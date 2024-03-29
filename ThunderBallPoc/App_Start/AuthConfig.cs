﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using ThunderBallPoc.Models;

namespace ThunderBallPoc
{
	public static class AuthConfig
	{
		public static void RegisterAuth()
		{
			// To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
			// you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

			//OAuthWebSecurity.RegisterMicrosoftClient(
			//    clientId: "",
			//    clientSecret: "");

			OAuthWebSecurity.RegisterTwitterClient(
				consumerKey: ConfigurationManager.AppSettings["TwitterConsumerKey"],
				consumerSecret: ConfigurationManager.AppSettings["TwitterConsumerSecret"]);

			//OAuthWebSecurity.RegisterFacebookClient(
			//    appId: "",
			//    appSecret: "");

			OAuthWebSecurity.RegisterGoogleClient();
		}
	}
}
