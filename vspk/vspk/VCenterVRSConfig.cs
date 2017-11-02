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

public class VCenterVRSConfig: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("allowDataDHCP")]
   protected bool _allowDataDHCP;
   
   [JsonProperty("allowMgmtDHCP")]
   protected bool _allowMgmtDHCP;
   
   [JsonProperty("customizedScriptURL")]
   protected String _customizedScriptURL;
   
   [JsonProperty("dataDNS1")]
   protected String _dataDNS1;
   
   [JsonProperty("dataDNS2")]
   protected String _dataDNS2;
   
   [JsonProperty("dataGateway")]
   protected String _dataGateway;
   
   [JsonProperty("dataNetworkPortgroup")]
   protected String _dataNetworkPortgroup;
   
   [JsonProperty("datapathSyncTimeout")]
   protected long? _datapathSyncTimeout;
   
   [JsonProperty("dhcpRelayServer")]
   protected String _dhcpRelayServer;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("flowEvictionThreshold")]
   protected long? _flowEvictionThreshold;
   
   [JsonProperty("genericSplitActivation")]
   protected bool _genericSplitActivation;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("metadataServerIP")]
   protected String _metadataServerIP;
   
   [JsonProperty("metadataServerListenPort")]
   protected long? _metadataServerListenPort;
   
   [JsonProperty("metadataServerPort")]
   protected long? _metadataServerPort;
   
   [JsonProperty("metadataServiceEnabled")]
   protected bool _metadataServiceEnabled;
   
   [JsonProperty("mgmtDNS1")]
   protected String _mgmtDNS1;
   
   [JsonProperty("mgmtDNS2")]
   protected String _mgmtDNS2;
   
   [JsonProperty("mgmtGateway")]
   protected String _mgmtGateway;
   
   [JsonProperty("mgmtNetworkPortgroup")]
   protected String _mgmtNetworkPortgroup;
   
   [JsonProperty("mtu")]
   protected long? _mtu;
   
   [JsonProperty("multiVMSsupport")]
   protected bool _multiVMSsupport;
   
   [JsonProperty("multicastReceiveInterface")]
   protected String _multicastReceiveInterface;
   
   [JsonProperty("multicastReceiveInterfaceIP")]
   protected String _multicastReceiveInterfaceIP;
   
   [JsonProperty("multicastReceiveInterfaceNetmask")]
   protected String _multicastReceiveInterfaceNetmask;
   
   [JsonProperty("multicastReceiveRange")]
   protected String _multicastReceiveRange;
   
   [JsonProperty("multicastSendInterface")]
   protected String _multicastSendInterface;
   
   [JsonProperty("multicastSendInterfaceIP")]
   protected String _multicastSendInterfaceIP;
   
   [JsonProperty("multicastSendInterfaceNetmask")]
   protected String _multicastSendInterfaceNetmask;
   
   [JsonProperty("multicastSourcePortgroup")]
   protected String _multicastSourcePortgroup;
   
   [JsonProperty("networkUplinkInterface")]
   protected String _networkUplinkInterface;
   
   [JsonProperty("networkUplinkInterfaceGateway")]
   protected String _networkUplinkInterfaceGateway;
   
   [JsonProperty("networkUplinkInterfaceIp")]
   protected String _networkUplinkInterfaceIp;
   
   [JsonProperty("networkUplinkInterfaceNetmask")]
   protected String _networkUplinkInterfaceNetmask;
   
   [JsonProperty("nfsLogServer")]
   protected String _nfsLogServer;
   
   [JsonProperty("nfsMountPath")]
   protected String _nfsMountPath;
   
   [JsonProperty("novaClientVersion")]
   protected long? _novaClientVersion;
   
   [JsonProperty("novaMetadataServiceAuthUrl")]
   protected String _novaMetadataServiceAuthUrl;
   
   [JsonProperty("novaMetadataServiceEndpoint")]
   protected String _novaMetadataServiceEndpoint;
   
   [JsonProperty("novaMetadataServicePassword")]
   protected String _novaMetadataServicePassword;
   
   [JsonProperty("novaMetadataServiceTenant")]
   protected String _novaMetadataServiceTenant;
   
   [JsonProperty("novaMetadataServiceUsername")]
   protected String _novaMetadataServiceUsername;
   
   [JsonProperty("novaMetadataSharedSecret")]
   protected String _novaMetadataSharedSecret;
   
   [JsonProperty("novaRegionName")]
   protected String _novaRegionName;
   
   [JsonProperty("ntpServer1")]
   protected String _ntpServer1;
   
   [JsonProperty("ntpServer2")]
   protected String _ntpServer2;
   
   [JsonProperty("personality")]
   protected String _personality;
   
   [JsonProperty("portgroupMetadata")]
   protected bool _portgroupMetadata;
   
   [JsonProperty("primaryNuageController")]
   protected String _primaryNuageController;
   
   [JsonProperty("secondaryNuageController")]
   protected String _secondaryNuageController;
   
   [JsonProperty("separateDataNetwork")]
   protected bool _separateDataNetwork;
   
   [JsonProperty("siteId")]
   protected String _siteId;
   
   [JsonProperty("staticRoute")]
   protected String _staticRoute;
   
   [JsonProperty("staticRouteGateway")]
   protected String _staticRouteGateway;
   
   [JsonProperty("staticRouteNetmask")]
   protected String _staticRouteNetmask;
   
   [JsonProperty("vRequireNuageMetadata")]
   protected bool _vRequireNuageMetadata;
   
   [JsonProperty("vmNetworkPortgroup")]
   protected String _vmNetworkPortgroup;
   
   [JsonProperty("vrsPassword")]
   protected String _vrsPassword;
   
   [JsonProperty("vrsUserName")]
   protected String _vrsUserName;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private VRSAddressRangesFetcher _vRSAddressRanges;
   
   [JsonIgnore]
   private VRSRedeploymentpoliciesFetcher _vRSRedeploymentpolicies;
   
   public VCenterVRSConfig() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _vRSAddressRanges = new VRSAddressRangesFetcher(this);
      
      _vRSRedeploymentpolicies = new VRSRedeploymentpoliciesFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUAllowDataDHCP {
      get {
         return _allowDataDHCP;
      }
      set {
         this._allowDataDHCP = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowMgmtDHCP {
      get {
         return _allowMgmtDHCP;
      }
      set {
         this._allowMgmtDHCP = value;
      }
   }

   
   [JsonIgnore]
   public String NUCustomizedScriptURL {
      get {
         return _customizedScriptURL;
      }
      set {
         this._customizedScriptURL = value;
      }
   }

   
   [JsonIgnore]
   public String NUDataDNS1 {
      get {
         return _dataDNS1;
      }
      set {
         this._dataDNS1 = value;
      }
   }

   
   [JsonIgnore]
   public String NUDataDNS2 {
      get {
         return _dataDNS2;
      }
      set {
         this._dataDNS2 = value;
      }
   }

   
   [JsonIgnore]
   public String NUDataGateway {
      get {
         return _dataGateway;
      }
      set {
         this._dataGateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUDataNetworkPortgroup {
      get {
         return _dataNetworkPortgroup;
      }
      set {
         this._dataNetworkPortgroup = value;
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
   public String NUDhcpRelayServer {
      get {
         return _dhcpRelayServer;
      }
      set {
         this._dhcpRelayServer = value;
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
   public bool NUGenericSplitActivation {
      get {
         return _genericSplitActivation;
      }
      set {
         this._genericSplitActivation = value;
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
   public String NUMetadataServerIP {
      get {
         return _metadataServerIP;
      }
      set {
         this._metadataServerIP = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMetadataServerListenPort {
      get {
         return _metadataServerListenPort;
      }
      set {
         this._metadataServerListenPort = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMetadataServerPort {
      get {
         return _metadataServerPort;
      }
      set {
         this._metadataServerPort = value;
      }
   }

   
   [JsonIgnore]
   public bool NUMetadataServiceEnabled {
      get {
         return _metadataServiceEnabled;
      }
      set {
         this._metadataServiceEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUMgmtDNS1 {
      get {
         return _mgmtDNS1;
      }
      set {
         this._mgmtDNS1 = value;
      }
   }

   
   [JsonIgnore]
   public String NUMgmtDNS2 {
      get {
         return _mgmtDNS2;
      }
      set {
         this._mgmtDNS2 = value;
      }
   }

   
   [JsonIgnore]
   public String NUMgmtGateway {
      get {
         return _mgmtGateway;
      }
      set {
         this._mgmtGateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUMgmtNetworkPortgroup {
      get {
         return _mgmtNetworkPortgroup;
      }
      set {
         this._mgmtNetworkPortgroup = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMtu {
      get {
         return _mtu;
      }
      set {
         this._mtu = value;
      }
   }

   
   [JsonIgnore]
   public bool NUMultiVMSsupport {
      get {
         return _multiVMSsupport;
      }
      set {
         this._multiVMSsupport = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastReceiveInterface {
      get {
         return _multicastReceiveInterface;
      }
      set {
         this._multicastReceiveInterface = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastReceiveInterfaceIP {
      get {
         return _multicastReceiveInterfaceIP;
      }
      set {
         this._multicastReceiveInterfaceIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastReceiveInterfaceNetmask {
      get {
         return _multicastReceiveInterfaceNetmask;
      }
      set {
         this._multicastReceiveInterfaceNetmask = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastReceiveRange {
      get {
         return _multicastReceiveRange;
      }
      set {
         this._multicastReceiveRange = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastSendInterface {
      get {
         return _multicastSendInterface;
      }
      set {
         this._multicastSendInterface = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastSendInterfaceIP {
      get {
         return _multicastSendInterfaceIP;
      }
      set {
         this._multicastSendInterfaceIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastSendInterfaceNetmask {
      get {
         return _multicastSendInterfaceNetmask;
      }
      set {
         this._multicastSendInterfaceNetmask = value;
      }
   }

   
   [JsonIgnore]
   public String NUMulticastSourcePortgroup {
      get {
         return _multicastSourcePortgroup;
      }
      set {
         this._multicastSourcePortgroup = value;
      }
   }

   
   [JsonIgnore]
   public String NUNetworkUplinkInterface {
      get {
         return _networkUplinkInterface;
      }
      set {
         this._networkUplinkInterface = value;
      }
   }

   
   [JsonIgnore]
   public String NUNetworkUplinkInterfaceGateway {
      get {
         return _networkUplinkInterfaceGateway;
      }
      set {
         this._networkUplinkInterfaceGateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUNetworkUplinkInterfaceIp {
      get {
         return _networkUplinkInterfaceIp;
      }
      set {
         this._networkUplinkInterfaceIp = value;
      }
   }

   
   [JsonIgnore]
   public String NUNetworkUplinkInterfaceNetmask {
      get {
         return _networkUplinkInterfaceNetmask;
      }
      set {
         this._networkUplinkInterfaceNetmask = value;
      }
   }

   
   [JsonIgnore]
   public String NUNfsLogServer {
      get {
         return _nfsLogServer;
      }
      set {
         this._nfsLogServer = value;
      }
   }

   
   [JsonIgnore]
   public String NUNfsMountPath {
      get {
         return _nfsMountPath;
      }
      set {
         this._nfsMountPath = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNovaClientVersion {
      get {
         return _novaClientVersion;
      }
      set {
         this._novaClientVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaMetadataServiceAuthUrl {
      get {
         return _novaMetadataServiceAuthUrl;
      }
      set {
         this._novaMetadataServiceAuthUrl = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaMetadataServiceEndpoint {
      get {
         return _novaMetadataServiceEndpoint;
      }
      set {
         this._novaMetadataServiceEndpoint = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaMetadataServicePassword {
      get {
         return _novaMetadataServicePassword;
      }
      set {
         this._novaMetadataServicePassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaMetadataServiceTenant {
      get {
         return _novaMetadataServiceTenant;
      }
      set {
         this._novaMetadataServiceTenant = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaMetadataServiceUsername {
      get {
         return _novaMetadataServiceUsername;
      }
      set {
         this._novaMetadataServiceUsername = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaMetadataSharedSecret {
      get {
         return _novaMetadataSharedSecret;
      }
      set {
         this._novaMetadataSharedSecret = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaRegionName {
      get {
         return _novaRegionName;
      }
      set {
         this._novaRegionName = value;
      }
   }

   
   [JsonIgnore]
   public String NUNtpServer1 {
      get {
         return _ntpServer1;
      }
      set {
         this._ntpServer1 = value;
      }
   }

   
   [JsonIgnore]
   public String NUNtpServer2 {
      get {
         return _ntpServer2;
      }
      set {
         this._ntpServer2 = value;
      }
   }

   
   [JsonIgnore]
   public String NUPersonality {
      get {
         return _personality;
      }
      set {
         this._personality = value;
      }
   }

   
   [JsonIgnore]
   public bool NUPortgroupMetadata {
      get {
         return _portgroupMetadata;
      }
      set {
         this._portgroupMetadata = value;
      }
   }

   
   [JsonIgnore]
   public String NUPrimaryNuageController {
      get {
         return _primaryNuageController;
      }
      set {
         this._primaryNuageController = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryNuageController {
      get {
         return _secondaryNuageController;
      }
      set {
         this._secondaryNuageController = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSeparateDataNetwork {
      get {
         return _separateDataNetwork;
      }
      set {
         this._separateDataNetwork = value;
      }
   }

   
   [JsonIgnore]
   public String NUSiteId {
      get {
         return _siteId;
      }
      set {
         this._siteId = value;
      }
   }

   
   [JsonIgnore]
   public String NUStaticRoute {
      get {
         return _staticRoute;
      }
      set {
         this._staticRoute = value;
      }
   }

   
   [JsonIgnore]
   public String NUStaticRouteGateway {
      get {
         return _staticRouteGateway;
      }
      set {
         this._staticRouteGateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUStaticRouteNetmask {
      get {
         return _staticRouteNetmask;
      }
      set {
         this._staticRouteNetmask = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVRequireNuageMetadata {
      get {
         return _vRequireNuageMetadata;
      }
      set {
         this._vRequireNuageMetadata = value;
      }
   }

   
   [JsonIgnore]
   public String NUVmNetworkPortgroup {
      get {
         return _vmNetworkPortgroup;
      }
      set {
         this._vmNetworkPortgroup = value;
      }
   }

   
   [JsonIgnore]
   public String NUVrsPassword {
      get {
         return _vrsPassword;
      }
      set {
         this._vrsPassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUVrsUserName {
      get {
         return _vrsUserName;
      }
      set {
         this._vrsUserName = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public VRSAddressRangesFetcher getVRSAddressRanges() {
      return _vRSAddressRanges;
   }
   
   public VRSRedeploymentpoliciesFetcher getVRSRedeploymentpolicies() {
      return _vRSRedeploymentpolicies;
   }
   

   public String toString() {
      return "VCenterVRSConfig [" + "allowDataDHCP=" + _allowDataDHCP + ", allowMgmtDHCP=" + _allowMgmtDHCP + ", customizedScriptURL=" + _customizedScriptURL + ", dataDNS1=" + _dataDNS1 + ", dataDNS2=" + _dataDNS2 + ", dataGateway=" + _dataGateway + ", dataNetworkPortgroup=" + _dataNetworkPortgroup + ", datapathSyncTimeout=" + _datapathSyncTimeout + ", dhcpRelayServer=" + _dhcpRelayServer + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", flowEvictionThreshold=" + _flowEvictionThreshold + ", genericSplitActivation=" + _genericSplitActivation + ", lastUpdatedBy=" + _lastUpdatedBy + ", metadataServerIP=" + _metadataServerIP + ", metadataServerListenPort=" + _metadataServerListenPort + ", metadataServerPort=" + _metadataServerPort + ", metadataServiceEnabled=" + _metadataServiceEnabled + ", mgmtDNS1=" + _mgmtDNS1 + ", mgmtDNS2=" + _mgmtDNS2 + ", mgmtGateway=" + _mgmtGateway + ", mgmtNetworkPortgroup=" + _mgmtNetworkPortgroup + ", mtu=" + _mtu + ", multiVMSsupport=" + _multiVMSsupport + ", multicastReceiveInterface=" + _multicastReceiveInterface + ", multicastReceiveInterfaceIP=" + _multicastReceiveInterfaceIP + ", multicastReceiveInterfaceNetmask=" + _multicastReceiveInterfaceNetmask + ", multicastReceiveRange=" + _multicastReceiveRange + ", multicastSendInterface=" + _multicastSendInterface + ", multicastSendInterfaceIP=" + _multicastSendInterfaceIP + ", multicastSendInterfaceNetmask=" + _multicastSendInterfaceNetmask + ", multicastSourcePortgroup=" + _multicastSourcePortgroup + ", networkUplinkInterface=" + _networkUplinkInterface + ", networkUplinkInterfaceGateway=" + _networkUplinkInterfaceGateway + ", networkUplinkInterfaceIp=" + _networkUplinkInterfaceIp + ", networkUplinkInterfaceNetmask=" + _networkUplinkInterfaceNetmask + ", nfsLogServer=" + _nfsLogServer + ", nfsMountPath=" + _nfsMountPath + ", novaClientVersion=" + _novaClientVersion + ", novaMetadataServiceAuthUrl=" + _novaMetadataServiceAuthUrl + ", novaMetadataServiceEndpoint=" + _novaMetadataServiceEndpoint + ", novaMetadataServicePassword=" + _novaMetadataServicePassword + ", novaMetadataServiceTenant=" + _novaMetadataServiceTenant + ", novaMetadataServiceUsername=" + _novaMetadataServiceUsername + ", novaMetadataSharedSecret=" + _novaMetadataSharedSecret + ", novaRegionName=" + _novaRegionName + ", ntpServer1=" + _ntpServer1 + ", ntpServer2=" + _ntpServer2 + ", personality=" + _personality + ", portgroupMetadata=" + _portgroupMetadata + ", primaryNuageController=" + _primaryNuageController + ", secondaryNuageController=" + _secondaryNuageController + ", separateDataNetwork=" + _separateDataNetwork + ", siteId=" + _siteId + ", staticRoute=" + _staticRoute + ", staticRouteGateway=" + _staticRouteGateway + ", staticRouteNetmask=" + _staticRouteNetmask + ", vRequireNuageMetadata=" + _vRequireNuageMetadata + ", vmNetworkPortgroup=" + _vmNetworkPortgroup + ", vrsPassword=" + _vrsPassword + ", vrsUserName=" + _vrsUserName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vrsconfigs";
   }

   public static String getRestName()
   {
	return "vrsconfig";
   }
}
}