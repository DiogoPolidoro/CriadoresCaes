using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Ficheiro que contém a fotografia
        /// </summary>
        [Display(Name = "Fotografia")]
        public string Foto { get; set; }

        /// <summary>
        /// Data de quando foi tirado a fotografia
        /// </summary>
        [Display(Name = "Data da fotografia")]
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde foi tirada a fotografia
        /// </summary>
        public string Local { get; set; }

        // criação da FK que referencia o Cão a quem a Foto pertence

        [ForeignKey(nameof(Cao))]
        [Display(Name = "Cão")]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }
    }
}
