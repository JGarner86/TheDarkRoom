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
using System.Windows.Shapes;
using TagEngineLib;

namespace DarkRoomGame
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        EnemyModel Sliter = new EnemyModel();
        EnemyModel Ghost = new EnemyModel();
        TextBlock jackdialog = new TextBlock();
        public GameWindow()
        {
            InitializeComponent();
           
            Sliter.Name = "Sliter";
            Ghost.Name = "Jack";
            Sliter.Health = 100;
           

        }

        private void TalkButton_Click(object sender, RoutedEventArgs e)
        {
            GameDialog.Text = "My Name Is " + Sliter.Name;
            GameDialog.FontSize = 50;
            jackdialog.Text = "My Name Is " + Ghost.Name;
            Ghost.TakePotion(50);




        }
    }


}
