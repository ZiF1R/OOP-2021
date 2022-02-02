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
        }

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

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Undo();
        }

        private void RedoButton_Click(object sender, RoutedEventArgs e)
        {
            WorkField.Redo();
        }

        private void ChangeSelectedTextProperty(DependencyProperty property, object value)
        {
            var selection = WorkField.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(property, value);
        }
    }
}
