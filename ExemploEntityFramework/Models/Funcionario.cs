using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Models
{
    // O modelo define a estrutura da tabela, os nomes das colunas e os tipos dela
    public class Funcionario
    {
        [Key]
        public int Id { get; set; } 
        // As colunas chamadas Id ou [NomeTabela]Id serão mapeadas como chave primária
        // É possível especificar a chave usando a anotação [Key]
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool HomeOffice { get; set; }
        public TipoEquipamento Equipamento { get; set; }
    }

    public enum TipoEquipamento
    {
        Computador = 1,
        Notebook = 2,
        Tablet = 3
    }
}
