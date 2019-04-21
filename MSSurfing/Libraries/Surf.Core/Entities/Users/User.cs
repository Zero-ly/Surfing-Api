using Surf.Core.Entities.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Surf.Core.Entities.Users
{
    public partial class User : BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public int EncryptMethodId { get; set; }
        public EncryptMethod EncryptMethod
        {
            get { return (EncryptMethod)EncryptMethodId; }
            set { this.EncryptMethodId = (int)value; }
        }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        //public DateTime CreatedOn { get; set; }
        #endregion
    }
}