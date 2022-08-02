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

public class Ddnsconfig: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EConnectionStatus {FAILED,SUCCESS,UNKNOWN };
   public enum EProviderName {DYN_DNS,NO_IP };

   
   [JsonProperty("assocGatewayId")]
   protected String _assocGatewayId;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("connectionStatus")]
   protected EConnectionStatus? _connectionStatus;
   
   [JsonProperty("enableDDNSConfig")]
   protected bool _enableDDNSConfig;
   
   [JsonProperty("hostname")]
   protected String _hostname;
   
   [JsonProperty("password")]
   protected String _password;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("providerName")]
   protected EProviderName? _providerName;
   
   [JsonProperty("username")]
   protected String _username;
   

   
   [JsonIgnore]
   private DdnsconfigbindingsFetcher _ddnsconfigbindings;
   
   public Ddnsconfig() {
      
      _ddnsconfigbindings = new DdnsconfigbindingsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssocGatewayId {
      get {
         return _assocGatewayId;
      }
      set {
         this._assocGatewayId = value;
      }
   }

   
   [JsonIgnore]
   public EConnectionStatus? NUConnectionStatus {
      get {
         return _connectionStatus;
      }
      set {
         this._connectionStatus = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEnableDDNSConfig {
      get {
         return _enableDDNSConfig;
      }
      set {
         this._enableDDNSConfig = value;
      }
   }

   
   [JsonIgnore]
   public String NUHostname {
      get {
         return _hostname;
      }
      set {
         this._hostname = value;
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
   public EProviderName? NUProviderName {
      get {
         return _providerName;
      }
      set {
         this._providerName = value;
      }
   }

   
   [JsonIgnore]
   public String NUUsername {
      get {
         return _username;
      }
      set {
         this._username = value;
      }
   }

   

   
   public DdnsconfigbindingsFetcher getDdnsconfigbindings() {
      return _ddnsconfigbindings;
   }
   

   public String toString() {
      return "Ddnsconfig [" + "assocGatewayId=" + _assocGatewayId + ", connectionStatus=" + _connectionStatus + ", enableDDNSConfig=" + _enableDDNSConfig + ", hostname=" + _hostname + ", password=" + _password + ", providerName=" + _providerName + ", username=" + _username + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ddnsconfigs";
   }

   public static String getRestName()
   {
	return "ddnsconfig";
   }
}
}