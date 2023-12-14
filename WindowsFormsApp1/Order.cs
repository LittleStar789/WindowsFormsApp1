//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public int ID_Client { get; set; }
        public int ID_TypeEquipment { get; set; }
        public int ID_TypeProblem { get; set; }
        public int ID_Technician { get; set; }
        public int ID_Manager { get; set; }
        public int ID_Status { get; set; }
        public System.DateTime DateOrderOpen { get; set; }
        public Nullable<System.DateTime> DateOrderClose { get; set; }
        public string Comments { get; set; }
        public string Photo { get; set; }
    
        public virtual EquipmentType EquipmentType { get; set; }
        public virtual ProblemType ProblemType { get; set; }
        public virtual Status Status { get; set; }
        public virtual Technician Technician { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
