using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploEntityFramework.Contexto;
using ExemploEntityFramework.Models;

namespace ExemploEntityFramework
{
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void CarregarDatagrid()
        {
            List<Funcionario> listaFuncionarios;
            using (var ctx = new ExemploContexto())
            {
                listaFuncionarios = ctx.Funcionarios.ToList();
                // Selecionar tudo do DbSet Funcionarios
                // O ToList() faz a execução da query
            }

            dataGridView1.DataSource = listaFuncionarios;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            var checkedRadio = groupEquip.Controls.OfType<RadioButton>().First(r => r.Checked);

            var funcionario = new Funcionario
            {
                Nome = txtNome.Text,
                Idade = Convert.ToInt32(numericUpDown1.Value),
                HomeOffice = chkHomeOffice.Checked,
                Equipamento = (TipoEquipamento)Convert.ToInt32(checkedRadio.Tag)
            };

            using (var ctx = new ExemploContexto())
            {
                ctx.Funcionarios.Add(funcionario);
                // Adiciona um novo usuário na coleção - ainda não existe no banco de dados

                ctx.SaveChanges();
                // O SaveChanges() salva todas as modificações feitas
            }

            CarregarDatagrid();
        }
        
        private void btVer_Click(object sender, EventArgs e)
        {
            var idFunc = ObterIdFuncionarioSelecionado();
            Funcionario func;

            using (var ctx = new ExemploContexto())
            {
                func = ctx.Funcionarios.Single(f => f.Id == idFunc);
            }

            CarregarFuncionario(func);

            groupBox1.Controls.Cast<Control>().ToList().ForEach(c => c.Enabled = false);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var idfunc = ObterIdFuncionarioSelecionado();

            using (var ctx = new ExemploContexto())
            {
                var func = ctx.Funcionarios.Find(idfunc);
                ctx.Funcionarios.Remove(func);
                ctx.SaveChanges();
            }

            CarregarDatagrid();
        }
        
        private void btRefresh_Click(object sender, EventArgs e)
        {
            CarregarDatagrid();
        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDatagrid();
        }
        
        private void CarregarFuncionario(Funcionario funcionario)
        {
            txtNome.Text = funcionario.Nome;
            numericUpDown1.Value = funcionario.Idade;
            chkHomeOffice.Checked = funcionario.HomeOffice;

            var radio = groupEquip.Controls.OfType<RadioButton>().First(r => Convert.ToInt32(r.Tag) == (int)funcionario.Equipamento);
            radio.Checked = true;
        }

        private int ObterIdFuncionarioSelecionado() => Convert.ToInt32(dataGridView1["Id", dataGridView1.CurrentCell.RowIndex].Value);
    }
}
