﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Criadores
    {

        public Criadores()
        {
            ListaDeCaes = new HashSet<CriadorCaes>();
        }

        /// <summary>
        /// Identificador de cada Criador
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do criador
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Nome de vendedor do criador
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do criador
        /// </summary>
        [Required]
        public string Morada { get; set; }

        /// <summary>
        /// Código postal da morada do criador
        /// </summary>
        [Required]
        public string CodigoPostal { get; set; }

        /// <summary>
        /// Numero de telemovel do criador
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        public string Email { get; set; }

        // ###########################################

        // lista de cães asociados ao Criador
        /// <summary>
        /// lista de cães asociados ao Criador
        /// </summary>
        public ICollection<CriadorCaes> ListaDeCaes { get; set; }
    }
}
