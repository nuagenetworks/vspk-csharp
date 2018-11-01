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

public class VNFThresholdPolicy: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAction {NONE,SHUTOFF };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("CPUThreshold")]
   protected long? _CPUThreshold;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("action")]
   protected EAction? _action;
   
   [JsonProperty("assocEntityType")]
   protected String _assocEntityType;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("memoryThreshold")]
   protected long? _memoryThreshold;
   
   [JsonProperty("minOccurrence")]
   protected long? _minOccurrence;
   
   [JsonProperty("monitInterval")]
   protected long? _monitInterval;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("storageThreshold")]
   protected long? _storageThreshold;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public VNFThresholdPolicy() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUCPUThreshold {
      get {
         return _CPUThreshold;
      }
      set {
         this._CPUThreshold = value;
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
   public String NUAssocEntityType {
      get {
         return _assocEntityType;
      }
      set {
         this._assocEntityType = value;
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
   public long? NUMemoryThreshold {
      get {
         return _memoryThreshold;
      }
      set {
         this._memoryThreshold = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMinOccurrence {
      get {
         return _minOccurrence;
      }
      set {
         this._minOccurrence = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMonitInterval {
      get {
         return _monitInterval;
      }
      set {
         this._monitInterval = value;
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
   public long? NUStorageThreshold {
      get {
         return _storageThreshold;
      }
      set {
         this._storageThreshold = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "VNFThresholdPolicy [" + "CPUThreshold=" + _CPUThreshold + ", action=" + _action + ", assocEntityType=" + _assocEntityType + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", memoryThreshold=" + _memoryThreshold + ", minOccurrence=" + _minOccurrence + ", monitInterval=" + _monitInterval + ", name=" + _name + ", storageThreshold=" + _storageThreshold + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vnfthresholdpolicies";
   }

   public static String getRestName()
   {
	return "vnfthresholdpolicy";
   }
}
}