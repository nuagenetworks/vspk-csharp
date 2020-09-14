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

public class IngressProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };

   
   [JsonProperty("assocEntityType")]
   protected String _assocEntityType;
   
   [JsonProperty("associatedIPFilterProfileID")]
   protected String _associatedIPFilterProfileID;
   
   [JsonProperty("associatedIPFilterProfileName")]
   protected String _associatedIPFilterProfileName;
   
   [JsonProperty("associatedIPv6FilterProfileID")]
   protected String _associatedIPv6FilterProfileID;
   
   [JsonProperty("associatedIPv6FilterProfileName")]
   protected String _associatedIPv6FilterProfileName;
   
   [JsonProperty("associatedMACFilterProfileID")]
   protected String _associatedMACFilterProfileID;
   
   [JsonProperty("associatedMACFilterProfileName")]
   protected String _associatedMACFilterProfileName;
   
   [JsonProperty("associatedSAPIngressQoSProfileID")]
   protected String _associatedSAPIngressQoSProfileID;
   
   [JsonProperty("associatedSAPIngressQoSProfileName")]
   protected String _associatedSAPIngressQoSProfileName;
   
   [JsonProperty("description")]
   protected String _description;
   
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
   

   
   [JsonIgnore]
   private DeploymentFailuresFetcher _deploymentFailures;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private VPortsFetcher _vPorts;
   
   public IngressProfile() {
      
      _deploymentFailures = new DeploymentFailuresFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _vPorts = new VPortsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssocEntityType {
      get {
         return _assocEntityType;
      }
      set {
         this._assocEntityType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIPFilterProfileID {
      get {
         return _associatedIPFilterProfileID;
      }
      set {
         this._associatedIPFilterProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIPFilterProfileName {
      get {
         return _associatedIPFilterProfileName;
      }
      set {
         this._associatedIPFilterProfileName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIPv6FilterProfileID {
      get {
         return _associatedIPv6FilterProfileID;
      }
      set {
         this._associatedIPv6FilterProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedIPv6FilterProfileName {
      get {
         return _associatedIPv6FilterProfileName;
      }
      set {
         this._associatedIPv6FilterProfileName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedMACFilterProfileID {
      get {
         return _associatedMACFilterProfileID;
      }
      set {
         this._associatedMACFilterProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedMACFilterProfileName {
      get {
         return _associatedMACFilterProfileName;
      }
      set {
         this._associatedMACFilterProfileName = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSAPIngressQoSProfileID {
      get {
         return _associatedSAPIngressQoSProfileID;
      }
      set {
         this._associatedSAPIngressQoSProfileID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedSAPIngressQoSProfileName {
      get {
         return _associatedSAPIngressQoSProfileName;
      }
      set {
         this._associatedSAPIngressQoSProfileName = value;
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

   

   
   public DeploymentFailuresFetcher getDeploymentFailures() {
      return _deploymentFailures;
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
   
   public VPortsFetcher getVPorts() {
      return _vPorts;
   }
   

   public String toString() {
      return "IngressProfile [" + "assocEntityType=" + _assocEntityType + ", associatedIPFilterProfileID=" + _associatedIPFilterProfileID + ", associatedIPFilterProfileName=" + _associatedIPFilterProfileName + ", associatedIPv6FilterProfileID=" + _associatedIPv6FilterProfileID + ", associatedIPv6FilterProfileName=" + _associatedIPv6FilterProfileName + ", associatedMACFilterProfileID=" + _associatedMACFilterProfileID + ", associatedMACFilterProfileName=" + _associatedMACFilterProfileName + ", associatedSAPIngressQoSProfileID=" + _associatedSAPIngressQoSProfileID + ", associatedSAPIngressQoSProfileName=" + _associatedSAPIngressQoSProfileName + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ingressprofiles";
   }

   public static String getRestName()
   {
	return "ingressprofile";
   }
}
}