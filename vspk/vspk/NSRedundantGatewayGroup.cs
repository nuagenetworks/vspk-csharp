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

public class NSRedundantGatewayGroup: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EPersonality {DC7X50,HARDWARE_VTEP,NSG,NSGBR,NSGDUC,NUAGE_210_WBX_32_Q,NUAGE_210_WBX_48_S,OTHER,VRSB,VRSG,VSA,VSG };
   public enum ERedundantGatewayStatus {FAILED,SUCCESS };

   
   [JsonProperty("consecutiveFailuresCount")]
   protected long? _consecutiveFailuresCount;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewayPeer1AutodiscoveredGatewayID")]
   protected String _gatewayPeer1AutodiscoveredGatewayID;
   
   [JsonProperty("gatewayPeer1Connected")]
   protected bool _gatewayPeer1Connected;
   
   [JsonProperty("gatewayPeer1ID")]
   protected String _gatewayPeer1ID;
   
   [JsonProperty("gatewayPeer1Name")]
   protected String _gatewayPeer1Name;
   
   [JsonProperty("gatewayPeer2AutodiscoveredGatewayID")]
   protected String _gatewayPeer2AutodiscoveredGatewayID;
   
   [JsonProperty("gatewayPeer2Connected")]
   protected bool _gatewayPeer2Connected;
   
   [JsonProperty("gatewayPeer2ID")]
   protected String _gatewayPeer2ID;
   
   [JsonProperty("gatewayPeer2Name")]
   protected String _gatewayPeer2Name;
   
   [JsonProperty("heartbeatInterval")]
   protected long? _heartbeatInterval;
   
   [JsonProperty("heartbeatVLANID")]
   protected long? _heartbeatVLANID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("personality")]
   protected EPersonality? _personality;
   
   [JsonProperty("redundancyPortIDs")]
   protected System.Collections.Generic.List<String> _redundancyPortIDs;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("redundantGatewayStatus")]
   protected ERedundantGatewayStatus? _redundantGatewayStatus;
   
   [JsonProperty("threatPreventionEnabled")]
   protected bool _threatPreventionEnabled;
   

   
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
   private NSGatewaysFetcher _nSGateways;
   
   [JsonIgnore]
   private RedundantPortsFetcher _redundantPorts;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private ShuntLinksFetcher _shuntLinks;
   
   public NSRedundantGatewayGroup() {
      
      _alarms = new AlarmsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _nSGateways = new NSGatewaysFetcher(this);
      
      _redundantPorts = new RedundantPortsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _shuntLinks = new ShuntLinksFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUConsecutiveFailuresCount {
      get {
         return _consecutiveFailuresCount;
      }
      set {
         this._consecutiveFailuresCount = value;
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
   public String NUGatewayPeer1AutodiscoveredGatewayID {
      get {
         return _gatewayPeer1AutodiscoveredGatewayID;
      }
      set {
         this._gatewayPeer1AutodiscoveredGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUGatewayPeer1Connected {
      get {
         return _gatewayPeer1Connected;
      }
      set {
         this._gatewayPeer1Connected = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayPeer1ID {
      get {
         return _gatewayPeer1ID;
      }
      set {
         this._gatewayPeer1ID = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayPeer1Name {
      get {
         return _gatewayPeer1Name;
      }
      set {
         this._gatewayPeer1Name = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayPeer2AutodiscoveredGatewayID {
      get {
         return _gatewayPeer2AutodiscoveredGatewayID;
      }
      set {
         this._gatewayPeer2AutodiscoveredGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUGatewayPeer2Connected {
      get {
         return _gatewayPeer2Connected;
      }
      set {
         this._gatewayPeer2Connected = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayPeer2ID {
      get {
         return _gatewayPeer2ID;
      }
      set {
         this._gatewayPeer2ID = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayPeer2Name {
      get {
         return _gatewayPeer2Name;
      }
      set {
         this._gatewayPeer2Name = value;
      }
   }

   
   [JsonIgnore]
   public long? NUHeartbeatInterval {
      get {
         return _heartbeatInterval;
      }
      set {
         this._heartbeatInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUHeartbeatVLANID {
      get {
         return _heartbeatVLANID;
      }
      set {
         this._heartbeatVLANID = value;
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
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
      }
   }

   
   [JsonIgnore]
   public EPersonality? NUPersonality {
      get {
         return _personality;
      }
      set {
         this._personality = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NURedundancyPortIDs {
      get {
         return _redundancyPortIDs;
      }
      set {
         this._redundancyPortIDs = value;
      }
   }

   
   [JsonIgnore]
   public ERedundantGatewayStatus? NURedundantGatewayStatus {
      get {
         return _redundantGatewayStatus;
      }
      set {
         this._redundantGatewayStatus = value;
      }
   }

   
   [JsonIgnore]
   public bool NUThreatPreventionEnabled {
      get {
         return _threatPreventionEnabled;
      }
      set {
         this._threatPreventionEnabled = value;
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
   
   public NSGatewaysFetcher getNSGateways() {
      return _nSGateways;
   }
   
   public RedundantPortsFetcher getRedundantPorts() {
      return _redundantPorts;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public ShuntLinksFetcher getShuntLinks() {
      return _shuntLinks;
   }
   

   public String toString() {
      return "NSRedundantGatewayGroup [" + "consecutiveFailuresCount=" + _consecutiveFailuresCount + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayPeer1AutodiscoveredGatewayID=" + _gatewayPeer1AutodiscoveredGatewayID + ", gatewayPeer1Connected=" + _gatewayPeer1Connected + ", gatewayPeer1ID=" + _gatewayPeer1ID + ", gatewayPeer1Name=" + _gatewayPeer1Name + ", gatewayPeer2AutodiscoveredGatewayID=" + _gatewayPeer2AutodiscoveredGatewayID + ", gatewayPeer2Connected=" + _gatewayPeer2Connected + ", gatewayPeer2ID=" + _gatewayPeer2ID + ", gatewayPeer2Name=" + _gatewayPeer2Name + ", heartbeatInterval=" + _heartbeatInterval + ", heartbeatVLANID=" + _heartbeatVLANID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", permittedAction=" + _permittedAction + ", personality=" + _personality + ", redundancyPortIDs=" + _redundancyPortIDs + ", redundantGatewayStatus=" + _redundantGatewayStatus + ", threatPreventionEnabled=" + _threatPreventionEnabled + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "nsgredundancygroups";
   }

   public static String getRestName()
   {
	return "nsgredundancygroup";
   }
}
}