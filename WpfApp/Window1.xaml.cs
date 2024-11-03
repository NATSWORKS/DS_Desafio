using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows;
using DS_Desafio;
using Microsoft.Extensions.Options;
using static DS_Desafio.TaskModel;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly HttpClient _httpClient;

        /*
        ========================
        Window1
        ------------------------
        Inicializador.
        ========================
        */
        public Window1()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7072/") }; // URL da API ASP.NET
        }

        /*
        ========================
        BtnCreate_Click
        ------------------------
        Cria cadastro no banco de dados.
        ========================
        */
        private async void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newTask = new TaskModel
                {
                    Title = tbTitle.Text,
                    Description = tbDesc.Text,
                    DateCreated = DateTime.Now,
                    DateConclusion = dpData.SelectedDate,
                    Status = StatusE.Pendente
                };

                var response = await _httpClient.PostAsJsonAsync("api/task/add", newTask);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tarefa criada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao criar a tarefa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
