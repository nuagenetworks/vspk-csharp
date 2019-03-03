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

public class DUCGroupBinding: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAssociatedUBRGroupFunction {GATEWAY,UBR };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("associatedDUCGroupID")]
   protected String _associatedDUCGroupID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedUBRGroupFunction")]
   protected EAssociatedUBRGroupFunction? _associatedUBRGroupFunction;
   
   [JsonProperty("associatedUBRGroupName")]
   protected String _associatedUBRGroupName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("oneWayDelay")]
   protected long? _oneWayDelay;
   
   [JsonProperty("priority")]
   protected long? _priority;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public DUCGroupBinding() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedDUCGroupID {
      get {
         return _associatedDUCGroupID;
      }
      set {
         this._associatedDUCGroupID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedUBRGroupFunction? NUAssociatedUBRGroupFunction {
      get {
         return _associatedUBRGroupFunction;
      }
      set {
         this._associatedUBRGroupFunction = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUBRGroupName {
      get {
         return _associatedUBRGroupName;
      }
      set {
         this._associatedUBRGroupName = value;
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
   public long? NUOneWayDelay {
      get {
         return _oneWayDelay;
      }
      set {
         this._oneWayDelay = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPriority {
      get {
         return _priority;
      }
      set {
         this._priority = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "DUCGroupBinding [" + "associatedDUCGroupID=" + _associatedDUCGroupID + ", associatedUBRGroupFunction=" + _associatedUBRGroupFunction + ", associatedUBRGroupName=" + _associatedUBRGroupName + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", oneWayDelay=" + _oneWayDelay + ", priority=" + _priority + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ducgroupbindings";
   }

   public static String getRestName()
   {
	return "ducgroupbinding";
   }
}
}