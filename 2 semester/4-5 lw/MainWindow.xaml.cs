using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SetDefaultEditorStyles();
            window.Title += " ・ " + Directory.GetCurrentDirectory();
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
        /// RichBox's changes history manipulation
        /// 
        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Undo();
        }

        private void RedoButton_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Redo();
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
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Copy();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Paste();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Cut();
        }

        private void WorkField_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRange text = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            int charactersNumber = Regex.Replace(text.Text, @"[\s\n\v\f\r]", "").Length;
            if (CharactersStatus != null)
                CharactersStatus.Content = $"Characters: {charactersNumber}";
        }

        /// 
        /// working with files
        /// 
        private void New_Click(object sender, RoutedEventArgs e)
        {
            var answer = MessageBox.Show(
                "Are you sure? After this action all changes will disappear!",
                "Warning!",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Warning
            );

            if (answer == MessageBoxResult.OK)
            {
                WorkField.Document.Blocks.Clear();
                window.Title = "New file ・ " + Directory.GetCurrentDirectory();
            }
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
                window.Title = this.GetFileName(file) + " ・ " + Directory.GetCurrentDirectory();
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            var answer = MessageBox.Show(
                "Are you sure? After this action all changes will disappear!",
                "Warning!",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Warning
            );
            if (answer == MessageBoxResult.Cancel) return;

            TextRange text = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (file.ShowDialog() == true)
            {
                FileStream fs = new FileStream(file.FileName, FileMode.Open);
                TextRange range = new TextRange(WorkField.Document.ContentStart, WorkField.Document.ContentEnd);
                string extension = System.IO.Path.GetExtension(file.FileName).ToLower();

                if (extension != ".rtf" && extension != ".txt")
                {
                    MessageBox.Show(
                        "Wrong file extension!",
                        "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error
                    );
                    return;
                }
                range.Load(fs, DataFormats.Rtf);
                window.Title = this.GetFileName(file) + " ・ " + Directory.GetCurrentDirectory();
            }
        }

        private string GetFileName(SaveFileDialog file)
        {
            string fileName = Regex.Match(file.FileName, @"\\[^\\]+\..+$").Value;
            fileName = Regex.Replace(fileName, @"\\", "");
            //fileName = Regex.Replace(fileName, @"\..+", "");

            return fileName;
        }

        private string GetFileName(OpenFileDialog file)
        {
            string fileName = Regex.Match(file.FileName, @"\\[^\\]+\..+$").Value;
            fileName = Regex.Replace(fileName, @"\\", "");
            //fileName = Regex.Replace(fileName, @"\..+", "");

            return fileName;
        }

        /// 
        /// support of multilanguage
        /// 
        private void RU_Click(object sender, RoutedEventArgs e)
        {
            Language.Source = new Uri("pack://application:,,,/lang/ru.xaml");
        }

        private void EN_Click(object sender, RoutedEventArgs e)
        {
            Language.Source = new Uri("pack://application:,,,/lang/en.xaml");
        }

        private void JP_Click(object sender, RoutedEventArgs e)
        {
            Language.Source = new Uri("pack://application:,,,/lang/jp.xaml");
        }

        /// 
        /// make sure that all changes was saved
        /// 
        private void window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var answer = MessageBox.Show(
                "Are you sure? After this action all changes will disappear!",
                "Warning!",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Warning
            );

            if (answer == MessageBoxResult.Cancel)
                e.Cancel = true;
            else e.Cancel = false;
        }
    }
}
