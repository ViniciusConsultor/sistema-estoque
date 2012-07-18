using System.Windows.Forms;

namespace Estoque.View
{
    public partial class frmCadFornecedor : Form
    {

       string strConn = string.Empty;

        public frmCadFornecedor(string connection)
        {
            InitializeComponent();
           this.strConn = connection;
        }

        private void frmCadFornecedor_Load(object sender, System.EventArgs e)
        {

        }
    }
}
