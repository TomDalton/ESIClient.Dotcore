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
    /// wallet transaction
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdWalletTransactions200Ok :  IEquatable<GetCharactersCharacterIdWalletTransactions200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdWalletTransactions200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdWalletTransactions200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdWalletTransactions200Ok" /> class.
        /// </summary>
        /// <param name="clientId">client_id integer (required).</param>
        /// <param name="date">Date and time of transaction (required).</param>
        /// <param name="isBuy">is_buy boolean (required).</param>
        /// <param name="isPersonal">is_personal boolean (required).</param>
        /// <param name="journalRefId">journal_ref_id integer (required).</param>
        /// <param name="locationId">location_id integer (required).</param>
        /// <param name="quantity">quantity integer (required).</param>
        /// <param name="transactionId">Unique transaction ID (required).</param>
        /// <param name="typeId">type_id integer (required).</param>
        /// <param name="unitPrice">Amount paid per unit (required).</param>
        public GetCharactersCharacterIdWalletTransactions200Ok(int? clientId = default(int?), DateTime? date = default(DateTime?), bool? isBuy = default(bool?), bool? isPersonal = default(bool?), long? journalRefId = default(long?), long? locationId = default(long?), int? quantity = default(int?), long? transactionId = default(long?), int? typeId = default(int?), double? unitPrice = default(double?))
        {
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new InvalidDataException("clientId is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.ClientId = clientId;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "isBuy" is required (not null)
            if (isBuy == null)
            {
                throw new InvalidDataException("isBuy is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.IsBuy = isBuy;
            }
            // to ensure "isPersonal" is required (not null)
            if (isPersonal == null)
            {
                throw new InvalidDataException("isPersonal is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.IsPersonal = isPersonal;
            }
            // to ensure "journalRefId" is required (not null)
            if (journalRefId == null)
            {
                throw new InvalidDataException("journalRefId is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.JournalRefId = journalRefId;
            }
            // to ensure "locationId" is required (not null)
            if (locationId == null)
            {
                throw new InvalidDataException("locationId is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.LocationId = locationId;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new InvalidDataException("transactionId is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.TransactionId = transactionId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
            // to ensure "unitPrice" is required (not null)
            if (unitPrice == null)
            {
                throw new InvalidDataException("unitPrice is a required property for GetCharactersCharacterIdWalletTransactions200Ok and cannot be null");
            }
            else
            {
                this.UnitPrice = unitPrice;
            }
        }
        
        /// <summary>
        /// client_id integer
        /// </summary>
        /// <value>client_id integer</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public int? ClientId { get; set; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>
        /// <value>Date and time of transaction</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// is_buy boolean
        /// </summary>
        /// <value>is_buy boolean</value>
        [DataMember(Name="is_buy", EmitDefaultValue=false)]
        public bool? IsBuy { get; set; }

        /// <summary>
        /// is_personal boolean
        /// </summary>
        /// <value>is_personal boolean</value>
        [DataMember(Name="is_personal", EmitDefaultValue=false)]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// journal_ref_id integer
        /// </summary>
        /// <value>journal_ref_id integer</value>
        [DataMember(Name="journal_ref_id", EmitDefaultValue=false)]
        public long? JournalRefId { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        /// <value>location_id integer</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public long? LocationId { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        /// <value>quantity integer</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Unique transaction ID
        /// </summary>
        /// <value>Unique transaction ID</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public long? TransactionId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Amount paid per unit
        /// </summary>
        /// <value>Amount paid per unit</value>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdWalletTransactions200Ok {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  IsBuy: ").Append(IsBuy).Append("\n");
            sb.Append("  IsPersonal: ").Append(IsPersonal).Append("\n");
            sb.Append("  JournalRefId: ").Append(JournalRefId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdWalletTransactions200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdWalletTransactions200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdWalletTransactions200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdWalletTransactions200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.IsBuy == input.IsBuy ||
                    (this.IsBuy != null &&
                    this.IsBuy.Equals(input.IsBuy))
                ) && 
                (
                    this.IsPersonal == input.IsPersonal ||
                    (this.IsPersonal != null &&
                    this.IsPersonal.Equals(input.IsPersonal))
                ) && 
                (
                    this.JournalRefId == input.JournalRefId ||
                    (this.JournalRefId != null &&
                    this.JournalRefId.Equals(input.JournalRefId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.IsBuy != null)
                    hashCode = hashCode * 59 + this.IsBuy.GetHashCode();
                if (this.IsPersonal != null)
                    hashCode = hashCode * 59 + this.IsPersonal.GetHashCode();
                if (this.JournalRefId != null)
                    hashCode = hashCode * 59 + this.JournalRefId.GetHashCode();
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                return hashCode;
            }
        }
    }

}