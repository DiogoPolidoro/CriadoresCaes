using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class CriadorCaes
    {

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        // ***************************************************

        // FK para o cão do criador
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }


        // FK para os criador do cão
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }
    }
}
