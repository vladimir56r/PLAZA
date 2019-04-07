using System;

namespace TaskManager.Source.Forms
{
	public partial class LoginForm : DevExpress.XtraEditors.XtraForm
	{
		public string Password { get; private set; }
		public string Login { get; set; }
		public LoginForm(string BtnCaption)
		{
			InitializeComponent();
			btn.Text = BtnCaption;
		}

		private void btn_Click(object sender, EventArgs e)
		{
			Login = loginEdit.Text;
			Password = passwordEdit.Text;
			Close();
		}
	}
}