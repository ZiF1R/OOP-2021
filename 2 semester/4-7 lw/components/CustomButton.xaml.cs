using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace test.components
{
    /// <summary>
    /// Логика взаимодействия для CustomButton.xaml
    /// </summary>
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty PlaceholderProperty =
        DependencyProperty.Register(
           name: "Placeholder",
           propertyType: typeof(string),
           ownerType: typeof(CustomButton),
           typeMetadata: new FrameworkPropertyMetadata(
               defaultValue: "Default value",
               flags: FrameworkPropertyMetadataOptions.AffectsMeasure,
               propertyChangedCallback: new PropertyChangedCallback(OnPlaceholderChanged),
               coerceValueCallback: new CoerceValueCallback(CoercePlaceholder)
           ),
           validateValueCallback: new ValidateValueCallback(IsValidReading));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public static bool IsValidReading(object value)
        {
            string val = (string)value;
            return val.All(ch => ch != '.');
        }

        private static void OnPlaceholderChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            depObj.CoerceValue(PlaceholderProperty);
            depObj.CoerceValue(PlaceholderProperty);
        }

        private static object CoercePlaceholder(DependencyObject depObj, object value)
        {
            string currentVal = (string)value;
            return currentVal = currentVal == "" ?
                (string)PlaceholderProperty.DefaultMetadata.DefaultValue :
                currentVal;
        }

        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
            "Tap", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomButton));

        // Provide CLR accessors for the event
        public event RoutedEventHandler Tap
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }
    }
}
