//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="IPCA">
// Copyright (c) IPCA. All rights reserved.</copyright>
//-----------------------------------------------------------------------
// <author>Yuri Lemos</author>
// <desc> This program do the basics of C#</desc>
// <Date> 31/05/2020 </Date>
// <version>3.0</version>
//-----------------------------------------------------------------------

using System;

namespace MVC_Model
{
    /// <summary>
    /// Representa erros relacionados com valores de input errados
    /// </summary>
    public class ValoresExceptions : ApplicationException
    {
        public ValoresExceptions() : base("Valor Inserido Errado") { }

        public ValoresExceptions(string s) : base(s) { }

        public ValoresExceptions(string s, Exception e)
        {
            throw new ValoresExceptions(e.Message + " - " + s);
        }
        

    }
}
