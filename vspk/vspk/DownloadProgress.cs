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

public class DownloadProgress: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("averageSpeed")]
   protected long? _averageSpeed;
   
   [JsonProperty("currentSpeed")]
   protected long? _currentSpeed;
   
   [JsonProperty("imageFileName")]
   protected String _imageFileName;
   
   [JsonProperty("imageVersion")]
   protected String _imageVersion;
   
   [JsonProperty("percentage")]
   protected long? _percentage;
   
   [JsonProperty("startTime")]
   protected long? _startTime;
   
   [JsonProperty("timeLeft")]
   protected String _timeLeft;
   
   [JsonProperty("timeSpent")]
   protected String _timeSpent;
   

   
   public DownloadProgress() {
      
   }

   
   [JsonIgnore]
   public long? NUAverageSpeed {
      get {
         return _averageSpeed;
      }
      set {
         this._averageSpeed = value;
      }
   }

   
   [JsonIgnore]
   public long? NUCurrentSpeed {
      get {
         return _currentSpeed;
      }
      set {
         this._currentSpeed = value;
      }
   }

   
   [JsonIgnore]
   public String NUImageFileName {
      get {
         return _imageFileName;
      }
      set {
         this._imageFileName = value;
      }
   }

   
   [JsonIgnore]
   public String NUImageVersion {
      get {
         return _imageVersion;
      }
      set {
         this._imageVersion = value;
      }
   }

   
   [JsonIgnore]
   public long? NUPercentage {
      get {
         return _percentage;
      }
      set {
         this._percentage = value;
      }
   }

   
   [JsonIgnore]
   public long? NUStartTime {
      get {
         return _startTime;
      }
      set {
         this._startTime = value;
      }
   }

   
   [JsonIgnore]
   public String NUTimeLeft {
      get {
         return _timeLeft;
      }
      set {
         this._timeLeft = value;
      }
   }

   
   [JsonIgnore]
   public String NUTimeSpent {
      get {
         return _timeSpent;
      }
      set {
         this._timeSpent = value;
      }
   }

   

   

   public String toString() {
      return "DownloadProgress [" + "averageSpeed=" + _averageSpeed + ", currentSpeed=" + _currentSpeed + ", imageFileName=" + _imageFileName + ", imageVersion=" + _imageVersion + ", percentage=" + _percentage + ", startTime=" + _startTime + ", timeLeft=" + _timeLeft + ", timeSpent=" + _timeSpent + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
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