using Microsoft.Reporting.Map.WebForms.BingMaps;

using PastelECia.Models;
using PastelECia.Models.Enum;
using PastelECia.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            if(lst == null || lst.Count == 0)
                throw new Exception("Erro ao carregar a lista de produtos");

            dtgProduto.DataSource = lst;
            DesenharGrid();
            UpdateRefreshGrid();
        }

        public void CarregarUnidadeMedida()
        {
            var lst = _serviceUnidade.ListarTodos();

            if(lst == null || lst.Count == 0)
                throw new Exception("Erro ao carregar a lista de unidades de medidas");

            cmbUnidadeMedida.DisplayMember = "Nome";
            cmbUnidadeMedida.ValueMember = "Id";
            cmbUnidadeMedida.DataSource = lst;
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
            throw new NotImplementedException();
        }

        public Produto TelaParaObjeto()
        {
           Produto produto = new Produto();
            if(string.IsNullOrEmpty(txtId.Text.Trim()))
                txtId.Text = "0";
            if(string.IsNullOrEmpty(txtNome.Text.Trim()))
                throw new Exception("Campo Nome é obrigatorio");
            if(string.IsNullOrEmpty(txtValor.Text.Trim()))
                throw new Exception("Campo Valor é obrigatorio");

            produto.Id = Convert.ToInt32(txtId.Text.Trim());
            produto.Nome = txtNome.Text.Trim();
            produto.Descricao = txtDescricao.Text.Trim();
            produto.Valor = Convert.ToDecimal(txtValor.Text.Trim());
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
            produto.UnidadeMedidaId = (int)cmbUnidadeMedida.SelectedValue;
            if(rdbSim.Checked)
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
                if(DesignMode == false)
                {
                    Cursor = Cursors.WaitCursor;

                    LimparGrid();
                    CarregarUnidadeMedida();
                    LimparTela();
                    CarregarGrid(_serviceProduto.ListarTodosAtivos());
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

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
                    _serviceProduto.Incluir(produto);
                else
                    _serviceProduto.Alterar(produto);

                CarregarGrid(_serviceProduto.ListarTodos());
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
    }
}
