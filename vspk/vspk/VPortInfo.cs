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

public class VPortInfo: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EVPortOperationalState {DEGRADED,DOWN,INIT,UP };

   
   [JsonProperty("gatewayID")]
   protected String _gatewayID;
   
   [JsonProperty("gatewayName")]
   protected String _gatewayName;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("vPortOperationalState")]
   protected EVPortOperationalState? _vPortOperationalState;
   

   
   public VPortInfo() {
      
   }

   
   [JsonIgnore]
   public String NUGatewayID {
      get {
         return _gatewayID;
      }
      set {
         this._gatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUGatewayName {
      get {
         return _gatewayName;
      }
      set {
         this._gatewayName = value;
      }
   }

   
   [JsonIgnore]
   public EVPortOperationalState? NUVPortOperationalState {
      get {
         return _vPortOperationalState;
      }
      set {
         this._vPortOperationalState = value;
      }
   }

   

   

   public String toString() {
      return "VPortInfo [" + "gatewayID=" + _gatewayID + ", gatewayName=" + _gatewayName + ", vPortOperationalState=" + _vPortOperationalState + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "None";
   }

   public static String getRestName()
   {
	return "None";
   }
}
}