﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClassSOAPWS;
using QuizFlashLibrary;

namespace ClassSoapWS
{
    /// <summary>
    /// Summary description for Classes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Classes : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet GetClass(String username)
        {
            DBConnect myDB = new DBConnect();
            String dbStr = "SELECT * FROM TP_Classes";
            DataSet myDS;

            myDS = myDB.GetDataSet(dbStr);
            return myDS;
        }

        //retrieve students in a class
        //Need to add database to include students or students to include classes
        [WebMethod]
        public DataSet getStudents(String name)
        {
            DBConnect myDB = new DBConnect();
            String dbStr = "SELECT * " +
            "FROM TP_Students";
            DataSet myDS;

            myDS = myDB.GetDataSet(dbStr);
            return myDS;
        }

        [WebMethod]
        public Boolean AddClass(TeacherClass obj)
        {
            if (obj != null)
            {
                DBConnect objDB = new DBConnect();

                String strSQL = "INSERT INTO TP_Classes (Name, Subject, Username, User_Type) " +
                                 "VALUES ('" + obj.Name + "','" + obj.Subject + "','" + obj.Username + "','" + obj.User_Type + "')";
                int retVal = objDB.DoUpdate(strSQL);
                if (retVal > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public Boolean DeleteClass(TeacherClass obj)
        {
            if (obj != null)
            {
                DBConnect db = new DBConnect();
                String cmd = "DELETE FROM TP_Classes (Name, Subject, Username, User_Type) " +
                             "VALUES('" + obj.Name + "', '" + obj.Subject + "', '" + obj.Username + "', '" + obj.User_Type + "')";
                int row = db.DoUpdate(cmd);
                
                if (row > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }


    }
}
