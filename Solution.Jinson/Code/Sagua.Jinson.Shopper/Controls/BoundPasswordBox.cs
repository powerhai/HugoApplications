using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sagua.Jinson.Shopper.Controls
{
    public class BoundPasswordBox
    {
        #region BoundPassword
        private static bool Updating = false;

        public static readonly DependencyProperty BoundPasswordProperty =
             DependencyProperty.RegisterAttached("BoundPassword",
                 typeof(string),
                 typeof(BoundPasswordBox),
                 new FrameworkPropertyMetadata(string.Empty, OnBoundPasswordChanged));
        public static string GetBoundPassword(DependencyObject d)
        {
            return (string)d.GetValue(BoundPasswordProperty);
        }

        public static void SetBoundPassword(DependencyObject d, string value)
        {
            d.SetValue(BoundPasswordProperty, value);
        }
        private static void OnBoundPasswordChanged(
           DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            if (password != null)
            {
                // Disconnect the handler while we're updating.
                password.PasswordChanged -= PasswordChanged;
            }

            if (e.NewValue != null)
            {
                if (!Updating)
                {
                    password.Password = e.NewValue.ToString();
                }
            }
            else
            {
                password.Password = string.Empty;
            }
            // Now, reconnect the handler.
            password.PasswordChanged += new RoutedEventHandler(PasswordChanged);
        }
        static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox password = sender as PasswordBox;
            Updating = true;
            SetBoundPassword(password, password.Password);
            Updating = false;
        }

        #endregion
    }
}
