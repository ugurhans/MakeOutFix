using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrate;

namespace Business.Constants
{
    public class Messages
    {
        public static string DayAdded = "Day Added";

        public static string AuthorizationDenied = "Yetki Yok";

        public static string ClaimAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; set; }
        public static string SuccessfulLogin { get; set; }
        public static string UserAlreadyExists { get; set; }
        public static string UserNotFound { get; set; }
        public static string UserRegistered { get; set; }
        public static string PasswordError { get; set; }
    }
}
