using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTecnologias.Code.DTO
{
    class EmpresaDTO
    {
        private int _codigo;
        private string _nome;
        private string _dono;
        private string _criacao;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Dono { get => _dono; set => _dono = value; }
        public string Criacao { get => _criacao; set => _criacao = value; }
    }
}
