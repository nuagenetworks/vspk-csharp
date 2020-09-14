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

public class PolicyDecision: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("egressACLs")]
   protected System.Collections.Generic.List<JObject> _egressACLs;
   
   [JsonProperty("egressQos")]
   protected Object _egressQos;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("fipACLs")]
   protected System.Collections.Generic.List<JObject> _fipACLs;
   
   [JsonProperty("ingressACLs")]
   protected System.Collections.Generic.List<JObject> _ingressACLs;
   
   [JsonProperty("ingressAdvFwd")]
   protected System.Collections.Generic.List<JObject> _ingressAdvFwd;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("qos")]
   protected Object _qos;
   
   [JsonProperty("stats")]
   protected StatisticsPolicy _stats;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private QOSsFetcher _qOSs;
   
   public PolicyDecision() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<JObject> NUEgressACLs {
      get {
         return _egressACLs;
      }
      set {
         this._egressACLs = value;
      }
   }

   
   [JsonIgnore]
   public Object NUEgressQos {
      get {
         return _egressQos;
      }
      set {
         this._egressQos = value;
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
   public System.Collections.Generic.List<JObject> NUFipACLs {
      get {
         return _fipACLs;
      }
      set {
         this._fipACLs = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<JObject> NUIngressACLs {
      get {
         return _ingressACLs;
      }
      set {
         this._ingressACLs = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<JObject> NUIngressAdvFwd {
      get {
         return _ingressAdvFwd;
      }
      set {
         this._ingressAdvFwd = value;
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
   public Object NUQos {
      get {
         return _qos;
      }
      set {
         this._qos = value;
      }
   }

   
   [JsonIgnore]
   public StatisticsPolicy NUStats {
      get {
         return _stats;
      }
      set {
         this._stats = value;
      }
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
   
   public QOSsFetcher getQOSs() {
      return _qOSs;
   }
   

   public String toString() {
      return "PolicyDecision [" + "egressACLs=" + _egressACLs + ", egressQos=" + _egressQos + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", fipACLs=" + _fipACLs + ", ingressACLs=" + _ingressACLs + ", ingressAdvFwd=" + _ingressAdvFwd + ", lastUpdatedBy=" + _lastUpdatedBy + ", qos=" + _qos + ", stats=" + _stats + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "policydecisions";
   }

   public static String getRestName()
   {
	return "policydecision";
   }
}
}