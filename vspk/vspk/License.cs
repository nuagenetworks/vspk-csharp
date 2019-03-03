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

public class License: RestObject {

   private const long serialVersionUID = 1L;

   
   public enum EEntityScope {ENTERPRISE,GLOBAL };
   public enum ELicenseEncryption {ENCRYPTION_DISABLED,ENCRYPTION_ENABLED };
   public enum ELicenseType {CLUSTERED,STANDARD };

   
   [JsonProperty("additionalSupportedVersions")]
   protected String _additionalSupportedVersions;
   
   [JsonProperty("allowedAVRSGsCount")]
   protected long? _allowedAVRSGsCount;
   
   [JsonProperty("allowedAVRSsCount")]
   protected long? _allowedAVRSsCount;
   
   [JsonProperty("allowedCPEsCount")]
   protected long? _allowedCPEsCount;
   
   [JsonProperty("allowedNICsCount")]
   protected long? _allowedNICsCount;
   
   [JsonProperty("allowedVDFGsCount")]
   protected long? _allowedVDFGsCount;
   
   [JsonProperty("allowedVDFsCount")]
   protected long? _allowedVDFsCount;
   
   [JsonProperty("allowedVMsCount")]
   protected long? _allowedVMsCount;
   
   [JsonProperty("allowedVRSGsCount")]
   protected long? _allowedVRSGsCount;
   
   [JsonProperty("allowedVRSsCount")]
   protected long? _allowedVRSsCount;
   
   [JsonProperty("city")]
   protected String _city;
   
   [JsonProperty("company")]
   protected String _company;
   
   [JsonProperty("country")]
   protected String _country;
   
   [JsonProperty("customerKey")]
   protected String _customerKey;
   
   [JsonProperty("email")]
   protected String _email;
   
   [JsonProperty("encryptionMode")]
   protected bool _encryptionMode;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("entityScope")]
   protected EEntityScope? _entityScope;
   
   [JsonProperty("expirationDate")]
   protected long? _expirationDate;
   
   [JsonProperty("expiryTimestamp")]
   protected long? _expiryTimestamp;
   
   [JsonProperty("externalID")]
   protected String _externalID;
   
   [JsonProperty("isClusterLicense")]
   protected bool _isClusterLicense;
   
   [JsonProperty("lastUpdatedBy")]
   protected String _lastUpdatedBy;
   
   [JsonProperty("license")]
   protected String _license;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("licenseEncryption")]
   protected ELicenseEncryption? _licenseEncryption;
   
   [JsonProperty("licenseEntities")]
   protected String _licenseEntities;
   
   [JsonProperty("licenseID")]
   protected long? _licenseID;
   [JsonConverter(typeof(StringEnumConverter))]
   [JsonProperty("licenseType")]
   protected ELicenseType? _licenseType;
   
   [JsonProperty("licensedFeature")]
   protected String _licensedFeature;
   
   [JsonProperty("majorRelease")]
   protected long? _majorRelease;
   
   [JsonProperty("minorRelease")]
   protected long? _minorRelease;
   
   [JsonProperty("phone")]
   protected String _phone;
   
   [JsonProperty("productVersion")]
   protected String _productVersion;
   
   [JsonProperty("provider")]
   protected String _provider;
   
   [JsonProperty("requestID")]
   protected String _requestID;
   
   [JsonProperty("state")]
   protected String _state;
   
   [JsonProperty("street")]
   protected String _street;
   
   [JsonProperty("system")]
   protected String _system;
   
   [JsonProperty("uniqueLicenseIdentifier")]
   protected String _uniqueLicenseIdentifier;
   
   [JsonProperty("userName")]
   protected String _userName;
   
   [JsonProperty("zip")]
   protected String _zip;
   

   
   [JsonIgnore]
   private EventLogsFetcher _eventLogs;
   
   [JsonIgnore]
   private GlobalMetadatasFetcher _globalMetadatas;
   
   [JsonIgnore]
   private MetadatasFetcher _metadatas;
   
   public License() {
      
      _eventLogs = new EventLogsFetcher(this);
      
      _globalMetadatas = new GlobalMetadatasFetcher(this);
      
      _metadatas = new MetadatasFetcher(this);
      
   }

   
   [JsonIgnore]
   public String NUAdditionalSupportedVersions {
      get {
         return _additionalSupportedVersions;
      }
      set {
         this._additionalSupportedVersions = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedAVRSGsCount {
      get {
         return _allowedAVRSGsCount;
      }
      set {
         this._allowedAVRSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedAVRSsCount {
      get {
         return _allowedAVRSsCount;
      }
      set {
         this._allowedAVRSsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedCPEsCount {
      get {
         return _allowedCPEsCount;
      }
      set {
         this._allowedCPEsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedNICsCount {
      get {
         return _allowedNICsCount;
      }
      set {
         this._allowedNICsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedVDFGsCount {
      get {
         return _allowedVDFGsCount;
      }
      set {
         this._allowedVDFGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedVDFsCount {
      get {
         return _allowedVDFsCount;
      }
      set {
         this._allowedVDFsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedVMsCount {
      get {
         return _allowedVMsCount;
      }
      set {
         this._allowedVMsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedVRSGsCount {
      get {
         return _allowedVRSGsCount;
      }
      set {
         this._allowedVRSGsCount = value;
      }
   }

   
   [JsonIgnore]
   public long? NUAllowedVRSsCount {
      get {
         return _allowedVRSsCount;
      }
      set {
         this._allowedVRSsCount = value;
      }
   }

   
   [JsonIgnore]
   public String NUCity {
      get {
         return _city;
      }
      set {
         this._city = value;
      }
   }

   
   [JsonIgnore]
   public String NUCompany {
      get {
         return _company;
      }
      set {
         this._company = value;
      }
   }

   
   [JsonIgnore]
   public String NUCountry {
      get {
         return _country;
      }
      set {
         this._country = value;
      }
   }

   
   [JsonIgnore]
   public String NUCustomerKey {
      get {
         return _customerKey;
      }
      set {
         this._customerKey = value;
      }
   }

   
   [JsonIgnore]
   public String NUEmail {
      get {
         return _email;
      }
      set {
         this._email = value;
      }
   }

   
   [JsonIgnore]
   public bool NUEncryptionMode {
      get {
         return _encryptionMode;
      }
      set {
         this._encryptionMode = value;
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
   public long? NUExpirationDate {
      get {
         return _expirationDate;
      }
      set {
         this._expirationDate = value;
      }
   }

   
   [JsonIgnore]
   public long? NUExpiryTimestamp {
      get {
         return _expiryTimestamp;
      }
      set {
         this._expiryTimestamp = value;
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
   public bool NUIsClusterLicense {
      get {
         return _isClusterLicense;
      }
      set {
         this._isClusterLicense = value;
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
   public String NULicense {
      get {
         return _license;
      }
      set {
         this._license = value;
      }
   }

   
   [JsonIgnore]
   public ELicenseEncryption? NULicenseEncryption {
      get {
         return _licenseEncryption;
      }
      set {
         this._licenseEncryption = value;
      }
   }

   
   [JsonIgnore]
   public String NULicenseEntities {
      get {
         return _licenseEntities;
      }
      set {
         this._licenseEntities = value;
      }
   }

   
   [JsonIgnore]
   public long? NULicenseID {
      get {
         return _licenseID;
      }
      set {
         this._licenseID = value;
      }
   }

   
   [JsonIgnore]
   public ELicenseType? NULicenseType {
      get {
         return _licenseType;
      }
      set {
         this._licenseType = value;
      }
   }

   
   [JsonIgnore]
   public String NULicensedFeature {
      get {
         return _licensedFeature;
      }
      set {
         this._licensedFeature = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMajorRelease {
      get {
         return _majorRelease;
      }
      set {
         this._majorRelease = value;
      }
   }

   
   [JsonIgnore]
   public long? NUMinorRelease {
      get {
         return _minorRelease;
      }
      set {
         this._minorRelease = value;
      }
   }

   
   [JsonIgnore]
   public String NUPhone {
      get {
         return _phone;
      }
      set {
         this._phone = value;
      }
   }

   
   [JsonIgnore]
   public String NUProductVersion {
      get {
         return _productVersion;
      }
      set {
         this._productVersion = value;
      }
   }

   
   [JsonIgnore]
   public String NUProvider {
      get {
         return _provider;
      }
      set {
         this._provider = value;
      }
   }

   
   [JsonIgnore]
   public String NURequestID {
      get {
         return _requestID;
      }
      set {
         this._requestID = value;
      }
   }

   
   [JsonIgnore]
   public String NUState {
      get {
         return _state;
      }
      set {
         this._state = value;
      }
   }

   
   [JsonIgnore]
   public String NUStreet {
      get {
         return _street;
      }
      set {
         this._street = value;
      }
   }

   
   [JsonIgnore]
   public String NUSystem {
      get {
         return _system;
      }
      set {
         this._system = value;
      }
   }

   
   [JsonIgnore]
   public String NUUniqueLicenseIdentifier {
      get {
         return _uniqueLicenseIdentifier;
      }
      set {
         this._uniqueLicenseIdentifier = value;
      }
   }

   
   [JsonIgnore]
   public String NUUserName {
      get {
         return _userName;
      }
      set {
         this._userName = value;
      }
   }

   
   [JsonIgnore]
   public String NUZip {
      get {
         return _zip;
      }
      set {
         this._zip = value;
      }
   }

   

   
   public EventLogsFetcher getEventLogs() {
      return _eventLogs;
   }
   
   public GlobalMetadatasFetcher getGlobalMetadatas() {
      return _globalMetadatas;
   }
   
   public MetadatasFetcher getMetadatas() {
      return _metadatas;
   }
   

   public String toString() {
      return "License [" + "additionalSupportedVersions=" + _additionalSupportedVersions + ", allowedAVRSGsCount=" + _allowedAVRSGsCount + ", allowedAVRSsCount=" + _allowedAVRSsCount + ", allowedCPEsCount=" + _allowedCPEsCount + ", allowedNICsCount=" + _allowedNICsCount + ", allowedVDFGsCount=" + _allowedVDFGsCount + ", allowedVDFsCount=" + _allowedVDFsCount + ", allowedVMsCount=" + _allowedVMsCount + ", allowedVRSGsCount=" + _allowedVRSGsCount + ", allowedVRSsCount=" + _allowedVRSsCount + ", city=" + _city + ", company=" + _company + ", country=" + _country + ", customerKey=" + _customerKey + ", email=" + _email + ", encryptionMode=" + _encryptionMode + ", entityScope=" + _entityScope + ", expirationDate=" + _expirationDate + ", expiryTimestamp=" + _expiryTimestamp + ", externalID=" + _externalID + ", isClusterLicense=" + _isClusterLicense + ", lastUpdatedBy=" + _lastUpdatedBy + ", license=" + _license + ", licenseEncryption=" + _licenseEncryption + ", licenseEntities=" + _licenseEntities + ", licenseID=" + _licenseID + ", licenseType=" + _licenseType + ", licensedFeature=" + _licensedFeature + ", majorRelease=" + _majorRelease + ", minorRelease=" + _minorRelease + ", phone=" + _phone + ", productVersion=" + _productVersion + ", provider=" + _provider + ", requestID=" + _requestID + ", state=" + _state + ", street=" + _street + ", system=" + _system + ", uniqueLicenseIdentifier=" + _uniqueLicenseIdentifier + ", userName=" + _userName + ", zip=" + _zip + ", id=" + NUId + ", parentId=" + NUParentId + ", parentType=" + NUParentType + ", creationDate=" + NUCreationDate + ", lastUpdatedDate="
              + NULastUpdatedDate + ", owner=" + NUOwner  + "]";
   }
   
   

   public static String getResourceName()
   {
	return "licenses";
   }

   public static String getRestName()
   {
	return "license";
   }
}
}