using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{

    /// <summary>
    /// Raça atribuída a uma cão
    /// </summary>
    public class Racas
    {

        /// <summary>
        /// Identificador de cada uma das raças
        /// </summary>
        public int Id { get; set; }
            
        /// <summary>
        /// Identifica o nome da raça
        /// </summary>
        public string Designacao { get; set; }

    }
}
