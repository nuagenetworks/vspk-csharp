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

public class SysmonUplinkConnection: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EIpsecDtlsState {ADMIN_DOWN,DOWN,NONE,UP };
   public enum EJsonState {ADMIN_DOWN,DOWN,NONE,UP };
   public enum EOpenflowState {ADMIN_DOWN,DOWN,NONE,UP };
   public enum EVxlanDtlsState {ADMIN_DOWN,DOWN,NONE,UP };

   
   [JsonProperty("datapathUplinkId")]
   protected String _datapathUplinkId;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("ipsecDtlsState")]
   protected EIpsecDtlsState? _ipsecDtlsState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("jsonState")]
   protected EJsonState? _jsonState;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("openflowState")]
   protected EOpenflowState? _openflowState;
   
   [JsonProperty("privateIP")]
   protected String _privateIP;
   
   [JsonProperty("publicIP")]
   protected String _publicIP;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("vxlanDtlsState")]
   protected EVxlanDtlsState? _vxlanDtlsState;
   

   
   public SysmonUplinkConnection() {
      
   }

   
   [JsonIgnore]
   public String NUDatapathUplinkId {
      get {
         return _datapathUplinkId;
      }
      set {
         this._datapathUplinkId = value;
      }
   }

   
   [JsonIgnore]
   public EIpsecDtlsState? NUIpsecDtlsState {
      get {
         return _ipsecDtlsState;
      }
      set {
         this._ipsecDtlsState = value;
      }
   }

   
   [JsonIgnore]
   public EJsonState? NUJsonState {
      get {
         return _jsonState;
      }
      set {
         this._jsonState = value;
      }
   }

   
   [JsonIgnore]
   public EOpenflowState? NUOpenflowState {
      get {
         return _openflowState;
      }
      set {
         this._openflowState = value;
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
   public String NUPublicIP {
      get {
         return _publicIP;
      }
      set {
         this._publicIP = value;
      }
   }

   
   [JsonIgnore]
   public EVxlanDtlsState? NUVxlanDtlsState {
      get {
         return _vxlanDtlsState;
      }
      set {
         this._vxlanDtlsState = value;
      }
   }

   

   

   public String toString() {
      return "SysmonUplinkConnection [" + "datapathUplinkId=" + _datapathUplinkId + ", ipsecDtlsState=" + _ipsecDtlsState + ", jsonState=" + _jsonState + ", openflowState=" + _openflowState + ", privateIP=" + _privateIP + ", publicIP=" + _publicIP + ", vxlanDtlsState=" + _vxlanDtlsState + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
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