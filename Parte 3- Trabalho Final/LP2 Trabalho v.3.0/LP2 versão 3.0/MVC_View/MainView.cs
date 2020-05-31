//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
// Copyright (c) IPCA. All rights reserved.</copyright>
//-----------------------------------------------------------------------
// <author>Yuri Lemos</author>
// <author>João Figueiredo</author>
// <desc> This program do the basics of C#</desc>
// <Date> 31/05/2020 </Date>
// <version>3.0</version>
//-----------------------------------------------------------------------


using MVC_Controller;
using MVC_Model;
using System;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MVC_View
{
    /// <summary>
    /// Esta Classe representa uma instancia de MainView (display do programa)
    /// <code>Herança: Form</code>
    /// <code>Implementa: IMainView</code>
    /// </summary>
    public partial class MainView : Form, IMainView
    {
        #region ATRIBUTOS
        /// <summary>
        /// Esta classe utiliza instancia de: - MainController
        ///                                   - Verificador
        ///                                   - Funcionarios
        /// </summary>
        MainController mc;
        Verificador vf;
        Funcionarios fst;
        #endregion

        #region CONSTRUTOR
        /// <summary>
        /// Este constructor cria uma instancia de MainView (Display)
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            fst = new Funcionarios();
            
        }
        #endregion

        #region PROPRIEDADES

        #region TAB FUNCIONARIOS
        #region TAB INSERIR
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Nome 
        /// <code>type: string</code>
        /// </summary>
        public string TabInsertNome { get => tabInsertTxtBxNome.Text; set => tabInsertTxtBxNome.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Contribuinte 
        /// <code>type: string</code>
        /// </summary>
        public string TabInsertContribuinte { get => tabInsertTxtBxContri.Text; set => tabInsertTxtBxContri.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir BI 
        /// <code>type: string</code>
        /// </summary>
        public string TabInsertBi { get => tabInsertTxtBxBi.Text; set => tabInsertTxtBxBi.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Morada 
        /// <code>type: string</code>
        /// </summary>
        public string TabInsertMorada { get => tabInsertTxtBxMorada.Text; set => tabInsertTxtBxMorada.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Contacto 
        /// <code>type: string</code>
        /// </summary>
        public string TabInsertContacto { get => tabInsertTxtBxContacto.Text; set => tabInsertTxtBxContacto.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Cargo 
        /// <code>type: string</code>
        /// </summary>
        public string TabInsertCargo { get => tabInsertTxtBxCargo.Text; set => tabInsertTxtBxCargo.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Data Admissão 
        /// <code>type: DateTime</code>
        /// </summary>
        public DateTime TabInsertDataAdmissao { get => tabInsertdateTimePicker.Value; set => tabInsertdateTimePicker.Value = value; }
        #endregion
        #region TAB EDITAR
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar ID 
        /// <code>type: string</code>
        /// </summary>
        public string TabEditID { get => fTabEditTbxID.Text; set => fTabEditTbxID.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Nome 
        /// <code>type: string</code>
        /// </summary>
        public string TabEditNome { get => fTabEditTbxNome.Text; set => fTabEditTbxNome.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Contribuinte 
        /// <code>type: string</code>
        /// </summary>
        public string TabEditContribuinte { get => fTabEditTbxContribu.Text; set => fTabEditTbxContribu.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar BI 
        /// <code>type: string</code>
        /// </summary>
        public string TabEditBi { get => fTabEditTbxBI.Text; set => fTabEditTbxBI.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Morada 
        /// <code>type: string</code>
        /// </summary>
        public string TabEditMorada { get => fTabEditTbxMorada.Text; set => fTabEditTbxMorada.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Contacto 
        /// <code>type: string</code>
        /// </summary>
        public string TabEditContacto { get => fTabEditTbxContacto.Text; set => fTabEditTbxContacto.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Cargo 
        /// <code>type: string</code>
        /// </summary>
        public string TabEditCargo { get => fTabEditTbxCargo.Text; set => fTabEditTbxCargo.Text = value; }
        #endregion
        #region TAB REMOVER
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover ID 
        /// <code>type: string</code>
        /// </summary>
        public string TabRemoveID { get => tabRemovTxtBxID.Text; set => tabRemovTxtBxID.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover Nome 
        /// <code>type: string</code>
        /// </summary>
        public string TabRemoveNome { get => tabRemovTxtBxNome.Text; set => tabRemovTxtBxNome.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover Contacto 
        /// <code>type: string</code>
        /// </summary>
        public string TabRemoveContacto { get => tabRemovTxtBxContato.Text; set => tabRemovTxtBxContato.Text = value; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover Cargo 
        /// <code>type: string</code>
        /// </summary>
        public string TabRemoveCargo { get => tabRemovTxtBxCargo.Text; set => tabRemovTxtBxCargo.Text = value; }

        #endregion
        #region TAB LISTVIEWS
        /// <summary>
        /// Obtém ou ajusta os dados da componente ListView no separador editar funcionario 
        /// <code>type: ListView</code>
        /// </summary>
        public ListView TabEditarListView { get => fTabEditListView; set => fTabEditListView = value; }
        /// <summary>
        /// Obtém ou ajusta os dados da componente ListView no separador listar funcionario 
        /// <code>type: ListView</code>
        /// </summary>
        public ListView TabListarListView { get => tabFuncListViewListar; set => tabFuncListViewListar = value; }
        /// <summary>
        /// Obtém ou ajusta os dados da componente ListView no separador remover funcionario 
        /// <code>type: ListView</code>
        /// </summary>
        public ListView TabRemoveListView { get => tabRemovListView; set => tabRemovListView = value; }
        #endregion
        #endregion

        #endregion

        #region METODOS
        /// Metodos da classe MainView
        #region METODOS DA MVC VIEW
        /// <summary>
        /// Este método é utilado para interligar a classe MainView com a classe MainController
        /// </summary>
        /// <param name="controller"></param>
        public void SetController(MainController controller)
        {
            mc = controller;
        }
        /// <summary>
        /// Este método é um evento que serve para dizer a camada de controlo quando precisa ser guardadas as informações
        /// Ele é ativado ao fazer click na pictureBox SaveIcon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureSaveIcon_Click(object sender, EventArgs e)
        {
            if (mc.SaveAll())
            {
                MessageBox.Show("Dados Guardados!");
            }
            else
            {
                MessageBox.Show("Erro na gravação!");
            }
        }
        #endregion

        #region METODOS FUNCIONARIOS
        /// <summary>
        /// Este método é um evento que serve para voltar ao menu principal do programa, ocultando o painel de funcionarios.
        /// Ele é ativado ao fazer click na pictureBox BackBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBXBackBtn_Click(object sender, EventArgs e)
        {
            pnlFuncionarios.Visible = false;
            LimpaTodosCampos();
        }
        /// <summary>
        /// Este método é um evento que serve para mostrar o painel de funcionarios.
        /// Ele é ativado ao fazer click no botão Gerir Funcionarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            pnlFuncionarios.Visible = true;
        }
        
        /// <summary>
        /// Este método é um evento que serve para dizer a camada de controlo quando precisa ser inserido um funcionario.
        /// Ele é ativado ao fazer click no botão criar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabInsertBtnCriar_Click(object sender, EventArgs e)
        {
            mc.InsereFuncionario();
        }
        /// <summary>
        /// Este método é um evento que serve para limpar as TextBox do separador Inserir Funcionario
        /// Ele é ativado ao fazer click no botão Limpar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabInsertBtnCancel_Click(object sender, EventArgs e)
        {
            TabInsertNome = "";
            TabInsertMorada = "";
            TabInsertBi = "";
            TabInsertCargo = "";
            TabInsertContacto = "";
            TabInsertContribuinte = "";
            TabInsertDataAdmissao = DateTime.Today;
        }
        /// <summary>
        /// Este método é um evento que serve para dizer a camada de controlo que um item da ListView foi selecionado do separador editar.
        /// Ele é ativado ao fazer click em um item da ListView do separador Editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fTabEditListView_MouseClick(object sender, MouseEventArgs e)
        {
            mc.EditFuncionarioSelected();
        }
        /// <summary>
        /// Este método é um evento que serve para dizer a camada de controlo quando precisa ser editado um funcionario.
        /// Ele é ativado ao fazer click no botão Editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fTabEditBtnEditar_Click(object sender, EventArgs e)
        {
            mc.EditarFuncionario();
        }
        /// <summary>
        /// Este método é um evento que serve para dizer a camada de controlo que um item da ListView foi selecionado do separador remover.
        /// Ele é ativado ao fazer click em um item da ListView do separador Remover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabRemovListView_MouseClick(object sender, MouseEventArgs e)
        {
            mc.RemoveFuncionarioSelected();
        }
        /// <summary>
        /// Este método é um evento que serve para dizer a camada de controlo quando precisa ser removido um funcionario.
        /// Ele é ativado ao fazer click no botão remover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fTabEditBtnRemover_Click(object sender, EventArgs e)
        {
            mc.RemoverFuncionario();
        }
        /// <summary>
        /// Este método busca os Sub itens selecionados na ListView Remover e insere nas respectivas TextBox do separador remover funcionario
        /// </summary>
        public void PreencheCampoTabRemove()
        {
            string[] dados = new string[8];
            try
            {
                
                for (int i = 0; i < tabRemovListView.SelectedItems[0].SubItems.Count; i++)
                {
                    dados[i] = tabRemovListView.SelectedItems[0].SubItems[i].Text;
                }
                tabRemovTxtBxID.Text = dados[0];
                tabRemovTxtBxNome.Text = dados[2];
                tabRemovTxtBxCargo.Text = dados[6];
                tabRemovTxtBxContato.Text = dados[5];
                //return lv.SelectedItems[0].SubItems[0].Text;

            }
            catch (Exception ee)
            {
                throw new Exception(ee.Message);
            }

        }
        /// <summary>
        /// Este método busca os Sub itens selecionados na ListView Editar e insere nas respectivas TextBox do separador editar funcionario.
        /// </summary>
        public void PreencheCampoTabEdit()
        {
            string[] dados = new string[8];
            try
            {
                //
                for (int i = 0; i < fTabEditListView.SelectedItems[0].SubItems.Count; i++)
                {
                    dados[i] = fTabEditListView.SelectedItems[0].SubItems[i].Text;
                }
                fTabEditTbxID.Text = dados[0];
                fTabEditTbxNome.Text = dados[2];
                fTabEditTbxCargo.Text = dados[6];
                fTabEditTbxContacto.Text = dados[5];
                fTabEditTbxContribu.Text = dados[4];
                fTabEditTbxBI.Text = dados[1];
                fTabEditTbxMorada.Text = dados[3];
                //return lv.SelectedItems[0].SubItems[0].Text;

            }
            catch (Exception ee)
            {
                throw new Exception(ee.Message);
            }

        }
        /// <summary>
        /// Este método limpa todas as TextBox existentes em todos os separadores de Gerir Funcionarios
        /// </summary>
        public void LimpaTodosCampos()
        {
            TabInsertNome = "";
            TabInsertMorada = "";
            TabInsertBi = "";
            TabInsertCargo = "";
            TabInsertContacto = "";
            TabInsertContribuinte = "";
            TabInsertDataAdmissao = DateTime.Today;

            TabEditID = "";
            TabEditNome = "";
            TabEditCargo = "";
            TabEditContacto = "";
            TabEditContribuinte = "";
            TabEditBi = "";
            TabEditMorada = "";

            TabRemoveID = "";
            TabRemoveNome = "";
            TabRemoveCargo = "";
            TabRemoveContacto = "";
        }
        #endregion

        #endregion

        
    }
}
