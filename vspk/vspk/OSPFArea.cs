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

public class OSPFArea: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAreaType {NORMAL,NSSA,STUB };
   public enum EDefaultOriginateOption {NONE,TYPE3,TYPE7 };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("aggregateAreaRange")]
   protected System.Collections.Generic.List<String> _aggregateAreaRange;
   
   [JsonProperty("aggregateAreaRangeNSSA")]
   protected System.Collections.Generic.List<String> _aggregateAreaRangeNSSA;
   
   [JsonProperty("areaID")]
   protected long? _areaID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("areaType")]
   protected EAreaType? _areaType;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("defaultMetric")]
   protected long? _defaultMetric;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("defaultOriginateOption")]
   protected EDefaultOriginateOption? _defaultOriginateOption;
   
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
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("redistributeExternalEnabled")]
   protected bool _redistributeExternalEnabled;
   
   [JsonProperty("summariesEnabled")]
   protected bool _summariesEnabled;
   
   [JsonProperty("suppressAreaRange")]
   protected System.Collections.Generic.List<String> _suppressAreaRange;
   
   [JsonProperty("suppressAreaRangeNSSA")]
   protected System.Collections.Generic.List<String> _suppressAreaRangeNSSA;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private OSPFInterfacesFetcher _oSPFInterfaces;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public OSPFArea() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _oSPFInterfaces = new OSPFInterfacesFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUAggregateAreaRange {
      get {
         return _aggregateAreaRange;
      }
      set {
         this._aggregateAreaRange = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUAggregateAreaRangeNSSA {
      get {
         return _aggregateAreaRangeNSSA;
      }
      set {
         this._aggregateAreaRangeNSSA = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAreaID {
      get {
         return _areaID;
      }
      set {
         this._areaID = value;
      }
   }

   
   [JsonIgnore]
   public EAreaType? NUAreaType {
      get {
         return _areaType;
      }
      set {
         this._areaType = value;
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
   public long? NUDefaultMetric {
      get {
         return _defaultMetric;
      }
      set {
         this._defaultMetric = value;
      }
   }

   
   [JsonIgnore]
   public EDefaultOriginateOption? NUDefaultOriginateOption {
      get {
         return _defaultOriginateOption;
      }
      set {
         this._defaultOriginateOption = value;
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
   public String NULastUpdatedDate {
      get {
         return _lastUpdatedDate;
      }
      set {
         this._lastUpdatedDate = value;
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
   public bool NURedistributeExternalEnabled {
      get {
         return _redistributeExternalEnabled;
      }
      set {
         this._redistributeExternalEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSummariesEnabled {
      get {
         return _summariesEnabled;
      }
      set {
         this._summariesEnabled = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUSuppressAreaRange {
      get {
         return _suppressAreaRange;
      }
      set {
         this._suppressAreaRange = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUSuppressAreaRangeNSSA {
      get {
         return _suppressAreaRangeNSSA;
      }
      set {
         this._suppressAreaRangeNSSA = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public OSPFInterfacesFetcher getOSPFInterfaces() {
      return _oSPFInterfaces;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "OSPFArea [" + "aggregateAreaRange=" + _aggregateAreaRange + ", aggregateAreaRangeNSSA=" + _aggregateAreaRangeNSSA + ", areaID=" + _areaID + ", areaType=" + _areaType + ", creationDate=" + _creationDate + ", defaultMetric=" + _defaultMetric + ", defaultOriginateOption=" + _defaultOriginateOption + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", redistributeExternalEnabled=" + _redistributeExternalEnabled + ", summariesEnabled=" + _summariesEnabled + ", suppressAreaRange=" + _suppressAreaRange + ", suppressAreaRangeNSSA=" + _suppressAreaRangeNSSA + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ospfareas";
   }

   public static String getRestName()
   {
	return "ospfarea";
   }
}
}