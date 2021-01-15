#nullable disable

namespace WebAPIapplication.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this class holds the data from TblLogin table in the database.
    /// </summary>
    public partial class TblLogin
    {
        /// <summary>
        /// Gets or sets the id of the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the UserName of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Password of the user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Messages of the user.
        /// </summary>
        public string Messages { get; set; }
    }
}
