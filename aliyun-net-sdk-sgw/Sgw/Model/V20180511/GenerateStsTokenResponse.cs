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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class GenerateStsTokenResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private string accessKeyId;

		private string accessKeySecret;

		private string expiration;

		private string securityToken;

		private string supportBundleTarget;

		private string environment;

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
			}
		}

		public string AccessKeySecret
		{
			get
			{
				return accessKeySecret;
			}
			set	
			{
				accessKeySecret = value;
			}
		}

		public string Expiration
		{
			get
			{
				return expiration;
			}
			set	
			{
				expiration = value;
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
			}
		}

		public string SupportBundleTarget
		{
			get
			{
				return supportBundleTarget;
			}
			set	
			{
				supportBundleTarget = value;
			}
		}

		public string Environment
		{
			get
			{
				return environment;
			}
			set	
			{
				environment = value;
			}
		}
	}
}
