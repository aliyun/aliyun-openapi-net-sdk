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
	public class DescribeGatewayActionsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<DescribeGatewayActions_Action> actions;

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

		public List<DescribeGatewayActions_Action> Actions
		{
			get
			{
				return actions;
			}
			set	
			{
				actions = value;
			}
		}

		public class DescribeGatewayActions_Action
		{

			private string gatewayId;

			private string self;

			private string monitor;

			private string disk;

			private string cache;

			private string smbUser;

			private string adLdap;

			private string target;

			public string GatewayId
			{
				get
				{
					return gatewayId;
				}
				set	
				{
					gatewayId = value;
				}
			}

			public string Self
			{
				get
				{
					return self;
				}
				set	
				{
					self = value;
				}
			}

			public string Monitor
			{
				get
				{
					return monitor;
				}
				set	
				{
					monitor = value;
				}
			}

			public string Disk
			{
				get
				{
					return disk;
				}
				set	
				{
					disk = value;
				}
			}

			public string Cache
			{
				get
				{
					return cache;
				}
				set	
				{
					cache = value;
				}
			}

			public string SmbUser
			{
				get
				{
					return smbUser;
				}
				set	
				{
					smbUser = value;
				}
			}

			public string AdLdap
			{
				get
				{
					return adLdap;
				}
				set	
				{
					adLdap = value;
				}
			}

			public string Target
			{
				get
				{
					return target;
				}
				set	
				{
					target = value;
				}
			}
		}
	}
}
