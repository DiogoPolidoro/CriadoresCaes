using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Fotografias
    {

        /// <summary>
        /// Identificador de cada uma das fotografias
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ficheiro que contém a fotografia
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// Data de quando foi tirado a fotografia
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde foi tirada a fotografia
        /// </summary>
        public string LocalFoto { get; set; }

        // criação da FK que referencia o Cão a quem a Foto pertence

        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }
    }
}
