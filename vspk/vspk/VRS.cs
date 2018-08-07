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

public class VRS: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EJSONRPCConnectionState {ADMIN_DOWN,DOWN,UP };
   public enum EClusterNodeRole {NONE,PRIMARY,SECONDARY };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EHypervisorConnectionState {ADMIN_DOWN,DOWN,UP };
   public enum ELicensedState {LICENSED,UNLICENSED };
   public enum EPersonality {HARDWARE_VTEP,NONE,NSG,NSGBR,NSGDUC,NUAGE_210_WBX_32_Q,NUAGE_210_WBX_48_S,VRS,VRSB,VRSG };
   public enum ERole {MASTER,NONE,SLAVE };
   public enum EStatus {ADMIN_DOWN,DOWN,UP };
   public enum EVscConfigState {PRIMARY,SECONDARY };
   public enum EVscCurrentState {PRIMARY,SECONDARY };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("JSONRPCConnectionState")]
   protected EJSONRPCConnectionState? _JSONRPCConnectionState;
   
   [JsonProperty("address")]
   protected String _address;
   
   [JsonProperty("averageCPUUsage")]
   protected float _averageCPUUsage;
   
   [JsonProperty("averageMemoryUsage")]
   protected float _averageMemoryUsage;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("clusterNodeRole")]
   protected EClusterNodeRole? _clusterNodeRole;
   
   [JsonProperty("currentCPUUsage")]
   protected float _currentCPUUsage;
   
   [JsonProperty("currentMemoryUsage")]
   protected float _currentMemoryUsage;
   
   [JsonProperty("dbSynced")]
   protected bool _dbSynced;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("disks")]
   protected System.Collections.Generic.List<DiskStat> _disks;
   
   [JsonProperty("dynamic")]
   protected bool _dynamic;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewayUUID")]
   protected String _gatewayUUID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("hypervisorConnectionState")]
   protected EHypervisorConnectionState? _hypervisorConnectionState;
   
   [JsonProperty("hypervisorIdentifier")]
   protected String _hypervisorIdentifier;
   
   [JsonProperty("hypervisorName")]
   protected String _hypervisorName;
   
   [JsonProperty("hypervisorType")]
   protected String _hypervisorType;
   
   [JsonProperty("isResilient")]
   protected bool _isResilient;
   
   [JsonProperty("lastEventName")]
   protected String _lastEventName;
   
   [JsonProperty("lastEventObject")]
   protected String _lastEventObject;
   
   [JsonProperty("lastEventTimestamp")]
   protected long? _lastEventTimestamp;
   
   [JsonProperty("lastStateChange")]
   protected long? _lastStateChange;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("licensedState")]
   protected ELicensedState? _licensedState;
   
   [JsonProperty("location")]
   protected String _location;
   
   [JsonProperty("managementIP")]
   protected String _managementIP;
   
   [JsonProperty("messages")]
   protected System.Collections.Generic.List<String> _messages;
   
   [JsonProperty("multiNICVPortEnabled")]
   protected bool _multiNICVPortEnabled;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("numberOfBridgeInterfaces")]
   protected long? _numberOfBridgeInterfaces;
   
   [JsonProperty("numberOfContainers")]
   protected long? _numberOfContainers;
   
   [JsonProperty("numberOfHostInterfaces")]
   protected long? _numberOfHostInterfaces;
   
   [JsonProperty("numberOfVirtualMachines")]
   protected long? _numberOfVirtualMachines;
   
   [JsonProperty("parentIDs")]
   protected System.Collections.Generic.List<String> _parentIDs;
   
   [JsonProperty("peakCPUUsage")]
   protected float _peakCPUUsage;
   
   [JsonProperty("peakMemoryUsage")]
   protected float _peakMemoryUsage;
   
   [JsonProperty("peer")]
   protected String _peer;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("personality")]
   protected EPersonality? _personality;
   
   [JsonProperty("primaryVSCConnectionLost")]
   protected bool _primaryVSCConnectionLost;
   
   [JsonProperty("productVersion")]
   protected String _productVersion;
   
   [JsonProperty("revertBehaviorEnabled")]
   protected bool _revertBehaviorEnabled;
   
   [JsonProperty("revertCompleted")]
   protected bool _revertCompleted;
   
   [JsonProperty("revertCount")]
   protected long? _revertCount;
   
   [JsonProperty("revertFailedCount")]
   protected long? _revertFailedCount;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("role")]
   protected ERole? _role;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("uptime")]
   protected long? _uptime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("vscConfigState")]
   protected EVscConfigState? _vscConfigState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("vscCurrentState")]
   protected EVscCurrentState? _vscCurrentState;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private ContainersFetcher _containers;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private HSCsFetcher _hSCs;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private MonitoringPortsFetcher _monitoringPorts;
   
   [JsonIgnore]
   private MultiNICVPortsFetcher _multiNICVPorts;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private VMsFetcher _vMs;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   [JsonIgnore]
   private VSCsFetcher _vSCs;
   
   public VRS() {
      
      _alarms = new AlarmsFetcher(this);
      
      _containers = new ContainersFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _hSCs = new HSCsFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _monitoringPorts = new MonitoringPortsFetcher(this);
      
      _multiNICVPorts = new MultiNICVPortsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _vMs = new VMsFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
      _vSCs = new VSCsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EJSONRPCConnectionState? NUJSONRPCConnectionState {
      get {
         return _JSONRPCConnectionState;
      }
      set {
         this._JSONRPCConnectionState = value;
      }
   }

   
   [JsonIgnore]
   public String NUAddress {
      get {
         return _address;
      }
      set {
         this._address = value;
      }
   }

   
   [JsonIgnore]
   public float NUAverageCPUUsage {
      get {
         return _averageCPUUsage;
      }
      set {
         this._averageCPUUsage = value;
      }
   }

   
   [JsonIgnore]
   public float NUAverageMemoryUsage {
      get {
         return _averageMemoryUsage;
      }
      set {
         this._averageMemoryUsage = value;
      }
   }

   
   [JsonIgnore]
   public EClusterNodeRole? NUClusterNodeRole {
      get {
         return _clusterNodeRole;
      }
      set {
         this._clusterNodeRole = value;
      }
   }

   
   [JsonIgnore]
   public float NUCurrentCPUUsage {
      get {
         return _currentCPUUsage;
      }
      set {
         this._currentCPUUsage = value;
      }
   }

   
   [JsonIgnore]
   public float NUCurrentMemoryUsage {
      get {
         return _currentMemoryUsage;
      }
      set {
         this._currentMemoryUsage = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDbSynced {
      get {
         return _dbSynced;
      }
      set {
         this._dbSynced = value;
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
   public System.Collections.Generic.List<DiskStat> NUDisks {
      get {
         return _disks;
      }
      set {
         this._disks = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDynamic {
      get {
         return _dynamic;
      }
      set {
         this._dynamic = value;
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
   public String NUGatewayUUID {
      get {
         return _gatewayUUID;
      }
      set {
         this._gatewayUUID = value;
      }
   }

   
   [JsonIgnore]
   public EHypervisorConnectionState? NUHypervisorConnectionState {
      get {
         return _hypervisorConnectionState;
      }
      set {
         this._hypervisorConnectionState = value;
      }
   }

   
   [JsonIgnore]
   public String NUHypervisorIdentifier {
      get {
         return _hypervisorIdentifier;
      }
      set {
         this._hypervisorIdentifier = value;
      }
   }

   
   [JsonIgnore]
   public String NUHypervisorName {
      get {
         return _hypervisorName;
      }
      set {
         this._hypervisorName = value;
      }
   }

   
   [JsonIgnore]
   public String NUHypervisorType {
      get {
         return _hypervisorType;
      }
      set {
         this._hypervisorType = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIsResilient {
      get {
         return _isResilient;
      }
      set {
         this._isResilient = value;
      }
   }

   
   [JsonIgnore]
   public String NULastEventName {
      get {
         return _lastEventName;
      }
      set {
         this._lastEventName = value;
      }
   }

   
   [JsonIgnore]
   public String NULastEventObject {
      get {
         return _lastEventObject;
      }
      set {
         this._lastEventObject = value;
      }
   }

   
   [JsonIgnore]
   public long? NULastEventTimestamp {
      get {
         return _lastEventTimestamp;
      }
      set {
         this._lastEventTimestamp = value;
      }
   }

   
   [JsonIgnore]
   public long? NULastStateChange {
      get {
         return _lastStateChange;
      }
      set {
         this._lastStateChange = value;
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
   public ELicensedState? NULicensedState {
      get {
         return _licensedState;
      }
      set {
         this._licensedState = value;
      }
   }

   
   [JsonIgnore]
   public String NULocation {
      get {
         return _location;
      }
      set {
         this._location = value;
      }
   }

   
   [JsonIgnore]
   public String NUManagementIP {
      get {
         return _managementIP;
      }
      set {
         this._managementIP = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUMessages {
      get {
         return _messages;
      }
      set {
         this._messages = value;
      }
   }

   
   [JsonIgnore]
   public bool NUMultiNICVPortEnabled {
      get {
         return _multiNICVPortEnabled;
      }
      set {
         this._multiNICVPortEnabled = value;
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
   public long? NUNumberOfBridgeInterfaces {
      get {
         return _numberOfBridgeInterfaces;
      }
      set {
         this._numberOfBridgeInterfaces = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNumberOfContainers {
      get {
         return _numberOfContainers;
      }
      set {
         this._numberOfContainers = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNumberOfHostInterfaces {
      get {
         return _numberOfHostInterfaces;
      }
      set {
         this._numberOfHostInterfaces = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNumberOfVirtualMachines {
      get {
         return _numberOfVirtualMachines;
      }
      set {
         this._numberOfVirtualMachines = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUParentIDs {
      get {
         return _parentIDs;
      }
      set {
         this._parentIDs = value;
      }
   }

   
   [JsonIgnore]
   public float NUPeakCPUUsage {
      get {
         return _peakCPUUsage;
      }
      set {
         this._peakCPUUsage = value;
      }
   }

   
   [JsonIgnore]
   public float NUPeakMemoryUsage {
      get {
         return _peakMemoryUsage;
      }
      set {
         this._peakMemoryUsage = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeer {
      get {
         return _peer;
      }
      set {
         this._peer = value;
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
   public bool NUPrimaryVSCConnectionLost {
      get {
         return _primaryVSCConnectionLost;
      }
      set {
         this._primaryVSCConnectionLost = value;
      }
   }

   
   [JsonIgnore]
   public String NUProductVersion {
      get {
         return _productVersion;
      }
      set {
         this._productVersion = value;
      }
   }

   
   [JsonIgnore]
   public bool NURevertBehaviorEnabled {
      get {
         return _revertBehaviorEnabled;
      }
      set {
         this._revertBehaviorEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NURevertCompleted {
      get {
         return _revertCompleted;
      }
      set {
         this._revertCompleted = value;
      }
   }

   
   [JsonIgnore]
   public long? NURevertCount {
      get {
         return _revertCount;
      }
      set {
         this._revertCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NURevertFailedCount {
      get {
         return _revertFailedCount;
      }
      set {
         this._revertFailedCount = value;
      }
   }

   
   [JsonIgnore]
   public ERole? NURole {
      get {
         return _role;
      }
      set {
         this._role = value;
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
   public long? NUUptime {
      get {
         return _uptime;
      }
      set {
         this._uptime = value;
      }
   }

   
   [JsonIgnore]
   public EVscConfigState? NUVscConfigState {
      get {
         return _vscConfigState;
      }
      set {
         this._vscConfigState = value;
      }
   }

   
   [JsonIgnore]
   public EVscCurrentState? NUVscCurrentState {
      get {
         return _vscCurrentState;
      }
      set {
         this._vscCurrentState = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
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
   
   public HSCsFetcher getHSCs() {
      return _hSCs;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public MonitoringPortsFetcher getMonitoringPorts() {
      return _monitoringPorts;
   }
   
   public MultiNICVPortsFetcher getMultiNICVPorts() {
      return _multiNICVPorts;
   }
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   
   public VMsFetcher getVMs() {
      return _vMs;
   }
   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   
   public VSCsFetcher getVSCs() {
      return _vSCs;
   }
   

   public String toString() {
      return "VRS [" + "JSONRPCConnectionState=" + _JSONRPCConnectionState + ", address=" + _address + ", averageCPUUsage=" + _averageCPUUsage + ", averageMemoryUsage=" + _averageMemoryUsage + ", clusterNodeRole=" + _clusterNodeRole + ", currentCPUUsage=" + _currentCPUUsage + ", currentMemoryUsage=" + _currentMemoryUsage + ", dbSynced=" + _dbSynced + ", description=" + _description + ", disks=" + _disks + ", dynamic=" + _dynamic + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayUUID=" + _gatewayUUID + ", hypervisorConnectionState=" + _hypervisorConnectionState + ", hypervisorIdentifier=" + _hypervisorIdentifier + ", hypervisorName=" + _hypervisorName + ", hypervisorType=" + _hypervisorType + ", isResilient=" + _isResilient + ", lastEventName=" + _lastEventName + ", lastEventObject=" + _lastEventObject + ", lastEventTimestamp=" + _lastEventTimestamp + ", lastStateChange=" + _lastStateChange + ", lastUpdatedBy=" + _lastUpdatedBy + ", licensedState=" + _licensedState + ", location=" + _location + ", managementIP=" + _managementIP + ", messages=" + _messages + ", multiNICVPortEnabled=" + _multiNICVPortEnabled + ", name=" + _name + ", numberOfBridgeInterfaces=" + _numberOfBridgeInterfaces + ", numberOfContainers=" + _numberOfContainers + ", numberOfHostInterfaces=" + _numberOfHostInterfaces + ", numberOfVirtualMachines=" + _numberOfVirtualMachines + ", parentIDs=" + _parentIDs + ", peakCPUUsage=" + _peakCPUUsage + ", peakMemoryUsage=" + _peakMemoryUsage + ", peer=" + _peer + ", personality=" + _personality + ", primaryVSCConnectionLost=" + _primaryVSCConnectionLost + ", productVersion=" + _productVersion + ", revertBehaviorEnabled=" + _revertBehaviorEnabled + ", revertCompleted=" + _revertCompleted + ", revertCount=" + _revertCount + ", revertFailedCount=" + _revertFailedCount + ", role=" + _role + ", status=" + _status + ", uptime=" + _uptime + ", vscConfigState=" + _vscConfigState + ", vscCurrentState=" + _vscCurrentState + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vrss";
   }

   public static String getRestName()
   {
	return "vrs";
   }
}
}