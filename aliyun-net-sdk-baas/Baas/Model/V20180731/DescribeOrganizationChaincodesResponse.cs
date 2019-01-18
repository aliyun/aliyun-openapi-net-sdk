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

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class DescribeOrganizationChaincodesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private List<DescribeOrganizationChaincodes_OrganizationChaincode> result;

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

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public List<DescribeOrganizationChaincodes_OrganizationChaincode> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeOrganizationChaincodes_OrganizationChaincode
		{

			private string name;

			private string version;

			private string creator;

			private string channelId;

			private string channelName;

			private string createTime;

			private string deployTime;

			private string chaincodeId;

			private string endorsePolicy;

			private string state;

			private string installed;

			private string message;

			private string consortiumId;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
				}
			}

			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
				}
			}

			public string ChannelName
			{
				get
				{
					return channelName;
				}
				set	
				{
					channelName = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string DeployTime
			{
				get
				{
					return deployTime;
				}
				set	
				{
					deployTime = value;
				}
			}

			public string ChaincodeId
			{
				get
				{
					return chaincodeId;
				}
				set	
				{
					chaincodeId = value;
				}
			}

			public string EndorsePolicy
			{
				get
				{
					return endorsePolicy;
				}
				set	
				{
					endorsePolicy = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string Installed
			{
				get
				{
					return installed;
				}
				set	
				{
					installed = value;
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

			public string ConsortiumId
			{
				get
				{
					return consortiumId;
				}
				set	
				{
					consortiumId = value;
				}
			}
		}
	}
}