using System;
using System.Collections.Generic;
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

namespace _4_5_lw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SetDefaultEditorStyles();
        }

        private void SetDefaultEditorStyles()
        {
            WorkField.FontFamily = new FontFamily(
                Regex.Replace(FontFamily.SelectedItem.ToString().Trim(), @".*:\s+", ""
            ));
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
            if (CharactersStatus != null)
                CharactersStatus.Content = $"Characters: {text.Text.Length - 3}";
        }
    }
}
