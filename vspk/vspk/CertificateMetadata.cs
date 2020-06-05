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

public class CertificateMetadata: RestObject {

   private const long serialVersionUID = 1L;

   

   
   [JsonProperty("SHA1Fingerprint")]
   protected String _SHA1Fingerprint;
   
   [JsonProperty("issuer")]
   protected String _issuer;
   
   [JsonProperty("notAfter")]
   protected long? _notAfter;
   
   [JsonProperty("notBefore")]
   protected long? _notBefore;
   
   [JsonProperty("serial")]
   protected String _serial;
   
   [JsonProperty("subject")]
   protected String _subject;
   

   
   public CertificateMetadata() {
      
   }

   
   [JsonIgnore]
   public String NUSHA1Fingerprint {
      get {
         return _SHA1Fingerprint;
      }
      set {
         this._SHA1Fingerprint = value;
      }
   }

   
   [JsonIgnore]
   public String NUIssuer {
      get {
         return _issuer;
      }
      set {
         this._issuer = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNotAfter {
      get {
         return _notAfter;
      }
      set {
         this._notAfter = value;
      }
   }

   
   [JsonIgnore]
   public long? NUNotBefore {
      get {
         return _notBefore;
      }
      set {
         this._notBefore = value;
      }
   }

   
   [JsonIgnore]
   public String NUSerial {
      get {
         return _serial;
      }
      set {
         this._serial = value;
      }
   }

   
   [JsonIgnore]
   public String NUSubject {
      get {
         return _subject;
      }
      set {
         this._subject = value;
      }
   }

   

   

   public String toString() {
      return "CertificateMetadata [" + "SHA1Fingerprint=" + _SHA1Fingerprint + ", issuer=" + _issuer + ", notAfter=" + _notAfter + ", notBefore=" + _notBefore + ", serial=" + _serial + ", subject=" + _subject + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
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