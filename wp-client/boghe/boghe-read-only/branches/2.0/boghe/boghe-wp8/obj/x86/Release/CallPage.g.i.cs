﻿#pragma checksum "E:\github\x-talker\wp-client\boghe\boghe-read-only\branches\2.0\boghe\Boghe-wp8\CallPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB8AA62F19E25714C7B67BDDE3985E37"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using BogheApp;
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


namespace BogheApp {
    
    
    public partial class CallPage : BogheApp.BasePage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitleText;
        
        internal System.Windows.Controls.TextBlock HoldStateText;
        
        internal System.Windows.Controls.TextBlock CallStateText;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel MainStackPanel;
        
        internal System.Windows.Controls.TextBlock CalleeNameText;
        
        internal System.Windows.Controls.StackPanel CalleeInfoStackPanel;
        
        internal System.Windows.Controls.TextBlock CalleeNumberText;
        
        internal System.Windows.Controls.TextBlock CallStartTimeText;
        
        internal System.Windows.Controls.StackPanel AudioRouteStackPanel;
        
        internal System.Windows.Controls.Button EarpieceButton;
        
        internal System.Windows.Controls.Button SpeakerButton;
        
        internal System.Windows.Controls.Button BluetoothButton;
        
        internal System.Windows.Controls.MediaElement bigHead;
        
        internal System.Windows.Controls.MediaElement littleHead;
        
        internal System.Windows.Controls.StackPanel BottomStackPanel;
        
        internal System.Windows.Controls.Button HangUpButton;
        
        internal System.Windows.Controls.Button HoldButton;
        
        internal System.Windows.Controls.Button CameraToggleButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/BogheApp;component/CallPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitleText = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitleText")));
            this.HoldStateText = ((System.Windows.Controls.TextBlock)(this.FindName("HoldStateText")));
            this.CallStateText = ((System.Windows.Controls.TextBlock)(this.FindName("CallStateText")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MainStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("MainStackPanel")));
            this.CalleeNameText = ((System.Windows.Controls.TextBlock)(this.FindName("CalleeNameText")));
            this.CalleeInfoStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("CalleeInfoStackPanel")));
            this.CalleeNumberText = ((System.Windows.Controls.TextBlock)(this.FindName("CalleeNumberText")));
            this.CallStartTimeText = ((System.Windows.Controls.TextBlock)(this.FindName("CallStartTimeText")));
            this.AudioRouteStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("AudioRouteStackPanel")));
            this.EarpieceButton = ((System.Windows.Controls.Button)(this.FindName("EarpieceButton")));
            this.SpeakerButton = ((System.Windows.Controls.Button)(this.FindName("SpeakerButton")));
            this.BluetoothButton = ((System.Windows.Controls.Button)(this.FindName("BluetoothButton")));
            this.bigHead = ((System.Windows.Controls.MediaElement)(this.FindName("bigHead")));
            this.littleHead = ((System.Windows.Controls.MediaElement)(this.FindName("littleHead")));
            this.BottomStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("BottomStackPanel")));
            this.HangUpButton = ((System.Windows.Controls.Button)(this.FindName("HangUpButton")));
            this.HoldButton = ((System.Windows.Controls.Button)(this.FindName("HoldButton")));
            this.CameraToggleButton = ((System.Windows.Controls.Button)(this.FindName("CameraToggleButton")));
        }
    }
}
