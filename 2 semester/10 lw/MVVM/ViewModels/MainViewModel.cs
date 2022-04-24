using _10_lw.MVVM.Classes;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _10_lw.MVVM.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string ConnectionString;
        private SqlDataAdapter Adapter;
        private DataTable StudentsTable;
        private DataTable LectorsTable;
        private DataTable DisciplinesTable;

        private Student selectedStudent;
        public ObservableCollection<Student> Students { get; set; }
        public Student SelectedStudent
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;
                OnPropertyChanged("SelectedStudent");
            }
        }

        private Lector selectedLector;
        public ObservableCollection<Lector> Lectors { get; set; }
        public Lector SelectedLector
        {
            get => selectedLector;
            set
            {
                selectedLector = value;
                OnPropertyChanged("SelectedLector");
            }
        }

        private Discipline selectedDiscipline;
        public ObservableCollection<Discipline> Disciplines { get; set; }
        public Discipline SelectedDiscipline
        {
            get => selectedDiscipline;
            set
            {
                selectedDiscipline = value;
                OnPropertyChanged("SelectedDiscipline");
            }
        }

        public MainViewModel()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Students = new ObservableCollection<Student>();
            Lectors = new ObservableCollection<Lector>();
            Disciplines = new ObservableCollection<Discipline>();

            PrintLectorsTable();
            PrintDisciplinesTable();
            PrintStudentsTable();
        }

        private void PrintLectorsTable()
        {
            Lectors.Clear();
            LectorsTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand("Select * from Lectors", connection);
                    Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(LectorsTable);
                    for (int i = 0; i < LectorsTable.Rows.Count; i++)
                    {
                        Lectors.Add(new Lector(
                            LectorsTable.Rows[i].ItemArray[1].ToString(),
                            LectorsTable.Rows[i].ItemArray[2].ToString(),
                            LectorsTable.Rows[i].ItemArray[3].ToString()));
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void PrintDisciplinesTable()
        {
            Disciplines.Clear();
            DisciplinesTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand("Select * from Disciplines", connection);
                    Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(DisciplinesTable);
                    for (int i = 0; i < DisciplinesTable.Rows.Count; i++)
                    {
                        command.CommandText = "Select Name, Surname, Patronimic from Lectors " +
                            $"Where id = {(int)DisciplinesTable.Rows[i].ItemArray[3]}";
                        SqlDataReader reader = command.ExecuteReader();

                        reader.Read();
                        if (!reader.HasRows) throw new Exception("lector read error");
                        string name = reader.GetString(0);
                        string surname = reader.GetString(1);
                        string patronimic = reader.GetString(2);
                        reader.Close();

                        Disciplines.Add(new Discipline(
                            DisciplinesTable.Rows[i].ItemArray[1].ToString(),
                            Convert.ToUInt16(DisciplinesTable.Rows[i].ItemArray[2]),
                            new Lector(name, surname, patronimic),
                            Convert.ToUInt16(DisciplinesTable.Rows[i].ItemArray[4])));
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    MessageBox.Show(er.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void PrintStudentsTable()
        {
            Students.Clear();
            StudentsTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand("Select * from Students", connection);
                    Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(StudentsTable);

                    for (int i = 0; i < StudentsTable.Rows.Count; i++)
                    {
                        Discipline discipline = null;
                        if (StudentsTable.Rows[i].ItemArray[3].ToString() != "")
                        {
                            command.CommandText = "Select * from Disciplines " +
                              $"Where id = {(int)StudentsTable.Rows[i].ItemArray[3]}";
                            SqlDataReader reader = command.ExecuteReader();

                            reader.Read();
                            if (!reader.HasRows) throw new Exception("discipline read error");
                            string name = reader.GetString(1);
                            ushort hours = (ushort)reader.GetInt32(2);
                            int lectorId = reader.GetInt32(3);
                            ushort listeners = (ushort)reader.GetInt32(4);
                            reader.Close();

                            command.CommandText = "Select Name, Surname, Patronimic from Lectors " +
                                $"Where id = {lectorId}";
                            SqlDataReader reader1 = command.ExecuteReader();

                            reader1.Read();
                            if (!reader1.HasRows) throw new Exception("lector read error");
                            string lector_name = reader1.GetString(0);
                            string surname = reader1.GetString(1);
                            string patronimic = reader1.GetString(2);
                            reader1.Close();

                            discipline = new Discipline(name, hours, new Lector(lector_name, surname, patronimic), listeners);
                        }
                       

                        Students.Add(new Student(
                            StudentsTable.Rows[i].ItemArray[0].ToString(),
                            StudentsTable.Rows[i].ItemArray[1].ToString(),
                            StudentsTable.Rows[i].ItemArray[2].ToString(),
                            discipline));
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    MessageBox.Show(er.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(obj =>
                    {
                        DisciplinesTable = new DataTable();
                        StudentsTable = new DataTable();

                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            try
                            {
                                if (SelectedStudent == null || SelectedLector == null)
                                    throw new Exception("Необходимо выбрать студента и лектора!");

                                connection.Open();
                                string studentDiscipline = null;

                                if (SelectedStudent.ActiveDiscipline != null)
                                    studentDiscipline = SelectedStudent.ActiveDiscipline.Name;

                                string lectorDiscipline =
                                    Disciplines.Where(d => d.Lector.Name == SelectedLector.Name &&
                                        d.Lector.Surname == SelectedLector.Surname).FirstOrDefault().Name;

                                if (studentDiscipline == lectorDiscipline)
                                    return;

                                var command = new SqlCommand("Select id from Lectors " +
                                            $"where Name = '{SelectedLector.Name}' and Surname = '{selectedLector.Surname}'", connection);

                                SqlDataReader reader = command.ExecuteReader();
                                reader.Read();
                                int lectorId = reader.GetInt32(0);
                                reader.Close();

                                command.CommandText = "Select * from Disciplines " +
                                    $"Where Lector = {lectorId}";

                                SqlDataReader reader1 = command.ExecuteReader();
                                reader1.Read();
                                int disciplineId = reader1.GetInt32(0);
                                string disciplineName = reader1.GetString(1);
                                ushort hours = (ushort)reader1.GetInt32(2);
                                ushort listeners = (ushort)reader1.GetInt32(4);
                                reader1.Close();

                                command.CommandText =
                                    "UPDATE Disciplines set " +
                                    "ListenersCount = ListenersCount + 1 " +
                                    $"Where Lector = {lectorId};" +

                                    $"UPDATE Students set " +
                                    $"ActiveDiscipline = {disciplineId} " +
                                    $"Where Name = '{SelectedStudent.Name}' and Surname = '{SelectedStudent.Surname}';";

                                if (studentDiscipline != null)
                                {
                                    command.CommandText +=
                                        "UPDATE Disciplines set " +
                                        "ListenersCount = ListenersCount - 1 " +
                                        $"Where Name = '{SelectedStudent.ActiveDiscipline.Name}';";

                                    Disciplines
                                        .Where(d => d.Name == SelectedStudent.ActiveDiscipline.Name)
                                        .FirstOrDefault().ListenersCount--;
                                }

                                command.ExecuteNonQuery();

                                Discipline discipline = Disciplines
                                    .Where(d => d.Name == disciplineName)
                                    .FirstOrDefault();
                                discipline.ListenersCount += 1;

                                Students
                                    .Where(s => s.Name == SelectedStudent.Name && s.Surname == SelectedStudent.Surname)
                                    .FirstOrDefault().ActiveDiscipline = discipline;


                                var command1 = new SqlCommand("Select * from Students", connection);
                                Adapter = new SqlDataAdapter(command1);
                                Adapter.Fill(StudentsTable);

                                var command2 = new SqlCommand("Select * from Disciplines", connection);
                                Adapter = new SqlDataAdapter(command2);
                                Adapter.Fill(DisciplinesTable);

                                command.Cancel();

                                PrintDisciplinesTable();
                                PrintStudentsTable();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally { connection.Close(); }
                        }
                    });
                }

                return addCommand;
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                if (removeCommand == null)
                {
                    removeCommand = new RelayCommand(obj =>
                    {
                        DisciplinesTable = new DataTable();
                        StudentsTable = new DataTable();

                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            try
                            {
                                if (SelectedStudent == null)
                                    throw new Exception("Необходимо выбрать студента!");

                                if (selectedStudent.ActiveDiscipline == null)
                                    throw new Exception("Студент еще не записан на дисциплину!");

                                connection.Open();
                                var command = new SqlCommand("Update Disciplines " +
                                    $"set ListenersCount = ListenersCount - 1 " +
                                    $"where Name = '{SelectedStudent.ActiveDiscipline.Name}';" +

                                    $"Update Students " +
                                    $"set ActiveDiscipline = NULL " +
                                    $"Where Name = '{SelectedStudent.Name}' and Surname = '{SelectedStudent.Surname}'", connection);
                                command.ExecuteNonQuery();

                                Disciplines
                                    .Where(d => d.Name == SelectedStudent.ActiveDiscipline.Name)
                                    .FirstOrDefault().ListenersCount--;
                                Students
                                    .Where(s => s.Name == SelectedStudent.Name && s.Surname == SelectedStudent.Surname)
                                    .FirstOrDefault().ActiveDiscipline = null;

                                var command1 = new SqlCommand("Select * from Students", connection);
                                Adapter = new SqlDataAdapter(command1);
                                Adapter.Fill(StudentsTable);

                                var command2 = new SqlCommand("Select * from Disciplines", connection);
                                Adapter = new SqlDataAdapter(command2);
                                Adapter.Fill(DisciplinesTable);

                                command.Cancel();

                                PrintDisciplinesTable();
                                PrintStudentsTable();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    });
                }

                return removeCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
