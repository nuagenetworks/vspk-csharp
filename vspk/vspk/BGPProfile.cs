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

public class BGPProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("associatedExportRoutingPolicyID")]
   protected String _associatedExportRoutingPolicyID;
   
   [JsonProperty("associatedImportRoutingPolicyID")]
   protected String _associatedImportRoutingPolicyID;
   
   [JsonProperty("dampeningHalfLife")]
   protected long? _dampeningHalfLife;
   
   [JsonProperty("dampeningMaxSuppress")]
   protected long? _dampeningMaxSuppress;
   
   [JsonProperty("dampeningName")]
   protected String _dampeningName;
   
   [JsonProperty("dampeningReuse")]
   protected long? _dampeningReuse;
   
   [JsonProperty("dampeningSuppress")]
   protected long? _dampeningSuppress;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("name")]
   protected String _name;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public BGPProfile() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedExportRoutingPolicyID {
      get {
         return _associatedExportRoutingPolicyID;
      }
      set {
         this._associatedExportRoutingPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedImportRoutingPolicyID {
      get {
         return _associatedImportRoutingPolicyID;
      }
      set {
         this._associatedImportRoutingPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDampeningHalfLife {
      get {
         return _dampeningHalfLife;
      }
      set {
         this._dampeningHalfLife = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDampeningMaxSuppress {
      get {
         return _dampeningMaxSuppress;
      }
      set {
         this._dampeningMaxSuppress = value;
      }
   }

   
   [JsonIgnore]
   public String NUDampeningName {
      get {
         return _dampeningName;
      }
      set {
         this._dampeningName = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDampeningReuse {
      get {
         return _dampeningReuse;
      }
      set {
         this._dampeningReuse = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDampeningSuppress {
      get {
         return _dampeningSuppress;
      }
      set {
         this._dampeningSuppress = value;
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
   public System.Collections.Generic.List<Metadata> NUEmbeddedMetadata {
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "BGPProfile [" + "associatedExportRoutingPolicyID=" + _associatedExportRoutingPolicyID + ", associatedImportRoutingPolicyID=" + _associatedImportRoutingPolicyID + ", dampeningHalfLife=" + _dampeningHalfLife + ", dampeningMaxSuppress=" + _dampeningMaxSuppress + ", dampeningName=" + _dampeningName + ", dampeningReuse=" + _dampeningReuse + ", dampeningSuppress=" + _dampeningSuppress + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", name=" + _name + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "bgpprofiles";
   }

   public static String getRestName()
   {
	return "bgpprofile";
   }
}
}