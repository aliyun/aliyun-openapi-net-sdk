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
	public class DescribeGatewayActionsResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<DescribeGatewayActions_Action> actions;

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

		[JsonProperty(PropertyName = "Actions")]
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

			private string smbUser;

			private string adLdap;

			private string gatewayId;

			private string monitor;

			private string self;

			private string disk;

			private string cache;

			private string target;

			[JsonProperty(PropertyName = "SmbUser")]
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

			[JsonProperty(PropertyName = "AdLdap")]
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

			[JsonProperty(PropertyName = "GatewayId")]
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

			[JsonProperty(PropertyName = "Monitor")]
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

			[JsonProperty(PropertyName = "Self")]
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

			[JsonProperty(PropertyName = "Disk")]
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

			[JsonProperty(PropertyName = "Cache")]
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

			[JsonProperty(PropertyName = "Target")]
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
