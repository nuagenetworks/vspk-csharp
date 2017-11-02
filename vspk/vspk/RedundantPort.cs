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

public class RedundantPort: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };
   public enum EPortType {ACCESS };
   public enum ESpeed {AUTONEGOTIATE,BASE10,BASET1000,BASETX100,BASEX10G };
   public enum EStatus {INITIALIZED,MISMATCH,ORPHAN,READY };

   
   [JsonProperty("MTU")]
   protected long? _MTU;
   
   [JsonProperty("VLANRange")]
   protected String _VLANRange;
   
   [JsonProperty("associatedEgressQOSPolicyID")]
   protected String _associatedEgressQOSPolicyID;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("infrastructureProfileID")]
   protected String _infrastructureProfileID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   
   [JsonProperty("physicalName")]
   protected String _physicalName;
   
   [JsonProperty("portPeer1ID")]
   protected String _portPeer1ID;
   
   [JsonProperty("portPeer2ID")]
   protected String _portPeer2ID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("portType")]
   protected EPortType? _portType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("speed")]
   protected ESpeed? _speed;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("useUntaggedHeartbeatVlan")]
   protected bool _useUntaggedHeartbeatVlan;
   
   [JsonProperty("useUserMnemonic")]
   protected bool _useUserMnemonic;
   
   [JsonProperty("userMnemonic")]
   protected String _userMnemonic;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NSPortsFetcher _nSPorts;
   
   [JsonIgnore]
   private VLANsFetcher _vLANs;
   
   public RedundantPort() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _nSPorts = new NSPortsFetcher(this);
      
      _vLANs = new VLANsFetcher(this);
      
   }

   
   [JsonIgnore]
   public long? NUMTU {
      get {
         return _MTU;
      }
      set {
         this._MTU = value;
      }
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
   public String NUDescription {
      get {
         return _description;
      }
      set {
         this._description = value;
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
   public String NUInfrastructureProfileID {
      get {
         return _infrastructureProfileID;
      }
      set {
         this._infrastructureProfileID = value;
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
   public String NUPhysicalName {
      get {
         return _physicalName;
      }
      set {
         this._physicalName = value;
      }
   }

   
   [JsonIgnore]
   public String NUPortPeer1ID {
      get {
         return _portPeer1ID;
      }
      set {
         this._portPeer1ID = value;
      }
   }

   
   [JsonIgnore]
   public String NUPortPeer2ID {
      get {
         return _portPeer2ID;
      }
      set {
         this._portPeer2ID = value;
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
   public ESpeed? NUSpeed {
      get {
         return _speed;
      }
      set {
         this._speed = value;
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
   public bool NUUseUntaggedHeartbeatVlan {
      get {
         return _useUntaggedHeartbeatVlan;
      }
      set {
         this._useUntaggedHeartbeatVlan = value;
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

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public NSPortsFetcher getNSPorts() {
      return _nSPorts;
   }
   
   public VLANsFetcher getVLANs() {
      return _vLANs;
   }
   

   public String toString() {
      return "RedundantPort [" + "MTU=" + _MTU + ", VLANRange=" + _VLANRange + ", associatedEgressQOSPolicyID=" + _associatedEgressQOSPolicyID + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", infrastructureProfileID=" + _infrastructureProfileID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", permittedAction=" + _permittedAction + ", physicalName=" + _physicalName + ", portPeer1ID=" + _portPeer1ID + ", portPeer2ID=" + _portPeer2ID + ", portType=" + _portType + ", speed=" + _speed + ", status=" + _status + ", useUntaggedHeartbeatVlan=" + _useUntaggedHeartbeatVlan + ", useUserMnemonic=" + _useUserMnemonic + ", userMnemonic=" + _userMnemonic + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "nsredundantports";
   }

   public static String getRestName()
   {
	return "nsredundantport";
   }
}
}