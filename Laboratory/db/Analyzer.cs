//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratory.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Analyzer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Analyzer()
        {
            this.Status_Services_ = new HashSet<Status_Services_>();
        }
    
        public int id { get; set; }
        public Nullable<System.TimeSpan> time_order { get; set; }
        public Nullable<System.TimeSpan> time_work { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status_Services_> Status_Services_ { get; set; }
    }
}
