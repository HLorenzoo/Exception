using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionn
{
    public class Alumno
    {
     public Alumno(string nombre) 
        {
            string name = nombre.Trim();
            if(name.Length <1 || name.Length > 50)
            {
                throw new Exception("Tiene que poner un nombre valido");
            }
            Nombre = name;
        }
           public string Nombre { get; set; }
        
        }


    }

