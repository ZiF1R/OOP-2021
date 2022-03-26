using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace test.components
{
    public class CustomRoutedEvent : Button
    {
        public static readonly RoutedEvent ConditionalClickEvent = EventManager.RegisterRoutedEvent(
          name: "ConditionalClick",
          routingStrategy: RoutingStrategy.Bubble,
          handlerType: typeof(RoutedEventHandler),
          ownerType: typeof(CustomRoutedEvent)
        );

        public event RoutedEventHandler ConditionalClick
        {
            add { AddHandler(ConditionalClickEvent, value); }
            remove { RemoveHandler(ConditionalClickEvent, value); }
        }

        void RaiseCustomRoutedEvent()
        {
            RoutedEventArgs routedEventArgs = new(routedEvent: ConditionalClickEvent);
            RaiseEvent(routedEventArgs);
        }

        protected override void OnClick()
        {
            RaiseCustomRoutedEvent();
            base.OnClick();
        }
    }
}
