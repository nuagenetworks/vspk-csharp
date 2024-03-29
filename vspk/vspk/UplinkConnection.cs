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

public class UplinkConnection: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAddressFamily {IPV4,IPV6 };
   public enum EAdvertisementCriteria {BFD,CONTROL_SESSION,OPERATIONAL_LINK };
   public enum EAuxMode {COLD,HOT,NONE };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EFecEnabled {ACTIVE,DISABLED,PASSIVE };
   public enum EInterfaceConnectionType {AUTOMATIC,EMBEDDED,PCI_EXPRESS,USB_ETHERNET,USB_MODEM };
   public enum EMode {Any,Dynamic,LTE,PPPoE,Static };
   public enum ERole {NONE,PRIMARY,SECONDARY,TERTIARY,UNKNOWN };
   public enum EUplinkType {CONTROL,DATA,SHUNT,UPLINK };

   
   [JsonProperty("DNSAddress")]
   protected String _DNSAddress;
   
   [JsonProperty("DNSAddressV6")]
   protected String _DNSAddressV6;
   
   [JsonProperty("PATEnabled")]
   protected bool _PATEnabled;
   
   [JsonProperty("address")]
   protected String _address;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("addressFamily")]
   protected EAddressFamily? _addressFamily;
   
   [JsonProperty("addressV6")]
   protected String _addressV6;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("advertisementCriteria")]
   protected EAdvertisementCriteria? _advertisementCriteria;
   
   [JsonProperty("assocUnderlayID")]
   protected String _assocUnderlayID;
   
   [JsonProperty("associatedBGPNeighborID")]
   protected String _associatedBGPNeighborID;
   
   [JsonProperty("associatedUnderlayName")]
   protected String _associatedUnderlayName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("auxMode")]
   protected EAuxMode? _auxMode;
   
   [JsonProperty("auxiliaryLink")]
   protected bool _auxiliaryLink;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("downloadRateLimit")]
   protected float _downloadRateLimit;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("fecEnabled")]
   protected EFecEnabled? _fecEnabled;
   
   [JsonProperty("gateway")]
   protected String _gateway;
   
   [JsonProperty("gatewayID")]
   protected String _gatewayID;
   
   [JsonProperty("gatewayV6")]
   protected String _gatewayV6;
   
   [JsonProperty("inherited")]
   protected bool _inherited;
   
   [JsonProperty("installerManaged")]
   protected bool _installerManaged;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("interfaceConnectionType")]
   protected EInterfaceConnectionType? _interfaceConnectionType;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("mode")]
   protected EMode? _mode;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("password")]
   protected String _password;
   
   [JsonProperty("portID")]
   protected String _portID;
   
   [JsonProperty("portName")]
   protected String _portName;
   
   [JsonProperty("primaryDataPathID")]
   protected String _primaryDataPathID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("role")]
   protected ERole? _role;
   
   [JsonProperty("roleOrder")]
   protected long? _roleOrder;
   
   [JsonProperty("secondaryAddress")]
   protected String _secondaryAddress;
   
   [JsonProperty("underlayEnabled")]
   protected bool _underlayEnabled;
   
   [JsonProperty("underlayID")]
   protected long? _underlayID;
   
   [JsonProperty("uplinkID")]
   protected long? _uplinkID;
   
   [JsonProperty("uplinkName")]
   protected String _uplinkName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("uplinkType")]
   protected EUplinkType? _uplinkType;
   
   [JsonProperty("username")]
   protected String _username;
   
   [JsonProperty("vlan")]
   protected long? _vlan;
   
   [JsonProperty("vlanID")]
   protected String _vlanID;
   

   
   [JsonIgnore]
   private BFDSessionsFetcher _bFDSessions;
   
   [JsonIgnore]
   private CustomPropertiesFetcher _customProperties;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private UnderlayTestsFetcher _underlayTests;
   
   public UplinkConnection() {
      
      _bFDSessions = new BFDSessionsFetcher(this);
      
      _customProperties = new CustomPropertiesFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _underlayTests = new UnderlayTestsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUDNSAddress {
      get {
         return _DNSAddress;
      }
      set {
         this._DNSAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUDNSAddressV6 {
      get {
         return _DNSAddressV6;
      }
      set {
         this._DNSAddressV6 = value;
      }
   }

   
   [JsonIgnore]
   public bool NUPATEnabled {
      get {
         return _PATEnabled;
      }
      set {
         this._PATEnabled = value;
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
   public EAddressFamily? NUAddressFamily {
      get {
         return _addressFamily;
      }
      set {
         this._addressFamily = value;
      }
   }

   
   [JsonIgnore]
   public String NUAddressV6 {
      get {
         return _addressV6;
      }
      set {
         this._addressV6 = value;
      }
   }

   
   [JsonIgnore]
   public EAdvertisementCriteria? NUAdvertisementCriteria {
      get {
         return _advertisementCriteria;
      }
      set {
         this._advertisementCriteria = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssocUnderlayID {
      get {
         return _assocUnderlayID;
      }
      set {
         this._assocUnderlayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedBGPNeighborID {
      get {
         return _associatedBGPNeighborID;
      }
      set {
         this._associatedBGPNeighborID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedUnderlayName {
      get {
         return _associatedUnderlayName;
      }
      set {
         this._associatedUnderlayName = value;
      }
   }

   
   [JsonIgnore]
   public EAuxMode? NUAuxMode {
      get {
         return _auxMode;
      }
      set {
         this._auxMode = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAuxiliaryLink {
      get {
         return _auxiliaryLink;
      }
      set {
         this._auxiliaryLink = value;
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
   public float NUDownloadRateLimit {
      get {
         return _downloadRateLimit;
      }
      set {
         this._downloadRateLimit = value;
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
   public EFecEnabled? NUFecEnabled {
      get {
         return _fecEnabled;
      }
      set {
         this._fecEnabled = value;
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
   public String NUGatewayID {
      get {
         return _gatewayID;
      }
      set {
         this._gatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayV6 {
      get {
         return _gatewayV6;
      }
      set {
         this._gatewayV6 = value;
      }
   }

   
   [JsonIgnore]
   public bool NUInherited {
      get {
         return _inherited;
      }
      set {
         this._inherited = value;
      }
   }

   
   [JsonIgnore]
   public bool NUInstallerManaged {
      get {
         return _installerManaged;
      }
      set {
         this._installerManaged = value;
      }
   }

   
   [JsonIgnore]
   public EInterfaceConnectionType? NUInterfaceConnectionType {
      get {
         return _interfaceConnectionType;
      }
      set {
         this._interfaceConnectionType = value;
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
   public EMode? NUMode {
      get {
         return _mode;
      }
      set {
         this._mode = value;
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
   public String NUPassword {
      get {
         return _password;
      }
      set {
         this._password = value;
      }
   }

   
   [JsonIgnore]
   public String NUPortID {
      get {
         return _portID;
      }
      set {
         this._portID = value;
      }
   }

   
   [JsonIgnore]
   public String NUPortName {
      get {
         return _portName;
      }
      set {
         this._portName = value;
      }
   }

   
   [JsonIgnore]
   public String NUPrimaryDataPathID {
      get {
         return _primaryDataPathID;
      }
      set {
         this._primaryDataPathID = value;
      }
   }

   
   [JsonIgnore]
   public ERole? NURole {
      get {
         return _role;
      }
      set {
         this._role = value;
      }
   }

   
   [JsonIgnore]
   public long? NURoleOrder {
      get {
         return _roleOrder;
      }
      set {
         this._roleOrder = value;
      }
   }

   
   [JsonIgnore]
   public String NUSecondaryAddress {
      get {
         return _secondaryAddress;
      }
      set {
         this._secondaryAddress = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUnderlayEnabled {
      get {
         return _underlayEnabled;
      }
      set {
         this._underlayEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUUnderlayID {
      get {
         return _underlayID;
      }
      set {
         this._underlayID = value;
      }
   }

   
   [JsonIgnore]
   public long? NUUplinkID {
      get {
         return _uplinkID;
      }
      set {
         this._uplinkID = value;
      }
   }

   
   [JsonIgnore]
   public String NUUplinkName {
      get {
         return _uplinkName;
      }
      set {
         this._uplinkName = value;
      }
   }

   
   [JsonIgnore]
   public EUplinkType? NUUplinkType {
      get {
         return _uplinkType;
      }
      set {
         this._uplinkType = value;
      }
   }

   
   [JsonIgnore]
   public String NUUsername {
      get {
         return _username;
      }
      set {
         this._username = value;
      }
   }

   
   [JsonIgnore]
   public long? NUVlan {
      get {
         return _vlan;
      }
      set {
         this._vlan = value;
      }
   }

   
   [JsonIgnore]
   public String NUVlanID {
      get {
         return _vlanID;
      }
      set {
         this._vlanID = value;
      }
   }

   

   
   public BFDSessionsFetcher getBFDSessions() {
      return _bFDSessions;
   }
   
   public CustomPropertiesFetcher getCustomProperties() {
      return _customProperties;
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
   
   public UnderlayTestsFetcher getUnderlayTests() {
      return _underlayTests;
   }
   

   public String toString() {
      return "UplinkConnection [" + "DNSAddress=" + _DNSAddress + ", DNSAddressV6=" + _DNSAddressV6 + ", PATEnabled=" + _PATEnabled + ", address=" + _address + ", addressFamily=" + _addressFamily + ", addressV6=" + _addressV6 + ", advertisementCriteria=" + _advertisementCriteria + ", assocUnderlayID=" + _assocUnderlayID + ", associatedBGPNeighborID=" + _associatedBGPNeighborID + ", associatedUnderlayName=" + _associatedUnderlayName + ", auxMode=" + _auxMode + ", auxiliaryLink=" + _auxiliaryLink + ", creationDate=" + _creationDate + ", downloadRateLimit=" + _downloadRateLimit + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", fecEnabled=" + _fecEnabled + ", gateway=" + _gateway + ", gatewayID=" + _gatewayID + ", gatewayV6=" + _gatewayV6 + ", inherited=" + _inherited + ", installerManaged=" + _installerManaged + ", interfaceConnectionType=" + _interfaceConnectionType + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", mode=" + _mode + ", netmask=" + _netmask + ", owner=" + _owner + ", password=" + _password + ", portID=" + _portID + ", portName=" + _portName + ", primaryDataPathID=" + _primaryDataPathID + ", role=" + _role + ", roleOrder=" + _roleOrder + ", secondaryAddress=" + _secondaryAddress + ", underlayEnabled=" + _underlayEnabled + ", underlayID=" + _underlayID + ", uplinkID=" + _uplinkID + ", uplinkName=" + _uplinkName + ", uplinkType=" + _uplinkType + ", username=" + _username + ", vlan=" + _vlan + ", vlanID=" + _vlanID + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "uplinkconnections";
   }

   public static String getRestName()
   {
	return "uplinkconnection";
   }
}
}