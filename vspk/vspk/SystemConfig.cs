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

public class SystemConfig: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ECsprootAuthenticationMethod {LDAP,LOCAL };
   public enum EDomainTunnelType {GRE,VLAN,VXLAN };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EGroupKeyDefaultSEKPayloadEncryptionAlgorithm {RSA_1024 };
   public enum EGroupKeyDefaultSEKPayloadSigningAlgorithm {SHA1withRSA,SHA224withRSA,SHA256withRSA,SHA384withRSA,SHA512withRSA };
   public enum EGroupKeyDefaultSeedPayloadAuthenticationAlgorithm {HMAC_SHA1,HMAC_SHA256,HMAC_SHA512 };
   public enum EGroupKeyDefaultSeedPayloadEncryptionAlgorithm {AES_128_CBC,AES_256_CBC,TRIPLE_DES_CBC };
   public enum EGroupKeyDefaultSeedPayloadSigningAlgorithm {SHA1withRSA,SHA224withRSA,SHA256withRSA,SHA384withRSA,SHA512withRSA };
   public enum EGroupKeyDefaultTrafficAuthenticationAlgorithm {HMAC_MD5,HMAC_SHA1,HMAC_SHA256,HMAC_SHA384,HMAC_SHA512 };
   public enum EGroupKeyDefaultTrafficEncryptionAlgorithm {AES_128_CBC,AES_192_CBC,AES_256_CBC,TRIPLE_DES_CBC };
   public enum ELastExecutedMigrationPhase {EXPAND,REDUCE };
   public enum ESystemAvatarType {BASE64,COMPUTEDURL,URL };

   
   [JsonProperty("AARFlowStatsInterval")]
   protected long? _AARFlowStatsInterval;
   
   [JsonProperty("AARProbeStatsInterval")]
   protected long? _AARProbeStatsInterval;
   
   [JsonProperty("ACLAllowOrigin")]
   protected String _ACLAllowOrigin;
   
   [JsonProperty("ADGatewayPurgeTime")]
   protected long? _ADGatewayPurgeTime;
   
   [JsonProperty("APIKeyRenewalInterval")]
   protected long? _APIKeyRenewalInterval;
   
   [JsonProperty("APIKeyValidity")]
   protected long? _APIKeyValidity;
   
   [JsonProperty("ASNumber")]
   protected long? _ASNumber;
   
   [JsonProperty("DHCPOptionSize")]
   protected long? _DHCPOptionSize;
   
   [JsonProperty("ECMPCount")]
   protected long? _ECMPCount;
   
   [JsonProperty("EVPNBGPCommunityTagASNumber")]
   protected long? _EVPNBGPCommunityTagASNumber;
   
   [JsonProperty("EVPNBGPCommunityTagLowerLimit")]
   protected long? _EVPNBGPCommunityTagLowerLimit;
   
   [JsonProperty("EVPNBGPCommunityTagUpperLimit")]
   protected long? _EVPNBGPCommunityTagUpperLimit;
   
   [JsonProperty("IPv6ExtendedPrefixesEnabled")]
   protected bool _IPv6ExtendedPrefixesEnabled;
   
   [JsonProperty("LDAPSyncInterval")]
   protected long? _LDAPSyncInterval;
   
   [JsonProperty("LDAPTrustStoreCertifcate")]
   protected String _LDAPTrustStoreCertifcate;
   
   [JsonProperty("LDAPTrustStorePassword")]
   protected String _LDAPTrustStorePassword;
   
   [JsonProperty("LRUCacheSizePerSubnet")]
   protected long? _LRUCacheSizePerSubnet;
   
   [JsonProperty("NSGUplinkHoldDownTimer")]
   protected long? _NSGUplinkHoldDownTimer;
   
   [JsonProperty("PGIDLowerLimit")]
   protected long? _PGIDLowerLimit;
   
   [JsonProperty("PGIDUpperLimit")]
   protected long? _PGIDUpperLimit;
   
   [JsonProperty("RDLowerLimit")]
   protected long? _RDLowerLimit;
   
   [JsonProperty("RDPublicNetworkLowerLimit")]
   protected long? _RDPublicNetworkLowerLimit;
   
   [JsonProperty("RDPublicNetworkUpperLimit")]
   protected long? _RDPublicNetworkUpperLimit;
   
   [JsonProperty("RDUpperLimit")]
   protected long? _RDUpperLimit;
   
   [JsonProperty("RTLowerLimit")]
   protected long? _RTLowerLimit;
   
   [JsonProperty("RTPublicNetworkLowerLimit")]
   protected long? _RTPublicNetworkLowerLimit;
   
   [JsonProperty("RTPublicNetworkUpperLimit")]
   protected long? _RTPublicNetworkUpperLimit;
   
   [JsonProperty("RTUpperLimit")]
   protected long? _RTUpperLimit;
   
   [JsonProperty("SaaSApplicationsPublishDate")]
   protected String _SaaSApplicationsPublishDate;
   
   [JsonProperty("VLANIDLowerLimit")]
   protected long? _VLANIDLowerLimit;
   
   [JsonProperty("VLANIDUpperLimit")]
   protected long? _VLANIDUpperLimit;
   
   [JsonProperty("VMCacheSize")]
   protected long? _VMCacheSize;
   
   [JsonProperty("VMPurgeTime")]
   protected long? _VMPurgeTime;
   
   [JsonProperty("VMResyncDeletionWaitTime")]
   protected long? _VMResyncDeletionWaitTime;
   
   [JsonProperty("VMResyncOutstandingInterval")]
   protected long? _VMResyncOutstandingInterval;
   
   [JsonProperty("VMUnreachableCleanupTime")]
   protected long? _VMUnreachableCleanupTime;
   
   [JsonProperty("VMUnreachableTime")]
   protected long? _VMUnreachableTime;
   
   [JsonProperty("VNFTaskTimeout")]
   protected long? _VNFTaskTimeout;
   
   [JsonProperty("VNIDLowerLimit")]
   protected long? _VNIDLowerLimit;
   
   [JsonProperty("VNIDPublicNetworkLowerLimit")]
   protected long? _VNIDPublicNetworkLowerLimit;
   
   [JsonProperty("VNIDPublicNetworkUpperLimit")]
   protected long? _VNIDPublicNetworkUpperLimit;
   
   [JsonProperty("VNIDUpperLimit")]
   protected long? _VNIDUpperLimit;
   
   [JsonProperty("VPortInitStatefulTimer")]
   protected long? _VPortInitStatefulTimer;
   
   [JsonProperty("VSCOnSameVersionAsVSD")]
   protected bool _VSCOnSameVersionAsVSD;
   
   [JsonProperty("VSDAARApplicationVersion")]
   protected String _VSDAARApplicationVersion;
   
   [JsonProperty("VSDAARApplicationVersionPublishDate")]
   protected String _VSDAARApplicationVersionPublishDate;
   
   [JsonProperty("VSDReadOnlyMode")]
   protected bool _VSDReadOnlyMode;
   
   [JsonProperty("VSDUpgradeIsComplete")]
   protected bool _VSDUpgradeIsComplete;
   
   [JsonProperty("VSSStatsInterval")]
   protected long? _VSSStatsInterval;
   
   [JsonProperty("ZFBBootstrapEnabled")]
   protected bool _ZFBBootstrapEnabled;
   
   [JsonProperty("ZFBRequestRetryTimer")]
   protected long? _ZFBRequestRetryTimer;
   
   [JsonProperty("ZFBSchedulerStaleRequestTimeout")]
   protected long? _ZFBSchedulerStaleRequestTimeout;
   
   [JsonProperty("accumulateLicensesEnabled")]
   protected bool _accumulateLicensesEnabled;
   
   [JsonProperty("alarmsMaxPerObject")]
   protected long? _alarmsMaxPerObject;
   
   [JsonProperty("allowEnterpriseAvatarOnNSG")]
   protected bool _allowEnterpriseAvatarOnNSG;
   
   [JsonProperty("attachProbeToIPsecNPM")]
   protected bool _attachProbeToIPsecNPM;
   
   [JsonProperty("attachProbeToVXLANNPM")]
   protected bool _attachProbeToVXLANNPM;
   
   [JsonProperty("avatarBasePath")]
   protected String _avatarBasePath;
   
   [JsonProperty("avatarBaseURL")]
   protected String _avatarBaseURL;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("csprootAuthenticationMethod")]
   protected ECsprootAuthenticationMethod? _csprootAuthenticationMethod;
   
   [JsonProperty("customerIDUpperLimit")]
   protected long? _customerIDUpperLimit;
   
   [JsonProperty("customerKey")]
   protected String _customerKey;
   
   [JsonProperty("deniedFlowCollectionEnabled")]
   protected bool _deniedFlowCollectionEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("domainTunnelType")]
   protected EDomainTunnelType? _domainTunnelType;
   
   [JsonProperty("dynamicWANServiceDiffTime")]
   protected long? _dynamicWANServiceDiffTime;
   
   [JsonProperty("ejbcaNSGCertificateProfile")]
   protected String _ejbcaNSGCertificateProfile;
   
   [JsonProperty("ejbcaNSGEndEntityProfile")]
   protected String _ejbcaNSGEndEntityProfile;
   
   [JsonProperty("ejbcaOCSPResponderCN")]
   protected String _ejbcaOCSPResponderCN;
   
   [JsonProperty("ejbcaOCSPResponderURI")]
   protected String _ejbcaOCSPResponderURI;
   
   [JsonProperty("ejbcaVspRootCa")]
   protected String _ejbcaVspRootCa;
   
   [JsonProperty("elasticClusterName")]
   protected String _elasticClusterName;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("embeddedMetadataSize")]
   protected long? _embeddedMetadataSize;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("esiID")]
   protected long? _esiID;
   
   [JsonProperty("eventLogCleanupInterval")]
   protected long? _eventLogCleanupInterval;
   
   [JsonProperty("eventLogEntryMaxAge")]
   protected long? _eventLogEntryMaxAge;
   
   [JsonProperty("eventProcessorInterval")]
   protected long? _eventProcessorInterval;
   
   [JsonProperty("eventProcessorMaxEventsCount")]
   protected long? _eventProcessorMaxEventsCount;
   
   [JsonProperty("eventProcessorTimeout")]
   protected long? _eventProcessorTimeout;
   
   [JsonProperty("explicitACLMatchingEnabled")]
   protected bool _explicitACLMatchingEnabled;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("fecFeedbackTimer")]
   protected long? _fecFeedbackTimer;
   
   [JsonProperty("flowCollectionEnabled")]
   protected bool _flowCollectionEnabled;
   
   [JsonProperty("flowDropTimeout")]
   protected long? _flowDropTimeout;
   
   [JsonProperty("gatewayProbeInterval")]
   protected long? _gatewayProbeInterval;
   
   [JsonProperty("gatewayProbeWindow")]
   protected long? _gatewayProbeWindow;
   
   [JsonProperty("gatewayRebalancingInterval")]
   protected long? _gatewayRebalancingInterval;
   
   [JsonProperty("globalMACAddress")]
   protected String _globalMACAddress;
   
   [JsonProperty("googleMapsAPIKey")]
   protected String _googleMapsAPIKey;
   
   [JsonProperty("groupKeyDefaultSEKGenerationInterval")]
   protected long? _groupKeyDefaultSEKGenerationInterval;
   
   [JsonProperty("groupKeyDefaultSEKLifetime")]
   protected long? _groupKeyDefaultSEKLifetime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("groupKeyDefaultSEKPayloadEncryptionAlgorithm")]
   protected EGroupKeyDefaultSEKPayloadEncryptionAlgorithm? _groupKeyDefaultSEKPayloadEncryptionAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("groupKeyDefaultSEKPayloadSigningAlgorithm")]
   protected EGroupKeyDefaultSEKPayloadSigningAlgorithm? _groupKeyDefaultSEKPayloadSigningAlgorithm;
   
   [JsonProperty("groupKeyDefaultSeedGenerationInterval")]
   protected long? _groupKeyDefaultSeedGenerationInterval;
   
   [JsonProperty("groupKeyDefaultSeedLifetime")]
   protected long? _groupKeyDefaultSeedLifetime;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("groupKeyDefaultSeedPayloadAuthenticationAlgorithm")]
   protected EGroupKeyDefaultSeedPayloadAuthenticationAlgorithm? _groupKeyDefaultSeedPayloadAuthenticationAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("groupKeyDefaultSeedPayloadEncryptionAlgorithm")]
   protected EGroupKeyDefaultSeedPayloadEncryptionAlgorithm? _groupKeyDefaultSeedPayloadEncryptionAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("groupKeyDefaultSeedPayloadSigningAlgorithm")]
   protected EGroupKeyDefaultSeedPayloadSigningAlgorithm? _groupKeyDefaultSeedPayloadSigningAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("groupKeyDefaultTrafficAuthenticationAlgorithm")]
   protected EGroupKeyDefaultTrafficAuthenticationAlgorithm? _groupKeyDefaultTrafficAuthenticationAlgorithm;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("groupKeyDefaultTrafficEncryptionAlgorithm")]
   protected EGroupKeyDefaultTrafficEncryptionAlgorithm? _groupKeyDefaultTrafficEncryptionAlgorithm;
   
   [JsonProperty("groupKeyDefaultTrafficEncryptionKeyLifetime")]
   protected long? _groupKeyDefaultTrafficEncryptionKeyLifetime;
   
   [JsonProperty("groupKeyGenerationIntervalOnForcedReKey")]
   protected long? _groupKeyGenerationIntervalOnForcedReKey;
   
   [JsonProperty("groupKeyGenerationIntervalOnRevoke")]
   protected long? _groupKeyGenerationIntervalOnRevoke;
   
   [JsonProperty("groupKeyMinimumSEKGenerationInterval")]
   protected long? _groupKeyMinimumSEKGenerationInterval;
   
   [JsonProperty("groupKeyMinimumSEKLifetime")]
   protected long? _groupKeyMinimumSEKLifetime;
   
   [JsonProperty("groupKeyMinimumSeedGenerationInterval")]
   protected long? _groupKeyMinimumSeedGenerationInterval;
   
   [JsonProperty("groupKeyMinimumSeedLifetime")]
   protected long? _groupKeyMinimumSeedLifetime;
   
   [JsonProperty("groupKeyMinimumTrafficEncryptionKeyLifetime")]
   protected long? _groupKeyMinimumTrafficEncryptionKeyLifetime;
   
   [JsonProperty("importedSaaSApplicationsVersion")]
   protected String _importedSaaSApplicationsVersion;
   
   [JsonProperty("inactiveTimeout")]
   protected long? _inactiveTimeout;
   
   [JsonProperty("infrastructureBGPASNumber")]
   protected long? _infrastructureBGPASNumber;
   
   [JsonProperty("interfaceIdLowerLimit")]
   protected long? _interfaceIdLowerLimit;
   
   [JsonProperty("interfaceIdUpperLimit")]
   protected long? _interfaceIdUpperLimit;
   
   [JsonProperty("keyServerMonitorEnabled")]
   protected bool _keyServerMonitorEnabled;
   
   [JsonProperty("keyServerVSDDataSynchronizationInterval")]
   protected long? _keyServerVSDDataSynchronizationInterval;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("lastExecutedMigrationPhase")]
   protected ELastExecutedMigrationPhase? _lastExecutedMigrationPhase;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("maxFailedLogins")]
   protected long? _maxFailedLogins;
   
   [JsonProperty("maxResponse")]
   protected long? _maxResponse;
   
   [JsonProperty("nsgBootstrapEndpoint")]
   protected String _nsgBootstrapEndpoint;
   
   [JsonProperty("nsgConfigEndpoint")]
   protected String _nsgConfigEndpoint;
   
   [JsonProperty("nsgLocalUiUrl")]
   protected String _nsgLocalUiUrl;
   
   [JsonProperty("offsetCustomerID")]
   protected long? _offsetCustomerID;
   
   [JsonProperty("offsetServiceID")]
   protected long? _offsetServiceID;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("pageMaxSize")]
   protected long? _pageMaxSize;
   
   [JsonProperty("pageSize")]
   protected long? _pageSize;
   
   [JsonProperty("perDomainVlanIdEnabled")]
   protected bool _perDomainVlanIdEnabled;
   
   [JsonProperty("postProcessorThreadsCount")]
   protected long? _postProcessorThreadsCount;
   
   [JsonProperty("rbacEnabled")]
   protected bool _rbacEnabled;
   
   [JsonProperty("secondaryASNumber")]
   protected long? _secondaryASNumber;
   
   [JsonProperty("secondaryRTLowerLimit")]
   protected long? _secondaryRTLowerLimit;
   
   [JsonProperty("secondaryRTUpperLimit")]
   protected long? _secondaryRTUpperLimit;
   
   [JsonProperty("serviceIDUpperLimit")]
   protected long? _serviceIDUpperLimit;
   
   [JsonProperty("stackTraceEnabled")]
   protected bool _stackTraceEnabled;
   
   [JsonProperty("statefulACLNonTCPTimeout")]
   protected long? _statefulACLNonTCPTimeout;
   
   [JsonProperty("statefulACLTCPTimeout")]
   protected long? _statefulACLTCPTimeout;
   
   [JsonProperty("staticWANServicePurgeTime")]
   protected long? _staticWANServicePurgeTime;
   
   [JsonProperty("statisticsEnabled")]
   protected bool _statisticsEnabled;
   
   [JsonProperty("statsCollectorAddress")]
   protected String _statsCollectorAddress;
   
   [JsonProperty("statsCollectorPort")]
   protected String _statsCollectorPort;
   
   [JsonProperty("statsCollectorProtoBufPort")]
   protected String _statsCollectorProtoBufPort;
   
   [JsonProperty("statsDatabaseProxy")]
   protected String _statsDatabaseProxy;
   
   [JsonProperty("statsMaxDataPoints")]
   protected long? _statsMaxDataPoints;
   
   [JsonProperty("statsMinDuration")]
   protected long? _statsMinDuration;
   
   [JsonProperty("statsNumberOfDataPoints")]
   protected long? _statsNumberOfDataPoints;
   
   [JsonProperty("statsTSDBServerAddress")]
   protected String _statsTSDBServerAddress;
   
   [JsonProperty("stickyECMPIdleTimeout")]
   protected long? _stickyECMPIdleTimeout;
   
   [JsonProperty("subnetResyncInterval")]
   protected long? _subnetResyncInterval;
   
   [JsonProperty("subnetResyncOutstandingInterval")]
   protected long? _subnetResyncOutstandingInterval;
   
   [JsonProperty("syslogDestinationHost")]
   protected String _syslogDestinationHost;
   
   [JsonProperty("syslogDestinationPort")]
   protected long? _syslogDestinationPort;
   
   [JsonProperty("sysmonCleanupTaskInterval")]
   protected long? _sysmonCleanupTaskInterval;
   
   [JsonProperty("sysmonNodePresenceTimeout")]
   protected long? _sysmonNodePresenceTimeout;
   
   [JsonProperty("sysmonProbeResponseTimeout")]
   protected long? _sysmonProbeResponseTimeout;
   
   [JsonProperty("sysmonPurgeInterval")]
   protected long? _sysmonPurgeInterval;
   
   [JsonProperty("systemAvatarData")]
   protected String _systemAvatarData;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("systemAvatarType")]
   protected ESystemAvatarType? _systemAvatarType;
   
   [JsonProperty("systemBlockedPageText")]
   protected String _systemBlockedPageText;
   
   [JsonProperty("threatIntelligenceEnabled")]
   protected bool _threatIntelligenceEnabled;
   
   [JsonProperty("threatPreventionFeedServerProxyPort")]
   protected long? _threatPreventionFeedServerProxyPort;
   
   [JsonProperty("threatPreventionServer")]
   protected String _threatPreventionServer;
   
   [JsonProperty("threatPreventionServerPassword")]
   protected String _threatPreventionServerPassword;
   
   [JsonProperty("threatPreventionServerProxyPort")]
   protected long? _threatPreventionServerProxyPort;
   
   [JsonProperty("threatPreventionServerUsername")]
   protected String _threatPreventionServerUsername;
   
   [JsonProperty("threatPreventionSyslogProxyPort")]
   protected long? _threatPreventionSyslogProxyPort;
   
   [JsonProperty("twoFactorCodeExpiry")]
   protected long? _twoFactorCodeExpiry;
   
   [JsonProperty("twoFactorCodeLength")]
   protected long? _twoFactorCodeLength;
   
   [JsonProperty("twoFactorCodeSeedLength")]
   protected long? _twoFactorCodeSeedLength;
   
   [JsonProperty("vcinLoadBalancerIP")]
   protected String _vcinLoadBalancerIP;
   
   [JsonProperty("virtualFirewallRulesEnabled")]
   protected bool _virtualFirewallRulesEnabled;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public SystemConfig() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
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
   public String NUACLAllowOrigin {
      get {
         return _ACLAllowOrigin;
      }
      set {
         this._ACLAllowOrigin = value;
      }
   }

   
   [JsonIgnore]
   public long? NUADGatewayPurgeTime {
      get {
         return _ADGatewayPurgeTime;
      }
      set {
         this._ADGatewayPurgeTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAPIKeyRenewalInterval {
      get {
         return _APIKeyRenewalInterval;
      }
      set {
         this._APIKeyRenewalInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAPIKeyValidity {
      get {
         return _APIKeyValidity;
      }
      set {
         this._APIKeyValidity = value;
      }
   }

   
   [JsonIgnore]
   public long? NUASNumber {
      get {
         return _ASNumber;
      }
      set {
         this._ASNumber = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDHCPOptionSize {
      get {
         return _DHCPOptionSize;
      }
      set {
         this._DHCPOptionSize = value;
      }
   }

   
   [JsonIgnore]
   public long? NUECMPCount {
      get {
         return _ECMPCount;
      }
      set {
         this._ECMPCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEVPNBGPCommunityTagASNumber {
      get {
         return _EVPNBGPCommunityTagASNumber;
      }
      set {
         this._EVPNBGPCommunityTagASNumber = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEVPNBGPCommunityTagLowerLimit {
      get {
         return _EVPNBGPCommunityTagLowerLimit;
      }
      set {
         this._EVPNBGPCommunityTagLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEVPNBGPCommunityTagUpperLimit {
      get {
         return _EVPNBGPCommunityTagUpperLimit;
      }
      set {
         this._EVPNBGPCommunityTagUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public bool NUIPv6ExtendedPrefixesEnabled {
      get {
         return _IPv6ExtendedPrefixesEnabled;
      }
      set {
         this._IPv6ExtendedPrefixesEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NULDAPSyncInterval {
      get {
         return _LDAPSyncInterval;
      }
      set {
         this._LDAPSyncInterval = value;
      }
   }

   
   [JsonIgnore]
   public String NULDAPTrustStoreCertifcate {
      get {
         return _LDAPTrustStoreCertifcate;
      }
      set {
         this._LDAPTrustStoreCertifcate = value;
      }
   }

   
   [JsonIgnore]
   public String NULDAPTrustStorePassword {
      get {
         return _LDAPTrustStorePassword;
      }
      set {
         this._LDAPTrustStorePassword = value;
      }
   }

   
   [JsonIgnore]
   public long? NULRUCacheSizePerSubnet {
      get {
         return _LRUCacheSizePerSubnet;
      }
      set {
         this._LRUCacheSizePerSubnet = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNSGUplinkHoldDownTimer {
      get {
         return _NSGUplinkHoldDownTimer;
      }
      set {
         this._NSGUplinkHoldDownTimer = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPGIDLowerLimit {
      get {
         return _PGIDLowerLimit;
      }
      set {
         this._PGIDLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPGIDUpperLimit {
      get {
         return _PGIDUpperLimit;
      }
      set {
         this._PGIDUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURDLowerLimit {
      get {
         return _RDLowerLimit;
      }
      set {
         this._RDLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURDPublicNetworkLowerLimit {
      get {
         return _RDPublicNetworkLowerLimit;
      }
      set {
         this._RDPublicNetworkLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURDPublicNetworkUpperLimit {
      get {
         return _RDPublicNetworkUpperLimit;
      }
      set {
         this._RDPublicNetworkUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURDUpperLimit {
      get {
         return _RDUpperLimit;
      }
      set {
         this._RDUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURTLowerLimit {
      get {
         return _RTLowerLimit;
      }
      set {
         this._RTLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURTPublicNetworkLowerLimit {
      get {
         return _RTPublicNetworkLowerLimit;
      }
      set {
         this._RTPublicNetworkLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURTPublicNetworkUpperLimit {
      get {
         return _RTPublicNetworkUpperLimit;
      }
      set {
         this._RTPublicNetworkUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NURTUpperLimit {
      get {
         return _RTUpperLimit;
      }
      set {
         this._RTUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public String NUSaaSApplicationsPublishDate {
      get {
         return _SaaSApplicationsPublishDate;
      }
      set {
         this._SaaSApplicationsPublishDate = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVLANIDLowerLimit {
      get {
         return _VLANIDLowerLimit;
      }
      set {
         this._VLANIDLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVLANIDUpperLimit {
      get {
         return _VLANIDUpperLimit;
      }
      set {
         this._VLANIDUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVMCacheSize {
      get {
         return _VMCacheSize;
      }
      set {
         this._VMCacheSize = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVMPurgeTime {
      get {
         return _VMPurgeTime;
      }
      set {
         this._VMPurgeTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVMResyncDeletionWaitTime {
      get {
         return _VMResyncDeletionWaitTime;
      }
      set {
         this._VMResyncDeletionWaitTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVMResyncOutstandingInterval {
      get {
         return _VMResyncOutstandingInterval;
      }
      set {
         this._VMResyncOutstandingInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVMUnreachableCleanupTime {
      get {
         return _VMUnreachableCleanupTime;
      }
      set {
         this._VMUnreachableCleanupTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVMUnreachableTime {
      get {
         return _VMUnreachableTime;
      }
      set {
         this._VMUnreachableTime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVNFTaskTimeout {
      get {
         return _VNFTaskTimeout;
      }
      set {
         this._VNFTaskTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVNIDLowerLimit {
      get {
         return _VNIDLowerLimit;
      }
      set {
         this._VNIDLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVNIDPublicNetworkLowerLimit {
      get {
         return _VNIDPublicNetworkLowerLimit;
      }
      set {
         this._VNIDPublicNetworkLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVNIDPublicNetworkUpperLimit {
      get {
         return _VNIDPublicNetworkUpperLimit;
      }
      set {
         this._VNIDPublicNetworkUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVNIDUpperLimit {
      get {
         return _VNIDUpperLimit;
      }
      set {
         this._VNIDUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVPortInitStatefulTimer {
      get {
         return _VPortInitStatefulTimer;
      }
      set {
         this._VPortInitStatefulTimer = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVSCOnSameVersionAsVSD {
      get {
         return _VSCOnSameVersionAsVSD;
      }
      set {
         this._VSCOnSameVersionAsVSD = value;
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
   public String NUVSDAARApplicationVersionPublishDate {
      get {
         return _VSDAARApplicationVersionPublishDate;
      }
      set {
         this._VSDAARApplicationVersionPublishDate = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVSDReadOnlyMode {
      get {
         return _VSDReadOnlyMode;
      }
      set {
         this._VSDReadOnlyMode = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVSDUpgradeIsComplete {
      get {
         return _VSDUpgradeIsComplete;
      }
      set {
         this._VSDUpgradeIsComplete = value;
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
   public bool NUZFBBootstrapEnabled {
      get {
         return _ZFBBootstrapEnabled;
      }
      set {
         this._ZFBBootstrapEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUZFBRequestRetryTimer {
      get {
         return _ZFBRequestRetryTimer;
      }
      set {
         this._ZFBRequestRetryTimer = value;
      }
   }

   
   [JsonIgnore]
   public long? NUZFBSchedulerStaleRequestTimeout {
      get {
         return _ZFBSchedulerStaleRequestTimeout;
      }
      set {
         this._ZFBSchedulerStaleRequestTimeout = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAccumulateLicensesEnabled {
      get {
         return _accumulateLicensesEnabled;
      }
      set {
         this._accumulateLicensesEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAlarmsMaxPerObject {
      get {
         return _alarmsMaxPerObject;
      }
      set {
         this._alarmsMaxPerObject = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAllowEnterpriseAvatarOnNSG {
      get {
         return _allowEnterpriseAvatarOnNSG;
      }
      set {
         this._allowEnterpriseAvatarOnNSG = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAttachProbeToIPsecNPM {
      get {
         return _attachProbeToIPsecNPM;
      }
      set {
         this._attachProbeToIPsecNPM = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAttachProbeToVXLANNPM {
      get {
         return _attachProbeToVXLANNPM;
      }
      set {
         this._attachProbeToVXLANNPM = value;
      }
   }

   
   [JsonIgnore]
   public String NUAvatarBasePath {
      get {
         return _avatarBasePath;
      }
      set {
         this._avatarBasePath = value;
      }
   }

   
   [JsonIgnore]
   public String NUAvatarBaseURL {
      get {
         return _avatarBaseURL;
      }
      set {
         this._avatarBaseURL = value;
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
   public ECsprootAuthenticationMethod? NUCsprootAuthenticationMethod {
      get {
         return _csprootAuthenticationMethod;
      }
      set {
         this._csprootAuthenticationMethod = value;
      }
   }

   
   [JsonIgnore]
   public long? NUCustomerIDUpperLimit {
      get {
         return _customerIDUpperLimit;
      }
      set {
         this._customerIDUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public String NUCustomerKey {
      get {
         return _customerKey;
      }
      set {
         this._customerKey = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDeniedFlowCollectionEnabled {
      get {
         return _deniedFlowCollectionEnabled;
      }
      set {
         this._deniedFlowCollectionEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EDomainTunnelType? NUDomainTunnelType {
      get {
         return _domainTunnelType;
      }
      set {
         this._domainTunnelType = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDynamicWANServiceDiffTime {
      get {
         return _dynamicWANServiceDiffTime;
      }
      set {
         this._dynamicWANServiceDiffTime = value;
      }
   }

   
   [JsonIgnore]
   public String NUEjbcaNSGCertificateProfile {
      get {
         return _ejbcaNSGCertificateProfile;
      }
      set {
         this._ejbcaNSGCertificateProfile = value;
      }
   }

   
   [JsonIgnore]
   public String NUEjbcaNSGEndEntityProfile {
      get {
         return _ejbcaNSGEndEntityProfile;
      }
      set {
         this._ejbcaNSGEndEntityProfile = value;
      }
   }

   
   [JsonIgnore]
   public String NUEjbcaOCSPResponderCN {
      get {
         return _ejbcaOCSPResponderCN;
      }
      set {
         this._ejbcaOCSPResponderCN = value;
      }
   }

   
   [JsonIgnore]
   public String NUEjbcaOCSPResponderURI {
      get {
         return _ejbcaOCSPResponderURI;
      }
      set {
         this._ejbcaOCSPResponderURI = value;
      }
   }

   
   [JsonIgnore]
   public String NUEjbcaVspRootCa {
      get {
         return _ejbcaVspRootCa;
      }
      set {
         this._ejbcaVspRootCa = value;
      }
   }

   
   [JsonIgnore]
   public String NUElasticClusterName {
      get {
         return _elasticClusterName;
      }
      set {
         this._elasticClusterName = value;
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
   public long? NUEmbeddedMetadataSize {
      get {
         return _embeddedMetadataSize;
      }
      set {
         this._embeddedMetadataSize = value;
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
   public long? NUEsiID {
      get {
         return _esiID;
      }
      set {
         this._esiID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEventLogCleanupInterval {
      get {
         return _eventLogCleanupInterval;
      }
      set {
         this._eventLogCleanupInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEventLogEntryMaxAge {
      get {
         return _eventLogEntryMaxAge;
      }
      set {
         this._eventLogEntryMaxAge = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEventProcessorInterval {
      get {
         return _eventProcessorInterval;
      }
      set {
         this._eventProcessorInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEventProcessorMaxEventsCount {
      get {
         return _eventProcessorMaxEventsCount;
      }
      set {
         this._eventProcessorMaxEventsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUEventProcessorTimeout {
      get {
         return _eventProcessorTimeout;
      }
      set {
         this._eventProcessorTimeout = value;
      }
   }

   
   [JsonIgnore]
   public bool NUExplicitACLMatchingEnabled {
      get {
         return _explicitACLMatchingEnabled;
      }
      set {
         this._explicitACLMatchingEnabled = value;
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
   public long? NUFecFeedbackTimer {
      get {
         return _fecFeedbackTimer;
      }
      set {
         this._fecFeedbackTimer = value;
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
   public long? NUFlowDropTimeout {
      get {
         return _flowDropTimeout;
      }
      set {
         this._flowDropTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGatewayProbeInterval {
      get {
         return _gatewayProbeInterval;
      }
      set {
         this._gatewayProbeInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGatewayProbeWindow {
      get {
         return _gatewayProbeWindow;
      }
      set {
         this._gatewayProbeWindow = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGatewayRebalancingInterval {
      get {
         return _gatewayRebalancingInterval;
      }
      set {
         this._gatewayRebalancingInterval = value;
      }
   }

   
   [JsonIgnore]
   public String NUGlobalMACAddress {
      get {
         return _globalMACAddress;
      }
      set {
         this._globalMACAddress = value;
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
   public long? NUGroupKeyDefaultSEKGenerationInterval {
      get {
         return _groupKeyDefaultSEKGenerationInterval;
      }
      set {
         this._groupKeyDefaultSEKGenerationInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyDefaultSEKLifetime {
      get {
         return _groupKeyDefaultSEKLifetime;
      }
      set {
         this._groupKeyDefaultSEKLifetime = value;
      }
   }

   
   [JsonIgnore]
   public EGroupKeyDefaultSEKPayloadEncryptionAlgorithm? NUGroupKeyDefaultSEKPayloadEncryptionAlgorithm {
      get {
         return _groupKeyDefaultSEKPayloadEncryptionAlgorithm;
      }
      set {
         this._groupKeyDefaultSEKPayloadEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public EGroupKeyDefaultSEKPayloadSigningAlgorithm? NUGroupKeyDefaultSEKPayloadSigningAlgorithm {
      get {
         return _groupKeyDefaultSEKPayloadSigningAlgorithm;
      }
      set {
         this._groupKeyDefaultSEKPayloadSigningAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyDefaultSeedGenerationInterval {
      get {
         return _groupKeyDefaultSeedGenerationInterval;
      }
      set {
         this._groupKeyDefaultSeedGenerationInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyDefaultSeedLifetime {
      get {
         return _groupKeyDefaultSeedLifetime;
      }
      set {
         this._groupKeyDefaultSeedLifetime = value;
      }
   }

   
   [JsonIgnore]
   public EGroupKeyDefaultSeedPayloadAuthenticationAlgorithm? NUGroupKeyDefaultSeedPayloadAuthenticationAlgorithm {
      get {
         return _groupKeyDefaultSeedPayloadAuthenticationAlgorithm;
      }
      set {
         this._groupKeyDefaultSeedPayloadAuthenticationAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public EGroupKeyDefaultSeedPayloadEncryptionAlgorithm? NUGroupKeyDefaultSeedPayloadEncryptionAlgorithm {
      get {
         return _groupKeyDefaultSeedPayloadEncryptionAlgorithm;
      }
      set {
         this._groupKeyDefaultSeedPayloadEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public EGroupKeyDefaultSeedPayloadSigningAlgorithm? NUGroupKeyDefaultSeedPayloadSigningAlgorithm {
      get {
         return _groupKeyDefaultSeedPayloadSigningAlgorithm;
      }
      set {
         this._groupKeyDefaultSeedPayloadSigningAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public EGroupKeyDefaultTrafficAuthenticationAlgorithm? NUGroupKeyDefaultTrafficAuthenticationAlgorithm {
      get {
         return _groupKeyDefaultTrafficAuthenticationAlgorithm;
      }
      set {
         this._groupKeyDefaultTrafficAuthenticationAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public EGroupKeyDefaultTrafficEncryptionAlgorithm? NUGroupKeyDefaultTrafficEncryptionAlgorithm {
      get {
         return _groupKeyDefaultTrafficEncryptionAlgorithm;
      }
      set {
         this._groupKeyDefaultTrafficEncryptionAlgorithm = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyDefaultTrafficEncryptionKeyLifetime {
      get {
         return _groupKeyDefaultTrafficEncryptionKeyLifetime;
      }
      set {
         this._groupKeyDefaultTrafficEncryptionKeyLifetime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyGenerationIntervalOnForcedReKey {
      get {
         return _groupKeyGenerationIntervalOnForcedReKey;
      }
      set {
         this._groupKeyGenerationIntervalOnForcedReKey = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyGenerationIntervalOnRevoke {
      get {
         return _groupKeyGenerationIntervalOnRevoke;
      }
      set {
         this._groupKeyGenerationIntervalOnRevoke = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyMinimumSEKGenerationInterval {
      get {
         return _groupKeyMinimumSEKGenerationInterval;
      }
      set {
         this._groupKeyMinimumSEKGenerationInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyMinimumSEKLifetime {
      get {
         return _groupKeyMinimumSEKLifetime;
      }
      set {
         this._groupKeyMinimumSEKLifetime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyMinimumSeedGenerationInterval {
      get {
         return _groupKeyMinimumSeedGenerationInterval;
      }
      set {
         this._groupKeyMinimumSeedGenerationInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyMinimumSeedLifetime {
      get {
         return _groupKeyMinimumSeedLifetime;
      }
      set {
         this._groupKeyMinimumSeedLifetime = value;
      }
   }

   
   [JsonIgnore]
   public long? NUGroupKeyMinimumTrafficEncryptionKeyLifetime {
      get {
         return _groupKeyMinimumTrafficEncryptionKeyLifetime;
      }
      set {
         this._groupKeyMinimumTrafficEncryptionKeyLifetime = value;
      }
   }

   
   [JsonIgnore]
   public String NUImportedSaaSApplicationsVersion {
      get {
         return _importedSaaSApplicationsVersion;
      }
      set {
         this._importedSaaSApplicationsVersion = value;
      }
   }

   
   [JsonIgnore]
   public long? NUInactiveTimeout {
      get {
         return _inactiveTimeout;
      }
      set {
         this._inactiveTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUInfrastructureBGPASNumber {
      get {
         return _infrastructureBGPASNumber;
      }
      set {
         this._infrastructureBGPASNumber = value;
      }
   }

   
   [JsonIgnore]
   public long? NUInterfaceIdLowerLimit {
      get {
         return _interfaceIdLowerLimit;
      }
      set {
         this._interfaceIdLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUInterfaceIdUpperLimit {
      get {
         return _interfaceIdUpperLimit;
      }
      set {
         this._interfaceIdUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public bool NUKeyServerMonitorEnabled {
      get {
         return _keyServerMonitorEnabled;
      }
      set {
         this._keyServerMonitorEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUKeyServerVSDDataSynchronizationInterval {
      get {
         return _keyServerVSDDataSynchronizationInterval;
      }
      set {
         this._keyServerVSDDataSynchronizationInterval = value;
      }
   }

   
   [JsonIgnore]
   public ELastExecutedMigrationPhase? NULastExecutedMigrationPhase {
      get {
         return _lastExecutedMigrationPhase;
      }
      set {
         this._lastExecutedMigrationPhase = value;
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
   public long? NUMaxFailedLogins {
      get {
         return _maxFailedLogins;
      }
      set {
         this._maxFailedLogins = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMaxResponse {
      get {
         return _maxResponse;
      }
      set {
         this._maxResponse = value;
      }
   }

   
   [JsonIgnore]
   public String NUNsgBootstrapEndpoint {
      get {
         return _nsgBootstrapEndpoint;
      }
      set {
         this._nsgBootstrapEndpoint = value;
      }
   }

   
   [JsonIgnore]
   public String NUNsgConfigEndpoint {
      get {
         return _nsgConfigEndpoint;
      }
      set {
         this._nsgConfigEndpoint = value;
      }
   }

   
   [JsonIgnore]
   public String NUNsgLocalUiUrl {
      get {
         return _nsgLocalUiUrl;
      }
      set {
         this._nsgLocalUiUrl = value;
      }
   }

   
   [JsonIgnore]
   public long? NUOffsetCustomerID {
      get {
         return _offsetCustomerID;
      }
      set {
         this._offsetCustomerID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUOffsetServiceID {
      get {
         return _offsetServiceID;
      }
      set {
         this._offsetServiceID = value;
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
   public long? NUPageMaxSize {
      get {
         return _pageMaxSize;
      }
      set {
         this._pageMaxSize = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPageSize {
      get {
         return _pageSize;
      }
      set {
         this._pageSize = value;
      }
   }

   
   [JsonIgnore]
   public bool NUPerDomainVlanIdEnabled {
      get {
         return _perDomainVlanIdEnabled;
      }
      set {
         this._perDomainVlanIdEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPostProcessorThreadsCount {
      get {
         return _postProcessorThreadsCount;
      }
      set {
         this._postProcessorThreadsCount = value;
      }
   }

   
   [JsonIgnore]
   public bool NURbacEnabled {
      get {
         return _rbacEnabled;
      }
      set {
         this._rbacEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSecondaryASNumber {
      get {
         return _secondaryASNumber;
      }
      set {
         this._secondaryASNumber = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSecondaryRTLowerLimit {
      get {
         return _secondaryRTLowerLimit;
      }
      set {
         this._secondaryRTLowerLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSecondaryRTUpperLimit {
      get {
         return _secondaryRTUpperLimit;
      }
      set {
         this._secondaryRTUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public long? NUServiceIDUpperLimit {
      get {
         return _serviceIDUpperLimit;
      }
      set {
         this._serviceIDUpperLimit = value;
      }
   }

   
   [JsonIgnore]
   public bool NUStackTraceEnabled {
      get {
         return _stackTraceEnabled;
      }
      set {
         this._stackTraceEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStatefulACLNonTCPTimeout {
      get {
         return _statefulACLNonTCPTimeout;
      }
      set {
         this._statefulACLNonTCPTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStatefulACLTCPTimeout {
      get {
         return _statefulACLTCPTimeout;
      }
      set {
         this._statefulACLTCPTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStaticWANServicePurgeTime {
      get {
         return _staticWANServicePurgeTime;
      }
      set {
         this._staticWANServicePurgeTime = value;
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
   public String NUStatsCollectorAddress {
      get {
         return _statsCollectorAddress;
      }
      set {
         this._statsCollectorAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUStatsCollectorPort {
      get {
         return _statsCollectorPort;
      }
      set {
         this._statsCollectorPort = value;
      }
   }

   
   [JsonIgnore]
   public String NUStatsCollectorProtoBufPort {
      get {
         return _statsCollectorProtoBufPort;
      }
      set {
         this._statsCollectorProtoBufPort = value;
      }
   }

   
   [JsonIgnore]
   public String NUStatsDatabaseProxy {
      get {
         return _statsDatabaseProxy;
      }
      set {
         this._statsDatabaseProxy = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStatsMaxDataPoints {
      get {
         return _statsMaxDataPoints;
      }
      set {
         this._statsMaxDataPoints = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStatsMinDuration {
      get {
         return _statsMinDuration;
      }
      set {
         this._statsMinDuration = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStatsNumberOfDataPoints {
      get {
         return _statsNumberOfDataPoints;
      }
      set {
         this._statsNumberOfDataPoints = value;
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

   
   [JsonIgnore]
   public long? NUStickyECMPIdleTimeout {
      get {
         return _stickyECMPIdleTimeout;
      }
      set {
         this._stickyECMPIdleTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSubnetResyncInterval {
      get {
         return _subnetResyncInterval;
      }
      set {
         this._subnetResyncInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSubnetResyncOutstandingInterval {
      get {
         return _subnetResyncOutstandingInterval;
      }
      set {
         this._subnetResyncOutstandingInterval = value;
      }
   }

   
   [JsonIgnore]
   public String NUSyslogDestinationHost {
      get {
         return _syslogDestinationHost;
      }
      set {
         this._syslogDestinationHost = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSyslogDestinationPort {
      get {
         return _syslogDestinationPort;
      }
      set {
         this._syslogDestinationPort = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSysmonCleanupTaskInterval {
      get {
         return _sysmonCleanupTaskInterval;
      }
      set {
         this._sysmonCleanupTaskInterval = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSysmonNodePresenceTimeout {
      get {
         return _sysmonNodePresenceTimeout;
      }
      set {
         this._sysmonNodePresenceTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSysmonProbeResponseTimeout {
      get {
         return _sysmonProbeResponseTimeout;
      }
      set {
         this._sysmonProbeResponseTimeout = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSysmonPurgeInterval {
      get {
         return _sysmonPurgeInterval;
      }
      set {
         this._sysmonPurgeInterval = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystemAvatarData {
      get {
         return _systemAvatarData;
      }
      set {
         this._systemAvatarData = value;
      }
   }

   
   [JsonIgnore]
   public ESystemAvatarType? NUSystemAvatarType {
      get {
         return _systemAvatarType;
      }
      set {
         this._systemAvatarType = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystemBlockedPageText {
      get {
         return _systemBlockedPageText;
      }
      set {
         this._systemBlockedPageText = value;
      }
   }

   
   [JsonIgnore]
   public bool NUThreatIntelligenceEnabled {
      get {
         return _threatIntelligenceEnabled;
      }
      set {
         this._threatIntelligenceEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUThreatPreventionFeedServerProxyPort {
      get {
         return _threatPreventionFeedServerProxyPort;
      }
      set {
         this._threatPreventionFeedServerProxyPort = value;
      }
   }

   
   [JsonIgnore]
   public String NUThreatPreventionServer {
      get {
         return _threatPreventionServer;
      }
      set {
         this._threatPreventionServer = value;
      }
   }

   
   [JsonIgnore]
   public String NUThreatPreventionServerPassword {
      get {
         return _threatPreventionServerPassword;
      }
      set {
         this._threatPreventionServerPassword = value;
      }
   }

   
   [JsonIgnore]
   public long? NUThreatPreventionServerProxyPort {
      get {
         return _threatPreventionServerProxyPort;
      }
      set {
         this._threatPreventionServerProxyPort = value;
      }
   }

   
   [JsonIgnore]
   public String NUThreatPreventionServerUsername {
      get {
         return _threatPreventionServerUsername;
      }
      set {
         this._threatPreventionServerUsername = value;
      }
   }

   
   [JsonIgnore]
   public long? NUThreatPreventionSyslogProxyPort {
      get {
         return _threatPreventionSyslogProxyPort;
      }
      set {
         this._threatPreventionSyslogProxyPort = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTwoFactorCodeExpiry {
      get {
         return _twoFactorCodeExpiry;
      }
      set {
         this._twoFactorCodeExpiry = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTwoFactorCodeLength {
      get {
         return _twoFactorCodeLength;
      }
      set {
         this._twoFactorCodeLength = value;
      }
   }

   
   [JsonIgnore]
   public long? NUTwoFactorCodeSeedLength {
      get {
         return _twoFactorCodeSeedLength;
      }
      set {
         this._twoFactorCodeSeedLength = value;
      }
   }

   
   [JsonIgnore]
   public String NUVcinLoadBalancerIP {
      get {
         return _vcinLoadBalancerIP;
      }
      set {
         this._vcinLoadBalancerIP = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVirtualFirewallRulesEnabled {
      get {
         return _virtualFirewallRulesEnabled;
      }
      set {
         this._virtualFirewallRulesEnabled = value;
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
      return "SystemConfig [" + "AARFlowStatsInterval=" + _AARFlowStatsInterval + ", AARProbeStatsInterval=" + _AARProbeStatsInterval + ", ACLAllowOrigin=" + _ACLAllowOrigin + ", ADGatewayPurgeTime=" + _ADGatewayPurgeTime + ", APIKeyRenewalInterval=" + _APIKeyRenewalInterval + ", APIKeyValidity=" + _APIKeyValidity + ", ASNumber=" + _ASNumber + ", DHCPOptionSize=" + _DHCPOptionSize + ", ECMPCount=" + _ECMPCount + ", EVPNBGPCommunityTagASNumber=" + _EVPNBGPCommunityTagASNumber + ", EVPNBGPCommunityTagLowerLimit=" + _EVPNBGPCommunityTagLowerLimit + ", EVPNBGPCommunityTagUpperLimit=" + _EVPNBGPCommunityTagUpperLimit + ", IPv6ExtendedPrefixesEnabled=" + _IPv6ExtendedPrefixesEnabled + ", LDAPSyncInterval=" + _LDAPSyncInterval + ", LDAPTrustStoreCertifcate=" + _LDAPTrustStoreCertifcate + ", LDAPTrustStorePassword=" + _LDAPTrustStorePassword + ", LRUCacheSizePerSubnet=" + _LRUCacheSizePerSubnet + ", NSGUplinkHoldDownTimer=" + _NSGUplinkHoldDownTimer + ", PGIDLowerLimit=" + _PGIDLowerLimit + ", PGIDUpperLimit=" + _PGIDUpperLimit + ", RDLowerLimit=" + _RDLowerLimit + ", RDPublicNetworkLowerLimit=" + _RDPublicNetworkLowerLimit + ", RDPublicNetworkUpperLimit=" + _RDPublicNetworkUpperLimit + ", RDUpperLimit=" + _RDUpperLimit + ", RTLowerLimit=" + _RTLowerLimit + ", RTPublicNetworkLowerLimit=" + _RTPublicNetworkLowerLimit + ", RTPublicNetworkUpperLimit=" + _RTPublicNetworkUpperLimit + ", RTUpperLimit=" + _RTUpperLimit + ", SaaSApplicationsPublishDate=" + _SaaSApplicationsPublishDate + ", VLANIDLowerLimit=" + _VLANIDLowerLimit + ", VLANIDUpperLimit=" + _VLANIDUpperLimit + ", VMCacheSize=" + _VMCacheSize + ", VMPurgeTime=" + _VMPurgeTime + ", VMResyncDeletionWaitTime=" + _VMResyncDeletionWaitTime + ", VMResyncOutstandingInterval=" + _VMResyncOutstandingInterval + ", VMUnreachableCleanupTime=" + _VMUnreachableCleanupTime + ", VMUnreachableTime=" + _VMUnreachableTime + ", VNFTaskTimeout=" + _VNFTaskTimeout + ", VNIDLowerLimit=" + _VNIDLowerLimit + ", VNIDPublicNetworkLowerLimit=" + _VNIDPublicNetworkLowerLimit + ", VNIDPublicNetworkUpperLimit=" + _VNIDPublicNetworkUpperLimit + ", VNIDUpperLimit=" + _VNIDUpperLimit + ", VPortInitStatefulTimer=" + _VPortInitStatefulTimer + ", VSCOnSameVersionAsVSD=" + _VSCOnSameVersionAsVSD + ", VSDAARApplicationVersion=" + _VSDAARApplicationVersion + ", VSDAARApplicationVersionPublishDate=" + _VSDAARApplicationVersionPublishDate + ", VSDReadOnlyMode=" + _VSDReadOnlyMode + ", VSDUpgradeIsComplete=" + _VSDUpgradeIsComplete + ", VSSStatsInterval=" + _VSSStatsInterval + ", ZFBBootstrapEnabled=" + _ZFBBootstrapEnabled + ", ZFBRequestRetryTimer=" + _ZFBRequestRetryTimer + ", ZFBSchedulerStaleRequestTimeout=" + _ZFBSchedulerStaleRequestTimeout + ", accumulateLicensesEnabled=" + _accumulateLicensesEnabled + ", alarmsMaxPerObject=" + _alarmsMaxPerObject + ", allowEnterpriseAvatarOnNSG=" + _allowEnterpriseAvatarOnNSG + ", attachProbeToIPsecNPM=" + _attachProbeToIPsecNPM + ", attachProbeToVXLANNPM=" + _attachProbeToVXLANNPM + ", avatarBasePath=" + _avatarBasePath + ", avatarBaseURL=" + _avatarBaseURL + ", creationDate=" + _creationDate + ", csprootAuthenticationMethod=" + _csprootAuthenticationMethod + ", customerIDUpperLimit=" + _customerIDUpperLimit + ", customerKey=" + _customerKey + ", deniedFlowCollectionEnabled=" + _deniedFlowCollectionEnabled + ", domainTunnelType=" + _domainTunnelType + ", dynamicWANServiceDiffTime=" + _dynamicWANServiceDiffTime + ", ejbcaNSGCertificateProfile=" + _ejbcaNSGCertificateProfile + ", ejbcaNSGEndEntityProfile=" + _ejbcaNSGEndEntityProfile + ", ejbcaOCSPResponderCN=" + _ejbcaOCSPResponderCN + ", ejbcaOCSPResponderURI=" + _ejbcaOCSPResponderURI + ", ejbcaVspRootCa=" + _ejbcaVspRootCa + ", elasticClusterName=" + _elasticClusterName + ", embeddedMetadata=" + _embeddedMetadata + ", embeddedMetadataSize=" + _embeddedMetadataSize + ", entityScope=" + _entityScope + ", esiID=" + _esiID + ", eventLogCleanupInterval=" + _eventLogCleanupInterval + ", eventLogEntryMaxAge=" + _eventLogEntryMaxAge + ", eventProcessorInterval=" + _eventProcessorInterval + ", eventProcessorMaxEventsCount=" + _eventProcessorMaxEventsCount + ", eventProcessorTimeout=" + _eventProcessorTimeout + ", explicitACLMatchingEnabled=" + _explicitACLMatchingEnabled + ", externalID=" + _externalID + ", fecFeedbackTimer=" + _fecFeedbackTimer + ", flowCollectionEnabled=" + _flowCollectionEnabled + ", flowDropTimeout=" + _flowDropTimeout + ", gatewayProbeInterval=" + _gatewayProbeInterval + ", gatewayProbeWindow=" + _gatewayProbeWindow + ", gatewayRebalancingInterval=" + _gatewayRebalancingInterval + ", globalMACAddress=" + _globalMACAddress + ", googleMapsAPIKey=" + _googleMapsAPIKey + ", groupKeyDefaultSEKGenerationInterval=" + _groupKeyDefaultSEKGenerationInterval + ", groupKeyDefaultSEKLifetime=" + _groupKeyDefaultSEKLifetime + ", groupKeyDefaultSEKPayloadEncryptionAlgorithm=" + _groupKeyDefaultSEKPayloadEncryptionAlgorithm + ", groupKeyDefaultSEKPayloadSigningAlgorithm=" + _groupKeyDefaultSEKPayloadSigningAlgorithm + ", groupKeyDefaultSeedGenerationInterval=" + _groupKeyDefaultSeedGenerationInterval + ", groupKeyDefaultSeedLifetime=" + _groupKeyDefaultSeedLifetime + ", groupKeyDefaultSeedPayloadAuthenticationAlgorithm=" + _groupKeyDefaultSeedPayloadAuthenticationAlgorithm + ", groupKeyDefaultSeedPayloadEncryptionAlgorithm=" + _groupKeyDefaultSeedPayloadEncryptionAlgorithm + ", groupKeyDefaultSeedPayloadSigningAlgorithm=" + _groupKeyDefaultSeedPayloadSigningAlgorithm + ", groupKeyDefaultTrafficAuthenticationAlgorithm=" + _groupKeyDefaultTrafficAuthenticationAlgorithm + ", groupKeyDefaultTrafficEncryptionAlgorithm=" + _groupKeyDefaultTrafficEncryptionAlgorithm + ", groupKeyDefaultTrafficEncryptionKeyLifetime=" + _groupKeyDefaultTrafficEncryptionKeyLifetime + ", groupKeyGenerationIntervalOnForcedReKey=" + _groupKeyGenerationIntervalOnForcedReKey + ", groupKeyGenerationIntervalOnRevoke=" + _groupKeyGenerationIntervalOnRevoke + ", groupKeyMinimumSEKGenerationInterval=" + _groupKeyMinimumSEKGenerationInterval + ", groupKeyMinimumSEKLifetime=" + _groupKeyMinimumSEKLifetime + ", groupKeyMinimumSeedGenerationInterval=" + _groupKeyMinimumSeedGenerationInterval + ", groupKeyMinimumSeedLifetime=" + _groupKeyMinimumSeedLifetime + ", groupKeyMinimumTrafficEncryptionKeyLifetime=" + _groupKeyMinimumTrafficEncryptionKeyLifetime + ", importedSaaSApplicationsVersion=" + _importedSaaSApplicationsVersion + ", inactiveTimeout=" + _inactiveTimeout + ", infrastructureBGPASNumber=" + _infrastructureBGPASNumber + ", interfaceIdLowerLimit=" + _interfaceIdLowerLimit + ", interfaceIdUpperLimit=" + _interfaceIdUpperLimit + ", keyServerMonitorEnabled=" + _keyServerMonitorEnabled + ", keyServerVSDDataSynchronizationInterval=" + _keyServerVSDDataSynchronizationInterval + ", lastExecutedMigrationPhase=" + _lastExecutedMigrationPhase + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", maxFailedLogins=" + _maxFailedLogins + ", maxResponse=" + _maxResponse + ", nsgBootstrapEndpoint=" + _nsgBootstrapEndpoint + ", nsgConfigEndpoint=" + _nsgConfigEndpoint + ", nsgLocalUiUrl=" + _nsgLocalUiUrl + ", offsetCustomerID=" + _offsetCustomerID + ", offsetServiceID=" + _offsetServiceID + ", owner=" + _owner + ", pageMaxSize=" + _pageMaxSize + ", pageSize=" + _pageSize + ", perDomainVlanIdEnabled=" + _perDomainVlanIdEnabled + ", postProcessorThreadsCount=" + _postProcessorThreadsCount + ", rbacEnabled=" + _rbacEnabled + ", secondaryASNumber=" + _secondaryASNumber + ", secondaryRTLowerLimit=" + _secondaryRTLowerLimit + ", secondaryRTUpperLimit=" + _secondaryRTUpperLimit + ", serviceIDUpperLimit=" + _serviceIDUpperLimit + ", stackTraceEnabled=" + _stackTraceEnabled + ", statefulACLNonTCPTimeout=" + _statefulACLNonTCPTimeout + ", statefulACLTCPTimeout=" + _statefulACLTCPTimeout + ", staticWANServicePurgeTime=" + _staticWANServicePurgeTime + ", statisticsEnabled=" + _statisticsEnabled + ", statsCollectorAddress=" + _statsCollectorAddress + ", statsCollectorPort=" + _statsCollectorPort + ", statsCollectorProtoBufPort=" + _statsCollectorProtoBufPort + ", statsDatabaseProxy=" + _statsDatabaseProxy + ", statsMaxDataPoints=" + _statsMaxDataPoints + ", statsMinDuration=" + _statsMinDuration + ", statsNumberOfDataPoints=" + _statsNumberOfDataPoints + ", statsTSDBServerAddress=" + _statsTSDBServerAddress + ", stickyECMPIdleTimeout=" + _stickyECMPIdleTimeout + ", subnetResyncInterval=" + _subnetResyncInterval + ", subnetResyncOutstandingInterval=" + _subnetResyncOutstandingInterval + ", syslogDestinationHost=" + _syslogDestinationHost + ", syslogDestinationPort=" + _syslogDestinationPort + ", sysmonCleanupTaskInterval=" + _sysmonCleanupTaskInterval + ", sysmonNodePresenceTimeout=" + _sysmonNodePresenceTimeout + ", sysmonProbeResponseTimeout=" + _sysmonProbeResponseTimeout + ", sysmonPurgeInterval=" + _sysmonPurgeInterval + ", systemAvatarData=" + _systemAvatarData + ", systemAvatarType=" + _systemAvatarType + ", systemBlockedPageText=" + _systemBlockedPageText + ", threatIntelligenceEnabled=" + _threatIntelligenceEnabled + ", threatPreventionFeedServerProxyPort=" + _threatPreventionFeedServerProxyPort + ", threatPreventionServer=" + _threatPreventionServer + ", threatPreventionServerPassword=" + _threatPreventionServerPassword + ", threatPreventionServerProxyPort=" + _threatPreventionServerProxyPort + ", threatPreventionServerUsername=" + _threatPreventionServerUsername + ", threatPreventionSyslogProxyPort=" + _threatPreventionSyslogProxyPort + ", twoFactorCodeExpiry=" + _twoFactorCodeExpiry + ", twoFactorCodeLength=" + _twoFactorCodeLength + ", twoFactorCodeSeedLength=" + _twoFactorCodeSeedLength + ", vcinLoadBalancerIP=" + _vcinLoadBalancerIP + ", virtualFirewallRulesEnabled=" + _virtualFirewallRulesEnabled + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "systemconfigs";
   }

   public static String getRestName()
   {
	return "systemconfig";
   }
}
}