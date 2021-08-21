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

public class NSGateway: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ESSHService {DISABLED,ENABLED,INHERITED };
   public enum ETPMStatus {DISABLED,ENABLED_NOT_OPERATIONAL,ENABLED_OPERATIONAL,UNKNOWN };
   public enum EZFBMatchAttribute {HOSTNAME,IP_ADDRESS,MAC_ADDRESS,NONE,NSGATEWAY_ID,SERIAL_NUMBER,UUID };
   public enum EBootstrapStatus {ACTIVE,CERTIFICATE_SIGNED,INACTIVE,NOTIFICATION_APP_REQ_ACK,NOTIFICATION_APP_REQ_SENT,QUARANTINED,REVOKED };
   public enum EConfigurationReloadState {APPLIED,FAILED_TO_APPLY,PENDING,SENT,UNKNOWN };
   public enum EConfigurationStatus {FAILURE,SUCCESS,UNKNOWN };
   public enum EConfigureLoadBalancing {DISABLED,INHERITED };
   public enum EDerivedSSHServiceState {INHERITED_DISABLED,INHERITED_ENABLED,INSTANCE_DISABLED,INSTANCE_ENABLED,UNKNOWN };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFamily {ANY,NSG_AMI,NSG_AZ,NSG_C,NSG_E,NSG_E200,NSG_E300,NSG_V,NSG_X,NSG_X200 };
   public enum EFunctions {GATEWAY,HUB,UBR };
   public enum EInheritedSSHServiceState {DISABLED,ENABLED };
   public enum ENetworkAcceleration {NONE,PERFORMANCE,SESSION_OPTIMIZED,TP_AWARE,VNF_AWARE };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EPersonality {NSG,NSGBR,NSGDUC };
   public enum ESyslogLevel {ALERT,CRITICAL,EMERGENCY,ERROR,INFO,NOTICE,WARNING };
   public enum ETunnelShaping {DISABLED,ENABLED };

   
   [JsonProperty("AARApplicationReleaseDate")]
   protected String _AARApplicationReleaseDate;
   
   [JsonProperty("AARApplicationVersion")]
   protected String _AARApplicationVersion;
   
   [JsonProperty("BIOSReleaseDate")]
   protected String _BIOSReleaseDate;
   
   [JsonProperty("BIOSVersion")]
   protected String _BIOSVersion;
   
   [JsonProperty("CPUCoreAllocation")]
   protected String _CPUCoreAllocation;
   
   [JsonProperty("CPUType")]
   protected String _CPUType;
   
   [JsonProperty("MACAddress")]
   protected String _MACAddress;
   
   [JsonProperty("NATTraversalEnabled")]
   protected bool _NATTraversalEnabled;
   
   [JsonProperty("NSGVersion")]
   protected String _NSGVersion;
   
   [JsonProperty("SKU")]
   protected String _SKU;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("SSHService")]
   protected ESSHService? _SSHService;
   
   [JsonProperty("TCPMSSEnabled")]
   protected bool _TCPMSSEnabled;
   
   [JsonProperty("TCPMaximumSegmentSize")]
   protected long? _TCPMaximumSegmentSize;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("TPMStatus")]
   protected ETPMStatus? _TPMStatus;
   
   [JsonProperty("TPMVersion")]
   protected String _TPMVersion;
   
   [JsonProperty("UUID")]
   protected String _UUID;
   
   [JsonProperty("VSDAARApplicationVersion")]
   protected String _VSDAARApplicationVersion;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ZFBMatchAttribute")]
   protected EZFBMatchAttribute? _ZFBMatchAttribute;
   
   [JsonProperty("ZFBMatchValue")]
   protected String _ZFBMatchValue;
   
   [JsonProperty("associatedGatewaySecurityID")]
   protected String _associatedGatewaySecurityID;
   
   [JsonProperty("associatedGatewaySecurityProfileID")]
   protected String _associatedGatewaySecurityProfileID;
   
   [JsonProperty("associatedNSGInfoID")]
   protected String _associatedNSGInfoID;
   
   [JsonProperty("associatedNSGUpgradeProfileID")]
   protected String _associatedNSGUpgradeProfileID;
   
   [JsonProperty("associatedOverlayManagementProfileID")]
   protected String _associatedOverlayManagementProfileID;
   
   [JsonProperty("autoDiscGatewayID")]
   protected String _autoDiscGatewayID;
   
   [JsonProperty("bootstrapID")]
   protected String _bootstrapID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("bootstrapStatus")]
   protected EBootstrapStatus? _bootstrapStatus;
   
   [JsonProperty("certValidityDays")]
   protected long? _certValidityDays;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configurationReloadState")]
   protected EConfigurationReloadState? _configurationReloadState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configurationStatus")]
   protected EConfigurationStatus? _configurationStatus;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configureLoadBalancing")]
   protected EConfigureLoadBalancing? _configureLoadBalancing;
   
   [JsonProperty("controlTrafficCOSValue")]
   protected long? _controlTrafficCOSValue;
   
   [JsonProperty("controlTrafficDSCPValue")]
   protected long? _controlTrafficDSCPValue;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("datapathID")]
   protected String _datapathID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("derivedSSHServiceState")]
   protected EDerivedSSHServiceState? _derivedSSHServiceState;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("family")]
   protected EFamily? _family;
   
   [JsonProperty("functions")]
   protected System.Collections.Generic.List<EFunctions> _functions;
   
   [JsonProperty("gatewayConfigRawVersion")]
   protected String _gatewayConfigRawVersion;
   
   [JsonProperty("gatewayConfigVersion")]
   protected String _gatewayConfigVersion;
   
   [JsonProperty("gatewayConnected")]
   protected bool _gatewayConnected;
   
   [JsonProperty("hugePageSetting")]
   protected String _hugePageSetting;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("inheritedSSHServiceState")]
   protected EInheritedSSHServiceState? _inheritedSSHServiceState;
   
   [JsonProperty("lastConfigurationReloadTimestamp")]
   protected long? _lastConfigurationReloadTimestamp;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("libraries")]
   protected String _libraries;
   
   [JsonProperty("locationID")]
   protected String _locationID;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("networkAcceleration")]
   protected ENetworkAcceleration? _networkAcceleration;
   
   [JsonProperty("operationMode")]
   protected String _operationMode;
   
   [JsonProperty("operationStatus")]
   protected String _operationStatus;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("pending")]
   protected bool _pending;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("personality")]
   protected EPersonality? _personality;
   
   [JsonProperty("productName")]
   protected String _productName;
   
   [JsonProperty("redundancyGroupID")]
   protected String _redundancyGroupID;
   
   [JsonProperty("serialNumber")]
   protected String _serialNumber;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("syslogLevel")]
   protected ESyslogLevel? _syslogLevel;
   
   [JsonProperty("systemID")]
   protected String _systemID;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   
   [JsonProperty("threatPreventionEnabled")]
   protected bool _threatPreventionEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("tunnelShaping")]
   protected ETunnelShaping? _tunnelShaping;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private BootstrapsFetcher _bootstraps;
   
   [JsonIgnore]
   private BootstrapActivationsFetcher _bootstrapActivations;
   
   [JsonIgnore]
   private CommandsFetcher _commands;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GatewaySecuritiesFetcher _gatewaySecurities;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private InfrastructureConfigsFetcher _infrastructureConfigs;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private LocationsFetcher _locations;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NSGatewayMonitorsFetcher _nSGatewayMonitors;
   
   [JsonIgnore]
   private NSGatewaySummariesFetcher _nSGatewaySummaries;
   
   [JsonIgnore]
   private NSGInfosFetcher _nSGInfos;
   
   [JsonIgnore]
   private NSPortsFetcher _nSPorts;
   
   [JsonIgnore]
   private PatchsFetcher _patchs;
   
   [JsonIgnore]
   private PATNATPoolsFetcher _pATNATPools;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private NSPortInfosFetcher _nSPortInfos;
   
   [JsonIgnore]
   private SubnetsFetcher _subnets;
   
   [JsonIgnore]
   private SupplementalInfraConfigsFetcher _supplementalInfraConfigs;
   
   [JsonIgnore]
   private ThreatPreventionInfosFetcher _threatPreventionInfos;
   
   [JsonIgnore]
   private UnderlayTestsFetcher _underlayTests;
   
   [JsonIgnore]
   private UplinkConnectionsFetcher _uplinkConnections;
   
   [JsonIgnore]
   private VirtualUplinksFetcher _virtualUplinks;
   
   [JsonIgnore]
   private VNFsFetcher _vNFs;
   
   [JsonIgnore]
   private WirelessPortsFetcher _wirelessPorts;
   
   public NSGateway() {
      
      _alarms = new AlarmsFetcher(this);
      
      _bootstraps = new BootstrapsFetcher(this);
      
      _bootstrapActivations = new BootstrapActivationsFetcher(this);
      
      _commands = new CommandsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _gatewaySecurities = new GatewaySecuritiesFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _infrastructureConfigs = new InfrastructureConfigsFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _locations = new LocationsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _nSGatewayMonitors = new NSGatewayMonitorsFetcher(this);
      
      _nSGatewaySummaries = new NSGatewaySummariesFetcher(this);
      
      _nSGInfos = new NSGInfosFetcher(this);
      
      _nSPorts = new NSPortsFetcher(this);
      
      _patchs = new PatchsFetcher(this);
      
      _pATNATPools = new PATNATPoolsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _nSPortInfos = new NSPortInfosFetcher(this);
      
      _subnets = new SubnetsFetcher(this);
      
      _supplementalInfraConfigs = new SupplementalInfraConfigsFetcher(this);
      
      _threatPreventionInfos = new ThreatPreventionInfosFetcher(this);
      
      _underlayTests = new UnderlayTestsFetcher(this);
      
      _uplinkConnections = new UplinkConnectionsFetcher(this);
      
      _virtualUplinks = new VirtualUplinksFetcher(this);
      
      _vNFs = new VNFsFetcher(this);
      
      _wirelessPorts = new WirelessPortsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAARApplicationReleaseDate {
      get {
         return _AARApplicationReleaseDate;
      }
      set {
         this._AARApplicationReleaseDate = value;
      }
   }

   
   [JsonIgnore]
   public String NUAARApplicationVersion {
      get {
         return _AARApplicationVersion;
      }
      set {
         this._AARApplicationVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUBIOSReleaseDate {
      get {
         return _BIOSReleaseDate;
      }
      set {
         this._BIOSReleaseDate = value;
      }
   }

   
   [JsonIgnore]
   public String NUBIOSVersion {
      get {
         return _BIOSVersion;
      }
      set {
         this._BIOSVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUCPUCoreAllocation {
      get {
         return _CPUCoreAllocation;
      }
      set {
         this._CPUCoreAllocation = value;
      }
   }

   
   [JsonIgnore]
   public String NUCPUType {
      get {
         return _CPUType;
      }
      set {
         this._CPUType = value;
      }
   }

   
   [JsonIgnore]
   public String NUMACAddress {
      get {
         return _MACAddress;
      }
      set {
         this._MACAddress = value;
      }
   }

   
   [JsonIgnore]
   public bool NUNATTraversalEnabled {
      get {
         return _NATTraversalEnabled;
      }
      set {
         this._NATTraversalEnabled = value;
      }
   }

   
   [JsonIgnore]
   public String NUNSGVersion {
      get {
         return _NSGVersion;
      }
      set {
         this._NSGVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUSKU {
      get {
         return _SKU;
      }
      set {
         this._SKU = value;
      }
   }

   
   [JsonIgnore]
   public ESSHService? NUSSHService {
      get {
         return _SSHService;
      }
      set {
         this._SSHService = value;
      }
   }

   
   [JsonIgnore]
   public bool NUTCPMSSEnabled {
      get {
         return _TCPMSSEnabled;
      }
      set {
         this._TCPMSSEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTCPMaximumSegmentSize {
      get {
         return _TCPMaximumSegmentSize;
      }
      set {
         this._TCPMaximumSegmentSize = value;
      }
   }

   
   [JsonIgnore]
   public ETPMStatus? NUTPMStatus {
      get {
         return _TPMStatus;
      }
      set {
         this._TPMStatus = value;
      }
   }

   
   [JsonIgnore]
   public String NUTPMVersion {
      get {
         return _TPMVersion;
      }
      set {
         this._TPMVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUUUID {
      get {
         return _UUID;
      }
      set {
         this._UUID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVSDAARApplicationVersion {
      get {
         return _VSDAARApplicationVersion;
      }
      set {
         this._VSDAARApplicationVersion = value;
      }
   }

   
   [JsonIgnore]
   public EZFBMatchAttribute? NUZFBMatchAttribute {
      get {
         return _ZFBMatchAttribute;
      }
      set {
         this._ZFBMatchAttribute = value;
      }
   }

   
   [JsonIgnore]
   public String NUZFBMatchValue {
      get {
         return _ZFBMatchValue;
      }
      set {
         this._ZFBMatchValue = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewaySecurityID {
      get {
         return _associatedGatewaySecurityID;
      }
      set {
         this._associatedGatewaySecurityID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewaySecurityProfileID {
      get {
         return _associatedGatewaySecurityProfileID;
      }
      set {
         this._associatedGatewaySecurityProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGInfoID {
      get {
         return _associatedNSGInfoID;
      }
      set {
         this._associatedNSGInfoID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGUpgradeProfileID {
      get {
         return _associatedNSGUpgradeProfileID;
      }
      set {
         this._associatedNSGUpgradeProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedOverlayManagementProfileID {
      get {
         return _associatedOverlayManagementProfileID;
      }
      set {
         this._associatedOverlayManagementProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAutoDiscGatewayID {
      get {
         return _autoDiscGatewayID;
      }
      set {
         this._autoDiscGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUBootstrapID {
      get {
         return _bootstrapID;
      }
      set {
         this._bootstrapID = value;
      }
   }

   
   [JsonIgnore]
   public EBootstrapStatus? NUBootstrapStatus {
      get {
         return _bootstrapStatus;
      }
      set {
         this._bootstrapStatus = value;
      }
   }

   
   [JsonIgnore]
   public long? NUCertValidityDays {
      get {
         return _certValidityDays;
      }
      set {
         this._certValidityDays = value;
      }
   }

   
   [JsonIgnore]
   public EConfigurationReloadState? NUConfigurationReloadState {
      get {
         return _configurationReloadState;
      }
      set {
         this._configurationReloadState = value;
      }
   }

   
   [JsonIgnore]
   public EConfigurationStatus? NUConfigurationStatus {
      get {
         return _configurationStatus;
      }
      set {
         this._configurationStatus = value;
      }
   }

   
   [JsonIgnore]
   public EConfigureLoadBalancing? NUConfigureLoadBalancing {
      get {
         return _configureLoadBalancing;
      }
      set {
         this._configureLoadBalancing = value;
      }
   }

   
   [JsonIgnore]
   public long? NUControlTrafficCOSValue {
      get {
         return _controlTrafficCOSValue;
      }
      set {
         this._controlTrafficCOSValue = value;
      }
   }

   
   [JsonIgnore]
   public long? NUControlTrafficDSCPValue {
      get {
         return _controlTrafficDSCPValue;
      }
      set {
         this._controlTrafficDSCPValue = value;
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
   public String NUDatapathID {
      get {
         return _datapathID;
      }
      set {
         this._datapathID = value;
      }
   }

   
   [JsonIgnore]
   public EDerivedSSHServiceState? NUDerivedSSHServiceState {
      get {
         return _derivedSSHServiceState;
      }
      set {
         this._derivedSSHServiceState = value;
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
   public EFamily? NUFamily {
      get {
         return _family;
      }
      set {
         this._family = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EFunctions> NUFunctions {
      get {
         return _functions;
      }
      set {
         this._functions = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayConfigRawVersion {
      get {
         return _gatewayConfigRawVersion;
      }
      set {
         this._gatewayConfigRawVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayConfigVersion {
      get {
         return _gatewayConfigVersion;
      }
      set {
         this._gatewayConfigVersion = value;
      }
   }

   
   [JsonIgnore]
   public bool NUGatewayConnected {
      get {
         return _gatewayConnected;
      }
      set {
         this._gatewayConnected = value;
      }
   }

   
   [JsonIgnore]
   public String NUHugePageSetting {
      get {
         return _hugePageSetting;
      }
      set {
         this._hugePageSetting = value;
      }
   }

   
   [JsonIgnore]
   public EInheritedSSHServiceState? NUInheritedSSHServiceState {
      get {
         return _inheritedSSHServiceState;
      }
      set {
         this._inheritedSSHServiceState = value;
      }
   }

   
   [JsonIgnore]
   public long? NULastConfigurationReloadTimestamp {
      get {
         return _lastConfigurationReloadTimestamp;
      }
      set {
         this._lastConfigurationReloadTimestamp = value;
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
   public String NULibraries {
      get {
         return _libraries;
      }
      set {
         this._libraries = value;
      }
   }

   
   [JsonIgnore]
   public String NULocationID {
      get {
         return _locationID;
      }
      set {
         this._locationID = value;
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
   public ENetworkAcceleration? NUNetworkAcceleration {
      get {
         return _networkAcceleration;
      }
      set {
         this._networkAcceleration = value;
      }
   }

   
   [JsonIgnore]
   public String NUOperationMode {
      get {
         return _operationMode;
      }
      set {
         this._operationMode = value;
      }
   }

   
   [JsonIgnore]
   public String NUOperationStatus {
      get {
         return _operationStatus;
      }
      set {
         this._operationStatus = value;
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
   public bool NUPending {
      get {
         return _pending;
      }
      set {
         this._pending = value;
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
   public EPersonality? NUPersonality {
      get {
         return _personality;
      }
      set {
         this._personality = value;
      }
   }

   
   [JsonIgnore]
   public String NUProductName {
      get {
         return _productName;
      }
      set {
         this._productName = value;
      }
   }

   
   [JsonIgnore]
   public String NURedundancyGroupID {
      get {
         return _redundancyGroupID;
      }
      set {
         this._redundancyGroupID = value;
      }
   }

   
   [JsonIgnore]
   public String NUSerialNumber {
      get {
         return _serialNumber;
      }
      set {
         this._serialNumber = value;
      }
   }

   
   [JsonIgnore]
   public ESyslogLevel? NUSyslogLevel {
      get {
         return _syslogLevel;
      }
      set {
         this._syslogLevel = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystemID {
      get {
         return _systemID;
      }
      set {
         this._systemID = value;
      }
   }

   
   [JsonIgnore]
   public String NUTemplateID {
      get {
         return _templateID;
      }
      set {
         this._templateID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUThreatPreventionEnabled {
      get {
         return _threatPreventionEnabled;
      }
      set {
         this._threatPreventionEnabled = value;
      }
   }

   
   [JsonIgnore]
   public ETunnelShaping? NUTunnelShaping {
      get {
         return _tunnelShaping;
      }
      set {
         this._tunnelShaping = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public BootstrapsFetcher getBootstraps() {
      return _bootstraps;
   }
   
   public BootstrapActivationsFetcher getBootstrapActivations() {
      return _bootstrapActivations;
   }
   
   public CommandsFetcher getCommands() {
      return _commands;
   }
   
   public EnterprisePermissionsFetcher getEnterprisePermissions() {
      return _enterprisePermissions;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GatewaySecuritiesFetcher getGatewaySecurities() {
      return _gatewaySecurities;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public InfrastructureConfigsFetcher getInfrastructureConfigs() {
      return _infrastructureConfigs;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public LocationsFetcher getLocations() {
      return _locations;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public NSGatewayMonitorsFetcher getNSGatewayMonitors() {
      return _nSGatewayMonitors;
   }
   
   public NSGatewaySummariesFetcher getNSGatewaySummaries() {
      return _nSGatewaySummaries;
   }
   
   public NSGInfosFetcher getNSGInfos() {
      return _nSGInfos;
   }
   
   public NSPortsFetcher getNSPorts() {
      return _nSPorts;
   }
   
   public PatchsFetcher getPatchs() {
      return _patchs;
   }
   
   public PATNATPoolsFetcher getPATNATPools() {
      return _pATNATPools;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public NSPortInfosFetcher getNSPortInfos() {
      return _nSPortInfos;
   }
   
   public SubnetsFetcher getSubnets() {
      return _subnets;
   }
   
   public SupplementalInfraConfigsFetcher getSupplementalInfraConfigs() {
      return _supplementalInfraConfigs;
   }
   
   public ThreatPreventionInfosFetcher getThreatPreventionInfos() {
      return _threatPreventionInfos;
   }
   
   public UnderlayTestsFetcher getUnderlayTests() {
      return _underlayTests;
   }
   
   public UplinkConnectionsFetcher getUplinkConnections() {
      return _uplinkConnections;
   }
   
   public VirtualUplinksFetcher getVirtualUplinks() {
      return _virtualUplinks;
   }
   
   public VNFsFetcher getVNFs() {
      return _vNFs;
   }
   
   public WirelessPortsFetcher getWirelessPorts() {
      return _wirelessPorts;
   }
   

   public String toString() {
      return "NSGateway [" + "AARApplicationReleaseDate=" + _AARApplicationReleaseDate + ", AARApplicationVersion=" + _AARApplicationVersion + ", BIOSReleaseDate=" + _BIOSReleaseDate + ", BIOSVersion=" + _BIOSVersion + ", CPUCoreAllocation=" + _CPUCoreAllocation + ", CPUType=" + _CPUType + ", MACAddress=" + _MACAddress + ", NATTraversalEnabled=" + _NATTraversalEnabled + ", NSGVersion=" + _NSGVersion + ", SKU=" + _SKU + ", SSHService=" + _SSHService + ", TCPMSSEnabled=" + _TCPMSSEnabled + ", TCPMaximumSegmentSize=" + _TCPMaximumSegmentSize + ", TPMStatus=" + _TPMStatus + ", TPMVersion=" + _TPMVersion + ", UUID=" + _UUID + ", VSDAARApplicationVersion=" + _VSDAARApplicationVersion + ", ZFBMatchAttribute=" + _ZFBMatchAttribute + ", ZFBMatchValue=" + _ZFBMatchValue + ", associatedGatewaySecurityID=" + _associatedGatewaySecurityID + ", associatedGatewaySecurityProfileID=" + _associatedGatewaySecurityProfileID + ", associatedNSGInfoID=" + _associatedNSGInfoID + ", associatedNSGUpgradeProfileID=" + _associatedNSGUpgradeProfileID + ", associatedOverlayManagementProfileID=" + _associatedOverlayManagementProfileID + ", autoDiscGatewayID=" + _autoDiscGatewayID + ", bootstrapID=" + _bootstrapID + ", bootstrapStatus=" + _bootstrapStatus + ", certValidityDays=" + _certValidityDays + ", configurationReloadState=" + _configurationReloadState + ", configurationStatus=" + _configurationStatus + ", configureLoadBalancing=" + _configureLoadBalancing + ", controlTrafficCOSValue=" + _controlTrafficCOSValue + ", controlTrafficDSCPValue=" + _controlTrafficDSCPValue + ", creationDate=" + _creationDate + ", datapathID=" + _datapathID + ", derivedSSHServiceState=" + _derivedSSHServiceState + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", family=" + _family + ", functions=" + _functions + ", gatewayConfigRawVersion=" + _gatewayConfigRawVersion + ", gatewayConfigVersion=" + _gatewayConfigVersion + ", gatewayConnected=" + _gatewayConnected + ", hugePageSetting=" + _hugePageSetting + ", inheritedSSHServiceState=" + _inheritedSSHServiceState + ", lastConfigurationReloadTimestamp=" + _lastConfigurationReloadTimestamp + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", libraries=" + _libraries + ", locationID=" + _locationID + ", name=" + _name + ", networkAcceleration=" + _networkAcceleration + ", operationMode=" + _operationMode + ", operationStatus=" + _operationStatus + ", owner=" + _owner + ", pending=" + _pending + ", permittedAction=" + _permittedAction + ", personality=" + _personality + ", productName=" + _productName + ", redundancyGroupID=" + _redundancyGroupID + ", serialNumber=" + _serialNumber + ", syslogLevel=" + _syslogLevel + ", systemID=" + _systemID + ", templateID=" + _templateID + ", threatPreventionEnabled=" + _threatPreventionEnabled + ", tunnelShaping=" + _tunnelShaping + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "nsgateways";
   }

   public static String getRestName()
   {
	return "nsgateway";
   }
}
}