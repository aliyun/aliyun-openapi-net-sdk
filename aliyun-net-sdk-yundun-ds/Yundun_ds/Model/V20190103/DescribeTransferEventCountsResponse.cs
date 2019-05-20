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

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
	public class DescribeTransferEventCountsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTransferEventCounts_Transfer> transferEventCountList;

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

		public List<DescribeTransferEventCounts_Transfer> TransferEventCountList
		{
			get
			{
				return transferEventCountList;
			}
			set	
			{
				transferEventCountList = value;
			}
		}

		public class DescribeTransferEventCounts_Transfer
		{

			private long? totalCount;

			private string productCode;

			private string targetProductCode;

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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string TargetProductCode
			{
				get
				{
					return targetProductCode;
				}
				set	
				{
					targetProductCode = value;
				}
			}
		}
	}
}
