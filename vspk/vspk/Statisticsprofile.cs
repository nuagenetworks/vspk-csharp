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

public class Statisticsprofile: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("flowStatsAggregationEnabled")]
   protected bool _flowStatsAggregationEnabled;
   
   [JsonProperty("name")]
   protected String _name;
   

   
   [JsonIgnore]
   private EnterprisesFetcher _enterprises;
   
   [JsonIgnore]
   private FlowstatisticsaggregationrulesFetcher _flowstatisticsaggregationrules;
   
   [JsonIgnore]
   private NSGatewaysFetcher _nSGateways;
   
   public Statisticsprofile() {
      
      _enterprises = new EnterprisesFetcher(this);
      
      _flowstatisticsaggregationrules = new FlowstatisticsaggregationrulesFetcher(this);
      
      _nSGateways = new NSGatewaysFetcher(this);
      
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
   public bool NUFlowStatsAggregationEnabled {
      get {
         return _flowStatsAggregationEnabled;
      }
      set {
         this._flowStatsAggregationEnabled = value;
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

   

   
   public EnterprisesFetcher getEnterprises() {
      return _enterprises;
   }
   
   public FlowstatisticsaggregationrulesFetcher getFlowstatisticsaggregationrules() {
      return _flowstatisticsaggregationrules;
   }
   
   public NSGatewaysFetcher getNSGateways() {
      return _nSGateways;
   }
   

   public String toString() {
      return "Statisticsprofile [" + "description=" + _description + ", flowStatsAggregationEnabled=" + _flowStatsAggregationEnabled + ", name=" + _name + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "statisticsprofiles";
   }

   public static String getRestName()
   {
	return "statisticsprofile";
   }
}
}