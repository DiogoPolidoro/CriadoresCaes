using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Criadores
    {

        /// <summary>
        /// Nome do criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nome de vendedor do criador
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código postal da morada do criador
        /// </summary>
        public string CodigoPostal { get; set; }

        /// <summary>
        /// Numero de telemovel do criador
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        public string Email { get; set; }
    }
}
