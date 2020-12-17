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

public class OSPFInstance: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIPType {IPV4 };
   public enum EOSPFType {OSPFv2,OSPFv3 };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("OSPFType")]
   protected EOSPFType? _OSPFType;
   
   [JsonProperty("associatedExportRoutingPolicyID")]
   protected String _associatedExportRoutingPolicyID;
   
   [JsonProperty("associatedImportRoutingPolicyID")]
   protected String _associatedImportRoutingPolicyID;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("exportLimit")]
   protected long? _exportLimit;
   
   [JsonProperty("exportToOverlay")]
   protected bool _exportToOverlay;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("externalPreference")]
   protected long? _externalPreference;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("preference")]
   protected long? _preference;
   
   [JsonProperty("superBackboneEnabled")]
   protected bool _superBackboneEnabled;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private OSPFAreasFetcher _oSPFAreas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public OSPFInstance() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _oSPFAreas = new OSPFAreasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EIPType? NUIPType {
      get {
         return _IPType;
      }
      set {
         this._IPType = value;
      }
   }

   
   [JsonIgnore]
   public EOSPFType? NUOSPFType {
      get {
         return _OSPFType;
      }
      set {
         this._OSPFType = value;
      }
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
   public long? NUExportLimit {
      get {
         return _exportLimit;
      }
      set {
         this._exportLimit = value;
      }
   }

   
   [JsonIgnore]
   public bool NUExportToOverlay {
      get {
         return _exportToOverlay;
      }
      set {
         this._exportToOverlay = value;
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
   public long? NUExternalPreference {
      get {
         return _externalPreference;
      }
      set {
         this._externalPreference = value;
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
   public long? NUPreference {
      get {
         return _preference;
      }
      set {
         this._preference = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSuperBackboneEnabled {
      get {
         return _superBackboneEnabled;
      }
      set {
         this._superBackboneEnabled = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public OSPFAreasFetcher getOSPFAreas() {
      return _oSPFAreas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "OSPFInstance [" + "IPType=" + _IPType + ", OSPFType=" + _OSPFType + ", associatedExportRoutingPolicyID=" + _associatedExportRoutingPolicyID + ", associatedImportRoutingPolicyID=" + _associatedImportRoutingPolicyID + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", exportLimit=" + _exportLimit + ", exportToOverlay=" + _exportToOverlay + ", externalID=" + _externalID + ", externalPreference=" + _externalPreference + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", preference=" + _preference + ", superBackboneEnabled=" + _superBackboneEnabled + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ospfinstances";
   }

   public static String getRestName()
   {
	return "ospfinstance";
   }
}
}