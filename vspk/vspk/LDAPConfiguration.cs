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

public class LDAPConfiguration: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("SSLEnabled")]
   protected bool _SSLEnabled;
   
   [JsonProperty("acceptAllCertificates")]
   protected bool _acceptAllCertificates;
   
   [JsonProperty("authorizationEnabled")]
   protected bool _authorizationEnabled;
   
   [JsonProperty("authorizingUserDN")]
   protected String _authorizingUserDN;
   
   [JsonProperty("certificate")]
   protected String _certificate;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("domain")]
   protected String _domain;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enabled")]
   protected bool _enabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("everybodyGroupEnabled")]
   protected bool _everybodyGroupEnabled;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("groupDN")]
   protected String _groupDN;
   
   [JsonProperty("groupNamePrefix")]
   protected String _groupNamePrefix;
   
   [JsonProperty("groupNameSuffix")]
   protected String _groupNameSuffix;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("password")]
   protected String _password;
   
   [JsonProperty("port")]
   protected String _port;
   
   [JsonProperty("server")]
   protected String _server;
   
   [JsonProperty("userDNTemplate")]
   protected String _userDNTemplate;
   
   [JsonProperty("userNameAttribute")]
   protected String _userNameAttribute;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public LDAPConfiguration() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUSSLEnabled {
      get {
         return _SSLEnabled;
      }
      set {
         this._SSLEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAcceptAllCertificates {
      get {
         return _acceptAllCertificates;
      }
      set {
         this._acceptAllCertificates = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAuthorizationEnabled {
      get {
         return _authorizationEnabled;
      }
      set {
         this._authorizationEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUAuthorizingUserDN {
      get {
         return _authorizingUserDN;
      }
      set {
         this._authorizingUserDN = value;
      }
   }

   
   [JsonIgnore]
   public String NUCertificate {
      get {
         return _certificate;
      }
      set {
         this._certificate = value;
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
   public String NUDomain {
      get {
         return _domain;
      }
      set {
         this._domain = value;
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
   public bool NUEnabled {
      get {
         return _enabled;
      }
      set {
         this._enabled = value;
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
   public bool NUEverybodyGroupEnabled {
      get {
         return _everybodyGroupEnabled;
      }
      set {
         this._everybodyGroupEnabled = value;
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
   public String NUGroupDN {
      get {
         return _groupDN;
      }
      set {
         this._groupDN = value;
      }
   }

   
   [JsonIgnore]
   public String NUGroupNamePrefix {
      get {
         return _groupNamePrefix;
      }
      set {
         this._groupNamePrefix = value;
      }
   }

   
   [JsonIgnore]
   public String NUGroupNameSuffix {
      get {
         return _groupNameSuffix;
      }
      set {
         this._groupNameSuffix = value;
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
   public String NUPort {
      get {
         return _port;
      }
      set {
         this._port = value;
      }
   }

   
   [JsonIgnore]
   public String NUServer {
      get {
         return _server;
      }
      set {
         this._server = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserDNTemplate {
      get {
         return _userDNTemplate;
      }
      set {
         this._userDNTemplate = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserNameAttribute {
      get {
         return _userNameAttribute;
      }
      set {
         this._userNameAttribute = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "LDAPConfiguration [" + "SSLEnabled=" + _SSLEnabled + ", acceptAllCertificates=" + _acceptAllCertificates + ", authorizationEnabled=" + _authorizationEnabled + ", authorizingUserDN=" + _authorizingUserDN + ", certificate=" + _certificate + ", creationDate=" + _creationDate + ", domain=" + _domain + ", embeddedMetadata=" + _embeddedMetadata + ", enabled=" + _enabled + ", entityScope=" + _entityScope + ", everybodyGroupEnabled=" + _everybodyGroupEnabled + ", externalID=" + _externalID + ", groupDN=" + _groupDN + ", groupNamePrefix=" + _groupNamePrefix + ", groupNameSuffix=" + _groupNameSuffix + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", password=" + _password + ", port=" + _port + ", server=" + _server + ", userDNTemplate=" + _userDNTemplate + ", userNameAttribute=" + _userNameAttribute + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ldapconfigurations";
   }

   public static String getRestName()
   {
	return "ldapconfiguration";
   }
}
}