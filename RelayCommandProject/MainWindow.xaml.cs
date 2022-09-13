using RelayCommandProject.Commands;
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

namespace RelayCommandProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(MainWindow), new PropertyMetadata(0));



        public RelayCommand SendCommand { get; set; }
        public RelayCommand SendCommand2 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

           
            //SendCommand = new RelayCommand(Display);

            SendCommand = new RelayCommand(Display, param =>
            {
                return Age > 30;
            });


            SendCommand2 = new RelayCommand(DisplayDouble);
        }

        private void Display(object obj)
        {
            MessageBox.Show("Hello RelayCommand Send");
        }
        private void DisplayDouble(object obj)
        {
            MessageBox.Show("You clicked like Double");
        }
    }
}
