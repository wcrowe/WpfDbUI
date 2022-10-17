﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfInotify.ViewModel
{
    public class PersonViewModel : ObservableObject
    {
        private string _name;

        public string Name
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_name))
                    return "Unknown";

                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }



        // snippet propdp
        //public int MyProperty
        //{
        //    get { return (int)GetValue(MyPropertyProperty); }
        //    set { SetValue(MyPropertyProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty MyPropertyProperty =
        //    DependencyProperty.Register("MyProperty", typeof(int), typeof(ownerclass), new PropertyMetadata(0));


    }
}
