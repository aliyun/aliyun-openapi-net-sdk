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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ModifyInstanceResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private ModifyInstance_Instance instance;

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

		public ModifyInstance_Instance Instance
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

		public class ModifyInstance_Instance
		{

			private long? creationTime;

			private string owner;

			private string callCenterInstanceId;

			private string nluServiceType;

			private string instanceName;

			private string creatorName;

			private int? maxConcurrentConversation;

			private string ownerName;

			private long? creatorId;

			private string instanceId;

			private string instanceDescription;

			private ModifyInstance_NluProfile nluProfile;

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

			public string CreatorName
			{
				get
				{
					return creatorName;
				}
				set	
				{
					creatorName = value;
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

			public string OwnerName
			{
				get
				{
					return ownerName;
				}
				set	
				{
					ownerName = value;
				}
			}

			public long? CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
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

			public ModifyInstance_NluProfile NluProfile
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

			public class ModifyInstance_NluProfile
			{

				private string accessKey;

				private string secretKey;

				private string endpoint;

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
			}
		}
	}
}
