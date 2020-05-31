//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
// Copyright (c) IPCA. All rights reserved.</copyright>
//-----------------------------------------------------------------------
// <author>Yuri Lemos</author>
// <author>João Figueiredo</author>
// <desc> This program do the basics of C#</desc>
// <Date> 31/05/2020 </Date>
// <version>3.0</version>

using System;

namespace MVC_Model
{
    /// <summary>
    /// Esta classe representa uma instâcia de ocorrencia 
    /// </summary>
    [Serializable]
    public class Ocorrencia
    {

        #region Atributos
        /// <summary>
        /// Os valores recebidos aqui são:
        /// *codAuditoria - Codigo de identificação da Auditoria na empresa
        /// *codVulnerabilidade - Codigo de identificação da Vulnerabilidade 
        /// *codEquipamento - Codigo de identificação do Equipamento
        /// *estado - Estado da Vulnerabildade 
        /// </summary>
        //int codAuditoria;
        int idOcorrencia;
        int codVulnerabilidade;
        int codEquipamento;
        bool estado;

        #endregion

        #region Construtor
        ///<summary>
        ///Inicializa uma nova instancia de Ocorrencia</summary>
        public Ocorrencia()
        {

        }

        ///<summary>
        ///Inicializa uma nova instancia de Ocorrencia com parametros</summary>
        public Ocorrencia(int codVulnerabilidade, int codEquipamento)
        {
            this.codVulnerabilidade = codVulnerabilidade;
            this.codEquipamento = codEquipamento;
            estado = true;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou ajusta o componente do ID de Ocorrencia
        /// <code>type: int</code>
        /// </summary>
        public int IdOcorrencia
        {
            get { return idOcorrencia; }
            set { idOcorrencia = value; }
        }
        /// <summary>
        /// Obtém ou ajusta o componente do codigo da vulnerabilidade
        /// <code>type: int</code>
        /// </summary>
        public int CodVulnerabilidade
        {
            get { return codVulnerabilidade; }
            set { codVulnerabilidade = value; }
        }
        /// <summary>
        /// Obtém ou ajusta o componente do codigo do equipamento
        /// <code>type: int</code>
        /// </summary>
        public int CodEquipamento
        {
            get { return codEquipamento; }
            set { codEquipamento = value; }
        }
        /// <summary>
        /// Obtém ou ajusta o componente estado da vulnerabilidade
        /// <code>type: bool</code>
        /// </summary>
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

        #region Metodos
        

        /// <summary>
        /// Metodo para listar a  ocorrencias
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

    }
}
