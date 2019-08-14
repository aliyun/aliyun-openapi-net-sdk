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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DescribeVerifyUsageResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeVerifyUsage_VerifyUsage> verifyUsageList;

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

		public List<DescribeVerifyUsage_VerifyUsage> VerifyUsageList
		{
			get
			{
				return verifyUsageList;
			}
			set	
			{
				verifyUsageList = value;
			}
		}

		public class DescribeVerifyUsage_VerifyUsage
		{

			private string bizType;

			private string date;

			private long? totalCount;

			private long? passCount;

			private long? failCount;

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
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

			public long? PassCount
			{
				get
				{
					return passCount;
				}
				set	
				{
					passCount = value;
				}
			}

			public long? FailCount
			{
				get
				{
					return failCount;
				}
				set	
				{
					failCount = value;
				}
			}
		}
	}
}
