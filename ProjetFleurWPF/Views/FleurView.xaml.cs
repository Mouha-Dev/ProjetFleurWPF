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
using ProjetFleurWPF.ViewModels;


namespace ProjetFleurWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour FleurView.xaml
    /// </summary>
    public partial class FleurView : UserControl
    {
        public FleurView()
        {
            InitializeComponent();
            this.DataContext = new FleurViewModel();
        }
    }
}
