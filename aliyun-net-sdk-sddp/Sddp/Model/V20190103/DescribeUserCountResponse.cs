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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeUserCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeUserCount_UserCount userCount;

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

		public DescribeUserCount_UserCount UserCount
		{
			get
			{
				return userCount;
			}
			set	
			{
				userCount = value;
			}
		}

		public class DescribeUserCount_UserCount
		{

			private bool? authed;

			private bool? buyed;

			private int? authCount;

			private int? unAuthCount;

			private int? totalAuthCount;

			private long? warnTotalCount;

			private int? saleInstanceStatus;

			private long? warnAddCount;

			private string saleInstanceId;

			public bool? Authed
			{
				get
				{
					return authed;
				}
				set	
				{
					authed = value;
				}
			}

			public bool? Buyed
			{
				get
				{
					return buyed;
				}
				set	
				{
					buyed = value;
				}
			}

			public int? AuthCount
			{
				get
				{
					return authCount;
				}
				set	
				{
					authCount = value;
				}
			}

			public int? UnAuthCount
			{
				get
				{
					return unAuthCount;
				}
				set	
				{
					unAuthCount = value;
				}
			}

			public int? TotalAuthCount
			{
				get
				{
					return totalAuthCount;
				}
				set	
				{
					totalAuthCount = value;
				}
			}

			public long? WarnTotalCount
			{
				get
				{
					return warnTotalCount;
				}
				set	
				{
					warnTotalCount = value;
				}
			}

			public int? SaleInstanceStatus
			{
				get
				{
					return saleInstanceStatus;
				}
				set	
				{
					saleInstanceStatus = value;
				}
			}

			public long? WarnAddCount
			{
				get
				{
					return warnAddCount;
				}
				set	
				{
					warnAddCount = value;
				}
			}

			public string SaleInstanceId
			{
				get
				{
					return saleInstanceId;
				}
				set	
				{
					saleInstanceId = value;
				}
			}
		}
	}
}
