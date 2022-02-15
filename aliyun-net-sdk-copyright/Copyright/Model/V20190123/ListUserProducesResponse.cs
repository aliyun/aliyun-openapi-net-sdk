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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class ListUserProducesResponse : AcsResponse
	{

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private bool? success;

		private int? totalItemNum;

		private int? totalPageNum;

		private List<ListUserProduces_Produces> data;

		public int? PageNum
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

		public List<ListUserProduces_Produces> Data
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

		public class ListUserProduces_Produces
		{

			private string bizId;

			private string bizType;

			private string endTime;

			private string extInfo;

			private string intentionBizId;

			private string modifyTime;

			private string orderId;

			private string orderPrice;

			private string orderTime;

			private string partnerCode;

			private string solutionBizId;

			private string startTime;

			private int? status;

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

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string OrderPrice
			{
				get
				{
					return orderPrice;
				}
				set	
				{
					orderPrice = value;
				}
			}

			public string OrderTime
			{
				get
				{
					return orderTime;
				}
				set	
				{
					orderTime = value;
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

			public string SolutionBizId
			{
				get
				{
					return solutionBizId;
				}
				set	
				{
					solutionBizId = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
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
