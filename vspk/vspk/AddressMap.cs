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

public class AddressMap: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EType {MANY_TO_ONE_PAT,ONE_TO_ONE_NAT };

   
   [JsonProperty("associatedPATNATPoolID")]
   protected String _associatedPATNATPoolID;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("privateIP")]
   protected String _privateIP;
   
   [JsonProperty("privatePort")]
   protected long? _privatePort;
   
   [JsonProperty("publicIP")]
   protected String _publicIP;
   
   [JsonProperty("publicPort")]
   protected long? _publicPort;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("type")]
   protected EType? _type;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private StatisticsFetcher _statistics;
   
   [JsonIgnore]
   private StatisticsPoliciesFetcher _statisticsPolicies;
   
   public AddressMap() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _statistics = new StatisticsFetcher(this);
      
      _statisticsPolicies = new StatisticsPoliciesFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedPATNATPoolID {
      get {
         return _associatedPATNATPoolID;
      }
      set {
         this._associatedPATNATPoolID = value;
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
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
      }
   }

   
   [JsonIgnore]
   public String NUPrivateIP {
      get {
         return _privateIP;
      }
      set {
         this._privateIP = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPrivatePort {
      get {
         return _privatePort;
      }
      set {
         this._privatePort = value;
      }
   }

   
   [JsonIgnore]
   public String NUPublicIP {
      get {
         return _publicIP;
      }
      set {
         this._publicIP = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPublicPort {
      get {
         return _publicPort;
      }
      set {
         this._publicPort = value;
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

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public StatisticsFetcher getStatistics() {
      return _statistics;
   }
   
   public StatisticsPoliciesFetcher getStatisticsPolicies() {
      return _statisticsPolicies;
   }
   

   public String toString() {
      return "AddressMap [" + "associatedPATNATPoolID=" + _associatedPATNATPoolID + ", creationDate=" + _creationDate + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", owner=" + _owner + ", privateIP=" + _privateIP + ", privatePort=" + _privatePort + ", publicIP=" + _publicIP + ", publicPort=" + _publicPort + ", type=" + _type + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "addressmaps";
   }

   public static String getRestName()
   {
	return "addressmap";
   }
}
}