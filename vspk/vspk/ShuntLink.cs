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

public class ShuntLink: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EPermittedAction {ALL,DEPLOY,EXTEND,INSTANTIATE,READ,USE };

   
   [JsonProperty("VLANPeer1ID")]
   protected String _VLANPeer1ID;
   
   [JsonProperty("VLANPeer2ID")]
   protected String _VLANPeer2ID;
   
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
   
   [JsonProperty("gatewayPeer1ID")]
   protected String _gatewayPeer1ID;
   
   [JsonProperty("gatewayPeer2ID")]
   protected String _gatewayPeer2ID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("owner")]
   protected String _owner;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("permittedAction")]
   protected EPermittedAction? _permittedAction;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private VirtualUplinksFetcher _virtualUplinks;
   
   public ShuntLink() {
      
      _alarms = new AlarmsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _virtualUplinks = new VirtualUplinksFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUVLANPeer1ID {
      get {
         return _VLANPeer1ID;
      }
      set {
         this._VLANPeer1ID = value;
      }
   }

   
   [JsonIgnore]
   public String NUVLANPeer2ID {
      get {
         return _VLANPeer2ID;
      }
      set {
         this._VLANPeer2ID = value;
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
   public String NUGatewayPeer1ID {
      get {
         return _gatewayPeer1ID;
      }
      set {
         this._gatewayPeer1ID = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayPeer2ID {
      get {
         return _gatewayPeer2ID;
      }
      set {
         this._gatewayPeer2ID = value;
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
   public EPermittedAction? NUPermittedAction {
      get {
         return _permittedAction;
      }
      set {
         this._permittedAction = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
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
   
   public VirtualUplinksFetcher getVirtualUplinks() {
      return _virtualUplinks;
   }
   

   public String toString() {
      return "ShuntLink [" + "VLANPeer1ID=" + _VLANPeer1ID + ", VLANPeer2ID=" + _VLANPeer2ID + ", creationDate=" + _creationDate + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayPeer1ID=" + _gatewayPeer1ID + ", gatewayPeer2ID=" + _gatewayPeer2ID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", name=" + _name + ", owner=" + _owner + ", permittedAction=" + _permittedAction + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "shuntlinks";
   }

   public static String getRestName()
   {
	return "shuntlink";
   }
}
}