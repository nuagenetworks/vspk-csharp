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

public class InfrastructureAccessProfile: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ESSHAuthMode {KEY_BASED,PASSWORD_AND_KEY_BASED,PASSWORD_BASED };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ESourceIPFilter {DISABLED,ENABLED };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("SSHAuthMode")]
   protected ESSHAuthMode? _SSHAuthMode;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<Metadata> _embeddedMetadata;
   
   [JsonProperty("enterpriseID")]
   protected String _enterpriseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("password")]
   protected String _password;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("sourceIPFilter")]
   protected ESourceIPFilter? _sourceIPFilter;
   
   [JsonProperty("userName")]
   protected String _userName;
   

   
   [JsonIgnore]
   private ConnectionendpointsFetcher _connectionendpoints;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   [JsonIgnore]
   private NSGatewayTemplatesFetcher _nSGatewayTemplates;
   
   [JsonIgnore]
   private SSHKeysFetcher _sSHKeys;
   
   public InfrastructureAccessProfile() {
      
      _connectionendpoints = new ConnectionendpointsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
      _nSGatewayTemplates = new NSGatewayTemplatesFetcher(this);
      
      _sSHKeys = new SSHKeysFetcher(this);
      
   }

   
   [JsonIgnore]
   public ESSHAuthMode? NUSSHAuthMode {
      get {
         return _SSHAuthMode;
      }
      set {
         this._SSHAuthMode = value;
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
   public String NUEnterpriseID {
      get {
         return _enterpriseID;
      }
      set {
         this._enterpriseID = value;
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
   public String NUPassword {
      get {
         return _password;
      }
      set {
         this._password = value;
      }
   }

   
   [JsonIgnore]
   public ESourceIPFilter? NUSourceIPFilter {
      get {
         return _sourceIPFilter;
      }
      set {
         this._sourceIPFilter = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserName {
      get {
         return _userName;
      }
      set {
         this._userName = value;
      }
   }

   

   
   public ConnectionendpointsFetcher getConnectionendpoints() {
      return _connectionendpoints;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   
   public NSGatewayTemplatesFetcher getNSGatewayTemplates() {
      return _nSGatewayTemplates;
   }
   
   public SSHKeysFetcher getSSHKeys() {
      return _sSHKeys;
   }
   

   public String toString() {
      return "InfrastructureAccessProfile [" + "SSHAuthMode=" + _SSHAuthMode + ", description=" + _description + ", embeddedMetadata=" + _embeddedMetadata + ", enterpriseID=" + _enterpriseID + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", name=" + _name + ", password=" + _password + ", sourceIPFilter=" + _sourceIPFilter + ", userName=" + _userName + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "infrastructureaccessprofiles";
   }

   public static String getRestName()
   {
	return "infrastructureaccessprofile";
   }
}
}