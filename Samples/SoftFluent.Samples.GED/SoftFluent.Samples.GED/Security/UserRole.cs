﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.GED.Security
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Thursday, 08 May 2014 21:28.
    // Build:1.0.61214.0769
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0769")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Role.Name={Role.Name}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class UserRole : System.ICloneable, System.IComparable, System.IComparable<SoftFluent.Samples.GED.Security.UserRole>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<SoftFluent.Samples.GED.Security.UserRole>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private byte[] _rowVersion;
        
        private System.Guid _roleId = CodeFluentPersistence.DefaultGuidValue;
        
        [System.NonSerializedAttribute()]
        private SoftFluent.Samples.GED.Security.Role _role = null;
        
        private System.Guid _userId = CodeFluentPersistence.DefaultGuidValue;
        
        [System.NonSerializedAttribute()]
        private SoftFluent.Samples.GED.Security.User _user = null;
        
        public UserRole()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                object[] keys = new object[] {
                        this.RoleId,
                        this.UserId};
                string v = CodeFluentPersistence.BuildEntityKey(keys);
                return v;
            }
            set
            {
                System.Type[] types = new System.Type[] {
                        typeof(System.Guid),
                        typeof(System.Guid)};
                object[] defaultValues = new object[] {
                        CodeFluentPersistence.DefaultGuidValue,
                        CodeFluentPersistence.DefaultGuidValue};
                object[] v1 = CodeFluentPersistence.ParseEntityKey(value, types, defaultValues);
                this.RoleId = ((System.Guid)(v1[0]));
                this.UserId = ((System.Guid)(v1[1]));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return ((string)(CodeFluent.Runtime.Utilities.ConvertUtilities.Evaluate(this, "Role.Name", typeof(string), null)));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [System.ComponentModel.DataObjectFieldAttribute(false, true)]
        [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.ByteArrayConverter))]
        public byte[] RowVersion
        {
            get
            {
                return this._rowVersion;
            }
            set
            {
                if (((value != null) 
                            && (value.Length == 0)))
                {
                    value = null;
                }
                this._rowVersion = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("RowVersion"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public System.Guid RoleId
        {
            get
            {
                if (((this._roleId.Equals(CodeFluentPersistence.DefaultGuidValue) == true) 
                            && (this._role != null)))
                {
                    this._roleId = this._role.Id;
                }
                return this._roleId;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<System.Guid>.Default.Equals(value, this.RoleId) == true))
                {
                    return;
                }
                this._role = null;
                this._roleId = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Role"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("RoleId"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SoftFluent.Samples.GED.Security.Role Role
        {
            get
            {
                if ((this._role == null))
                {
                    this._role = SoftFluent.Samples.GED.Security.Role.Load(this._roleId);
                }
                return this._role;
            }
            set
            {
                this._roleId = CodeFluentPersistence.DefaultGuidValue;
                this._role = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Role"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("RoleId"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public System.Guid UserId
        {
            get
            {
                if (((this._userId.Equals(CodeFluentPersistence.DefaultGuidValue) == true) 
                            && (this._user != null)))
                {
                    this._userId = this._user.Id;
                }
                return this._userId;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<System.Guid>.Default.Equals(value, this.UserId) == true))
                {
                    return;
                }
                this._user = null;
                this._userId = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("User"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("UserId"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SoftFluent.Samples.GED.Security.User User
        {
            get
            {
                if ((this._user == null))
                {
                    this._user = SoftFluent.Samples.GED.Security.User.Load(this._userId);
                }
                return this._user;
            }
            set
            {
                this._userId = CodeFluentPersistence.DefaultGuidValue;
                this._user = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("User"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("UserId"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.Created) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(SoftFluent.Samples.GED.Security.UserRole userRole)
        {
            if ((userRole == null))
            {
                return false;
            }
            if (((this.RoleId.Equals(CodeFluentPersistence.DefaultGuidValue) == true) 
                        || (this.UserId.Equals(CodeFluentPersistence.DefaultGuidValue) == true)))
            {
                return base.Equals(userRole);
            }
            return ((this.RoleId.Equals(userRole.RoleId) && this.UserId.Equals(userRole.UserId)) 
                        == true);
        }
        
        public override int GetHashCode()
        {
            if ((this.EntityKey == null))
            {
                return base.GetHashCode();
            }
            return this.EntityKey.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            SoftFluent.Samples.GED.Security.UserRole userRole = null;
			userRole = obj as SoftFluent.Samples.GED.Security.UserRole;
            return this.Equals(userRole);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            SoftFluent.Samples.GED.Security.UserRole userRole = null;
userRole = value as SoftFluent.Samples.GED.Security.UserRole;
            if ((userRole == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(userRole);
            return localCompareTo;
        }
        
        public virtual int CompareTo(SoftFluent.Samples.GED.Security.UserRole userRole)
        {
            if ((userRole == null))
            {
                throw new System.ArgumentNullException("userRole");
            }
            int localCompareTo = this.Role.CompareTo(userRole.Role);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = SoftFluent.Samples.GED.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.GED.Security.UserRole.ExternalValidate", "Type \'SoftFluent.Samples.GED.Security.UserRole\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            if ((this.Role == null))
            {
                string localValidate = SoftFluent.Samples.GED.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.GED.Security.UserRole.Role.NullException", "\'Role\' property cannot be set to \'\' for type \'SoftFluent.Samples.GED.Security.Use" +
                        "rRole\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate);
            }
            if ((this.User == null))
            {
                string localValidate1 = SoftFluent.Samples.GED.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.GED.Security.UserRole.User.NullException", "\'User\' property cannot be set to \'\' for type \'SoftFluent.Samples.GED.Security.Use" +
                        "rRole\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate1);
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            if ((this.RowVersion == null))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.GED.Constants.SoftFluent_Samples_GEDStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "UserRole", "Delete");
            persistence.AddParameter("@UserRole_Role_Id", this.RoleId, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@UserRole_User_Id", this.UserId, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this.RoleId = CodeFluentPersistence.GetReaderValue(reader, "UserRole_Role_Id", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
                this.UserId = CodeFluentPersistence.GetReaderValue(reader, "UserRole_User_Id", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.RowVersion) 
                        == 0) 
                        == false))
            {
                this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.GED.Security.UserRole Load(System.Guid roleId, System.Guid userId)
        {
            if ((roleId.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            if ((userId.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            SoftFluent.Samples.GED.Security.UserRole userRole = new SoftFluent.Samples.GED.Security.UserRole();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.GED.Constants.SoftFluent_Samples_GEDStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "UserRole", "Load");
            persistence.AddParameter("@RoleId", roleId);
            persistence.AddParameter("@UserId", userId);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    userRole.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    userRole.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return userRole;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
        public static SoftFluent.Samples.GED.Security.UserRole LoadByUserUserNameAndRoleName(string userUserName, string roleName)
        {
            if ((userUserName == default(string)))
            {
                return null;
            }
            if ((roleName == default(string)))
            {
                return null;
            }
            SoftFluent.Samples.GED.Security.UserRole userRole = new SoftFluent.Samples.GED.Security.UserRole();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.GED.Constants.SoftFluent_Samples_GEDStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "UserRole", "LoadByUserUserNameAndRoleName");
            persistence.AddParameter("@userUserName", userUserName);
            persistence.AddParameter("@roleName", roleName);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    userRole.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    userRole.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return userRole;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if (((this.RoleId.Equals(CodeFluentPersistence.DefaultGuidValue) == true) 
                        || (this.UserId.Equals(CodeFluentPersistence.DefaultGuidValue) == true)))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.GED.Constants.SoftFluent_Samples_GEDStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "UserRole", "Load");
            persistence.AddParameter("@RoleId", this.RoleId, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@UserId", this.UserId, CodeFluentPersistence.DefaultGuidValue);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.GED.Constants.SoftFluent_Samples_GEDStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "UserRole", "Save");
            persistence.AddParameter("@UserRole_Role_Id", this.RoleId, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@UserRole_User_Id", this.UserId, CodeFluentPersistence.DefaultGuidValue);
            persistence.AddParameter("@_trackLastWriteUser", persistence.Context.User.Name);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(SoftFluent.Samples.GED.Security.UserRole userRole)
        {
            if ((userRole == null))
            {
                return false;
            }
            bool ret = userRole.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(SoftFluent.Samples.GED.Security.UserRole userRole)
        {
            bool ret = SoftFluent.Samples.GED.Security.UserRole.Save(userRole);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(SoftFluent.Samples.GED.Security.UserRole userRole)
        {
            if ((userRole == null))
            {
                return false;
            }
            bool ret = userRole.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("Role=");
            if ((this._role != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._role)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_roleId=");
            writer.Write(this._roleId);
            writer.Write(",");
            writer.Write("User=");
            if ((this._user != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._user)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_userId=");
            writer.Write(this._userId);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.GED.Security.UserRole LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            SoftFluent.Samples.GED.Security.UserRole userRole;
            System.Type[] types = new System.Type[] {
                    typeof(System.Guid),
                    typeof(System.Guid)};
            object[] defaultValues = new object[] {
                    CodeFluentPersistence.DefaultGuidValue,
                    CodeFluentPersistence.DefaultGuidValue};
            object[] v = CodeFluentPersistence.ParseEntityKey(key, types, defaultValues);
            System.Guid var0;
            var0 = ((System.Guid)(v[0]));
            System.Guid var1;
            var1 = ((System.Guid)(v[1]));
            userRole = SoftFluent.Samples.GED.Security.UserRole.Load(var0, var1);
            return userRole;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public SoftFluent.Samples.GED.Security.UserRole Clone(bool deep)
        {
            SoftFluent.Samples.GED.Security.UserRole userRole = new SoftFluent.Samples.GED.Security.UserRole();
            this.CopyTo(userRole, deep);
            return userRole;
        }
        
        public SoftFluent.Samples.GED.Security.UserRole Clone()
        {
            SoftFluent.Samples.GED.Security.UserRole localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("UserId") == true))
            {
                this.UserId = ((System.Guid)(ConvertUtilities.ChangeType(dict["UserId"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("RoleId") == true))
            {
                this.RoleId = ((System.Guid)(ConvertUtilities.ChangeType(dict["RoleId"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(SoftFluent.Samples.GED.Security.UserRole userRole, bool deep)
        {
            if ((userRole == null))
            {
                throw new System.ArgumentNullException("userRole");
            }
            userRole.UserId = this.UserId;
            userRole.RoleId = this.RoleId;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, userRole));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["UserId"] = this.UserId;
            dict["RoleId"] = this.RoleId;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}
