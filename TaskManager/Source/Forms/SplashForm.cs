using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using TaskManager.Source.Utils;

namespace TaskManager.Source.Forms
{
	public partial class SplashForm : SplashScreen
	{
		public SplashForm()
		{
			InitializeComponent();
			labelVersion.Text += ProgramData.Version;
		}

		#region Overrides

		public override void ProcessCommand(Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);
		}

		#endregion

		public enum SplashScreenCommand
		{
		}
	}
}