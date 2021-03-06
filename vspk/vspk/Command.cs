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

public class Command: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ECommand {NSG_APPLY_PATCH,NSG_DELETE_PATCH,NSG_DOWNLOAD_OS_IMAGE,NSG_REBOOT,NSG_RENEW_CERT,NSG_UPDATE_INFO,NSG_UPGRADE_TO_IMAGE,NSG_OVERLAY_SYSLOG_CONTAINER_START,NSG_OVERLAY_SYSLOG_CONTAINER_RESTART,NSG_OVERLAY_SYSLOG_CONTAINER_STOP,NSG_CONTAINER_TEST_SUITE_RUN,NSG_CONTAINER_UNDERLAY_TEST,UNKNOWN };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EOverride {ABANDON,UNSPECIFIED };
   public enum EStatus {ABANDONED,COMPLETED,FAILED,RUNNING,SKIPPED,STARTED,UNKNOWN };

   
   [JsonProperty("assocEntityType")]
   protected String _assocEntityType;
   
   [JsonProperty("associatedParam")]
   protected String _associatedParam;
   
   [JsonProperty("associatedParamType")]
   protected String _associatedParamType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("command")]
   protected ECommand? _command;
   
   [JsonProperty("commandInformation")]
   protected String _commandInformation;
   
   [JsonProperty("creationDate")]
   protected String _creationDate;
   
   [JsonProperty("detail")]
   protected String _detail;
   
   [JsonProperty("detailedStatus")]
   protected String _detailedStatus;
   
   [JsonProperty("detailedStatusCode")]
   protected long? _detailedStatusCode;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("fullCommand")]
   protected String _fullCommand;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("lastUpdatedDate")]
   protected String _lastUpdatedDate;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("override")]
   protected EOverride? _override;
   
   [JsonProperty("owner")]
   protected String _owner;
   
   [JsonProperty("progress")]
   protected String _progress;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("summary")]
   protected String _summary;
   

   
   public Command() {
      
   }

   
   [JsonIgnore]
   public String NUAssocEntityType {
      get {
         return _assocEntityType;
      }
      set {
         this._assocEntityType = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedParam {
      get {
         return _associatedParam;
      }
      set {
         this._associatedParam = value;
      }
   }

   
   [JsonIgnore]
   public String NUAssociatedParamType {
      get {
         return _associatedParamType;
      }
      set {
         this._associatedParamType = value;
      }
   }

   
   [JsonIgnore]
   public ECommand? NUCommand {
      get {
         return _command;
      }
      set {
         this._command = value;
      }
   }

   
   [JsonIgnore]
   public String NUCommandInformation {
      get {
         return _commandInformation;
      }
      set {
         this._commandInformation = value;
      }
   }

   
   [JsonIgnore]
   public String NUCreationDate {
      get {
         return _creationDate;
      }
      set {
         this._creationDate = value;
      }
   }

   
   [JsonIgnore]
   public String NUDetail {
      get {
         return _detail;
      }
      set {
         this._detail = value;
      }
   }

   
   [JsonIgnore]
   public String NUDetailedStatus {
      get {
         return _detailedStatus;
      }
      set {
         this._detailedStatus = value;
      }
   }

   
   [JsonIgnore]
   public long? NUDetailedStatusCode {
      get {
         return _detailedStatusCode;
      }
      set {
         this._detailedStatusCode = value;
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
   public String NUFullCommand {
      get {
         return _fullCommand;
      }
      set {
         this._fullCommand = value;
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
   public String NULastUpdatedDate {
      get {
         return _lastUpdatedDate;
      }
      set {
         this._lastUpdatedDate = value;
      }
   }

   
   [JsonIgnore]
   public EOverride? NUOverride {
      get {
         return _override;
      }
      set {
         this._override = value;
      }
   }

   
   [JsonIgnore]
   public String NUOwner {
      get {
         return _owner;
      }
      set {
         this._owner = value;
      }
   }

   
   [JsonIgnore]
   public String NUProgress {
      get {
         return _progress;
      }
      set {
         this._progress = value;
      }
   }

   
   [JsonIgnore]
   public EStatus? NUStatus {
      get {
         return _status;
      }
      set {
         this._status = value;
      }
   }

   
   [JsonIgnore]
   public String NUSummary {
      get {
         return _summary;
      }
      set {
         this._summary = value;
      }
   }

   

   

   public String toString() {
      return "Command [" + "assocEntityType=" + _assocEntityType + ", associatedParam=" + _associatedParam + ", associatedParamType=" + _associatedParamType + ", command=" + _command + ", commandInformation=" + _commandInformation + ", creationDate=" + _creationDate + ", detail=" + _detail + ", detailedStatus=" + _detailedStatus + ", detailedStatusCode=" + _detailedStatusCode + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", fullCommand=" + _fullCommand + ", lastUpdatedBy=" + _lastUpdatedBy + ", lastUpdatedDate=" + _lastUpdatedDate + ", override=" + _override + ", owner=" + _owner + ", progress=" + _progress + ", status=" + _status + ", summary=" + _summary + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "commands";
   }

   public static String getRestName()
   {
	return "command";
   }
}
}