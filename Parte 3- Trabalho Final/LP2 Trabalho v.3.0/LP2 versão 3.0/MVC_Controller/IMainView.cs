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

using System;
using System.Windows.Forms;

namespace MVC_Controller
{
    /// <summary>
    /// Esta é uma interface do MainView
    /// </summary>
    public interface IMainView
    {
        /// <summary>
        /// Este método é utilado para interligar a classe MainView com a classe MainController
        /// </summary>
        /// <param name="controller"></param>
        void SetController(MainController controller);        
        /// <summary>
        /// Este método busca os Sub itens selecionados na ListView Editar e insere nas respectivas TextBox do separador editar funcionario.
        /// </summary>
        void PreencheCampoTabEdit();
        /// <summary>
        /// Este método busca os Sub itens selecionados na ListView Remover e insere nas respectivas TextBox do separador remover funcionario
        /// </summary>
        void PreencheCampoTabRemove();
        /// <summary>
        /// Este método limpa todas as TextBox existentes em todos os separadores de Gerir Funcionarios
        /// </summary>
        void LimpaTodosCampos();
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Nome 
        /// <code>type: string</code>
        /// </summary>
        string TabInsertNome { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Contribuinte 
        /// <code>type: string</code>
        /// </summary>
        string TabInsertContribuinte { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir BI 
        /// <code>type: string</code>
        /// </summary>
        string TabInsertBi { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Morada 
        /// <code>type: string</code>
        /// </summary>
        string TabInsertMorada { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Contacto 
        /// <code>type: string</code>
        /// </summary>
        string TabInsertContacto { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Cargo 
        /// <code>type: string</code>
        /// </summary>
        string TabInsertCargo { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox inserir Data Admissão 
        /// <code>type: DateTime</code>
        /// </summary>
        DateTime TabInsertDataAdmissao { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar ID 
        /// <code>type: string</code>
        /// </summary>
        string TabEditID { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Nome 
        /// <code>type: string</code>
        /// </summary>
        string TabEditNome { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Contribuinte 
        /// <code>type: string</code>
        /// </summary>
        string TabEditContribuinte { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar BI 
        /// <code>type: string</code>
        /// </summary>
        string TabEditBi { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Morada 
        /// <code>type: string</code>
        /// </summary>
        string TabEditMorada { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Contacto 
        /// <code>type: string</code>
        /// </summary>
        string TabEditContacto { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox editar Cargo 
        /// <code>type: string</code>
        /// </summary>
        string TabEditCargo { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover ID 
        /// <code>type: string</code>
        /// </summary>
        string TabRemoveID { get; set ; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover Nome 
        /// <code>type: string</code>
        /// </summary>
        string TabRemoveNome { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover Contacto 
        /// <code>type: string</code>
        /// </summary>
        string TabRemoveContacto { get; set; }
        /// <summary>
        /// Obtém ou ajusta o texto da componente TextBox Remover Cargo 
        /// <code>type: string</code>
        /// </summary>
        string TabRemoveCargo { get; set; }
        /// <summary>
        /// Obtém ou ajusta os dados da componente ListView no separador editar funcionario 
        /// <code>type: ListView</code>
        /// </summary>
        ListView TabEditarListView { get; set; }
        /// <summary>
        /// Obtém ou ajusta os dados da componente ListView no separador listar funcionario 
        /// <code>type: ListView</code>
        /// </summary>
        ListView TabListarListView { get; set; }
        /// <summary>
        /// Obtém ou ajusta os dados da componente ListView no separador remover funcionario 
        /// <code>type: ListView</code>
        /// </summary>
        ListView TabRemoveListView { get; set; }


    }
}
