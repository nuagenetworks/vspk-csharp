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

public class AggregateMetadata: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("assocEntityType")]
   protected String _assocEntityType;
   
   [JsonProperty("blob")]
   protected String _blob;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("global")]
   protected bool _globalMetadata;
   
   [JsonProperty("metadataTagIDs")]
   protected System.Collections.Generic.List<String> _metadataTagIDs;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("networkNotificationDisabled")]
   protected bool _networkNotificationDisabled;
   

   
   public AggregateMetadata() {
      
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
   public String NUBlob {
      get {
         return _blob;
      }
      set {
         this._blob = value;
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
   public bool NUGlobalMetadata {
      get {
         return _globalMetadata;
      }
      set {
         this._globalMetadata = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUMetadataTagIDs {
      get {
         return _metadataTagIDs;
      }
      set {
         this._metadataTagIDs = value;
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
   public bool NUNetworkNotificationDisabled {
      get {
         return _networkNotificationDisabled;
      }
      set {
         this._networkNotificationDisabled = value;
      }
   }

   

   

   public String toString() {
      return "AggregateMetadata [" + "assocEntityType=" + _assocEntityType + ", blob=" + _blob + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", globalMetadata=" + _globalMetadata + ", metadataTagIDs=" + _metadataTagIDs + ", name=" + _name + ", networkNotificationDisabled=" + _networkNotificationDisabled + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "aggregatemetadatas";
   }

   public static String getRestName()
   {
	return "aggregatemetadata";
   }
}
}