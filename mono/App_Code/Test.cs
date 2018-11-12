using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Script.Serialization;


public class Test : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {

        context.Response.ContentType = "application/json";
        context.Response.Write("{}");
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}