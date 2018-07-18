using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Softmax.XNotifi._Applications;
using Softmax.XNotifi.Authorization.Users;
using Abp.Domain.Entities.Auditing;

namespace Softmax.XNotifi._Clients
{
    [Table("AppClients")]
    public class Client : Entity<Guid>, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public bool IsCustomer { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

        public Client()
        {
            CreationTime = DateTime.Now;
        }
    }
}
