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

public class PerformanceMonitor: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EProbeType {HTTP,IPSEC_AND_VXLAN,ONEWAY };
   public enum EServiceClass {A,B,C,D,E,F,G,H };

   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("holdDownTimer")]
   protected long? _holdDownTimer;
   
   [JsonProperty("interval")]
   protected long? _interval;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("numberOfPackets")]
   protected long? _numberOfPackets;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("payloadSize")]
   protected long? _payloadSize;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("probeType")]
   protected EProbeType? _probeType;
   
   [JsonProperty("readOnly")]
   protected bool _readOnly;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("serviceClass")]
   protected EServiceClass? _serviceClass;
   

   
   [JsonIgnore]
   private ApplicationperformancemanagementsFetcher _applicationperformancemanagements;
   
   [JsonIgnore]
   private TiersFetcher _tiers;
   
   public PerformanceMonitor() {
      
      _applicationperformancemanagements = new ApplicationperformancemanagementsFetcher(this);
      
      _tiers = new TiersFetcher(this);
      
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
   public long? NUHoldDownTimer {
      get {
         return _holdDownTimer;
      }
      set {
         this._holdDownTimer = value;
      }
   }

   
   [JsonIgnore]
   public long? NUInterval {
      get {
         return _interval;
      }
      set {
         this._interval = value;
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
   public long? NUNumberOfPackets {
      get {
         return _numberOfPackets;
      }
      set {
         this._numberOfPackets = value;
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
   public long? NUPayloadSize {
      get {
         return _payloadSize;
      }
      set {
         this._payloadSize = value;
      }
   }

   
   [JsonIgnore]
   public EProbeType? NUProbeType {
      get {
         return _probeType;
      }
      set {
         this._probeType = value;
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
   public EServiceClass? NUServiceClass {
      get {
         return _serviceClass;
      }
      set {
         this._serviceClass = value;
      }
   }

   

   
   public ApplicationperformancemanagementsFetcher getApplicationperformancemanagements() {
      return _applicationperformancemanagements;
   }
   
   public TiersFetcher getTiers() {
      return _tiers;
   }
   

   public String toString() {
      return "PerformanceMonitor [" + "creationDate=" + _creationDate + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", holdDownTimer=" + _holdDownTimer + ", interval=" + _interval + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", numberOfPackets=" + _numberOfPackets + ", owner=" + _owner + ", payloadSize=" + _payloadSize + ", probeType=" + _probeType + ", readOnly=" + _readOnly + ", serviceClass=" + _serviceClass + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "performancemonitors";
   }

   public static String getRestName()
   {
	return "performancemonitor";
   }
}
}