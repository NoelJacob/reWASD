﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DiscSoft.NET.Common.View.Controls.Buttons;

namespace reWASDUI.Views.SecondaryWindows.AddExternalDeviceWizard
{
	public class GimxStage2 : UserControl, IComponentConnector
	{
		public GimxStage2()
		{
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.5.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/reWASD;component/views/secondarywindows/addexternaldevicewizard/addgimx/gimxstage2.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.5.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.NewDeviceDetectedTB = (TextBlock)target;
				return;
			case 2:
				this.MessageTextTB = (TextBlock)target;
				return;
			case 3:
				this.BackButton = (ColoredButton)target;
				return;
			case 4:
				this.NextButton = (ColoredButton)target;
				return;
			case 5:
				this.CancelButton = (ColoredButton)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		internal TextBlock NewDeviceDetectedTB;

		internal TextBlock MessageTextTB;

		internal ColoredButton BackButton;

		internal ColoredButton NextButton;

		internal ColoredButton CancelButton;

		private bool _contentLoaded;
	}
}
