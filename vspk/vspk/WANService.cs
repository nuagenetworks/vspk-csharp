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

public class WANService: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EConfigType {DYNAMIC,STATIC };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EServiceType {L2,L3 };
   public enum ETunnelType {DC_DEFAULT,GRE,VXLAN };

   
   [JsonProperty("IRBEnabled")]
   protected bool _IRBEnabled;
   
   [JsonProperty("WANServiceIdentifier")]
   protected String _WANServiceIdentifier;
   
   [JsonProperty("associatedDomainID")]
   protected String _associatedDomainID;
   
   [JsonProperty("associatedVPNConnectID")]
   protected String _associatedVPNConnectID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configType")]
   protected EConfigType? _configType;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("domainName")]
   protected String _domainName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   
   [JsonProperty("enterpriseName")]
   protected String _enterpriseName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("externalRouteTarget")]
   protected String _externalRouteTarget;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("orphan")]
   protected bool _orphan;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("servicePolicy")]
   protected String _servicePolicy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("serviceType")]
   protected EServiceType? _serviceType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("tunnelType")]
   protected ETunnelType? _tunnelType;
   
   [JsonProperty("useUserMnemonic")]
   protected bool _useUserMnemonic;
   
   [JsonProperty("userMnemonic")]
   protected String _userMnemonic;
   
   [JsonProperty("vnId")]
   protected long? _vnId;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public WANService() {
      _configType = EConfigType.STATIC;
      _serviceType = EServiceType.L3;
      
      _alarms = new AlarmsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUIRBEnabled {
      get {
         return _IRBEnabled;
      }
      set {
         this._IRBEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUWANServiceIdentifier {
      get {
         return _WANServiceIdentifier;
      }
      set {
         this._WANServiceIdentifier = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedDomainID {
      get {
         return _associatedDomainID;
      }
      set {
         this._associatedDomainID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVPNConnectID {
      get {
         return _associatedVPNConnectID;
      }
      set {
         this._associatedVPNConnectID = value;
      }
   }

   
   [JsonIgnore]
   public EConfigType? NUConfigType {
      get {
         return _configType;
      }
      set {
         this._configType = value;
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
   public String NUDomainName {
      get {
         return _domainName;
      }
      set {
         this._domainName = value;
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
   public String NUEnterpriseName {
      get {
         return _enterpriseName;
      }
      set {
         this._enterpriseName = value;
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
   public String NUExternalRouteTarget {
      get {
         return _externalRouteTarget;
      }
      set {
         this._externalRouteTarget = value;
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
   public bool NUOrphan {
      get {
         return _orphan;
      }
      set {
         this._orphan = value;
      }
   }

   
   [JsonIgnore]
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
      }
   }

   
   [JsonIgnore]
   public String NUServicePolicy {
      get {
         return _servicePolicy;
      }
      set {
         this._servicePolicy = value;
      }
   }

   
   [JsonIgnore]
   public EServiceType? NUServiceType {
      get {
         return _serviceType;
      }
      set {
         this._serviceType = value;
      }
   }

   
   [JsonIgnore]
   public ETunnelType? NUTunnelType {
      get {
         return _tunnelType;
      }
      set {
         this._tunnelType = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUseUserMnemonic {
      get {
         return _useUserMnemonic;
      }
      set {
         this._useUserMnemonic = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserMnemonic {
      get {
         return _userMnemonic;
      }
      set {
         this._userMnemonic = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVnId {
      get {
         return _vnId;
      }
      set {
         this._vnId = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public EnterprisePermissionsFetcher getEnterprisePermissions() {
      return _enterprisePermissions;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
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
      return "WANService [" + "IRBEnabled=" + _IRBEnabled + ", WANServiceIdentifier=" + _WANServiceIdentifier + ", associatedDomainID=" + _associatedDomainID + ", associatedVPNConnectID=" + _associatedVPNConnectID + ", configType=" + _configType + ", description=" + _description + ", domainName=" + _domainName + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseName=" + _enterpriseName + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", externalRouteTarget=" + _externalRouteTarget + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", orphan=" + _orphan + ", permittedAction=" + _permittedAction + ", servicePolicy=" + _servicePolicy + ", serviceType=" + _serviceType + ", tunnelType=" + _tunnelType + ", useUserMnemonic=" + _useUserMnemonic + ", userMnemonic=" + _userMnemonic + ", vnId=" + _vnId + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "services";
   }

   public static String getRestName()
   {
	return "service";
   }
}
}