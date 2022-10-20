using global::System;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Text;
using global::System.Threading.Tasks;
using global::System.Windows;
using global::System.Windows.Controls;
using global::System.Windows.Data;
using global::System.Windows.Documents;
using global::System.Windows.Input;
using global::System.Windows.Media;
using global::System.Windows.Media.Imaging;
using global::System.Windows.Navigation;
using global::System.Windows.Shapes;

namespace WpfBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : global::System.Windows.Window
    { 
        public Notes? Notes { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            var dc = new global::WpfBindingExample.DataClass();
            DataContext = dc.GetNotes();
        }
    }
}
