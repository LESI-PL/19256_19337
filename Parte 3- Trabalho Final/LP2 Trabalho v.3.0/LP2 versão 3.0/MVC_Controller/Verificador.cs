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
using System;
using System.Windows.Forms;
namespace MVC_Controller
{
    /// <summary>
    /// Esta Classe representa uma instancia de Verificador
    /// </summary>
    public class Verificador
    {
        /// <summary>
        /// Esta classe utiliza instancia de: - MainController
        ///                                   - IMainView
        /// </summary>
        MainController controller;
        IMainView view;

        /// <summary>
        /// Este constructor cria uma instancia de Verificador
        /// </summary>
        public Verificador(IMainView v, MainController controlr)
        {
            view = v;
            controller = controlr;
        }
        /// <summary>
        /// Este método verifica os dados das TextBox do separador Inserir Funcionario
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool CheckDadosInsert(out Funcionario f)
        {
            Funcionario func = new Funcionario();
            int contrib, contato;
            try
            {               
                Int32.TryParse(view.TabInsertContribuinte, out contrib);
                Int32.TryParse(view.TabInsertContacto, out contato);
                if(contrib == 0 || contato == 0)
                {
                    MessageBox.Show("Erro nos valores inseridos!\nVerifique os campos do contribuinte e contacto");
                }
                else
                {
                    func.Nome = view.TabInsertNome;
                    func.NContribuinte = contrib;
                    func.Contacto = contato;
                    func.Morada = view.TabInsertMorada;
                    func.BI = view.TabInsertBi;
                    func.Cargo = view.TabInsertCargo;
                    func.DataAdmissao = view.TabInsertDataAdmissao;
                    func.Estado = true;
                    f = func;
                    return true;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            f = null;
            return false;
        }
        /// <summary>
        /// Este método verifica os dados das TextBox do separador editar Funcionario
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool CheckDadosEdit(out Funcionario f)
        {
            Funcionario func = new Funcionario();
            int id, contrib, contato;
            try
            {
                Int32.TryParse(view.TabEditContribuinte, out contrib);
                Int32.TryParse(view.TabEditContacto, out contato);
                Int32.TryParse(view.TabEditID, out id);
                if (contrib == 0 || contato == 0)
                {
                    MessageBox.Show("Erro nos valores inseridos!\nVerifique os campos do contribuinte e contacto");
                }
                else
                {
                    func.IdFuncionario = id;
                    func.Nome = view.TabEditNome;
                    func.NContribuinte = contrib;
                    func.Contacto = contato;
                    func.Morada = view.TabEditMorada;
                    func.BI = view.TabEditBi;
                    func.Cargo = view.TabEditCargo;
                    
                    f = func;
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            f = null;
            return false;
        }
        /// <summary>
        /// Este método verifica os dados das TextBox do separador remover Funcionario
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool CheckDadosRemover(out Funcionario f)
        {
            Funcionario func = new Funcionario();
            int id;
            try
            {
                
                Int32.TryParse(view.TabRemoveID, out id);
                func.IdFuncionario = id;
                f = func;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
