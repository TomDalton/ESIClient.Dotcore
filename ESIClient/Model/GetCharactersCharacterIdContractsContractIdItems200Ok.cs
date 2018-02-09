/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.7.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ESIClient.Client.SwaggerDateConverter;

namespace ESIClient.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdContractsContractIdItems200Ok :  IEquatable<GetCharactersCharacterIdContractsContractIdItems200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdContractsContractIdItems200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdContractsContractIdItems200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdContractsContractIdItems200Ok" /> class.
        /// </summary>
        /// <param name="recordId">Unique ID for the item (required).</param>
        /// <param name="typeId">Type ID for item (required).</param>
        /// <param name="quantity">Number of items in the stack (required).</param>
        /// <param name="rawQuantity">-1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy.</param>
        /// <param name="isSingleton">is_singleton boolean (required).</param>
        /// <param name="isIncluded">true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract. (required).</param>
        public GetCharactersCharacterIdContractsContractIdItems200Ok(long? recordId = default(long?), int? typeId = default(int?), int? quantity = default(int?), int? rawQuantity = default(int?), bool? isSingleton = default(bool?), bool? isIncluded = default(bool?))
        {
            // to ensure "recordId" is required (not null)
            if (recordId == null)
            {
                throw new InvalidDataException("recordId is a required property for GetCharactersCharacterIdContractsContractIdItems200Ok and cannot be null");
            }
            else
            {
                this.RecordId = recordId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCharactersCharacterIdContractsContractIdItems200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for GetCharactersCharacterIdContractsContractIdItems200Ok and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "isSingleton" is required (not null)
            if (isSingleton == null)
            {
                throw new InvalidDataException("isSingleton is a required property for GetCharactersCharacterIdContractsContractIdItems200Ok and cannot be null");
            }
            else
            {
                this.IsSingleton = isSingleton;
            }
            // to ensure "isIncluded" is required (not null)
            if (isIncluded == null)
            {
                throw new InvalidDataException("isIncluded is a required property for GetCharactersCharacterIdContractsContractIdItems200Ok and cannot be null");
            }
            else
            {
                this.IsIncluded = isIncluded;
            }
            this.RawQuantity = rawQuantity;
        }
        
        /// <summary>
        /// Unique ID for the item
        /// </summary>
        /// <value>Unique ID for the item</value>
        [DataMember(Name="record_id", EmitDefaultValue=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// Type ID for item
        /// </summary>
        /// <value>Type ID for item</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Number of items in the stack
        /// </summary>
        /// <value>Number of items in the stack</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// -1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy
        /// </summary>
        /// <value>-1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy</value>
        [DataMember(Name="raw_quantity", EmitDefaultValue=false)]
        public int? RawQuantity { get; set; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>
        /// <value>is_singleton boolean</value>
        [DataMember(Name="is_singleton", EmitDefaultValue=false)]
        public bool? IsSingleton { get; set; }

        /// <summary>
        /// true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract.
        /// </summary>
        /// <value>true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract.</value>
        [DataMember(Name="is_included", EmitDefaultValue=false)]
        public bool? IsIncluded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdContractsContractIdItems200Ok {\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RawQuantity: ").Append(RawQuantity).Append("\n");
            sb.Append("  IsSingleton: ").Append(IsSingleton).Append("\n");
            sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdContractsContractIdItems200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdContractsContractIdItems200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdContractsContractIdItems200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdContractsContractIdItems200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.RawQuantity == input.RawQuantity ||
                    (this.RawQuantity != null &&
                    this.RawQuantity.Equals(input.RawQuantity))
                ) && 
                (
                    this.IsSingleton == input.IsSingleton ||
                    (this.IsSingleton != null &&
                    this.IsSingleton.Equals(input.IsSingleton))
                ) && 
                (
                    this.IsIncluded == input.IsIncluded ||
                    (this.IsIncluded != null &&
                    this.IsIncluded.Equals(input.IsIncluded))
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
                if (this.RecordId != null)
                    hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.RawQuantity != null)
                    hashCode = hashCode * 59 + this.RawQuantity.GetHashCode();
                if (this.IsSingleton != null)
                    hashCode = hashCode * 59 + this.IsSingleton.GetHashCode();
                if (this.IsIncluded != null)
                    hashCode = hashCode * 59 + this.IsIncluded.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
