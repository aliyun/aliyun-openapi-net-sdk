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
	public class DescribeGatewayNFSClientsResponse : AcsResponse
	{

		private bool? version40Enabled;

		private bool? version41Enabled;

		private int? totalCount;

		private string requestId;

		private string message;

		private int? pageSize;

		private int? pageNumber;

		private bool? version3Enabled;

		private string code;

		private bool? success;

		private List<DescribeGatewayNFSClients_ClientInfo> clientInfoList;

		[JsonProperty(PropertyName = "Version40Enabled")]
		public bool? Version40Enabled
		{
			get
			{
				return version40Enabled;
			}
			set	
			{
				version40Enabled = value;
			}
		}

		[JsonProperty(PropertyName = "Version41Enabled")]
		public bool? Version41Enabled
		{
			get
			{
				return version41Enabled;
			}
			set	
			{
				version41Enabled = value;
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

		[JsonProperty(PropertyName = "Version3Enabled")]
		public bool? Version3Enabled
		{
			get
			{
				return version3Enabled;
			}
			set	
			{
				version3Enabled = value;
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

		[JsonProperty(PropertyName = "ClientInfoList")]
		public List<DescribeGatewayNFSClients_ClientInfo> ClientInfoList
		{
			get
			{
				return clientInfoList;
			}
			set	
			{
				clientInfoList = value;
			}
		}

		public class DescribeGatewayNFSClients_ClientInfo
		{

			private bool? hasNFSv40;

			private bool? hasNFSv41;

			private bool? hasNFSv3;

			private string clientIpAddr;

			[JsonProperty(PropertyName = "HasNFSv40")]
			public bool? HasNFSv40
			{
				get
				{
					return hasNFSv40;
				}
				set	
				{
					hasNFSv40 = value;
				}
			}

			[JsonProperty(PropertyName = "HasNFSv41")]
			public bool? HasNFSv41
			{
				get
				{
					return hasNFSv41;
				}
				set	
				{
					hasNFSv41 = value;
				}
			}

			[JsonProperty(PropertyName = "HasNFSv3")]
			public bool? HasNFSv3
			{
				get
				{
					return hasNFSv3;
				}
				set	
				{
					hasNFSv3 = value;
				}
			}

			[JsonProperty(PropertyName = "ClientIpAddr")]
			public string ClientIpAddr
			{
				get
				{
					return clientIpAddr;
				}
				set	
				{
					clientIpAddr = value;
				}
			}
		}
	}
}
