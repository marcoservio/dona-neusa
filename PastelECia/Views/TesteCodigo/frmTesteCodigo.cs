using PastelECia.Models.Enum;
using PastelECia.Models;
using PastelECia.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia.Views
{
    public partial class frmTesteCodigo : UserControl, IMethodsModel<Produto>
    {
        private ProdutoService _service = new ProdutoService();

        public frmTesteCodigo()
        {
            InitializeComponent();
        }

        private void frmTesteCodigo_Load(object sender, EventArgs e)
        {
            try
            {
                if(DesignMode == false)
                {
                    Cursor = Cursors.WaitCursor;

                    CarregarGrid(_service.ListarTodos());
                    LimparTela();
                    LimparGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void DesenharGrid()
        {
            dtgTeste.Columns["DataAlteracao"].Visible = false;
            dtgTeste.Columns["ValorTotal"].Visible = false;
            dtgTeste.Columns["Nome"].Width = 243;
            dtgTeste.Columns["Descricao"].Width = 244;
            dtgTeste.Columns["Id"].Width = 50;
            dtgTeste.Columns["Inativo"].Width = 50;
        }

        public void CarregarGrid(List<Produto> lstProdutos)
        {
            Cursor = Cursors.WaitCursor;

            if(lstProdutos == null || lstProdutos.Count == 0)
                throw new Exception("Erro ao carregar a lista de produtos");

            dtgTeste.DataSource = lstProdutos;
            DesenharGrid();
        }

        public Produto TelaParaObjeto()
        {
            Produto produto = new Produto();

            if(string.IsNullOrEmpty(txtId.Text.Trim()))
                throw new Exception("Campo ID é obrigatorio");
            if(string.IsNullOrEmpty(txtNome.Text.Trim()))
                throw new Exception("Campo Nome é obrigatorio");
            if(string.IsNullOrEmpty(txtValor.Text.Trim()))
                throw new Exception("Campo Valor é obrigatorio");
            if(string.IsNullOrEmpty(cmbInativo.Text.Trim()))
                throw new Exception("Campo Inativo é obrigatorio");

            produto.Id = Convert.ToInt32(txtId.Text.Trim());
            produto.Nome = txtNome.Text.Trim();
            produto.Descricao = txtDescricao.Text.Trim();
            produto.Valor = Convert.ToDecimal(txtValor.Text.Trim());
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
            produto.DataAlteracao = DateTime.Now;
            //UnidadeMedida uni = new UnidadeMedida();
            //uni.Nome = "Caixa";
            //produto.UnidadeMedida = uni;

            if(cmbInativo.SelectedIndex == 0)
                produto.Inativo = Enumerador.SimNao.S;
            else
                produto.Inativo = Enumerador.SimNao.N;

            return produto;
        }

        public void ObjetoParaTela(Produto produto)
        {
            txtId.Text = produto?.Id.ToString();
            txtNome.Text = produto?.Nome;
            txtDescricao.Text = produto?.Descricao;
            txtValor.Text = produto?.Valor.ToString();
            txtQuantidade.Text = produto?.Quantidade.ToString();
        }

        public void LimparTela()
        {
            txtId.Text = "0";
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtValor.Text = "0,00";
            txtQuantidade.Text = string.Empty;
            cmbInativo.SelectedIndex = -1;
            txtBuscarId.Text = string.Empty;
            txtListarNome.Text = string.Empty;
        }

        public void LimparGrid()
        {
            dtgTeste.DataSource = new List<Produto>();
            DesenharGrid();
            dtgTeste.Update();
        }

        public void TxtSomenteNumeroKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void TxtDecimalLeave(object sender, EventArgs e, TextBox txt)
        {
            try
            {
                if(txt.Text.Contains(",") == false)
                {
                    txt.Text += ",00";
                }
                else
                {
                    if(txt.Text.IndexOf(",") == txt.Text.Length - 1)
                    {
                        txt.Text += "00";
                    }
                }
                try
                {
                    double d = Convert.ToDouble(txt.Text);
                }
                catch
                {
                    txt.Text = "0,00";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TxtDecimalKeyPress(object sender, KeyPressEventArgs e, TextBox txt)
        {
            try
            {
                if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char) 8 && e.KeyChar != ',' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                if(e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if(!txt.Text.Contains(","))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExlcuir_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if(dtgTeste.CurrentRow == null)
                    throw new Exception("Clique um item da tabela para excluir.");

                Produto produto = (Produto) dtgTeste.CurrentRow.DataBoundItem;

                if(produto == null)
                    throw new Exception("Erro ao excluir o produto");

                _service.Excluir(produto);

                CarregarGrid(_service.ListarTodos());
                LimparTela();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var produto = TelaParaObjeto();

                if(produto == null)
                    throw new Exception("Erro ao salvar o produto");

                if(produto.Id == 0)
                    _service.Incluir(produto);
                else
                    _service.Alterar(produto);

                CarregarGrid(_service.ListarTodos());
                LimparTela();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            TxtDecimalLeave(sender, e, txtValor);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtDecimalKeyPress(sender, e, txtValor);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtSomenteNumeroKeyPress(sender, e);
        }

        private void dtgTeste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Produto produto = (Produto) dtgTeste.CurrentRow.DataBoundItem;

                if(produto == null)
                    throw new Exception();

                ObjetoParaTela(produto);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
            LimparGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                CarregarGrid(_service.ListarTodos());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Produto produto = new Produto();

                if(string.IsNullOrEmpty(txtId.Text.Trim()))
                    produto = _service.BuscarPor(Convert.ToInt32(txtId.Text));

                if(produto == null)
                    throw new Exception("Produto não encontrado");

                ObjetoParaTela(produto);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtSomenteNumeroKeyPress(sender, e);
        }

        private void btnListarNome_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                CarregarGrid(_service.ListarPor(txtListarNome.Text.Trim()));

                LimparTela();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                Produto produto = _service.BuscarPor(Convert.ToInt32(txtBuscarId.Text.Trim()));

                if(produto == null)
                    throw new Exception();

                List<Produto> lstProdutos = new List<Produto>();
                lstProdutos.Add(produto);

                CarregarGrid(lstProdutos);

                LimparTela();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtBuscarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtSomenteNumeroKeyPress(sender, e);
        }

        private void txtTeste_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(txtId.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtId, "Digite um ID");
                txtId.Focus();
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateRefreshGrid()
        {
            throw new NotImplementedException();
        }
    }
}
