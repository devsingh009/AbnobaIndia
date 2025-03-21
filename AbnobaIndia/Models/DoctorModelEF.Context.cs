﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AbnobaIndia.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class abnobaEntities : DbContext
    {
        public abnobaEntities()
            : base("name=abnobaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UsersLogin> UsersLogins { get; set; }
        public virtual DbSet<AdminLoginMaster> AdminLoginMasters { get; set; }
    
        public virtual int spUserRegistrationItems(string fIRSTNAME, string lASTNAME, string eMAILID, string pASSWORD, Nullable<int> zIP, string cOUNTRY, string pROFESSION, string dISCIPLINE, string fIELDOFACTIVITY, Nullable<bool> wANTTORECEIVEDOCEMAIL, ObjectParameter rESULT)
        {
            var fIRSTNAMEParameter = fIRSTNAME != null ?
                new ObjectParameter("FIRSTNAME", fIRSTNAME) :
                new ObjectParameter("FIRSTNAME", typeof(string));
    
            var lASTNAMEParameter = lASTNAME != null ?
                new ObjectParameter("LASTNAME", lASTNAME) :
                new ObjectParameter("LASTNAME", typeof(string));
    
            var eMAILIDParameter = eMAILID != null ?
                new ObjectParameter("EMAILID", eMAILID) :
                new ObjectParameter("EMAILID", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            var zIPParameter = zIP.HasValue ?
                new ObjectParameter("ZIP", zIP) :
                new ObjectParameter("ZIP", typeof(int));
    
            var cOUNTRYParameter = cOUNTRY != null ?
                new ObjectParameter("COUNTRY", cOUNTRY) :
                new ObjectParameter("COUNTRY", typeof(string));
    
            var pROFESSIONParameter = pROFESSION != null ?
                new ObjectParameter("PROFESSION", pROFESSION) :
                new ObjectParameter("PROFESSION", typeof(string));
    
            var dISCIPLINEParameter = dISCIPLINE != null ?
                new ObjectParameter("DISCIPLINE", dISCIPLINE) :
                new ObjectParameter("DISCIPLINE", typeof(string));
    
            var fIELDOFACTIVITYParameter = fIELDOFACTIVITY != null ?
                new ObjectParameter("FIELDOFACTIVITY", fIELDOFACTIVITY) :
                new ObjectParameter("FIELDOFACTIVITY", typeof(string));
    
            var wANTTORECEIVEDOCEMAILParameter = wANTTORECEIVEDOCEMAIL.HasValue ?
                new ObjectParameter("WANTTORECEIVEDOCEMAIL", wANTTORECEIVEDOCEMAIL) :
                new ObjectParameter("WANTTORECEIVEDOCEMAIL", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUserRegistrationItems", fIRSTNAMEParameter, lASTNAMEParameter, eMAILIDParameter, pASSWORDParameter, zIPParameter, cOUNTRYParameter, pROFESSIONParameter, dISCIPLINEParameter, fIELDOFACTIVITYParameter, wANTTORECEIVEDOCEMAILParameter, rESULT);
        }
    
        public virtual int spUsersLogin(string userName, string password, ObjectParameter result)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUsersLogin", userNameParameter, passwordParameter, result);
        }
    
        public virtual ObjectResult<spAdminLogin_Result> spAdminLogin(string userId, string password)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAdminLogin_Result>("spAdminLogin", userIdParameter, passwordParameter);
        }
    
        public virtual ObjectResult<spGetUserDetails_Result> spGetUserDetails(string name, string profession, string discipline, string fOA)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("Profession", profession) :
                new ObjectParameter("Profession", typeof(string));
    
            var disciplineParameter = discipline != null ?
                new ObjectParameter("Discipline", discipline) :
                new ObjectParameter("Discipline", typeof(string));
    
            var fOAParameter = fOA != null ?
                new ObjectParameter("FOA", fOA) :
                new ObjectParameter("FOA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserDetails_Result>("spGetUserDetails", nameParameter, professionParameter, disciplineParameter, fOAParameter);
        }
    }
}
