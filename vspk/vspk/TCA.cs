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

public class TCA: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAction {Alert,Alert_Add_Network_Macro,Alert_Add_Policy_Group,Alert_PolicyGroupChange };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EMetric {ACL_DENY_EVENT_COUNT,ANTI_SPOOF_EVENT_COUNT,BYTES_IN,BYTES_OUT,FIP_PRE_RATE_LIMIT_BYTES,FIP_PRE_RATE_LIMIT_PACKETS,FIP_RATE_LIMIT_DROPPED_BYTES,FIP_RATE_LIMIT_DROPPED_PACKETS,HIGH_RISK_IP_ACCESS_EVENT_COUNT,IDP_EVENT_COUNT,L7_BYTES_IN,L7_BYTES_OUT,L7_PACKETS_IN,L7_PACKETS_OUT,MEDIUM_RISK_IP_ACCESS_EVENT_COUNT,PACKETS_DROPPED_BY_RATE_LIMIT,PACKETS_IN,PACKETS_IN_DROPPED,PACKETS_IN_ERROR,PACKETS_OUT,PACKETS_OUT_DROPPED,PACKETS_OUT_ERROR,PORT_SCAN_PORT_COUNT,PORT_SWEEP_IP_COUNT,TCP_FLAG_ACK_IN,TCP_FLAG_ACK_OUT,TCP_FLAG_NULL_IN,TCP_FLAG_NULL_OUT,TCP_FLAG_RST_IN,TCP_FLAG_RST_OUT,TCP_FLAG_SYN_IN,TCP_FLAG_SYN_OUT };
   public enum EType {BREACH,ROLLING_AVERAGE,UNIQUE_COUNT };

   
   [JsonProperty("URLEndPoint")]
   protected String _URLEndPoint;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("action")]
   protected EAction? _action;
   
   [JsonProperty("count")]
   protected long? _count;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("disable")]
   protected bool _disable;
   
   [JsonProperty("displayStatus")]
   protected String _displayStatus;
   
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
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("metric")]
   protected EMetric? _metric;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("period")]
   protected long? _period;
   
   [JsonProperty("status")]
   protected bool _status;
   
   [JsonProperty("targetEntityID")]
   protected String _targetEntityID;
   
   [JsonProperty("targetPolicyGroupID")]
   protected String _targetPolicyGroupID;
   
   [JsonProperty("threshold")]
   protected long? _threshold;
   
   [JsonProperty("throttleTime")]
   protected long? _throttleTime;
   
   [JsonProperty("triggerInterval")]
   protected long? _triggerInterval;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public TCA() {
      _metric = EMetric.BYTES_IN;
      _type = EType.ROLLING_AVERAGE;
      
      _alarms = new AlarmsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUURLEndPoint {
      get {
         return _URLEndPoint;
      }
      set {
         this._URLEndPoint = value;
      }
   }

   
   [JsonIgnore]
   public EAction? NUAction {
      get {
         return _action;
      }
      set {
         this._action = value;
      }
   }

   
   [JsonIgnore]
   public long? NUCount {
      get {
         return _count;
      }
      set {
         this._count = value;
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
   public bool NUDisable {
      get {
         return _disable;
      }
      set {
         this._disable = value;
      }
   }

   
   [JsonIgnore]
   public String NUDisplayStatus {
      get {
         return _displayStatus;
      }
      set {
         this._displayStatus = value;
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
   public EMetric? NUMetric {
      get {
         return _metric;
      }
      set {
         this._metric = value;
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
   public long? NUPeriod {
      get {
         return _period;
      }
      set {
         this._period = value;
      }
   }

   
   [JsonIgnore]
   public bool NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public String NUTargetEntityID {
      get {
         return _targetEntityID;
      }
      set {
         this._targetEntityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUTargetPolicyGroupID {
      get {
         return _targetPolicyGroupID;
      }
      set {
         this._targetPolicyGroupID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUThreshold {
      get {
         return _threshold;
      }
      set {
         this._threshold = value;
      }
   }

   
   [JsonIgnore]
   public long? NUThrottleTime {
      get {
         return _throttleTime;
      }
      set {
         this._throttleTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTriggerInterval {
      get {
         return _triggerInterval;
      }
      set {
         this._triggerInterval = value;
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

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
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
      return "TCA [" + "URLEndPoint=" + _URLEndPoint + ", action=" + _action + ", count=" + _count + ", creationDate=" + _creationDate + ", description=" + _description + ", disable=" + _disable + ", displayStatus=" + _displayStatus + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", metric=" + _metric + ", name=" + _name + ", owner=" + _owner + ", period=" + _period + ", status=" + _status + ", targetEntityID=" + _targetEntityID + ", targetPolicyGroupID=" + _targetPolicyGroupID + ", threshold=" + _threshold + ", throttleTime=" + _throttleTime + ", triggerInterval=" + _triggerInterval + ", type=" + _type + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "tcas";
   }

   public static String getRestName()
   {
	return "tca";
   }
}
}