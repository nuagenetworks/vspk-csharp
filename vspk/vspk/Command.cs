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

public class Command: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum ECommand {NSG_APPLY_PATCH,NSG_DOWNLOAD_OS_IMAGE,NSG_UPGRADE_TO_IMAGE,UNKNOWN };
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum EOverride {ABANDON,UNSPECIFIED };
   public enum EStatus {COMPLETE,FAILED,STARTED,UNKNOWN };

   
   [JsonProperty("associatedParam")]
   protected String _associatedParam;
   
   [JsonProperty("associatedParamType")]
   protected String _associatedParamType;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("command")]
   protected ECommand? _command;
   
   [JsonProperty("commandInformation")]
   protected String _commandInformation;
   
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
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("override")]
   protected EOverride? _override;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("status")]
   protected EStatus? _status;
   
   [JsonProperty("summary")]
   protected String _summary;
   

   
   public Command() {
      
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
   public EOverride? NUOverride {
      get {
         return _override;
      }
      set {
         this._override = value;
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
      return "Command [" + "associatedParam=" + _associatedParam + ", associatedParamType=" + _associatedParamType + ", command=" + _command + ", commandInformation=" + _commandInformation + ", detailedStatus=" + _detailedStatus + ", detailedStatusCode=" + _detailedStatusCode + ", entityScope=" + _entityScope + ", externalID=" + _externalID + ", fullCommand=" + _fullCommand + ", lastUpdatedBy=" + _lastUpdatedBy + ", override=" + _override + ", status=" + _status + ", summary=" + _summary + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
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