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

public class UplinkConnection: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAdvertisementCriteria {BFD,CONTROL_SESSION,OPERATIONAL_LINK };
   public enum EInterfaceConnectionType {AUTOMATIC,EMBEDDED,PCI_EXPRESS,USB_ETHERNET,USB_MODEM };
   public enum EMode {Dynamic,LTE,PPPoE,Static };
   public enum ERole {NONE,PRIMARY,SECONDARY,TERTIARY,UNKNOWN };

   
   [JsonProperty("DNSAddress")]
   protected String _DNSAddress;
   
   [JsonProperty("PATEnabled")]
   protected bool _PATEnabled;
   
   [JsonProperty("address")]
   protected String _address;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("advertisementCriteria")]
   protected EAdvertisementCriteria? _advertisementCriteria;
   
   [JsonProperty("assocUnderlayID")]
   protected String _assocUnderlayID;
   
   [JsonProperty("associatedBGPNeighborID")]
   protected String _associatedBGPNeighborID;
   
   [JsonProperty("associatedUnderlayName")]
   protected String _associatedUnderlayName;
   
   [JsonProperty("auxiliaryLink")]
   protected bool _auxiliaryLink;
   
   [JsonProperty("downloadRateLimit")]
   protected float _downloadRateLimit;
   
   [JsonProperty("gateway")]
   protected String _gateway;
   
   [JsonProperty("installerManaged")]
   protected bool _installerManaged;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("interfaceConnectionType")]
   protected EInterfaceConnectionType? _interfaceConnectionType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("mode")]
   protected EMode? _mode;
   
   [JsonProperty("netmask")]
   protected String _netmask;
   
   [JsonProperty("password")]
   protected String _password;
   
   [JsonProperty("portName")]
   protected String _portName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("role")]
   protected ERole? _role;
   
   [JsonProperty("roleOrder")]
   protected String _roleOrder;
   
   [JsonProperty("secondaryAddress")]
   protected String _secondaryAddress;
   
   [JsonProperty("underlayEnabled")]
   protected bool _underlayEnabled;
   
   [JsonProperty("uplinkID")]
   protected long? _uplinkID;
   
   [JsonProperty("username")]
   protected String _username;
   
   [JsonProperty("vlanId")]
   protected String _vlanId;
   

   
   [JsonIgnore]
   private BFDSessionsFetcher _bFDSessions;
   
   [JsonIgnore]
   private CustomPropertiesFetcher _customProperties;
   
   [JsonIgnore]
   private UnderlaysFetcher _underlays;
   
   public UplinkConnection() {
      
      _bFDSessions = new BFDSessionsFetcher(this);
      
      _customProperties = new CustomPropertiesFetcher(this);
      
      _underlays = new UnderlaysFetcher(this);
      
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
   public bool NUAuxiliaryLink {
      get {
         return _auxiliaryLink;
      }
      set {
         this._auxiliaryLink = value;
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
   public String NUGateway {
      get {
         return _gateway;
      }
      set {
         this._gateway = value;
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
   public String NUPassword {
      get {
         return _password;
      }
      set {
         this._password = value;
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
   public ERole? NURole {
      get {
         return _role;
      }
      set {
         this._role = value;
      }
   }

   
   [JsonIgnore]
   public String NURoleOrder {
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
   public long? NUUplinkID {
      get {
         return _uplinkID;
      }
      set {
         this._uplinkID = value;
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
   public String NUVlanId {
      get {
         return _vlanId;
      }
      set {
         this._vlanId = value;
      }
   }

   

   
   public BFDSessionsFetcher getBFDSessions() {
      return _bFDSessions;
   }
   
   public CustomPropertiesFetcher getCustomProperties() {
      return _customProperties;
   }
   
   public UnderlaysFetcher getUnderlays() {
      return _underlays;
   }
   

   public String toString() {
      return "UplinkConnection [" + "DNSAddress=" + _DNSAddress + ", PATEnabled=" + _PATEnabled + ", address=" + _address + ", advertisementCriteria=" + _advertisementCriteria + ", assocUnderlayID=" + _assocUnderlayID + ", associatedBGPNeighborID=" + _associatedBGPNeighborID + ", associatedUnderlayName=" + _associatedUnderlayName + ", auxiliaryLink=" + _auxiliaryLink + ", downloadRateLimit=" + _downloadRateLimit + ", gateway=" + _gateway + ", installerManaged=" + _installerManaged + ", interfaceConnectionType=" + _interfaceConnectionType + ", mode=" + _mode + ", netmask=" + _netmask + ", password=" + _password + ", portName=" + _portName + ", role=" + _role + ", roleOrder=" + _roleOrder + ", secondaryAddress=" + _secondaryAddress + ", underlayEnabled=" + _underlayEnabled + ", uplinkID=" + _uplinkID + ", username=" + _username + ", vlanId=" + _vlanId + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
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