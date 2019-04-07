using System.Text;
using TaskManager.Source.Data;

namespace TaskManager.Source.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colComplete = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colIcon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.icEditors = new DevExpress.Utils.ImageCollection(this.components);
			this.colPriority = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colOverdue = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colSubject = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colExecutor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCreator = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCategory = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
			this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colCreated = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colPercent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
			this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colStartDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colDueDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCompleted = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colFlagStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemImageComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.ilColumns = new System.Windows.Forms.ImageList(this.components);
			this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.icCategory = new DevExpress.Utils.ImageCollection(this.components);
			this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.bbiOpen = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSaveAs = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNewTask = new DevExpress.XtraBars.BarButtonItem();
			this.bbiEditTask = new DevExpress.XtraBars.BarButtonItem();
			this.bbiDeleteTask = new DevExpress.XtraBars.BarButtonItem();
			this.bbiTodayFlag = new DevExpress.XtraBars.BarButtonItem();
			this.bbiTomorrowFlag = new DevExpress.XtraBars.BarButtonItem();
			this.bbiThisWeekFlag = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNextWeekFlag = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNoDateFlag = new DevExpress.XtraBars.BarButtonItem();
			this.bbiCustomFlag = new DevExpress.XtraBars.BarButtonItem();
			this.rgbiCurrentViewTasks = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.bbiManageView = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSaveCurrentView = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgTasks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgFollowUp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpdCurrentViewTasks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.pmFlagStatus = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pmFlagStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 95);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemProgressBar1,
            this.repositoryItemImageComboBox4,
            this.repositoryItemTrackBar1,
            this.repositoryItemImageComboBox5,
            this.repositoryItemRichTextEdit1});
			this.gridControl1.Size = new System.Drawing.Size(1093, 539);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colComplete,
            this.colIcon,
            this.colPriority,
            this.colSubject,
            this.colExecutor,
            this.colCreator,
            this.colStatus,
            this.colPercent,
            this.colCreated,
            this.colStartDate,
            this.colDueDate,
            this.colCompleted,
            this.colCategory,
            this.colFlagStatus,
            this.colOverdue,
            this.colDescription});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Subject", null, "")});
			this.gridView1.Images = this.ilColumns;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
			this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
			this.gridView1.OptionsDetail.EnableMasterViewMode = false;
			this.gridView1.OptionsFind.AlwaysVisible = true;
			this.gridView1.OptionsFind.FindFilterColumns = "Subject";
			this.gridView1.OptionsSelection.MultiSelect = true;
			this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
			this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
			this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
			this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
			this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
			this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
			this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
			this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
			// 
			// gridBand1
			// 
			this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridBand1.Columns.Add(this.colComplete);
			this.gridBand1.Columns.Add(this.colIcon);
			this.gridBand1.Columns.Add(this.colPriority);
			this.gridBand1.Columns.Add(this.colOverdue);
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.OptionsBand.AllowMove = false;
			this.gridBand1.OptionsBand.AllowSize = false;
			this.gridBand1.OptionsBand.FixedWidth = true;
			this.gridBand1.VisibleIndex = 0;
			this.gridBand1.Width = 104;
			// 
			// colComplete
			// 
			this.colComplete.FieldName = "Complete";
			this.colComplete.ImageAlignment = System.Drawing.StringAlignment.Center;
			this.colComplete.ImageIndex = 2;
			this.colComplete.Name = "colComplete";
			this.colComplete.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.colComplete.OptionsColumn.AllowMove = false;
			this.colComplete.OptionsColumn.AllowSize = false;
			this.colComplete.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.colComplete.OptionsColumn.FixedWidth = true;
			this.colComplete.OptionsColumn.ShowCaption = false;
			this.colComplete.OptionsColumn.ShowInCustomizationForm = false;
			this.colComplete.OptionsFilter.AllowFilter = false;
			this.colComplete.RowCount = 3;
			this.colComplete.ToolTip = "Complete";
			this.colComplete.Visible = true;
			this.colComplete.Width = 32;
			// 
			// colIcon
			// 
			this.colIcon.ColumnEdit = this.repositoryItemImageComboBox2;
			this.colIcon.FieldName = "Icon";
			this.colIcon.ImageAlignment = System.Drawing.StringAlignment.Center;
			this.colIcon.ImageIndex = 1;
			this.colIcon.Name = "colIcon";
			this.colIcon.OptionsColumn.AllowEdit = false;
			this.colIcon.OptionsColumn.AllowFocus = false;
			this.colIcon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.colIcon.OptionsColumn.AllowMove = false;
			this.colIcon.OptionsColumn.AllowSize = false;
			this.colIcon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.colIcon.OptionsColumn.FixedWidth = true;
			this.colIcon.OptionsColumn.ShowCaption = false;
			this.colIcon.OptionsFilter.AllowFilter = false;
			this.colIcon.RowCount = 3;
			this.colIcon.Visible = true;
			this.colIcon.Width = 32;
			// 
			// repositoryItemImageComboBox2
			// 
			this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
			this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0)});
			this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
			this.repositoryItemImageComboBox2.SmallImages = this.icEditors;
			// 
			// icEditors
			// 
			this.icEditors.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icEditors.ImageStream")));
			this.icEditors.Images.SetKeyName(0, "Low16x16.png");
			this.icEditors.Images.SetKeyName(1, "High16x16.png");
			this.icEditors.Images.SetKeyName(2, "Task_16x16.png");
			this.icEditors.Images.SetKeyName(3, "Report_16x16.png");
			// 
			// colPriority
			// 
			this.colPriority.ColumnEdit = this.repositoryItemImageComboBox1;
			this.colPriority.FieldName = "Priority";
			this.colPriority.ImageAlignment = System.Drawing.StringAlignment.Center;
			this.colPriority.ImageIndex = 0;
			this.colPriority.Name = "colPriority";
			this.colPriority.OptionsColumn.AllowMove = false;
			this.colPriority.OptionsColumn.AllowSize = false;
			this.colPriority.OptionsColumn.FixedWidth = true;
			this.colPriority.OptionsColumn.ShowCaption = false;
			this.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colPriority.RowCount = 3;
			this.colPriority.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
			this.colPriority.ToolTip = "Приоритет";
			this.colPriority.Visible = true;
			this.colPriority.Width = 40;
			// 
			// repositoryItemImageComboBox1
			// 
			this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
			this.repositoryItemImageComboBox1.SmallImages = this.icEditors;
			// 
			// colOverdue
			// 
			this.colOverdue.FieldName = "Overdue";
			this.colOverdue.Name = "colOverdue";
			this.colOverdue.OptionsColumn.ShowInCustomizationForm = false;
			// 
			// gridBand2
			// 
			this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand2.Caption = "Основные параметры";
			this.gridBand2.Columns.Add(this.colSubject);
			this.gridBand2.Columns.Add(this.colExecutor);
			this.gridBand2.Columns.Add(this.colCreator);
			this.gridBand2.Columns.Add(this.colCategory);
			this.gridBand2.Columns.Add(this.colDescription);
			this.gridBand2.Name = "gridBand2";
			this.gridBand2.OptionsBand.AllowMove = false;
			this.gridBand2.VisibleIndex = 1;
			this.gridBand2.Width = 665;
			// 
			// colSubject
			// 
			this.colSubject.Caption = "Тема задания";
			this.colSubject.FieldName = "Subject";
			this.colSubject.Name = "colSubject";
			this.colSubject.OptionsColumn.AllowEdit = false;
			this.colSubject.OptionsColumn.AllowFocus = false;
			this.colSubject.OptionsColumn.AllowMove = false;
			this.colSubject.Visible = true;
			this.colSubject.Width = 171;
			// 
			// colExecutor
			// 
			this.colExecutor.Caption = "Исполнитель";
			this.colExecutor.FieldName = "Executor";
			this.colExecutor.Name = "colExecutor";
			this.colExecutor.OptionsColumn.AllowEdit = false;
			this.colExecutor.OptionsColumn.AllowFocus = false;
			this.colExecutor.OptionsColumn.AllowMove = false;
			this.colExecutor.Visible = true;
			this.colExecutor.Width = 189;
			// 
			// colCreator
			// 
			this.colCreator.Caption = "Заявитель";
			this.colCreator.FieldName = "Creator";
			this.colCreator.Name = "colCreator";
			this.colCreator.OptionsColumn.AllowEdit = false;
			this.colCreator.OptionsColumn.AllowFocus = false;
			this.colCreator.OptionsColumn.AllowMove = false;
			this.colCreator.Visible = true;
			this.colCreator.Width = 156;
			// 
			// colCategory
			// 
			this.colCategory.Caption = "Группа";
			this.colCategory.FieldName = "Category";
			this.colCategory.Name = "colCategory";
			this.colCategory.OptionsColumn.AllowEdit = false;
			this.colCategory.OptionsColumn.AllowFocus = false;
			this.colCategory.OptionsColumn.AllowMove = false;
			this.colCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colCategory.Visible = true;
			this.colCategory.Width = 149;
			// 
			// colDescription
			// 
			this.colDescription.Caption = "Описание задачи";
			this.colDescription.ColumnEdit = this.repositoryItemRichTextEdit1;
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.OptionsColumn.AllowMove = false;
			this.colDescription.RowCount = 2;
			this.colDescription.RowIndex = 1;
			this.colDescription.Visible = true;
			this.colDescription.Width = 665;
			// 
			// repositoryItemRichTextEdit1
			// 
			this.repositoryItemRichTextEdit1.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
			this.repositoryItemRichTextEdit1.EncodingWebName = "utf-8";
			this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
			this.repositoryItemRichTextEdit1.ReadOnly = true;
			this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
			// 
			// gridBand3
			// 
			this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand3.Caption = "Состояние задачи";
			this.gridBand3.Columns.Add(this.colCreated);
			this.gridBand3.Columns.Add(this.colStatus);
			this.gridBand3.Columns.Add(this.colPercent);
			this.gridBand3.Name = "gridBand3";
			this.gridBand3.OptionsBand.AllowMove = false;
			this.gridBand3.OptionsBand.AllowSize = false;
			this.gridBand3.OptionsBand.FixedWidth = true;
			this.gridBand3.VisibleIndex = 2;
			this.gridBand3.Width = 150;
			// 
			// colCreated
			// 
			this.colCreated.Caption = "Добавлено";
			this.colCreated.FieldName = "CreatedDate";
			this.colCreated.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colCreated.Name = "colCreated";
			this.colCreated.OptionsColumn.AllowEdit = false;
			this.colCreated.OptionsColumn.AllowFocus = false;
			this.colCreated.OptionsColumn.AllowMove = false;
			this.colCreated.Visible = true;
			this.colCreated.Width = 150;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Статус";
			this.colStatus.ColumnEdit = this.repositoryItemImageComboBox3;
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.OptionsColumn.AllowMove = false;
			this.colStatus.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colStatus.RowIndex = 1;
			this.colStatus.Visible = true;
			this.colStatus.Width = 150;
			// 
			// repositoryItemImageComboBox3
			// 
			this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
			this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
			// 
			// colPercent
			// 
			this.colPercent.Caption = "Завершено";
			this.colPercent.ColumnEdit = this.repositoryItemProgressBar1;
			this.colPercent.FieldName = "PercentComplete";
			this.colPercent.Name = "colPercent";
			this.colPercent.OptionsColumn.AllowMove = false;
			this.colPercent.RowIndex = 2;
			this.colPercent.Visible = true;
			this.colPercent.Width = 150;
			// 
			// repositoryItemProgressBar1
			// 
			this.repositoryItemProgressBar1.LookAndFeel.SkinName = "Office 2010 Black";
			this.repositoryItemProgressBar1.LookAndFeel.UseDefaultLookAndFeel = false;
			this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
			this.repositoryItemProgressBar1.ShowTitle = true;
			// 
			// gridBand4
			// 
			this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand4.Caption = "Время";
			this.gridBand4.Columns.Add(this.colStartDate);
			this.gridBand4.Columns.Add(this.colDueDate);
			this.gridBand4.Columns.Add(this.colCompleted);
			this.gridBand4.Name = "gridBand4";
			this.gridBand4.OptionsBand.AllowMove = false;
			this.gridBand4.OptionsBand.AllowSize = false;
			this.gridBand4.OptionsBand.FixedWidth = true;
			this.gridBand4.VisibleIndex = 3;
			this.gridBand4.Width = 78;
			// 
			// colStartDate
			// 
			this.colStartDate.Caption = "Дата начала";
			this.colStartDate.FieldName = "StartDate";
			this.colStartDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colStartDate.Name = "colStartDate";
			this.colStartDate.OptionsColumn.AllowMove = false;
			this.colStartDate.Visible = true;
			this.colStartDate.Width = 78;
			// 
			// colDueDate
			// 
			this.colDueDate.Caption = "Дедлайн";
			this.colDueDate.FieldName = "DueDate";
			this.colDueDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colDueDate.Name = "colDueDate";
			this.colDueDate.OptionsColumn.AllowMove = false;
			this.colDueDate.RowIndex = 1;
			this.colDueDate.Visible = true;
			this.colDueDate.Width = 78;
			// 
			// colCompleted
			// 
			this.colCompleted.Caption = "Выполнено";
			this.colCompleted.FieldName = "CompletedDate";
			this.colCompleted.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colCompleted.Name = "colCompleted";
			this.colCompleted.OptionsColumn.AllowEdit = false;
			this.colCompleted.OptionsColumn.AllowFocus = false;
			this.colCompleted.OptionsColumn.AllowMove = false;
			this.colCompleted.RowIndex = 2;
			this.colCompleted.Visible = true;
			this.colCompleted.Width = 78;
			// 
			// gridBand5
			// 
			this.gridBand5.Columns.Add(this.colFlagStatus);
			this.gridBand5.Name = "gridBand5";
			this.gridBand5.OptionsBand.AllowMove = false;
			this.gridBand5.OptionsBand.AllowSize = false;
			this.gridBand5.OptionsBand.FixedWidth = true;
			this.gridBand5.VisibleIndex = 4;
			this.gridBand5.Width = 35;
			// 
			// colFlagStatus
			// 
			this.colFlagStatus.ColumnEdit = this.repositoryItemImageComboBox5;
			this.colFlagStatus.FieldName = "FlagStatus";
			this.colFlagStatus.ImageIndex = 3;
			this.colFlagStatus.Name = "colFlagStatus";
			this.colFlagStatus.OptionsColumn.AllowEdit = false;
			this.colFlagStatus.OptionsColumn.AllowFocus = false;
			this.colFlagStatus.OptionsColumn.AllowMove = false;
			this.colFlagStatus.OptionsColumn.AllowSize = false;
			this.colFlagStatus.OptionsColumn.FixedWidth = true;
			this.colFlagStatus.OptionsColumn.ShowCaption = false;
			this.colFlagStatus.RowCount = 3;
			this.colFlagStatus.ToolTip = "Метка";
			this.colFlagStatus.Visible = true;
			this.colFlagStatus.Width = 35;
			// 
			// repositoryItemImageComboBox5
			// 
			this.repositoryItemImageComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
			this.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5";
			// 
			// ilColumns
			// 
			this.ilColumns.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilColumns.ImageStream")));
			this.ilColumns.TransparentColor = System.Drawing.Color.Transparent;
			this.ilColumns.Images.SetKeyName(0, "Importance.png");
			this.ilColumns.Images.SetKeyName(1, "Icon.png");
			this.ilColumns.Images.SetKeyName(2, "Complete.png");
			this.ilColumns.Images.SetKeyName(3, "Flag.png");
			// 
			// repositoryItemImageComboBox4
			// 
			this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
			this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
			this.repositoryItemImageComboBox4.SmallImages = this.icCategory;
			// 
			// icCategory
			// 
			this.icCategory.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icCategory.ImageStream")));
			this.icCategory.Images.SetKeyName(0, "HouseChores_16x16.png");
			this.icCategory.Images.SetKeyName(1, "BO_Cart.png");
			this.icCategory.Images.SetKeyName(2, "BO_Organization.png");
			// 
			// repositoryItemTrackBar1
			// 
			this.repositoryItemTrackBar1.LargeChange = 10;
			this.repositoryItemTrackBar1.LookAndFeel.SkinName = "Office 2010 Black";
			this.repositoryItemTrackBar1.LookAndFeel.UseDefaultLookAndFeel = false;
			this.repositoryItemTrackBar1.Maximum = 100;
			this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
			this.repositoryItemTrackBar1.ShowValueToolTip = true;
			this.repositoryItemTrackBar1.SmallChange = 5;
			this.repositoryItemTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiOpen,
            this.bbiSave,
            this.bbiSaveAs,
            this.bbiNewTask,
            this.bbiEditTask,
            this.bbiDeleteTask,
            this.bbiTodayFlag,
            this.bbiTomorrowFlag,
            this.bbiThisWeekFlag,
            this.bbiNextWeekFlag,
            this.bbiNoDateFlag,
            this.bbiCustomFlag,
            this.rgbiCurrentViewTasks,
            this.bbiManageView,
            this.bbiSaveCurrentView});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 4;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Size = new System.Drawing.Size(1093, 95);
			this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
			this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// bbiOpen
			// 
			this.bbiOpen.Caption = "Открыть";
			this.bbiOpen.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiOpen.Glyph")));
			this.bbiOpen.Id = 1;
			this.bbiOpen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiOpen.LargeGlyph")));
			this.bbiOpen.Name = "bbiOpen";
			this.bbiOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOpen_ItemClick);
			// 
			// bbiSave
			// 
			this.bbiSave.Caption = "Сохранить";
			this.bbiSave.Glyph = global::TaskManager.Properties.Resources.Save_16x16;
			this.bbiSave.Id = 2;
			this.bbiSave.LargeGlyph = global::TaskManager.Properties.Resources.Save_32x32;
			this.bbiSave.Name = "bbiSave";
			// 
			// bbiSaveAs
			// 
			this.bbiSaveAs.Caption = "Сохранить как";
			this.bbiSaveAs.Glyph = global::TaskManager.Properties.Resources.SaveAll_32x32;
			this.bbiSaveAs.Id = 3;
			this.bbiSaveAs.LargeGlyph = global::TaskManager.Properties.Resources.SaveAll_32x32;
			this.bbiSaveAs.Name = "bbiSaveAs";
			// 
			// bbiNewTask
			// 
			this.bbiNewTask.Caption = "Добавить";
			this.bbiNewTask.Glyph = global::TaskManager.Properties.Resources.NewTask_16x16;
			this.bbiNewTask.Id = 54;
			this.bbiNewTask.LargeGlyph = global::TaskManager.Properties.Resources.NewTask_32x32;
			this.bbiNewTask.LargeWidth = 68;
			this.bbiNewTask.Name = "bbiNewTask";
			this.bbiNewTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNewTask_ItemClick);
			// 
			// bbiEditTask
			// 
			this.bbiEditTask.Caption = "Изменить";
			this.bbiEditTask.Glyph = global::TaskManager.Properties.Resources.EditTask_16x16;
			this.bbiEditTask.Id = 55;
			this.bbiEditTask.LargeGlyph = global::TaskManager.Properties.Resources.EditTask_32x32;
			this.bbiEditTask.LargeWidth = 68;
			this.bbiEditTask.Name = "bbiEditTask";
			this.bbiEditTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditTask_ItemClick);
			// 
			// bbiDeleteTask
			// 
			this.bbiDeleteTask.Caption = "Удалить";
			this.bbiDeleteTask.Glyph = global::TaskManager.Properties.Resources.Delete_16x16;
			this.bbiDeleteTask.Id = 56;
			this.bbiDeleteTask.LargeGlyph = global::TaskManager.Properties.Resources.Delete_32x32;
			this.bbiDeleteTask.LargeWidth = 68;
			this.bbiDeleteTask.Name = "bbiDeleteTask";
			this.bbiDeleteTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeleteTask_ItemClick);
			// 
			// bbiTodayFlag
			// 
			this.bbiTodayFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.bbiTodayFlag.Caption = "Сегодня";
			this.bbiTodayFlag.Glyph = global::TaskManager.Properties.Resources.Today_Flag;
			this.bbiTodayFlag.Id = 45;
			this.bbiTodayFlag.Name = "bbiTodayFlag";
			this.bbiTodayFlag.Tag = "Today";
			this.bbiTodayFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiTomorrowFlag
			// 
			this.bbiTomorrowFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.bbiTomorrowFlag.Caption = "Завтра";
			this.bbiTomorrowFlag.Glyph = global::TaskManager.Properties.Resources.Tomorrow_Flag;
			this.bbiTomorrowFlag.Id = 46;
			this.bbiTomorrowFlag.Name = "bbiTomorrowFlag";
			this.bbiTomorrowFlag.Tag = "Tomorrow";
			this.bbiTomorrowFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiThisWeekFlag
			// 
			this.bbiThisWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.bbiThisWeekFlag.Caption = "Эта неделя";
			this.bbiThisWeekFlag.Glyph = global::TaskManager.Properties.Resources.ThisWeek_Flag;
			this.bbiThisWeekFlag.Id = 47;
			this.bbiThisWeekFlag.Name = "bbiThisWeekFlag";
			this.bbiThisWeekFlag.Tag = "ThisWeek";
			this.bbiThisWeekFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiNextWeekFlag
			// 
			this.bbiNextWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.bbiNextWeekFlag.Caption = "Следующая неделя";
			this.bbiNextWeekFlag.Glyph = global::TaskManager.Properties.Resources.NextWeek_Flag;
			this.bbiNextWeekFlag.Id = 48;
			this.bbiNextWeekFlag.Name = "bbiNextWeekFlag";
			this.bbiNextWeekFlag.Tag = "NextWeek";
			this.bbiNextWeekFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiNoDateFlag
			// 
			this.bbiNoDateFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.bbiNoDateFlag.Caption = "Без ограничений";
			this.bbiNoDateFlag.Glyph = global::TaskManager.Properties.Resources.NoDate_Flag;
			this.bbiNoDateFlag.Id = 49;
			this.bbiNoDateFlag.Name = "bbiNoDateFlag";
			this.bbiNoDateFlag.Tag = "NoDate";
			this.bbiNoDateFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiCustomFlag
			// 
			this.bbiCustomFlag.Caption = "Произвольная дата";
			this.bbiCustomFlag.Glyph = global::TaskManager.Properties.Resources.Custom_Flag;
			this.bbiCustomFlag.Id = 50;
			this.bbiCustomFlag.Name = "bbiCustomFlag";
			this.bbiCustomFlag.Tag = "Custom";
			this.bbiCustomFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// rgbiCurrentViewTasks
			// 
			// 
			// 
			// 
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseFont = true;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
			this.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.rgbiCurrentViewTasks.Gallery.ColumnCount = 4;
			galleryItem1.Checked = true;
			galleryItem1.Image = global::TaskManager.Properties.Resources.ListByDate_32x32;
			galleryItem1.Tag = "TaskList";
			galleryItem2.Image = global::TaskManager.Properties.Resources.ToDoList_32x32;
			galleryItem2.Tag = "TaskToDoList";
			galleryItem3.Image = global::TaskManager.Properties.Resources.Completed_32x32;
			galleryItem3.Tag = "TaskCompleted";
			galleryItem4.Image = global::TaskManager.Properties.Resources.Today_32x32;
			galleryItem4.Tag = "TaskToday";
			galleryItem5.Image = global::TaskManager.Properties.Resources.Prioritized_32x32;
			galleryItem5.Tag = "TaskPrioritized";
			galleryItem6.Image = global::TaskManager.Properties.Resources.Overdue_32x32;
			galleryItem6.Tag = "TaskOverdue";
			galleryItem7.Image = global::TaskManager.Properties.Resources.List_32x32;
			galleryItem7.Tag = "TaskSimpleList";
			galleryItem8.Image = global::TaskManager.Properties.Resources.Deferred_32x32;
			galleryItem8.Tag = "TaskDeferred";
			galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7,
            galleryItem8});
			this.rgbiCurrentViewTasks.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.rgbiCurrentViewTasks.Gallery.ImageSize = new System.Drawing.Size(32, 32);
			this.rgbiCurrentViewTasks.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
			this.rgbiCurrentViewTasks.Gallery.RowCount = 2;
			this.rgbiCurrentViewTasks.Gallery.ShowItemText = true;
			this.rgbiCurrentViewTasks.Id = 44;
			this.rgbiCurrentViewTasks.Name = "rgbiCurrentViewTasks";
			this.rgbiCurrentViewTasks.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiCurrentViewTasks_GalleryItemClick);
			this.rgbiCurrentViewTasks.GalleryInitDropDownGallery += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.rgbiCurrentView_GalleryInitDropDownGallery);
			// 
			// bbiManageView
			// 
			this.bbiManageView.Enabled = false;
			this.bbiManageView.Id = 42;
			this.bbiManageView.Name = "bbiManageView";
			// 
			// bbiSaveCurrentView
			// 
			this.bbiSaveCurrentView.Enabled = false;
			this.bbiSaveCurrentView.Id = 43;
			this.bbiSaveCurrentView.Name = "bbiSaveCurrentView";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rpgTasks,
            this.rpgFollowUp,
            this.rpdCurrentViewTasks});
			this.ribbonPage1.Name = "ribbonPage1";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.bbiOpen);
			this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
			this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAs);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Файл";
			this.ribbonPageGroup1.Visible = false;
			// 
			// rpgTasks
			// 
			this.rpgTasks.ItemLinks.Add(this.bbiNewTask);
			this.rpgTasks.ItemLinks.Add(this.bbiEditTask);
			this.rpgTasks.ItemLinks.Add(this.bbiDeleteTask, true);
			this.rpgTasks.Name = "rpgTasks";
			this.rpgTasks.ShowCaptionButton = false;
			this.rpgTasks.Text = "Задачи";
			// 
			// rpgFollowUp
			// 
			this.rpgFollowUp.ItemLinks.Add(this.bbiTodayFlag);
			this.rpgFollowUp.ItemLinks.Add(this.bbiTomorrowFlag);
			this.rpgFollowUp.ItemLinks.Add(this.bbiThisWeekFlag);
			this.rpgFollowUp.ItemLinks.Add(this.bbiNextWeekFlag);
			this.rpgFollowUp.ItemLinks.Add(this.bbiNoDateFlag);
			this.rpgFollowUp.ItemLinks.Add(this.bbiCustomFlag);
			this.rpgFollowUp.Name = "rpgFollowUp";
			this.rpgFollowUp.ShowCaptionButton = false;
			this.rpgFollowUp.Text = "Дедлайн";
			// 
			// rpdCurrentViewTasks
			// 
			this.rpdCurrentViewTasks.ItemLinks.Add(this.rgbiCurrentViewTasks);
			this.rpdCurrentViewTasks.Name = "rpdCurrentViewTasks";
			this.rpdCurrentViewTasks.ShowCaptionButton = false;
			this.rpdCurrentViewTasks.Text = "Отображение";
			// 
			// pmFlagStatus
			// 
			this.pmFlagStatus.ItemLinks.Add(this.bbiTodayFlag);
			this.pmFlagStatus.ItemLinks.Add(this.bbiTomorrowFlag);
			this.pmFlagStatus.ItemLinks.Add(this.bbiThisWeekFlag);
			this.pmFlagStatus.ItemLinks.Add(this.bbiNextWeekFlag);
			this.pmFlagStatus.ItemLinks.Add(this.bbiNoDateFlag);
			this.pmFlagStatus.ItemLinks.Add(this.bbiCustomFlag, true);
			this.pmFlagStatus.Name = "pmFlagStatus";
			this.pmFlagStatus.Ribbon = this.ribbonControl1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 634);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.ribbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.LookAndFeel.UseDefaultLookAndFeel = false;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PLAZA";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pmFlagStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraBars.BarButtonItem bbiOpen;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox5;
		private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
		private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
		private DevExpress.Utils.ImageCollection icEditors;
		private DevExpress.Utils.ImageCollection icCategory;
		private System.Windows.Forms.ImageList ilColumns;
		private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridView1;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOverdue;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFlagStatus;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCategory;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCompleted;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDueDate;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStartDate;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreated;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPercent;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStatus;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreator;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colExecutor;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSubject;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPriority;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIcon;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colComplete;
		private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
		private DevExpress.XtraBars.BarButtonItem bbiSave;
		private DevExpress.XtraBars.BarButtonItem bbiSaveAs;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTasks;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFollowUp;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpdCurrentViewTasks;
		private DevExpress.XtraBars.BarButtonItem bbiNewTask;
		private DevExpress.XtraBars.BarButtonItem bbiEditTask;
		private DevExpress.XtraBars.BarButtonItem bbiDeleteTask;
		private DevExpress.XtraBars.BarButtonItem bbiTodayFlag;
		private DevExpress.XtraBars.BarButtonItem bbiTomorrowFlag;
		private DevExpress.XtraBars.BarButtonItem bbiThisWeekFlag;
		private DevExpress.XtraBars.BarButtonItem bbiNextWeekFlag;
		private DevExpress.XtraBars.BarButtonItem bbiNoDateFlag;
		private DevExpress.XtraBars.BarButtonItem bbiCustomFlag;
		private DevExpress.XtraBars.RibbonGalleryBarItem rgbiCurrentViewTasks;
		private DevExpress.XtraBars.BarButtonItem bbiManageView;
		private DevExpress.XtraBars.BarButtonItem bbiSaveCurrentView;
		private DevExpress.XtraBars.PopupMenu pmFlagStatus;
	}
}