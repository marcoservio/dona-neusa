using PastelECia.Models;
using PastelECia.Models.Enum;
using PastelECia.Services;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PastelECia.Views.Cadastro
{
    public partial class frmCadastroProduto : frmAncestral, IMethodsModel<Produto>
    {
        private readonly ProdutoService _serviceProduto = new ProdutoService();
        private readonly UnidadeMedidaService _serviceUnidade = new UnidadeMedidaService();

        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        public void CarregarGrid(List<Produto> lst)
        {
            dtgProduto.DataSource = lst;
            DesenharGrid();
            UpdateRefreshGrid();
        }

        public void CarregarUnidadeMedida()
        {
            var lst = _serviceUnidade.ListarTodos();

            if (lst != null && lst.Count > 0)
            {
                cmbUnidadeMedida.DisplayMember = "NomeDescricao";
                cmbUnidadeMedida.ValueMember = "Id";
                cmbUnidadeMedida.DataSource = lst;
            }
        }

        public void DesenharGrid()
        {
            dtgProduto.Columns["UnidadeMedidaId"].Visible = false;
            dtgProduto.Columns["DataAlteracao"].Visible = false;
            dtgProduto.Columns["ValorTotal"].Visible = false;
        }

        public void LimparGrid()
        {
            dtgProduto.DataSource = null;
            UpdateRefreshGrid();
        }

        public void LimparTela()
        {
            txtId.Text = string.Empty;
            txtId.Focus();
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            rdbNao.Checked = true;
            cmbUnidadeMedida.SelectedIndex = -1;
        }

        public void ObjetoParaTela(Produto obj)
        {
            txtId.Text = obj?.Id.ToString();
            txtNome.Text = obj?.Nome;
            txtDescricao.Text = obj?.Descricao;
            txtValor.Text = obj?.Valor.ToString();
            txtQuantidade.Text = obj?.Quantidade.ToString();
            cmbUnidadeMedida.SelectedValue = (int)obj?.UnidadeMedida?.Id;
            if (obj?.Inativo == Enumerador.SimNao.S)
                rdbSim.Checked = true;
            else
                rdbNao.Checked = true;
        }

        public Produto TelaParaObjeto()
        {
            Produto produto = new Produto();

            if (string.IsNullOrEmpty(txtId.Text.Trim()))
                txtId.Text = "0";
            if (string.IsNullOrEmpty(txtQuantidade.Text.Trim()))
                txtQuantidade.Text = "0";
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                throw new Exception("Campo Nome é obrigatorio");
            if (string.IsNullOrEmpty(txtValor.Text.Trim()))
                throw new Exception("Campo Valor é obrigatorio");
            if (string.IsNullOrEmpty(cmbUnidadeMedida.Text.Trim()))
                throw new Exception("Campo Unidade de Medida é obrigatorio");

            produto.Id = Convert.ToInt32(txtId.Text.Trim());
            produto.Nome = txtNome.Text.Trim();
            produto.Descricao = txtDescricao.Text.Trim();
            produto.Valor = Convert.ToDecimal(txtValor.Text.Trim());
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
            produto.UnidadeMedidaId = (int)cmbUnidadeMedida.SelectedValue;
            if (rdbSim.Checked)
                produto.Inativo = Enumerador.SimNao.S;
            else
                produto.Inativo = Enumerador.SimNao.N;

            return produto;
        }

        public void UpdateRefreshGrid()
        {
            dtgProduto.Update();
            dtgProduto.Refresh();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {
                if (DesignMode == false)
                {
                    Cursor = Cursors.WaitCursor;

                    LimparGrid();
                    CarregarUnidadeMedida();
                    LimparTela();
                    CarregarGrid(_serviceProduto.ListarTodos());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (string.IsNullOrEmpty(txtId.Text))
                    throw new Exception("Selecione um produto para continuar com a exclusão.");

                Produto produto = _serviceProduto.BuscarPor(Convert.ToInt32(txtId.Text));

                if (produto == null)
                    throw new Exception("Erro ao excluir o produto");

                if (MessageBox.Show("Confirma a exclusão do Produto?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    _serviceProduto.Excluir(produto);

                CarregarGrid(_serviceProduto.ListarTodos());
                LimparTela();
            }
            catch (Exception ex)
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

                if (produto == null)
                    throw new Exception("Erro ao salvar o produto");

                if (produto.Id == 0 || _serviceProduto.BuscarPor(produto.Id) == null)
                    _serviceProduto.Incluir(produto);
                else
                    _serviceProduto.Alterar(produto);

                CarregarGrid(_serviceProduto.ListarTodos());
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void TxtSomenteNumeroKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void TxtDecimalKeyPress(object sender, KeyPressEventArgs e, TextBox txt)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(","))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TxtDecimalLeave(object sender, EventArgs e, TextBox txt)
        {
            try
            {
                if (txt.Text.Contains(",") == false)
                {
                    txt.Text += ",00";
                }
                else
                {
                    if (txt.Text.IndexOf(",") == txt.Text.Length - 1)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtDecimalKeyPress(sender, e, txtValor);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            TxtDecimalLeave(sender, e, txtValor);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtSomenteNumeroKeyPress(sender, e);
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Produto produto = new Produto();

                if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    produto = _serviceProduto.BuscarPor(Convert.ToInt32(txtId.Text));

                    if (produto == null)
                        throw new Exception("Produto não encontrado");

                    ObjetoParaTela(produto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void dtgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProduto.CurrentRow == null)
                throw new Exception("Selecione um item da tabela.");

            var produto = dtgProduto.CurrentRow.DataBoundItem as Produto;

            if (produto == null)
                throw new Exception("Erro ao buscar o produto");

            ObjetoParaTela(produto);
        }
    }
}
