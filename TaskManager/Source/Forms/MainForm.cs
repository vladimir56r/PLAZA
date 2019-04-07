using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TaskManager.Source.Data;
using TaskManager.Source.Utils;

namespace TaskManager.Source.Forms
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		TaskBase taskBase = new TaskBase(string.Empty);
		Task CurrentTask
		{
			get
			{
				if( gridView1.FocusedRowHandle < 0 ) return null;
				return gridView1.GetRow(gridView1.FocusedRowHandle) as Task;
			}
		}
		const string DefaultTaskBaseFName = @"bin\taskbases\TaskBase.tb";
		public MainForm()
		{
			SplashScreenManager.ShowForm(this, typeof(SplashForm), true, false, false);
			InitializeComponent();
			if( File.Exists(DefaultTaskBaseFName) )
				taskBase.Load(DefaultTaskBaseFName, string.Empty);
			else
				taskBase.Save(DefaultTaskBaseFName);
			gridControl1.DataSource = taskBase.Tasks;
			EditorUtils.CreateTaskStatusImageComboBox(repositoryItemImageComboBox3);
			EditorUtils.CreateFlagStatusImageComboBox(repositoryItemImageComboBox5);
			EditorUtils.InitPriorityComboBox(repositoryItemImageComboBox1);
			UpdateCurrentTask();
			Text = ProgramData.Caption;
			EnumProcessingHelper.RegisterEnum(typeof(TaskStatus));
			Thread.Sleep(1800);
			SplashScreenManager.CloseForm();
		}

		internal void EnabledFlagButtons(bool enabledCurrentTask, bool enabledEdit, Task task)
		{
			List<BarButtonItem> list = new List<BarButtonItem> { bbiTodayFlag, bbiTomorrowFlag, bbiThisWeekFlag,
				bbiNextWeekFlag, bbiNoDateFlag, bbiCustomFlag };
			foreach( BarButtonItem item in list )
			{
				item.Enabled = enabledCurrentTask;
				if( task != null )
					item.Down = task.FlagStatus.ToString() == (item.Tag as string);
				else item.Down = false;
			}
			bbiDeleteTask.Enabled = enabledCurrentTask;
			bbiEditTask.Enabled = enabledEdit;
		}

		private void bbiOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			//if( CurrentTask == null ) return;
			if( e.Column == colFlagStatus )
			{
				if( e.Button == MouseButtons.Left )
					CurrentTask.Complete = !CurrentTask.Complete;
				if( e.Button == MouseButtons.Right ) pmFlagStatus.ShowPopup(gridControl1.PointToScreen(e.Location));
				gridView1.LayoutChanged();
			}
			if( e.Button == MouseButtons.Left && e.RowHandle >= 0 && e.Clicks == 2 )
			{
				EditTask(CurrentTask);
			}
		}
		private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{
			if( e.RowHandle < 0 ) return;
			Task currentTask = gridView1.GetRow(e.RowHandle) as Task;
			if( currentTask == null ) return;
			if( currentTask.Status == TaskStatus.Completed )
			{
				e.Appearance.Font = FontResources.StrikeoutFont;
				e.Appearance.ForeColor = Utils.ColorUtils.DisabledTextColor;
			}
			if( currentTask.Status == TaskStatus.Deferred )
				e.Appearance.ForeColor = Utils.ColorUtils.DisabledTextColor;
			//if( e.Column == colDescription )
			//{
			//	var cell = (GridCellInfo)e.Cell;
			//	var editor = cell.Editor as DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit;
			//	editor.Appearance.Size = 5;
			//}
			if( currentTask.Status == TaskStatus.WaitingOnSomeoneElse )
			{
				e.Appearance.ForeColor = Utils.ColorUtils.WarningColor;
			}
			if( currentTask.Priority == TaskPriority.High && currentTask.Status != TaskStatus.Completed )
				e.Appearance.Font = FontResources.BoldFont;
			if( currentTask.Overdue )
				e.Appearance.ForeColor = Utils.ColorUtils.CriticalColor;
		}
		private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if( e.RowHandle == gridView1.FocusedRowHandle && gridView1.FocusedColumn != e.Column )
			{
				e.Appearance.BackColor = gridView1.PaintAppearance.FocusedRow.BackColor;
				e.Appearance.ForeColor = gridView1.PaintAppearance.FocusedRow.ForeColor;
			}
		}
		private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
		{
			if( e.Column == colPercent )
				e.RepositoryItem = repositoryItemTrackBar1;
		}
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			UpdateCurrentTask();
		}
		private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
		{
			UpdateCurrentTask();
		}
		private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{
			UpdateCurrentTask();
		}
		void UpdateCurrentTask()
		{
			if( CurrentTask != null )
				EnabledFlagButtons(true, AllowEdit, CurrentTask);
			else EnabledFlagButtons(false, AllowEdit, null);
		}
		private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			Task task = gridView1.GetRow(e.RowHandle) as Task;
			if( e.Column == colComplete && task != null )
			{
				task.Complete = !task.Complete;
				gridView1.CloseEditor();
				gridView1.UpdateCurrentRow();
			}
		}
		private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{
			if( e.Column.ColumnType == typeof(DateTime?) )
			{
				DateTime? value = e.Value as DateTime?;
				if( value == null || !value.HasValue )
					e.DisplayText = Properties.Resources.None;
			}
			if( e.Column == colPriority )
			{
				e.DisplayText = "";
			}
		}
		private void gridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if( e.KeyData == Keys.Enter && gridView1.FocusedRowHandle >= 0 )
				EditTask(CurrentTask);
		}
		DialogResult EditTask(Task task)
		{
			if( task == null ) return DialogResult.Ignore;
			DialogResult ret = DialogResult.Cancel;
			Cursor.Current = Cursors.WaitCursor;
			using( EditTaskForm frm = new EditTaskForm(task, ribbonControl1) )
			{
				ret = frm.ShowDialog(ribbonControl1);
			}
			UpdateCurrentTask();
			Cursor.Current = Cursors.Default;
			return ret;
		}

		private void rgbiCurrentViewTasks_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
		{
			ButtonClick(string.Format("{0}", e.Item.Tag));
		}
		private void rgbiCurrentView_GalleryInitDropDownGallery(object sender, InplaceGalleryEventArgs e)
		{
			e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiManageView);
			e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiSaveCurrentView);
			e.PopupGallery.SynchWithInRibbonGallery = true;
		}
		protected internal void ButtonClick(string tag)
		{
			gridView1.BeginUpdate();
			try
			{
				LoadDefaultLayout();
				switch( tag )
				{
					case TagResources.TaskList:
						colCreated.Group();
						colCreated.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
						break;
					case TagResources.TaskToDoList:
						gridView1.ActiveFilterString = "[Status] <> ##Enum#TaskManager.Source.Data.TaskStatus,Completed# And [DueDate] Is Not Null";
						colDueDate.Group();
						colCompleted.Visible = false;
						break;
					case TagResources.TaskCompleted:
						gridView1.ActiveFilterString = "[Status] = ##Enum#TaskManager.Source.Data.TaskStatus,Completed#";
						colCompleted.Group();
						colCompleted.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
						break;
					case TagResources.TaskToday:
						gridView1.ActiveFilterString = "IsOutlookIntervalToday([DueDate])";
						colPriority.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
						colCompleted.Visible = false;
						break;
					case TagResources.TaskPrioritized:
						colPriority.Group();
						colCategory.Group();
						colDueDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
						colCreated.Visible = false;
						break;
					case TagResources.TaskOverdue:
						gridView1.ActiveFilterString = "[Overdue] = True";
						colDueDate.Group();
						colCreated.Visible = false;
						colCompleted.Visible = false;
						break;
					case TagResources.TaskSimpleList:
						colDueDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
						colPriority.Visible = false;
						colCategory.Visible = false;
						colStatus.Visible = false;
						colPercent.Visible = false;
						colStartDate.Visible = false;
						colCompleted.Visible = false;
						break;
					case TagResources.TaskDeferred:
						gridView1.ActiveFilterString = "[Status] = ##Enum#TaskManager.Source.Data.TaskStatus,Deferred# Or [Status] = ##Enum#TaskManager.Source.Data.TaskStatus,WaitingOnSomeoneElse#";
						colCompleted.Group();
						colCreated.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
						colCompleted.Visible = false;
						break;
				}
			}
			finally
			{
				gridView1.FocusedRowHandle = 0;
				gridView1.MakeRowVisible(gridView1.FocusedRowHandle);
				gridView1.EndUpdate();
			}
		}
		void RemoveCurrentTask(List<Task> list)
		{
			if( gridView1.SelectedRowsCount == 0 && CurrentTask != null ) list.Remove(CurrentTask);
			else {
				List<Task> selectedTasks = new List<Task>();
				foreach( int index in gridView1.GetSelectedRows() )
				{
					Task task = gridView1.GetRow(index) as Task;
					if( task != null ) selectedTasks.Add(task);
				}
				foreach( Task task in selectedTasks ) list.Remove(task);
			}
		}
		void DoFlagStatusButtonClick(string tag)
		{
			if( CurrentTask == null ) return;
			if( !Enum.IsDefined(typeof(FlagStatus), tag) ) return;
			int day = -1;
			if( tag.Equals(FlagStatus.Today.ToString()) ) CurrentTask.DueDate = DateTime.Today;
			if( tag.Equals(FlagStatus.Tomorrow.ToString()) ) CurrentTask.DueDate = DateTime.Today.AddDays(1);
			if( tag.Equals(FlagStatus.ThisWeek.ToString()) )
			{
				if( CurrentTask.FlagStatus != FlagStatus.ThisWeek ) day = 5;
			}
			if( tag.Equals(FlagStatus.NextWeek.ToString()) )
			{
				if( CurrentTask.FlagStatus != FlagStatus.NextWeek ) day = 12;
			}
			if( day > 0 )
				CurrentTask.DueDate = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(DateTime.Today).AddDays(day);
			if( tag.Equals(FlagStatus.NoDate.ToString()) ) CurrentTask.DueDate = null;
			if( tag.Equals(FlagStatus.Custom.ToString()) )
			{
				using( CustomDateForm frm = new CustomDateForm(CurrentTask) )
					frm.ShowDialog(this);
			}
			CurrentTask.Complete = false;
			gridView1.LayoutChanged();
			EnabledFlagButtons(true, AllowEdit, CurrentTask);
		}
		bool AllowEdit
		{
			get
			{
				if( CurrentTask == null ) return false;
				if( gridView1.SelectedRowsCount == 1 ) return gridView1.FocusedRowHandle == gridView1.GetSelectedRows()[0];
				return gridView1.SelectedRowsCount == 0;
			}
		}
		void LoadDefaultLayout()
		{
			gridView1.ClearGrouping();
			gridView1.ClearSorting();
			gridView1.ActiveFilterString = string.Empty;
			for( int i = 0; i < gridView1.Columns.Count; i++ )
				if( gridView1.Columns[i] != colOverdue && gridView1.Columns[i].OptionsColumn.ShowInCustomizationForm )
					gridView1.Columns[i].VisibleIndex = i;
		}

		private void bbiDeleteTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int index = gridView1.FocusedRowHandle;
			gridView1.BeginDataUpdate();
			try
			{
				RemoveCurrentTask(taskBase.Tasks);
			}
			finally
			{
				gridView1.EndDataUpdate();
			}
			if( index > gridView1.DataRowCount - 1 ) index--;
			gridView1.FocusedRowHandle = index;
		}

		private void bbiNewTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Task task = new Task(Properties.Resources.NewTaskName);
			if( EditTask(task) == DialogResult.OK )
			{
				gridControl1.MainView.BeginDataUpdate();
				try
				{
					taskBase.Tasks.Add(task);
				}
				finally
				{
					gridControl1.MainView.EndDataUpdate();
				}
				ColumnView view = gridControl1.MainView as ColumnView;
				if( view != null )
				{
					GridUtils.GridViewFocusObject(view, task);
				}
			}
		}

		private void bbiEditTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			EditTask(CurrentTask);
		}

		private void bbiFlag_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DoFlagStatusButtonClick(e.Item.Tag as string);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			taskBase.Save();
		}
	}
}