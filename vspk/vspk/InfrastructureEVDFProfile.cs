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

using net.nuagenetworks.vspk.v5_0.fetchers;

namespace net.nuagenetworks.vspk.v5_0
{

public class InfrastructureEVDFProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ENuagePlatform {KVM,KVM_K8S,KVM_LXC };

   
   [JsonProperty("NTPServerKey")]
   protected String _NTPServerKey;
   
   [JsonProperty("NTPServerKeyID")]
   protected long? _NTPServerKeyID;
   
   [JsonProperty("activeController")]
   protected String _activeController;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("nuagePlatform")]
   protected ENuagePlatform? _nuagePlatform;
   
   [JsonProperty("proxyDNSName")]
   protected String _proxyDNSName;
   
   [JsonProperty("serviceIPv4Subnet")]
   protected String _serviceIPv4Subnet;
   
   [JsonProperty("standbyController")]
   protected String _standbyController;
   
   [JsonProperty("useTwoFactor")]
   protected bool _useTwoFactor;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public InfrastructureEVDFProfile() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUNTPServerKey {
      get {
         return _NTPServerKey;
      }
      set {
         this._NTPServerKey = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNTPServerKeyID {
      get {
         return _NTPServerKeyID;
      }
      set {
         this._NTPServerKeyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUActiveController {
      get {
         return _activeController;
      }
      set {
         this._activeController = value;
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
   public String NUEnterpriseID {
      get {
         return _enterpriseID;
      }
      set {
         this._enterpriseID = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public ENuagePlatform? NUNuagePlatform {
      get {
         return _nuagePlatform;
      }
      set {
         this._nuagePlatform = value;
      }
   }

   
   [JsonIgnore]
   public String NUProxyDNSName {
      get {
         return _proxyDNSName;
      }
      set {
         this._proxyDNSName = value;
      }
   }

   
   [JsonIgnore]
   public String NUServiceIPv4Subnet {
      get {
         return _serviceIPv4Subnet;
      }
      set {
         this._serviceIPv4Subnet = value;
      }
   }

   
   [JsonIgnore]
   public String NUStandbyController {
      get {
         return _standbyController;
      }
      set {
         this._standbyController = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUseTwoFactor {
      get {
         return _useTwoFactor;
      }
      set {
         this._useTwoFactor = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "InfrastructureEVDFProfile [" + "NTPServerKey=" + _NTPServerKey + ", NTPServerKeyID=" + _NTPServerKeyID + ", activeController=" + _activeController + ", description=" + _description + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", nuagePlatform=" + _nuagePlatform + ", proxyDNSName=" + _proxyDNSName + ", serviceIPv4Subnet=" + _serviceIPv4Subnet + ", standbyController=" + _standbyController + ", useTwoFactor=" + _useTwoFactor + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "infrastructureevdfprofiles";
   }

   public static String getRestName()
   {
	return "infrastructureevdfprofile";
   }
}
}