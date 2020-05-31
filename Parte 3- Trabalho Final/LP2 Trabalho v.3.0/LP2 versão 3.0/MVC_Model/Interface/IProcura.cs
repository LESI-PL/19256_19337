//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
// Copyright (c) IPCA. All rights reserved.</copyright>
//-----------------------------------------------------------------------
// <author>Yuri Lemos</author>
// <desc> This program do the basics of C#</desc>
// <Date> 31/05/2020 </Date>
// <version>3.0</version>
//-----------------------------------------------------------------------

namespace MVC_Model
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProcura
    {
        /// <summary>
        /// Metodo que busca numa lista a posição do codigo inserido, caso nao exista retorna -1
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>indice posição ou -1</returns>
        int Procura(int codigo);
    }
}
