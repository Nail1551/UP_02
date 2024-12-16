//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP_02
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            this.PartnerProducts = new HashSet<PartnerProducts>();
        }
    
        public int PartnerID { get; set; }
        public Nullable<int> PartnerType { get; set; }
        public string CompanyName { get; set; }
        public string LegalAddress { get; set; }
        public string INN { get; set; }
        public string DirectorName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Discount { get; set; }
        public Nullable<int> Rating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProducts> PartnerProducts { get; set; }
        public virtual PartnersType PartnersType { get; set; }
    }
}
