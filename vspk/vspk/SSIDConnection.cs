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

public class SSIDConnection: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAuthenticationMode {CAPTIVE_PORTAL,OPEN,WEP,WPA,WPA2,WPA_OTP,WPA_WPA2 };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {USE,READ,ALL,INSTANTIATE,EXTEND,DEPLOY };
   public enum ERedirectOption {CONFIGURED_URL,ORIGINAL_REQUEST };
   public enum EStatus {INITIALIZED,ORPHAN,READY,MISMATCH };

   
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
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gatewayID")]
   protected String _gatewayID;
   
   [JsonProperty("genericConfig")]
   protected String _genericConfig;
   
   [JsonProperty("interfaceName")]
   protected String _interfaceName;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("passphrase")]
   protected String _passphrase;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("readonly")]
   protected bool _readonly;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("redirectOption")]
   protected ERedirectOption? _redirectOption;
   
   [JsonProperty("redirectURL")]
   protected String _redirectURL;
   
   [JsonProperty("restricted")]
   protected bool _restricted;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("vlanID")]
   protected long? _vlanID;
   
   [JsonProperty("vportID")]
   protected String _vportID;
   
   [JsonProperty("whiteList")]
   protected System.Collections.Generic.List<String> _whiteList;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public SSIDConnection() {
      
      _alarms = new AlarmsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
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
   public String NUGatewayID {
      get {
         return _gatewayID;
      }
      set {
         this._gatewayID = value;
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
   public String NUPassphrase {
      get {
         return _passphrase;
      }
      set {
         this._passphrase = value;
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
   public bool NUReadonly {
      get {
         return _readonly;
      }
      set {
         this._readonly = value;
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
   public bool NURestricted {
      get {
         return _restricted;
      }
      set {
         this._restricted = value;
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
   public long? NUVlanID {
      get {
         return _vlanID;
      }
      set {
         this._vlanID = value;
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
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "SSIDConnection [" + "associatedCaptivePortalProfileID=" + _associatedCaptivePortalProfileID + ", associatedEgressQOSPolicyID=" + _associatedEgressQOSPolicyID + ", authenticationMode=" + _authenticationMode + ", blackList=" + _blackList + ", broadcastSSID=" + _broadcastSSID + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayID=" + _gatewayID + ", genericConfig=" + _genericConfig + ", interfaceName=" + _interfaceName + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", passphrase=" + _passphrase + ", permittedAction=" + _permittedAction + ", readonly=" + _readonly + ", redirectOption=" + _redirectOption + ", redirectURL=" + _redirectURL + ", restricted=" + _restricted + ", status=" + _status + ", vlanID=" + _vlanID + ", vportID=" + _vportID + ", whiteList=" + _whiteList + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
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