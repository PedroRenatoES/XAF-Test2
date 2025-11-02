using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAF_Test2.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Tarea : BaseObject
    {
        [Required]
        public virtual string Titulo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual DateTime FechaCreacion { get; set; } = DateTime.Now;
        public virtual bool Completada { get; set; }

    }
}
