using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Nancy.Json;
using System.Data;

namespace KONTROL
{
    public partial class ObjectsForm : Form
    {
        // Свойство BindingSource будет использоваться для связывания данных из списка объектов типа objData с DataGridView
        private BindingSource bindingSource = new BindingSource();
        private List<objData> data = new List<objData>();

        public ObjectsForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = bindingSource;

            ToolTip bcf = new ToolTip();
            bcf.SetToolTip(buttonBackToChoiceForm, "Вернуться назад к выбору действий");
        }

        async void ObjectsForm_Load(object sender, EventArgs e)
        {
            // Асинхронно выгружаются в таблицу данные с базы при открытии формы
            data = await GetDataAsync();
            bindingSource.DataSource = data;
            //dataGridView1.Columns[0].Width = 28;
            dataGridView1.ReadOnly = true; // Только чтение таблицы
            dataGridView1.AutoGenerateColumns = true;

        }

        // Асинхронный метод, который использует HttpClient для отправки запроса к файлу database.php и получения данных в формате JSON
        public async Task<List<objData>> GetDataAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost/objects.php"); // Подключаемся к PHP
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<objData>>(responseBody);
            }

        }

        // Данные десериализуются в список объектов типа objData
        public class objData
        {
            [DisplayName("№")] // Имя столбца
            public int id { get; set; }
            [DisplayName("Название объекта")]
            public string name { get; set; }
            [DisplayName("Адрес")]
            public string address { get; set; }

            public objData(int object_id, string object_name, string object_address)
            {
                id = object_id;
                name = object_name;
                address = object_address;
            }

        }

        // Принимаем текстовый параметр заголовка из формы ChoiceForm в метод в качестве аргумента 
        public void SetText(string text)
        {
            if (text != null)
            {
                Text = text;
            }
        }

        async void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[row];
            string? name = selectedRow.Cells["name"].Value.ToString(); // Здесь "name" - это название столбца в таблице

            string url = "http://localhost/contracts.php?name=" + name;

            string response = await GetResponseAsync(url);

            if (response.Contains("error"))
            {
                // Если есть ошибки, выводит сообщение об ошибке и завершает метод
                MessageBox.Show("Произошла ошибка при получении данных из базы");
                return;
            }

            if (name != null)
            {
                dataGridView1.Visible = false;
            }

            /*            ContractsObjectsForm form = new ContractsObjectsForm(response);
                        form.contrData = response;
                        form.Show();*/

            if (name != null)
            {
                // Вызываем метод формы и передаем ему выбранный элемент списка
                string selectItem = name;
                ContractsObjectsForm cof = new(response);
                cof.SetTextCOF(selectItem);
                cof.ShowDialog();
            }
        }

        async Task<string> GetResponseAsync(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            // Добавляем обработку ошибок
            if (responseBody.Contains("error"))
            {
                responseBody = "{\"error\": \"Произошла ошибка при запросе к базе\"}";
            }

            return responseBody;
        }

        private void buttonBackToChoiceForm_Click(object sender, EventArgs e)
        {
            //Close();
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*            string selectedCellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                        ContractsObjectsForm form2 = new ContractsObjectsForm(selectedCellValue);
                        form2.Show();*/
        }
    }
}
