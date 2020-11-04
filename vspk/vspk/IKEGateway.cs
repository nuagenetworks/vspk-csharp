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

public class IKEGateway: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIKEVersion {V1,V2 };
   public enum EIKEv1Mode {AGGRESSIVE,MAIN,NONE };
   public enum EAssociatedCloudType {AZURECLOUD };
   public enum EConfigurationStatus {CANCELING,CANCELLED,CLOUD_CONFIGURATION_REMOVED,FAILED,IN_PROGRESS,NOT_APPLICABLE,PAUSING,SUCCESS,SYNCED_FROM_CLOUD,UNKNOWN,WAITING,WAITING_FOR_RESOURCES };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IKEVersion")]
   protected EIKEVersion? _IKEVersion;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IKEv1Mode")]
   protected EIKEv1Mode? _IKEv1Mode;
   
   [JsonProperty("IPAddress")]
   protected String _IPAddress;
   
   [JsonProperty("associatedCloudID")]
   protected String _associatedCloudID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedCloudType")]
   protected EAssociatedCloudType? _associatedCloudType;
   
   [JsonProperty("associatedEnterpriseID")]
   protected String _associatedEnterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configurationStatus")]
   protected EConfigurationStatus? _configurationStatus;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private IKEGatewayConfigsFetcher _iKEGatewayConfigs;
   
   [JsonIgnore]
   private IKESubnetsFetcher _iKESubnets;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public IKEGateway() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _iKEGatewayConfigs = new IKEGatewayConfigsFetcher(this);
      
      _iKESubnets = new IKESubnetsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EIKEVersion? NUIKEVersion {
      get {
         return _IKEVersion;
      }
      set {
         this._IKEVersion = value;
      }
   }

   
   [JsonIgnore]
   public EIKEv1Mode? NUIKEv1Mode {
      get {
         return _IKEv1Mode;
      }
      set {
         this._IKEv1Mode = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPAddress {
      get {
         return _IPAddress;
      }
      set {
         this._IPAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedCloudID {
      get {
         return _associatedCloudID;
      }
      set {
         this._associatedCloudID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedCloudType? NUAssociatedCloudType {
      get {
         return _associatedCloudType;
      }
      set {
         this._associatedCloudType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEnterpriseID {
      get {
         return _associatedEnterpriseID;
      }
      set {
         this._associatedEnterpriseID = value;
      }
   }

   
   [JsonIgnore]
   public EConfigurationStatus? NUConfigurationStatus {
      get {
         return _configurationStatus;
      }
      set {
         this._configurationStatus = value;
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
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
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

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public IKEGatewayConfigsFetcher getIKEGatewayConfigs() {
      return _iKEGatewayConfigs;
   }
   
   public IKESubnetsFetcher getIKESubnets() {
      return _iKESubnets;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "IKEGateway [" + "IKEVersion=" + _IKEVersion + ", IKEv1Mode=" + _IKEv1Mode + ", IPAddress=" + _IPAddress + ", associatedCloudID=" + _associatedCloudID + ", associatedCloudType=" + _associatedCloudType + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", configurationStatus=" + _configurationStatus + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ikegateways";
   }

   public static String getRestName()
   {
	return "ikegateway";
   }
}
}