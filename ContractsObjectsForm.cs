using Newtonsoft.Json;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Windows.Forms;
using static KONTROL.ObjectsForm;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KONTROL
{
    public partial class ContractsObjectsForm : Form
    {
        //public string contrData { get; set; }
        public string name { get; set; }

        public ContractsObjectsForm(string name)
        {
            InitializeComponent();

            Name = name;
            /*            DataTable contrData = JsonConvert.DeserializeObject<DataTable>(response);
                        dataGridView1.DataSource = contrData;*/
            MessageBox.Show(name);
        }

        public void SetTextCOF(string text)
        {
            if (text != null)
            {
                Text = ($"Список договоров по объекту {text}");
            }
        }

        private void ContractsObjectsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
