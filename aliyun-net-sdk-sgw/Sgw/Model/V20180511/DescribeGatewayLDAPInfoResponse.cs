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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayLDAPInfoResponse : AcsResponse
	{

		private string rootDN;

		private string requestId;

		private string message;

		private bool? isEnabled;

		private string baseDN;

		private string serverIp;

		private bool? isTls;

		private string code;

		private bool? success;

		[JsonProperty(PropertyName = "RootDN")]
		public string RootDN
		{
			get
			{
				return rootDN;
			}
			set	
			{
				rootDN = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "IsEnabled")]
		public bool? IsEnabled
		{
			get
			{
				return isEnabled;
			}
			set	
			{
				isEnabled = value;
			}
		}

		[JsonProperty(PropertyName = "BaseDN")]
		public string BaseDN
		{
			get
			{
				return baseDN;
			}
			set	
			{
				baseDN = value;
			}
		}

		[JsonProperty(PropertyName = "ServerIp")]
		public string ServerIp
		{
			get
			{
				return serverIp;
			}
			set	
			{
				serverIp = value;
			}
		}

		[JsonProperty(PropertyName = "IsTls")]
		public bool? IsTls
		{
			get
			{
				return isTls;
			}
			set	
			{
				isTls = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}
	}
}
