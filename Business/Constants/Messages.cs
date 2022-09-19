using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "Maintenace time";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category.";
        public static string ProductNameAlreadyExists = "There is already another product with this name.";
        public static string CategoryLimitExceded = "Category limit exceded";
        public static string AuthorizationDenied = "You don't have authorized ";
        public static string UserAdded = "User added";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists= "User already exists";
        public static string AccessTokenCreated= "Access token created";
    }
}
