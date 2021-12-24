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
	public class DescribeExpressSyncSharesResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<DescribeExpressSyncShares_Share> shares;

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

		[JsonProperty(PropertyName = "Shares")]
		public List<DescribeExpressSyncShares_Share> Shares
		{
			get
			{
				return shares;
			}
			set	
			{
				shares = value;
			}
		}

		public class DescribeExpressSyncShares_Share
		{

			private string mnsQueue;

			private string expressSyncId;

			private string gatewayId;

			private string expressSyncState;

			private string gatewayName;

			private string storageBundleId;

			private int? syncProgress;

			private string gatewayRegion;

			private string shareName;

			[JsonProperty(PropertyName = "MnsQueue")]
			public string MnsQueue
			{
				get
				{
					return mnsQueue;
				}
				set	
				{
					mnsQueue = value;
				}
			}

			[JsonProperty(PropertyName = "ExpressSyncId")]
			public string ExpressSyncId
			{
				get
				{
					return expressSyncId;
				}
				set	
				{
					expressSyncId = value;
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

			[JsonProperty(PropertyName = "ExpressSyncState")]
			public string ExpressSyncState
			{
				get
				{
					return expressSyncState;
				}
				set	
				{
					expressSyncState = value;
				}
			}

			[JsonProperty(PropertyName = "GatewayName")]
			public string GatewayName
			{
				get
				{
					return gatewayName;
				}
				set	
				{
					gatewayName = value;
				}
			}

			[JsonProperty(PropertyName = "StorageBundleId")]
			public string StorageBundleId
			{
				get
				{
					return storageBundleId;
				}
				set	
				{
					storageBundleId = value;
				}
			}

			[JsonProperty(PropertyName = "SyncProgress")]
			public int? SyncProgress
			{
				get
				{
					return syncProgress;
				}
				set	
				{
					syncProgress = value;
				}
			}

			[JsonProperty(PropertyName = "GatewayRegion")]
			public string GatewayRegion
			{
				get
				{
					return gatewayRegion;
				}
				set	
				{
					gatewayRegion = value;
				}
			}

			[JsonProperty(PropertyName = "ShareName")]
			public string ShareName
			{
				get
				{
					return shareName;
				}
				set	
				{
					shareName = value;
				}
			}
		}
	}
}
