﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        string[] recentFilesHistory = { };
        bool isChangesSaved = true;
        private ResourceDictionary currentLang = new ResourceDictionary();
        private ResourceDictionary currentTheme = new ResourceDictionary();

        public MainWindow()
        {
            InitializeComponent();
            this.SetDefaultEditorStyles();
            this.FindRecentOpenedFiles();
            PathStatus.Content = Directory.GetCurrentDirectory();
            this.currentLang.Source = new Uri("pack://application:,,,/lang/en.xaml");
            this.currentTheme.Source = new Uri("pack://application:,,,/theme/Default.xaml");
            var sri = Application.GetResourceStream(new Uri("pack://application:,,,/cursor.cur", UriKind.RelativeOrAbsolute));
            var customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
            WorkField.Cursor = customCursor;
            WorkField.AddHandler(RichTextBox.DragOverEvent, new DragEventHandler(WorkField_DragOver), true);
            WorkField.AddHandler(RichTextBox.DropEvent, new DragEventHandler(WorkField_Drop), true);
            //WorkField.AddHandler(MainWindow.ConditionalClickEvent, new RoutedEventHandler(CustomTextBox_ConditionalClick), true);
        }

        private void SetDefaultEditorStyles()
        {
            WorkField.FontFamily = new FontFamily(
                Regex.Replace(FontFamily.SelectedItem.ToString().Trim(), @".*:\s+", "")
            );
            WorkField.FontSize = Convert.ToDouble(
                Regex.Replace(FontSize.SelectedItem.ToString().Trim(), @".*:\s+", "")
            );
        }

        private void FindRecentOpenedFiles()
        {
            if (File.Exists("recentFiles.json"))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(string[]));
                using (FileStream fs = new FileStream("recentFiles.json", FileMode.Open))
                {
                    string[] restoredFilesHistory = (string[])serializer.ReadObject(fs);
                    if (restoredFilesHistory != null)
                        this.recentFilesHistory = restoredFilesHistory;
                }
                this.PrintRecentFiles();
            }
        }

        private void PrintRecentFiles()
        {
            OpenedFilesList.Items.Clear();
            foreach (string path in this.recentFilesHistory)
            {
                MenuItem menuItem = new MenuItem();
                menuItem.Header = path;
                menuItem.Click += this.OpenRecent_Click;
                OpenedFilesList.Items.Add(menuItem);
            }
        }

        /// 
        /// Handlers for manipulations with font
        /// 
        private void FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkField == null) return;
            ComboBox comboBox = (ComboBox)sender;
            string font = FontFamily.SelectedItem.ToString();
            this.ChangeSelectedTextProperty(
                TextElement.FontFamilyProperty, new FontFamily(Regex.Replace(font.Trim(), @".*:\s+", ""))
            );
        }

        private void FontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkField == null) return;
            ComboBox comboBox = (ComboBox)sender;
            string size = FontSize.SelectedItem.ToString();
            this.ChangeSelectedTextProperty(TextElement.FontSizeProperty, Regex.Replace(size.Trim(), @".*:\s+", ""));
        }

        private void FontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkField == null) return;
            ComboBox comboBox = (ComboBox)sender;
            string color = FontColor.SelectedItem.ToString();
            this.ChangeSelectedTextProperty(TextElement.ForegroundProperty, Regex.Replace(color.Trim(), @".*:\s+", ""));
        }

        /// 
        /// Handlers for changing font style/decorations
        /// 
        private void BoldToggle_Checked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextElement.FontWeightProperty, "Bold");
        }

        private void BoldToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextElement.FontWeightProperty, "Regular");
        }

        private void ItalicToggle_Checked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextElement.FontStyleProperty, "Italic");
        }

        private void ItalicToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextElement.FontStyleProperty, "Normal");
        }

        private void UnderlineToggle_Checked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextBox.TextDecorationsProperty, "Underline");
        }

        private void UnderlineToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextBox.TextDecorationsProperty, "None");
        }

        private void StrikeToggle_Checked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextBox.TextDecorationsProperty, "Strikethrough");
        }

        private void StrikeToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            this.ChangeSelectedTextProperty(TextBox.TextDecorationsProperty, "None");
        }

        private void ChangeSelectedTextProperty(DependencyProperty property, object value)
        {
            var selection = WorkField.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(property, value);
        }

        /// 
        /// Handlers for working with clipboard
        ///
        private void WorkField_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.isChangesSaved = false;
            TextRange text = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            int charactersNumber = Regex.Replace(text.Text, @"[\s\n\v\f\r]", "").Length;
            if (CharactersStatus != null)
                CharactersStatus.Content = charactersNumber;
        }

        /// 
        /// working with files
        /// 
        private void New_Click(object sender, RoutedEventArgs e)
        {
            if (!this.isChangesSaved)
            {
                var answer = MessageBox.Show(
                    "Are you sure? After this action all unsaved changes will disappear!",
                    "Warning!",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning
                );
                if (answer == MessageBoxResult.Cancel) return;
            }
            WorkField.Document.Blocks.Clear();
            window.Title = "New file";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            TextRange text = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (file.ShowDialog() == true)
            {
                using (FileStream fs = File.Create(file.FileName))
                {
                    string extension = System.IO.Path.GetExtension(file.FileName).ToLower();
                    if (extension == ".txt") text.Save(fs, DataFormats.Rtf);
                    else if (extension == ".rtf") text.Save(fs, DataFormats.Text);
                    else
                    {
                        MessageBox.Show(
                            "Wrong file extension!",
                            "Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                        );
                        return;
                    }
                }
                window.Title = GetFileName(file.FileName);
                this.SaveToRecentFilesHistory(file.FileName);
                this.isChangesSaved = true;
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            if (!this.isChangesSaved)
            {
                var answer = MessageBox.Show(
                    "Are you sure? After this action all unsaved changes will disappear!",
                    "Warning!",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning
                );
                if (answer == MessageBoxResult.Cancel) return;
            }

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (file.ShowDialog() == true)
            {
                bool isSuccesfully = this.ReadFromFile(file.FileName);
                if (isSuccesfully)
                    this.SaveToRecentFilesHistory(file.FileName);
            }
        }

        private void OpenRecent_Click(object sender, RoutedEventArgs e)
        {
            if (!this.isChangesSaved)
            {
                var answer = MessageBox.Show(
                    "Are you sure? After this action all unsaved changes will disappear!",
                    "Warning!",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning
                );
                if (answer == MessageBoxResult.Cancel) return;
            }

            MenuItem menuItem = sender as MenuItem;
            string filePath = menuItem.Header.ToString();
            if (menuItem != null && filePath != null)
            {
                bool isSuccesfully = this.ReadFromFile(filePath);
                if (isSuccesfully)
                    this.SaveToRecentFilesHistory(filePath);
            }
        }

        private static string GetFileName(string fullPath)
        {
            string fileName = Regex.Match(fullPath, @"\\[^\\]+\..+$").Value;
            fileName = Regex.Replace(fileName, @"\\", "");
            //fileName = Regex.Replace(fileName, @"\..+", "");

            return fileName;
        }

        private void SaveToRecentFilesHistory(string newPath)
        {
            // behavior:

            // if function received path which already exist in this.recentFilesHistory
                // => bubble it to first position

            // otherwise
                // if this.recentFilesHistory already have 10 files paths
                    // => remove the last one and add new item to the head

                // else add new item to the head
            // at the end save new history to file <recentFiles.json>

            if (this.recentFilesHistory.Contains(newPath))
            {
                this.recentFilesHistory = this.recentFilesHistory.Where(path => path != newPath).Prepend(newPath).ToArray();
            }
            else
            {
                if (this.recentFilesHistory.Length == 10)
                {
                    this.recentFilesHistory = this.recentFilesHistory
                        .Where((path, index) => index != this.recentFilesHistory.Length - 1)
                        .Prepend(newPath)
                        .ToArray();
                }
                else
                    this.recentFilesHistory = this.recentFilesHistory.Prepend(newPath).ToArray();
            }
            this.PrintRecentFiles();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(string[]));
            using (FileStream fs = new FileStream("recentFiles.json", FileMode.Create))
            {
                serializer.WriteObject(fs, this.recentFilesHistory);
            }
        }

        private bool ReadFromFile(string fullPath)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(fullPath, FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                this.RemoveRecentFilePath(fullPath);
                this.PrintRecentFiles();
                MessageBox.Show(
                    "The file doesn't exist! Check the path to file!",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                return false;
            }
            TextRange range = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            string extension = System.IO.Path.GetExtension(fullPath).ToLower();

            if (extension != ".rtf" && extension != ".txt")
            {
                MessageBox.Show(
                    "Wrong file extension!",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                return false;
            }
            range.Load(fs, DataFormats.Rtf);
            window.Title = GetFileName(fullPath);
            this.isChangesSaved = true;

            return true;
        }

        private void RemoveRecentFilePath(string pathToRemove)
        {
            this.recentFilesHistory = this.recentFilesHistory.Where(path => path != pathToRemove).ToArray();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(string[]));
            using (FileStream fs = new FileStream("recentFiles.json", FileMode.Create))
            {
                serializer.WriteObject(fs, this.recentFilesHistory);
            }
        }

        /// 
        /// support of multilanguage
        /// 
        private void RU_Click(object sender, RoutedEventArgs e)
        {
            this.SetNewResource(this.currentLang, "pack://application:,,,/lang/ru.xaml");
        }

        private void EN_Click(object sender, RoutedEventArgs e)
        {
            this.SetNewResource(this.currentLang, "pack://application:,,,/lang/en.xaml");
        }

        private void JP_Click(object sender, RoutedEventArgs e)
        {
            this.SetNewResource(this.currentLang, "pack://application:,,,/lang/jp.xaml");
        }

        /// 
        /// working with themes
        /// 
        private void DefaultTheme_Click(object sender, RoutedEventArgs e)
        {
            this.SetNewResource(this.currentTheme, "pack://application:,,,/theme/Default.xaml");
        }

        private void VueTheme_Click(object sender, RoutedEventArgs e)
        {
            this.SetNewResource(this.currentTheme, "pack://application:,,,/theme/VueTheme.xaml");
        }

        private void ReactTheme_Click(object sender, RoutedEventArgs e)
        {
            this.SetNewResource(this.currentTheme, "pack://application:,,,/theme/ReactTheme.xaml");
        }

        private void AngularTheme_Click(object sender, RoutedEventArgs e)
        {
            this.SetNewResource(this.currentTheme, "pack://application:,,,/theme/AngularTheme.xaml");
        }

        private void SetNewResource(ResourceDictionary oldResource, string newResourcePath)
        {
            Uri newSource = new Uri(newResourcePath);
            ResourceDictionary newResource = new ResourceDictionary();
            newResource.Source = newSource;
            this.Resources.MergedDictionaries.Remove(oldResource);
            this.Resources.MergedDictionaries.Add(newResource);
            oldResource.Source = newSource;
        }

        /// 
        /// make sure that all changes was saved
        /// 
        private void window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!this.isChangesSaved)
            {
                var answer = MessageBox.Show(
                    "Are you sure? After this action all unsaved changes will disappear!",
                    "Warning!",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning
                );

                if (answer == MessageBoxResult.Cancel)
                    e.Cancel = true;
                else e.Cancel = false;
            }
        }

        /// 
        /// working with drag-and-drop
        /// 
        private void WorkField_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.None;
            }
            else
            {
                e.Effects = DragDropEffects.All;
            }
            e.Handled = false;
        }

        private void WorkField_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);

                // By default, open as Rich Text (RTF).
                var dataFormat = DataFormats.Rtf;

                // If the Shift key is pressed, open as plain text.
                if (e.KeyStates == DragDropKeyStates.ShiftKey)
                {
                    dataFormat = DataFormats.Text;
                }

                System.Windows.Documents.TextRange range;
                System.IO.FileStream fStream;
                if (System.IO.File.Exists(docPath[0]))
                {
                    try
                    {
                        // Open the document in the RichTextBox.
                        range = new System.Windows.Documents.TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
                        fStream = new System.IO.FileStream(docPath[0], System.IO.FileMode.OpenOrCreate);
                        range.Load(fStream, dataFormat);
                        fStream.Close();
                        this.SaveToRecentFilesHistory(docPath[0]);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show(
                            "File could not be opened. Make sure the file is a text file.",
                            "Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                        );
                    }
                }
            }
        }

        private void CustomTextBox_ConditionalClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click on CustomTextBox");
        }

        private void window_ConditionalClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click on Window");
        }

        private void StackPanel1_ConditionalClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click on StackPanel");
        }
    }
}
