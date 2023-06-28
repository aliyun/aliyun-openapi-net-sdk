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

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcOperationBiddingResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcOperationBidding_DataItem> data;

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

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

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

		public List<GetOcOperationBidding_DataItem> Data
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

		public class GetOcOperationBidding_DataItem
		{

			private string entName;

			private string bidTitle;

			private string bidType;

			private string regionName;

			private string bidIndustry;

			private string publicDate;

			private string projectNum;

			private string projectName;

			private string projectAmount;

			private string tenderEntName;

			private string agentEntName;

			private string winnerEntName;

			private string content;

			private string infoType;

			private string subType;

			private string openingTime;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
				}
			}

			public string BidTitle
			{
				get
				{
					return bidTitle;
				}
				set	
				{
					bidTitle = value;
				}
			}

			public string BidType
			{
				get
				{
					return bidType;
				}
				set	
				{
					bidType = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public string BidIndustry
			{
				get
				{
					return bidIndustry;
				}
				set	
				{
					bidIndustry = value;
				}
			}

			public string PublicDate
			{
				get
				{
					return publicDate;
				}
				set	
				{
					publicDate = value;
				}
			}

			public string ProjectNum
			{
				get
				{
					return projectNum;
				}
				set	
				{
					projectNum = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string ProjectAmount
			{
				get
				{
					return projectAmount;
				}
				set	
				{
					projectAmount = value;
				}
			}

			public string TenderEntName
			{
				get
				{
					return tenderEntName;
				}
				set	
				{
					tenderEntName = value;
				}
			}

			public string AgentEntName
			{
				get
				{
					return agentEntName;
				}
				set	
				{
					agentEntName = value;
				}
			}

			public string WinnerEntName
			{
				get
				{
					return winnerEntName;
				}
				set	
				{
					winnerEntName = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string InfoType
			{
				get
				{
					return infoType;
				}
				set	
				{
					infoType = value;
				}
			}

			public string SubType
			{
				get
				{
					return subType;
				}
				set	
				{
					subType = value;
				}
			}

			public string OpeningTime
			{
				get
				{
					return openingTime;
				}
				set	
				{
					openingTime = value;
				}
			}
		}
	}
}
