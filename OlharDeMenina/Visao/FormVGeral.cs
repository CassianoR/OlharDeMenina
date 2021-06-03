using System.Drawing;
using System.Windows.Forms;

namespace OlharDeMenina.Visao
{
    public partial class FormVGeral : Form
    {
        public FormVGeral()
        {
            InitializeComponent();
        }
        public System.Drawing.Size Size { get; set; }
        public System.Drawing.Point Location { get; set; }
        Form1 form = new Form1();

        private void FormVGeral_Load(object sender, System.EventArgs e)
        {

        }

    }
}