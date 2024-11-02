using System;
using System.Windows;
using DS_Desafio;
using Microsoft.Extensions.Options;
using static DS_Desafio.Task;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly TaskDb _context;

        public Window1(TaskDb context)
        {
            InitializeComponent();
            _context = context;
        }

        private async void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            var newTask = new DS_Desafio.Task// Cria uma Task
            {
                Title = tbTitle.Text,
                Description = tbDesc.Text,
                DateCreated = DateTime.Now,
                DateConclusion = dpData.SelectedDate,
                Status = StatusE.Pendente
            };

            _context.Tasks.Add(newTask);  // Adiciona a nova task ao contexto
            await _context.SaveChangesAsync();  // Salva as mudanças no banco de dados
        }
    }
}
