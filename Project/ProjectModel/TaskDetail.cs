//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskDetail
    {
        public string TaskID { get; set; }
        public string TaskDetailID { get; set; }
        public string TaskDetailName { get; set; }
        public string TaskDetailStatusID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Description { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Status Status { get; set; }
        public virtual Task Task { get; set; }
    }
}
