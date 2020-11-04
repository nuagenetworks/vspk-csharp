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

public class OverlayManagementSubnetProfile: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("associatedDNASubnetID")]
   protected String _associatedDNASubnetID;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("syslogDestinationIDs")]
   protected System.Collections.Generic.List<String> _syslogDestinationIDs;
   

   
   public OverlayManagementSubnetProfile() {
      
   }

   
   [JsonIgnore]
   public String NUAssociatedDNASubnetID {
      get {
         return _associatedDNASubnetID;
      }
      set {
         this._associatedDNASubnetID = value;
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
   public String NUName {
      get {
         return _name;
      }
      set {
         this._name = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUSyslogDestinationIDs {
      get {
         return _syslogDestinationIDs;
      }
      set {
         this._syslogDestinationIDs = value;
      }
   }

   

   

   public String toString() {
      return "OverlayManagementSubnetProfile [" + "associatedDNASubnetID=" + _associatedDNASubnetID + ", description=" + _description + ", name=" + _name + ", syslogDestinationIDs=" + _syslogDestinationIDs + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "overlaymanagementsubnetprofiles";
   }

   public static String getRestName()
   {
	return "overlaymanagementsubnetprofile";
   }
}
}