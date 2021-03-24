using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{

    /// <summary>
    /// Descrição de cada um dos cães
    /// </summary>
    public class Caes
    {

        public Caes()
        {
            // inicializar a lista de Fotografias de cada um dos cães
            ListaDeFotografias = new HashSet<Fotografias>();
            // inicializar a lista de Criadores do cão
            ListaCriadores = new HashSet<CriadoresCaes>();

        }

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
        /// Registo do cão no livro de origens portuguesas (LOP)
        /// </summary>
        public string LOP { get; set; }

        // ***************************************************************


        /// <summary>
        /// FK para a Raça do cão
        /// </summary>
        [ForeignKey(nameof(Raca))] // esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca' ,
                                   // e que representa uma FK para a classe Raca
        public int RacaFK { get; set; } // atributo para ser usado no SGBD e no C#. Representa a FK para a raça do cão
        public Racas Raca { get; set; } // atributo para ser usado no C#. Representa a FK para a raça do cão


        // *****************************************************************

        // associar os cães às suas fotografias
        /// <summary>
        /// Lista das Fotografias do cão
        /// </summary>
        public ICollection<Fotografias> ListaDeFotografias { get; set; }

        // ####################################################################

        // associar os Cães aos seus Criadores
        /// <summary>
        /// Lista dos Criadores associado ao um cão 
        /// </summary>
        public ICollection<CriadoresCaes> ListaCriadores { get; set; }
    }
}
