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
    
    public partial class racetrack
    {
        public racetrack()
        {
            this.race_info = new ObservableCollection<race_info>();
        }
    
        public int track_id { get; set; }
        public string track_name { get; set; }
        public string flat_characteristic { get; set; }
        public decimal straight_distance { get; set; }
        public string course_shape { get; set; }
        public string turn_direction { get; set; }
        public string speed { get; set; }
    
        public virtual ObservableCollection<race_info> race_info { get; set; }
    }
}
