//@Felipe Aguilera 15.771.527-5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace conBiblioteca.Clases
{
    public class PrestamoLibro:Prestamo
    {
        //Atributos
        private string genero;
        private string tapa;
        //Propiedades
        public string Genero
        {
            get { return genero; }
            set { genero= value; }
        }
        public string Tapa 
        {
            get { return tapa; }
            set { tapa= value; }
        }
        //Constructores
        public PrestamoLibro():base() { }
        public PrestamoLibro(string identificador, string titulo, int codigoISBN, string sede, string encargado, string genero, string tapa): 
                            base(identificador,titulo,codigoISBN,sede,encargado)
        {
            this.genero= genero;
            this.tapa= tapa;
        }
        public PrestamoLibro(PrestamoLibro p) :base(p)
        {
            this.genero= p.genero;
            this.tapa= p.tapa;
        }
        public PrestamoLibro(string prestamo) :base(prestamo)
        {
            string[] campo;
            campo = prestamo.Split(',');
            this.genero= campo[6];
            this.tapa= campo[7];
        }

        //Sobreescritura
        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\nGenero: ");
            sb.Append(this.genero);
            sb.Append("\nDe Tapa: ");
            sb.Append(this.tapa);
            return  sb.ToString();
        }
    }
}
