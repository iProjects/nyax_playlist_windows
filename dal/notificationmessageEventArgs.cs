﻿/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/10/2018
 * Time: 10:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dal
{
	/// <summary>
	/// Description of notificationmessageEventArgs.
	/// </summary>
	public class notificationmessageEventArgs: EventArgs
	{
		public notificationmessageEventArgs(string _message){
			this.message = _message; 
		}
		public notificationmessageEventArgs(string _message, string _tag){
			this.message = _message; 
			this.TAG = _tag; 
		}
		public string message { get; private set; } 
		public string TAG { get; private set; } 
		 
	}
}
