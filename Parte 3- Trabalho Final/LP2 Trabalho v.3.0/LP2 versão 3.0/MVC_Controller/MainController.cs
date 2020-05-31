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

using MVC_Model;
using System.IO;
using System.Windows.Forms;

namespace MVC_Controller
{
    /// <summary>
    /// Esta Classe representa uma instancia de MainController(controlador do programa)
    /// </summary>
    public class MainController
    {
        /// <summary>
        /// Esta classe utiliza instancia de: - IMainView
        ///                                   - Verificador
        ///                                   - Funcionarios
        /// </summary>
        IMainView view;
        Verificador verif;
        Funcionarios fs;

        /// <summary>
        /// Este constructor cria uma instancia de MainController (Controlador)
        /// </summary>
        /// <param name="view"></param>
        public MainController(IMainView view)
        {
            this.view = view;
            fs = new Funcionarios();
            verif = new Verificador(this.view, this);
            view.SetController(this);
            LoadAll();
            UpdateAllLists();
        }
        /// <summary>
        /// Este método diz a instancia da classe MainView para atualizar todas as ListViews
        /// </summary>
        public void UpdateAllLists()
        {
            view.TabListarListView = fs.GetListAtivos(view.TabListarListView);
            view.TabRemoveListView = fs.GetListAtivos(view.TabRemoveListView);
            view.TabEditarListView = fs.GetListAtivos(view.TabEditarListView);
        }
        /// <summary>
        /// Este método diz a instancia da classe MainView para utilizar o seu método PreencheCampoTabEdit
        /// </summary>
        /// <returns></returns>
        public bool EditFuncionarioSelected()
        {
            view.PreencheCampoTabEdit();
           
            return true;
        }
        /// <summary>
        /// Este método diz a instancia da classe MainView para utilizar o seu método PreencheCampoTabRemove
        /// </summary>
        /// <returns></returns>
        public bool RemoveFuncionarioSelected()
        {
         
            view.PreencheCampoTabRemove();
            return true;
        }
        /// <summary>
        /// Este método diz a instancia da classe Verificador para verificar todos os dados inseridos pelo utilizador,
        /// Caso o verificador retorne true é dito então para a instancia de Funcionarios
        /// para inserir o Funcionario devolvido pelo verificador.
        /// </summary>
        /// <returns>True, caso o funcionario seja inserido</returns>
        public bool InsereFuncionario()
        {
            bool estadoCheck, estadoInsert;
            Funcionario f = new Funcionario();
            estadoCheck = verif.CheckDadosInsert(out f);
            if (estadoCheck && f != null)
            {
                estadoInsert = fs.InserirFuncionario(f);
                if (estadoInsert)
                {
                    MessageBox.Show("Dados Inseridos!");

                }
                else
                {
                    MessageBox.Show("Falha ao inserir o funcionario!");
                }
            }
            view.LimpaTodosCampos();
            UpdateAllLists();
            return estadoCheck;
        }
        /// <summary>
        /// Este método diz a instancia da classe Verificador para verificar todos os dados inseridos pelo utilizador,
        /// Caso o verificador retorne true é dito então para a instancia de Funcionarios
        /// para editar o Funcionario devolvido pelo verificador.
        /// </summary>
        /// <returns>True, caso o funcionario seja editado</returns>
        public bool EditarFuncionario()
        {
            bool estadoCheck, estadoInsert;
            Funcionario f = new Funcionario();
            estadoCheck = verif.CheckDadosEdit(out f);
            if (estadoCheck && f != null)
            {
                estadoInsert = fs.Editar(f);
                if (estadoInsert)
                {
                    MessageBox.Show("Dados Editados!");

                }
                else
                {
                    MessageBox.Show("Falha ao editar o funcionario!");
                }
            }
            view.LimpaTodosCampos();
            UpdateAllLists();
            return estadoCheck;
        }
        /// <summary>
        /// Este método diz a instancia da classe Verificador para verificar todos os dados inseridos pelo utilizador,
        /// Caso o verificador retorne true é dito então para a instancia de Funcionarios
        /// para remover o Funcionario devolvido pelo verificador.
        /// </summary>
        /// <returns>True, caso o funcionario seja removido</returns>
        public bool RemoverFuncionario()
        {
            bool estadoCheck, estadoInsert;
            Funcionario f = new Funcionario();
            estadoCheck = verif.CheckDadosRemover(out f);
            if (estadoCheck && f != null)
            {
                estadoInsert = fs.Remove(f);
                if (estadoInsert)
                {
                    MessageBox.Show("Funcionario Removido!");

                }
                else
                {
                    MessageBox.Show("Falha ao remover o funcionario!");
                }
            }
            view.LimpaTodosCampos();
            UpdateAllLists();
            return estadoCheck;
        }
        /// <summary>
        /// Este método diz a instancia de Funcionarios para gravar em um
        /// ficheiro os dados que estão na sua lista
        /// </summary>
        /// <returns>true caso consiga guardar os dados</returns>
        public bool SaveAll()
        {

            try
            {
                if (fs.SaveFuncionarios())
                {
                    return true;
                }
            }
            catch (IOException e)
            {
                throw e;
            }
            return false;
        }
        /// <summary>
        /// Este método diz a instancia de Funcionarios para carregar os dados
        /// guardados em um ficheiro
        /// </summary>
        /// <returns>true caso consiga guardar os dados</returns>
        public bool LoadAll()
        {

            try
            {
                if (fs.LoadFuncionarios())
                {
                    return true;
                }
            }
            catch (System.Runtime.Serialization.SerializationException se)
            {
                throw se;
            }
            catch (IOException e)
            {
                throw e;
            }
            return false;
        }




    }
}
