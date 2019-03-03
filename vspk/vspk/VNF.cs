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

public class VNF: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAllowedActions {DEPLOY,REDEPLOY,RESTART,START,STOP,UNDEPLOY };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ELastUserAction {DEPLOY,NONE,REDEPLOY,RESTART,START,STOP,UNDEPLOY };
   public enum EStatus {BLOCKED,CRASHED,DYING,IDLE,INIT,LAST,PAUSED,PMSUSPENDED,RUNNING,SHUTDOWN,SHUTOFF };
   public enum ETaskState {DEPLOYING,NONE,STARTING,STOPPING,UNDEPLOYING };
   public enum EType {FIREWALL,WAN_OPT };

   
   [JsonProperty("CPUCount")]
   protected long? _CPUCount;
   
   [JsonProperty("NSGName")]
   protected String _NSGName;
   
   [JsonProperty("NSGSystemID")]
   protected String _NSGSystemID;
   
   [JsonProperty("NSGatewayID")]
   protected String _NSGatewayID;
   
   [JsonProperty("VNFDescriptorID")]
   protected String _VNFDescriptorID;
   
   [JsonProperty("VNFDescriptorName")]
   protected String _VNFDescriptorName;
   
   [JsonProperty("allowedActions")]
   protected System.Collections.Generic.List<EAllowedActions> _allowedActions;
   
   [JsonProperty("associatedVNFMetadataID")]
   protected String _associatedVNFMetadataID;
   
   [JsonProperty("associatedVNFThresholdPolicyID")]
   protected String _associatedVNFThresholdPolicyID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("isAttachedToDescriptor")]
   protected bool _isAttachedToDescriptor;
   
   [JsonProperty("lastKnownError")]
   protected String _lastKnownError;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("lastUserAction")]
   protected ELastUserAction? _lastUserAction;
   
   [JsonProperty("memoryMB")]
   protected long? _memoryMB;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("storageGB")]
   protected long? _storageGB;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("taskState")]
   protected ETaskState? _taskState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   
   [JsonProperty("vendor")]
   protected String _vendor;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private JobsFetcher _jobs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private VNFInterfacesFetcher _vNFInterfaces;
   
   [JsonIgnore]
   private VNFMetadatasFetcher _vNFMetadatas;
   
   [JsonIgnore]
   private VNFThresholdPoliciesFetcher _vNFThresholdPolicies;
   
   public VNF() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _jobs = new JobsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _vNFInterfaces = new VNFInterfacesFetcher(this);
      
      _vNFMetadatas = new VNFMetadatasFetcher(this);
      
      _vNFThresholdPolicies = new VNFThresholdPoliciesFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUCPUCount {
      get {
         return _CPUCount;
      }
      set {
         this._CPUCount = value;
      }
   }

   
   [JsonIgnore]
   public String NUNSGName {
      get {
         return _NSGName;
      }
      set {
         this._NSGName = value;
      }
   }

   
   [JsonIgnore]
   public String NUNSGSystemID {
      get {
         return _NSGSystemID;
      }
      set {
         this._NSGSystemID = value;
      }
   }

   
   [JsonIgnore]
   public String NUNSGatewayID {
      get {
         return _NSGatewayID;
      }
      set {
         this._NSGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVNFDescriptorID {
      get {
         return _VNFDescriptorID;
      }
      set {
         this._VNFDescriptorID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVNFDescriptorName {
      get {
         return _VNFDescriptorName;
      }
      set {
         this._VNFDescriptorName = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<EAllowedActions> NUAllowedActions {
      get {
         return _allowedActions;
      }
      set {
         this._allowedActions = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVNFMetadataID {
      get {
         return _associatedVNFMetadataID;
      }
      set {
         this._associatedVNFMetadataID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedVNFThresholdPolicyID {
      get {
         return _associatedVNFThresholdPolicyID;
      }
      set {
         this._associatedVNFThresholdPolicyID = value;
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
   public String NUEnterpriseID {
      get {
         return _enterpriseID;
      }
      set {
         this._enterpriseID = value;
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
   public bool NUIsAttachedToDescriptor {
      get {
         return _isAttachedToDescriptor;
      }
      set {
         this._isAttachedToDescriptor = value;
      }
   }

   
   [JsonIgnore]
   public String NULastKnownError {
      get {
         return _lastKnownError;
      }
      set {
         this._lastKnownError = value;
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
   public ELastUserAction? NULastUserAction {
      get {
         return _lastUserAction;
      }
      set {
         this._lastUserAction = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMemoryMB {
      get {
         return _memoryMB;
      }
      set {
         this._memoryMB = value;
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
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStorageGB {
      get {
         return _storageGB;
      }
      set {
         this._storageGB = value;
      }
   }

   
   [JsonIgnore]
   public ETaskState? NUTaskState {
      get {
         return _taskState;
      }
      set {
         this._taskState = value;
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
   public String NUVendor {
      get {
         return _vendor;
      }
      set {
         this._vendor = value;
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
   
   public VNFInterfacesFetcher getVNFInterfaces() {
      return _vNFInterfaces;
   }
   
   public VNFMetadatasFetcher getVNFMetadatas() {
      return _vNFMetadatas;
   }
   
   public VNFThresholdPoliciesFetcher getVNFThresholdPolicies() {
      return _vNFThresholdPolicies;
   }
   

   public String toString() {
      return "VNF [" + "CPUCount=" + _CPUCount + ", NSGName=" + _NSGName + ", NSGSystemID=" + _NSGSystemID + ", NSGatewayID=" + _NSGatewayID + ", VNFDescriptorID=" + _VNFDescriptorID + ", VNFDescriptorName=" + _VNFDescriptorName + ", allowedActions=" + _allowedActions + ", associatedVNFMetadataID=" + _associatedVNFMetadataID + ", associatedVNFThresholdPolicyID=" + _associatedVNFThresholdPolicyID + ", description=" + _description + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", isAttachedToDescriptor=" + _isAttachedToDescriptor + ", lastKnownError=" + _lastKnownError + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUserAction=" + _lastUserAction + ", memoryMB=" + _memoryMB + ", name=" + _name + ", status=" + _status + ", storageGB=" + _storageGB + ", taskState=" + _taskState + ", type=" + _type + ", vendor=" + _vendor + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vnfs";
   }

   public static String getRestName()
   {
	return "vnf";
   }
}
}