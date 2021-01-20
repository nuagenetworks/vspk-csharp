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

public class RedirectionTarget: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDestinationType {OVERLAY_MIRROR_DESTINATION,REDIRECTION_TARGET };
   public enum EEndPointType {L3,NSG_VNF,VIRTUAL_WIRE };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ETriggerType {GARP,NONE };

   
   [JsonProperty("ESI")]
   protected String _ESI;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("destinationType")]
   protected EDestinationType? _destinationType;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("endPointType")]
   protected EEndPointType? _endPointType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("redundancyEnabled")]
   protected bool _redundancyEnabled;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("triggerType")]
   protected ETriggerType? _triggerType;
   
   [JsonProperty("virtualNetworkID")]
   protected String _virtualNetworkID;
   

   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private VirtualIPsFetcher _virtualIPs;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   public RedirectionTarget() {
      _endPointType = EEndPointType.L3;
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _virtualIPs = new VirtualIPsFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUESI {
      get {
         return _ESI;
      }
      set {
         this._ESI = value;
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
   public EDestinationType? NUDestinationType {
      get {
         return _destinationType;
      }
      set {
         this._destinationType = value;
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
   public EEndPointType? NUEndPointType {
      get {
         return _endPointType;
      }
      set {
         this._endPointType = value;
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
   public bool NURedundancyEnabled {
      get {
         return _redundancyEnabled;
      }
      set {
         this._redundancyEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUTemplateID {
      get {
         return _templateID;
      }
      set {
         this._templateID = value;
      }
   }

   
   [JsonIgnore]
   public ETriggerType? NUTriggerType {
      get {
         return _triggerType;
      }
      set {
         this._triggerType = value;
      }
   }

   
   [JsonIgnore]
   public String NUVirtualNetworkID {
      get {
         return _virtualNetworkID;
      }
      set {
         this._virtualNetworkID = value;
      }
   }

   

   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public VirtualIPsFetcher getVirtualIPs() {
      return _virtualIPs;
   }
   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   

   public String toString() {
      return "RedirectionTarget [" + "ESI=" + _ESI + ", description=" + _description + ", destinationType=" + _destinationType + ", embeddedMetadata=" + _embeddedMetadata + ", endPointType=" + _endPointType + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", redundancyEnabled=" + _redundancyEnabled + ", templateID=" + _templateID + ", triggerType=" + _triggerType + ", virtualNetworkID=" + _virtualNetworkID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "redirectiontargets";
   }

   public static String getRestName()
   {
	return "redirectiontarget";
   }
}
}