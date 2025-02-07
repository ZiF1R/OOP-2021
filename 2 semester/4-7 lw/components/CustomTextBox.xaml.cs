﻿using System;
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
    /// Логика взаимодействия для CustomTextBox.xaml
    /// </summary>
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty PlaceholderProperty =
        DependencyProperty.Register(
           name: "Placeholder",
           propertyType: typeof(string),
           ownerType: typeof(CustomTextBox),
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
        }

        private static object CoercePlaceholder(DependencyObject depObj, object value)
        {
            string currentVal = (string)value;
            return currentVal = currentVal == "" ?
                (string)PlaceholderProperty.DefaultMetadata.DefaultValue :
                currentVal;
        }

        void CustomTextBox_Click(object sender, RoutedEventArgs e)
        {
            RaiseClickEvent();
        }

        public static readonly RoutedEvent ClickEvent =
           EventManager.RegisterRoutedEvent("CustomClick", RoutingStrategy.Bubble,
           typeof(RoutedEventHandler), typeof(CustomTextBox));

        public event RoutedEventHandler Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        protected virtual void RaiseClickEvent()
        {
            RoutedEventArgs args = new(routedEvent: ClickEvent);
            RaiseEvent(args);
        }
    }
}
