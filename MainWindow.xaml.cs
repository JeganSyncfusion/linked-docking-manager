using System;
using System.Collections.Generic;
using System.Linq;
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

namespace LinkedDockingManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 dockWindow2 = new Window1();

        public MainWindow()
        {
            InitializeComponent();
            dockWindow2.Show();

            this.dockingManager1.AddToTargetManagersList(dockWindow2.dockingManager2);
            dockWindow2.dockingManager2.AddToTargetManagersList(this.dockingManager1);
        }

        private void Save_Clicked(object sender, RoutedEventArgs e)
        {
            dockWindow2.dockingManager2.SaveDockState("File1.xml");
            dockingManager1.SaveDockState("File2.xml");
        }

        private void Load_Clicked(object sender, RoutedEventArgs e)
        {
            dockWindow2.dockingManager2.LoadDockState("File1.xml");
            dockingManager1.LoadDockState("File2.xml");
        }
    }
}
