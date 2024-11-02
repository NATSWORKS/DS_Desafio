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

namespace WpfApp
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

        #region Buttons
        /*
        ========================
        btnAddTarefa_Click
        ------------------------
        Abre a janela para criar tarefa.
        ========================
        */
        private void btnAddTarefa_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        /*
        ========================
        btnSearch_Click
        ------------------------
        Pesquisa tarefas no banco de dados.
        ========================
        */
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}