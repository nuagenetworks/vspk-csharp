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

using net.nuagenetworks.vspk.v5_0.fetchers;

namespace net.nuagenetworks.vspk.v5_0
{

public class VNFDomainMapping: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ESegmentationType {VLAN };

   
   [JsonProperty("associatedNSGatewayID")]
   protected String _associatedNSGatewayID;
   
   [JsonProperty("associatedNSGatewayName")]
   protected String _associatedNSGatewayName;
   
   [JsonProperty("segmentationID")]
   protected long? _segmentationID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("segmentationType")]
   protected ESegmentationType? _segmentationType;
   

   
   public VNFDomainMapping() {
      
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGatewayID {
      get {
         return _associatedNSGatewayID;
      }
      set {
         this._associatedNSGatewayID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedNSGatewayName {
      get {
         return _associatedNSGatewayName;
      }
      set {
         this._associatedNSGatewayName = value;
      }
   }

   
   [JsonIgnore]
   public long? NUSegmentationID {
      get {
         return _segmentationID;
      }
      set {
         this._segmentationID = value;
      }
   }

   
   [JsonIgnore]
   public ESegmentationType? NUSegmentationType {
      get {
         return _segmentationType;
      }
      set {
         this._segmentationType = value;
      }
   }

   

   

   public String toString() {
      return "VNFDomainMapping [" + "associatedNSGatewayID=" + _associatedNSGatewayID + ", associatedNSGatewayName=" + _associatedNSGatewayName + ", segmentationID=" + _segmentationID + ", segmentationType=" + _segmentationType + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "vnfdomainmappings";
   }

   public static String getRestName()
   {
	return "vnfdomainmapping";
   }
}
}