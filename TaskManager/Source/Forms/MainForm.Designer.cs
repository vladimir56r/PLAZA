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
			this.icEditors = new DevExpress.Utils.ImageCollection();
			this.colPriority = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colOverdue = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colSubject = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colExecutor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCreator = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCategory = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.icCategory = new DevExpress.Utils.ImageCollection();
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
			this.ilColumns = new System.Windows.Forms.ImageList();
			this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
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
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			resources.ApplyResources(this.gridControl1, "gridControl1");
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
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
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
			resources.ApplyResources(this.gridBand1, "gridBand1");
			this.gridBand1.OptionsBand.AllowMove = false;
			this.gridBand1.OptionsBand.AllowSize = false;
			this.gridBand1.OptionsBand.FixedWidth = true;
			this.gridBand1.VisibleIndex = 0;
			// 
			// colComplete
			// 
			this.colComplete.FieldName = "Complete";
			resources.ApplyResources(this.colComplete, "colComplete");
			this.colComplete.Name = "colComplete";
			this.colComplete.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.colComplete.OptionsColumn.AllowSize = false;
			this.colComplete.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.colComplete.OptionsColumn.FixedWidth = true;
			this.colComplete.OptionsColumn.ShowCaption = false;
			this.colComplete.OptionsColumn.ShowInCustomizationForm = false;
			this.colComplete.OptionsFilter.AllowFilter = false;
			this.colComplete.RowCount = 3;
			// 
			// colIcon
			// 
			this.colIcon.ColumnEdit = this.repositoryItemImageComboBox2;
			this.colIcon.FieldName = "Icon";
			resources.ApplyResources(this.colIcon, "colIcon");
			this.colIcon.Name = "colIcon";
			this.colIcon.OptionsColumn.AllowEdit = false;
			this.colIcon.OptionsColumn.AllowFocus = false;
			this.colIcon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.colIcon.OptionsColumn.AllowSize = false;
			this.colIcon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.colIcon.OptionsColumn.FixedWidth = true;
			this.colIcon.OptionsColumn.ShowCaption = false;
			this.colIcon.OptionsFilter.AllowFilter = false;
			this.colIcon.RowCount = 3;
			// 
			// repositoryItemImageComboBox2
			// 
			this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox2.Buttons"))))});
			this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items5"))))});
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
			resources.ApplyResources(this.colPriority, "colPriority");
			this.colPriority.Name = "colPriority";
			this.colPriority.OptionsColumn.AllowSize = false;
			this.colPriority.OptionsColumn.FixedWidth = true;
			this.colPriority.OptionsColumn.ShowCaption = false;
			this.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colPriority.RowCount = 3;
			this.colPriority.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
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
			resources.ApplyResources(this.gridBand2, "gridBand2");
			this.gridBand2.Columns.Add(this.colSubject);
			this.gridBand2.Columns.Add(this.colExecutor);
			this.gridBand2.Columns.Add(this.colCreator);
			this.gridBand2.Columns.Add(this.colCategory);
			this.gridBand2.Columns.Add(this.colDescription);
			this.gridBand2.OptionsBand.AllowMove = false;
			this.gridBand2.VisibleIndex = 1;
			// 
			// colSubject
			// 
			resources.ApplyResources(this.colSubject, "colSubject");
			this.colSubject.FieldName = "Subject";
			this.colSubject.Name = "colSubject";
			this.colSubject.OptionsColumn.AllowEdit = false;
			this.colSubject.OptionsColumn.AllowFocus = false;
			// 
			// colExecutor
			// 
			resources.ApplyResources(this.colExecutor, "colExecutor");
			this.colExecutor.FieldName = "Executor";
			this.colExecutor.Name = "colExecutor";
			this.colExecutor.OptionsColumn.AllowEdit = false;
			this.colExecutor.OptionsColumn.AllowFocus = false;
			// 
			// colCreator
			// 
			resources.ApplyResources(this.colCreator, "colCreator");
			this.colCreator.FieldName = "Creator";
			this.colCreator.Name = "colCreator";
			this.colCreator.OptionsColumn.AllowEdit = false;
			this.colCreator.OptionsColumn.AllowFocus = false;
			// 
			// colCategory
			// 
			resources.ApplyResources(this.colCategory, "colCategory");
			this.colCategory.ColumnEdit = this.repositoryItemImageComboBox4;
			this.colCategory.FieldName = "Category";
			this.colCategory.Name = "colCategory";
			this.colCategory.OptionsColumn.AllowEdit = false;
			this.colCategory.OptionsColumn.AllowFocus = false;
			this.colCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			// 
			// repositoryItemImageComboBox4
			// 
			this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox4.Buttons"))))});
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
			// colDescription
			// 
			resources.ApplyResources(this.colDescription, "colDescription");
			this.colDescription.ColumnEdit = this.repositoryItemRichTextEdit1;
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.RowCount = 2;
			this.colDescription.RowIndex = 1;
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
			resources.ApplyResources(this.gridBand3, "gridBand3");
			this.gridBand3.Columns.Add(this.colCreated);
			this.gridBand3.Columns.Add(this.colStatus);
			this.gridBand3.Columns.Add(this.colPercent);
			this.gridBand3.OptionsBand.AllowMove = false;
			this.gridBand3.OptionsBand.AllowSize = false;
			this.gridBand3.OptionsBand.FixedWidth = true;
			this.gridBand3.VisibleIndex = 2;
			// 
			// colCreated
			// 
			resources.ApplyResources(this.colCreated, "colCreated");
			this.colCreated.FieldName = "CreatedDate";
			this.colCreated.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colCreated.Name = "colCreated";
			this.colCreated.OptionsColumn.AllowEdit = false;
			this.colCreated.OptionsColumn.AllowFocus = false;
			// 
			// colStatus
			// 
			resources.ApplyResources(this.colStatus, "colStatus");
			this.colStatus.ColumnEdit = this.repositoryItemImageComboBox3;
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colStatus.RowIndex = 1;
			// 
			// repositoryItemImageComboBox3
			// 
			this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox3.Buttons"))))});
			this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
			// 
			// colPercent
			// 
			resources.ApplyResources(this.colPercent, "colPercent");
			this.colPercent.ColumnEdit = this.repositoryItemProgressBar1;
			this.colPercent.FieldName = "PercentComplete";
			this.colPercent.Name = "colPercent";
			this.colPercent.RowIndex = 2;
			// 
			// repositoryItemProgressBar1
			// 
			this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
			this.repositoryItemProgressBar1.ShowTitle = true;
			// 
			// gridBand4
			// 
			this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			resources.ApplyResources(this.gridBand4, "gridBand4");
			this.gridBand4.Columns.Add(this.colStartDate);
			this.gridBand4.Columns.Add(this.colDueDate);
			this.gridBand4.Columns.Add(this.colCompleted);
			this.gridBand4.OptionsBand.AllowMove = false;
			this.gridBand4.OptionsBand.AllowSize = false;
			this.gridBand4.OptionsBand.FixedWidth = true;
			this.gridBand4.VisibleIndex = 3;
			// 
			// colStartDate
			// 
			resources.ApplyResources(this.colStartDate, "colStartDate");
			this.colStartDate.FieldName = "StartDate";
			this.colStartDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colStartDate.Name = "colStartDate";
			// 
			// colDueDate
			// 
			resources.ApplyResources(this.colDueDate, "colDueDate");
			this.colDueDate.FieldName = "DueDate";
			this.colDueDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colDueDate.Name = "colDueDate";
			this.colDueDate.RowIndex = 1;
			// 
			// colCompleted
			// 
			resources.ApplyResources(this.colCompleted, "colCompleted");
			this.colCompleted.FieldName = "CompletedDate";
			this.colCompleted.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
			this.colCompleted.Name = "colCompleted";
			this.colCompleted.OptionsColumn.AllowEdit = false;
			this.colCompleted.OptionsColumn.AllowFocus = false;
			this.colCompleted.RowIndex = 2;
			// 
			// gridBand5
			// 
			this.gridBand5.Columns.Add(this.colFlagStatus);
			resources.ApplyResources(this.gridBand5, "gridBand5");
			this.gridBand5.OptionsBand.AllowMove = false;
			this.gridBand5.OptionsBand.AllowSize = false;
			this.gridBand5.OptionsBand.FixedWidth = true;
			this.gridBand5.VisibleIndex = 4;
			// 
			// colFlagStatus
			// 
			this.colFlagStatus.ColumnEdit = this.repositoryItemImageComboBox5;
			this.colFlagStatus.FieldName = "FlagStatus";
			resources.ApplyResources(this.colFlagStatus, "colFlagStatus");
			this.colFlagStatus.Name = "colFlagStatus";
			this.colFlagStatus.OptionsColumn.AllowEdit = false;
			this.colFlagStatus.OptionsColumn.AllowFocus = false;
			this.colFlagStatus.OptionsColumn.AllowSize = false;
			this.colFlagStatus.OptionsColumn.FixedWidth = true;
			this.colFlagStatus.OptionsColumn.ShowCaption = false;
			this.colFlagStatus.RowCount = 3;
			// 
			// repositoryItemImageComboBox5
			// 
			this.repositoryItemImageComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox5.Buttons"))))});
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
			// repositoryItemTrackBar1
			// 
			this.repositoryItemTrackBar1.LargeChange = 10;
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
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
			resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
			this.ribbonControl1.MaxItemId = 4;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbonControl1.ShowToolbarCustomizeItem = false;
			this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
			this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
			this.barButtonItem1.Id = 1;
			this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
			resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
			this.barButtonItem2.Id = 2;
			this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
			resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
			this.barButtonItem3.Id = 3;
			this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
			resources.ApplyResources(this.barButtonItem3, "barButtonItem3");
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// bbiNewTask
			// 
			resources.ApplyResources(this.bbiNewTask, "bbiNewTask");
			this.bbiNewTask.Glyph = global::TaskManager.Properties.Resources.NewTask_16x16;
			this.bbiNewTask.Id = 54;
			this.bbiNewTask.LargeGlyph = global::TaskManager.Properties.Resources.NewTask_32x32;
			this.bbiNewTask.Name = "bbiNewTask";
			this.bbiNewTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNewTask_ItemClick);
			// 
			// bbiEditTask
			// 
			resources.ApplyResources(this.bbiEditTask, "bbiEditTask");
			this.bbiEditTask.Glyph = global::TaskManager.Properties.Resources.EditTask_16x16;
			this.bbiEditTask.Id = 55;
			this.bbiEditTask.LargeGlyph = global::TaskManager.Properties.Resources.EditTask_32x32;
			this.bbiEditTask.Name = "bbiEditTask";
			this.bbiEditTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditTask_ItemClick);
			// 
			// bbiDeleteTask
			// 
			resources.ApplyResources(this.bbiDeleteTask, "bbiDeleteTask");
			this.bbiDeleteTask.Glyph = global::TaskManager.Properties.Resources.Delete_16x16;
			this.bbiDeleteTask.Id = 56;
			this.bbiDeleteTask.LargeGlyph = global::TaskManager.Properties.Resources.Delete_32x32;
			this.bbiDeleteTask.Name = "bbiDeleteTask";
			this.bbiDeleteTask.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeleteTask_ItemClick);
			// 
			// bbiTodayFlag
			// 
			this.bbiTodayFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			resources.ApplyResources(this.bbiTodayFlag, "bbiTodayFlag");
			this.bbiTodayFlag.Glyph = global::TaskManager.Properties.Resources.Today_Flag;
			this.bbiTodayFlag.Id = 45;
			this.bbiTodayFlag.Name = "bbiTodayFlag";
			this.bbiTodayFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiTomorrowFlag
			// 
			this.bbiTomorrowFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			resources.ApplyResources(this.bbiTomorrowFlag, "bbiTomorrowFlag");
			this.bbiTomorrowFlag.Glyph = global::TaskManager.Properties.Resources.Tomorrow_Flag;
			this.bbiTomorrowFlag.Id = 46;
			this.bbiTomorrowFlag.Name = "bbiTomorrowFlag";
			this.bbiTomorrowFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiThisWeekFlag
			// 
			this.bbiThisWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			resources.ApplyResources(this.bbiThisWeekFlag, "bbiThisWeekFlag");
			this.bbiThisWeekFlag.Glyph = global::TaskManager.Properties.Resources.ThisWeek_Flag;
			this.bbiThisWeekFlag.Id = 47;
			this.bbiThisWeekFlag.Name = "bbiThisWeekFlag";
			this.bbiThisWeekFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiNextWeekFlag
			// 
			this.bbiNextWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			resources.ApplyResources(this.bbiNextWeekFlag, "bbiNextWeekFlag");
			this.bbiNextWeekFlag.Glyph = global::TaskManager.Properties.Resources.NextWeek_Flag;
			this.bbiNextWeekFlag.Id = 48;
			this.bbiNextWeekFlag.Name = "bbiNextWeekFlag";
			this.bbiNextWeekFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiNoDateFlag
			// 
			this.bbiNoDateFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			resources.ApplyResources(this.bbiNoDateFlag, "bbiNoDateFlag");
			this.bbiNoDateFlag.Glyph = global::TaskManager.Properties.Resources.NoDate_Flag;
			this.bbiNoDateFlag.Id = 49;
			this.bbiNoDateFlag.Name = "bbiNoDateFlag";
			this.bbiNoDateFlag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFlag_ItemClick);
			// 
			// bbiCustomFlag
			// 
			resources.ApplyResources(this.bbiCustomFlag, "bbiCustomFlag");
			this.bbiCustomFlag.Glyph = global::TaskManager.Properties.Resources.Custom_Flag;
			this.bbiCustomFlag.Id = 50;
			this.bbiCustomFlag.Name = "bbiCustomFlag";
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
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			// 
			// rpgTasks
			// 
			this.rpgTasks.ItemLinks.Add(this.bbiNewTask);
			this.rpgTasks.ItemLinks.Add(this.bbiEditTask);
			this.rpgTasks.ItemLinks.Add(this.bbiDeleteTask, true);
			this.rpgTasks.Name = "rpgTasks";
			this.rpgTasks.ShowCaptionButton = false;
			resources.ApplyResources(this.rpgTasks, "rpgTasks");
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
			resources.ApplyResources(this.rpgFollowUp, "rpgFollowUp");
			// 
			// rpdCurrentViewTasks
			// 
			this.rpdCurrentViewTasks.ItemLinks.Add(this.rgbiCurrentViewTasks);
			this.rpdCurrentViewTasks.Name = "rpdCurrentViewTasks";
			this.rpdCurrentViewTasks.ShowCaptionButton = false;
			resources.ApplyResources(this.rpdCurrentViewTasks, "rpdCurrentViewTasks");
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.ribbonControl1);
			this.LookAndFeel.SkinName = "Office 2013";
			this.LookAndFeel.UseDefaultLookAndFeel = false;
			this.Name = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
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
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpTasks;
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
	}
}