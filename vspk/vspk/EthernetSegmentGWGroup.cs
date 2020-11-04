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

public class EthernetSegmentGWGroup: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EPersonality {NETCONF_7X50 };

   
   [JsonProperty("assocGatewaysNames")]
   protected System.Collections.Generic.List<String> _assocGatewaysNames;
   
   [JsonProperty("assocGatewaysStatus")]
   protected System.Collections.Generic.List<String> _assocGatewaysStatus;
   
   [JsonProperty("associatedGatewayIDs")]
   protected System.Collections.Generic.List<String> _associatedGatewayIDs;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("personality")]
   protected EPersonality? _personality;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private DeploymentFailuresFetcher _deploymentFailures;
   
   [JsonIgnore]
   private DomainsFetcher _domains;
   
   [JsonIgnore]
   private EgressProfilesFetcher _egressProfiles;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private EthernetSegmentGroupsFetcher _ethernetSegmentGroups;
   
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
   private MACFilterProfilesFetcher _mACFilterProfiles;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private SAPEgressQoSProfilesFetcher _sAPEgressQoSProfiles;
   
   [JsonIgnore]
   private SAPIngressQoSProfilesFetcher _sAPIngressQoSProfiles;
   
   public EthernetSegmentGWGroup() {
      
      _alarms = new AlarmsFetcher(this);
      
      _deploymentFailures = new DeploymentFailuresFetcher(this);
      
      _domains = new DomainsFetcher(this);
      
      _egressProfiles = new EgressProfilesFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _ethernetSegmentGroups = new EthernetSegmentGroupsFetcher(this);
      
      _ingressProfiles = new IngressProfilesFetcher(this);
      
      _iPFilterProfiles = new IPFilterProfilesFetcher(this);
      
      _iPv6FilterProfiles = new IPv6FilterProfilesFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _l2Domains = new L2DomainsFetcher(this);
      
      _mACFilterProfiles = new MACFilterProfilesFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _sAPEgressQoSProfiles = new SAPEgressQoSProfilesFetcher(this);
      
      _sAPIngressQoSProfiles = new SAPIngressQoSProfilesFetcher(this);
      
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUAssocGatewaysNames {
      get {
         return _assocGatewaysNames;
      }
      set {
         this._assocGatewaysNames = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUAssocGatewaysStatus {
      get {
         return _assocGatewaysStatus;
      }
      set {
         this._assocGatewaysStatus = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUAssociatedGatewayIDs {
      get {
         return _associatedGatewayIDs;
      }
      set {
         this._associatedGatewayIDs = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
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

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
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
   
   public EthernetSegmentGroupsFetcher getEthernetSegmentGroups() {
      return _ethernetSegmentGroups;
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
   
   public MACFilterProfilesFetcher getMACFilterProfiles() {
      return _mACFilterProfiles;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public SAPEgressQoSProfilesFetcher getSAPEgressQoSProfiles() {
      return _sAPEgressQoSProfiles;
   }
   
   public SAPIngressQoSProfilesFetcher getSAPIngressQoSProfiles() {
      return _sAPIngressQoSProfiles;
   }
   

   public String toString() {
      return "EthernetSegmentGWGroup [" + "assocGatewaysNames=" + _assocGatewaysNames + ", assocGatewaysStatus=" + _assocGatewaysStatus + ", associatedGatewayIDs=" + _associatedGatewayIDs + ", description=" + _description + ", name=" + _name + ", personality=" + _personality + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ethernetsegmentgwgroups";
   }

   public static String getRestName()
   {
	return "ethernetsegmentgwgroup";
   }
}
}