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

namespace MinecraftBreedingCalculatorGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         }

        private void Button_Click(object sender, RoutedEventArgs e) //when the button is clicked we activate this. it will shut the program down after 20 seconds.
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            if (num1 < num2 && num1 >= 2)
            {
                MessageBox.Show($"You need {2 * (num2 - num1)} resources in order to get {num2} animals");
            }
            else if (num1 >= num2)
            {
                MessageBox.Show($"You need to kill {num1 - num2} animal(s) in order to get {num2} animals");
            }
            else
            {
                MessageBox.Show("You can't get over 1 animal with just 1 animal! You need to get looking for more.");
            }
            Thread.Sleep(20000);
            Application.Current.Shutdown(); //no need to have the app open anymore.
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }
    }
}