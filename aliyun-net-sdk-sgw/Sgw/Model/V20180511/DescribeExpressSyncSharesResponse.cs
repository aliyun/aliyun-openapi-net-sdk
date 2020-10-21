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
	public class DescribeExpressSyncSharesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<DescribeExpressSyncShares_Share> shares;

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

			private string gatewayId;

			private string storageBundleId;

			private string gatewayName;

			private string gatewayRegion;

			private string shareName;

			private string expressSyncState;

			private string expressSyncId;

			private string mnsQueue;

			private int? syncProgress;

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
		}
	}
}
