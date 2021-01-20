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

public class VPortMirror: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EMirrorDirection {BOTH,EGRESS,INGRESS };

   
   [JsonProperty("attachedNetworkType")]
   protected String _attachedNetworkType;
   
   [JsonProperty("domainName")]
   protected String _domainName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterpiseName")]
   protected String _enterpiseName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("mirrorDestinationID")]
   protected String _mirrorDestinationID;
   
   [JsonProperty("mirrorDestinationName")]
   protected String _mirrorDestinationName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("mirrorDirection")]
   protected EMirrorDirection? _mirrorDirection;
   
   [JsonProperty("networkName")]
   protected String _networkName;
   
   [JsonProperty("vportId")]
   protected String _vportId;
   
   [JsonProperty("vportName")]
   protected String _vportName;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public VPortMirror() {
      _mirrorDirection = EMirrorDirection.BOTH;
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAttachedNetworkType {
      get {
         return _attachedNetworkType;
      }
      set {
         this._attachedNetworkType = value;
      }
   }

   
   [JsonIgnore]
   public String NUDomainName {
      get {
         return _domainName;
      }
      set {
         this._domainName = value;
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
   public String NUEnterpiseName {
      get {
         return _enterpiseName;
      }
      set {
         this._enterpiseName = value;
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
   public String NUMirrorDestinationID {
      get {
         return _mirrorDestinationID;
      }
      set {
         this._mirrorDestinationID = value;
      }
   }

   
   [JsonIgnore]
   public String NUMirrorDestinationName {
      get {
         return _mirrorDestinationName;
      }
      set {
         this._mirrorDestinationName = value;
      }
   }

   
   [JsonIgnore]
   public EMirrorDirection? NUMirrorDirection {
      get {
         return _mirrorDirection;
      }
      set {
         this._mirrorDirection = value;
      }
   }

   
   [JsonIgnore]
   public String NUNetworkName {
      get {
         return _networkName;
      }
      set {
         this._networkName = value;
      }
   }

   
   [JsonIgnore]
   public String NUVportId {
      get {
         return _vportId;
      }
      set {
         this._vportId = value;
      }
   }

   
   [JsonIgnore]
   public String NUVportName {
      get {
         return _vportName;
      }
      set {
         this._vportName = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "VPortMirror [" + "attachedNetworkType=" + _attachedNetworkType + ", domainName=" + _domainName + ", embeddedMetadata=" + _embeddedMetadata + ", enterpiseName=" + _enterpiseName + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", mirrorDestinationID=" + _mirrorDestinationID + ", mirrorDestinationName=" + _mirrorDestinationName + ", mirrorDirection=" + _mirrorDirection + ", networkName=" + _networkName + ", vportId=" + _vportId + ", vportName=" + _vportName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vportmirrors";
   }

   public static String getRestName()
   {
	return "vportmirror";
   }
}
}