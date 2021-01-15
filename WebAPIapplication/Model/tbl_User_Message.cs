namespace WebAPIapplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// this class holds the data from Tbl_User_Massage table in the database.
    /// </summary>
    public partial class Tbl_User_Massage
    {
        /// <summary>
        /// Gets or sets the id of the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the DateOfBirth of the user.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the Subject of the user.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the Messages of the user.
        /// </summary>
        public string Messages { get; set; }

        /// <summary>
        /// Gets or sets the Userid of the user.
        /// </summary>
        public int Userid { get; set; }
    }
}
