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
    
    public partial class InsuranceCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceCompany()
        {
            this.CheckCompany = new HashSet<CheckCompany>();
        }
    
        public int id { get; set; }
        public string namecompany { get; set; }
        public string addresscompany { get; set; }
        public Nullable<long> INN { get; set; }
        public Nullable<long> BIK { get; set; }
        public string checkingaccount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckCompany> CheckCompany { get; set; }
    }
}