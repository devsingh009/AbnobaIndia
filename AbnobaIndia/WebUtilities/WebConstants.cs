using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AbnobaIndia.Utilities
{
    public class WebConstants
    {

        public struct GeneralMessage
        {
            public const string SAVED_SUCCESSFULL = "Data Saved successfully";
            public const string UPDATED_SUCCESSFULL = "Data Update successfully";
            public const string DELETE_SUCCESSFULL = "Data Delete successfully";
            public const string ALREADY_EXISTS = "Your EmailId or MobileNo Already Exists";
            public const string INVALID_EMAILID_PASSWORD = "Invalid EmailId or Password";
            public const string INVALID_PASSWORD = "Invalid Password";
            public const string YOUR_ACCOUNT_INACTIVE = "Your A/c is inactive";
            public const string YOU_ARE_ALREADY_REGISTERED = "You are already registered. Please log in.";
            public const string USER_REGISTRATION = "Registration completed successfully!.";
            public const string USER_REGISTRATION_FAILED = "Registration failed!try again.";
            public const string OTPMESSAGE = "OTP sent to your Mobile No!";
            public const string INVALID_OTP = "Invalid OTP!";
            public const string INVALID_EMAILID_MOBILENO = "Invalid EmailId or Mobile No.";
            public const string INVALID_LOGIN = "Entered credentials are invalid. Please enter correct credentials.";
            public const string NOT_RIGISTERED_USER = "You are not registered user.Please do Sign-Up.";
            public const string MOBILE_NUMBER_NOT_REGISTERED = "Mobile number is not registered";
            public const string INVALID_USERID = "Invalid userID";
            public const string SOMETHING_WRONG = "!!Oops something went wrong!";
            public const string SAVE_LIMIT = "Your data saved limit has exceed.";
            public const string YOUR_CHANGES_SUCCESSFULLY = "Changes have been saved successfully.";
            public const string COMBINATION_NOT_EXIST = "Selected brand & category combination does not exists";
            public const string DUPLICATE_PRODUCT_ATTRIBUTE = "This product attributes already exist";
            public const string DUPLICATE_RECORD_CATEGORY = " Entered category name already exist";
            public const string DUPLICATE_RECORD_BRAND = "Entered brand name already exists";
            public const string DUPLICATE_RECORD_MODEL = "Entered Model name already exists";
            public const string DUPLICATE_RECORD_City = "Entered city name already exists";
            public const string DUPLICATE_RECORD_HOME_THUMB_BANNER = "This page type already exists";
            public const string DUPLICATE_RECORD_THUMB_BANNER = "This page type already exists";
            public const string FILES_SAVED = "File saved successfully";
            public const string OUT_OF_STOCK = "This item is Out Of Stock";
            public const string PRODUCT_ADDED = "This item is already added in Cart";
            public const string WHISH_ADDED = "This item is already added in wishlist";
            public const string PRODUCT_ADDED_IN_CARTLIST = "Item(s) added in cart successfully";
            public const string PRODUCT_ADDED_IN_WHISHLIST = "Item(s) added in wishlist successfully";
            public const string REQUIRED_QUANTITY_NOT_AVAILABLE_IN_STOCK = "Required quantity not available in stock";
            public const string YOUR_PASSWORD_CHANGE = "Your password changed successfully.";
            public const string YOUR_PASSWORD_Not_CHANGE = "Your password not changed.";
            public const string YOUR_MOBILE_NUMBER = "This mobile number exists ";
            public const string OLD_PASSWORD = "Old password is incorrect.";
            public const string SUCCESS_MESSAGE = "Success";
            public const string PROCEED_PAYMENT = "Order generated sucessfully, order status is pending";
            public const string OTP_SENT_SUCCESS = "OTP sent to your number successfully, please validate";
            public const string THUMB_BANNER = "Thumb banner image not blank.";
            public const string REMARKS = "Please enter remarks then submit";
            public const string ALL_FIELDS_MANDATORY = "all fields are mandatory";
            public const string NOT_LOGIN = "Your are not login";
            public const string YOUR_NOTIFYME = "Your will be notify by email when item will be instock";
            public const string NOTIFYME_ADDED = "This item sku is already added in Notifyme";
            public const string YOUR_ITEM_CANCELLED = "Your sellected item have been cancel now";
            public const string YOUR_CAN_NOT_CANCEL = "Your can't cancel order";
            //Following items added pawan roopwal starts here
            public const string ITEM_ADDED_REPAIR = "Item added successfully";
            public const string ITEM_EXCLUDED_REPAIR = "Item excluded successfully";
            public const string LINK_SEND_SUCCESS = "Link sent successfully";
            //Items added by pawan roopwal ends here
            public const string REMOVE_SUCCESSFULL = "Item Remove successfully";
            public const string ADDED_ITEM_SKU = "Added item in your cart is out of stock.Please select different item.";
            /*Item added by pawan roopwal on 05-Aug-2017 starts here*/
            public const string REVIEWS_ADD_SUCCESS = "Reviews submitted successfully";
            /*Item added by pawan roopwal on 05-Aug-2017 ends here*/
            public const string DUPLICATE_LOOKUP_CODE = "This Lookup code already exist";
            // public const string DUPLICATE_PRODUCT_VIDEO = "This Video url already exist";
            public const string DUPLICATE_PRODUCT_VIDEO = "This Category and brand is already exist in our database and only you can edit/update";//naren4jan
            public const string INVALID_ROLE_MESSAGE = "No role has assigned for this user";
            public const string FEEDBACK_MESSAGE = "Thanks for contact with us.! will get back soon.";
            public const string ONLINEFORM_MESSAGE = "Your profile has been submitted successfully! Our recruitment team will get back to you soon.";//naren24jan2018
            public const string IMEI_NUMBER = "This imei number is already added ";
            //#region[city name api url, created by pawan roopwal on 07-Sep-2017]
            //public const string cGetCountryNameserviceURL = ConfigurationManager.AppSettings["CityNameApi"].ToString(); 
            //#endregion
            #region[Default rate and review status values, pawan roopwal, 30-Oct-2017]
            public const int STATUS_VALUE = 2;
            public const string STATUS_TEXT = "Pending";
            #endregion

            #region[Default address set message, pawan roopwal, 30-Oct-2017]
            public const string SET_DEFAULT_ADDRESS = "Default address set successfully";
            #endregion

            public const string DELETE_SUCCESS = "Data deleted successfully";
            public const string DEFAULT_ADDRESS = "Default Address Succefully Set";
            public const string FALIEDSET_DEFAULT_ADDRESS = "Default Address Not Set";
            public const string NO_RECORD_FOUND = "No Record Found";


            /*setting a new variable to hold value for url to get city, state and locality info based on pincode, pawan roopwal 23-Aug-2018*/
            public const string ADDRESS_INFO_URL_PINCODE_WISE = "http://helpdesk.gadgetwood.com/ready.asmx/FetchStateCityLocality?Pincode=";
            /*setting a new variable to hold value for url to get city, state and locality info based on pincode, pawan roopwal 23-Aug-2018, ends here*/

            /*Mobile app redirection work, pawan roopwal, 30-aug-2018*/

            public const string DEVICE_TYPE_CHECK = @"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino";
            public const string MOBILE_VERSION_CHECK = @"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-";

            public const string ANDROID_SCHEME_NAME = "yaantraportal://";
            public const string IOS_SCHEME_NAME = "YaantraOnline://";

            /*Mobile app redirection work, pawan roopwal, 30-aug-2018, ends here*/


            public const string EXIT_CONTENT_STR = "exit intent";
            public const string POPUP_CONTENT_STR = "popup banner";

            /*code added for referral module work, pawan roopwal, 02-Nov-2018*/
            public const string COUPON_FOR_REFEREDTO = "ReferedTo";
            public const string COUPON_FOR_REFEREDBY = "ReferedBy";
            public const string UPDATE_ISSENTTOREFERED = "Update IsSentToRefered";
            public const string UPDATE_REFEREDAVAILED_AND_REFEREDBYCOUPONDETAILS = "Update ReferedToAvailed And ReferedByCouponDetails";
            public const string UPDATE_REFEREDBYAVAILEDETAILS = "Update ReferedByAvailedDetails";
            public const string COUPON_REFEREDTO_EMAIL_HTML = "Dear ReferedToName,<br/><br/>Your friend just referred you to visit Product_Name on Yaantra.com. We have a unique coupon for you, use code ReferedCouponCode to avail extra discount on your 1st order.<br/><br/>Happy Shopping!!<br/><br/>Team Yaantra.";
            //public const string COUPON_REFEREDTO_EMAIL_HTML = "<h3>Hi ReferedToName</h3><br/> You have been refered by your friend ReferedByName to Yaantra.com, use ReferedCouponCode for purchase at Yaantra.com and get big discount.";
            public const string REFERRAL_MAIL_SUBJECT = "Discount coupon from yaantra.com";
            //public const string REFEREDTO_SMS_CONTENT = "http://api-alerts.solutionsinfini.com/v3/?method=sms&api_key=A65d015f63167c8685717dcf081d179c2&to=ReferredToMobileNo&sender=YANTRA&message=Hi ReferedToName you have been by your friend ReferedByName to Yaantra.com, use ReferedCouponCode for purchase at Yaantra.com and get big discount.";
            public const string REFEREDTO_SMS_CONTENT = "http://api-alerts.solutionsinfini.com/v3/?method=sms&api_key=A65d015f63167c8685717dcf081d179c2&to=ReferredToMobileNo&sender=YANTRA&message=Hi ReferedToName Your order has been placed with Yaantra. Order Id: ReferedCouponCode. You will receive a confirmation call within 24hrs from 011-60012600. Thank you for choosing Yaantra!";
            //Hi " + this.CurrentSession.FirstName + " Your order has been placed with Yaantra. Order Id: " + this.CurrentSession.OrderNo + ". You will receive a confirmation call within 24hrs from 011-60012600. Thank you for choosing Yaantra!
            public const string GENERAL_ADDRESSING_TERM = "Customer";
            public const string SMS_SENDING_CONFIRMATION = "Campaign of 1 numbers Submitted successfully";
            public const string COUPON_REFEREDBY_EMAIL_HTML = "<h3>Hi ReferedByName</h3><br/> You got a discount coupon ReferedCouponCode under referral scheme at yaantra.com . Happy shopping";
            //public const string REFEREDBY_SMS_CONTENT = "http://api-alerts.solutionsinfini.com/v3/?method=sms&api_key=A65d015f63167c8685717dcf081d179c2&to=ReferredByMobileNo&sender=YANTRA&message=Hi ReferedByName You got a discount coupon ReferedCouponCode under referral scheme at yaantra.com Happy shopping";
            public const string REFEREDBY_SMS_CONTENT = "http://api-alerts.solutionsinfini.com/v3/?method=sms&api_key=A65d015f63167c8685717dcf081d179c2&to=ReferredByMobileNo&sender=YANTRA&message=Hi ReferedByName Your order has been placed with Yaantra. Order Id: ReferedCouponCode. You will receive a confirmation call within 24hrs from 011-60012600. Thank you for choosing Yaantra!";
            public const string REFERRED_SUCCESSFULLY_MESSAGE = "Referred successfully";
            /*code added for referral module work, pawan roopwal, 02-Nov-2018 ends here*/
        }

        public struct HomePageItems
        {

            public const string TOP_SELLING = "TOP SELLING";
            public const string REFURBISHED_MOBILES = "REFURBISHED MOBILES";
            public const string UNBOXED_MOBILES = "UNBOXED MOBILES";
            public const string PREOWNED_MOBILES = "PREOWNED MOBILES";
            public const string TODAY = "TODAY'S";
            public const string DEALS = "DEALS";
            public const string NOIMAGE = "noimage.png";
            public const string BROWSEBYBRANDS = "Browse By Brands: ";
        }

        public struct CommonMessage
        {

            public const string SUCCESSFULLY_UPDATE = "Record Updated Successfully";
            public const string SUCCESSFULLY_SAVE = "Record Saved Successfully";
            public const string SUCCESSFULLY_INACTIVE = "Selected Record Is Inactive Now";
            public const string SUCCESSFULLY_Activate = "Selected Record Is Active Now";
            public const string SUCCESSFULLYUPLOADIMAGE = "Image Uploaded Successfully";
            public const string SUCCESSFULLYUPLOADRESUME = "Resume Uploaded Successfully";//naren23jan18
            public const string SUCCESSFULLY_PASSWORDCHANGE = "Your password changed successfully.";
            public const string INCORRET_PASSWORD = "Old password is incorret!";
            public const string DELETERECORD = "Record Deleted Successfully";
        }

        public struct ImagePath
        {
            public const string MOBILEBANNERIMAGEPATH = "/ItemImages/Banner/MobileBanner/";
            public const string BANNERIMAGEPATH = "/ItemImages/Banner/Large/";
            public const string LPIMAGEPATH = "/ItemImages/Banner/LandingPagesBanner/";
            public const string THUMBBANNERPATH = "/ItemImages/Banner/Thumb/";
            public const string CATEGORYIMAGEPATH = "/ItemImages/Category/";
            public const string MODELIMAGEPATH = "/ItemImages/Model/";
            public const string BRANDIMAGEPATH = "/ItemImages/Brand/";
            public const string TEMPIMAGEPATH = "/ItemImages/Catalog/Products/Pictures/";
            public const string TEMPRESUMEIMAGEPATH = "/ItemImages/Catalog/Products/Pictures/";//NAREN05FEB2018
            public const string ResumePath = "/ItemImages/Resumes/";//naren24jan18v1

            public const string DESKTOPIMAGEPATH = "/Images/LandingPagesImage/desktop-banner/";
            public const string MOBILEIMAGEPATH = "/Images/LandingPagesImage/mobile-banner/";
            /*Defining new image paths for showing image for selected model in repair module, pawan roopwal, 08-March-2018*/
            public const string MODELIMAGEPATH_SMALL = "/ItemImages/Catalog/Products/Small/";
            public const string MODELIMAGEPATH_THUMBNAIL = "/ItemImages/Catalog/Products/ThumbNail/";
            /*Defining new image paths for showing image for selected model in repair module, pawan roopwal, 08-March-2018 end*/

            public const string CATALOGIMAGEPATH = "/ItemImages/Catalog/";
            public const string PROFILEPHOTO = "/ItemImages/ProfilePhoto/";
            public const string MOBILEHOMEBANNER = "/ItemImages/Banner/MobileBanner/";
            public const string INVOICE = "/ItemImages/Invoice/";
            public const string FREQUENTLY = "/ItemImages/Catalog/Products/Small/";

        }

        public struct FailedMessage
        {
            public const string FAILEDTOUPLOADFILE = "Failed to upload file";
            // changes made by pawan roopwal
            public const string FAILED_TO_SAVE_CHANGES = "Failed to save changes, please try again";
            public const string DUPLICATE_RECORD = "Group name already exists, please try other group name";

            public const string FAILED_TO_SAVE_NEWDATA = "Failed to submit data, please try again";
            public const string FAILED_SUBMIT = "Failed to submit data";
            public const string UPDATE_FAIL = "Failed to update data please try again";
            public const string DUPLICATE_FOUND = "Duplicate record found, please try again";
            public const string CHECK_DUPLICATE = "Duplicate record found, please change the matrix";
            public const string NOFILE = "No file Selected";
            public const string DEPENDANCY_FOUND = "Can't inactive. Reference id existing in another table.";
            public const string ADD_CART_FAILED = "Failed to add items to cart";
            public const string FAILURE_MESSAGE = "Failure";
            public const string FAILED_PROCEED_PAYMENT = "Failed to proceed for payment, please try again";
            public const string FAILED_COMPLETE_ORDER = "Failed to complete the order, please try again";
            public const string ERROR_PROCEED_PAYMENT = "Encountered error to proceed for payment, please try again";
            public const string OTP_SENT_FAILED = "Unable to send OTP, please try again";
            public const string FAILED_ADDED_ITEM_REPAIR = "Failed to add item";
            public const string FAILED_EXCLUD_ITEM_REPAIR = "Failed to exclude item";
            public const string LINK_SEND_FAILED = "Server is not availabe to send the link please try again later";
            // changes made by pawan roopwal ends here

            /*Item added by pawan roopwal on 05-Aug-2017 starts here*/
            public const string DUPLICATE_REVIEWS = "You have already rated this product with current ratings";
            /*Item added by pawan roopwal on 05-Aug-2017 ends here*/

            #region[Enum for failed rate and review submit operation, pawan roopwal, date = 16-Oct-2017]
            public const string FAILED_SUBMIT_RATE_AND_REVIEWS = "Failed to submit reviews, please try again";
            #endregion


            #region[Default address set message, pawan roopwal, 30-Oct-2017]
            public const string SET_DEFAULT_ADDRESS_FAIL = "Failed to set default address please try again";
            #endregion


            public const string DATA_DELETE_FAILED = "Failed to delete record please try again";


            public const string MOBILE_NO_EXISTS = "Mobile no. already exists";

            public const string EMAIL_ID_EXISTS = "Email id already exists";
            public const string CANNOT_REFER_ITSELF = "You can not refer your self";

        }

        public struct DefaultPrice
        {
            public const int DEFAULTMINIMUMPRICE = 0;
            public const int DEFAULTMAXIMUMPRICE = 60000;

        }

        public struct SortType
        {
            public const string SORT_PRICE_HIGH_TO_LOW = "PRICEHIGHTOLOW";
            public const string SORT_PRICE_LOW_TO_HIGH = "PRICELOWTOHIGH";
            public const string DEFAULTSORTVALUE = "0";
            public const string DEFAULT_SORT = "NA";
        }

        public struct CategoryImageTag
        {
            public const string REFURBISHED_IMAGE_TAG = "/images/refurbished.png";
            public const string UNBOXED_IMAGE_TAG = "/images/unboxed-o.png";
            public const string PREOWNED_IMAGE_TAG = "/images/Preowned-o.png";
        }

        public struct DashBoardDisplayType
        {
            public const string TOPDEALS = "TopDeals";
            public const string REFURBISHED = "Refurbished";
            public const string UNBOXED = "Unboxed";
            public const string UNBOX = "Unbox";
            public const string PREOWNED = "Preowned";
            public const string BRANDS = "brand";


        }

        public struct DefualEmailcredential
        {
            public const string from = "no-reply@yaantra.com";
            public const string to = "no-reply@yaantra.com";
            public const string cc = "no-reply@yaantra.com";
            public const string bcc = "no-reply@yaantra.com";
            public const string subject = "Order Confirmation";

        }

        public struct ScreenName
        {
            public const string HOMEPAGE = "Home";
            public const string PRODUCTLISTING = "ProductList";
            public const string MYCART = "mycart";
            public const string CARTCHECKOUT = "CartCheckOut";
            public const string ORDER_CONFIRMATION = "OrderConfirmation";
            public const string DEFAULT_PAGE_TITLE = "Yaantra.com";
            public const string BROWSE_BY_BRAND = "Brands";
            public const string POWERBANK = "PowerBank";
            public const string FAQ = "Faq";
            public const string YAANTRACARE = "yaantracare";
            public const string CONTACTUS = "contactus";
            public const string RETURNPOLICY = "returnpolicy";
            public const string CAREER = "onlineapplicationform";
            public const string REFUNDPOLICY = "refundpolicy";
            public const string NEWSANDEVENTS = "newsandevents";
            public const string STORELOCATOR = "storelocator";
            public const string TERMSUSE = "termsuse";
            public const string SHIPPINGPOLICY = "shippingpolicy";
            public const string PRIVACYPOLICY = "privacypolicy";
            public const string YAANTRAOFFER = "yaantraoffer";
            public const string RETAILERREGISTRATION = "RetailerRegistration";

            public const string CANCELLATIONPOLICY = "cancellationpolicy";
            public const string IPHONEREPAIR = "Iphonerepair";
            public const string TABLETREPAIR = "tableterepair";
            public const string MOBILEREPAIR = "mobilerepair";
            public const string ABOUTUS = "aboutus";
            public const string SELLYOURPHONE = "sellyourphone";
            public const string ONLINEAPPLICATIONFORM = "OnlineApplicationForm";//naren23jan18 
            public const string BRANDLIST = "brandlist";
            public const string REFURBISHED = "refurbished";
            public const string UNBOXED = "unboxed";
            public const string PREOWNED = "preowned";
            public const string OFFERZONE = "offerzone";
            public const string TRACKORDER = "trackorder";
            public const string CAREEROPENINGS = "careeropenings";
            public const string JOBAPPLICATION = "jobapplication";
            public const string TRACKORDERDETAILS = "trackorderdetails";
            public const string YAANTRARETAILER = "yaantra-retailer";
        }
        public struct ScriptName
        {
            //naren7dec changed All Page to AllPage below all
            public const string All_Page = "AllPage";
            public const string LISTING_PAGE = "ListingPage";
            public const string PRODUCT_DETAIL_PAGE = "ProductDetailpage";
            public const string CART_PAGE = "CartPage";
            public const string CHECKOUT_PAGE = "CheckoutPage";
            public const string ORDERCONFIRMATION_PAGE = "OrderConfirmationPage";
            public const string WISHLIST_PAGE = "WishlistPage";//naren6dec
            public const string REGISTRATION_PAGE = "RegistrationPage";//naren6dec
            public const string LANDING_PAGE = "LandingPage";//naren7dec
            public const string THANKYOU_PAGE = "ThankyouPage";//naren7dec
        }

        public struct APIStatusCode
        {
            public const string STATUS_SUCCESS = "101";
            public const string STATUS_FAILED = "102";
            public const string MESSAGE = "Server Is Busy!Try After Some Time";
            public const string NO_Record = "No Record Found";
        }

        public struct PushNotificationMessage
        {
            public const string DEFAULT_ICON_PATH = "../Images/default_icons/push1.png";
            public const string PUBLICKEY = "BHmb3FSIPqJI_ZZW_TrQDuFp6bfbrqmube8HkTDLryyCQXQy3Mx5ehKQpwaHdXS7QCpSwJskXj7OCzK-WyKqov4";
            public const string PRIVATEKEY = "0QFGGV3JgdVMgAsw20O4lYLpBV5NpYEsDtfu1zqeZ7k";
        }
       
        //public struct GeneralMessage
        //{
        //    public const string SUCCESS_MESSAGE = "Data Saved Successfully";
        //    public const string UPDATE_MESSAGE = "Data Update Successfully";
        //    public const string DUPLICATE_RECORD = "Duplicate Record Found";
            
        //    public const string DELETE_MESSAGE = "Record is deleted Successfully!";
        //}
    }
}
