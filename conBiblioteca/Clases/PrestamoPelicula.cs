//@Felipe Aguilera 15.771.527-5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conBiblioteca.Clases
{
    public class PrestamoPelicula:Prestamo
    {
        //Atributos
        private int diasPrestamo;
        private string tipoPeli;

        //Propiedades
        public int DiasPrestamo
        {
            get { return diasPrestamo; }
            set { diasPrestamo = value;}
        }
        public string TipoPeli
        {
            get { return tipoPeli; }
            set { tipoPeli = value; }
        }

        //Constructores
        public PrestamoPelicula() : base() { }
        public PrestamoPelicula(string identificador, string titulo, int codigoISBN, string sede, string encargado, int diasPrestamo, string tipoPeli) :
                                base(identificador,titulo,codigoISBN,sede,encargado) 
        {
            this.diasPrestamo= diasPrestamo;
            this.tipoPeli= tipoPeli;
        }
        public PrestamoPelicula(PrestamoPelicula pp):base(pp) 
        {
            this.diasPrestamo = pp.diasPrestamo;
            this.tipoPeli = pp.tipoPeli;    
        }
        public PrestamoPelicula(string prestamo) :base(prestamo)       
        {
            string[] campo = prestamo.Split(',');
            this.tipoPeli = campo[6];
            int.TryParse(campo[7],out this.diasPrestamo);
        }

        //Sobreescribir
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\nTipo de Pelicula: ");
            sb.Append(this.tipoPeli);
            sb.Append("\nDias prestados: ");
            sb.Append(this.diasPrestamo);
            return sb.ToString();
        }

        //Metodo
        public void AumentarDias()
        {
             this.diasPrestamo += 1;
        }
    }
}
