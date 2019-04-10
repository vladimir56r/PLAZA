using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TaskManager.Source.Data;

namespace TaskManager.Source.Utils
{
	public static class ProgramData
	{
		/// <summary>
		/// Версия программы
		/// </summary>
		public static string Version { get { return "1.3"; } }
		/// <summary>
		/// Название программы
		/// </summary>
		public static string Name { get { return "PLAZA"; } }
		/// <summary>
		/// Заголовок программы
		/// </summary>
		public static string Caption { get { return $"{Name} (build {Version})"; } }
	}
	public static class MD5Provider
	{
		public static string GetHash(string input)
		{
			// Use input string to calculate MD5 hash
			using( MD5 md5 = MD5.Create() )
			{
				byte[] inputBytes = Encoding.ASCII.GetBytes(input);
				byte[] hashBytes = md5.ComputeHash(inputBytes);

				// Convert the byte array to hexadecimal string
				StringBuilder sb = new StringBuilder();
				for( int i = 0; i < hashBytes.Length; i++ )
				{
					sb.Append(hashBytes[i].ToString("X2"));
				}
				return sb.ToString();
			}
		}
	}
	public static class SerializationProvider
	{
		public static bool SaveObjectToFile(string fileName, object serializableObject)
		{
			using( var Writer = new FileStream(fileName, FileMode.OpenOrCreate) )
			{
				using( GZipStream stream = new GZipStream(Writer, CompressionMode.Compress) )
				{
					try
					{
						var BF = new BinaryFormatter();
						BF.Serialize(stream, serializableObject);
						return true;
					}
					catch( Exception error )
					{
						MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					return false;
				}
			}
		}
		public static object LoadObjectFromFile(string fileName)
		{
			using( var Reader = new FileStream(fileName, FileMode.Open) )
			{
				using( GZipStream stream = new GZipStream(Reader, CompressionMode.Decompress) )
				{
					try
					{
						var BF = new BinaryFormatter();
						return BF.Deserialize(stream);
					}
					catch( Exception error )
					{
						MessageBox.Show(error.Message, ProgramData.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			return null;
		}
	}

	public class TagResources
	{
		public const string TaskList = "TaskList";
		public const string TaskToDoList = "TaskToDoList";
		public const string TaskPrioritized = "TaskPrioritized";
		public const string TaskCompleted = "TaskCompleted";
		public const string TaskToday = "TaskToday";
		public const string TaskOverdue = "TaskOverdue";
		public const string TaskSimpleList = "TaskSimpleList";
		public const string TaskDeferred = "TaskDeferred";
		public const string TaskNew = "NewTask";
		public const string TaskEdit = "EditTask";
		public const string TaskDelete = "DeleteTask";
		public const string Preview = "ShowPreview";
	}
	public class ValidationRulesUtils
	{
		static ConditionValidationRule ruleIsNotBlank = null;
		public static ConditionValidationRule RuleIsNotBlank
		{
			get
			{
				if( ruleIsNotBlank == null )
				{
					ruleIsNotBlank = new ConditionValidationRule();
					ruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank;
					ruleIsNotBlank.ErrorText = Properties.Resources.RuleIsNotBlankWarning;
					ruleIsNotBlank.ErrorType = ErrorType.Critical;
				}
				return ruleIsNotBlank;
			}
		}
	}
	public class EditorUtils
	{
		public static RepositoryItemImageComboBox CreateTaskStatusImageComboBox(RepositoryItemImageComboBox edit)
		{
			Array arr = Enum.GetValues(typeof(TaskStatus));
			edit.Items.Clear();
			foreach( TaskStatus status in arr )
				edit.Items.Add(new ImageComboBoxItem(GetStringByTaskStatus(status), status, (int)status));
			return edit;
		}
		
		static string GetStringByTaskStatus(TaskStatus status)
		{
			switch( status )
			{
				case TaskStatus.Completed: return Properties.Resources.TaskStatusCompleted;
				case TaskStatus.Canceled: return Properties.Resources.TaskStatusCanceled;
				case TaskStatus.NotStarted: return Properties.Resources.TaskStatusNotStarted;
				case TaskStatus.TransferredTo: return Properties.Resources.TaskStatusTransferredTo;
				case TaskStatus.Deferred: return Properties.Resources.TaskStatusDeferred;
				case TaskStatus.InProgress: return Properties.Resources.TaskStatusInProgress;
				case TaskStatus.WaitingOnSomeoneElse: return Properties.Resources.TaskStatusWaitingOnSomeoneElse;
			}
			return Properties.Resources.TaskStatusNotStarted;
		}
		public static RepositoryItemImageComboBox CreateFlagStatusImageComboBox(RepositoryItemImageComboBox edit)
		{
			edit.Items.Clear();
			edit.SmallImages = CreateFlagStatusImageCollection();
			edit.GlyphAlignment = HorzAlignment.Center;
			edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Today, FlagStatus.Today, (int)FlagStatus.Today));
			edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Tomorrow, FlagStatus.Tomorrow, (int)FlagStatus.Tomorrow));
			edit.Items.Add(new ImageComboBoxItem(Properties.Resources.ThisWeek, FlagStatus.ThisWeek, (int)FlagStatus.ThisWeek));
			edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NextWeek, FlagStatus.NextWeek, (int)FlagStatus.NextWeek));
			edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NoDate, FlagStatus.NoDate, (int)FlagStatus.NoDate));
			edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Custom, FlagStatus.Custom, (int)FlagStatus.Custom));
			edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Completed, FlagStatus.Completed, (int)FlagStatus.Completed));
			return edit;
		}
		public static void InitPriorityComboBox(RepositoryItemImageComboBox edit)
		{
			edit.Items.Clear();
			edit.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
				new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityLow, TaskPriority.Low, 0),
				new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityMedium, TaskPriority.Normal, -1),
				new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityHigh, TaskPriority.High, 1)});
		}
		static ImageCollection CreateFlagStatusImageCollection()
		{
			ImageCollection ret = new ImageCollection();
			ret.AddImage(Properties.Resources.Today_Flag);
			ret.AddImage(Properties.Resources.Tomorrow_Flag);
			ret.AddImage(Properties.Resources.ThisWeek_Flag);
			ret.AddImage(Properties.Resources.NextWeek_Flag);
			ret.AddImage(Properties.Resources.NoDate_Flag);
			ret.AddImage(Properties.Resources.Custom_Flag);
			ret.AddImage(Properties.Resources.Completed_16x16);
			return ret;
		}
	}
	public class GridUtils
	{
		public static void SetFindControlImages(GridControl grid)
		{
			grid.ForceInitialize();
			FindControl fControl = null;
			foreach( Control ctrl in grid.Controls )
			{
				fControl = ctrl as FindControl;
				if( fControl != null ) break;
			}
			if( fControl != null )
			{
				fControl.FindButton.Image = global::TaskManager.Properties.Resources.Search;
				fControl.ClearButton.Image = global::TaskManager.Properties.Resources.Delete_16x16;
				fControl.CalcButtonsBestFit();
			}
		}
		public static void GridViewFocusObject(ColumnView cView, object obj)
		{
			if( obj == null ) return;
			int oldFocusedRowHandle = cView.FocusedRowHandle;
			for( int i = 0; i < cView.DataRowCount; ++i )
			{
				object rowObj = cView.GetRow(i) as object;
				if( rowObj == null ) continue;
				if( ReferenceEquals(obj, rowObj) )
				{
					if( i == oldFocusedRowHandle )
						cView.FocusedRowHandle = GridControl.InvalidRowHandle;
					cView.FocusedRowHandle = i;
					break;
				}
			}
		}
	}
	public class ImageUtils
	{
		public static Bitmap GetScaleImage(Image image, Size size)
		{
			return new Bitmap(image, size.Width, size.Height);
		}
		public static string GetFaviconIconPath(string link)
		{
			link = ObjectUtils.GetCorrectUrl(link);
			string[] links = link.Split('/');
			if( links.Length > 1 )
				return string.Format("http://{0}/favicon.ico", links[2]);
			return null;
		}
	}
	public class ObjectUtils
	{
		static RichEditDocumentServer rich = new RichEditDocumentServer();
		public static string GetPlainText(string htmlText)
		{
			rich.HtmlText = htmlText;
			return rich.Text.TrimStart();
		}
		public static void ShowWebSite(string url)
		{
			if( url == null ) return;
			string processName = GetCorrectUrl(url);
			if( processName.Length == 0 ) return;
			StartProcess(processName);
		}
		public static string GetCorrectUrl(string url)
		{
			string ret = url.Replace(" ", string.Empty);
			if( ret.Length == 0 ) return string.Empty;
			const string protocol = "http://";
			const string protocol2 = "https://";
			if( ret.IndexOf(protocol) != 0 && ret.IndexOf(protocol2) != 0 )
				ret = protocol + ret;
			return ret;
		}
		public static void StartProcess(string processName)
		{
			try
			{
				Process.Start(processName);
			}
			catch( Exception ex )
			{
				XtraMessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
	public class ColorUtils
	{
		public static void UpdateColor(ImageList list, UserLookAndFeel lf)
		{
			for( int i = 0; i < list.Images.Count; i++ )
				list.Images[i] = SetColor(list.Images[i] as Bitmap, GetHeaderForeColor(lf));
		}
		public static Color GetHeaderForeColor(UserLookAndFeel lf)
		{
			Color ret = SystemColors.ControlText;
			if( lf.ActiveStyle != ActiveLookAndFeelStyle.Skin ) return ret;
			return GridSkins.GetSkin(lf)[GridSkins.SkinHeader].Color.GetForeColor();
		}
		static Bitmap SetColor(Bitmap bmp, Color color)
		{
			for( int i = 0; i < bmp.Width; i++ )
				for( int j = 0; j < bmp.Height; j++ )
					if( bmp.GetPixel(i, j).Name != "0" )
						bmp.SetPixel(i, j, color);
			return bmp;
		}
		public static string HtmlHyperLinkTextColor
		{
			get
			{
				Color color = EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HyperLinkTextColor");
				return GetRGBColor(color);
			}
		}
		public static string HtmlHighlightTextColor
		{
			get
			{
				Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HighlightText");
				return GetRGBColor(color);
			}
		}
		public static string HtmlControlTextColor
		{
			get
			{
				Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("ControlText");
				return GetRGBColor(color);
			}
		}
		public static string HtmlControlTextColor2
		{
			get
			{
				Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
				return GetRGBColor(color);
			}
		}
		public static string HtmlQuestionColor
		{
			get
			{
				Color color = CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
				return GetRGBColor(color);
			}
		}
		public static string HtmlWarningColor
		{
			get
			{
				Color color = CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
				return GetRGBColor(color);
			}
		}
		public static Color DisabledTextColor
		{
			get
			{
				return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("DisabledText");
			}
		}
		public static Color CriticalColor
		{
			get
			{
				return CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
			}
		}
		public static Color WarningColor
		{
			get
			{
				return CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
			}
		}
		static string GetRGBColor(Color color)
		{
			return string.Format("{0},{1},{2}", color.R, color.G, color.B);
		}
	}
	public class FontResources
	{
		public static Font StrikeoutFont = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
		public static Font BoldFont = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
	}
}
