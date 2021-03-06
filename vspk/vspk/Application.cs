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

public class Application: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EOptimizePathSelection {JITTER,LATENCY,PACKETLOSS };
   public enum EPerformanceMonitorType {CONTINUOUS,FIRST_PACKET,FIRST_PACKET_AND_CONTINUOUS };
   public enum EPostClassificationPath {ANY,PRIMARY,SECONDARY };
   public enum EPreClassificationPath {DEFAULT,PRIMARY,SECONDARY };
   public enum EProtocol {NONE,TCP,UDP };

   
   [JsonProperty("DSCP")]
   protected String _DSCP;
   
   [JsonProperty("appId")]
   protected long? _appId;
   
   [JsonProperty("associatedL7ApplicationSignatureID")]
   protected String _associatedL7ApplicationSignatureID;
   
   [JsonProperty("bandwidth")]
   protected long? _bandwidth;
   
   [JsonProperty("certificateCommonName")]
   protected String _certificateCommonName;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("destinationIP")]
   protected String _destinationIP;
   
   [JsonProperty("destinationPort")]
   protected String _destinationPort;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enablePPS")]
   protected bool _enablePPS;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("etherType")]
   protected String _etherType;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("networkSymmetry")]
   protected bool _networkSymmetry;
   
   [JsonProperty("oneWayDelay")]
   protected long? _oneWayDelay;
   
   [JsonProperty("oneWayJitter")]
   protected long? _oneWayJitter;
   
   [JsonProperty("oneWayLoss")]
   protected float _oneWayLoss;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("optimizePathSelection")]
   protected EOptimizePathSelection? _optimizePathSelection;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("performanceMonitorType")]
   protected EPerformanceMonitorType? _performanceMonitorType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("postClassificationPath")]
   protected EPostClassificationPath? _postClassificationPath;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("preClassificationPath")]
   protected EPreClassificationPath? _preClassificationPath;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("protocol")]
   protected EProtocol? _protocol;
   
   [JsonProperty("readOnly")]
   protected bool _readOnly;
   
   [JsonProperty("sourceIP")]
   protected String _sourceIP;
   
   [JsonProperty("sourcePort")]
   protected String _sourcePort;
   
   [JsonProperty("symmetry")]
   protected bool _symmetry;
   

   
   [JsonIgnore]
   private ApplicationBindingsFetcher _applicationBindings;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private MonitorscopesFetcher _monitorscopes;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public Application() {
      
      _applicationBindings = new ApplicationBindingsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _monitorscopes = new MonitorscopesFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUDSCP {
      get {
         return _DSCP;
      }
      set {
         this._DSCP = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAppId {
      get {
         return _appId;
      }
      set {
         this._appId = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedL7ApplicationSignatureID {
      get {
         return _associatedL7ApplicationSignatureID;
      }
      set {
         this._associatedL7ApplicationSignatureID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUBandwidth {
      get {
         return _bandwidth;
      }
      set {
         this._bandwidth = value;
      }
   }

   
   [JsonIgnore]
   public String NUCertificateCommonName {
      get {
         return _certificateCommonName;
      }
      set {
         this._certificateCommonName = value;
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
   public String NUDestinationIP {
      get {
         return _destinationIP;
      }
      set {
         this._destinationIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUDestinationPort {
      get {
         return _destinationPort;
      }
      set {
         this._destinationPort = value;
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
   public bool NUEnablePPS {
      get {
         return _enablePPS;
      }
      set {
         this._enablePPS = value;
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
   public String NUEtherType {
      get {
         return _etherType;
      }
      set {
         this._etherType = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public bool NUNetworkSymmetry {
      get {
         return _networkSymmetry;
      }
      set {
         this._networkSymmetry = value;
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
   public long? NUOneWayJitter {
      get {
         return _oneWayJitter;
      }
      set {
         this._oneWayJitter = value;
      }
   }

   
   [JsonIgnore]
   public float NUOneWayLoss {
      get {
         return _oneWayLoss;
      }
      set {
         this._oneWayLoss = value;
      }
   }

   
   [JsonIgnore]
   public EOptimizePathSelection? NUOptimizePathSelection {
      get {
         return _optimizePathSelection;
      }
      set {
         this._optimizePathSelection = value;
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
   public EPerformanceMonitorType? NUPerformanceMonitorType {
      get {
         return _performanceMonitorType;
      }
      set {
         this._performanceMonitorType = value;
      }
   }

   
   [JsonIgnore]
   public EPostClassificationPath? NUPostClassificationPath {
      get {
         return _postClassificationPath;
      }
      set {
         this._postClassificationPath = value;
      }
   }

   
   [JsonIgnore]
   public EPreClassificationPath? NUPreClassificationPath {
      get {
         return _preClassificationPath;
      }
      set {
         this._preClassificationPath = value;
      }
   }

   
   [JsonIgnore]
   public EProtocol? NUProtocol {
      get {
         return _protocol;
      }
      set {
         this._protocol = value;
      }
   }

   
   [JsonIgnore]
   public bool NUReadOnly {
      get {
         return _readOnly;
      }
      set {
         this._readOnly = value;
      }
   }

   
   [JsonIgnore]
   public String NUSourceIP {
      get {
         return _sourceIP;
      }
      set {
         this._sourceIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUSourcePort {
      get {
         return _sourcePort;
      }
      set {
         this._sourcePort = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSymmetry {
      get {
         return _symmetry;
      }
      set {
         this._symmetry = value;
      }
   }

   

   
   public ApplicationBindingsFetcher getApplicationBindings() {
      return _applicationBindings;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public MonitorscopesFetcher getMonitorscopes() {
      return _monitorscopes;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   

   public String toString() {
      return "Application [" + "DSCP=" + _DSCP + ", appId=" + _appId + ", associatedL7ApplicationSignatureID=" + _associatedL7ApplicationSignatureID + ", bandwidth=" + _bandwidth + ", certificateCommonName=" + _certificateCommonName + ", creationDate=" + _creationDate + ", description=" + _description + ", destinationIP=" + _destinationIP + ", destinationPort=" + _destinationPort + ", embeddedMetadata=" + _embeddedMetadata + ", enablePPS=" + _enablePPS + ", entityScope=" + _entityScope + ", etherType=" + _etherType + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", networkSymmetry=" + _networkSymmetry + ", oneWayDelay=" + _oneWayDelay + ", oneWayJitter=" + _oneWayJitter + ", oneWayLoss=" + _oneWayLoss + ", optimizePathSelection=" + _optimizePathSelection + ", owner=" + _owner + ", performanceMonitorType=" + _performanceMonitorType + ", postClassificationPath=" + _postClassificationPath + ", preClassificationPath=" + _preClassificationPath + ", protocol=" + _protocol + ", readOnly=" + _readOnly + ", sourceIP=" + _sourceIP + ", sourcePort=" + _sourcePort + ", symmetry=" + _symmetry + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "applications";
   }

   public static String getRestName()
   {
	return "application";
   }
}
}