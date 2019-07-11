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
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ERole {MASTER,NONE,SLAVE };
   public enum EStatus {ADMIN_DOWN,DOWN,UP };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("JSONRPCConnectionState")]
   protected EJSONRPCConnectionState? _JSONRPCConnectionState;
   
   [JsonProperty("VRSID")]
   protected String _VRSID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("VRSPersonality")]
   protected EVRSPersonality? _VRSPersonality;
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
   protected System.Collections.Generic.List<String> _connections;
   
   [JsonProperty("controllerID")]
   protected String _controllerID;
   
   [JsonProperty("controllerType")]
   protected String _controllerType;
   
   [JsonProperty("dynamic")]
   protected bool _dynamic;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
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
   private VRSsFetcher _vRSs;
   
   [JsonIgnore]
   private VSCsFetcher _vSCs;
   
   public ControllerVRSLink() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _hSCs = new HSCsFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
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
   public EVRSPersonality? NUVRSPersonality {
      get {
         return _VRSPersonality;
      }
      set {
         this._VRSPersonality = value;
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
   public System.Collections.Generic.List<String> NUConnections {
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
   public String NUControllerType {
      get {
         return _controllerType;
      }
      set {
         this._controllerType = value;
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
   
   public VRSsFetcher getVRSs() {
      return _vRSs;
   }
   
   public VSCsFetcher getVSCs() {
      return _vSCs;
   }
   

   public String toString() {
      return "ControllerVRSLink [" + "JSONRPCConnectionState=" + _JSONRPCConnectionState + ", VRSID=" + _VRSID + ", VRSPersonality=" + _VRSPersonality + ", VSCConfigState=" + _VSCConfigState + ", VSCCurrentState=" + _VSCCurrentState + ", clusterNodeRole=" + _clusterNodeRole + ", connections=" + _connections + ", controllerID=" + _controllerID + ", controllerType=" + _controllerType + ", dynamic=" + _dynamic + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", peer=" + _peer + ", role=" + _role + ", status=" + _status + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
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