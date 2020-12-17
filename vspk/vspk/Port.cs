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

public class Port: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EOperationalState {DOWN,INIT,UP };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EPortType {ACCESS,MANAGEMENT,NETWORK };
   public enum EStatus {INITIALIZED,MISMATCH,ORPHAN,READY };

   
   [JsonProperty("VLANRange")]
   protected String _VLANRange;
   
   [JsonProperty("associatedEgressQOSPolicyID")]
   protected String _associatedEgressQOSPolicyID;
   
   [JsonProperty("associatedEthernetSegmentGroupID")]
   protected String _associatedEthernetSegmentGroupID;
   
   [JsonProperty("associatedEthernetSegmentID")]
   protected String _associatedEthernetSegmentID;
   
   [JsonProperty("associatedEthernetSegmentVLANRange")]
   protected String _associatedEthernetSegmentVLANRange;
   
   [JsonProperty("associatedEthernetSegmentVirtual")]
   protected bool _associatedEthernetSegmentVirtual;
   
   [JsonProperty("associatedRedundantPortID")]
   protected String _associatedRedundantPortID;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("isResilient")]
   protected bool _isResilient;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("nativeVLAN")]
   protected String _nativeVLAN;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("operationalState")]
   protected EOperationalState? _operationalState;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("physicalName")]
   protected String _physicalName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("portType")]
   protected EPortType? _portType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("templateID")]
   protected String _templateID;
   
   [JsonProperty("useUserMnemonic")]
   protected bool _useUserMnemonic;
   
   [JsonProperty("userMnemonic")]
   protected String _userMnemonic;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private VLANsFetcher _vLANs;
   
   public Port() {
      
      _alarms = new AlarmsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _vLANs = new VLANsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUVLANRange {
      get {
         return _VLANRange;
      }
      set {
         this._VLANRange = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEgressQOSPolicyID {
      get {
         return _associatedEgressQOSPolicyID;
      }
      set {
         this._associatedEgressQOSPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEthernetSegmentGroupID {
      get {
         return _associatedEthernetSegmentGroupID;
      }
      set {
         this._associatedEthernetSegmentGroupID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEthernetSegmentID {
      get {
         return _associatedEthernetSegmentID;
      }
      set {
         this._associatedEthernetSegmentID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedEthernetSegmentVLANRange {
      get {
         return _associatedEthernetSegmentVLANRange;
      }
      set {
         this._associatedEthernetSegmentVLANRange = value;
      }
   }

   
   [JsonIgnore]
   public bool NUAssociatedEthernetSegmentVirtual {
      get {
         return _associatedEthernetSegmentVirtual;
      }
      set {
         this._associatedEthernetSegmentVirtual = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedRedundantPortID {
      get {
         return _associatedRedundantPortID;
      }
      set {
         this._associatedRedundantPortID = value;
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
   public bool NUIsResilient {
      get {
         return _isResilient;
      }
      set {
         this._isResilient = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public String NUNativeVLAN {
      get {
         return _nativeVLAN;
      }
      set {
         this._nativeVLAN = value;
      }
   }

   
   [JsonIgnore]
   public EOperationalState? NUOperationalState {
      get {
         return _operationalState;
      }
      set {
         this._operationalState = value;
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
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
      }
   }

   
   [JsonIgnore]
   public String NUPhysicalName {
      get {
         return _physicalName;
      }
      set {
         this._physicalName = value;
      }
   }

   
   [JsonIgnore]
   public EPortType? NUPortType {
      get {
         return _portType;
      }
      set {
         this._portType = value;
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
   public String NUTemplateID {
      get {
         return _templateID;
      }
      set {
         this._templateID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUUseUserMnemonic {
      get {
         return _useUserMnemonic;
      }
      set {
         this._useUserMnemonic = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserMnemonic {
      get {
         return _userMnemonic;
      }
      set {
         this._userMnemonic = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public EnterprisePermissionsFetcher getEnterprisePermissions() {
      return _enterprisePermissions;
   }
   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
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
   
   public VLANsFetcher getVLANs() {
      return _vLANs;
   }
   

   public String toString() {
      return "Port [" + "VLANRange=" + _VLANRange + ", associatedEgressQOSPolicyID=" + _associatedEgressQOSPolicyID + ", associatedEthernetSegmentGroupID=" + _associatedEthernetSegmentGroupID + ", associatedEthernetSegmentID=" + _associatedEthernetSegmentID + ", associatedEthernetSegmentVLANRange=" + _associatedEthernetSegmentVLANRange + ", associatedEthernetSegmentVirtual=" + _associatedEthernetSegmentVirtual + ", associatedRedundantPortID=" + _associatedRedundantPortID + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", isResilient=" + _isResilient + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", nativeVLAN=" + _nativeVLAN + ", operationalState=" + _operationalState + ", owner=" + _owner + ", permittedAction=" + _permittedAction + ", physicalName=" + _physicalName + ", portType=" + _portType + ", status=" + _status + ", templateID=" + _templateID + ", useUserMnemonic=" + _useUserMnemonic + ", userMnemonic=" + _userMnemonic + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ports";
   }

   public static String getRestName()
   {
	return "port";
   }
}
}