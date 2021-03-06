// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covi.Client.Services.Platform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UserState
    {
        /// <summary>
        /// Initializes a new instance of the UserState class.
        /// </summary>
        public UserState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserState class.
        /// </summary>
        public UserState(int? statusId = default(int?), System.DateTime? statusChangedOn = default(System.DateTime?), string username = default(string), IList<string> roles = default(IList<string>))
        {
            StatusId = statusId;
            StatusChangedOn = statusChangedOn;
            Username = username;
            Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusId")]
        public int? StatusId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusChangedOn")]
        public System.DateTime? StatusChangedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

    }
}
