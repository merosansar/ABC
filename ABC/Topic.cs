//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Topic
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<bool> IsNepali { get; set; }
    
        public virtual Subject Subject { get; set; }
    }
}
