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

public class ZFBRequest: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EZFBApprovalStatus {APPROVED,ASSIGNED,DENIED,UNASSIGNED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
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
   
   [JsonProperty("associatedNSGatewayID")]
   protected String _associatedNSGatewayID;
   
   [JsonProperty("associatedNSGatewayName")]
   protected String _associatedNSGatewayName;
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
   
   public ZFBRequest() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
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
   

   public String toString() {
      return "ZFBRequest [" + "CPUType=" + _CPUType + ", IPAddress=" + _IPAddress + ", MACAddress=" + _MACAddress + ", NSGVersion=" + _NSGVersion + ", SKU=" + _SKU + ", UUID=" + _UUID + ", ZFBApprovalStatus=" + _ZFBApprovalStatus + ", ZFBBootstrapEnabled=" + _ZFBBootstrapEnabled + ", ZFBInfo=" + _ZFBInfo + ", ZFBRequestRetryTimer=" + _ZFBRequestRetryTimer + ", associatedEnterpriseID=" + _associatedEnterpriseID + ", associatedEnterpriseName=" + _associatedEnterpriseName + ", associatedNSGatewayID=" + _associatedNSGatewayID + ", associatedNSGatewayName=" + _associatedNSGatewayName + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", family=" + _family + ", hostname=" + _hostname + ", lastConnectedTime=" + _lastConnectedTime + ", lastUpdatedBy=" + _lastUpdatedBy + ", serialNumber=" + _serialNumber + ", statusString=" + _statusString + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
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