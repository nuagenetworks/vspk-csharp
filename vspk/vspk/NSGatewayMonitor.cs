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

public class NSGatewayMonitor: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("controllervrslinks")]
   protected System.Collections.Generic.List<String> _controllervrslinks;
   
   [JsonProperty("nsginfo")]
   protected Object _nsginfo;
   
   [JsonProperty("nsgstate")]
   protected Object _nsgstate;
   
   [JsonProperty("nsgsummary")]
   protected Object _nsgsummary;
   
   [JsonProperty("vrsinfo")]
   protected Object _vrsinfo;
   
   [JsonProperty("vscs")]
   protected System.Collections.Generic.List<String> _vscs;
   

   
   public NSGatewayMonitor() {
      
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUControllervrslinks {
      get {
         return _controllervrslinks;
      }
      set {
         this._controllervrslinks = value;
      }
   }

   
   [JsonIgnore]
   public Object NUNsginfo {
      get {
         return _nsginfo;
      }
      set {
         this._nsginfo = value;
      }
   }

   
   [JsonIgnore]
   public Object NUNsgstate {
      get {
         return _nsgstate;
      }
      set {
         this._nsgstate = value;
      }
   }

   
   [JsonIgnore]
   public Object NUNsgsummary {
      get {
         return _nsgsummary;
      }
      set {
         this._nsgsummary = value;
      }
   }

   
   [JsonIgnore]
   public Object NUVrsinfo {
      get {
         return _vrsinfo;
      }
      set {
         this._vrsinfo = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUVscs {
      get {
         return _vscs;
      }
      set {
         this._vscs = value;
      }
   }

   

   

   public String toString() {
      return "NSGatewayMonitor [" + "controllervrslinks=" + _controllervrslinks + ", nsginfo=" + _nsginfo + ", nsgstate=" + _nsgstate + ", nsgsummary=" + _nsgsummary + ", vrsinfo=" + _vrsinfo + ", vscs=" + _vscs + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "nsgatewaysmonitors";
   }

   public static String getRestName()
   {
	return "nsgatewaysmonitor";
   }
}
}