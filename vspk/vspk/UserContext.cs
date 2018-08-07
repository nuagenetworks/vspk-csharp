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

public class UserContext: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("AARFlowStatsInterval")]
   protected long? _AARFlowStatsInterval;
   
   [JsonProperty("AARProbeStatsInterval")]
   protected long? _AARProbeStatsInterval;
   
   [JsonProperty("VSSFeatureEnabled")]
   protected bool _VSSFeatureEnabled;
   
   [JsonProperty("VSSStatsInterval")]
   protected long? _VSSStatsInterval;
   
   [JsonProperty("flowCollectionEnabled")]
   protected bool _flowCollectionEnabled;
   
   [JsonProperty("googleMapsAPIKey")]
   protected String _googleMapsAPIKey;
   
   [JsonProperty("pageSize")]
   protected String _pageSize;
   
   [JsonProperty("statisticsEnabled")]
   protected bool _statisticsEnabled;
   
   [JsonProperty("statsTSDBServerAddress")]
   protected String _statsTSDBServerAddress;
   

   
   public UserContext() {
      
   }

   
   [JsonIgnore]
   public long? NUAARFlowStatsInterval {
      get {
         return _AARFlowStatsInterval;
      }
      set {
         this._AARFlowStatsInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAARProbeStatsInterval {
      get {
         return _AARProbeStatsInterval;
      }
      set {
         this._AARProbeStatsInterval = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVSSFeatureEnabled {
      get {
         return _VSSFeatureEnabled;
      }
      set {
         this._VSSFeatureEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVSSStatsInterval {
      get {
         return _VSSStatsInterval;
      }
      set {
         this._VSSStatsInterval = value;
      }
   }

   
   [JsonIgnore]
   public bool NUFlowCollectionEnabled {
      get {
         return _flowCollectionEnabled;
      }
      set {
         this._flowCollectionEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUGoogleMapsAPIKey {
      get {
         return _googleMapsAPIKey;
      }
      set {
         this._googleMapsAPIKey = value;
      }
   }

   
   [JsonIgnore]
   public String NUPageSize {
      get {
         return _pageSize;
      }
      set {
         this._pageSize = value;
      }
   }

   
   [JsonIgnore]
   public bool NUStatisticsEnabled {
      get {
         return _statisticsEnabled;
      }
      set {
         this._statisticsEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUStatsTSDBServerAddress {
      get {
         return _statsTSDBServerAddress;
      }
      set {
         this._statsTSDBServerAddress = value;
      }
   }

   

   

   public String toString() {
      return "UserContext [" + "AARFlowStatsInterval=" + _AARFlowStatsInterval + ", AARProbeStatsInterval=" + _AARProbeStatsInterval + ", VSSFeatureEnabled=" + _VSSFeatureEnabled + ", VSSStatsInterval=" + _VSSStatsInterval + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", googleMapsAPIKey=" + _googleMapsAPIKey + ", pageSize=" + _pageSize + ", statisticsEnabled=" + _statisticsEnabled + ", statsTSDBServerAddress=" + _statsTSDBServerAddress + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "usercontexts";
   }

   public static String getRestName()
   {
	return "usercontext";
   }
}
}