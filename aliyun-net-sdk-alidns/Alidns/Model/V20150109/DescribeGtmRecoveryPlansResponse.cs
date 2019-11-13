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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeGtmRecoveryPlansResponse : AcsResponse
	{

		private string requestId;

		private int? totalItems;

		private int? totalPages;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeGtmRecoveryPlans_RecoveryPlan> recoveryPlans;

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

		public int? TotalItems
		{
			get
			{
				return totalItems;
			}
			set	
			{
				totalItems = value;
			}
		}

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
			}
		}

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

		public List<DescribeGtmRecoveryPlans_RecoveryPlan> RecoveryPlans
		{
			get
			{
				return recoveryPlans;
			}
			set	
			{
				recoveryPlans = value;
			}
		}

		public class DescribeGtmRecoveryPlans_RecoveryPlan
		{

			private long? recoveryPlanId;

			private string name;

			private string remark;

			private int? faultAddrPoolNum;

			private string lastExecuteTime;

			private long? lastExecuteTimestamp;

			private string lastRollbackTime;

			private long? lastRollbackTimestamp;

			private string createTime;

			private long? createTimestamp;

			private string updateTime;

			private long? updateTimestamp;

			private string status;

			public long? RecoveryPlanId
			{
				get
				{
					return recoveryPlanId;
				}
				set	
				{
					recoveryPlanId = value;
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

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public int? FaultAddrPoolNum
			{
				get
				{
					return faultAddrPoolNum;
				}
				set	
				{
					faultAddrPoolNum = value;
				}
			}

			public string LastExecuteTime
			{
				get
				{
					return lastExecuteTime;
				}
				set	
				{
					lastExecuteTime = value;
				}
			}

			public long? LastExecuteTimestamp
			{
				get
				{
					return lastExecuteTimestamp;
				}
				set	
				{
					lastExecuteTimestamp = value;
				}
			}

			public string LastRollbackTime
			{
				get
				{
					return lastRollbackTime;
				}
				set	
				{
					lastRollbackTime = value;
				}
			}

			public long? LastRollbackTimestamp
			{
				get
				{
					return lastRollbackTimestamp;
				}
				set	
				{
					lastRollbackTimestamp = value;
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

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? UpdateTimestamp
			{
				get
				{
					return updateTimestamp;
				}
				set	
				{
					updateTimestamp = value;
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
		}
	}
}
