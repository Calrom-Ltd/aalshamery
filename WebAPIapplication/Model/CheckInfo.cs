namespace WebAPIapplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// this class hold the properties we need from Tbl_user_message.
    /// </summary>
    public class CheckInfo
    {
        /// <summary>
        /// Gets or sets the date of birth of the user.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the subject of the message.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the messages of the user.
        /// </summary>
        public string Messages { get; set; }
    }
}
