using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Fotografias
    {

        /// <summary>
        /// Ficheiro que contém a fotografia
        /// </summary>
        public int Foto { get; set; }

        /// <summary>
        /// Data de quando foi tirado a fotografia
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde foi tirada a fotografia
        /// </summary>
        public string LocalFoto { get; set; }
    }
}
