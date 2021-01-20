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

public class DomainTemplate: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EDPI {DISABLED,ENABLED };
   public enum EEncryption {DISABLED,ENABLED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EMulticast {DISABLED,ENABLED,INHERITED };
   public enum EPolicyChangeStatus {APPLIED,DISCARDED,STARTED };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("DPI")]
   protected EDPI? _DPI;
   
   [JsonProperty("associatedBGPProfileID")]
   protected String _associatedBGPProfileID;
   
   [JsonProperty("associatedMulticastChannelMapID")]
   protected String _associatedMulticastChannelMapID;
   
   [JsonProperty("associatedPATMapperID")]
   protected String _associatedPATMapperID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("encryption")]
   protected EEncryption? _encryption;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("multicast")]
   protected EMulticast? _multicast;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("policyChangeStatus")]
   protected EPolicyChangeStatus? _policyChangeStatus;
   

   
   [JsonIgnore]
   private DomainsFetcher _domains;
   
   [JsonIgnore]
   private EgressACLTemplatesFetcher _egressACLTemplates;
   
   [JsonIgnore]
   private EgressAdvFwdTemplatesFetcher _egressAdvFwdTemplates;
   
   [JsonIgnore]
   private DomainFIPAclTemplatesFetcher _domainFIPAclTemplates;
   
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
   private MetadatasFetcher _metadatas;
   
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
   private SubnetTemplatesFetcher _subnetTemplates;
   
   [JsonIgnore]
   private VirtualFirewallPoliciesFetcher _virtualFirewallPolicies;
   
   [JsonIgnore]
   private ZoneTemplatesFetcher _zoneTemplates;
   
   public DomainTemplate() {
      
      _domains = new DomainsFetcher(this);
      
      _egressACLTemplates = new EgressACLTemplatesFetcher(this);
      
      _egressAdvFwdTemplates = new EgressAdvFwdTemplatesFetcher(this);
      
      _domainFIPAclTemplates = new DomainFIPAclTemplatesFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _groups = new GroupsFetcher(this);
      
      _ingressACLTemplates = new IngressACLTemplatesFetcher(this);
      
      _ingressAdvFwdTemplates = new IngressAdvFwdTemplatesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _pGExpressionTemplates = new PGExpressionTemplatesFetcher(this);
      
      _policyGroupTemplates = new PolicyGroupTemplatesFetcher(this);
      
      _qOSs = new QOSsFetcher(this);
      
      _redirectionTargetTemplates = new RedirectionTargetTemplatesFetcher(this);
      
      _subnetTemplates = new SubnetTemplatesFetcher(this);
      
      _virtualFirewallPolicies = new VirtualFirewallPoliciesFetcher(this);
      
      _zoneTemplates = new ZoneTemplatesFetcher(this);
      
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
   public String NUAssociatedBGPProfileID {
      get {
         return _associatedBGPProfileID;
      }
      set {
         this._associatedBGPProfileID = value;
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
   public String NUAssociatedPATMapperID {
      get {
         return _associatedPATMapperID;
      }
      set {
         this._associatedPATMapperID = value;
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
   public String NUExternalID {
      get {
         return _externalID;
      }
      set {
         this._externalID = value;
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
   public EPolicyChangeStatus? NUPolicyChangeStatus {
      get {
         return _policyChangeStatus;
      }
      set {
         this._policyChangeStatus = value;
      }
   }

   

   
   public DomainsFetcher getDomains() {
      return _domains;
   }
   
   public EgressACLTemplatesFetcher getEgressACLTemplates() {
      return _egressACLTemplates;
   }
   
   public EgressAdvFwdTemplatesFetcher getEgressAdvFwdTemplates() {
      return _egressAdvFwdTemplates;
   }
   
   public DomainFIPAclTemplatesFetcher getDomainFIPAclTemplates() {
      return _domainFIPAclTemplates;
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
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
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
   
   public SubnetTemplatesFetcher getSubnetTemplates() {
      return _subnetTemplates;
   }
   
   public VirtualFirewallPoliciesFetcher getVirtualFirewallPolicies() {
      return _virtualFirewallPolicies;
   }
   
   public ZoneTemplatesFetcher getZoneTemplates() {
      return _zoneTemplates;
   }
   

   public String toString() {
      return "DomainTemplate [" + "DPI=" + _DPI + ", associatedBGPProfileID=" + _associatedBGPProfileID + ", associatedMulticastChannelMapID=" + _associatedMulticastChannelMapID + ", associatedPATMapperID=" + _associatedPATMapperID + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", encryption=" + _encryption + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", multicast=" + _multicast + ", name=" + _name + ", policyChangeStatus=" + _policyChangeStatus + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "domaintemplates";
   }

   public static String getRestName()
   {
	return "domaintemplate";
   }
}
}