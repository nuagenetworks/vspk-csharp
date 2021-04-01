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

public class IKEGatewayProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIKEGatewayIdentifierType {ID_DER_ASN1_DN,ID_FQDN,ID_IPV4_ADDR,ID_KEY_ID,ID_RFC822_ADDR };
   public enum EAssociatedCloudType {AZURECLOUD };
   public enum EAssociatedIKEAuthenticationType {IKE_CERTIFICATE,IKE_PSK };
   public enum EConfigurationStatus {CANCELING,CANCELLED,CLOUD_CONFIGURATION_REMOVED,FAILED,IN_PROGRESS,NOT_APPLICABLE,PAUSING,SUCCESS,SYNCED_FROM_CLOUD,UNKNOWN,WAITING,WAITING_FOR_RESOURCES };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EServiceClass {A,B,C,D,E,F,G,H,NONE };

   
   [JsonProperty("IKEGatewayIdentifier")]
   protected String _IKEGatewayIdentifier;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IKEGatewayIdentifierType")]
   protected EIKEGatewayIdentifierType? _IKEGatewayIdentifierType;
   
   [JsonProperty("antiReplayCheck")]
   protected bool _antiReplayCheck;
   
   [JsonProperty("associatedCloudID")]
   protected String _associatedCloudID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedCloudType")]
   protected EAssociatedCloudType? _associatedCloudType;
   
   [JsonProperty("associatedEnterpriseID")]
   protected String _associatedEnterpriseID;
   
   [JsonProperty("associatedIKEAuthenticationID")]
   protected String _associatedIKEAuthenticationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedIKEAuthenticationType")]
   protected EAssociatedIKEAuthenticationType? _associatedIKEAuthenticationType;
   
   [JsonProperty("associatedIKEEncryptionProfileID")]
   protected String _associatedIKEEncryptionProfileID;
   
   [JsonProperty("associatedIKEGatewayID")]
   protected String _associatedIKEGatewayID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configurationStatus")]
   protected EConfigurationStatus? _configurationStatus;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
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
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("serviceClass")]
   protected EServiceClass? _serviceClass;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public IKEGatewayProfile() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUIKEGatewayIdentifier {
      get {
         return _IKEGatewayIdentifier;
      }
      set {
         this._IKEGatewayIdentifier = value;
      }
   }

   
   [JsonIgnore]
   public EIKEGatewayIdentifierType? NUIKEGatewayIdentifierType {
      get {
         return _IKEGatewayIdentifierType;
      }
      set {
         this._IKEGatewayIdentifierType = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAntiReplayCheck {
      get {
         return _antiReplayCheck;
      }
      set {
         this._antiReplayCheck = value;
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
   public String NUAssociatedIKEAuthenticationID {
      get {
         return _associatedIKEAuthenticationID;
      }
      set {
         this._associatedIKEAuthenticationID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedIKEAuthenticationType? NUAssociatedIKEAuthenticationType {
      get {
         return _associatedIKEAuthenticationType;
      }
      set {
         this._associatedIKEAuthenticationType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEEncryptionProfileID {
      get {
         return _associatedIKEEncryptionProfileID;
      }
      set {
         this._associatedIKEEncryptionProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEGatewayID {
      get {
         return _associatedIKEGatewayID;
      }
      set {
         this._associatedIKEGatewayID = value;
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

   
   [JsonIgnore]
   public EServiceClass? NUServiceClass {
      get {
         return _serviceClass;
      }
      set {
         this._serviceClass = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "IKEGatewayProfile [" + "IKEGatewayIdentifier=" + _IKEGatewayIdentifier + ", IKEGatewayIdentifierType=" + _IKEGatewayIdentifierType + ", antiReplayCheck=" + _antiReplayCheck + ", associatedCloudID=" + _associatedCloudID + ", associatedCloudType=" + _associatedCloudType + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", associatedIKEAuthenticationID=" + _associatedIKEAuthenticationID + ", associatedIKEAuthenticationType=" + _associatedIKEAuthenticationType + ", associatedIKEEncryptionProfileID=" + _associatedIKEEncryptionProfileID + ", associatedIKEGatewayID=" + _associatedIKEGatewayID + ", configurationStatus=" + _configurationStatus + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", serviceClass=" + _serviceClass + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ikegatewayprofiles";
   }

   public static String getRestName()
   {
	return "ikegatewayprofile";
   }
}
}