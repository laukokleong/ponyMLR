//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PonyMLR.DataAccess
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class trainer_info
    {
        public trainer_info()
        {
            this.race_result = new ObservableCollection<race_result>();
        }
    
        public int trainer_id { get; set; }
        public string trainer_name { get; set; }
        public string alternate_name { get; set; }
        public string description { get; set; }
    
        public virtual ObservableCollection<race_result> race_result { get; set; }
    }
}
