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
	public class QueryBestSession4ItemsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<QueryBestSession4Items_LmItemActivitySessionModel> lmItemActivitySessionModelList;

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

		public List<QueryBestSession4Items_LmItemActivitySessionModel> LmItemActivitySessionModelList
		{
			get
			{
				return lmItemActivitySessionModelList;
			}
			set	
			{
				lmItemActivitySessionModelList = value;
			}
		}

		public class QueryBestSession4Items_LmItemActivitySessionModel
		{

			private long? itemId;

			private string lmItemId;

			private QueryBestSession4Items_LmActivitySessionModel lmActivitySessionModel;

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

			public QueryBestSession4Items_LmActivitySessionModel LmActivitySessionModel
			{
				get
				{
					return lmActivitySessionModel;
				}
				set	
				{
					lmActivitySessionModel = value;
				}
			}

			public class QueryBestSession4Items_LmActivitySessionModel
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
