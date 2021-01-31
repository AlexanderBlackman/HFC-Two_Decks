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

namespace HFC_Two_Decks
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

        private void MoveCard(bool leftToRight)
        {
            if ((Resources["rightDeck"] is Deck rightDeck) && (Resources["leftDeck"] is Deck leftDeck)) { 
            if (leftToRight) { 
                if (d1_listBox.SelectedItem is Card card) 
                {
                    leftDeck.Remove(card);
                    rightDeck.Add(card);
                } } else
                {
                    if (d2_listBox.SelectedItem is Card card)
                    {
                        rightDeck.Remove(card);
                        leftDeck.Add(card);
                    }
                }
            }
        }

        private void shuffleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void d1_listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void d2_listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void d2_listBox_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.Key == Key.Enter)
            {
                MoveCard(false);
            }
        }

        private void d1_listBox_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.Key == Key.Enter)
            {
                MoveCard(true);
            }
        }
    }
}
