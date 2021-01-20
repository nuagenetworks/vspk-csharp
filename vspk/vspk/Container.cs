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

public class Container: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDeleteMode {TIMER };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EReasonType {BLOCKED_LAST,BLOCKED_UNKNOWN,CRASHED_LAST,CRASHED_UNKNOWN,NOSTATE_LAST,NOSTATE_UNKNOWN,PAUSED_DUMP,PAUSED_FROM_SNAPSHOT,PAUSED_IOERROR,PAUSED_LAST,PAUSED_MIGRATION,PAUSED_SAVE,PAUSED_SHUTTING_DOWN,PAUSED_UNKNOWN,PAUSED_USER,PAUSED_WATCHDOG,RUNNING_BOOTED,RUNNING_FROM_SNAPSHOT,RUNNING_LAST,RUNNING_MIGRATED,RUNNING_MIGRATION_CANCELED,RUNNING_RESTORED,RUNNING_SAVE_CANCELED,RUNNING_UNKNOWN,RUNNING_UNPAUSED,SHUTDOWN_LAST,SHUTDOWN_UNKNOWN,SHUTDOWN_USER,SHUTOFF_CRASHED,SHUTOFF_DESTROYED,SHUTOFF_FAILED,SHUTOFF_FROM_SNAPSHOT,SHUTOFF_LAST,SHUTOFF_MIGRATED,SHUTOFF_SAVED,SHUTOFF_SHUTDOWN,SHUTOFF_UNKNOWN,UNKNOWN };
   public enum EStatus {BLOCKED,CRASHED,DELETE_PENDING,INIT,LAST,NOSTATE,PAUSED,RUNNING,SHUTDOWN,SHUTOFF,UNKNOWN,UNREACHABLE };

   
   [JsonProperty("UUID")]
   protected String _UUID;
   
   [JsonProperty("VRSID")]
   protected String _VRSID;
   
   [JsonProperty("computeProvisioned")]
   protected bool _computeProvisioned;
   
   [JsonProperty("deleteExpiry")]
   protected long? _deleteExpiry;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("deleteMode")]
   protected EDeleteMode? _deleteMode;
   
   [JsonProperty("domainIDs")]
   protected System.Collections.Generic.List<String> _domainIDs;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   
   [JsonProperty("enterpriseName")]
   protected String _enterpriseName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("hypervisorIP")]
   protected String _hypervisorIP;
   
   [JsonProperty("imageID")]
   protected String _imageID;
   
   [JsonProperty("imageName")]
   protected String _imageName;
   
   [JsonProperty("interfaces")]
   protected System.Collections.Generic.List<JObject> _interfaces;
   
   [JsonProperty("l2DomainIDs")]
   protected System.Collections.Generic.List<String> _l2DomainIDs;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("orchestrationID")]
   protected String _orchestrationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("reasonType")]
   protected EReasonType? _reasonType;
   
   [JsonProperty("resyncInfo")]
   protected Object _resyncInfo;
   
   [JsonProperty("siteIdentifier")]
   protected String _siteIdentifier;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("subnetIDs")]
   protected System.Collections.Generic.List<String> _subnetIDs;
   
   [JsonProperty("userID")]
   protected String _userID;
   
   [JsonProperty("userName")]
   protected String _userName;
   
   [JsonProperty("vrsRawVersion")]
   protected String _vrsRawVersion;
   
   [JsonProperty("vrsVersion")]
   protected String _vrsVersion;
   
   [JsonProperty("zoneIDs")]
   protected System.Collections.Generic.List<String> _zoneIDs;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private ContainerInterfacesFetcher _containerInterfaces;
   
   [JsonIgnore]
   private ContainerResyncsFetcher _containerResyncs;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private VRSsFetcher _vRSs;
   
   public Container() {
      
      _alarms = new AlarmsFetcher(this);
      
      _containerInterfaces = new ContainerInterfacesFetcher(this);
      
      _containerResyncs = new ContainerResyncsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _vRSs = new VRSsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUUUID {
      get {
         return _UUID;
      }
      set {
         this._UUID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSID {
      get {
         return _VRSID;
      }
      set {
         this._VRSID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUComputeProvisioned {
      get {
         return _computeProvisioned;
      }
      set {
         this._computeProvisioned = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDeleteExpiry {
      get {
         return _deleteExpiry;
      }
      set {
         this._deleteExpiry = value;
      }
   }

   
   [JsonIgnore]
   public EDeleteMode? NUDeleteMode {
      get {
         return _deleteMode;
      }
      set {
         this._deleteMode = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUDomainIDs {
      get {
         return _domainIDs;
      }
      set {
         this._domainIDs = value;
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
   public String NUHypervisorIP {
      get {
         return _hypervisorIP;
      }
      set {
         this._hypervisorIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUImageID {
      get {
         return _imageID;
      }
      set {
         this._imageID = value;
      }
   }

   
   [JsonIgnore]
   public String NUImageName {
      get {
         return _imageName;
      }
      set {
         this._imageName = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<JObject> NUInterfaces {
      get {
         return _interfaces;
      }
      set {
         this._interfaces = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUL2DomainIDs {
      get {
         return _l2DomainIDs;
      }
      set {
         this._l2DomainIDs = value;
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
   public String NUOrchestrationID {
      get {
         return _orchestrationID;
      }
      set {
         this._orchestrationID = value;
      }
   }

   
   [JsonIgnore]
   public EReasonType? NUReasonType {
      get {
         return _reasonType;
      }
      set {
         this._reasonType = value;
      }
   }

   
   [JsonIgnore]
   public Object NUResyncInfo {
      get {
         return _resyncInfo;
      }
      set {
         this._resyncInfo = value;
      }
   }

   
   [JsonIgnore]
   public String NUSiteIdentifier {
      get {
         return _siteIdentifier;
      }
      set {
         this._siteIdentifier = value;
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
   public System.Collections.Generic.List<String> NUSubnetIDs {
      get {
         return _subnetIDs;
      }
      set {
         this._subnetIDs = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserID {
      get {
         return _userID;
      }
      set {
         this._userID = value;
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

   
   [JsonIgnore]
   public String NUVrsRawVersion {
      get {
         return _vrsRawVersion;
      }
      set {
         this._vrsRawVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUVrsVersion {
      get {
         return _vrsVersion;
      }
      set {
         this._vrsVersion = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUZoneIDs {
      get {
         return _zoneIDs;
      }
      set {
         this._zoneIDs = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public ContainerInterfacesFetcher getContainerInterfaces() {
      return _containerInterfaces;
   }
   
   public ContainerResyncsFetcher getContainerResyncs() {
      return _containerResyncs;
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
   
   public VRSsFetcher getVRSs() {
      return _vRSs;
   }
   

   public String toString() {
      return "Container [" + "UUID=" + _UUID + ", VRSID=" + _VRSID + ", computeProvisioned=" + _computeProvisioned + ", deleteExpiry=" + _deleteExpiry + ", deleteMode=" + _deleteMode + ", domainIDs=" + _domainIDs + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseID=" + _enterpriseID + ", enterpriseName=" + _enterpriseName + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", hypervisorIP=" + _hypervisorIP + ", imageID=" + _imageID + ", imageName=" + _imageName + ", interfaces=" + _interfaces + ", l2DomainIDs=" + _l2DomainIDs + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", orchestrationID=" + _orchestrationID + ", reasonType=" + _reasonType + ", resyncInfo=" + _resyncInfo + ", siteIdentifier=" + _siteIdentifier + ", status=" + _status + ", subnetIDs=" + _subnetIDs + ", userID=" + _userID + ", userName=" + _userName + ", vrsRawVersion=" + _vrsRawVersion + ", vrsVersion=" + _vrsVersion + ", zoneIDs=" + _zoneIDs + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "containers";
   }

   public static String getRestName()
   {
	return "container";
   }
}
}