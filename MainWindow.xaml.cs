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
using System.Collections.Generic;

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
            //get the user input
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);



            //the if statements below go through the possible scenarios, covering the edge cases.
            if (num1 < num2 && num1 >= 2)
            {
                int timeRequired = TimeCalculator.TimeCalculation(num1, num2); //call time calculator method
                MessageBox.Show($"You need {2 * (num2 - num1)} resources in order to get {num2} animals.\n" +
                    $"This may take {timeRequired} minutes to do!");
            }
            else if (num1 >= num2)
            {
                MessageBox.Show($"You need to kill {num1 - num2} animal(s) in order to get {num2} animals"); 
            }
            else if(num1 < 2)
            {
                MessageBox.Show("You can't get over 1 animal with under 2 animals! You need to get looking for more.");
            }
            else if (num2 < 0)
            {
                MessageBox.Show("You cannot get negative animals!");
            }
             
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) //this is here just to cover the errors.
        {
          
        }
    }
}