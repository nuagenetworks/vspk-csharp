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

public class IngressQOSPolicy: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EQueue1ForwardingClasses {A,B,C,D,E,F,G,H,NONE };
   public enum EQueue2ForwardingClasses {A,B,C,D,E,F,G,H,NONE };
   public enum EQueue3ForwardingClasses {A,B,C,D,E,F,G,H,NONE };
   public enum EQueue4ForwardingClasses {A,B,C,D,E,F,G,H,NONE };

   
   [JsonProperty("assocEgressQosId")]
   protected String _assocEgressQosId;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("parentQueueAssociatedRateLimiterID")]
   protected String _parentQueueAssociatedRateLimiterID;
   
   [JsonProperty("queue1AssociatedRateLimiterID")]
   protected String _queue1AssociatedRateLimiterID;
   
   [JsonProperty("queue1ForwardingClasses")]
   protected System.Collections.Generic.List<EQueue1ForwardingClasses> _queue1ForwardingClasses;
   
   [JsonProperty("queue2AssociatedRateLimiterID")]
   protected String _queue2AssociatedRateLimiterID;
   
   [JsonProperty("queue2ForwardingClasses")]
   protected System.Collections.Generic.List<EQueue2ForwardingClasses> _queue2ForwardingClasses;
   
   [JsonProperty("queue3AssociatedRateLimiterID")]
   protected String _queue3AssociatedRateLimiterID;
   
   [JsonProperty("queue3ForwardingClasses")]
   protected System.Collections.Generic.List<EQueue3ForwardingClasses> _queue3ForwardingClasses;
   
   [JsonProperty("queue4AssociatedRateLimiterID")]
   protected String _queue4AssociatedRateLimiterID;
   
   [JsonProperty("queue4ForwardingClasses")]
   protected System.Collections.Generic.List<EQueue4ForwardingClasses> _queue4ForwardingClasses;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public IngressQOSPolicy() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssocEgressQosId {
      get {
         return _assocEgressQosId;
      }
      set {
         this._assocEgressQosId = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public String NUParentQueueAssociatedRateLimiterID {
      get {
         return _parentQueueAssociatedRateLimiterID;
      }
      set {
         this._parentQueueAssociatedRateLimiterID = value;
      }
   }

   
   [JsonIgnore]
   public String NUQueue1AssociatedRateLimiterID {
      get {
         return _queue1AssociatedRateLimiterID;
      }
      set {
         this._queue1AssociatedRateLimiterID = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EQueue1ForwardingClasses> NUQueue1ForwardingClasses {
      get {
         return _queue1ForwardingClasses;
      }
      set {
         this._queue1ForwardingClasses = value;
      }
   }

   
   [JsonIgnore]
   public String NUQueue2AssociatedRateLimiterID {
      get {
         return _queue2AssociatedRateLimiterID;
      }
      set {
         this._queue2AssociatedRateLimiterID = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EQueue2ForwardingClasses> NUQueue2ForwardingClasses {
      get {
         return _queue2ForwardingClasses;
      }
      set {
         this._queue2ForwardingClasses = value;
      }
   }

   
   [JsonIgnore]
   public String NUQueue3AssociatedRateLimiterID {
      get {
         return _queue3AssociatedRateLimiterID;
      }
      set {
         this._queue3AssociatedRateLimiterID = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EQueue3ForwardingClasses> NUQueue3ForwardingClasses {
      get {
         return _queue3ForwardingClasses;
      }
      set {
         this._queue3ForwardingClasses = value;
      }
   }

   
   [JsonIgnore]
   public String NUQueue4AssociatedRateLimiterID {
      get {
         return _queue4AssociatedRateLimiterID;
      }
      set {
         this._queue4AssociatedRateLimiterID = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EQueue4ForwardingClasses> NUQueue4ForwardingClasses {
      get {
         return _queue4ForwardingClasses;
      }
      set {
         this._queue4ForwardingClasses = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "IngressQOSPolicy [" + "assocEgressQosId=" + _assocEgressQosId + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", parentQueueAssociatedRateLimiterID=" + _parentQueueAssociatedRateLimiterID + ", queue1AssociatedRateLimiterID=" + _queue1AssociatedRateLimiterID + ", queue1ForwardingClasses=" + _queue1ForwardingClasses + ", queue2AssociatedRateLimiterID=" + _queue2AssociatedRateLimiterID + ", queue2ForwardingClasses=" + _queue2ForwardingClasses + ", queue3AssociatedRateLimiterID=" + _queue3AssociatedRateLimiterID + ", queue3ForwardingClasses=" + _queue3ForwardingClasses + ", queue4AssociatedRateLimiterID=" + _queue4AssociatedRateLimiterID + ", queue4ForwardingClasses=" + _queue4ForwardingClasses + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ingressqospolicies";
   }

   public static String getRestName()
   {
	return "ingressqospolicy";
   }
}
}