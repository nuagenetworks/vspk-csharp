/*
  Copyright (c) 2017, Nokia
  All rights reserved.

  Redistribution and use in source and binary forms, with or without
  modification, are permitted provided that the following conditions are met:
      * Redistributions of source code must retain the above copyright
        notice, this list of conditions and the following disclaimer.
      * Redistributions in binary form must reproduce the above copyright
        notice, this list of conditions and the following disclaimer in the
        documentation and/or other materials provided with the distribution.
      * Neither the name of the copyright holder nor the names of its contributors
        may be used to endorse or promote products derived from this software without
        specific prior written permission.

  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY
  DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
  ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/


using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using net.nuagenetworks.bambou;

using net.nuagenetworks.vspk.v6.fetchers;

namespace net.nuagenetworks.vspk.v6
{

public class User: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAvatarType {BASE64,COMPUTEDURL,URL };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EManagementMode {CMS,DEFAULT };

   
   [JsonProperty("LDAPDomain")]
   protected String _LDAPDomain;
   
   [JsonProperty("LDAPEnabled")]
   protected bool _LDAPEnabled;
   
   [JsonProperty("LDAPId")]
   protected String _LDAPId;
   
   [JsonProperty("LDAPUserDN")]
   protected String _LDAPUserDN;
   
   [JsonProperty("avatarData")]
   protected String _avatarData;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("avatarType")]
   protected EAvatarType? _avatarType;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("disableCertificateAuth")]
   protected bool _disableCertificateAuth;
   
   [JsonProperty("disablePasswordAuth")]
   protected bool _disablePasswordAuth;
   
   [JsonProperty("disabled")]
   protected bool _disabled;
   
   [JsonProperty("email")]
   protected String _email;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("firstName")]
   protected String _firstName;
   
   [JsonProperty("lastName")]
   protected String _lastName;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("managementMode")]
   protected EManagementMode? _managementMode;
   
   [JsonProperty("mobileNumber")]
   protected String _mobileNumber;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("password")]
   protected String _password;
   
   [JsonProperty("userName")]
   protected String _userName;
   

   
   [JsonIgnore]
   private AvatarsFetcher _avatars;
   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private GroupsFetcher _groups;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   public User() {
      
      _avatars = new AvatarsFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _groups = new GroupsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NULDAPDomain {
      get {
         return _LDAPDomain;
      }
      set {
         this._LDAPDomain = value;
      }
   }

   
   [JsonIgnore]
   public bool NULDAPEnabled {
      get {
         return _LDAPEnabled;
      }
      set {
         this._LDAPEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NULDAPId {
      get {
         return _LDAPId;
      }
      set {
         this._LDAPId = value;
      }
   }

   
   [JsonIgnore]
   public String NULDAPUserDN {
      get {
         return _LDAPUserDN;
      }
      set {
         this._LDAPUserDN = value;
      }
   }

   
   [JsonIgnore]
   public String NUAvatarData {
      get {
         return _avatarData;
      }
      set {
         this._avatarData = value;
      }
   }

   
   [JsonIgnore]
   public EAvatarType? NUAvatarType {
      get {
         return _avatarType;
      }
      set {
         this._avatarType = value;
      }
   }

   
   [JsonIgnore]
   public String NUCreationDate {
      get {
         return _creationDate;
      }
      set {
         this._creationDate = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDisableCertificateAuth {
      get {
         return _disableCertificateAuth;
      }
      set {
         this._disableCertificateAuth = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDisablePasswordAuth {
      get {
         return _disablePasswordAuth;
      }
      set {
         this._disablePasswordAuth = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDisabled {
      get {
         return _disabled;
      }
      set {
         this._disabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUEmail {
      get {
         return _email;
      }
      set {
         this._email = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<Metadata> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
      }
   }

   
   [JsonIgnore]
   public EEntityScope? NUEntityScope {
      get {
         return _entityScope;
      }
      set {
         this._entityScope = value;
      }
   }

   
   [JsonIgnore]
   public String NUExternalID {
      get {
         return _externalID;
      }
      set {
         this._externalID = value;
      }
   }

   
   [JsonIgnore]
   public String NUFirstName {
      get {
         return _firstName;
      }
      set {
         this._firstName = value;
      }
   }

   
   [JsonIgnore]
   public String NULastName {
      get {
         return _lastName;
      }
      set {
         this._lastName = value;
      }
   }

   
   [JsonIgnore]
   public String NULastUpdatedBy {
      get {
         return _lastUpdatedBy;
      }
      set {
         this._lastUpdatedBy = value;
      }
   }

   
   [JsonIgnore]
   public String NULastUpdatedDate {
      get {
         return _lastUpdatedDate;
      }
      set {
         this._lastUpdatedDate = value;
      }
   }

   
   [JsonIgnore]
   public EManagementMode? NUManagementMode {
      get {
         return _managementMode;
      }
      set {
         this._managementMode = value;
      }
   }

   
   [JsonIgnore]
   public String NUMobileNumber {
      get {
         return _mobileNumber;
      }
      set {
         this._mobileNumber = value;
      }
   }

   
   [JsonIgnore]
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
      }
   }

   
   [JsonIgnore]
   public String NUPassword {
      get {
         return _password;
      }
      set {
         this._password = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserName {
      get {
         return _userName;
      }
      set {
         this._userName = value;
      }
   }

   

   
   public AvatarsFetcher getAvatars() {
      return _avatars;
   }
   
   public ContainersFetcher getContainers() {
      return _containers;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public GroupsFetcher getGroups() {
      return _groups;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public VMsFetcher getVMs() {
      return _vMs;
   }
   

   public String toString() {
      return "User [" + "LDAPDomain=" + _LDAPDomain + ", LDAPEnabled=" + _LDAPEnabled + ", LDAPId=" + _LDAPId + ", LDAPUserDN=" + _LDAPUserDN + ", avatarData=" + _avatarData + ", avatarType=" + _avatarType + ", creationDate=" + _creationDate + ", disableCertificateAuth=" + _disableCertificateAuth + ", disablePasswordAuth=" + _disablePasswordAuth + ", disabled=" + _disabled + ", email=" + _email + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", firstName=" + _firstName + ", lastName=" + _lastName + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", managementMode=" + _managementMode + ", mobileNumber=" + _mobileNumber + ", owner=" + _owner + ", password=" + _password + ", userName=" + _userName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "users";
   }

   public static String getRestName()
   {
	return "user";
   }
}
}