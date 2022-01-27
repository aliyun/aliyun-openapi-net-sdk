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
	public class DescribeCSGClientsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeCSGClients_Client> clients;

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

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		[JsonProperty(PropertyName = "Clients")]
		public List<DescribeCSGClients_Client> Clients
		{
			get
			{
				return clients;
			}
			set	
			{
				clients = value;
			}
		}

		public class DescribeCSGClients_Client
		{

			private string vpcId;

			private string status;

			private string ecsInstanceId;

			private long? lastHeartbeatTime;

			private string clientId;

			private string clientVersion;

			private string clientInstallationCommand;

			private string clientDeletionCommand;

			private string workDirectory;

			[JsonProperty(PropertyName = "VpcId")]
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

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "EcsInstanceId")]
			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "LastHeartbeatTime")]
			public long? LastHeartbeatTime
			{
				get
				{
					return lastHeartbeatTime;
				}
				set	
				{
					lastHeartbeatTime = value;
				}
			}

			[JsonProperty(PropertyName = "ClientId")]
			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			[JsonProperty(PropertyName = "ClientVersion")]
			public string ClientVersion
			{
				get
				{
					return clientVersion;
				}
				set	
				{
					clientVersion = value;
				}
			}

			[JsonProperty(PropertyName = "ClientInstallationCommand")]
			public string ClientInstallationCommand
			{
				get
				{
					return clientInstallationCommand;
				}
				set	
				{
					clientInstallationCommand = value;
				}
			}

			[JsonProperty(PropertyName = "ClientDeletionCommand")]
			public string ClientDeletionCommand
			{
				get
				{
					return clientDeletionCommand;
				}
				set	
				{
					clientDeletionCommand = value;
				}
			}

			[JsonProperty(PropertyName = "WorkDirectory")]
			public string WorkDirectory
			{
				get
				{
					return workDirectory;
				}
				set	
				{
					workDirectory = value;
				}
			}
		}
	}
}
