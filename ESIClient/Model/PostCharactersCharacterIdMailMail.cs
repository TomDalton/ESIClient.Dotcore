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
    /// mail object
    /// </summary>
    [DataContract]
    public partial class PostCharactersCharacterIdMailMail :  IEquatable<PostCharactersCharacterIdMailMail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdMailMail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostCharactersCharacterIdMailMail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdMailMail" /> class.
        /// </summary>
        /// <param name="recipients">recipients array (required).</param>
        /// <param name="subject">subject string (required).</param>
        /// <param name="body">body string (required).</param>
        /// <param name="approvedCost">approved_cost integer (default to 0).</param>
        public PostCharactersCharacterIdMailMail(List<PostCharactersCharacterIdMailRecipient> recipients = default(List<PostCharactersCharacterIdMailRecipient>), string subject = default(string), string body = default(string), long? approvedCost = 0)
        {
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new InvalidDataException("recipients is a required property for PostCharactersCharacterIdMailMail and cannot be null");
            }
            else
            {
                this.Recipients = recipients;
            }
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for PostCharactersCharacterIdMailMail and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for PostCharactersCharacterIdMailMail and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            // use default value if no "approvedCost" provided
            if (approvedCost == null)
            {
                this.ApprovedCost = 0;
            }
            else
            {
                this.ApprovedCost = approvedCost;
            }
        }
        
        /// <summary>
        /// recipients array
        /// </summary>
        /// <value>recipients array</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<PostCharactersCharacterIdMailRecipient> Recipients { get; set; }

        /// <summary>
        /// subject string
        /// </summary>
        /// <value>subject string</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// body string
        /// </summary>
        /// <value>body string</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// approved_cost integer
        /// </summary>
        /// <value>approved_cost integer</value>
        [DataMember(Name="approved_cost", EmitDefaultValue=false)]
        public long? ApprovedCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCharactersCharacterIdMailMail {\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ApprovedCost: ").Append(ApprovedCost).Append("\n");
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
            return this.Equals(input as PostCharactersCharacterIdMailMail);
        }

        /// <summary>
        /// Returns true if PostCharactersCharacterIdMailMail instances are equal
        /// </summary>
        /// <param name="input">Instance of PostCharactersCharacterIdMailMail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCharactersCharacterIdMailMail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.ApprovedCost == input.ApprovedCost ||
                    (this.ApprovedCost != null &&
                    this.ApprovedCost.Equals(input.ApprovedCost))
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
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.ApprovedCost != null)
                    hashCode = hashCode * 59 + this.ApprovedCost.GetHashCode();
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
            // Subject (string) maxLength
            if(this.Subject != null && this.Subject.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subject, length must be less than 1000.", new [] { "Subject" });
            }

            // Body (string) maxLength
            if(this.Body != null && this.Body.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Body, length must be less than 10000.", new [] { "Body" });
            }

            yield break;
        }
    }

}
