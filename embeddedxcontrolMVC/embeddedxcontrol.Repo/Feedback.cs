//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace embeddedxcontrol.Repo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public string UnregisteredName { get; set; }
        public Nullable<int> Reference { get; set; }
        public int ProjectId { get; set; }
        public string Text { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual UserData UserData { get; set; }
    }
}
