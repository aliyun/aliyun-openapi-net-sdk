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
	public class QueryUnfinishedSessions4ItemsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<QueryUnfinishedSessions4Items_LmItemActivitySessionModelList> lmItemActivitySessionModelListList;

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

		public List<QueryUnfinishedSessions4Items_LmItemActivitySessionModelList> LmItemActivitySessionModelListList
		{
			get
			{
				return lmItemActivitySessionModelListList;
			}
			set	
			{
				lmItemActivitySessionModelListList = value;
			}
		}

		public class QueryUnfinishedSessions4Items_LmItemActivitySessionModelList
		{

			private long? itemId;

			private string lmItemId;

			private List<QueryUnfinishedSessions4Items_LmActivitySessionModel> lmActivitySessionModels;

			public long? ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public string LmItemId
			{
				get
				{
					return lmItemId;
				}
				set	
				{
					lmItemId = value;
				}
			}

			public List<QueryUnfinishedSessions4Items_LmActivitySessionModel> LmActivitySessionModels
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

			public class QueryUnfinishedSessions4Items_LmActivitySessionModel
			{

				private string bizId;

				private string description;

				private string displayDate;

				private string endDate;

				private string extInfo;

				private long? lmActivityId;

				private long? lmSessionId;

				private string name;

				private string startDate;

				private string subBizCode;

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
			}
		}
	}
}
