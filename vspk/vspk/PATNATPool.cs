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

public class PATNATPool: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIPType {DUALSTACK,IPV4,IPV6 };
   public enum EAssociatedGatewayType {AUTO_DISC_GATEWAY,GATEWAY,IKE_GATEWAY,NSGATEWAY };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   
   [JsonProperty("addressRange")]
   protected String _addressRange;
   
   [JsonProperty("associatedGatewayId")]
   protected String _associatedGatewayId;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedGatewayType")]
   protected EAssociatedGatewayType? _associatedGatewayType;
   
   [JsonProperty("associatedSubnetId")]
   protected String _associatedSubnetId;
   
   [JsonProperty("associatedVlanId")]
   protected String _associatedVlanId;
   
   [JsonProperty("defaultPATIP")]
   protected String _defaultPATIP;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("dynamicSourceEnabled")]
   protected bool _dynamicSourceEnabled;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   
   [JsonProperty("endAddressRange")]
   protected String _endAddressRange;
   
   [JsonProperty("endSourceAddress")]
   protected String _endSourceAddress;
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
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("startAddressRange")]
   protected String _startAddressRange;
   
   [JsonProperty("startSourceAddress")]
   protected String _startSourceAddress;
   

   
   [JsonIgnore]
   private AddressMapsFetcher _addressMaps;
   
   [JsonIgnore]
   private BulkStatisticsFetcher _bulkStatistics;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NATMapEntriesFetcher _nATMapEntries;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private StatisticsPoliciesFetcher _statisticsPolicies;
   
   public PATNATPool() {
      
      _addressMaps = new AddressMapsFetcher(this);
      
      _bulkStatistics = new BulkStatisticsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _nATMapEntries = new NATMapEntriesFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _statisticsPolicies = new StatisticsPoliciesFetcher(this);
      
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
   public String NUAddressRange {
      get {
         return _addressRange;
      }
      set {
         this._addressRange = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewayId {
      get {
         return _associatedGatewayId;
      }
      set {
         this._associatedGatewayId = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedGatewayType? NUAssociatedGatewayType {
      get {
         return _associatedGatewayType;
      }
      set {
         this._associatedGatewayType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSubnetId {
      get {
         return _associatedSubnetId;
      }
      set {
         this._associatedSubnetId = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVlanId {
      get {
         return _associatedVlanId;
      }
      set {
         this._associatedVlanId = value;
      }
   }

   
   [JsonIgnore]
   public String NUDefaultPATIP {
      get {
         return _defaultPATIP;
      }
      set {
         this._defaultPATIP = value;
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
   public bool NUDynamicSourceEnabled {
      get {
         return _dynamicSourceEnabled;
      }
      set {
         this._dynamicSourceEnabled = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
      }
   }

   
   [JsonIgnore]
   public String NUEndAddressRange {
      get {
         return _endAddressRange;
      }
      set {
         this._endAddressRange = value;
      }
   }

   
   [JsonIgnore]
   public String NUEndSourceAddress {
      get {
         return _endSourceAddress;
      }
      set {
         this._endSourceAddress = value;
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
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
      }
   }

   
   [JsonIgnore]
   public String NUStartAddressRange {
      get {
         return _startAddressRange;
      }
      set {
         this._startAddressRange = value;
      }
   }

   
   [JsonIgnore]
   public String NUStartSourceAddress {
      get {
         return _startSourceAddress;
      }
      set {
         this._startSourceAddress = value;
      }
   }

   

   
   public AddressMapsFetcher getAddressMaps() {
      return _addressMaps;
   }
   
   public BulkStatisticsFetcher getBulkStatistics() {
      return _bulkStatistics;
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
   
   public NATMapEntriesFetcher getNATMapEntries() {
      return _nATMapEntries;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   
   public StatisticsPoliciesFetcher getStatisticsPolicies() {
      return _statisticsPolicies;
   }
   

   public String toString() {
      return "PATNATPool [" + "IPType=" + _IPType + ", addressRange=" + _addressRange + ", associatedGatewayId=" + _associatedGatewayId + ", associatedGatewayType=" + _associatedGatewayType + ", associatedSubnetId=" + _associatedSubnetId + ", associatedVlanId=" + _associatedVlanId + ", defaultPATIP=" + _defaultPATIP + ", description=" + _description + ", dynamicSourceEnabled=" + _dynamicSourceEnabled + ", embeddedMetadata=" + _embeddedMetadata + ", endAddressRange=" + _endAddressRange + ", endSourceAddress=" + _endSourceAddress + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", permittedAction=" + _permittedAction + ", startAddressRange=" + _startAddressRange + ", startSourceAddress=" + _startSourceAddress + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "patnatpools";
   }

   public static String getRestName()
   {
	return "patnatpool";
   }
}
}