using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Contact
    {
        public Contact(int id, DateTime modifiedOn, DateTime createdOn, string name, string description, string createdById, string modifiedById,
          string accountId, string dear, string salutationTypeId, string genderId, string ownerId, string decisionRoleId, string jobId, string jobTitle,
          string departmentId, DateTime birthDate, string phone, string mobilePhone, string homePhone, string skype, string email, string address,
          string cityId, string regionId, string zip, string countryId, bool doNotUseEmail, bool doNotUseCall, bool doNotUseFax, bool doNotUseSms, 
          bool doNotUseMail, string notes, string typeId, string addressTypeId, string facebook, string linkedIn, string twitter, string facebookId,
          string linkedInId, string twitterId, object contactPhoto, string twitterAFDAId, string facebookAFDAId, string linkedInAFDAId,
          int processListeners, string photoId, string gpsn, string gpse, string surname, string givenName, string middleName, bool confirmed,
          int completeness, string languageId)
        {
            if (id < 0)
            {
                throw new ArgumentException(LogConst.IdIsNegative);
            }
            if (name == null || name == "")
                throw new NullReferenceException(LogConst.ParamCannotBeNull(name));
            if (description == null || description == "")
                throw new NullReferenceException(LogConst.ParamCannotBeNull(description));
            if (modifiedById == null || modifiedById == "")
                throw new NullReferenceException(LogConst.ParamCannotBeNull(modifiedById));
            if (accountId == null || accountId == "")
                throw new NullReferenceException(LogConst.ParamCannotBeNull(accountId));
            if (dear == null || dear == "")
                throw new NullReferenceException(LogConst.ParamCannotBeNull(dear));
            if (salutationTypeId == null || salutationTypeId == "")
                throw new NullReferenceException(LogConst.ParamCannotBeNull(salutationTypeId));
            
            Id = id;
            ModifiedOn = modifiedOn;
            CreatedOn = createdOn;
            Name = name;
            Description = description;
            CreatedById = createdById;
            ModifiedById = modifiedById;
            AccountId = accountId;
            Dear = dear;
            SalutationTypeId = salutationTypeId;
        }

        public int Id{ get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
        public string AccountId { get; set; }
        public string Dear { get; set; }
        public string SalutationTypeId { get; set; }




        public Person() { }
    }
}
