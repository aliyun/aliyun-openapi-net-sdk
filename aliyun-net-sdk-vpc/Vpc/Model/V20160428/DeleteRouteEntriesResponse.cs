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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DeleteRouteEntriesResponse : AcsResponse
	{

		private string requestId;

		private int? successCount;

		private int? failedCount;

		private List<DeleteRouteEntries_FailedRouteEntriesItem> failedRouteEntries;

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

		public int? SuccessCount
		{
			get
			{
				return successCount;
			}
			set	
			{
				successCount = value;
			}
		}

		public int? FailedCount
		{
			get
			{
				return failedCount;
			}
			set	
			{
				failedCount = value;
			}
		}

		public List<DeleteRouteEntries_FailedRouteEntriesItem> FailedRouteEntries
		{
			get
			{
				return failedRouteEntries;
			}
			set	
			{
				failedRouteEntries = value;
			}
		}

		public class DeleteRouteEntries_FailedRouteEntriesItem
		{

			private string routeEntryId;

			private string dstCidrBlock;

			private string nextHop;

			private string failedCode;

			private string failedMessage;

			public string RouteEntryId
			{
				get
				{
					return routeEntryId;
				}
				set	
				{
					routeEntryId = value;
				}
			}

			public string DstCidrBlock
			{
				get
				{
					return dstCidrBlock;
				}
				set	
				{
					dstCidrBlock = value;
				}
			}

			public string NextHop
			{
				get
				{
					return nextHop;
				}
				set	
				{
					nextHop = value;
				}
			}

			public string FailedCode
			{
				get
				{
					return failedCode;
				}
				set	
				{
					failedCode = value;
				}
			}

			public string FailedMessage
			{
				get
				{
					return failedMessage;
				}
				set	
				{
					failedMessage = value;
				}
			}
		}
	}
}
