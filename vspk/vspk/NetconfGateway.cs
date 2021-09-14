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

public class NetconfGateway: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EZFBMatchAttribute {HOSTNAME,IP_ADDRESS,MAC_ADDRESS,NONE,SERIAL_NUMBER,UUID };
   public enum EBootstrapStatus {ACTIVE,CERTIFICATE_SIGNED,INACTIVE,MIGRATING,NOTIFICATION_APP_REQ_ACK,NOTIFICATION_APP_REQ_SENT,QUARANTINED,REVOKED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFamily {ANY,NSG_AMI,NSG_AZ,NSG_C,NSG_E,NSG_E200,NSG_E300,NSG_V,NSG_X,NSG_X200,VRS };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EPersonality {DC7X50,EVDF,EVDFB,HARDWARE_VTEP,NETCONF_7X50,NETCONF_THIRDPARTY_HW_VTEP,NUAGE_210_WBX_32_Q,NUAGE_210_WBX_48_S,OTHER,UNMANAGED_GATEWAY,VDFG,VRSB,VRSG,VSA,VSG };
   public enum EVendor {CISCO,NOKIA };

   
   [JsonProperty("BIOSReleaseDate")]
   protected String _BIOSReleaseDate;
   
   [JsonProperty("BIOSVersion")]
   protected String _BIOSVersion;
   
   [JsonProperty("CPUType")]
   protected String _CPUType;
   
   [JsonProperty("MACAddress")]
   protected String _MACAddress;
   
   [JsonProperty("UUID")]
   protected String _UUID;
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
   
   [JsonProperty("associatedNetconfProfileID")]
   protected String _associatedNetconfProfileID;
   
   [JsonProperty("autoDiscGatewayID")]
   protected String _autoDiscGatewayID;
   
   [JsonProperty("bootstrapID")]
   protected String _bootstrapID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("bootstrapStatus")]
   protected EBootstrapStatus? _bootstrapStatus;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("datapathID")]
   protected String _datapathID;
   
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
   
   [JsonProperty("gatewayConnected")]
   protected bool _gatewayConnected;
   
   [JsonProperty("gatewayModel")]
   protected String _gatewayModel;
   
   [JsonProperty("gatewayVersion")]
   protected String _gatewayVersion;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("libraries")]
   protected String _libraries;
   
   [JsonProperty("locationID")]
   protected String _locationID;
   
   [JsonProperty("managementID")]
   protected String _managementID;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("patches")]
   protected String _patches;
   
   [JsonProperty("peer")]
   protected String _peer;
   
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
   
   [JsonProperty("systemID")]
   protected String _systemID;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   
   [JsonProperty("useGatewayVLANVNID")]
   protected bool _useGatewayVLANVNID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("vendor")]
   protected EVendor? _vendor;
   
   [JsonProperty("vtep")]
   protected String _vtep;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private BootstrapsFetcher _bootstraps;
   
   [JsonIgnore]
   private BootstrapActivationsFetcher _bootstrapActivations;
   
   [JsonIgnore]
   private DeploymentFailuresFetcher _deploymentFailures;
   
   [JsonIgnore]
   private DomainsFetcher _domains;
   
   [JsonIgnore]
   private EgressProfilesFetcher _egressProfiles;
   
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
   private IngressProfilesFetcher _ingressProfiles;
   
   [JsonIgnore]
   private IPFilterProfilesFetcher _iPFilterProfiles;
   
   [JsonIgnore]
   private IPv6FilterProfilesFetcher _iPv6FilterProfiles;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private L2DomainsFetcher _l2Domains;
   
   [JsonIgnore]
   private LocationsFetcher _locations;
   
   [JsonIgnore]
   private MACFilterProfilesFetcher _mACFilterProfiles;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PATNATPoolsFetcher _pATNATPools;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private PortsFetcher _ports;
   
   [JsonIgnore]
   private SAPEgressQoSProfilesFetcher _sAPEgressQoSProfiles;
   
   [JsonIgnore]
   private SAPIngressQoSProfilesFetcher _sAPIngressQoSProfiles;
   
   [JsonIgnore]
   private WANServicesFetcher _wANServices;
   
   [JsonIgnore]
   private SubnetsFetcher _subnets;
   
   public NetconfGateway() {
      
      _alarms = new AlarmsFetcher(this);
      
      _bootstraps = new BootstrapsFetcher(this);
      
      _bootstrapActivations = new BootstrapActivationsFetcher(this);
      
      _deploymentFailures = new DeploymentFailuresFetcher(this);
      
      _domains = new DomainsFetcher(this);
      
      _egressProfiles = new EgressProfilesFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _gatewaySecurities = new GatewaySecuritiesFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _infrastructureConfigs = new InfrastructureConfigsFetcher(this);
      
      _ingressProfiles = new IngressProfilesFetcher(this);
      
      _iPFilterProfiles = new IPFilterProfilesFetcher(this);
      
      _iPv6FilterProfiles = new IPv6FilterProfilesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _l2Domains = new L2DomainsFetcher(this);
      
      _locations = new LocationsFetcher(this);
      
      _mACFilterProfiles = new MACFilterProfilesFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _pATNATPools = new PATNATPoolsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _ports = new PortsFetcher(this);
      
      _sAPEgressQoSProfiles = new SAPEgressQoSProfilesFetcher(this);
      
      _sAPIngressQoSProfiles = new SAPIngressQoSProfilesFetcher(this);
      
      _wANServices = new WANServicesFetcher(this);
      
      _subnets = new SubnetsFetcher(this);
      
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
   public String NUUUID {
      get {
         return _UUID;
      }
      set {
         this._UUID = value;
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
   public String NUAssociatedNetconfProfileID {
      get {
         return _associatedNetconfProfileID;
      }
      set {
         this._associatedNetconfProfileID = value;
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
   public bool NUGatewayConnected {
      get {
         return _gatewayConnected;
      }
      set {
         this._gatewayConnected = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayModel {
      get {
         return _gatewayModel;
      }
      set {
         this._gatewayModel = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayVersion {
      get {
         return _gatewayVersion;
      }
      set {
         this._gatewayVersion = value;
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
   public String NUManagementID {
      get {
         return _managementID;
      }
      set {
         this._managementID = value;
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
   public String NUPatches {
      get {
         return _patches;
      }
      set {
         this._patches = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeer {
      get {
         return _peer;
      }
      set {
         this._peer = value;
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
   public bool NUUseGatewayVLANVNID {
      get {
         return _useGatewayVLANVNID;
      }
      set {
         this._useGatewayVLANVNID = value;
      }
   }

   
   [JsonIgnore]
   public EVendor? NUVendor {
      get {
         return _vendor;
      }
      set {
         this._vendor = value;
      }
   }

   
   [JsonIgnore]
   public String NUVtep {
      get {
         return _vtep;
      }
      set {
         this._vtep = value;
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
   
   public DeploymentFailuresFetcher getDeploymentFailures() {
      return _deploymentFailures;
   }
   
   public DomainsFetcher getDomains() {
      return _domains;
   }
   
   public EgressProfilesFetcher getEgressProfiles() {
      return _egressProfiles;
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
   
   public IngressProfilesFetcher getIngressProfiles() {
      return _ingressProfiles;
   }
   
   public IPFilterProfilesFetcher getIPFilterProfiles() {
      return _iPFilterProfiles;
   }
   
   public IPv6FilterProfilesFetcher getIPv6FilterProfiles() {
      return _iPv6FilterProfiles;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public L2DomainsFetcher getL2Domains() {
      return _l2Domains;
   }
   
   public LocationsFetcher getLocations() {
      return _locations;
   }
   
   public MACFilterProfilesFetcher getMACFilterProfiles() {
      return _mACFilterProfiles;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PATNATPoolsFetcher getPATNATPools() {
      return _pATNATPools;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public PortsFetcher getPorts() {
      return _ports;
   }
   
   public SAPEgressQoSProfilesFetcher getSAPEgressQoSProfiles() {
      return _sAPEgressQoSProfiles;
   }
   
   public SAPIngressQoSProfilesFetcher getSAPIngressQoSProfiles() {
      return _sAPIngressQoSProfiles;
   }
   
   public WANServicesFetcher getWANServices() {
      return _wANServices;
   }
   
   public SubnetsFetcher getSubnets() {
      return _subnets;
   }
   

   public String toString() {
      return "NetconfGateway [" + "BIOSReleaseDate=" + _BIOSReleaseDate + ", BIOSVersion=" + _BIOSVersion + ", CPUType=" + _CPUType + ", MACAddress=" + _MACAddress + ", UUID=" + _UUID + ", ZFBMatchAttribute=" + _ZFBMatchAttribute + ", ZFBMatchValue=" + _ZFBMatchValue + ", associatedGatewaySecurityID=" + _associatedGatewaySecurityID + ", associatedGatewaySecurityProfileID=" + _associatedGatewaySecurityProfileID + ", associatedNSGInfoID=" + _associatedNSGInfoID + ", associatedNetconfProfileID=" + _associatedNetconfProfileID + ", autoDiscGatewayID=" + _autoDiscGatewayID + ", bootstrapID=" + _bootstrapID + ", bootstrapStatus=" + _bootstrapStatus + ", creationDate=" + _creationDate + ", datapathID=" + _datapathID + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", family=" + _family + ", gatewayConnected=" + _gatewayConnected + ", gatewayModel=" + _gatewayModel + ", gatewayVersion=" + _gatewayVersion + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", libraries=" + _libraries + ", locationID=" + _locationID + ", managementID=" + _managementID + ", name=" + _name + ", owner=" + _owner + ", patches=" + _patches + ", peer=" + _peer + ", pending=" + _pending + ", permittedAction=" + _permittedAction + ", personality=" + _personality + ", productName=" + _productName + ", redundancyGroupID=" + _redundancyGroupID + ", serialNumber=" + _serialNumber + ", systemID=" + _systemID + ", templateID=" + _templateID + ", useGatewayVLANVNID=" + _useGatewayVLANVNID + ", vendor=" + _vendor + ", vtep=" + _vtep + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "netconfgateways";
   }

   public static String getRestName()
   {
	return "netconfgateway";
   }
}
}