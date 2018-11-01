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

public class VCenterHypervisor: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EVRSState {DEPLOYED,DEPLOYING,NOT_DEPLOYED,TIMEDOUT,UPGRADING };
   public enum EAvrsProfile {AVRS_25G };
   public enum ECpuCount {DEFAULT_2,LARGE_6,MEDIUM_4,XLARGE_8 };
   public enum EDestinationMirrorPort {ens160,ens161,ens224,ens256,no_mirror };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EMemorySizeInGB {DEFAULT_4,LARGE_8,MEDIUM_6 };
   public enum EPersonality {VDF,VRS };
   public enum ERemoteSyslogServerType {NONE,TCP,UDP };

   
   [JsonProperty("ARPReply")]
   protected bool _ARPReply;
   
   [JsonProperty("VRSAgentMOID")]
   protected String _VRSAgentMOID;
   
   [JsonProperty("VRSAgentName")]
   protected String _VRSAgentName;
   
   [JsonProperty("VRSConfigurationTimeLimit")]
   protected long? _VRSConfigurationTimeLimit;
   
   [JsonProperty("VRSMetricsID")]
   protected String _VRSMetricsID;
   
   [JsonProperty("VRSMgmtHostname")]
   protected String _VRSMgmtHostname;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("VRSState")]
   protected EVRSState? _VRSState;
   
   [JsonProperty("agencyMoid")]
   protected String _agencyMoid;
   
   [JsonProperty("allowDataDHCP")]
   protected bool _allowDataDHCP;
   
   [JsonProperty("allowMgmtDHCP")]
   protected bool _allowMgmtDHCP;
   
   [JsonProperty("availableNetworks")]
   protected System.Collections.Generic.List<String> _availableNetworks;
   
   [JsonProperty("avrsEnabled")]
   protected bool _avrsEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("avrsProfile")]
   protected EAvrsProfile? _avrsProfile;
   
   [JsonProperty("configuredMetricsPushInterval")]
   protected long? _configuredMetricsPushInterval;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("cpuCount")]
   protected ECpuCount? _cpuCount;
   
   [JsonProperty("customizedScriptURL")]
   protected String _customizedScriptURL;
   
   [JsonProperty("dataDNS1")]
   protected String _dataDNS1;
   
   [JsonProperty("dataDNS2")]
   protected String _dataDNS2;
   
   [JsonProperty("dataGateway")]
   protected String _dataGateway;
   
   [JsonProperty("dataIPAddress")]
   protected String _dataIPAddress;
   
   [JsonProperty("dataNetmask")]
   protected String _dataNetmask;
   
   [JsonProperty("dataNetworkPortgroup")]
   protected String _dataNetworkPortgroup;
   
   [JsonProperty("datapathSyncTimeout")]
   protected long? _datapathSyncTimeout;
   
   [JsonProperty("deploymentCount")]
   protected long? _deploymentCount;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("destinationMirrorPort")]
   protected EDestinationMirrorPort? _destinationMirrorPort;
   
   [JsonProperty("dhcpRelayServer")]
   protected String _dhcpRelayServer;
   
   [JsonProperty("disableGROOnDatapath")]
   protected bool _disableGROOnDatapath;
   
   [JsonProperty("disableLROOnDatapath")]
   protected bool _disableLROOnDatapath;
   
   [JsonProperty("enableVRSResourceReservation")]
   protected bool _enableVRSResourceReservation;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("flowEvictionThreshold")]
   protected long? _flowEvictionThreshold;
   
   [JsonProperty("genericSplitActivation")]
   protected bool _genericSplitActivation;
   
   [JsonProperty("hypervisorIP")]
   protected String _hypervisorIP;
   
   [JsonProperty("hypervisorPassword")]
   protected String _hypervisorPassword;
   
   [JsonProperty("hypervisorUser")]
   protected String _hypervisorUser;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastVRSDeployedDate")]
   protected long? _lastVRSDeployedDate;
   
   [JsonProperty("manageVRSAvailability")]
   protected bool _manageVRSAvailability;
   
   [JsonProperty("managedObjectID")]
   protected String _managedObjectID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("memorySizeInGB")]
   protected EMemorySizeInGB? _memorySizeInGB;
   
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
   
   [JsonProperty("mgmtIPAddress")]
   protected String _mgmtIPAddress;
   
   [JsonProperty("mgmtNetmask")]
   protected String _mgmtNetmask;
   
   [JsonProperty("mgmtNetworkPortgroup")]
   protected String _mgmtNetworkPortgroup;
   
   [JsonProperty("mirrorNetworkPortgroup")]
   protected String _mirrorNetworkPortgroup;
   
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
   
   [JsonProperty("name")]
   protected String _name;
   
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
   
   [JsonProperty("novaIdentityURLVersion")]
   protected String _novaIdentityURLVersion;
   
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
   
   [JsonProperty("novaOSKeystoneUsername")]
   protected String _novaOSKeystoneUsername;
   
   [JsonProperty("novaProjectDomainName")]
   protected String _novaProjectDomainName;
   
   [JsonProperty("novaProjectName")]
   protected String _novaProjectName;
   
   [JsonProperty("novaRegionName")]
   protected String _novaRegionName;
   
   [JsonProperty("novaUserDomainName")]
   protected String _novaUserDomainName;
   
   [JsonProperty("ntpServer1")]
   protected String _ntpServer1;
   
   [JsonProperty("ntpServer2")]
   protected String _ntpServer2;
   
   [JsonProperty("ovfURL")]
   protected String _ovfURL;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("personality")]
   protected EPersonality? _personality;
   
   [JsonProperty("portgroupMetadata")]
   protected bool _portgroupMetadata;
   
   [JsonProperty("primaryDataUplinkUnderlayID")]
   protected long? _primaryDataUplinkUnderlayID;
   
   [JsonProperty("primaryDataUplinkVDFControlVLAN")]
   protected long? _primaryDataUplinkVDFControlVLAN;
   
   [JsonProperty("primaryNuageController")]
   protected String _primaryNuageController;
   
   [JsonProperty("remoteSyslogServerIP")]
   protected String _remoteSyslogServerIP;
   
   [JsonProperty("remoteSyslogServerPort")]
   protected long? _remoteSyslogServerPort;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("remoteSyslogServerType")]
   protected ERemoteSyslogServerType? _remoteSyslogServerType;
   
   [JsonProperty("removedFromVCenterInventory")]
   protected bool _removedFromVCenterInventory;
   
   [JsonProperty("revertiveControllerEnabled")]
   protected bool _revertiveControllerEnabled;
   
   [JsonProperty("revertiveTimer")]
   protected long? _revertiveTimer;
   
   [JsonProperty("scope")]
   protected bool _scope;
   
   [JsonProperty("secondaryDataUplinkDHCPEnabled")]
   protected bool _secondaryDataUplinkDHCPEnabled;
   
   [JsonProperty("secondaryDataUplinkEnabled")]
   protected bool _secondaryDataUplinkEnabled;
   
   [JsonProperty("secondaryDataUplinkIP")]
   protected String _secondaryDataUplinkIP;
   
   [JsonProperty("secondaryDataUplinkInterface")]
   protected String _secondaryDataUplinkInterface;
   
   [JsonProperty("secondaryDataUplinkMTU")]
   protected long? _secondaryDataUplinkMTU;
   
   [JsonProperty("secondaryDataUplinkNetmask")]
   protected String _secondaryDataUplinkNetmask;
   
   [JsonProperty("secondaryDataUplinkPrimaryController")]
   protected String _secondaryDataUplinkPrimaryController;
   
   [JsonProperty("secondaryDataUplinkSecondaryController")]
   protected String _secondaryDataUplinkSecondaryController;
   
   [JsonProperty("secondaryDataUplinkUnderlayID")]
   protected long? _secondaryDataUplinkUnderlayID;
   
   [JsonProperty("secondaryDataUplinkVDFControlVLAN")]
   protected long? _secondaryDataUplinkVDFControlVLAN;
   
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
   
   [JsonProperty("successfullyAppliedUpgradePackagePassword")]
   protected String _successfullyAppliedUpgradePackagePassword;
   
   [JsonProperty("successfullyAppliedUpgradePackageURL")]
   protected String _successfullyAppliedUpgradePackageURL;
   
   [JsonProperty("successfullyAppliedUpgradePackageUsername")]
   protected String _successfullyAppliedUpgradePackageUsername;
   
   [JsonProperty("successfullyAppliedVersion")]
   protected String _successfullyAppliedVersion;
   
   [JsonProperty("toolboxDeploymentMode")]
   protected bool _toolboxDeploymentMode;
   
   [JsonProperty("toolboxGroup")]
   protected String _toolboxGroup;
   
   [JsonProperty("toolboxIP")]
   protected String _toolboxIP;
   
   [JsonProperty("toolboxPassword")]
   protected String _toolboxPassword;
   
   [JsonProperty("toolboxUserName")]
   protected String _toolboxUserName;
   
   [JsonProperty("upgradePackagePassword")]
   protected String _upgradePackagePassword;
   
   [JsonProperty("upgradePackageURL")]
   protected String _upgradePackageURL;
   
   [JsonProperty("upgradePackageUsername")]
   protected String _upgradePackageUsername;
   
   [JsonProperty("upgradeScriptTimeLimit")]
   protected long? _upgradeScriptTimeLimit;
   
   [JsonProperty("upgradeStatus")]
   protected String _upgradeStatus;
   
   [JsonProperty("upgradeTimedout")]
   protected bool _upgradeTimedout;
   
   [JsonProperty("vCenterIP")]
   protected String _vCenterIP;
   
   [JsonProperty("vCenterPassword")]
   protected String _vCenterPassword;
   
   [JsonProperty("vCenterUser")]
   protected String _vCenterUser;
   
   [JsonProperty("vRequireNuageMetadata")]
   protected bool _vRequireNuageMetadata;
   
   [JsonProperty("vmNetworkPortgroup")]
   protected String _vmNetworkPortgroup;
   
   [JsonProperty("vrsId")]
   protected String _vrsId;
   
   [JsonProperty("vrsMarkedAsAvailable")]
   protected bool _vrsMarkedAsAvailable;
   
   [JsonProperty("vrsPassword")]
   protected String _vrsPassword;
   
   [JsonProperty("vrsUserName")]
   protected String _vrsUserName;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private VRSAddressRangesFetcher _vRSAddressRanges;
   
   [JsonIgnore]
   private VRSMetricsFetcher _vRSMetrics;
   
   [JsonIgnore]
   private VRSRedeploymentpoliciesFetcher _vRSRedeploymentpolicies;
   
   public VCenterHypervisor() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _vRSAddressRanges = new VRSAddressRangesFetcher(this);
      
      _vRSMetrics = new VRSMetricsFetcher(this);
      
      _vRSRedeploymentpolicies = new VRSRedeploymentpoliciesFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUARPReply {
      get {
         return _ARPReply;
      }
      set {
         this._ARPReply = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSAgentMOID {
      get {
         return _VRSAgentMOID;
      }
      set {
         this._VRSAgentMOID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSAgentName {
      get {
         return _VRSAgentName;
      }
      set {
         this._VRSAgentName = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVRSConfigurationTimeLimit {
      get {
         return _VRSConfigurationTimeLimit;
      }
      set {
         this._VRSConfigurationTimeLimit = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSMetricsID {
      get {
         return _VRSMetricsID;
      }
      set {
         this._VRSMetricsID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSMgmtHostname {
      get {
         return _VRSMgmtHostname;
      }
      set {
         this._VRSMgmtHostname = value;
      }
   }

   
   [JsonIgnore]
   public EVRSState? NUVRSState {
      get {
         return _VRSState;
      }
      set {
         this._VRSState = value;
      }
   }

   
   [JsonIgnore]
   public String NUAgencyMoid {
      get {
         return _agencyMoid;
      }
      set {
         this._agencyMoid = value;
      }
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
   public System.Collections.Generic.List<String> NUAvailableNetworks {
      get {
         return _availableNetworks;
      }
      set {
         this._availableNetworks = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAvrsEnabled {
      get {
         return _avrsEnabled;
      }
      set {
         this._avrsEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EAvrsProfile? NUAvrsProfile {
      get {
         return _avrsProfile;
      }
      set {
         this._avrsProfile = value;
      }
   }

   
   [JsonIgnore]
   public long? NUConfiguredMetricsPushInterval {
      get {
         return _configuredMetricsPushInterval;
      }
      set {
         this._configuredMetricsPushInterval = value;
      }
   }

   
   [JsonIgnore]
   public ECpuCount? NUCpuCount {
      get {
         return _cpuCount;
      }
      set {
         this._cpuCount = value;
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
   public String NUDataIPAddress {
      get {
         return _dataIPAddress;
      }
      set {
         this._dataIPAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUDataNetmask {
      get {
         return _dataNetmask;
      }
      set {
         this._dataNetmask = value;
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
   public long? NUDeploymentCount {
      get {
         return _deploymentCount;
      }
      set {
         this._deploymentCount = value;
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
   public EDestinationMirrorPort? NUDestinationMirrorPort {
      get {
         return _destinationMirrorPort;
      }
      set {
         this._destinationMirrorPort = value;
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
   public bool NUDisableGROOnDatapath {
      get {
         return _disableGROOnDatapath;
      }
      set {
         this._disableGROOnDatapath = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDisableLROOnDatapath {
      get {
         return _disableLROOnDatapath;
      }
      set {
         this._disableLROOnDatapath = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEnableVRSResourceReservation {
      get {
         return _enableVRSResourceReservation;
      }
      set {
         this._enableVRSResourceReservation = value;
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
   public String NUHypervisorIP {
      get {
         return _hypervisorIP;
      }
      set {
         this._hypervisorIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUHypervisorPassword {
      get {
         return _hypervisorPassword;
      }
      set {
         this._hypervisorPassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUHypervisorUser {
      get {
         return _hypervisorUser;
      }
      set {
         this._hypervisorUser = value;
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
   public long? NULastVRSDeployedDate {
      get {
         return _lastVRSDeployedDate;
      }
      set {
         this._lastVRSDeployedDate = value;
      }
   }

   
   [JsonIgnore]
   public bool NUManageVRSAvailability {
      get {
         return _manageVRSAvailability;
      }
      set {
         this._manageVRSAvailability = value;
      }
   }

   
   [JsonIgnore]
   public String NUManagedObjectID {
      get {
         return _managedObjectID;
      }
      set {
         this._managedObjectID = value;
      }
   }

   
   [JsonIgnore]
   public EMemorySizeInGB? NUMemorySizeInGB {
      get {
         return _memorySizeInGB;
      }
      set {
         this._memorySizeInGB = value;
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
   public String NUMgmtIPAddress {
      get {
         return _mgmtIPAddress;
      }
      set {
         this._mgmtIPAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUMgmtNetmask {
      get {
         return _mgmtNetmask;
      }
      set {
         this._mgmtNetmask = value;
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
   public String NUMirrorNetworkPortgroup {
      get {
         return _mirrorNetworkPortgroup;
      }
      set {
         this._mirrorNetworkPortgroup = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
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
   public String NUNovaIdentityURLVersion {
      get {
         return _novaIdentityURLVersion;
      }
      set {
         this._novaIdentityURLVersion = value;
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
   public String NUNovaOSKeystoneUsername {
      get {
         return _novaOSKeystoneUsername;
      }
      set {
         this._novaOSKeystoneUsername = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaProjectDomainName {
      get {
         return _novaProjectDomainName;
      }
      set {
         this._novaProjectDomainName = value;
      }
   }

   
   [JsonIgnore]
   public String NUNovaProjectName {
      get {
         return _novaProjectName;
      }
      set {
         this._novaProjectName = value;
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
   public String NUNovaUserDomainName {
      get {
         return _novaUserDomainName;
      }
      set {
         this._novaUserDomainName = value;
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
   public String NUOvfURL {
      get {
         return _ovfURL;
      }
      set {
         this._ovfURL = value;
      }
   }

   
   [JsonIgnore]
   public EPersonality? NUPersonality {
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
   public long? NUPrimaryDataUplinkUnderlayID {
      get {
         return _primaryDataUplinkUnderlayID;
      }
      set {
         this._primaryDataUplinkUnderlayID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPrimaryDataUplinkVDFControlVLAN {
      get {
         return _primaryDataUplinkVDFControlVLAN;
      }
      set {
         this._primaryDataUplinkVDFControlVLAN = value;
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
   public String NURemoteSyslogServerIP {
      get {
         return _remoteSyslogServerIP;
      }
      set {
         this._remoteSyslogServerIP = value;
      }
   }

   
   [JsonIgnore]
   public long? NURemoteSyslogServerPort {
      get {
         return _remoteSyslogServerPort;
      }
      set {
         this._remoteSyslogServerPort = value;
      }
   }

   
   [JsonIgnore]
   public ERemoteSyslogServerType? NURemoteSyslogServerType {
      get {
         return _remoteSyslogServerType;
      }
      set {
         this._remoteSyslogServerType = value;
      }
   }

   
   [JsonIgnore]
   public bool NURemovedFromVCenterInventory {
      get {
         return _removedFromVCenterInventory;
      }
      set {
         this._removedFromVCenterInventory = value;
      }
   }

   
   [JsonIgnore]
   public bool NURevertiveControllerEnabled {
      get {
         return _revertiveControllerEnabled;
      }
      set {
         this._revertiveControllerEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NURevertiveTimer {
      get {
         return _revertiveTimer;
      }
      set {
         this._revertiveTimer = value;
      }
   }

   
   [JsonIgnore]
   public bool NUScope {
      get {
         return _scope;
      }
      set {
         this._scope = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSecondaryDataUplinkDHCPEnabled {
      get {
         return _secondaryDataUplinkDHCPEnabled;
      }
      set {
         this._secondaryDataUplinkDHCPEnabled = value;
      }
   }

   
   [JsonIgnore]
   public bool NUSecondaryDataUplinkEnabled {
      get {
         return _secondaryDataUplinkEnabled;
      }
      set {
         this._secondaryDataUplinkEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryDataUplinkIP {
      get {
         return _secondaryDataUplinkIP;
      }
      set {
         this._secondaryDataUplinkIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryDataUplinkInterface {
      get {
         return _secondaryDataUplinkInterface;
      }
      set {
         this._secondaryDataUplinkInterface = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSecondaryDataUplinkMTU {
      get {
         return _secondaryDataUplinkMTU;
      }
      set {
         this._secondaryDataUplinkMTU = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryDataUplinkNetmask {
      get {
         return _secondaryDataUplinkNetmask;
      }
      set {
         this._secondaryDataUplinkNetmask = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryDataUplinkPrimaryController {
      get {
         return _secondaryDataUplinkPrimaryController;
      }
      set {
         this._secondaryDataUplinkPrimaryController = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryDataUplinkSecondaryController {
      get {
         return _secondaryDataUplinkSecondaryController;
      }
      set {
         this._secondaryDataUplinkSecondaryController = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSecondaryDataUplinkUnderlayID {
      get {
         return _secondaryDataUplinkUnderlayID;
      }
      set {
         this._secondaryDataUplinkUnderlayID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSecondaryDataUplinkVDFControlVLAN {
      get {
         return _secondaryDataUplinkVDFControlVLAN;
      }
      set {
         this._secondaryDataUplinkVDFControlVLAN = value;
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
   public String NUSuccessfullyAppliedUpgradePackagePassword {
      get {
         return _successfullyAppliedUpgradePackagePassword;
      }
      set {
         this._successfullyAppliedUpgradePackagePassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUSuccessfullyAppliedUpgradePackageURL {
      get {
         return _successfullyAppliedUpgradePackageURL;
      }
      set {
         this._successfullyAppliedUpgradePackageURL = value;
      }
   }

   
   [JsonIgnore]
   public String NUSuccessfullyAppliedUpgradePackageUsername {
      get {
         return _successfullyAppliedUpgradePackageUsername;
      }
      set {
         this._successfullyAppliedUpgradePackageUsername = value;
      }
   }

   
   [JsonIgnore]
   public String NUSuccessfullyAppliedVersion {
      get {
         return _successfullyAppliedVersion;
      }
      set {
         this._successfullyAppliedVersion = value;
      }
   }

   
   [JsonIgnore]
   public bool NUToolboxDeploymentMode {
      get {
         return _toolboxDeploymentMode;
      }
      set {
         this._toolboxDeploymentMode = value;
      }
   }

   
   [JsonIgnore]
   public String NUToolboxGroup {
      get {
         return _toolboxGroup;
      }
      set {
         this._toolboxGroup = value;
      }
   }

   
   [JsonIgnore]
   public String NUToolboxIP {
      get {
         return _toolboxIP;
      }
      set {
         this._toolboxIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUToolboxPassword {
      get {
         return _toolboxPassword;
      }
      set {
         this._toolboxPassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUToolboxUserName {
      get {
         return _toolboxUserName;
      }
      set {
         this._toolboxUserName = value;
      }
   }

   
   [JsonIgnore]
   public String NUUpgradePackagePassword {
      get {
         return _upgradePackagePassword;
      }
      set {
         this._upgradePackagePassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUUpgradePackageURL {
      get {
         return _upgradePackageURL;
      }
      set {
         this._upgradePackageURL = value;
      }
   }

   
   [JsonIgnore]
   public String NUUpgradePackageUsername {
      get {
         return _upgradePackageUsername;
      }
      set {
         this._upgradePackageUsername = value;
      }
   }

   
   [JsonIgnore]
   public long? NUUpgradeScriptTimeLimit {
      get {
         return _upgradeScriptTimeLimit;
      }
      set {
         this._upgradeScriptTimeLimit = value;
      }
   }

   
   [JsonIgnore]
   public String NUUpgradeStatus {
      get {
         return _upgradeStatus;
      }
      set {
         this._upgradeStatus = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUpgradeTimedout {
      get {
         return _upgradeTimedout;
      }
      set {
         this._upgradeTimedout = value;
      }
   }

   
   [JsonIgnore]
   public String NUVCenterIP {
      get {
         return _vCenterIP;
      }
      set {
         this._vCenterIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUVCenterPassword {
      get {
         return _vCenterPassword;
      }
      set {
         this._vCenterPassword = value;
      }
   }

   
   [JsonIgnore]
   public String NUVCenterUser {
      get {
         return _vCenterUser;
      }
      set {
         this._vCenterUser = value;
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
   public String NUVrsId {
      get {
         return _vrsId;
      }
      set {
         this._vrsId = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVrsMarkedAsAvailable {
      get {
         return _vrsMarkedAsAvailable;
      }
      set {
         this._vrsMarkedAsAvailable = value;
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
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public VRSAddressRangesFetcher getVRSAddressRanges() {
      return _vRSAddressRanges;
   }
   
   public VRSMetricsFetcher getVRSMetrics() {
      return _vRSMetrics;
   }
   
   public VRSRedeploymentpoliciesFetcher getVRSRedeploymentpolicies() {
      return _vRSRedeploymentpolicies;
   }
   

   public String toString() {
      return "VCenterHypervisor [" + "ARPReply=" + _ARPReply + ", VRSAgentMOID=" + _VRSAgentMOID + ", VRSAgentName=" + _VRSAgentName + ", VRSConfigurationTimeLimit=" + _VRSConfigurationTimeLimit + ", VRSMetricsID=" + _VRSMetricsID + ", VRSMgmtHostname=" + _VRSMgmtHostname + ", VRSState=" + _VRSState + ", agencyMoid=" + _agencyMoid + ", allowDataDHCP=" + _allowDataDHCP + ", allowMgmtDHCP=" + _allowMgmtDHCP + ", availableNetworks=" + _availableNetworks + ", avrsEnabled=" + _avrsEnabled + ", avrsProfile=" + _avrsProfile + ", configuredMetricsPushInterval=" + _configuredMetricsPushInterval + ", cpuCount=" + _cpuCount + ", customizedScriptURL=" + _customizedScriptURL + ", dataDNS1=" + _dataDNS1 + ", dataDNS2=" + _dataDNS2 + ", dataGateway=" + _dataGateway + ", dataIPAddress=" + _dataIPAddress + ", dataNetmask=" + _dataNetmask + ", dataNetworkPortgroup=" + _dataNetworkPortgroup + ", datapathSyncTimeout=" + _datapathSyncTimeout + ", deploymentCount=" + _deploymentCount + ", description=" + _description + ", destinationMirrorPort=" + _destinationMirrorPort + ", dhcpRelayServer=" + _dhcpRelayServer + ", disableGROOnDatapath=" + _disableGROOnDatapath + ", disableLROOnDatapath=" + _disableLROOnDatapath + ", enableVRSResourceReservation=" + _enableVRSResourceReservation + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", flowEvictionThreshold=" + _flowEvictionThreshold + ", genericSplitActivation=" + _genericSplitActivation + ", hypervisorIP=" + _hypervisorIP + ", hypervisorPassword=" + _hypervisorPassword + ", hypervisorUser=" + _hypervisorUser + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastVRSDeployedDate=" + _lastVRSDeployedDate + ", manageVRSAvailability=" + _manageVRSAvailability + ", managedObjectID=" + _managedObjectID + ", memorySizeInGB=" + _memorySizeInGB + ", metadataServerIP=" + _metadataServerIP + ", metadataServerListenPort=" + _metadataServerListenPort + ", metadataServerPort=" + _metadataServerPort + ", metadataServiceEnabled=" + _metadataServiceEnabled + ", mgmtDNS1=" + _mgmtDNS1 + ", mgmtDNS2=" + _mgmtDNS2 + ", mgmtGateway=" + _mgmtGateway + ", mgmtIPAddress=" + _mgmtIPAddress + ", mgmtNetmask=" + _mgmtNetmask + ", mgmtNetworkPortgroup=" + _mgmtNetworkPortgroup + ", mirrorNetworkPortgroup=" + _mirrorNetworkPortgroup + ", mtu=" + _mtu + ", multiVMSsupport=" + _multiVMSsupport + ", multicastReceiveInterface=" + _multicastReceiveInterface + ", multicastReceiveInterfaceIP=" + _multicastReceiveInterfaceIP + ", multicastReceiveInterfaceNetmask=" + _multicastReceiveInterfaceNetmask + ", multicastReceiveRange=" + _multicastReceiveRange + ", multicastSendInterface=" + _multicastSendInterface + ", multicastSendInterfaceIP=" + _multicastSendInterfaceIP + ", multicastSendInterfaceNetmask=" + _multicastSendInterfaceNetmask + ", multicastSourcePortgroup=" + _multicastSourcePortgroup + ", name=" + _name + ", networkUplinkInterface=" + _networkUplinkInterface + ", networkUplinkInterfaceGateway=" + _networkUplinkInterfaceGateway + ", networkUplinkInterfaceIp=" + _networkUplinkInterfaceIp + ", networkUplinkInterfaceNetmask=" + _networkUplinkInterfaceNetmask + ", nfsLogServer=" + _nfsLogServer + ", nfsMountPath=" + _nfsMountPath + ", novaClientVersion=" + _novaClientVersion + ", novaIdentityURLVersion=" + _novaIdentityURLVersion + ", novaMetadataServiceAuthUrl=" + _novaMetadataServiceAuthUrl + ", novaMetadataServiceEndpoint=" + _novaMetadataServiceEndpoint + ", novaMetadataServicePassword=" + _novaMetadataServicePassword + ", novaMetadataServiceTenant=" + _novaMetadataServiceTenant + ", novaMetadataServiceUsername=" + _novaMetadataServiceUsername + ", novaMetadataSharedSecret=" + _novaMetadataSharedSecret + ", novaOSKeystoneUsername=" + _novaOSKeystoneUsername + ", novaProjectDomainName=" + _novaProjectDomainName + ", novaProjectName=" + _novaProjectName + ", novaRegionName=" + _novaRegionName + ", novaUserDomainName=" + _novaUserDomainName + ", ntpServer1=" + _ntpServer1 + ", ntpServer2=" + _ntpServer2 + ", ovfURL=" + _ovfURL + ", personality=" + _personality + ", portgroupMetadata=" + _portgroupMetadata + ", primaryDataUplinkUnderlayID=" + _primaryDataUplinkUnderlayID + ", primaryDataUplinkVDFControlVLAN=" + _primaryDataUplinkVDFControlVLAN + ", primaryNuageController=" + _primaryNuageController + ", remoteSyslogServerIP=" + _remoteSyslogServerIP + ", remoteSyslogServerPort=" + _remoteSyslogServerPort + ", remoteSyslogServerType=" + _remoteSyslogServerType + ", removedFromVCenterInventory=" + _removedFromVCenterInventory + ", revertiveControllerEnabled=" + _revertiveControllerEnabled + ", revertiveTimer=" + _revertiveTimer + ", scope=" + _scope + ", secondaryDataUplinkDHCPEnabled=" + _secondaryDataUplinkDHCPEnabled + ", secondaryDataUplinkEnabled=" + _secondaryDataUplinkEnabled + ", secondaryDataUplinkIP=" + _secondaryDataUplinkIP + ", secondaryDataUplinkInterface=" + _secondaryDataUplinkInterface + ", secondaryDataUplinkMTU=" + _secondaryDataUplinkMTU + ", secondaryDataUplinkNetmask=" + _secondaryDataUplinkNetmask + ", secondaryDataUplinkPrimaryController=" + _secondaryDataUplinkPrimaryController + ", secondaryDataUplinkSecondaryController=" + _secondaryDataUplinkSecondaryController + ", secondaryDataUplinkUnderlayID=" + _secondaryDataUplinkUnderlayID + ", secondaryDataUplinkVDFControlVLAN=" + _secondaryDataUplinkVDFControlVLAN + ", secondaryNuageController=" + _secondaryNuageController + ", separateDataNetwork=" + _separateDataNetwork + ", siteId=" + _siteId + ", staticRoute=" + _staticRoute + ", staticRouteGateway=" + _staticRouteGateway + ", staticRouteNetmask=" + _staticRouteNetmask + ", successfullyAppliedUpgradePackagePassword=" + _successfullyAppliedUpgradePackagePassword + ", successfullyAppliedUpgradePackageURL=" + _successfullyAppliedUpgradePackageURL + ", successfullyAppliedUpgradePackageUsername=" + _successfullyAppliedUpgradePackageUsername + ", successfullyAppliedVersion=" + _successfullyAppliedVersion + ", toolboxDeploymentMode=" + _toolboxDeploymentMode + ", toolboxGroup=" + _toolboxGroup + ", toolboxIP=" + _toolboxIP + ", toolboxPassword=" + _toolboxPassword + ", toolboxUserName=" + _toolboxUserName + ", upgradePackagePassword=" + _upgradePackagePassword + ", upgradePackageURL=" + _upgradePackageURL + ", upgradePackageUsername=" + _upgradePackageUsername + ", upgradeScriptTimeLimit=" + _upgradeScriptTimeLimit + ", upgradeStatus=" + _upgradeStatus + ", upgradeTimedout=" + _upgradeTimedout + ", vCenterIP=" + _vCenterIP + ", vCenterPassword=" + _vCenterPassword + ", vCenterUser=" + _vCenterUser + ", vRequireNuageMetadata=" + _vRequireNuageMetadata + ", vmNetworkPortgroup=" + _vmNetworkPortgroup + ", vrsId=" + _vrsId + ", vrsMarkedAsAvailable=" + _vrsMarkedAsAvailable + ", vrsPassword=" + _vrsPassword + ", vrsUserName=" + _vrsUserName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vcenterhypervisors";
   }

   public static String getRestName()
   {
	return "vcenterhypervisor";
   }
}
}