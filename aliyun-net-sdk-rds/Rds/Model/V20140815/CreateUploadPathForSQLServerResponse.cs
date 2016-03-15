/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class CreateUploadPathForSQLServerResponse : AcsResponse
	{

		private string internetFtpServer;

		private int? internetPort;

		private string intranetFtpserver;

		private int? intranetport;

		private string userName;

		private string password;

		private string fileName;

		public string InternetFtpServer
		{
			get
			{
				return internetFtpServer;
			}
			set	
			{
				internetFtpServer = value;
			}
		}

		public int? InternetPort
		{
			get
			{
				return internetPort;
			}
			set	
			{
				internetPort = value;
			}
		}

		public string IntranetFtpserver
		{
			get
			{
				return intranetFtpserver;
			}
			set	
			{
				intranetFtpserver = value;
			}
		}

		public int? Intranetport
		{
			get
			{
				return intranetport;
			}
			set	
			{
				intranetport = value;
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
			}
		}
	}
}