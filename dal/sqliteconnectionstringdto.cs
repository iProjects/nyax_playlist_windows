﻿/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/27/2018
 * Time: 07:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dal
{
	public class sqliteconnectionstringdto : connectionstringdto
	{ 
		public string sqlite_database_path { get; set; }
		public string sqlite_version { get; set; }
		public string sqlite_pooling { get; set; }
		public string sqlite_fail_if_missing { get; set; }
		public string sqlite_db_extension { get; set; } 
	}
}
