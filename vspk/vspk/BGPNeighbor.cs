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

public class BGPNeighbor: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIPType {IPV4,IPV6 };
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("BFDEnabled")]
   protected bool _BFDEnabled;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("IPType")]
   protected EIPType? _IPType;
   
   [JsonProperty("IPv6Address")]
   protected String _IPv6Address;
   
   [JsonProperty("associatedExportRoutingPolicyID")]
   protected String _associatedExportRoutingPolicyID;
   
   [JsonProperty("associatedImportRoutingPolicyID")]
   protected String _associatedImportRoutingPolicyID;
   
   [JsonProperty("dampeningEnabled")]
   protected bool _dampeningEnabled;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("domainServiceLabel")]
   protected String _domainServiceLabel;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("peerAS")]
   protected long? _peerAS;
   
   [JsonProperty("peerConfiguration")]
   protected String _peerConfiguration;
   
   [JsonProperty("peerIP")]
   protected String _peerIP;
   
   [JsonProperty("session")]
   protected String _session;
   

   
   [JsonIgnore]
   private DeploymentFailuresFetcher _deploymentFailures;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public BGPNeighbor() {
      
      _deploymentFailures = new DeploymentFailuresFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
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
   public EIPType? NUIPType {
      get {
         return _IPType;
      }
      set {
         this._IPType = value;
      }
   }

   
   [JsonIgnore]
   public String NUIPv6Address {
      get {
         return _IPv6Address;
      }
      set {
         this._IPv6Address = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedExportRoutingPolicyID {
      get {
         return _associatedExportRoutingPolicyID;
      }
      set {
         this._associatedExportRoutingPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedImportRoutingPolicyID {
      get {
         return _associatedImportRoutingPolicyID;
      }
      set {
         this._associatedImportRoutingPolicyID = value;
      }
   }

   
   [JsonIgnore]
   public bool NUDampeningEnabled {
      get {
         return _dampeningEnabled;
      }
      set {
         this._dampeningEnabled = value;
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
   public String NUDomainServiceLabel {
      get {
         return _domainServiceLabel;
      }
      set {
         this._domainServiceLabel = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPeerAS {
      get {
         return _peerAS;
      }
      set {
         this._peerAS = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerConfiguration {
      get {
         return _peerConfiguration;
      }
      set {
         this._peerConfiguration = value;
      }
   }

   
   [JsonIgnore]
   public String NUPeerIP {
      get {
         return _peerIP;
      }
      set {
         this._peerIP = value;
      }
   }

   
   [JsonIgnore]
   public String NUSession {
      get {
         return _session;
      }
      set {
         this._session = value;
      }
   }

   

   
   public DeploymentFailuresFetcher getDeploymentFailures() {
      return _deploymentFailures;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "BGPNeighbor [" + "BFDEnabled=" + _BFDEnabled + ", IPType=" + _IPType + ", IPv6Address=" + _IPv6Address + ", associatedExportRoutingPolicyID=" + _associatedExportRoutingPolicyID + ", associatedImportRoutingPolicyID=" + _associatedImportRoutingPolicyID + ", dampeningEnabled=" + _dampeningEnabled + ", description=" + _description + ", domainServiceLabel=" + _domainServiceLabel + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", name=" + _name + ", peerAS=" + _peerAS + ", peerConfiguration=" + _peerConfiguration + ", peerIP=" + _peerIP + ", session=" + _session + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "bgpneighbors";
   }

   public static String getRestName()
   {
	return "bgpneighbor";
   }
}
}