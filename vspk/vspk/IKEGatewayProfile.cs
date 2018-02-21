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

public class IKEGatewayProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIKEGatewayIdentifierType {ID_DER_ASN1_DN,ID_FQDN,ID_IPV4_ADDR,ID_KEY_ID,ID_RFC822_ADDR };
   public enum EAssociatedIKEAuthenticationType {ACLENTRY_LOCATION,ADDRESS_RANGE,ADDRESS_RANGE_STATE,ALARM,APPD_APPLICATION,APPD_EXTERNAL_APP_SERVICE,APPD_FLOW,APPD_FLOW_FORWARDING_POLICY,APPD_FLOW_SECURITY_POLICY,APPD_SERVICE,APPD_TIER,APPLICATION,AUTO_DISC_GATEWAY,BACK_HAUL_SERVICE_RESP,BGPPEER,BGP_DAMPENING_MED_RESPONSE,BGP_NEIGHBOR,BGP_NEIGHBOR_MED_RESPONSE,BGP_PROFILE,BGP_PROFILE_MED_RESPONSE,BOOTSTRAP,BOOTSTRAP_ACTIVATION,BRIDGEINTERFACE,CERTIFICATE,CHILD_ENTITY_POLICY_CHANGE,CLOUD_MGMT_SYSTEM,CONTAINER_RESYNC,CUSTOMER_VRF_SEQUENCENO,DC_CONFIG,DHCP_ALLOC_MESSAGE,DHCP_CONFIG_RESP,DHCP_OPTION,DISKSTATS,DOMAIN,DOMAIN_CONFIG,DOMAIN_CONFIG_RESP,DOMAIN_FLOATING_IP_ACL_TEMPLATE,DOMAIN_FLOATING_IP_ACL_TEMPLATE_ENTRY,DOMAIN_TEMPLATE,DSCP_FORWARDING_CLASS_MAPPING,DSCP_FORWARDING_CLASS_TABLE,EGRESS_ACL,EGRESS_ACL_ENTRY,EGRESS_ACL_TEMPLATE,EGRESS_ACL_TEMPLATE_ENTRY,EGRESS_QOS_MR,EGRESS_QOS_PRIMITIVE,EGRESS_QOS_QUEUE_MR,ENDPOINT,ENTERPRISE,ENTERPRISE_CONFIG,ENTERPRISE_CONFIG_RESP,ENTERPRISE_NETWORK,ENTERPRISE_PERMISSION,ENTERPRISE_PROFILE,ENTERPRISE_SECURED_DATA,ENTERPRISE_SECURITY,ENTITY_METADATA_BINDING,ESI_SEQUENCENO,EVENT_LOG,EVPN_BGP_COMMUNITY_TAG_ENTRY,EVPN_BGP_COMMUNITY_TAG_SEQ_NO,EXPORTIMPORT,EXTERNAL_SERVICE,FLOATINGIP,FLOATINGIP_ACL,FLOATINGIP_ACL_ENTRY,FLOATING_IP_ACL_TEMPLATE,FLOATING_IP_ACL_TEMPLATE_ENTRY,GATEWAY,GATEWAY_CONFIG,GATEWAY_CONFIG_RESP,GATEWAY_SECURED_DATA,GATEWAY_SECURITY,GATEWAY_SECURITY_PROFILE_REQUEST,GATEWAY_SECURITY_PROFILE_RESPONSE,GATEWAY_SECURITY_REQUEST,GATEWAY_SECURITY_RESPONSE,GATEWAY_SERVICE_CONFIG,GATEWAY_SERVICE_CONFIG_RESP,GATEWAY_TEMPLATE,GATEWAY_VPORT_CONFIG,GATEWAY_VPORT_CONFIG_RESP,GEO_VM_EVENT,GEO_VM_REQ,GEO_VM_RES,GROUP,GROUPKEY_ENCRYPTION_PROFILE,HEALTH_REQ,HOSTINTERFACE,HSC,IKE_CERTIFICATE,IKE_ENCRYPTION_PROFILE,IKE_GATEWAY,IKE_GATEWAY_CONFIG,IKE_GATEWAY_CONNECTION,IKE_GATEWAY_PROFILE,IKE_PSK,IKE_SUBNET,INFRASTRUCTURE_CONFIG,INFRASTRUCTURE_GATEWAY_PROFILE,INFRASTRUCTURE_PORT_PROFILE,INFRASTRUCTURE_VSC_PROFILE,INGRESS_ACL,INGRESS_ACL_ENTRY,INGRESS_ACL_TEMPLATE,INGRESS_ACL_TEMPLATE_ENTRY,INGRESS_ADV_FWD,INGRESS_ADV_FWD_ENTRY,INGRESS_ADV_FWD_TEMPLATE,INGRESS_ADV_FWD_TEMPLATE_ENTRY,INGRESS_EXT_SERVICE,INGRESS_EXT_SERVICE_ENTRY,INGRESS_EXT_SERVICE_TEMPLATE,INGRESS_EXT_SERVICE_TEMPLATE_ENTRY,IP_BINDING,JOB,KEYSERVER_MEMBER,KEYSERVER_MONITOR,KEYSERVER_MONITOR_ENCRYPTED_SEED,KEYSERVER_MONITOR_SEED,KEYSERVER_MONITOR_SEK,KEYSERVER_NOTIFICATION,L2DOMAIN,L2DOMAIN_SHARED,L2DOMAIN_TEMPLATE,LDAP_CONFIG,LIBVIRT_INTERFACE,LICENSE,LOCATION,MC_CHANNEL_MAP,MC_LIST,MC_RANGE,METADATA,METADATA_TAG,MIRROR_DESTINATION,MONITORING_PORT,MULTI_NIC_VPORT,NATMAPENTRY,NETWORK_ELEMENT,NETWORK_LAYOUT,NETWORK_MACRO_GROUP,NETWORK_POLICY_GROUP,NEXT_HOP_RESP,NODE_EXECUTION_ERROR,NSGATEWAY,NSGATEWAY_CONFIG,NSGATEWAY_TEMPLATE,NSG_NOTIFICATION,NSPORT,NSPORT_STATIC_CONFIG,NSPORT_TEMPLATE,NSPORT_VLAN_CONFIG,NSREDUNDANT_GW_GRP,NS_REDUNDANT_PORT,PATCONFIG_CONFIG_RESP,PATNATPOOL,PERMISSION,PERMITTED_ACTION,POLICING_POLICY,POLICY_DECISION,POLICY_GROUP,POLICY_GROUP_TEMPLATE,PORT,PORT_MR,PORT_PUSH,PORT_TEMPLATE,PORT_VLAN_CONFIG,PORT_VLAN_CONFIG_RESPONSE,PUBLIC_NETWORK,QOS_PRIMITIVE,RATE_LIMITER,RD_SEQUENCENO,REDUNDANT_GW_GRP,ROUTING_POLICY,ROUTING_POL_MED_RESPONSE,RTRD_ENTITY,RTRD_SEQUENCENO,SERVICES_GATEWAY_RESPONSE,SERVICE_GATEWAY_RESPONSE,SERVICE_VRF_SEQUENCENO,SHAPING_POLICY,SHARED_RESOURCE,SITE,SITE_REQ,SITE_RES,STATIC_ROUTE,STATIC_ROUTE_RESP,STATISTICS,STATSSERVER,STATS_COLLECTOR,STATS_POLICY,STATS_TCA,SUBNET,SUBNET_ENTRY,SUBNET_MAC_ENTRY,SUBNET_POOL_ENTRY,SUBNET_TEMPLATE,SYSTEM_CONFIG,SYSTEM_CONFIG_REQ,SYSTEM_CONFIG_RESP,SYSTEM_MONITORING,UNSUPPORTED,UPLINK_RD,USER,VIRTUAL_IP,VIRTUAL_MACHINE,VIRTUAL_MACHINE_REPORT,VLAN,VLAN_CONFIG_RESPONSE,VLAN_TEMPLATE,VMWARE_RELOAD_CONFIG,VMWARE_VCENTER,VMWARE_VCENTER_CLUSTER,VMWARE_VCENTER_DATACENTER,VMWARE_VCENTER_EAM_CONFIG,VMWARE_VCENTER_HYPERVISOR,VMWARE_VCENTER_VRS_BASE_CONFIG,VMWARE_VCENTER_VRS_CONFIG,VMWARE_VRS_ADDRESS_RANGE,VM_DESCRIPTION,VM_INTERFACE,VM_RESYNC,VNID_SEQUENCENO,VPN_CONNECT,VPORT,VPORTTAG,VPORTTAGTEMPLATE,VPORT_GATEWAY_RESPONSE,VPORT_MEDIATION_REQUEST,VPORT_MIRROR,VPORT_TAG_BASE,VPRN_LABEL_SEQUENCENO,VRS,VSC,VSD,VSD_COMPONENT,VSG_REDUNDANT_PORT,VSP,WAN_SERVICE,ZONE,ZONE_TEMPLATE };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EServiceClass {A,B,C,D,E,F,G,H,NONE };

   
   [JsonProperty("IKEGatewayIdentifier")]
   protected String _IKEGatewayIdentifier;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IKEGatewayIdentifierType")]
   protected EIKEGatewayIdentifierType? _IKEGatewayIdentifierType;
   
   [JsonProperty("antiReplayCheck")]
   protected bool _antiReplayCheck;
   
   [JsonProperty("associatedEnterpriseID")]
   protected String _associatedEnterpriseID;
   
   [JsonProperty("associatedIKEAuthenticationID")]
   protected String _associatedIKEAuthenticationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedIKEAuthenticationType")]
   protected EAssociatedIKEAuthenticationType? _associatedIKEAuthenticationType;
   
   [JsonProperty("associatedIKEEncryptionProfileID")]
   protected String _associatedIKEEncryptionProfileID;
   
   [JsonProperty("associatedIKEGatewayID")]
   protected String _associatedIKEGatewayID;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("serviceClass")]
   protected EServiceClass? _serviceClass;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public IKEGatewayProfile() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUIKEGatewayIdentifier {
      get {
         return _IKEGatewayIdentifier;
      }
      set {
         this._IKEGatewayIdentifier = value;
      }
   }

   
   [JsonIgnore]
   public EIKEGatewayIdentifierType? NUIKEGatewayIdentifierType {
      get {
         return _IKEGatewayIdentifierType;
      }
      set {
         this._IKEGatewayIdentifierType = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAntiReplayCheck {
      get {
         return _antiReplayCheck;
      }
      set {
         this._antiReplayCheck = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEnterpriseID {
      get {
         return _associatedEnterpriseID;
      }
      set {
         this._associatedEnterpriseID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEAuthenticationID {
      get {
         return _associatedIKEAuthenticationID;
      }
      set {
         this._associatedIKEAuthenticationID = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedIKEAuthenticationType? NUAssociatedIKEAuthenticationType {
      get {
         return _associatedIKEAuthenticationType;
      }
      set {
         this._associatedIKEAuthenticationType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEEncryptionProfileID {
      get {
         return _associatedIKEEncryptionProfileID;
      }
      set {
         this._associatedIKEEncryptionProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIKEGatewayID {
      get {
         return _associatedIKEGatewayID;
      }
      set {
         this._associatedIKEGatewayID = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public EServiceClass? NUServiceClass {
      get {
         return _serviceClass;
      }
      set {
         this._serviceClass = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "IKEGatewayProfile [" + "IKEGatewayIdentifier=" + _IKEGatewayIdentifier + ", IKEGatewayIdentifierType=" + _IKEGatewayIdentifierType + ", antiReplayCheck=" + _antiReplayCheck + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", associatedIKEAuthenticationID=" + _associatedIKEAuthenticationID + ", associatedIKEAuthenticationType=" + _associatedIKEAuthenticationType + ", associatedIKEEncryptionProfileID=" + _associatedIKEEncryptionProfileID + ", associatedIKEGatewayID=" + _associatedIKEGatewayID + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", serviceClass=" + _serviceClass + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ikegatewayprofiles";
   }

   public static String getRestName()
   {
	return "ikegatewayprofile";
   }
}
}