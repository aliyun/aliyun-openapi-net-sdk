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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryTrademarkMonitorResultsResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private bool? prePage;

		private bool? nextPage;

		private List<QueryTrademarkMonitorResults_TmMonitorResult> data;

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

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<QueryTrademarkMonitorResults_TmMonitorResult> Data
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

		public class QueryTrademarkMonitorResults_TmMonitorResult
		{

			private string userId;

			private string ruleId;

			private string tmUid;

			private long? dataCreateTime;

			private long? dataUpdateTime;

			private string tmName;

			private string tmImage;

			private string classification;

			private string registrationNumber;

			private string tmProcedureStatusDesc;

			private string ownerName;

			private string ownerEnName;

			private string applyDate;

			private string xuzhanEndDate;

			private string chesanEndDate;

			private string wuxiaoEndDate;

			private string yiyiEndDate;

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

			public string RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

			public string TmUid
			{
				get
				{
					return tmUid;
				}
				set	
				{
					tmUid = value;
				}
			}

			public long? DataCreateTime
			{
				get
				{
					return dataCreateTime;
				}
				set	
				{
					dataCreateTime = value;
				}
			}

			public long? DataUpdateTime
			{
				get
				{
					return dataUpdateTime;
				}
				set	
				{
					dataUpdateTime = value;
				}
			}

			public string TmName
			{
				get
				{
					return tmName;
				}
				set	
				{
					tmName = value;
				}
			}

			public string TmImage
			{
				get
				{
					return tmImage;
				}
				set	
				{
					tmImage = value;
				}
			}

			public string Classification
			{
				get
				{
					return classification;
				}
				set	
				{
					classification = value;
				}
			}

			public string RegistrationNumber
			{
				get
				{
					return registrationNumber;
				}
				set	
				{
					registrationNumber = value;
				}
			}

			public string TmProcedureStatusDesc
			{
				get
				{
					return tmProcedureStatusDesc;
				}
				set	
				{
					tmProcedureStatusDesc = value;
				}
			}

			public string OwnerName
			{
				get
				{
					return ownerName;
				}
				set	
				{
					ownerName = value;
				}
			}

			public string OwnerEnName
			{
				get
				{
					return ownerEnName;
				}
				set	
				{
					ownerEnName = value;
				}
			}

			public string ApplyDate
			{
				get
				{
					return applyDate;
				}
				set	
				{
					applyDate = value;
				}
			}

			public string XuzhanEndDate
			{
				get
				{
					return xuzhanEndDate;
				}
				set	
				{
					xuzhanEndDate = value;
				}
			}

			public string ChesanEndDate
			{
				get
				{
					return chesanEndDate;
				}
				set	
				{
					chesanEndDate = value;
				}
			}

			public string WuxiaoEndDate
			{
				get
				{
					return wuxiaoEndDate;
				}
				set	
				{
					wuxiaoEndDate = value;
				}
			}

			public string YiyiEndDate
			{
				get
				{
					return yiyiEndDate;
				}
				set	
				{
					yiyiEndDate = value;
				}
			}
		}
	}
}
