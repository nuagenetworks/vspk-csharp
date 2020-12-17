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

public class VLAN: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAssociatedConnectionType {BR_CONNECTION,UPLINK_CONNECTION };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EStatus {INITIALIZED,MISMATCH,ORPHAN,READY };
   public enum EType {ACCESS,BR,DUC,UPLINK };

   
   [JsonProperty("TrafficThroughUBROnly")]
   protected bool _TrafficThroughUBROnly;
   
   [JsonProperty("associatedBGPProfileID")]
   protected String _associatedBGPProfileID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedConnectionType")]
   protected EAssociatedConnectionType? _associatedConnectionType;
   
   [JsonProperty("associatedEgressQOSPolicyID")]
   protected String _associatedEgressQOSPolicyID;
   
   [JsonProperty("associatedIngressOverlayQoSPolicerID")]
   protected String _associatedIngressOverlayQoSPolicerID;
   
   [JsonProperty("associatedIngressQOSPolicyID")]
   protected String _associatedIngressQOSPolicyID;
   
   [JsonProperty("associatedIngressUnderlayQoSPolicerID")]
   protected String _associatedIngressUnderlayQoSPolicerID;
   
   [JsonProperty("associatedUplinkConnectionID")]
   protected String _associatedUplinkConnectionID;
   
   [JsonProperty("associatedVSCProfileID")]
   protected String _associatedVSCProfileID;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("ducVlan")]
   protected bool _ducVlan;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enableNATProbes")]
   protected bool _enableNATProbes;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewayID")]
   protected String _gatewayID;
   
   [JsonProperty("inheritedPortPropertiesDiverged")]
   protected bool _inheritedPortPropertiesDiverged;
   
   [JsonProperty("isUplink")]
   protected bool _isUplink;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("mtu")]
   protected long? _mtu;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("readonly")]
   protected bool _readonly;
   
   [JsonProperty("restricted")]
   protected bool _restricted;
   
   [JsonProperty("shuntVLAN")]
   protected bool _shuntVLAN;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   
   [JsonProperty("useUserMnemonic")]
   protected bool _useUserMnemonic;
   
   [JsonProperty("userMnemonic")]
   protected String _userMnemonic;
   
   [JsonProperty("value")]
   protected long? _value;
   
   [JsonProperty("vportID")]
   protected String _vportID;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private BGPNeighborsFetcher _bGPNeighbors;
   
   [JsonIgnore]
   private BRConnectionsFetcher _bRConnections;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private IKEGatewayConnectionsFetcher _iKEGatewayConnections;
   
   [JsonIgnore]
   private LtestatisticsFetcher _ltestatistics;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PATNATPoolsFetcher _pATNATPools;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private UplinkConnectionsFetcher _uplinkConnections;
   
   public VLAN() {
      
      _alarms = new AlarmsFetcher(this);
      
      _bGPNeighbors = new BGPNeighborsFetcher(this);
      
      _bRConnections = new BRConnectionsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _iKEGatewayConnections = new IKEGatewayConnectionsFetcher(this);
      
      _ltestatistics = new LtestatisticsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _pATNATPools = new PATNATPoolsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _uplinkConnections = new UplinkConnectionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUTrafficThroughUBROnly {
      get {
         return _TrafficThroughUBROnly;
      }
      set {
         this._TrafficThroughUBROnly = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedBGPProfileID {
      get {
         return _associatedBGPProfileID;
      }
      set {
         this._associatedBGPProfileID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedConnectionType? NUAssociatedConnectionType {
      get {
         return _associatedConnectionType;
      }
      set {
         this._associatedConnectionType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEgressQOSPolicyID {
      get {
         return _associatedEgressQOSPolicyID;
      }
      set {
         this._associatedEgressQOSPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIngressOverlayQoSPolicerID {
      get {
         return _associatedIngressOverlayQoSPolicerID;
      }
      set {
         this._associatedIngressOverlayQoSPolicerID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIngressQOSPolicyID {
      get {
         return _associatedIngressQOSPolicyID;
      }
      set {
         this._associatedIngressQOSPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIngressUnderlayQoSPolicerID {
      get {
         return _associatedIngressUnderlayQoSPolicerID;
      }
      set {
         this._associatedIngressUnderlayQoSPolicerID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUplinkConnectionID {
      get {
         return _associatedUplinkConnectionID;
      }
      set {
         this._associatedUplinkConnectionID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVSCProfileID {
      get {
         return _associatedVSCProfileID;
      }
      set {
         this._associatedVSCProfileID = value;
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
   public bool NUDucVlan {
      get {
         return _ducVlan;
      }
      set {
         this._ducVlan = value;
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
   public bool NUEnableNATProbes {
      get {
         return _enableNATProbes;
      }
      set {
         this._enableNATProbes = value;
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
   public String NUGatewayID {
      get {
         return _gatewayID;
      }
      set {
         this._gatewayID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUInheritedPortPropertiesDiverged {
      get {
         return _inheritedPortPropertiesDiverged;
      }
      set {
         this._inheritedPortPropertiesDiverged = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIsUplink {
      get {
         return _isUplink;
      }
      set {
         this._isUplink = value;
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
   public long? NUMtu {
      get {
         return _mtu;
      }
      set {
         this._mtu = value;
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
   public bool NUReadonly {
      get {
         return _readonly;
      }
      set {
         this._readonly = value;
      }
   }

   
   [JsonIgnore]
   public bool NURestricted {
      get {
         return _restricted;
      }
      set {
         this._restricted = value;
      }
   }

   
   [JsonIgnore]
   public bool NUShuntVLAN {
      get {
         return _shuntVLAN;
      }
      set {
         this._shuntVLAN = value;
      }
   }

   
   [JsonIgnore]
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public String NUTemplateID {
      get {
         return _templateID;
      }
      set {
         this._templateID = value;
      }
   }

   
   [JsonIgnore]
   public EType? NUType {
      get {
         return _type;
      }
      set {
         this._type = value;
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
   public long? NUValue {
      get {
         return _value;
      }
      set {
         this._value = value;
      }
   }

   
   [JsonIgnore]
   public String NUVportID {
      get {
         return _vportID;
      }
      set {
         this._vportID = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public BGPNeighborsFetcher getBGPNeighbors() {
      return _bGPNeighbors;
   }
   
   public BRConnectionsFetcher getBRConnections() {
      return _bRConnections;
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
   
   public IKEGatewayConnectionsFetcher getIKEGatewayConnections() {
      return _iKEGatewayConnections;
   }
   
   public LtestatisticsFetcher getLtestatistics() {
      return _ltestatistics;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PATNATPoolsFetcher getPATNATPools() {
      return _pATNATPools;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   
   public UplinkConnectionsFetcher getUplinkConnections() {
      return _uplinkConnections;
   }
   

   public String toString() {
      return "VLAN [" + "TrafficThroughUBROnly=" + _TrafficThroughUBROnly + ", associatedBGPProfileID=" + _associatedBGPProfileID + ", associatedConnectionType=" + _associatedConnectionType + ", associatedEgressQOSPolicyID=" + _associatedEgressQOSPolicyID + ", associatedIngressOverlayQoSPolicerID=" + _associatedIngressOverlayQoSPolicerID + ", associatedIngressQOSPolicyID=" + _associatedIngressQOSPolicyID + ", associatedIngressUnderlayQoSPolicerID=" + _associatedIngressUnderlayQoSPolicerID + ", associatedUplinkConnectionID=" + _associatedUplinkConnectionID + ", associatedVSCProfileID=" + _associatedVSCProfileID + ", creationDate=" + _creationDate + ", description=" + _description + ", ducVlan=" + _ducVlan + ", embeddedMetadata=" + _embeddedMetadata + ", enableNATProbes=" + _enableNATProbes + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayID=" + _gatewayID + ", inheritedPortPropertiesDiverged=" + _inheritedPortPropertiesDiverged + ", isUplink=" + _isUplink + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", mtu=" + _mtu + ", owner=" + _owner + ", permittedAction=" + _permittedAction + ", readonly=" + _readonly + ", restricted=" + _restricted + ", shuntVLAN=" + _shuntVLAN + ", status=" + _status + ", templateID=" + _templateID + ", type=" + _type + ", useUserMnemonic=" + _useUserMnemonic + ", userMnemonic=" + _userMnemonic + ", value=" + _value + ", vportID=" + _vportID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vlans";
   }

   public static String getRestName()
   {
	return "vlan";
   }
}
}