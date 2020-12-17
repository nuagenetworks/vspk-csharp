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

public class WirelessPort: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EChannelWidth {WIDTH_20_MHZ,WIDTH_40_MHZ,WIDTH_80_MHZ,WIDTH_LESS_40_MHZ,WIDTH_PLUS_40_MHZ };
   public enum ECountryCode {AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IN,IO,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,ME,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RS,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TL,TM,TN,TO,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,ZA,ZM,ZW };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFrequencyChannel {CH_0,CH_1,CH_10,CH_100,CH_104,CH_108,CH_11,CH_112,CH_116,CH_12,CH_120,CH_124,CH_128,CH_13,CH_132,CH_136,CH_14,CH_140,CH_144,CH_149,CH_153,CH_157,CH_161,CH_165,CH_2,CH_3,CH_36,CH_4,CH_40,CH_44,CH_48,CH_5,CH_52,CH_56,CH_6,CH_60,CH_64,CH_7,CH_8,CH_9 };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EPortType {ACCESS };
   public enum EStatus {INITIALIZED,MISMATCH,ORPHAN,READY };
   public enum EWifiFrequencyBand {FREQ_2_4_GHZ,FREQ_5_0_GHZ };
   public enum EWifiMode {WIFI_A,WIFI_A_AC,WIFI_A_N,WIFI_A_N_AC,WIFI_B_G,WIFI_B_G_N };

   
   [JsonProperty("VLANRange")]
   protected String _VLANRange;
   
   [JsonProperty("associatedEgressQOSPolicyID")]
   protected String _associatedEgressQOSPolicyID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("channelWidth")]
   protected EChannelWidth? _channelWidth;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("countryCode")]
   protected ECountryCode? _countryCode;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("frequencyChannel")]
   protected EFrequencyChannel? _frequencyChannel;
   
   [JsonProperty("genericConfig")]
   protected String _genericConfig;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("physicalName")]
   protected String _physicalName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("portType")]
   protected EPortType? _portType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("useUserMnemonic")]
   protected bool _useUserMnemonic;
   
   [JsonProperty("userMnemonic")]
   protected String _userMnemonic;
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
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private SSIDConnectionsFetcher _sSIDConnections;
   
   public WirelessPort() {
      
      _alarms = new AlarmsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _sSIDConnections = new SSIDConnectionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUVLANRange {
      get {
         return _VLANRange;
      }
      set {
         this._VLANRange = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEgressQOSPolicyID {
      get {
         return _associatedEgressQOSPolicyID;
      }
      set {
         this._associatedEgressQOSPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public EChannelWidth? NUChannelWidth {
      get {
         return _channelWidth;
      }
      set {
         this._channelWidth = value;
      }
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
   public String NUExternalID {
      get {
         return _externalID;
      }
      set {
         this._externalID = value;
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
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
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
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUseUserMnemonic {
      get {
         return _useUserMnemonic;
      }
      set {
         this._useUserMnemonic = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserMnemonic {
      get {
         return _userMnemonic;
      }
      set {
         this._userMnemonic = value;
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
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public SSIDConnectionsFetcher getSSIDConnections() {
      return _sSIDConnections;
   }
   

   public String toString() {
      return "WirelessPort [" + "VLANRange=" + _VLANRange + ", associatedEgressQOSPolicyID=" + _associatedEgressQOSPolicyID + ", channelWidth=" + _channelWidth + ", countryCode=" + _countryCode + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", frequencyChannel=" + _frequencyChannel + ", genericConfig=" + _genericConfig + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", permittedAction=" + _permittedAction + ", physicalName=" + _physicalName + ", portType=" + _portType + ", status=" + _status + ", useUserMnemonic=" + _useUserMnemonic + ", userMnemonic=" + _userMnemonic + ", wifiFrequencyBand=" + _wifiFrequencyBand + ", wifiMode=" + _wifiMode + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
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