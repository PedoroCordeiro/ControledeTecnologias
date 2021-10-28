using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleTecnologias.Code.BLL;
using ControleTecnologias.Code.DTO;

namespace ControleTecnologias
{
    public partial class FormEmpresas : System.Windows.Forms.Form
    {
        EmpresaBLL objBLL = new EmpresaBLL();
        EmpresaDTO objDTO = new EmpresaDTO();
        public FormEmpresas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objDTO.Nome = txtNome.Text;
            objDTO.Dono = txtDono.Text;
            objDTO.Dono = txtCriacao.Text;
            objBLL.Inserir(objDTO);
        }
    }
}
