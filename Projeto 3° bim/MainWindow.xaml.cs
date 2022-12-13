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

namespace Projeto_3__bim
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

        private void AddTime_Click(object sender, RoutedEventArgs e)
        {
            Time lista = new Time(NomeTime.Text, EstadoTime.Text);
            MessageBox.Show("Time Cadastrado.");
        }

        private void AddJogador_Click(object sender, RoutedEventArgs e)
        {
            int gols = int.Parse(Gols.Text);
            Jogador j1 = new Jogador(NomeJogador.Text, Camisa.Text, gols);
            MessageBox.Show("Jogador Cadastrado.");
        }
        
    }
}
