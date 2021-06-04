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

namespace Random_Menu_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        public void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Breads = new string[]
                    {
                        "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"
                    };
                }

                menuItems[i].Generate();
            }

            Item1.Text = menuItems[0].Description;
            Price1.Text = menuItems[0].Price;
            Item2.Text = menuItems[1].Description;
            Price2.Text = menuItems[1].Price;
            Item3.Text = menuItems[2].Description;
            Price3.Text = menuItems[2].Price;
            Item4.Text = menuItems[3].Description;
            Price4.Text = menuItems[3].Price;
            Item5.Text = menuItems[4].Description;
            Price5.Text = menuItems[4].Price;

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] {"A glutton free roll", "a wrap", "pita"},
                Condiments = new string[] {"dijon mustard", "miso dressing", "au jus"}
            };
            specialMenuItem.Generate();

            Item6.Text = specialMenuItem.Description;
            Price6.Text = specialMenuItem.Price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;

            guacomole.Text = " Add guacamole for " + guacamolePrice;
        }
    }
}
