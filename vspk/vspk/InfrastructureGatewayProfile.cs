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

public class InfrastructureGatewayProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EControllerLessForwardingMode {DISABLED,LOCAL_AND_REMOTE,LOCAL_ONLY };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ERemoteLogMode {DISABLED,RSYSLOG };
   public enum EUnderlayTestUplinkMode {ALL_UPLINKS,BOOTSTRAP_UPLINK };
   public enum EUpgradeAction {DOWNLOAD_AND_UPGRADE_AT_WINDOW,DOWNLOAD_AND_UPGRADE_NOW,DOWNLOAD_ONLY,NONE,UPGRADE_AT_BOOTSTRAPPING,UPGRADE_NOW };

   
   [JsonProperty("NTPServerKey")]
   protected String _NTPServerKey;
   
   [JsonProperty("NTPServerKeyID")]
   protected long? _NTPServerKeyID;
   
   [JsonProperty("controllerLessDuration")]
   protected String _controllerLessDuration;
   
   [JsonProperty("controllerLessEnabled")]
   protected bool _controllerLessEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("controllerLessForwardingMode")]
   protected EControllerLessForwardingMode? _controllerLessForwardingMode;
   
   [JsonProperty("controllerLessRemoteDuration")]
   protected String _controllerLessRemoteDuration;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("datapathSyncTimeout")]
   protected long? _datapathSyncTimeout;
   
   [JsonProperty("deadTimer")]
   protected String _deadTimer;
   
   [JsonProperty("deadTimerEnabled")]
   protected bool _deadTimerEnabled;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enableUnderlayTestsDuringActivation")]
   protected bool _enableUnderlayTestsDuringActivation;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("flowEvictionThreshold")]
   protected long? _flowEvictionThreshold;
   
   [JsonProperty("forceImmediateSystemSync")]
   protected bool _forceImmediateSystemSync;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("metadataUpgradePath")]
   protected String _metadataUpgradePath;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("openFlowAuditTimer")]
   protected long? _openFlowAuditTimer;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("proxyDNSName")]
   protected String _proxyDNSName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("remoteLogMode")]
   protected ERemoteLogMode? _remoteLogMode;
   
   [JsonProperty("remoteLogServerAddress")]
   protected String _remoteLogServerAddress;
   
   [JsonProperty("remoteLogServerPort")]
   protected long? _remoteLogServerPort;
   
   [JsonProperty("runUnderlayBandwidthTest")]
   protected bool _runUnderlayBandwidthTest;
   
   [JsonProperty("runUnderlayConnectivityTest")]
   protected bool _runUnderlayConnectivityTest;
   
   [JsonProperty("runUnderlayMTUDiscoveryTest")]
   protected bool _runUnderlayMTUDiscoveryTest;
   
   [JsonProperty("secondaryRemoteLogServerAddress")]
   protected String _secondaryRemoteLogServerAddress;
   
   [JsonProperty("secondaryRemoteLogServerPort")]
   protected long? _secondaryRemoteLogServerPort;
   
   [JsonProperty("statsCollectorPort")]
   protected long? _statsCollectorPort;
   
   [JsonProperty("systemSyncScheduler")]
   protected String _systemSyncScheduler;
   
   [JsonProperty("underlayTestServer")]
   protected String _underlayTestServer;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("underlayTestUplinkMode")]
   protected EUnderlayTestUplinkMode? _underlayTestUplinkMode;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("upgradeAction")]
   protected EUpgradeAction? _upgradeAction;
   
   [JsonProperty("useTwoFactor")]
   protected bool _useTwoFactor;
   
   [JsonProperty("webFilterDownloadPort")]
   protected long? _webFilterDownloadPort;
   
   [JsonProperty("webFilterQueryPort")]
   protected long? _webFilterQueryPort;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public InfrastructureGatewayProfile() {
      _upgradeAction = EUpgradeAction.NONE;
      _statsCollectorPort = 29090L;
      _systemSyncScheduler = "0 0 * * *";
      _useTwoFactor = true;
      _remoteLogMode = ERemoteLogMode.DISABLED;
      _datapathSyncTimeout = 1000L;
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUNTPServerKey {
      get {
         return _NTPServerKey;
      }
      set {
         this._NTPServerKey = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNTPServerKeyID {
      get {
         return _NTPServerKeyID;
      }
      set {
         this._NTPServerKeyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUControllerLessDuration {
      get {
         return _controllerLessDuration;
      }
      set {
         this._controllerLessDuration = value;
      }
   }

   
   [JsonIgnore]
   public bool NUControllerLessEnabled {
      get {
         return _controllerLessEnabled;
      }
      set {
         this._controllerLessEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EControllerLessForwardingMode? NUControllerLessForwardingMode {
      get {
         return _controllerLessForwardingMode;
      }
      set {
         this._controllerLessForwardingMode = value;
      }
   }

   
   [JsonIgnore]
   public String NUControllerLessRemoteDuration {
      get {
         return _controllerLessRemoteDuration;
      }
      set {
         this._controllerLessRemoteDuration = value;
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
   public long? NUDatapathSyncTimeout {
      get {
         return _datapathSyncTimeout;
      }
      set {
         this._datapathSyncTimeout = value;
      }
   }

   
   [JsonIgnore]
   public String NUDeadTimer {
      get {
         return _deadTimer;
      }
      set {
         this._deadTimer = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDeadTimerEnabled {
      get {
         return _deadTimerEnabled;
      }
      set {
         this._deadTimerEnabled = value;
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
   public bool NUEnableUnderlayTestsDuringActivation {
      get {
         return _enableUnderlayTestsDuringActivation;
      }
      set {
         this._enableUnderlayTestsDuringActivation = value;
      }
   }

   
   [JsonIgnore]
   public String NUEnterpriseID {
      get {
         return _enterpriseID;
      }
      set {
         this._enterpriseID = value;
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
   public long? NUFlowEvictionThreshold {
      get {
         return _flowEvictionThreshold;
      }
      set {
         this._flowEvictionThreshold = value;
      }
   }

   
   [JsonIgnore]
   public bool NUForceImmediateSystemSync {
      get {
         return _forceImmediateSystemSync;
      }
      set {
         this._forceImmediateSystemSync = value;
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
   public String NUMetadataUpgradePath {
      get {
         return _metadataUpgradePath;
      }
      set {
         this._metadataUpgradePath = value;
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
   public long? NUOpenFlowAuditTimer {
      get {
         return _openFlowAuditTimer;
      }
      set {
         this._openFlowAuditTimer = value;
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
   public String NUProxyDNSName {
      get {
         return _proxyDNSName;
      }
      set {
         this._proxyDNSName = value;
      }
   }

   
   [JsonIgnore]
   public ERemoteLogMode? NURemoteLogMode {
      get {
         return _remoteLogMode;
      }
      set {
         this._remoteLogMode = value;
      }
   }

   
   [JsonIgnore]
   public String NURemoteLogServerAddress {
      get {
         return _remoteLogServerAddress;
      }
      set {
         this._remoteLogServerAddress = value;
      }
   }

   
   [JsonIgnore]
   public long? NURemoteLogServerPort {
      get {
         return _remoteLogServerPort;
      }
      set {
         this._remoteLogServerPort = value;
      }
   }

   
   [JsonIgnore]
   public bool NURunUnderlayBandwidthTest {
      get {
         return _runUnderlayBandwidthTest;
      }
      set {
         this._runUnderlayBandwidthTest = value;
      }
   }

   
   [JsonIgnore]
   public bool NURunUnderlayConnectivityTest {
      get {
         return _runUnderlayConnectivityTest;
      }
      set {
         this._runUnderlayConnectivityTest = value;
      }
   }

   
   [JsonIgnore]
   public bool NURunUnderlayMTUDiscoveryTest {
      get {
         return _runUnderlayMTUDiscoveryTest;
      }
      set {
         this._runUnderlayMTUDiscoveryTest = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryRemoteLogServerAddress {
      get {
         return _secondaryRemoteLogServerAddress;
      }
      set {
         this._secondaryRemoteLogServerAddress = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSecondaryRemoteLogServerPort {
      get {
         return _secondaryRemoteLogServerPort;
      }
      set {
         this._secondaryRemoteLogServerPort = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStatsCollectorPort {
      get {
         return _statsCollectorPort;
      }
      set {
         this._statsCollectorPort = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystemSyncScheduler {
      get {
         return _systemSyncScheduler;
      }
      set {
         this._systemSyncScheduler = value;
      }
   }

   
   [JsonIgnore]
   public String NUUnderlayTestServer {
      get {
         return _underlayTestServer;
      }
      set {
         this._underlayTestServer = value;
      }
   }

   
   [JsonIgnore]
   public EUnderlayTestUplinkMode? NUUnderlayTestUplinkMode {
      get {
         return _underlayTestUplinkMode;
      }
      set {
         this._underlayTestUplinkMode = value;
      }
   }

   
   [JsonIgnore]
   public EUpgradeAction? NUUpgradeAction {
      get {
         return _upgradeAction;
      }
      set {
         this._upgradeAction = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUseTwoFactor {
      get {
         return _useTwoFactor;
      }
      set {
         this._useTwoFactor = value;
      }
   }

   
   [JsonIgnore]
   public long? NUWebFilterDownloadPort {
      get {
         return _webFilterDownloadPort;
      }
      set {
         this._webFilterDownloadPort = value;
      }
   }

   
   [JsonIgnore]
   public long? NUWebFilterQueryPort {
      get {
         return _webFilterQueryPort;
      }
      set {
         this._webFilterQueryPort = value;
      }
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
   

   public String toString() {
      return "InfrastructureGatewayProfile [" + "NTPServerKey=" + _NTPServerKey + ", NTPServerKeyID=" + _NTPServerKeyID + ", controllerLessDuration=" + _controllerLessDuration + ", controllerLessEnabled=" + _controllerLessEnabled + ", controllerLessForwardingMode=" + _controllerLessForwardingMode + ", controllerLessRemoteDuration=" + _controllerLessRemoteDuration + ", creationDate=" + _creationDate + ", datapathSyncTimeout=" + _datapathSyncTimeout + ", deadTimer=" + _deadTimer + ", deadTimerEnabled=" + _deadTimerEnabled + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", enableUnderlayTestsDuringActivation=" + _enableUnderlayTestsDuringActivation + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", flowEvictionThreshold=" + _flowEvictionThreshold + ", forceImmediateSystemSync=" + _forceImmediateSystemSync + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", metadataUpgradePath=" + _metadataUpgradePath + ", name=" + _name + ", openFlowAuditTimer=" + _openFlowAuditTimer + ", owner=" + _owner + ", proxyDNSName=" + _proxyDNSName + ", remoteLogMode=" + _remoteLogMode + ", remoteLogServerAddress=" + _remoteLogServerAddress + ", remoteLogServerPort=" + _remoteLogServerPort + ", runUnderlayBandwidthTest=" + _runUnderlayBandwidthTest + ", runUnderlayConnectivityTest=" + _runUnderlayConnectivityTest + ", runUnderlayMTUDiscoveryTest=" + _runUnderlayMTUDiscoveryTest + ", secondaryRemoteLogServerAddress=" + _secondaryRemoteLogServerAddress + ", secondaryRemoteLogServerPort=" + _secondaryRemoteLogServerPort + ", statsCollectorPort=" + _statsCollectorPort + ", systemSyncScheduler=" + _systemSyncScheduler + ", underlayTestServer=" + _underlayTestServer + ", underlayTestUplinkMode=" + _underlayTestUplinkMode + ", upgradeAction=" + _upgradeAction + ", useTwoFactor=" + _useTwoFactor + ", webFilterDownloadPort=" + _webFilterDownloadPort + ", webFilterQueryPort=" + _webFilterQueryPort + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "infrastructuregatewayprofiles";
   }

   public static String getRestName()
   {
	return "infrastructuregatewayprofile";
   }
}
}