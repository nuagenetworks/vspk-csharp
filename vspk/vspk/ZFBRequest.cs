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

public class ZFBRequest: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EZFBApprovalStatus {APPROVED,ASSIGNED,DENIED,UNASSIGNED };
   public enum EAssociatedEntityType {GATEWAY,NSGATEWAY };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ERequestType {SELF_REBOOTSTRAP,ZFB };

   
   [JsonProperty("CPUType")]
   protected String _CPUType;
   
   [JsonProperty("IPAddress")]
   protected String _IPAddress;
   
   [JsonProperty("MACAddress")]
   protected String _MACAddress;
   
   [JsonProperty("NSGVersion")]
   protected String _NSGVersion;
   
   [JsonProperty("SKU")]
   protected String _SKU;
   
   [JsonProperty("UUID")]
   protected String _UUID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ZFBApprovalStatus")]
   protected EZFBApprovalStatus? _ZFBApprovalStatus;
   
   [JsonProperty("ZFBBootstrapEnabled")]
   protected bool _ZFBBootstrapEnabled;
   
   [JsonProperty("ZFBInfo")]
   protected String _ZFBInfo;
   
   [JsonProperty("ZFBRequestRetryTimer")]
   protected long? _ZFBRequestRetryTimer;
   
   [JsonProperty("associatedEnterpriseID")]
   protected String _associatedEnterpriseID;
   
   [JsonProperty("associatedEnterpriseName")]
   protected String _associatedEnterpriseName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("associatedEntityType")]
   protected EAssociatedEntityType? _associatedEntityType;
   
   [JsonProperty("associatedGatewayID")]
   protected String _associatedGatewayID;
   
   [JsonProperty("associatedGatewayName")]
   protected String _associatedGatewayName;
   
   [JsonProperty("associatedNSGatewayID")]
   protected String _associatedNSGatewayID;
   
   [JsonProperty("associatedNSGatewayName")]
   protected String _associatedNSGatewayName;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("family")]
   protected String _family;
   
   [JsonProperty("hostname")]
   protected String _hostname;
   
   [JsonProperty("lastConnectedTime")]
   protected long? _lastConnectedTime;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("originalEnterpriseName")]
   protected String _originalEnterpriseName;
   
   [JsonProperty("originalGatewayDatapathID")]
   protected String _originalGatewayDatapathID;
   
   [JsonProperty("originalGatewayName")]
   protected String _originalGatewayName;
   
   [JsonProperty("originalUplinkConnectionInfo")]
   protected String _originalUplinkConnectionInfo;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("registrationURL")]
   protected String _registrationURL;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("requestType")]
   protected ERequestType? _requestType;
   
   [JsonProperty("serialNumber")]
   protected String _serialNumber;
   
   [JsonProperty("statusString")]
   protected String _statusString;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public ZFBRequest() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
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
   public String NUIPAddress {
      get {
         return _IPAddress;
      }
      set {
         this._IPAddress = value;
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
   public String NUNSGVersion {
      get {
         return _NSGVersion;
      }
      set {
         this._NSGVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUSKU {
      get {
         return _SKU;
      }
      set {
         this._SKU = value;
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
   public EZFBApprovalStatus? NUZFBApprovalStatus {
      get {
         return _ZFBApprovalStatus;
      }
      set {
         this._ZFBApprovalStatus = value;
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
   public String NUZFBInfo {
      get {
         return _ZFBInfo;
      }
      set {
         this._ZFBInfo = value;
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
   public String NUAssociatedEnterpriseID {
      get {
         return _associatedEnterpriseID;
      }
      set {
         this._associatedEnterpriseID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEnterpriseName {
      get {
         return _associatedEnterpriseName;
      }
      set {
         this._associatedEnterpriseName = value;
      }
   }

   
   [JsonIgnore]
   public EAssociatedEntityType? NUAssociatedEntityType {
      get {
         return _associatedEntityType;
      }
      set {
         this._associatedEntityType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewayID {
      get {
         return _associatedGatewayID;
      }
      set {
         this._associatedGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedGatewayName {
      get {
         return _associatedGatewayName;
      }
      set {
         this._associatedGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGatewayID {
      get {
         return _associatedNSGatewayID;
      }
      set {
         this._associatedNSGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGatewayName {
      get {
         return _associatedNSGatewayName;
      }
      set {
         this._associatedNSGatewayName = value;
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
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
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
   public String NUFamily {
      get {
         return _family;
      }
      set {
         this._family = value;
      }
   }

   
   [JsonIgnore]
   public String NUHostname {
      get {
         return _hostname;
      }
      set {
         this._hostname = value;
      }
   }

   
   [JsonIgnore]
   public long? NULastConnectedTime {
      get {
         return _lastConnectedTime;
      }
      set {
         this._lastConnectedTime = value;
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
   public String NUOriginalEnterpriseName {
      get {
         return _originalEnterpriseName;
      }
      set {
         this._originalEnterpriseName = value;
      }
   }

   
   [JsonIgnore]
   public String NUOriginalGatewayDatapathID {
      get {
         return _originalGatewayDatapathID;
      }
      set {
         this._originalGatewayDatapathID = value;
      }
   }

   
   [JsonIgnore]
   public String NUOriginalGatewayName {
      get {
         return _originalGatewayName;
      }
      set {
         this._originalGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public String NUOriginalUplinkConnectionInfo {
      get {
         return _originalUplinkConnectionInfo;
      }
      set {
         this._originalUplinkConnectionInfo = value;
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
   public String NURegistrationURL {
      get {
         return _registrationURL;
      }
      set {
         this._registrationURL = value;
      }
   }

   
   [JsonIgnore]
   public ERequestType? NURequestType {
      get {
         return _requestType;
      }
      set {
         this._requestType = value;
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
   public String NUStatusString {
      get {
         return _statusString;
      }
      set {
         this._statusString = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
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
   

   public String toString() {
      return "ZFBRequest [" + "CPUType=" + _CPUType + ", IPAddress=" + _IPAddress + ", MACAddress=" + _MACAddress + ", NSGVersion=" + _NSGVersion + ", SKU=" + _SKU + ", UUID=" + _UUID + ", ZFBApprovalStatus=" + _ZFBApprovalStatus + ", ZFBBootstrapEnabled=" + _ZFBBootstrapEnabled + ", ZFBInfo=" + _ZFBInfo + ", ZFBRequestRetryTimer=" + _ZFBRequestRetryTimer + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", associatedEnterpriseName=" + _associatedEnterpriseName + ", associatedEntityType=" + _associatedEntityType + ", associatedGatewayID=" + _associatedGatewayID + ", associatedGatewayName=" + _associatedGatewayName + ", associatedNSGatewayID=" + _associatedNSGatewayID + ", associatedNSGatewayName=" + _associatedNSGatewayName + ", creationDate=" + _creationDate + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", family=" + _family + ", hostname=" + _hostname + ", lastConnectedTime=" + _lastConnectedTime + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", originalEnterpriseName=" + _originalEnterpriseName + ", originalGatewayDatapathID=" + _originalGatewayDatapathID + ", originalGatewayName=" + _originalGatewayName + ", originalUplinkConnectionInfo=" + _originalUplinkConnectionInfo + ", owner=" + _owner + ", registrationURL=" + _registrationURL + ", requestType=" + _requestType + ", serialNumber=" + _serialNumber + ", statusString=" + _statusString + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "zfbrequests";
   }

   public static String getRestName()
   {
	return "zfbrequest";
   }
}
}