using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Contact
    {
        //public Contact(Guid id, System.DateTime modifiedOn, DateTime createdOn, string name, string description, Guid createdById, Guid modifiedById,
        //  Guid accountId, string dear, Guid salutationTypeId, Guid genderId, Guid ownerId, Guid decisionRoleId, Guid jobId, string jobTitle,
        //  Guid departmentId, DateTime birthDate, string phone, string mobilePhone, string homePhone, string skype, string email, string address,
        //  Guid cityId, Guid regionId, string zip, Guid countryId, bool doNotUseEmail, bool doNotUseCall, bool doNotUseFax, bool doNotUseSms,
        //  bool doNotUseMail, string notes, Guid typeId, Guid addressTypeId, string facebook, string linkedIn, string twitter, Guid facebookId,
        //  Guid linkedInId, Guid twitterId, byte[] contactPhoto, Guid twitterAFDAId, Guid facebookAFDAId, Guid linkedInAFDAId,
        //  int processListeners, Guid photoId, string gpsn, string gpse, string surname, string givenName, string middleName, bool confirmed,
        //  int completeness, Guid languageId)
        //{
        //    //if (name == null || name == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(name));
        //    //if (description == null || description == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(description));
        //    //if (dear == null || dear == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(dear));
        //    //if (jobTitle == null || jobTitle == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(jobTitle));
        //    //if (phone == null || phone == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(phone));
        //    //if (mobilePhone == null || mobilePhone == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(mobilePhone));
        //    //if (homePhone == null || homePhone == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(homePhone));
        //    //if (skype == null || skype == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(skype));
        //    //if (email == null || email == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(email));
        //    //if (address == null || address == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(address));
        //    //if (zip == null || zip == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(zip));
        //    //if (notes == null || notes == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(notes));
        //    //if (facebook == null || facebook == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(facebook));
        //    //if (linkedIn == null || linkedIn == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(linkedIn));
        //    //if (twitter == null || twitter == "")
        //    //    throw new NullReferenceException(LogConst.ParamCannotBeNull(twitter));
        

        //    //Id = id;
        //    //ModifiedOn = modifiedOn;
        //    //CreatedOn = createdOn;
        //    //Name = name;
        //    //Description = description;
        //    //CreatedById = createdById;
        //    //ModifiedById = modifiedById;
        //    //AccountId = accountId;
        //    //Dear = dear;
        //    //SalutationTypeId = salutationTypeId;
        //    //GenderId = genderId;
        //    //OwnerId = ownerId;
        //    //DecisionRoleId = decisionRoleId;
        //    //JobId = jobId;
        //    //JobTitle = jobTitle;
        //    //DepartmentId = departmentId;
        //    //BirthDate = birthDate;
        //    //Phone = phone;
        //    //MobilePhone = mobilePhone;
        //    //HomePhone = homePhone;
        //    //Skype = skype;
        //    //Email = email;
        //    //Address = address;
        //    //CityId = cityId;
        //    //RegionId = regionId;
        //    //Zip = zip;
        //    //CountryId = countryId;
        //    //DoNotUseEmail = doNotUseEmail;
        //    //DoNotUseCall = doNotUseCall;
        //    //DoNotUseFax = doNotUseFax;
        //    //DoNotUseSms = doNotUseSms;
        //    //DoNotUseMail = doNotUseMail;
        //    //Notes = notes;
        //    //TypeId = typeId;
        //    //AddressTypeId = addressTypeId;
        //    //Facebook = facebook;
        //    //LinkedIn = linkedIn;
        //    //Twitter = twitter;
        //    //FacebookId = facebookId;
        //    //LinkedInId = linkedInId;
        //    //TwitterId = twitterId;
        //    //ContactPhoto = contactPhoto;
        //    //TwitterAFDAId = twitterAFDAId;
        //    //FacebookAFDAId = facebookAFDAId;
        //    //LinkedInAFDAId = linkedInAFDAId;
        //    //ProcessListeners = processListeners;
        //    //PhotoId = photoId;
        //    //GPSN = gpsn;
        //    //GPSE = gpse;
        //    //Surname = surname;
        //    //GivenName = givenName;
        //    //MiddleName = middleName;
        //    //Confirmed = confirmed;
        //    //Completeness = completeness;
        //    //LanguageId = languageId;
        //}

        public Guid Id { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? CreatedById { get; set; }
        public Guid? ModifiedById { get; set; }
        public Guid? AccountId { get; set; }
        public string Dear { get; set; }
        public Guid? SalutationTypeId { get; set; }
        public Guid? GenderId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? DecisionRoleId { get; set; }
        public Guid? JobId { get; set; }
        public string JobTitle { get; set; }
        public Guid? DepartmentId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Guid? CityId { get; set; }
        public Guid? RegionId { get; set; }
        public string Zip { get; set; }
        public Guid? CountryId { get; set; }
        public bool DoNotUseEmail { get; set; }
        public bool DoNotUseCall { get; set; }
        public bool DoNotUseFax { get; set; }
        public bool DoNotUseSms { get; set; }
        public bool DoNotUseMail { get; set; }
        public string Notes { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? AddressTypeId { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
        public Guid? FacebookId { get; set; }
        public Guid? LinkedInId { get; set; }
        public Guid? TwitterId { get; set; }
        public byte[]? ContactPhoto { get; set; }
        public Guid? TwitterAFDAId { get; set; }
        public Guid? FacebookAFDAId { get; set; }
        public Guid? LinkedInAFDAId { get; set; }
        public int ProcessListeners { get; set; }
        public Guid? PhotoId { get; set; }
        public string GPSN { get; set; }
        public string GPSE { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public bool Confirmed { get; set; }
        public int Completeness { get; set; }
        public Guid? LanguageId { get; set; }

        public Contact() { }
    }
}
