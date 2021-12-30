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

public class ICMPEchoTestDefinition: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("donotFragment")]
   protected bool _donotFragment;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("packetCount")]
   protected long? _packetCount;
   
   [JsonProperty("packetInterval")]
   protected long? _packetInterval;
   
   [JsonProperty("packetSize")]
   protected long? _packetSize;
   
   [JsonProperty("slaMonitoring")]
   protected bool _slaMonitoring;
   
   [JsonProperty("thresholdAverageRoundTripTime")]
   protected float _thresholdAverageRoundTripTime;
   
   [JsonProperty("thresholdPacketLoss")]
   protected float _thresholdPacketLoss;
   
   [JsonProperty("timeout")]
   protected long? _timeout;
   
   [JsonProperty("tos")]
   protected long? _tos;
   

   
   public ICMPEchoTestDefinition() {
      
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
   public bool NUDonotFragment {
      get {
         return _donotFragment;
      }
      set {
         this._donotFragment = value;
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
   public long? NUPacketCount {
      get {
         return _packetCount;
      }
      set {
         this._packetCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPacketInterval {
      get {
         return _packetInterval;
      }
      set {
         this._packetInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPacketSize {
      get {
         return _packetSize;
      }
      set {
         this._packetSize = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSlaMonitoring {
      get {
         return _slaMonitoring;
      }
      set {
         this._slaMonitoring = value;
      }
   }

   
   [JsonIgnore]
   public float NUThresholdAverageRoundTripTime {
      get {
         return _thresholdAverageRoundTripTime;
      }
      set {
         this._thresholdAverageRoundTripTime = value;
      }
   }

   
   [JsonIgnore]
   public float NUThresholdPacketLoss {
      get {
         return _thresholdPacketLoss;
      }
      set {
         this._thresholdPacketLoss = value;
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

   
   [JsonIgnore]
   public long? NUTos {
      get {
         return _tos;
      }
      set {
         this._tos = value;
      }
   }

   

   

   public String toString() {
      return "ICMPEchoTestDefinition [" + "description=" + _description + ", donotFragment=" + _donotFragment + ", name=" + _name + ", packetCount=" + _packetCount + ", packetInterval=" + _packetInterval + ", packetSize=" + _packetSize + ", slaMonitoring=" + _slaMonitoring + ", thresholdAverageRoundTripTime=" + _thresholdAverageRoundTripTime + ", thresholdPacketLoss=" + _thresholdPacketLoss + ", timeout=" + _timeout + ", tos=" + _tos + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "icmpechotestdefinitions";
   }

   public static String getRestName()
   {
	return "icmpechotestdefinition";
   }
}
}