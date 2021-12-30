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

public class ScheduledTestSuite: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EScheduleIntervalUnits {DAYS,HOURS,MINUTES,MONTHS };

   
   [JsonProperty("description")]
   protected String _description;
   
   [JsonProperty("endDateTime")]
   protected long? _endDateTime;
   
   [JsonProperty("name")]
   protected String _name;
   
   [JsonProperty("scheduleInterval")]
   protected long? _scheduleInterval;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("scheduleIntervalUnits")]
   protected EScheduleIntervalUnits? _scheduleIntervalUnits;
   
   [JsonProperty("startDateTime")]
   protected long? _startDateTime;
   

   
   [JsonIgnore]
   private ScheduledtestsuiterunsFetcher _scheduledtestsuiteruns;
   
   [JsonIgnore]
   private TestsFetcher _tests;
   
   public ScheduledTestSuite() {
      
      _scheduledtestsuiteruns = new ScheduledtestsuiterunsFetcher(this);
      
      _tests = new TestsFetcher(this);
      
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
   public long? NUEndDateTime {
      get {
         return _endDateTime;
      }
      set {
         this._endDateTime = value;
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
   public long? NUScheduleInterval {
      get {
         return _scheduleInterval;
      }
      set {
         this._scheduleInterval = value;
      }
   }

   
   [JsonIgnore]
   public EScheduleIntervalUnits? NUScheduleIntervalUnits {
      get {
         return _scheduleIntervalUnits;
      }
      set {
         this._scheduleIntervalUnits = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStartDateTime {
      get {
         return _startDateTime;
      }
      set {
         this._startDateTime = value;
      }
   }

   

   
   public ScheduledtestsuiterunsFetcher getScheduledtestsuiteruns() {
      return _scheduledtestsuiteruns;
   }
   
   public TestsFetcher getTests() {
      return _tests;
   }
   

   public String toString() {
      return "ScheduledTestSuite [" + "description=" + _description + ", endDateTime=" + _endDateTime + ", name=" + _name + ", scheduleInterval=" + _scheduleInterval + ", scheduleIntervalUnits=" + _scheduleIntervalUnits + ", startDateTime=" + _startDateTime + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "scheduledtestsuites";
   }

   public static String getRestName()
   {
	return "scheduledtestsuite";
   }
}
}