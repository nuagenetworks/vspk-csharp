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

public class Flowstatisticsaggregationrule: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EAggregationCriteria {FORWARD_AND_REVERSE_TRAFFIC_PORT_AGG };
   public enum EMatchingCriteria {L4_SERVICE,L4_SERVICE_GROUP };

   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("aggregationCriteria")]
   protected EAggregationCriteria? _aggregationCriteria;
   
   [JsonProperty("associatedTrafficTypeID")]
   protected String _associatedTrafficTypeID;
   
   [JsonProperty("description")]
   protected String _description;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("matchingCriteria")]
   protected EMatchingCriteria? _matchingCriteria;
   
   [JsonProperty("name")]
   protected String _name;
   

   
   public Flowstatisticsaggregationrule() {
      
   }

   
   [JsonIgnore]
   public EAggregationCriteria? NUAggregationCriteria {
      get {
         return _aggregationCriteria;
      }
      set {
         this._aggregationCriteria = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedTrafficTypeID {
      get {
         return _associatedTrafficTypeID;
      }
      set {
         this._associatedTrafficTypeID = value;
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
   public EMatchingCriteria? NUMatchingCriteria {
      get {
         return _matchingCriteria;
      }
      set {
         this._matchingCriteria = value;
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

   

   

   public String toString() {
      return "Flowstatisticsaggregationrule [" + "aggregationCriteria=" + _aggregationCriteria + ", associatedTrafficTypeID=" + _associatedTrafficTypeID + ", description=" + _description + ", matchingCriteria=" + _matchingCriteria + ", name=" + _name + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "flowstatisticsaggregationrules";
   }

   public static String getRestName()
   {
	return "flowstatisticsaggregationrule";
   }
}
}