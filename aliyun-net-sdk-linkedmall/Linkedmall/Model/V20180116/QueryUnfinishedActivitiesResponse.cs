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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryUnfinishedActivitiesResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? pageSize;

		private long? pageNumber;

		private long? totalCount;

		private List<QueryUnfinishedActivities_LmActivityModelV2Ext> lmActivityModelExtList;

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

		public long? PageSize
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

		public long? PageNumber
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

		public List<QueryUnfinishedActivities_LmActivityModelV2Ext> LmActivityModelExtList
		{
			get
			{
				return lmActivityModelExtList;
			}
			set	
			{
				lmActivityModelExtList = value;
			}
		}

		public class QueryUnfinishedActivities_LmActivityModelV2Ext
		{

			private string startDate;

			private string name;

			private long? lmActivityId;

			private string endDate;

			private string description;

			private string bizId;

			private string activityPicUrl;

			private List<QueryUnfinishedActivities_LmActivitySessionModel> lmActivitySessionModels;

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
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

			public long? LmActivityId
			{
				get
				{
					return lmActivityId;
				}
				set	
				{
					lmActivityId = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

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

			public string ActivityPicUrl
			{
				get
				{
					return activityPicUrl;
				}
				set	
				{
					activityPicUrl = value;
				}
			}

			public List<QueryUnfinishedActivities_LmActivitySessionModel> LmActivitySessionModels
			{
				get
				{
					return lmActivitySessionModels;
				}
				set	
				{
					lmActivitySessionModels = value;
				}
			}

			public class QueryUnfinishedActivities_LmActivitySessionModel
			{

				private long? lmActivityId;

				private long? lmSessionId;

				private string name;

				private string description;

				private string bizId;

				private string subBizCode;

				private string displayDate;

				private string startDate;

				private string endDate;

				private string extInfo;

				public long? LmActivityId
				{
					get
					{
						return lmActivityId;
					}
					set	
					{
						lmActivityId = value;
					}
				}

				public long? LmSessionId
				{
					get
					{
						return lmSessionId;
					}
					set	
					{
						lmSessionId = value;
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

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

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

				public string SubBizCode
				{
					get
					{
						return subBizCode;
					}
					set	
					{
						subBizCode = value;
					}
				}

				public string DisplayDate
				{
					get
					{
						return displayDate;
					}
					set	
					{
						displayDate = value;
					}
				}

				public string StartDate
				{
					get
					{
						return startDate;
					}
					set	
					{
						startDate = value;
					}
				}

				public string EndDate
				{
					get
					{
						return endDate;
					}
					set	
					{
						endDate = value;
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
			}
		}
	}
}
