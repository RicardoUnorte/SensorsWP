﻿#pragma checksum "C:\Users\Ricardo\Documents\Movil\Windows Phone\Sensors\Sensors\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E10A23A79BA0382C71B3DF13DC250337"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Sensors {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ComboBox Seleccionar;
        
        internal System.Windows.Controls.TextBlock Values;
        
        internal System.Windows.Controls.TextBlock ValuesG;
        
        internal System.Windows.Controls.TextBlock ValuesC;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Sensors;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Seleccionar = ((System.Windows.Controls.ComboBox)(this.FindName("Seleccionar")));
            this.Values = ((System.Windows.Controls.TextBlock)(this.FindName("Values")));
            this.ValuesG = ((System.Windows.Controls.TextBlock)(this.FindName("ValuesG")));
            this.ValuesC = ((System.Windows.Controls.TextBlock)(this.FindName("ValuesC")));
        }
    }
}

