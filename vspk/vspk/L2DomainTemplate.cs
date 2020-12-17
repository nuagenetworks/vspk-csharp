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

public class L2DomainTemplate: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDPI {DISABLED,ENABLED,INHERITED };
   public enum EIPType {DUALSTACK,IPV4,IPV6 };
   public enum EEncryption {DISABLED,ENABLED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EEntityState {MARKED_FOR_DELETION,UNDER_CONSTRUCTION };
   public enum EMulticast {DISABLED,ENABLED,INHERITED };
   public enum EPolicyChangeStatus {APPLIED,DISCARDED,STARTED };
   public enum EUseGlobalMAC {DISABLED,ENABLED };

   
   [JsonProperty("DHCPManaged")]
   protected bool _DHCPManaged;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DPI")]
   protected EDPI? _DPI;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   
   [JsonProperty("IPv6Address")]
   protected String _IPv6Address;
   
   [JsonProperty("IPv6Gateway")]
   protected String _IPv6Gateway;
   
   [JsonProperty("address")]
   protected String _address;
   
   [JsonProperty("associatedMulticastChannelMapID")]
   protected String _associatedMulticastChannelMapID;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dualStackDynamicIPAllocation")]
   protected bool _dualStackDynamicIPAllocation;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enableDHCPv4")]
   protected bool _enableDHCPv4;
   
   [JsonProperty("enableDHCPv6")]
   protected bool _enableDHCPv6;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("encryption")]
   protected EEncryption? _encryption;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityState")]
   protected EEntityState? _entityState;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gateway")]
   protected String _gateway;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("multicast")]
   protected EMulticast? _multicast;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("policyChangeStatus")]
   protected EPolicyChangeStatus? _policyChangeStatus;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("useGlobalMAC")]
   protected EUseGlobalMAC? _useGlobalMAC;
   

   
   [JsonIgnore]
   private AddressRangesFetcher _addressRanges;
   
   [JsonIgnore]
   private EgressACLTemplatesFetcher _egressACLTemplates;
   
   [JsonIgnore]
   private EgressAdvFwdTemplatesFetcher _egressAdvFwdTemplates;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private GroupsFetcher _groups;
   
   [JsonIgnore]
   private IngressACLTemplatesFetcher _ingressACLTemplates;
   
   [JsonIgnore]
   private IngressAdvFwdTemplatesFetcher _ingressAdvFwdTemplates;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private L2DomainsFetcher _l2Domains;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private OverlayMirrorDestinationTemplatesFetcher _overlayMirrorDestinationTemplates;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private PGExpressionTemplatesFetcher _pGExpressionTemplates;
   
   [JsonIgnore]
   private PolicyGroupTemplatesFetcher _policyGroupTemplates;
   
   [JsonIgnore]
   private QOSsFetcher _qOSs;
   
   [JsonIgnore]
   private RedirectionTargetTemplatesFetcher _redirectionTargetTemplates;
   
   [JsonIgnore]
   private VirtualFirewallPoliciesFetcher _virtualFirewallPolicies;
   
   public L2DomainTemplate() {
      
      _addressRanges = new AddressRangesFetcher(this);
      
      _egressACLTemplates = new EgressACLTemplatesFetcher(this);
      
      _egressAdvFwdTemplates = new EgressAdvFwdTemplatesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _groups = new GroupsFetcher(this);
      
      _ingressACLTemplates = new IngressACLTemplatesFetcher(this);
      
      _ingressAdvFwdTemplates = new IngressAdvFwdTemplatesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _l2Domains = new L2DomainsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _overlayMirrorDestinationTemplates = new OverlayMirrorDestinationTemplatesFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _pGExpressionTemplates = new PGExpressionTemplatesFetcher(this);
      
      _policyGroupTemplates = new PolicyGroupTemplatesFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _redirectionTargetTemplates = new RedirectionTargetTemplatesFetcher(this);
      
      _virtualFirewallPolicies = new VirtualFirewallPoliciesFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUDHCPManaged {
      get {
         return _DHCPManaged;
      }
      set {
         this._DHCPManaged = value;
      }
   }

   
   [JsonIgnore]
   public EDPI? NUDPI {
      get {
         return _DPI;
      }
      set {
         this._DPI = value;
      }
   }

   
   [JsonIgnore]
   public EIPType? NUIPType {
      get {
         return _IPType;
      }
      set {
         this._IPType = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPv6Address {
      get {
         return _IPv6Address;
      }
      set {
         this._IPv6Address = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPv6Gateway {
      get {
         return _IPv6Gateway;
      }
      set {
         this._IPv6Gateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUAddress {
      get {
         return _address;
      }
      set {
         this._address = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedMulticastChannelMapID {
      get {
         return _associatedMulticastChannelMapID;
      }
      set {
         this._associatedMulticastChannelMapID = value;
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
   public bool NUDualStackDynamicIPAllocation {
      get {
         return _dualStackDynamicIPAllocation;
      }
      set {
         this._dualStackDynamicIPAllocation = value;
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
   public bool NUEnableDHCPv4 {
      get {
         return _enableDHCPv4;
      }
      set {
         this._enableDHCPv4 = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEnableDHCPv6 {
      get {
         return _enableDHCPv6;
      }
      set {
         this._enableDHCPv6 = value;
      }
   }

   
   [JsonIgnore]
   public EEncryption? NUEncryption {
      get {
         return _encryption;
      }
      set {
         this._encryption = value;
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
   public EEntityState? NUEntityState {
      get {
         return _entityState;
      }
      set {
         this._entityState = value;
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
   public String NUGateway {
      get {
         return _gateway;
      }
      set {
         this._gateway = value;
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
   public EMulticast? NUMulticast {
      get {
         return _multicast;
      }
      set {
         this._multicast = value;
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
   public String NUNetmask {
      get {
         return _netmask;
      }
      set {
         this._netmask = value;
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
   public EPolicyChangeStatus? NUPolicyChangeStatus {
      get {
         return _policyChangeStatus;
      }
      set {
         this._policyChangeStatus = value;
      }
   }

   
   [JsonIgnore]
   public EUseGlobalMAC? NUUseGlobalMAC {
      get {
         return _useGlobalMAC;
      }
      set {
         this._useGlobalMAC = value;
      }
   }

   

   
   public AddressRangesFetcher getAddressRanges() {
      return _addressRanges;
   }
   
   public EgressACLTemplatesFetcher getEgressACLTemplates() {
      return _egressACLTemplates;
   }
   
   public EgressAdvFwdTemplatesFetcher getEgressAdvFwdTemplates() {
      return _egressAdvFwdTemplates;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public GroupsFetcher getGroups() {
      return _groups;
   }
   
   public IngressACLTemplatesFetcher getIngressACLTemplates() {
      return _ingressACLTemplates;
   }
   
   public IngressAdvFwdTemplatesFetcher getIngressAdvFwdTemplates() {
      return _ingressAdvFwdTemplates;
   }
   
   public JobsFetcher getJobs() {
      return _jobs;
   }
   
   public L2DomainsFetcher getL2Domains() {
      return _l2Domains;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public OverlayMirrorDestinationTemplatesFetcher getOverlayMirrorDestinationTemplates() {
      return _overlayMirrorDestinationTemplates;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public PGExpressionTemplatesFetcher getPGExpressionTemplates() {
      return _pGExpressionTemplates;
   }
   
   public PolicyGroupTemplatesFetcher getPolicyGroupTemplates() {
      return _policyGroupTemplates;
   }
   
   public QOSsFetcher getQOSs() {
      return _qOSs;
   }
   
   public RedirectionTargetTemplatesFetcher getRedirectionTargetTemplates() {
      return _redirectionTargetTemplates;
   }
   
   public VirtualFirewallPoliciesFetcher getVirtualFirewallPolicies() {
      return _virtualFirewallPolicies;
   }
   

   public String toString() {
      return "L2DomainTemplate [" + "DHCPManaged=" + _DHCPManaged + ", DPI=" + _DPI + ", IPType=" + _IPType + ", IPv6Address=" + _IPv6Address + ", IPv6Gateway=" + _IPv6Gateway + ", address=" + _address + ", associatedMulticastChannelMapID=" + _associatedMulticastChannelMapID + ", creationDate=" + _creationDate + ", description=" + _description + ", dualStackDynamicIPAllocation=" + _dualStackDynamicIPAllocation + ", embeddedMetadata=" + _embeddedMetadata + ", enableDHCPv4=" + _enableDHCPv4 + ", enableDHCPv6=" + _enableDHCPv6 + ", encryption=" + _encryption + ", entityScope=" + _entityScope + ", entityState=" + _entityState + ", externalID=" + _externalID + ", gateway=" + _gateway + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", multicast=" + _multicast + ", name=" + _name + ", netmask=" + _netmask + ", owner=" + _owner + ", policyChangeStatus=" + _policyChangeStatus + ", useGlobalMAC=" + _useGlobalMAC + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "l2domaintemplates";
   }

   public static String getRestName()
   {
	return "l2domaintemplate";
   }
}
}