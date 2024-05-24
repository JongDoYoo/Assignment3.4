using Accessibility;
using Assignment3._4;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Coffee> coffeeList = new List<Coffee>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Coffee coffee = new Coffee();
                  
            //you have to create a name of the textbox with x:Name= " " The "this.Americano.text" is the name of the textbox in XAML 

            if (String.IsNullOrEmpty(this.Americano.Text))
            {
                MessageBox.Show("You must enter yes for an Americano", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                coffee.Americano = this.Americano.Text;
            }
            if (String.IsNullOrEmpty(this.Latte.Text))
            {
                MessageBox.Show("You must enter yes for Latte", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                coffee.Latte = this.Latte.Text;
            }
            if (String.IsNullOrEmpty(this.Macchiato.Text))
            {
                MessageBox.Show("You must enter yes for Macchiato", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                coffee.macchiato = this.Macchiato.Text;
            }
            //This is adding all of the objects fromt he class "coffee" and adding it to this list below. This will happen whenevber the method is called out or used
            coffeeList.Add(coffee);
        }

      
    }
    
    
   
    
}