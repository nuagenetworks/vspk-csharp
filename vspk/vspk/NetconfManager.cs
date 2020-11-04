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

public class NetconfManager: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EStatus {CONNECTED,DISCONNECTED,INIT,JMS_DISCONNECTED };

   
   [JsonProperty("assocEntityType")]
   protected String _assocEntityType;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("eventProcessingEnabled")]
   protected bool _eventProcessingEnabled;
   
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
   
   [JsonProperty("release")]
   protected String _release;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private GNMISessionsFetcher _gNMISessions;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NetconfSessionsFetcher _netconfSessions;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public NetconfManager() {
      
      _alarms = new AlarmsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _gNMISessions = new GNMISessionsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _netconfSessions = new NetconfSessionsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssocEntityType {
      get {
         return _assocEntityType;
      }
      set {
         this._assocEntityType = value;
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
   public bool NUEventProcessingEnabled {
      get {
         return _eventProcessingEnabled;
      }
      set {
         this._eventProcessingEnabled = value;
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
   public String NURelease {
      get {
         return _release;
      }
      set {
         this._release = value;
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

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public GNMISessionsFetcher getGNMISessions() {
      return _gNMISessions;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public NetconfSessionsFetcher getNetconfSessions() {
      return _netconfSessions;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "NetconfManager [" + "assocEntityType=" + _assocEntityType + ", creationDate=" + _creationDate + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", eventProcessingEnabled=" + _eventProcessingEnabled + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", release=" + _release + ", status=" + _status + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "netconfmanagers";
   }

   public static String getRestName()
   {
	return "netconfmanager";
   }
}
}