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

public class WirelessPort: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ECountryCode {AT,AU,BE,BR,CA,CH,CN,CY,CZ,DE,DK,EE,ES,FI,FR,GB,GR,HK,HU,ID,IE,IL,IN,IT,JP,KR,LT,LU,LV,MY,NL,NO,NZ,PH,PL,PT,SE,SG,SI,SK,TH,TW,US,ZA };
   public enum EFrequencyChannel {CH_0,CH_1,CH_10,CH_100,CH_104,CH_108,CH_11,CH_112,CH_116,CH_12,CH_120,CH_124,CH_128,CH_13,CH_132,CH_136,CH_14,CH_140,CH_144,CH_149,CH_153,CH_157,CH_161,CH_165,CH_2,CH_3,CH_36,CH_4,CH_40,CH_44,CH_48,CH_5,CH_52,CH_56,CH_6,CH_60,CH_64,CH_7,CH_8,CH_9 };
   public enum EPortType {ACCESS };
   public enum EWifiFrequencyBand {FREQ_2_4_GHZ,FREQ_5_0_GHZ };
   public enum EWifiMode {WIFI_A,WIFI_A_AC,WIFI_A_N,WIFI_A_N_AC,WIFI_B_G,WIFI_B_G_N };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("countryCode")]
   protected ECountryCode? _countryCode;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("frequencyChannel")]
   protected EFrequencyChannel? _frequencyChannel;
   
   [JsonProperty("genericConfig")]
   protected String _genericConfig;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("physicalName")]
   protected String _physicalName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("portType")]
   protected EPortType? _portType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("wifiFrequencyBand")]
   protected EWifiFrequencyBand? _wifiFrequencyBand;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("wifiMode")]
   protected EWifiMode? _wifiMode;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private SSIDConnectionsFetcher _sSIDConnections;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   public WirelessPort() {
      
      _alarms = new AlarmsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _sSIDConnections = new SSIDConnectionsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
   }

   
   [JsonIgnore]
   public ECountryCode? NUCountryCode {
      get {
         return _countryCode;
      }
      set {
         this._countryCode = value;
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
   public EFrequencyChannel? NUFrequencyChannel {
      get {
         return _frequencyChannel;
      }
      set {
         this._frequencyChannel = value;
      }
   }

   
   [JsonIgnore]
   public String NUGenericConfig {
      get {
         return _genericConfig;
      }
      set {
         this._genericConfig = value;
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
   public String NUPhysicalName {
      get {
         return _physicalName;
      }
      set {
         this._physicalName = value;
      }
   }

   
   [JsonIgnore]
   public EPortType? NUPortType {
      get {
         return _portType;
      }
      set {
         this._portType = value;
      }
   }

   
   [JsonIgnore]
   public EWifiFrequencyBand? NUWifiFrequencyBand {
      get {
         return _wifiFrequencyBand;
      }
      set {
         this._wifiFrequencyBand = value;
      }
   }

   
   [JsonIgnore]
   public EWifiMode? NUWifiMode {
      get {
         return _wifiMode;
      }
      set {
         this._wifiMode = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public SSIDConnectionsFetcher getSSIDConnections() {
      return _sSIDConnections;
   }
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   

   public String toString() {
      return "WirelessPort [" + "countryCode=" + _countryCode + ", description=" + _description + ", frequencyChannel=" + _frequencyChannel + ", genericConfig=" + _genericConfig + ", name=" + _name + ", physicalName=" + _physicalName + ", portType=" + _portType + ", wifiFrequencyBand=" + _wifiFrequencyBand + ", wifiMode=" + _wifiMode + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "wirelessports";
   }

   public static String getRestName()
   {
	return "wirelessport";
   }
}
}