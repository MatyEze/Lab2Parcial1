using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
        }
        #endregion

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public virtual void ToFileTxt(string folderName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = $"{this.nombre}-{this.apellido}-{this.dni}";
            if (folderName == null || folderName == string.Empty)
            {
                path += @"\" + nombreArchivo + ".txt"; 
            }
            else
            {
                path += @"\" + folderName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path += @"\" + nombreArchivo + ".txt";
            }

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"NOMBRE COMPLETO: {nombre} {apellido}");
                    sw.WriteLine($"DNI: {dni}");
                }
            }

        }
    }
}
