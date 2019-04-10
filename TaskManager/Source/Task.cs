using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Source.Utils;

namespace TaskManager.Source.Data
{
	[Flags]
	public enum TaskStatus { InProgress, NotStarted, WaitingOnSomeoneElse, Deferred, Completed, Canceled, TransferredTo};
	public enum FlagStatus { Today, Tomorrow, ThisWeek, NextWeek, NoDate, Custom, Completed };
	public enum TaskPriority { Low, Normal, High }

	[Serializable]
	public class Task : IDXDataErrorInfo
	{
		#region Fields
		TaskPriority priority = TaskPriority.Normal;
		int percentComplete = 0;
		DateTime createdDate;
		DateTime? startDate = null, dueDate = null, completedDate = null;
		string subject, description;
		TaskStatus status = TaskStatus.NotStarted;
		string executor, creator;
		string category = "";
		string hiddenDescription;
		#endregion
		#region Properties
		public string Executor { get { return executor; } set { executor = value; } }
		public string Creator { get { return creator; } set { creator = value; } }
		public string Category { get { return category; } set { category = value; } }
		public TaskPriority Priority { get { return priority; } set { priority = value; } }
		public string HiddenDescription { get { return hiddenDescription; } set { hiddenDescription = value; } }
		public int PercentComplete
		{
			get { return percentComplete; }
			set
			{
				if( value < 0 ) value = 0;
				if( value > 100 ) value = 100;
				if( percentComplete == value ) return;
				percentComplete = value;
				if( percentComplete == 100 ) Status = TaskStatus.Completed;
				if( percentComplete > 0 && percentComplete < 100 ) Status = TaskStatus.InProgress;
			}
		}
		public DateTime CreatedDate { get { return createdDate; } }
		public DateTime? StartDate { get { return startDate; } set { startDate = value; } }
		public DateTime? DueDate { get { return dueDate; } set { dueDate = value; } }
		public DateTime? CompletedDate { get { return completedDate; } set { completedDate = value; } }
		public string Subject { get { return subject; } set { subject = value; } }
		public string Description { get { return description; } set { description = value; } }
		public int IntStatus { get { return (int)Status; } }
		public TaskStatus Status
		{
			get { return status; }
			set
			{
				status = value;
				if( status == TaskStatus.Completed )
				{
					PercentComplete = 100;
					CompletedDate = DateTime.Now;
				}
				else
					CompletedDate = null;
				if( status == TaskStatus.NotStarted )
					PercentComplete = 0;
				if( status == TaskStatus.InProgress && PercentComplete == 100 )
					PercentComplete = 75;
				if( status == TaskStatus.Deferred || status == TaskStatus.WaitingOnSomeoneElse )
					DueDate = null;
			}
		}
		internal TimeSpan TimeDiff { get { return (DateTime.Now - CreatedDate); } }
		public bool Overdue
		{
			get
			{
				if( Status == TaskStatus.Completed || !DueDate.HasValue ) return false;
				DateTime dDate = DueDate.Value.Date.AddDays(1);
				if( DateTime.Now >= dDate ) return true;
				return false;
			}
		}
		public bool Complete
		{
			get { return Status == TaskStatus.Completed; }
			set
			{
				if( value )
					Status = TaskStatus.Completed;
				else Status = TaskStatus.NotStarted;
			}
		}
		public int Icon {
			get {
				switch( Status )
				{

				}
				return Complete ? 0 : 1;
			} }
		public FlagStatus FlagStatus
		{
			get
			{
				DateTime today = DateTime.Today;
				if( Complete ) return FlagStatus.Completed;
				if( !DueDate.HasValue ) return FlagStatus.NoDate;
				if( DueDate.Value.Date.Equals(today) ) return FlagStatus.Today;
				if( DueDate.Value.Date.Equals(today.AddDays(1)) ) return FlagStatus.Tomorrow;
				DateTime thisWeekStart = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(today);
				if( DueDate.Value.Date >= thisWeekStart && DueDate.Value.Date < thisWeekStart.AddDays(7) ) return FlagStatus.ThisWeek;
				if( DueDate.Value.Date >= thisWeekStart.AddDays(7) && DueDate.Value.Date < thisWeekStart.AddDays(14) ) return FlagStatus.NextWeek;
				return FlagStatus.Custom;
			}
		}
		#endregion
		#region Constructors
		public Task(string subject) : this(subject, DateTime.Now)
		{
		}
		internal Task(string subject, DateTime date)
		{
			this.subject = subject;
			this.createdDate = date;
		}
		#endregion
		#region Methods
		public void Assign(Task task)
		{
			this.subject = task.Subject;
			this.priority = task.Priority;
			this.percentComplete = task.PercentComplete;
			this.createdDate = task.CreatedDate;
			this.startDate = task.StartDate;
			this.dueDate = task.DueDate;
			this.completedDate = task.CompletedDate;
			this.description = task.Description;
			this.hiddenDescription = task.HiddenDescription;
			this.status = task.Status;
			this.category = task.category;
			this.Executor = task.executor;
			this.Creator = task.creator;
		}
		public Task Clone()
		{
			Task task = new Task(this.Subject);
			task.Assign(this);
			return task;
		}
		public void Transffer(string NextExecutor)
		{
			Executor = NextExecutor;
			status = TaskStatus.TransferredTo;
		}
		public string DueIn
		{
			get
			{
				if( DueDate.HasValue )
				{
					int oDays = (DateTime.Today - DueDate.Value).Days;
					return oDays > 0 ? string.Format("{0} day{1} overdue", oDays, oDays > 1 ? "s" : string.Empty) : string.Empty;
				}
				return string.Empty;
			}
		}
		#endregion
		#region IDXDataErrorInfo Members
		public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info) { }

		public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
		{
			if( propertyName == "DueDate" )
			{
				if( (DueDate.HasValue && StartDate.HasValue) && DueDate < StartDate )
					SetErrorInfo(info, Properties.Resources.DueDateError, ErrorType.Critical);
				//if( !DueDate.HasValue && Status == TaskStatus.InProgress )
				//	SetErrorInfo(info, Properties.Resources.DueDateWarning, ErrorType.Warning);
			}
		}
		void SetErrorInfo(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info, string errorText, ErrorType errorType)
		{
			info.ErrorText = errorText;
			info.ErrorType = errorType;
		}
		#endregion
	}
	[Serializable]
	public class TaskBase
	{
		string passHash;
		/// <summary>
		/// Array with tasks
		/// </summary>
		public List<Task> Tasks;
		/// <summary>
		/// Metadata for tasks base
		/// </summary>
		public object MetaData { get; set; }
		public string FileName { get; set; }
		public string Password { set { passHash = MD5Provider.GetHash(value); } }
		public TaskBase(string password)
		{
			passHash = MD5Provider.GetHash(password);
			Tasks = new List<Task>();
		}
		public bool CheckPassword(string password)
		{
			return MD5Provider.GetHash(password) == passHash;
		}
		public bool Save() => Save(FileName);
		public bool Save(string FileName)
		{
			this.FileName = FileName;
			return SerializationProvider.SaveObjectToFile(FileName, this);
		}
		public bool Load(string FileName, string Password)
		{
			TaskBase tmpBase = SerializationProvider.LoadObjectFromFile(FileName) as TaskBase;
			if( tmpBase == null || MD5Provider.GetHash(Password) != tmpBase.passHash )
				return false;
			this.FileName = FileName;
			passHash = tmpBase.passHash;
			MetaData = tmpBase.MetaData;
			Tasks = tmpBase.Tasks;
			return true;
		}
	}
}
