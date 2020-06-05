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

public class EthernetSegmentGroup: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EPortType {ACCESS };

   
   [JsonProperty("VLANRange")]
   protected String _VLANRange;
   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("ethernetSegmentID")]
   protected String _ethernetSegmentID;
   
   [JsonProperty("name")]
   protected String _name;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("portType")]
   protected EPortType? _portType;
   
   [JsonProperty("virtual")]
   protected bool _virtual;
   

   
   [JsonIgnore]
   private AlarmsFetcher _alarms;
   
   [JsonIgnore]
   private EnterprisePermissionsFetcher _enterprisePermissions;
   
   [JsonIgnore]
   private PermissionsFetcher _permissions;
   
   [JsonIgnore]
   private VLANsFetcher _vLANs;
   
   public EthernetSegmentGroup() {
      
      _alarms = new AlarmsFetcher(this);
      
      _enterprisePermissions = new EnterprisePermissionsFetcher(this);
      
      _permissions = new PermissionsFetcher(this);
      
      _vLANs = new VLANsFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUVLANRange {
      get {
         return _VLANRange;
      }
      set {
         this._VLANRange = value;
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
   public String NUEthernetSegmentID {
      get {
         return _ethernetSegmentID;
      }
      set {
         this._ethernetSegmentID = value;
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
   public EPortType? NUPortType {
      get {
         return _portType;
      }
      set {
         this._portType = value;
      }
   }

   
   [JsonIgnore]
   public bool NUVirtual {
      get {
         return _virtual;
      }
      set {
         this._virtual = value;
      }
   }

   

   
   public AlarmsFetcher getAlarms() {
      return _alarms;
   }
   
   public EnterprisePermissionsFetcher getEnterprisePermissions() {
      return _enterprisePermissions;
   }
   
   public PermissionsFetcher getPermissions() {
      return _permissions;
   }
   
   public VLANsFetcher getVLANs() {
      return _vLANs;
   }
   

   public String toString() {
      return "EthernetSegmentGroup [" + "VLANRange=" + _VLANRange + ", description=" + _description + ", ethernetSegmentID=" + _ethernetSegmentID + ", name=" + _name + ", portType=" + _portType + ", virtual=" + _virtual + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "ethernetsegmentgroups";
   }

   public static String getRestName()
   {
	return "ethernetsegmentgroup";
   }
}
}