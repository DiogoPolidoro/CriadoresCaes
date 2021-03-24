using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{

    /// <summary>
    /// Descrição de cada um dos cães
    /// </summary>
    public class Caes
    {

        /// <summary>
        /// Identificador de cada cão
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do cão
        /// M - masculino
        /// F - Feminino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Data de nascimento do cão
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Registo do cão no livro de origens portuguesas (LOP)
        /// </summary>
        public string LOP { get; set; }

    }
}
