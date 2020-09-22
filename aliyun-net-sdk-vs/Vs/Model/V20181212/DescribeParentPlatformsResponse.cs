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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeParentPlatformsResponse : AcsResponse
	{

		private string requestId;

		private long? pageSize;

		private long? pageNum;

		private long? pageCount;

		private long? totalCount;

		private List<DescribeParentPlatforms_Platform> platforms;

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

		public long? PageSize
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

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		public long? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
			}
		}

		public long? TotalCount
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

		public List<DescribeParentPlatforms_Platform> Platforms
		{
			get
			{
				return platforms;
			}
			set	
			{
				platforms = value;
			}
		}

		public class DescribeParentPlatforms_Platform
		{

			private string id;

			private string name;

			private string description;

			private string protocol;

			private string status;

			private string gbId;

			private string ip;

			private long? port;

			private string clientGbId;

			private bool? clientAuth;

			private string clientUsername;

			private string clientPassword;

			private string clientIp;

			private long? clientPort;

			private bool? autoStart;

			private string createdTime;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public string GbId
			{
				get
				{
					return gbId;
				}
				set	
				{
					gbId = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public long? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string ClientGbId
			{
				get
				{
					return clientGbId;
				}
				set	
				{
					clientGbId = value;
				}
			}

			public bool? ClientAuth
			{
				get
				{
					return clientAuth;
				}
				set	
				{
					clientAuth = value;
				}
			}

			public string ClientUsername
			{
				get
				{
					return clientUsername;
				}
				set	
				{
					clientUsername = value;
				}
			}

			public string ClientPassword
			{
				get
				{
					return clientPassword;
				}
				set	
				{
					clientPassword = value;
				}
			}

			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
				}
			}

			public long? ClientPort
			{
				get
				{
					return clientPort;
				}
				set	
				{
					clientPort = value;
				}
			}

			public bool? AutoStart
			{
				get
				{
					return autoStart;
				}
				set	
				{
					autoStart = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}
		}
	}
}
