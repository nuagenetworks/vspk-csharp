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

public class OSPFInterface: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAdminState {DOWN,UP };
   public enum EAuthenticationType {MESSAGE_DIGEST,NONE,PASSWORD };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EInterfaceType {BROADCAST,POINT_TO_POINT };

   
   [JsonProperty("BFDEnabled")]
   protected bool _BFDEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("adminState")]
   protected EAdminState? _adminState;
   
   [JsonProperty("associatedSubnetID")]
   protected String _associatedSubnetID;
   
   [JsonProperty("authenticationKey")]
   protected String _authenticationKey;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("authenticationType")]
   protected EAuthenticationType? _authenticationType;
   
   [JsonProperty("deadInterval")]
   protected long? _deadInterval;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("helloInterval")]
   protected long? _helloInterval;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("interfaceType")]
   protected EInterfaceType? _interfaceType;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("messageDigestKeys")]
   protected System.Collections.Generic.List<String> _messageDigestKeys;
   
   [JsonProperty("metric")]
   protected long? _metric;
   
   [JsonProperty("mtu")]
   protected long? _mtu;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("passiveEnabled")]
   protected bool _passiveEnabled;
   
   [JsonProperty("priority")]
   protected long? _priority;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   public OSPFInterface() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
   }

   
   [JsonIgnore]
   public bool NUBFDEnabled {
      get {
         return _BFDEnabled;
      }
      set {
         this._BFDEnabled = value;
      }
   }

   
   [JsonIgnore]
   public EAdminState? NUAdminState {
      get {
         return _adminState;
      }
      set {
         this._adminState = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSubnetID {
      get {
         return _associatedSubnetID;
      }
      set {
         this._associatedSubnetID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAuthenticationKey {
      get {
         return _authenticationKey;
      }
      set {
         this._authenticationKey = value;
      }
   }

   
   [JsonIgnore]
   public EAuthenticationType? NUAuthenticationType {
      get {
         return _authenticationType;
      }
      set {
         this._authenticationType = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDeadInterval {
      get {
         return _deadInterval;
      }
      set {
         this._deadInterval = value;
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
   public long? NUHelloInterval {
      get {
         return _helloInterval;
      }
      set {
         this._helloInterval = value;
      }
   }

   
   [JsonIgnore]
   public EInterfaceType? NUInterfaceType {
      get {
         return _interfaceType;
      }
      set {
         this._interfaceType = value;
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
   public System.Collections.Generic.List<String> NUMessageDigestKeys {
      get {
         return _messageDigestKeys;
      }
      set {
         this._messageDigestKeys = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMetric {
      get {
         return _metric;
      }
      set {
         this._metric = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMtu {
      get {
         return _mtu;
      }
      set {
         this._mtu = value;
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
   public bool NUPassiveEnabled {
      get {
         return _passiveEnabled;
      }
      set {
         this._passiveEnabled = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPriority {
      get {
         return _priority;
      }
      set {
         this._priority = value;
      }
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
   

   public String toString() {
      return "OSPFInterface [" + "BFDEnabled=" + _BFDEnabled + ", adminState=" + _adminState + ", associatedSubnetID=" + _associatedSubnetID + ", authenticationKey=" + _authenticationKey + ", authenticationType=" + _authenticationType + ", deadInterval=" + _deadInterval + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", helloInterval=" + _helloInterval + ", interfaceType=" + _interfaceType + ", lastUpdatedBy=" + _lastUpdatedBy + ", messageDigestKeys=" + _messageDigestKeys + ", metric=" + _metric + ", mtu=" + _mtu + ", name=" + _name + ", passiveEnabled=" + _passiveEnabled + ", priority=" + _priority + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ospfinterfaces";
   }

   public static String getRestName()
   {
	return "ospfinterface";
   }
}
}