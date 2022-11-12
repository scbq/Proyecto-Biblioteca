//@Felipe Aguilera 15.771.527-5
using conBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace conBiblioteca.Colecciones
{
    public class Biblioteca
    {
        //Atributos y lista
        private string nombre;
        private string sede;
        private List<Prestamo> bibloteca;

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sede
        {
            get { return sede; } 
            set { sede = value; }
        }
        
        //Constructores
        public Biblioteca()
        {
            this.nombre= string.Empty;
            this.Sede= string.Empty;
            bibloteca= new List<Prestamo>();
        }
        public Biblioteca(string nombre,string sede,string archivo)
        {
            this.nombre= nombre;
            this.sede= sede;
            this.bibloteca= new List<Prestamo>();
            CargaArchivos(archivo);
        }

        //Metodo Carga lista desde Archivo
        private bool CargaArchivos(string arch)
        {
            try
            {
                FileStream f =new FileStream(arch,FileMode.Open,FileAccess.Read);
                StreamReader sf= new StreamReader(f);
                string linea;
                PrestamoLibro pLibro;
                PrestamoPelicula pPelicula;
                char tipo;

                while(!sf.EndOfStream ) 
                {
                    linea= sf.ReadLine();
                    tipo = linea[0];
                    linea = linea.Substring(1);

                    switch(tipo )
                    {
                        case'L':
                            pLibro = new PrestamoLibro(linea);
                            bibloteca.Add(pLibro);
                            break;
                        case 'P':
                            pPelicula= new PrestamoPelicula(linea);
                            bibloteca.Add(pPelicula);
                            break;
                    }
                }
                sf.Close();
                f.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        //Sobreescribir
        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("Nombre de la Biblioteca: ");
            sb.Append(this.nombre);
            sb.Append("\nSede: ");
            sb.Append(this.sede);
            foreach(Prestamo pres in bibloteca)
            {
                sb.Append("\n" + pres.ToString() + "\n");
            }
            return sb.ToString();  
        }

        //Metodos

        public Prestamo ObtenerPrestamo(string identificador)
        {
            Prestamo inf = new Prestamo();



            for (int i = 0; i < bibloteca.Count; i++)
            {
                if (bibloteca[i].Identificador.Equals(identificador))
                {
                    inf = (Prestamo)bibloteca[i];

                }
            }
            return inf;
        }

        public int TotalPrestamoMasDe(int masdia)
        {
            int cont = 0;
            for(int i = 0;i<bibloteca.Count;i++)
            {
                if (bibloteca[i] is PrestamoPelicula)
                {
                    PrestamoPelicula peli = (PrestamoPelicula)bibloteca[i];

                    if (peli.DiasPrestamo > masdia)
                    {
                        cont++;
                    }
                }
            }
            return cont;
        }
    }
}
