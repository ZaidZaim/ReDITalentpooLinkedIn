using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using RestSharp;

namespace LinkedInAPIs
{
    class Program
    {
        /*
         * Client ID: 77rvncft7i3cc5
         * Client Secret: HlBlGH9dRtEknzKC
         * redirect URL: http://localhost:3001/
         * encoded redirect URL: http%3A%2F%2Flocalhost%3A3001%2F
         * 
         * 
         */
        // third party authentications c# 
        // POST Method
        static void Main(string[] args)
        {
            
            // Create a request for the URL.
            System.Diagnostics.Process.Start("https://www.linkedin.com/oauth/v2/authorization?response_type=code&state=987654321&scope=r_liteprofile%20r_emailaddress&client_id=77rvncft7i3cc5&redirect_uri=http%3A%2F%2Flocalhost%3A3001%2F");
           

        }
    }
}
