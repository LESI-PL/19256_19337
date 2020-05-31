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
using MVC_View;
using System;

namespace MVC_Main
{
    /// <summary>
    /// Esta classe é a classe principal do programa onde o programa é inicializado
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {            
            MainView view = new  MainView();
            view.Visible = false;            
            MainController controller = new MainController(view);
            view.ShowDialog();
        }
    }
}
