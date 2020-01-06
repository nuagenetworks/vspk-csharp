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

public class TestRun: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EOperationStatus {COMPLETED,FAILED,STARTED,TIMED_OUT,UNKNOWN };

   
   [JsonProperty("associatedTestID")]
   protected String _associatedTestID;
   
   [JsonProperty("associatedTestSuiteRunID")]
   protected String _associatedTestSuiteRunID;
   
   [JsonProperty("command")]
   protected String _command;
   
   [JsonProperty("commandExitCode")]
   protected long? _commandExitCode;
   
   [JsonProperty("commandOutput")]
   protected String _commandOutput;
   
   [JsonProperty("commandOutputSummary")]
   protected String _commandOutputSummary;
   
   [JsonProperty("duration")]
   protected long? _duration;
   
   [JsonProperty("embeddedMetadata")]
   protected System.Collections.Generic.List<String> _embeddedMetadata;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("operationStatus")]
   protected EOperationStatus? _operationStatus;
   
   [JsonProperty("startDateTime")]
   protected long? _startDateTime;
   
   [JsonProperty("stopDateTime")]
   protected long? _stopDateTime;
   

   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public TestRun() {
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAssociatedTestID {
      get {
         return _associatedTestID;
      }
      set {
         this._associatedTestID = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedTestSuiteRunID {
      get {
         return _associatedTestSuiteRunID;
      }
      set {
         this._associatedTestSuiteRunID = value;
      }
   }

   
   [JsonIgnore]
   public String NUCommand {
      get {
         return _command;
      }
      set {
         this._command = value;
      }
   }

   
   [JsonIgnore]
   public long? NUCommandExitCode {
      get {
         return _commandExitCode;
      }
      set {
         this._commandExitCode = value;
      }
   }

   
   [JsonIgnore]
   public String NUCommandOutput {
      get {
         return _commandOutput;
      }
      set {
         this._commandOutput = value;
      }
   }

   
   [JsonIgnore]
   public String NUCommandOutputSummary {
      get {
         return _commandOutputSummary;
      }
      set {
         this._commandOutputSummary = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDuration {
      get {
         return _duration;
      }
      set {
         this._duration = value;
      }
   }

   
   [JsonIgnore]
   public System.Collections.Generic.List<String> NUEmbeddedMetadata {
      get {
         return _embeddedMetadata;
      }
      set {
         this._embeddedMetadata = value;
      }
   }

   
   [JsonIgnore]
   public EEntityScope? NUEntityScope {
      get {
         return _entityScope;
      }
      set {
         this._entityScope = value;
      }
   }

   
   [JsonIgnore]
   public String NUExternalID {
      get {
         return _externalID;
      }
      set {
         this._externalID = value;
      }
   }

   
   [JsonIgnore]
   public String NULastUpdatedBy {
      get {
         return _lastUpdatedBy;
      }
      set {
         this._lastUpdatedBy = value;
      }
   }

   
   [JsonIgnore]
   public EOperationStatus? NUOperationStatus {
      get {
         return _operationStatus;
      }
      set {
         this._operationStatus = value;
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

   
   [JsonIgnore]
   public long? NUStopDateTime {
      get {
         return _stopDateTime;
      }
      set {
         this._stopDateTime = value;
      }
   }

   

   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "TestRun [" + "associatedTestID=" + _associatedTestID + ", associatedTestSuiteRunID=" + _associatedTestSuiteRunID + ", command=" + _command + ", commandExitCode=" + _commandExitCode + ", commandOutput=" + _commandOutput + ", commandOutputSummary=" + _commandOutputSummary + ", duration=" + _duration + ", embeddedMetadata=" + _embeddedMetadata + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", lastUpdatedBy=" + _lastUpdatedBy + ", operationStatus=" + _operationStatus + ", startDateTime=" + _startDateTime + ", stopDateTime=" + _stopDateTime + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "testruns";
   }

   public static String getRestName()
   {
	return "testrun";
   }
}
}