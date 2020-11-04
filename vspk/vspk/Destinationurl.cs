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

public class Destinationurl: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EHTTPMethod {GET,HEAD };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("HTTPMethod")]
   protected EHTTPMethod? _HTTPMethod;
   
   [JsonProperty("URL")]
   protected String _URL;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("downThresholdCount")]
   protected long? _downThresholdCount;
   
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
   
   [JsonProperty("packetCount")]
   protected long? _packetCount;
   
   [JsonProperty("percentageWeight")]
   protected long? _percentageWeight;
   
   [JsonProperty("probeInterval")]
   protected long? _probeInterval;
   
   [JsonProperty("timeout")]
   protected long? _timeout;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public Destinationurl() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EHTTPMethod? NUHTTPMethod {
      get {
         return _HTTPMethod;
      }
      set {
         this._HTTPMethod = value;
      }
   }

   
   [JsonIgnore]
   public String NUURL {
      get {
         return _URL;
      }
      set {
         this._URL = value;
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
   public long? NUDownThresholdCount {
      get {
         return _downThresholdCount;
      }
      set {
         this._downThresholdCount = value;
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
   public long? NUPacketCount {
      get {
         return _packetCount;
      }
      set {
         this._packetCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPercentageWeight {
      get {
         return _percentageWeight;
      }
      set {
         this._percentageWeight = value;
      }
   }

   
   [JsonIgnore]
   public long? NUProbeInterval {
      get {
         return _probeInterval;
      }
      set {
         this._probeInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTimeout {
      get {
         return _timeout;
      }
      set {
         this._timeout = value;
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
   

   public String toString() {
      return "Destinationurl [" + "HTTPMethod=" + _HTTPMethod + ", URL=" + _URL + ", creationDate=" + _creationDate + ", downThresholdCount=" + _downThresholdCount + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", packetCount=" + _packetCount + ", percentageWeight=" + _percentageWeight + ", probeInterval=" + _probeInterval + ", timeout=" + _timeout + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "destinationurls";
   }

   public static String getRestName()
   {
	return "destinationurl";
   }
}
}