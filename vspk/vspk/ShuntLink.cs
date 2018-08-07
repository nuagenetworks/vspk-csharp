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

public class ShuntLink: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("VLANPeer1ID")]
   protected String _VLANPeer1ID;
   
   [JsonProperty("VLANPeer2ID")]
   protected String _VLANPeer2ID;
   
   [JsonProperty("description")]
   protected String _description;
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
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("peer1IPAddress")]
   protected String _peer1IPAddress;
   
   [JsonProperty("peer1Subnet")]
   protected String _peer1Subnet;
   
   [JsonProperty("peer2IPAddress")]
   protected String _peer2IPAddress;
   
   [JsonProperty("peer2Subnet")]
   protected String _peer2Subnet;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public ShuntLink() {
      
      _alarms = new AlarmsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeer1IPAddress {
      get {
         return _peer1IPAddress;
      }
      set {
         this._peer1IPAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeer1Subnet {
      get {
         return _peer1Subnet;
      }
      set {
         this._peer1Subnet = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeer2IPAddress {
      get {
         return _peer2IPAddress;
      }
      set {
         this._peer2IPAddress = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeer2Subnet {
      get {
         return _peer2Subnet;
      }
      set {
         this._peer2Subnet = value;
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
   

   public String toString() {
      return "ShuntLink [" + "VLANPeer1ID=" + _VLANPeer1ID + ", VLANPeer2ID=" + _VLANPeer2ID + ", description=" + _description + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", gatewayPeer1ID=" + _gatewayPeer1ID + ", gatewayPeer2ID=" + _gatewayPeer2ID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", peer1IPAddress=" + _peer1IPAddress + ", peer1Subnet=" + _peer1Subnet + ", peer2IPAddress=" + _peer2IPAddress + ", peer2Subnet=" + _peer2Subnet + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
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