//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbDataManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employe()
        {
            this.Shops = new HashSet<Shop>();
        }
    
        public int Id { get; set; }
        public int Wage { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> Shops { get; set; }

        public static implicit operator DbEssense.Employe(Employe v)
        {
            DbEssense.Employe employe = new DbEssense.Employe();
            employe.Shop = (ICollection<DbEssense.Shop>)v.Shops;
            employe.Name = v.Name;
            employe.Id = v.Id;
            employe.Wage = v.Wage;
            return employe;
        }
    }
}