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

public class SharedNetworkResource: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedActionType {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EType {FLOATING,L2DOMAIN,PUBLIC,UPLINK_SUBNET };
   public enum EUseGlobalMAC {DISABLED,ENABLED };

   
   [JsonProperty("DHCPManaged")]
   protected bool _DHCPManaged;
   
   [JsonProperty("ECMPCount")]
   protected long? _ECMPCount;
   
   [JsonProperty("accessRestrictionEnabled")]
   protected bool _accessRestrictionEnabled;
   
   [JsonProperty("address")]
   protected String _address;
   
   [JsonProperty("associatedPATMapperID")]
   protected String _associatedPATMapperID;
   
   [JsonProperty("backHaulRouteDistinguisher")]
   protected String _backHaulRouteDistinguisher;
   
   [JsonProperty("backHaulRouteTarget")]
   protected String _backHaulRouteTarget;
   
   [JsonProperty("backHaulVNID")]
   protected long? _backHaulVNID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("domainRouteDistinguisher")]
   protected String _domainRouteDistinguisher;
   
   [JsonProperty("domainRouteTarget")]
   protected String _domainRouteTarget;
   
   [JsonProperty("dynamicPATAllocationEnabled")]
   protected bool _dynamicPATAllocationEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("gateway")]
   protected String _gateway;
   
   [JsonProperty("gatewayMACAddress")]
   protected String _gatewayMACAddress;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedActionType")]
   protected EPermittedActionType? _permittedActionType;
   
   [JsonProperty("sharedResourceParentID")]
   protected String _sharedResourceParentID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   
   [JsonProperty("underlay")]
   protected bool _underlay;
   
   [JsonProperty("uplinkGWVlanAttachmentID")]
   protected String _uplinkGWVlanAttachmentID;
   
   [JsonProperty("uplinkInterfaceIP")]
   protected String _uplinkInterfaceIP;
   
   [JsonProperty("uplinkInterfaceMAC")]
   protected String _uplinkInterfaceMAC;
   
   [JsonProperty("uplinkVPortName")]
   protected String _uplinkVPortName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("useGlobalMAC")]
   protected EUseGlobalMAC? _useGlobalMAC;
   
   [JsonProperty("vnID")]
   protected long? _vnID;
   

   
   [JsonIgnore]
   private AddressRangesFetcher _addressRanges;
   
   [JsonIgnore]
   private DHCPOptionsFetcher _dHCPOptions;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PATIPEntriesFetcher _pATIPEntries;
   
   [JsonIgnore]
   private StaticRoutesFetcher _staticRoutes;
   
   [JsonIgnore]
   private VPNConnectionsFetcher _vPNConnections;
   
   public SharedNetworkResource() {
      _type = EType.PUBLIC;
      _DHCPManaged = true;
      
      _addressRanges = new AddressRangesFetcher(this);
      
      _dHCPOptions = new DHCPOptionsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _pATIPEntries = new PATIPEntriesFetcher(this);
      
      _staticRoutes = new StaticRoutesFetcher(this);
      
      _vPNConnections = new VPNConnectionsFetcher(this);
      
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
   public long? NUECMPCount {
      get {
         return _ECMPCount;
      }
      set {
         this._ECMPCount = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAccessRestrictionEnabled {
      get {
         return _accessRestrictionEnabled;
      }
      set {
         this._accessRestrictionEnabled = value;
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
   public String NUAssociatedPATMapperID {
      get {
         return _associatedPATMapperID;
      }
      set {
         this._associatedPATMapperID = value;
      }
   }

   
   [JsonIgnore]
   public String NUBackHaulRouteDistinguisher {
      get {
         return _backHaulRouteDistinguisher;
      }
      set {
         this._backHaulRouteDistinguisher = value;
      }
   }

   
   [JsonIgnore]
   public String NUBackHaulRouteTarget {
      get {
         return _backHaulRouteTarget;
      }
      set {
         this._backHaulRouteTarget = value;
      }
   }

   
   [JsonIgnore]
   public long? NUBackHaulVNID {
      get {
         return _backHaulVNID;
      }
      set {
         this._backHaulVNID = value;
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
   public String NUDomainRouteDistinguisher {
      get {
         return _domainRouteDistinguisher;
      }
      set {
         this._domainRouteDistinguisher = value;
      }
   }

   
   [JsonIgnore]
   public String NUDomainRouteTarget {
      get {
         return _domainRouteTarget;
      }
      set {
         this._domainRouteTarget = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDynamicPATAllocationEnabled {
      get {
         return _dynamicPATAllocationEnabled;
      }
      set {
         this._dynamicPATAllocationEnabled = value;
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
   public String NUGateway {
      get {
         return _gateway;
      }
      set {
         this._gateway = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayMACAddress {
      get {
         return _gatewayMACAddress;
      }
      set {
         this._gatewayMACAddress = value;
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
   public String NUNetmask {
      get {
         return _netmask;
      }
      set {
         this._netmask = value;
      }
   }

   
   [JsonIgnore]
   public EPermittedActionType? NUPermittedActionType {
      get {
         return _permittedActionType;
      }
      set {
         this._permittedActionType = value;
      }
   }

   
   [JsonIgnore]
   public String NUSharedResourceParentID {
      get {
         return _sharedResourceParentID;
      }
      set {
         this._sharedResourceParentID = value;
      }
   }

   
   [JsonIgnore]
   public EType? NUType {
      get {
         return _type;
      }
      set {
         this._type = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUnderlay {
      get {
         return _underlay;
      }
      set {
         this._underlay = value;
      }
   }

   
   [JsonIgnore]
   public String NUUplinkGWVlanAttachmentID {
      get {
         return _uplinkGWVlanAttachmentID;
      }
      set {
         this._uplinkGWVlanAttachmentID = value;
      }
   }

   
   [JsonIgnore]
   public String NUUplinkInterfaceIP {
      get {
         return _uplinkInterfaceIP;
      }
      set {
         this._uplinkInterfaceIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUUplinkInterfaceMAC {
      get {
         return _uplinkInterfaceMAC;
      }
      set {
         this._uplinkInterfaceMAC = value;
      }
   }

   
   [JsonIgnore]
   public String NUUplinkVPortName {
      get {
         return _uplinkVPortName;
      }
      set {
         this._uplinkVPortName = value;
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

   
   [JsonIgnore]
   public long? NUVnID {
      get {
         return _vnID;
      }
      set {
         this._vnID = value;
      }
   }

   

   
   public AddressRangesFetcher getAddressRanges() {
      return _addressRanges;
   }
   
   public DHCPOptionsFetcher getDHCPOptions() {
      return _dHCPOptions;
   }
   
   public EnterprisePermissionsFetcher getEnterprisePermissions() {
      return _enterprisePermissions;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PATIPEntriesFetcher getPATIPEntries() {
      return _pATIPEntries;
   }
   
   public StaticRoutesFetcher getStaticRoutes() {
      return _staticRoutes;
   }
   
   public VPNConnectionsFetcher getVPNConnections() {
      return _vPNConnections;
   }
   

   public String toString() {
      return "SharedNetworkResource [" + "DHCPManaged=" + _DHCPManaged + ", ECMPCount=" + _ECMPCount + ", accessRestrictionEnabled=" + _accessRestrictionEnabled + ", address=" + _address + ", associatedPATMapperID=" + _associatedPATMapperID + ", backHaulRouteDistinguisher=" + _backHaulRouteDistinguisher + ", backHaulRouteTarget=" + _backHaulRouteTarget + ", backHaulVNID=" + _backHaulVNID + ", description=" + _description + ", domainRouteDistinguisher=" + _domainRouteDistinguisher + ", domainRouteTarget=" + _domainRouteTarget + ", dynamicPATAllocationEnabled=" + _dynamicPATAllocationEnabled + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gateway=" + _gateway + ", gatewayMACAddress=" + _gatewayMACAddress + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", netmask=" + _netmask + ", permittedActionType=" + _permittedActionType + ", sharedResourceParentID=" + _sharedResourceParentID + ", type=" + _type + ", underlay=" + _underlay + ", uplinkGWVlanAttachmentID=" + _uplinkGWVlanAttachmentID + ", uplinkInterfaceIP=" + _uplinkInterfaceIP + ", uplinkInterfaceMAC=" + _uplinkInterfaceMAC + ", uplinkVPortName=" + _uplinkVPortName + ", useGlobalMAC=" + _useGlobalMAC + ", vnID=" + _vnID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "sharednetworkresources";
   }

   public static String getRestName()
   {
	return "sharednetworkresource";
   }
}
}