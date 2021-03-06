/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ESIClient.Dotcore.Client.SwaggerDateConverter;

namespace ESIClient.Dotcore.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdShareholders200Ok :  IEquatable<GetCorporationsCorporationIdShareholders200Ok>
    {
        /// <summary>
        /// shareholder_type string
        /// </summary>
        /// <value>shareholder_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShareholderTypeEnum
        {
            
            /// <summary>
            /// Enum Character for value: character
            /// </summary>
            [EnumMember(Value = "character")]
            Character = 1,
            
            /// <summary>
            /// Enum Corporation for value: corporation
            /// </summary>
            [EnumMember(Value = "corporation")]
            Corporation = 2
        }

        /// <summary>
        /// shareholder_type string
        /// </summary>
        /// <value>shareholder_type string</value>
        [DataMember(Name="shareholder_type", EmitDefaultValue=false)]
        public ShareholderTypeEnum ShareholderType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdShareholders200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdShareholders200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdShareholders200Ok" /> class.
        /// </summary>
        /// <param name="shareCount">share_count integer (required).</param>
        /// <param name="shareholderId">shareholder_id integer (required).</param>
        /// <param name="shareholderType">shareholder_type string (required).</param>
        public GetCorporationsCorporationIdShareholders200Ok(long? shareCount = default(long?), int? shareholderId = default(int?), ShareholderTypeEnum shareholderType = default(ShareholderTypeEnum))
        {
            // to ensure "shareCount" is required (not null)
            if (shareCount == null)
            {
                throw new InvalidDataException("shareCount is a required property for GetCorporationsCorporationIdShareholders200Ok and cannot be null");
            }
            else
            {
                this.ShareCount = shareCount;
            }
            // to ensure "shareholderId" is required (not null)
            if (shareholderId == null)
            {
                throw new InvalidDataException("shareholderId is a required property for GetCorporationsCorporationIdShareholders200Ok and cannot be null");
            }
            else
            {
                this.ShareholderId = shareholderId;
            }
            // to ensure "shareholderType" is required (not null)
            if (shareholderType == null)
            {
                throw new InvalidDataException("shareholderType is a required property for GetCorporationsCorporationIdShareholders200Ok and cannot be null");
            }
            else
            {
                this.ShareholderType = shareholderType;
            }
        }
        
        /// <summary>
        /// share_count integer
        /// </summary>
        /// <value>share_count integer</value>
        [DataMember(Name="share_count", EmitDefaultValue=false)]
        public long? ShareCount { get; set; }

        /// <summary>
        /// shareholder_id integer
        /// </summary>
        /// <value>shareholder_id integer</value>
        [DataMember(Name="shareholder_id", EmitDefaultValue=false)]
        public int? ShareholderId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdShareholders200Ok {\n");
            sb.Append("  ShareCount: ").Append(ShareCount).Append("\n");
            sb.Append("  ShareholderId: ").Append(ShareholderId).Append("\n");
            sb.Append("  ShareholderType: ").Append(ShareholderType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCorporationsCorporationIdShareholders200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdShareholders200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdShareholders200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdShareholders200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShareCount == input.ShareCount ||
                    (this.ShareCount != null &&
                    this.ShareCount.Equals(input.ShareCount))
                ) && 
                (
                    this.ShareholderId == input.ShareholderId ||
                    (this.ShareholderId != null &&
                    this.ShareholderId.Equals(input.ShareholderId))
                ) && 
                (
                    this.ShareholderType == input.ShareholderType ||
                    (this.ShareholderType != null &&
                    this.ShareholderType.Equals(input.ShareholderType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ShareCount != null)
                    hashCode = hashCode * 59 + this.ShareCount.GetHashCode();
                if (this.ShareholderId != null)
                    hashCode = hashCode * 59 + this.ShareholderId.GetHashCode();
                if (this.ShareholderType != null)
                    hashCode = hashCode * 59 + this.ShareholderType.GetHashCode();
                return hashCode;
            }
        }
    }

}
