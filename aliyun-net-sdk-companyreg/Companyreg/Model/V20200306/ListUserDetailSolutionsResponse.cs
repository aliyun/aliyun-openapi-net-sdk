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

namespace Aliyun.Acs.companyreg.Model.V20200306
{
	public class ListUserDetailSolutionsResponse : AcsResponse
	{

		private int? currentPageNum;

		private int? pageSize;

		private string requestId;

		private int? totalItemNum;

		private int? totalPageNum;

		private List<ListUserDetailSolutions_Solution> data;

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public List<ListUserDetailSolutions_Solution> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListUserDetailSolutions_Solution
		{

			private string bizId;

			private string bizType;

			private long? createTime;

			private string deliveryOrderBizId;

			private string extInfo;

			private string intentionAssignBizId;

			private string intentionBizId;

			private string partnerCode;

			private string reason;

			private int? status;

			private long? updateTime;

			private string userId;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

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

			public long? CreateTime
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

			public string DeliveryOrderBizId
			{
				get
				{
					return deliveryOrderBizId;
				}
				set	
				{
					deliveryOrderBizId = value;
				}
			}

			public string ExtInfo
			{
				get
				{
					return extInfo;
				}
				set	
				{
					extInfo = value;
				}
			}

			public string IntentionAssignBizId
			{
				get
				{
					return intentionAssignBizId;
				}
				set	
				{
					intentionAssignBizId = value;
				}
			}

			public string IntentionBizId
			{
				get
				{
					return intentionBizId;
				}
				set	
				{
					intentionBizId = value;
				}
			}

			public string PartnerCode
			{
				get
				{
					return partnerCode;
				}
				set	
				{
					partnerCode = value;
				}
			}

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

			public int? Status
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

			public long? UpdateTime
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

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}
		}
	}
}
