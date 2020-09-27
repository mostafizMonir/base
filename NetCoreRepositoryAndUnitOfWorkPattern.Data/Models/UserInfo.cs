using System;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            Id = Guid.NewGuid().ToString("D");
        }
        public string Id { get; set; }
        public string UserName { get; set; }
       
    }
}