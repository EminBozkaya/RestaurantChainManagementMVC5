using RCM.DataAccess.Concrete.EntityFramework.Context;
using RCM.Model.Domain;
using System;
using System.Data.SqlClient;
using System.Text;

namespace RCM.WebUI.MvcHelper
{
    public static class CreateExceptionFormat
    {

        public static string CreateMessage(Exception ex)
        {

            MyException myEx = new MyException();
            StringBuilder sb = new StringBuilder();
            StringBuilder sqlSb = new StringBuilder();
            StringBuilder innersqlSb = new StringBuilder();
            int id = 0;
            if (SessionManager.ActiveUser != null) id = SessionManager.ActiveUser.UId;

            string hResult = "-";
            string Message = "-";
            string Source = "-";
            string stackTrace = "-";
            string paramName = "-";
            string errors = "-";
            string innerMessage = "-";
            string innerSource = "-";
            string innerstackTrace = "-";
            string innerparamName = "-";
            string innererrors = "-";

            if (ex.HResult.ToString() != null)
                hResult = ex.HResult.ToString();
            if (ex.Message != null)
                Message = ex.Message;
            if (ex.Source != null)
                Source = ex.Source;
            if (ex.StackTrace != null)
                stackTrace = ex.StackTrace;


            try 
            {
                if (ex is SqlException)
                {

                    SqlException sex = (SqlException)ex;

                    foreach (SqlError failure in sex.Errors)
                    {
                        for (int i = 0; i < sex.Errors.Count; i++)
                        {
                            sqlSb.Append("Index #" + i + ":" +
                                "Message: " + sex.Errors[i].Message + " / " +
                                "LineNumber: " + sex.Errors[i].LineNumber + " / " +
                                "Source: " + sex.Errors[i].Source + " / " +
                                "Procedure: " + sex.Errors[i].Procedure + "  //  ");
                        }
                    }
                    errors = sqlSb.ToString();
                }
            }
            catch { }



            if (ex is ArgumentNullException)
            {
                ArgumentNullException anEx = (ArgumentNullException)ex;

                if (anEx.ParamName != null)
                    paramName = anEx.ParamName;
            }
            if (ex is ArgumentOutOfRangeException)
            {
                ArgumentOutOfRangeException aorEx = (ArgumentOutOfRangeException)ex;

                if (aorEx.ParamName != null)
                    paramName = aorEx.ParamName;
            }
            if (ex is ArgumentException)
            {
                ArgumentException aEx = (ArgumentException)ex;

                if (aEx.ParamName != null)
                    paramName = aEx.ParamName;
            }


            if (ex.InnerException is SqlException)
            {
                innersqlSb.Clear();
                SqlException sex = (SqlException)(ex.InnerException);
                foreach (SqlError failure in sex.Errors)
                {
                    for (int i = 0; i < sex.Errors.Count; i++)
                    {
                        innersqlSb.Append("Index #" + i + ":" +
                            "Message: " + sex.Errors[i].Message + " / " +
                            "LineNumber: " + sex.Errors[i].LineNumber + " / " +
                            "Source: " + sex.Errors[i].Source + " / " +
                            "Procedure: " + sex.Errors[i].Procedure + "  //  ");
                    }
                }
                innererrors = innersqlSb.ToString();
            }



            if (ex.InnerException != null)
            {
                if (ex.InnerException.Message != null)
                    innerMessage = ex.InnerException.Message;
                if (ex.InnerException.Source != null)
                    innerSource = ex.InnerException.Source;
                if (ex.InnerException.StackTrace != null)
                    innerstackTrace = ex.InnerException.StackTrace;
            }



            if (ex.InnerException is ArgumentNullException)
            {
                ArgumentNullException anEx = (ArgumentNullException)(ex.InnerException);

                if (anEx.ParamName != null)
                    innerparamName = anEx.ParamName;
            }
            if (ex.InnerException is ArgumentOutOfRangeException)
            {
                ArgumentOutOfRangeException aorEx = (ArgumentOutOfRangeException)(ex.InnerException);

                if (aorEx.ParamName != null)
                    paramName = aorEx.ParamName;
            }
            if (ex.InnerException is ArgumentException)
            {
                ArgumentException aEx = (ArgumentException)(ex.InnerException);

                if (aEx.ParamName != null)
                    paramName = aEx.ParamName;
            }



            sb.Append("<b>Hata kodu #(HResult):</b> " + hResult + "<br />");
            sb.Append("<b>Hata mesajı:</b> " + Message + "<br />");
            sb.Append("<b>Hata merkezi:</b> " + Source + "<br />");
            //sb.Append("<b>Hata izi:</b> " + stackTrace + "<br />");
            if(paramName!="-")
            sb.Append("<b>Hatalı parametre:</b> " + paramName + "<br />");
            if (errors != "-")
                sb.Append("<b>Sql Hataları:</b> " + errors + "<br />");
            if (innerMessage != "-")
                sb.Append("<b>Dahili hata mesajı:</b> " + innerMessage + "<br />");
            if (innerSource != "-")
                sb.Append("<b>Dahili hata merkezi:</b> " + innerSource + "<br />");
            if (innerparamName != "-")
                //sb.Append("<b>Dahili hata izi:</b> " + innerstackTrace + "<br />");
                sb.Append("<b>Dahili hatalı parametre:</b> " + innerparamName + "<br />");
            if (innererrors != "-")
                sb.Append("<b>Dahili Sql hataları:</b> " + innererrors + "<br />");

            

            //--------to log exception to database------------

            myEx.UId = id;
            myEx.Date = DateTime.Now;
            myEx.HResultCode = hResult;
            myEx.Message = Message;
            myEx.Source = Source;
            myEx.StackTrace = stackTrace;
            myEx.ParamName = paramName;
            myEx.Errors = errors;
            myEx.InnerMessage = innerMessage;
            myEx.InnerSource = innerSource;
            myEx.InnerStackTrace = innerstackTrace;
            myEx.InnerParamName = innerparamName;
            myEx.InnerErrors = innererrors;

            try
            {
                using (RCMContext ctx = new RCMContext())
                {
                    MyException addedEntity = ctx.Set<MyException>().Add(myEx);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                sb.Append("------------------------------------<br />");
                sb.Append("<h5><b>Hata, veritabanına kaydedilemedi</b></h5>");
                return sb.ToString();
            }

            
            //---------------/ end logging-------------------------------


            return sb.ToString();
        }


    }
}



//messageBody = string.Format("<b>Hata kodu #(HResult):</b> {0}<br /><b>Hata mesajı:</b> {1}<br /><b>Hata merkezi:</b> {2}<br /><b>Hata izi:</b> {3}<br /><b>Dahili hata mesajı:</b> {4}<br /><b>Dahili hata merkezi:</b> {5}<br /><b>Dahili hata izi:</b> {6}", hResult, Message, Source, stackTrace, innerMessage, innerSource, innerstackTrace);


//NullReferenceException n = new NullReferenceException();

//ArgumentOutOfRangeException a = new ArgumentOutOfRangeException();

//IndexOutOfRangeException i = new IndexOutOfRangeException();

////par ArgumentException an = new ArgumentException();

//SqlException s = new SqlException();


//WebException w = new WebException();

//SmtpException sm = new SmtpException();

////par ArgumentNullException ar = new ArgumentNullException();


//FieldAccessException f = new FieldAccessException();

//IOException tinoksit = new IOException();


//DateTime dt;
//string createdTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//try
//{
//    DateTime.TryParseExact(createdTime,
//               "yyyy-MM-dd HH:mm:ss",
//                CultureInfo.InvariantCulture,
//                DateTimeStyles.None,
//                out dt);
//}
//catch
//{
//    throw;
//}