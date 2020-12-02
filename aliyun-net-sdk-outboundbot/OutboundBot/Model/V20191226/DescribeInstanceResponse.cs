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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class DescribeInstanceResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeInstance_Instance instance;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public DescribeInstance_Instance Instance
		{
			get
			{
				return instance;
			}
			set	
			{
				instance = value;
			}
		}

		public class DescribeInstance_Instance
		{

			private string callCenterInstanceId;

			private long? creationTime;

			private string instanceDescription;

			private string instanceId;

			private string instanceName;

			private int? maxConcurrentConversation;

			private string owner;

			private string nluServiceType;

			private DescribeInstance_NluProfile nluProfile;

			public string CallCenterInstanceId
			{
				get
				{
					return callCenterInstanceId;
				}
				set	
				{
					callCenterInstanceId = value;
				}
			}

			public long? CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string InstanceDescription
			{
				get
				{
					return instanceDescription;
				}
				set	
				{
					instanceDescription = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public int? MaxConcurrentConversation
			{
				get
				{
					return maxConcurrentConversation;
				}
				set	
				{
					maxConcurrentConversation = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string NluServiceType
			{
				get
				{
					return nluServiceType;
				}
				set	
				{
					nluServiceType = value;
				}
			}

			public DescribeInstance_NluProfile NluProfile
			{
				get
				{
					return nluProfile;
				}
				set	
				{
					nluProfile = value;
				}
			}

			public class DescribeInstance_NluProfile
			{

				private string endpoint;

				private string accessKey;

				private string secretKey;

				public string Endpoint
				{
					get
					{
						return endpoint;
					}
					set	
					{
						endpoint = value;
					}
				}

				public string AccessKey
				{
					get
					{
						return accessKey;
					}
					set	
					{
						accessKey = value;
					}
				}

				public string SecretKey
				{
					get
					{
						return secretKey;
					}
					set	
					{
						secretKey = value;
					}
				}
			}
		}
	}
}
