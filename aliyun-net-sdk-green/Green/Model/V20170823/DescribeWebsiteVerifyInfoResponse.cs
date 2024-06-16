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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeWebsiteVerifyInfoResponse : AcsResponse
	{

		private string domain;

		private string requestId;

		private string verifyMethod;

		private string indexPage;

		private string protocol;

		private string cname;

		private string hostFile;

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string VerifyMethod
		{
			get
			{
				return verifyMethod;
			}
			set	
			{
				verifyMethod = value;
			}
		}

		public string IndexPage
		{
			get
			{
				return indexPage;
			}
			set	
			{
				indexPage = value;
			}
		}

		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
			}
		}

		public string Cname
		{
			get
			{
				return cname;
			}
			set	
			{
				cname = value;
			}
		}

		public string HostFile
		{
			get
			{
				return hostFile;
			}
			set	
			{
				hostFile = value;
			}
		}
	}
}
