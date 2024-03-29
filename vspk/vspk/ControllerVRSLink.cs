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

public class ControllerVRSLink: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EJSONRPCConnectionState {ADMIN_DOWN,DOWN,NONE,UP };
   public enum EVRSPersonality {HARDWARE_VTEP,NONE,NSG,NSGBR,NSGDUC,NUAGE_210_WBX_32_Q,NUAGE_210_WBX_48_S,VRS,VRSB,VRSG };
   public enum EVSCConfigState {PRIMARY,SECONDARY };
   public enum EVSCCurrentState {PRIMARY,SECONDARY };
   public enum EClusterNodeRole {NONE,PRIMARY,SECONDARY };
   public enum EControllerType {HSC,VSC };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ERole {MASTER,NONE,SLAVE };
   public enum EStatus {ADMIN_DOWN,DOWN,UP };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("JSONRPCConnectionState")]
   protected EJSONRPCConnectionState? _JSONRPCConnectionState;
   
   [JsonProperty("VRSID")]
   protected String _VRSID;
   
   [JsonProperty("VRSISSUFailureReason")]
   protected String _VRSISSUFailureReason;
   
   [JsonProperty("VRSISSUState")]
   protected String _VRSISSUState;
   
   [JsonProperty("VRSLastISSUState")]
   protected String _VRSLastISSUState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("VRSPersonality")]
   protected EVRSPersonality? _VRSPersonality;
   
   [JsonProperty("VRSSystemId")]
   protected String _VRSSystemId;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("VSCConfigState")]
   protected EVSCConfigState? _VSCConfigState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("VSCCurrentState")]
   protected EVSCCurrentState? _VSCCurrentState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("clusterNodeRole")]
   protected EClusterNodeRole? _clusterNodeRole;
   
   [JsonProperty("connections")]
   protected System.Collections.Generic.List<SysmonUplinkConnection> _connections;
   
   [JsonProperty("controllerID")]
   protected String _controllerID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("controllerType")]
   protected EControllerType? _controllerType;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("dynamic")]
   protected bool _dynamic;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("peer")]
   protected String _peer;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("role")]
   protected ERole? _role;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private HSCsFetcher _hSCs;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private VRSsFetcher _vRSs;
   
   [JsonIgnore]
   private VSCsFetcher _vSCs;
   
   public ControllerVRSLink() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _hSCs = new HSCsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _vRSs = new VRSsFetcher(this);
      
      _vSCs = new VSCsFetcher(this);
      
   }

   
   [JsonIgnore]
   public EJSONRPCConnectionState? NUJSONRPCConnectionState {
      get {
         return _JSONRPCConnectionState;
      }
      set {
         this._JSONRPCConnectionState = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSID {
      get {
         return _VRSID;
      }
      set {
         this._VRSID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSISSUFailureReason {
      get {
         return _VRSISSUFailureReason;
      }
      set {
         this._VRSISSUFailureReason = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSISSUState {
      get {
         return _VRSISSUState;
      }
      set {
         this._VRSISSUState = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSLastISSUState {
      get {
         return _VRSLastISSUState;
      }
      set {
         this._VRSLastISSUState = value;
      }
   }

   
   [JsonIgnore]
   public EVRSPersonality? NUVRSPersonality {
      get {
         return _VRSPersonality;
      }
      set {
         this._VRSPersonality = value;
      }
   }

   
   [JsonIgnore]
   public String NUVRSSystemId {
      get {
         return _VRSSystemId;
      }
      set {
         this._VRSSystemId = value;
      }
   }

   
   [JsonIgnore]
   public EVSCConfigState? NUVSCConfigState {
      get {
         return _VSCConfigState;
      }
      set {
         this._VSCConfigState = value;
      }
   }

   
   [JsonIgnore]
   public EVSCCurrentState? NUVSCCurrentState {
      get {
         return _VSCCurrentState;
      }
      set {
         this._VSCCurrentState = value;
      }
   }

   
   [JsonIgnore]
   public EClusterNodeRole? NUClusterNodeRole {
      get {
         return _clusterNodeRole;
      }
      set {
         this._clusterNodeRole = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<SysmonUplinkConnection> NUConnections {
      get {
         return _connections;
      }
      set {
         this._connections = value;
      }
   }

   
   [JsonIgnore]
   public String NUControllerID {
      get {
         return _controllerID;
      }
      set {
         this._controllerID = value;
      }
   }

   
   [JsonIgnore]
   public EControllerType? NUControllerType {
      get {
         return _controllerType;
      }
      set {
         this._controllerType = value;
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
   public bool NUDynamic {
      get {
         return _dynamic;
      }
      set {
         this._dynamic = value;
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
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeer {
      get {
         return _peer;
      }
      set {
         this._peer = value;
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
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public HSCsFetcher getHSCs() {
      return _hSCs;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public VRSsFetcher getVRSs() {
      return _vRSs;
   }
   
   public VSCsFetcher getVSCs() {
      return _vSCs;
   }
   

   public String toString() {
      return "ControllerVRSLink [" + "JSONRPCConnectionState=" + _JSONRPCConnectionState + ", VRSID=" + _VRSID + ", VRSISSUFailureReason=" + _VRSISSUFailureReason + ", VRSISSUState=" + _VRSISSUState + ", VRSLastISSUState=" + _VRSLastISSUState + ", VRSPersonality=" + _VRSPersonality + ", VRSSystemId=" + _VRSSystemId + ", VSCConfigState=" + _VSCConfigState + ", VSCCurrentState=" + _VSCCurrentState + ", clusterNodeRole=" + _clusterNodeRole + ", connections=" + _connections + ", controllerID=" + _controllerID + ", controllerType=" + _controllerType + ", creationDate=" + _creationDate + ", dynamic=" + _dynamic + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", peer=" + _peer + ", role=" + _role + ", status=" + _status + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "controllervrslinks";
   }

   public static String getRestName()
   {
	return "controllervrslink";
   }
}
}