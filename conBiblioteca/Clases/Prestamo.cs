//@Felipe Aguilera 15.771.527-5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace conBiblioteca.Clases
{
    public class Prestamo
    {
        //Atributos
        private string identificador;
        private string titulo;
        private int codigoISBN;
        private string sede;
        private string encargado;

        //Propiedades
        public string Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int CodigoISBN
        {
            get { return codigoISBN; }
            set { codigoISBN = value;}
        }
        public string Sede
        {
            get { return sede; }
            set {sede = value; }
        }
        public string Encargado
        {
            get { return encargado; }
            set {encargado = value; }
        }

        //Constructores
        public Prestamo() { }
        public Prestamo(string identificador, string titulo, int codigoISBN, string sede, string encargado)
        {
            this.identificador = identificador;
            this.titulo = titulo;
            this.codigoISBN = codigoISBN;
            this.sede = sede;
            this.encargado = encargado;
        }
        public Prestamo(string prestamo)
        {
            string[] campo = prestamo.Split(',');
            this.identificador = campo[1]; 
            this.titulo= campo[2];
            int.TryParse(campo[3], out codigoISBN);
            this.sede= campo[4];
            this.encargado= campo[5];
        }
         public Prestamo(Prestamo p)
        {
            this.identificador= p.identificador;
            this.titulo= p.titulo;
            this.codigoISBN= p.codigoISBN;
            this.sede= p.sede;
            this.encargado= p.encargado;
        }
        //Sobreescritura
        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("Numero Id: ");
            sb.Append(this.identificador);
            sb.Append("\tTitulo: ");
            sb.Append(this.titulo);
            sb.Append("\tCodigo ISBN: ");
            sb.Append(this.codigoISBN);
            sb.Append("\tSede: ");
            sb.Append(this.sede);
            sb.Append("\tBibliotecario encargado: ");
            sb.Append(this.encargado);
            return sb.ToString();
        }
    }
}
