namespace WebAPIapplication.Model
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// this is an interface for dbAPITestContext class.
    /// </summary>
    public interface IDbAPITestContext
    {
        /// <summary>
        /// Gets or sets Tbl_User_Massages table.
        /// </summary>
        DbSet<Tbl_User_Massage> Tbl_User_Massages { get; set; }

        /// <summary>
        /// Gets or sets TblLogins table.
        /// </summary>
        DbSet<TblLogin> TblLogins { get; set; }
    }
}