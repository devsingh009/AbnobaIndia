using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

using System.Text;


namespace AbnobaIndia.WebUtilities
{
    public class Utilities
    {

        public static StringBuilder SendMailToCustomer(string name, string username,string password)
        {
            //DateTime dt1 = Convert.ToDateTime(sPassDeliverDate);
            //dt1 = dt1.AddDays(4);
            //var dt = dt1.ToString("MMMM dd, yyyy");

            #region[html template]
            StringBuilder HTMLContent = new StringBuilder();
            HTMLContent.Append("<table>");
            HTMLContent.Append("<tbody style=\"padding-bottom: 50px; border-spacing: 0px; padding: 0px; text-align:center;  width:700px;\">");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"padding: 10px 10px 10px 10px; text-align: left; width: 700px; color: #fff;\">");
            HTMLContent.Append("<tbody>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td style=\"font-size: 12px; color:#333333; text-align:left; font-family: Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif \"><img src='http://localhost:54177/images/logo.png' alt='abnoba logo'></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</tbody>");
            HTMLContent.Append("</table>");

            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"border: 1px solid #333; padding-bottom: 25px; border-spacing: 0px; padding: 0px; width:700px; text-align:left;\">");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td align='left' style=\"font-size: 14px; font-style: normal; font-weight: 100; color: #333; line-height: 1.8; text-align:justify; padding:10px 20px 0px 20px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">");

            HTMLContent.Append("Hi " + name);
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">Thank you for showing your interest with <b>ABNOBA</b>.</p>");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif; line-height:1.3;\">You are successfully registered and now Authorized on ABNOBA for Login.</p>");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif; line-height:1.3;\">Your Login Details are as under:</p>");
            HTMLContent.Append(" UserId : " + username + "<br/>");
            HTMLContent.Append("Password:"+password+" <br/>");


            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr style=\"text-align:center; margin:20px 0 20px 0;\">");
            HTMLContent.Append("<td style=\"margin-top:14px;\"><a href='http://localhost:54177/images/logo.png' style=\"background-color: #d9534f; border: 1px solid #d04945; color: #fff; padding: 8px; font-weight:700; margin:30px 0px; text-decoration:none; font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;line-height:28px;\"> VISIT WEBSITE </a><br/><br/></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"margin-top: 20px; padding: 6px; background-color: #f4f4f4; border-spacing: 0px; padding: 0px; width: 700px; padding:15px 0 0 0 ;  text-align: center;\">");
            HTMLContent.Append("<tr style=\"padding:15px; text-align:center; width:700px;\">");
            HTMLContent.Append("<td style=\"margin-top:15px; font-size:20px; font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">ABNOBA</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"margin-top: -4px; padding: 6px; background-color: #f4f4f4; border-spacing: 0px; padding: 0px; width: 700px; padding:15px; text-align: center;\">");
            HTMLContent.Append("<tr style=\"text-align:center; padding:15px\">");
            HTMLContent.Append("<td style=\"border-right: 1px solid #121212;\"><a href='#' style=\"color: #121212;  text-decoration: none;   font-size: 15px; font-family: Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif \">About Us</a></td>");
            HTMLContent.Append("<td style=\"border-right: 1px solid #121212;\"><a href='#' style=\"color: #121212;  text-decoration: none;   font-size: 15px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">Programs</a></td>");
            HTMLContent.Append("<td><a href=#' style=\"color: #121212;  text-decoration: none;   font-size: 15px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">Facilities</a></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("</tbody>");

            HTMLContent.Append("</table>");

            return HTMLContent;
            #endregion
        }


        public static StringBuilder SendMailToAdmin(string CustomerName, string mobileNo, string Email, string comments)
        {
            //DateTime dt1 = Convert.ToDateTime(sPassDeliverDate);
            //dt1 = dt1.AddDays(4);
            //var dt = dt1.ToString("MMMM dd, yyyy");

            #region[html template]
            StringBuilder HTMLContent = new StringBuilder();
            HTMLContent.Append("<table>");
            HTMLContent.Append("<tbody style=\"padding-bottom: 50px; border-spacing: 0px; padding: 0px; text-align:center;  width:700px;\">");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"padding: 10px 10px 10px 10px; text-align: left; width: 700px; color: #fff;\">");
            HTMLContent.Append("<tbody>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td style=\"font-size: 12px; color:#333333; text-align:left; font-family: Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif \"><img src='http://www.kamalmodelschool.in/images/logo.png' alt='kms logo'></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</tbody>");
            HTMLContent.Append("</table>");

            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"border: 1px solid #333; padding-bottom: 25px; border-spacing: 0px; padding: 0px; width:700px; text-align:left;\">");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td align='left' style=\"font-size: 14px; font-style: normal; font-weight: 100; color: #333; line-height: 1.8; text-align:justify; padding:10px 20px 0px 20px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">");
            HTMLContent.Append("Dear Sir,");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">I would like to hear from you on below request. I am sharing my details and comments below:</p>");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif; line-height:1.3;\"><b>Name:</b>  " + CustomerName + "</p>");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif; line-height:1.3;\"><b>EmailID:</b>  " + Email + "</p>");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif; line-height:1.3;\"><b>Mobile No:</b>  " + mobileNo + "</p>");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif; line-height:1.3;\"><b>Comments/Query:</b>  " + comments + "</p>");

            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr style=\"text-align:center; margin:20px 0 20px 0;\">");
            HTMLContent.Append("<td style=\"margin-top:14px;\"><a href='http://www.kamalmodelschool.in/' style=\"background-color: #d9534f; border: 1px solid #d04945; color: #fff; padding: 8px; font-weight:700; margin:30px 0px; text-decoration:none; font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;line-height:28px;\"> VISIT WEBSITE </a><br/><br/></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"margin-top: 20px; padding: 6px; background-color: #f4f4f4; border-spacing: 0px; padding: 0px; width: 700px; padding:15px 0 0 0 ;  text-align: center;\">");
            HTMLContent.Append("<tr style=\"padding:15px; text-align:center; width:700px;\">");
            HTMLContent.Append("<td style=\"margin-top:15px; font-size:20px; font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">KMS, Mohan Garden, New Delhi</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"margin-top: -4px; padding: 6px; background-color: #f4f4f4; border-spacing: 0px; padding: 0px; width: 700px; padding:15px; text-align: center;\">");
            HTMLContent.Append("<tr style=\"text-align:center; padding:15px\">");
            HTMLContent.Append("<td style=\"border-right: 1px solid #121212;\"><a href='http://www.kamalmodelschool.in/home/aboutus' style=\"color: #121212;  text-decoration: none;   font-size: 15px; font-family: Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif \">About School</a></td>");
            HTMLContent.Append("<td style=\"border-right: 1px solid #121212;\"><a href='http://www.kamalmodelschool.in/gallery/photo-gallery' style=\"color: #121212;  text-decoration: none;   font-size: 15px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">Photo Gallery</a></td>");
            HTMLContent.Append("<td style=\"border-right: 1px solid #121212;\"><a href='http://www.kamalmodelschool.in/curriculum/admission-criteria' style=\"color: #121212;  text-decoration: none;   font-size: 15px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">Admission Criteria</a></td>");
            HTMLContent.Append("<td><a href='http://www.kamalmodelschool.in/home/facilities' style=\"color: #121212;  text-decoration: none;   font-size: 15px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">Infrastructure</a></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("</tbody>");

            HTMLContent.Append("</table>");

            return HTMLContent;
            #endregion
        }

        public static StringBuilder SendMailToAdmin(string CustomerName, string mobileno, string Email, string CheckIn, string CheckOut, string Child, string Adult, string Comments)
        {
            //DateTime dt1 = Convert.ToDateTime(CheckIn);
            //dt1 = dt1.AddDays(4);
            //var dt = dt1.ToString("MMMM dd, yyyy");

            #region[html template]
            StringBuilder HTMLContent = new StringBuilder();
            HTMLContent.Append("<table>");
            HTMLContent.Append("<tbody style=\"padding-bottom: 50px; border-spacing: 0px; padding: 0px; text-align:center;  width:700px;\">");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"padding: 10px 10px 10px 10px; text-align: left; width: 700px; color: #fff;\">");
            HTMLContent.Append("<tbody>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td style=\"font-size: 12px; color:#333333; text-align:left; font-family: Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif \"><img src='http://www.casaabuelavarca.com/images/logo.png' alt='logo'></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</tbody>");
            HTMLContent.Append("</table>");

            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"border: 1px solid #333; padding-bottom: 25px; border-spacing: 0px; padding: 0px; width:700px; text-align:left;\">");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td align='left' style=\"font-size: 14px; font-style: normal; font-weight: 100; color: #929292; line-height: 1.8; text-align:justify; padding:10px 20px 0px 20px; font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">");

            HTMLContent.Append("Dear Casa Abuela Team,");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif;\">I want to show my interest to book Casa Abuela Varca (http://casaabuelavarca.com).</p>");
            HTMLContent.Append("<p style=\"font-family:Gotham, ' helvetica neue', helvetica, arial, sans-serif; line-height:1.3;\">I am giving my details as:</p>");

            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr style=\"text-align:center; margin:20px 0 20px 0;\">");
            HTMLContent.Append("<td style=\"margin-top:14px;\"><a href='http://www.casaabuelavarca.com/' style=\"background-color: #d9534f; border: 1px solid #d04945; color: #fff; padding: 8px 40px; font-weight: 600; margin: 30px 0; text-decoration:none; font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\"> VISIT WEBSITE</a><br><br></td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr>");
            //<!-- Row container for Intro/ Description -->

            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Customer Name: " + CustomerName + "</td>");
            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">MobileNo: " + mobileno + "</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Email Id: " + Email + "</td>");
            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Comments: " + Comments + "</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Check In: " + CheckIn + "</td>");
            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Check Out: " + CheckOut + "</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Adult(s): " + Adult + "</td>");
            HTMLContent.Append("<td style=\"padding:15px;\"> <span style=\"font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Child(s): " + Child + "</td>");
            HTMLContent.Append("</tr>");


            // HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
           
            HTMLContent.Append("</tr>");


            HTMLContent.Append("<tr>");
            HTMLContent.Append("<td>");
            HTMLContent.Append("<table style=\"margin-top: 20px; padding: 6px; background-color: #f4f4f4; border-spacing: 0px; padding: 0px; width: 700px; padding:15px 0 0 0 ;  text-align: center;\">");
            HTMLContent.Append("<tr style=\"padding:15px; text-align:center; width:700px;\">");
            HTMLContent.Append("<td style=\"margin-top:15px; font-size:20px; font-family:Gotham, 'Helvetica Neue', Helvetica, Arial, sans-serif;\">Casa Abuela Varca: Goa</td>");
            HTMLContent.Append("</tr>");
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");
            
            HTMLContent.Append("</table>");
            HTMLContent.Append("</td>");
            HTMLContent.Append("</tr>");

            HTMLContent.Append("</tbody>");

            HTMLContent.Append("</table>");

            return HTMLContent;
            #endregion
        }

        public static string SendSMS(string mobileNo, string msg)
        {
            string msgConfirmation = string.Empty;
            System.Net.WebClient client = new System.Net.WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            string baseurl = "http://alerts.cbis.in/SMSApi/send?userid=yantra&password=yantra@1&sendMethod=quick&mobile=" + mobileNo + "&msg=" + msg + "&senderid=YANTRA&msgType=text&duplicatecheck=true&output=json";
            System.IO.Stream data = client.OpenRead(baseurl);
            System.IO.StreamReader reader = new System.IO.StreamReader(data);
            msgConfirmation = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return msgConfirmation;
        }

       

    }


    
}