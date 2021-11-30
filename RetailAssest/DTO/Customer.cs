using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RetailAssest
{
    [Description("Model for managing customer data")]
    public class Customer
    {

        /// <summary>
        /// Type of Applicant
        /// </summary>
        /// <example>
        /// 630AA8D0-D153-49E0-BA04-2B8A6E797648
        /// </example>
        public string RequestId { get; set; }
        /// <summary> 
        /// Type of Applicant :  Entity / Individual
        /// </summary>
        /// <example>
        /// Entity
        /// </example>
        public string ApplicantType { get; set; }
        /// <summary>
        /// Income type : Salaried / Self Employee
        /// </summary>
        /// <example>
        /// Salaried
        /// </example>
        public string IncomeType { get; set; }
        /// <summary>
        /// Resident Status : Resident India / NRI
        /// </summary>
        /// <example>
        /// Resident India
        /// </example>
        public string ResidentStatus { get; set; }
        /// <summary>
        /// Gender : Male / Female
        /// </summary>
        /// <example>
        /// Male
        /// </example>
        public string Gender { get; set; }
        /// <summary>
        /// First name of the Applicant
        /// </summary>
        /// <example>
        /// Sachin
        /// </example>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of Applicant
        /// </summary>
        /// <example>
        /// Jain
        /// </example>
        public string LastName { get; set; }
        /// <summary>
        /// Email ID of Applicant
        /// </summary>
        /// <example>
        /// xxxxxxxxx@gmail.com
        /// </example>
        public string EmailId { get; set; }
        /// <summary>
        /// Applicant mobile number
        /// </summary>
        /// <example>
        /// 9999999999
        /// </example>
        public string MobileNumber { get; set; }
        /// <summary>
        /// Alternate mobile number, not mandetory
        /// </summary>
        public string AlternateMobileNumber { get; set; }
        /// <summary>
        /// Acceptance flag for TnC
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public byte IsTncAgree { get; set; }
        /// <summary>
        /// Status of the Request : 
        /// FollowUp
        /// Pending for Docs
        /// Credit Reject
        /// RCU Reject
        /// Negative Area
        /// SanctionLost
        /// DuplicatePANCard
        /// Sanctioned
        /// </summary>
        /// <example>
        /// FollowUp
        /// </example>
        public string Status { get; set; }
        /// <summary>
        /// Date of Lead Request Creation
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// Source of Lead Request Creation
        /// </summary>
        public string CreatedBy { get; set; }

    }


    public static class ResponseMessage
    {
        public static readonly string DataSaved = "Record(s) inserted successfully";
        public static readonly string DataDeleted = "Record(s) deleted successfully";
        public static readonly string DataDeactivated = "Record(s) deactivated successfully";
        public static readonly string DataUpdated = "Record(s) updated successfully";
        public static readonly string DataExist = "Record(s) already exists";
        public static readonly string NoData = "No record(s) found";
        public static readonly string InternalServerError = "Internal server error. Please contact administrator";
        public static readonly string MandatoryData = "Required data not found  : ";

   
        public static readonly string InsertErrorMessage = "Error while processing record(s)";
        public static readonly string DeleteErrorMessage = "Error while deactivating record(s)";
        public static readonly string UploadFailed = "Upload failed. Please check the data";
    

    }
}
