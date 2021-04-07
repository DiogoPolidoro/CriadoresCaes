using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{

    /// <summary>
    /// Raça atribuída a uma cão
    /// </summary>
    public class Racas
    {

        public Racas()
        {
            // procurar os Cães de cada Raça e criar, para cada Raça, uma lista com os seus cães
            ListaDeCaes = new HashSet<Caes>();

        }


        /// <summary>
        /// Identificador de cada uma das raças
        /// </summary>
        [Key]
        public int Id { get; set; }
            
        /// <summary>
        /// Identifica o nome da raça
        /// </summary>
        public string Designacao { get; set; }

        // ***********************************************

        // uma raça está associada a muitos cães
        // uma raça tem uma lista de cães
        /// <summary>
        /// Lista dos cães que são da raça
        /// </summary>
        public ICollection<Caes> ListaDeCaes { get; set; }
    }
}
