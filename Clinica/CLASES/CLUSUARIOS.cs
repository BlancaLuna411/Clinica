using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.CLASES
{
    internal class CLUSUARIOS
    {
        private string email;
        private string fecha;
        private int    id;
        private int    idrole;
        private string telefono;
        private string nombre;
        private string password;
        private int    id_empresa;
        private string login;
        private int    condicion;
        private string imagen;
       
      
        public CLUSUARIOS(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public CLUSUARIOS(string email, string fecha, int id, int idrole, string telefono, string nombre, string password, int id_empresa, string login, int condicion, string imagen) : this(email, fecha)
        {
            this.id = id;
            this.idrole = idrole;
            this.telefono = telefono;
            this.nombre = nombre;
            this.password = password;
            this.id_empresa = id_empresa;
            this.login = login;
            this.condicion = condicion;
            this.imagen = imagen;
        }

        public CLUSUARIOS(string nombre)
        {
            this.nombre = nombre;
        }

        // Selecciona todas las columnas de usuarios y filtra por correo y contraseña 
        public string ingresar()
        {
            return ("select * from tblusuarios where email= '" +this.email+"'and password = '"+ this.password +"'");
        }
        public string buscarporclave()
        {
            return ("select * from tblusuarios where id= '" + this.id + "'");
        }
       // public string buscarpornombre()
       // {
           // return ("select * from tblusuarios where nombre= '" + this, nombre + "'");
        //}
    }
}
