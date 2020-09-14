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

public class VSD: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EMode {CLUSTER,STANDALONE };
   public enum EStatus {ADMIN_DOWN,DOWN,UP };

   
   [JsonProperty("URL")]
   protected String _URL;
   
   [JsonProperty("address")]
   protected String _address;
   
   [JsonProperty("alreadyMarkedForUnavailable")]
   protected bool _alreadyMarkedForUnavailable;
   
   [JsonProperty("averageCPUUsage")]
   protected float _averageCPUUsage;
   
   [JsonProperty("averageMemoryUsage")]
   protected float _averageMemoryUsage;
   
   [JsonProperty("currentCPUUsage")]
   protected float _currentCPUUsage;
   
   [JsonProperty("currentMemoryUsage")]
   protected float _currentMemoryUsage;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("disks")]
   protected System.Collections.Generic.List<String> _disks;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastStateChange")]
   protected long? _lastStateChange;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("location")]
   protected String _location;
   
   [JsonProperty("managementIP")]
   protected String _managementIP;
   
   [JsonProperty("messages")]
   protected System.Collections.Generic.List<String> _messages;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("mode")]
   protected EMode? _mode;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("peakCPUUsage")]
   protected float _peakCPUUsage;
   
   [JsonProperty("peakMemoryUsage")]
   protected float _peakMemoryUsage;
   
   [JsonProperty("peerAddresses")]
   protected String _peerAddresses;
   
   [JsonProperty("productVersion")]
   protected String _productVersion;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("unavailableTimestamp")]
   protected long? _unavailableTimestamp;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private VSDComponentsFetcher _vSDComponents;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public VSD() {
      
      _alarms = new AlarmsFetcher(this);
      
      _vSDComponents = new VSDComponentsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUURL {
      get {
         return _URL;
      }
      set {
         this._URL = value;
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
   public bool NUAlreadyMarkedForUnavailable {
      get {
         return _alreadyMarkedForUnavailable;
      }
      set {
         this._alreadyMarkedForUnavailable = value;
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
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUDisks {
      get {
         return _disks;
      }
      set {
         this._disks = value;
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
   public EMode? NUMode {
      get {
         return _mode;
      }
      set {
         this._mode = value;
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
   public String NUPeerAddresses {
      get {
         return _peerAddresses;
      }
      set {
         this._peerAddresses = value;
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
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public long? NUUnavailableTimestamp {
      get {
         return _unavailableTimestamp;
      }
      set {
         this._unavailableTimestamp = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public VSDComponentsFetcher getVSDComponents() {
      return _vSDComponents;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "VSD [" + "URL=" + _URL + ", address=" + _address + ", alreadyMarkedForUnavailable=" + _alreadyMarkedForUnavailable + ", averageCPUUsage=" + _averageCPUUsage + ", averageMemoryUsage=" + _averageMemoryUsage + ", currentCPUUsage=" + _currentCPUUsage + ", currentMemoryUsage=" + _currentMemoryUsage + ", description=" + _description + ", disks=" + _disks + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastStateChange=" + _lastStateChange + ", lastUpdatedBy=" + _lastUpdatedBy + ", location=" + _location + ", managementIP=" + _managementIP + ", messages=" + _messages + ", mode=" + _mode + ", name=" + _name + ", peakCPUUsage=" + _peakCPUUsage + ", peakMemoryUsage=" + _peakMemoryUsage + ", peerAddresses=" + _peerAddresses + ", productVersion=" + _productVersion + ", status=" + _status + ", unavailableTimestamp=" + _unavailableTimestamp + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vsds";
   }

   public static String getRestName()
   {
	return "vsd";
   }
}
}