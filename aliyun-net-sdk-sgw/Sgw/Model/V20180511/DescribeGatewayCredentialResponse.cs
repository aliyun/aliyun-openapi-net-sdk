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
	public class DescribeGatewayCredentialResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private string ecsIp;

		private string ecsPassword;

		private string consoleUsername;

		private string consolePassword;

		private string vpcId;

		private string vSwitchId;

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

		public string EcsIp
		{
			get
			{
				return ecsIp;
			}
			set	
			{
				ecsIp = value;
			}
		}

		public string EcsPassword
		{
			get
			{
				return ecsPassword;
			}
			set	
			{
				ecsPassword = value;
			}
		}

		public string ConsoleUsername
		{
			get
			{
				return consoleUsername;
			}
			set	
			{
				consoleUsername = value;
			}
		}

		public string ConsolePassword
		{
			get
			{
				return consolePassword;
			}
			set	
			{
				consolePassword = value;
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
			}
		}
	}
}
