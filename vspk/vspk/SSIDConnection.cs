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

public class SSIDConnection: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAuthenticationMode {CAPTIVE_PORTAL,OPEN,WEP,WPA,WPA2,WPA_OTP,WPA_WPA2 };
   public enum ERedirectOption {CONFIGURED_URL,ORIGINAL_REQUEST };

   
   [JsonProperty("associatedCaptivePortalProfileID")]
   protected String _associatedCaptivePortalProfileID;
   
   [JsonProperty("associatedEgressQOSPolicyID")]
   protected String _associatedEgressQOSPolicyID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("authenticationMode")]
   protected EAuthenticationMode? _authenticationMode;
   
   [JsonProperty("blackList")]
   protected System.Collections.Generic.List<String> _blackList;
   
   [JsonProperty("broadcastSSID")]
   protected bool _broadcastSSID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("genericConfig")]
   protected String _genericConfig;
   
   [JsonProperty("interfaceName")]
   protected String _interfaceName;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("passphrase")]
   protected String _passphrase;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("redirectOption")]
   protected ERedirectOption? _redirectOption;
   
   [JsonProperty("redirectURL")]
   protected String _redirectURL;
   
   [JsonProperty("vportID")]
   protected String _vportID;
   
   [JsonProperty("whiteList")]
   protected System.Collections.Generic.List<String> _whiteList;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private CaptivePortalProfilesFetcher _captivePortalProfiles;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   public SSIDConnection() {
      
      _alarms = new AlarmsFetcher(this);
      
      _captivePortalProfiles = new CaptivePortalProfilesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedCaptivePortalProfileID {
      get {
         return _associatedCaptivePortalProfileID;
      }
      set {
         this._associatedCaptivePortalProfileID = value;
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
   public EAuthenticationMode? NUAuthenticationMode {
      get {
         return _authenticationMode;
      }
      set {
         this._authenticationMode = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUBlackList {
      get {
         return _blackList;
      }
      set {
         this._blackList = value;
      }
   }

   
   [JsonIgnore]
   public bool NUBroadcastSSID {
      get {
         return _broadcastSSID;
      }
      set {
         this._broadcastSSID = value;
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
   public String NUGenericConfig {
      get {
         return _genericConfig;
      }
      set {
         this._genericConfig = value;
      }
   }

   
   [JsonIgnore]
   public String NUInterfaceName {
      get {
         return _interfaceName;
      }
      set {
         this._interfaceName = value;
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
   public String NUPassphrase {
      get {
         return _passphrase;
      }
      set {
         this._passphrase = value;
      }
   }

   
   [JsonIgnore]
   public ERedirectOption? NURedirectOption {
      get {
         return _redirectOption;
      }
      set {
         this._redirectOption = value;
      }
   }

   
   [JsonIgnore]
   public String NURedirectURL {
      get {
         return _redirectURL;
      }
      set {
         this._redirectURL = value;
      }
   }

   
   [JsonIgnore]
   public String NUVportID {
      get {
         return _vportID;
      }
      set {
         this._vportID = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUWhiteList {
      get {
         return _whiteList;
      }
      set {
         this._whiteList = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public CaptivePortalProfilesFetcher getCaptivePortalProfiles() {
      return _captivePortalProfiles;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   

   public String toString() {
      return "SSIDConnection [" + "associatedCaptivePortalProfileID=" + _associatedCaptivePortalProfileID + ", associatedEgressQOSPolicyID=" + _associatedEgressQOSPolicyID + ", authenticationMode=" + _authenticationMode + ", blackList=" + _blackList + ", broadcastSSID=" + _broadcastSSID + ", description=" + _description + ", genericConfig=" + _genericConfig + ", interfaceName=" + _interfaceName + ", name=" + _name + ", passphrase=" + _passphrase + ", redirectOption=" + _redirectOption + ", redirectURL=" + _redirectURL + ", vportID=" + _vportID + ", whiteList=" + _whiteList + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ssidconnections";
   }

   public static String getRestName()
   {
	return "ssidconnection";
   }
}
}