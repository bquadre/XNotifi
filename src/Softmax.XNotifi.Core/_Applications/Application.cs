using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Softmax.XNotifi._Clients;
using Abp.Domain.Entities.Auditing;

namespace Softmax.XNotifi._Applications
{
    [Table("Applications")]
    public class Application : Entity<Guid>, IHasCreationTime
    {
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public Guid ClientId { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }

        public Application()
        {
            CreationTime = DateTime.Now;
        }
    }
}
