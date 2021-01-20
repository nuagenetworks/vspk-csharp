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

public class EventLog: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("diff")]
   protected Object _diff;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterprise")]
   protected String _enterprise;
   
   [JsonProperty("entities")]
   protected System.Collections.Generic.List<JObject> _entities;
   
   [JsonProperty("entityID")]
   protected String _entityID;
   
   [JsonProperty("entityParentID")]
   protected String _entityParentID;
   
   [JsonProperty("entityParentType")]
   protected String _entityParentType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("entityType")]
   protected String _entityType;
   
   [JsonProperty("eventReceivedTime")]
   protected long? _eventReceivedTime;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("requestID")]
   protected String _requestID;
   
   [JsonProperty("type")]
   protected String _type;
   
   [JsonProperty("user")]
   protected String _user;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public EventLog() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public Object NUDiff {
      get {
         return _diff;
      }
      set {
         this._diff = value;
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
   public String NUEnterprise {
      get {
         return _enterprise;
      }
      set {
         this._enterprise = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<JObject> NUEntities {
      get {
         return _entities;
      }
      set {
         this._entities = value;
      }
   }

   
   [JsonIgnore]
   public String NUEntityID {
      get {
         return _entityID;
      }
      set {
         this._entityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUEntityParentID {
      get {
         return _entityParentID;
      }
      set {
         this._entityParentID = value;
      }
   }

   
   [JsonIgnore]
   public String NUEntityParentType {
      get {
         return _entityParentType;
      }
      set {
         this._entityParentType = value;
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
   public String NUEntityType {
      get {
         return _entityType;
      }
      set {
         this._entityType = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEventReceivedTime {
      get {
         return _eventReceivedTime;
      }
      set {
         this._eventReceivedTime = value;
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
   public String NURequestID {
      get {
         return _requestID;
      }
      set {
         this._requestID = value;
      }
   }

   
   [JsonIgnore]
   public String NUType {
      get {
         return _type;
      }
      set {
         this._type = value;
      }
   }

   
   [JsonIgnore]
   public String NUUser {
      get {
         return _user;
      }
      set {
         this._user = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "EventLog [" + "diff=" + _diff + ", embeddedMetadata=" + _embeddedMetadata + ", enterprise=" + _enterprise + ", entities=" + _entities + ", entityID=" + _entityID + ", entityParentID=" + _entityParentID + ", entityParentType=" + _entityParentType + ", entityScope=" + _entityScope + ", entityType=" + _entityType + ", eventReceivedTime=" + _eventReceivedTime + ", externalID=" + _externalID + ", requestID=" + _requestID + ", type=" + _type + ", user=" + _user + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "eventlogs";
   }

   public static String getRestName()
   {
	return "eventlog";
   }
}
}