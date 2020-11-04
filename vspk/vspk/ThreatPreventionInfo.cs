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

public class ThreatPreventionInfo: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EConfigurationStatus {ACTIVATION_FAILED,CONFIG_FAILED,NOT_APPLICABLE,REGISTRATION_FAILED,SYNCED };
   public enum EManagementServerConnectionStatus {CONNECTED,DISCONNECTED,NOT_APPLICABLE };
   public enum EServiceStatus {BLOCKED,CRASHED,DYING,IDLE,INIT,LAST,PAUSED,PMSUSPENDED,RUNNING,SHUTDOWN,SHUTOFF };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("configurationStatus")]
   protected EConfigurationStatus? _configurationStatus;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("managementServerConnectionStatus")]
   protected EManagementServerConnectionStatus? _managementServerConnectionStatus;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("serviceStatus")]
   protected EServiceStatus? _serviceStatus;
   

   
   public ThreatPreventionInfo() {
      
   }

   
   [JsonIgnore]
   public EConfigurationStatus? NUConfigurationStatus {
      get {
         return _configurationStatus;
      }
      set {
         this._configurationStatus = value;
      }
   }

   
   [JsonIgnore]
   public EManagementServerConnectionStatus? NUManagementServerConnectionStatus {
      get {
         return _managementServerConnectionStatus;
      }
      set {
         this._managementServerConnectionStatus = value;
      }
   }

   
   [JsonIgnore]
   public EServiceStatus? NUServiceStatus {
      get {
         return _serviceStatus;
      }
      set {
         this._serviceStatus = value;
      }
   }

   

   

   public String toString() {
      return "ThreatPreventionInfo [" + "configurationStatus=" + _configurationStatus + ", managementServerConnectionStatus=" + _managementServerConnectionStatus + ", serviceStatus=" + _serviceStatus + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "threatpreventioninfos";
   }

   public static String getRestName()
   {
	return "threatpreventioninfo";
   }
}
}