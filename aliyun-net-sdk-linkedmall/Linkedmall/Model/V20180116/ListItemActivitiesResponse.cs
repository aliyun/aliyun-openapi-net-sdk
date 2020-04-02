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
	public class ListItemActivitiesResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<ListItemActivities_LmItemActivityModel> lmItemActivityModelList;

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

		public List<ListItemActivities_LmItemActivityModel> LmItemActivityModelList
		{
			get
			{
				return lmItemActivityModelList;
			}
			set	
			{
				lmItemActivityModelList = value;
			}
		}

		public class ListItemActivities_LmItemActivityModel
		{

			private long? itemId;

			private string lmItemId;

			private ListItemActivities_LmActivityPopModel lmActivityPopModel;

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

			public ListItemActivities_LmActivityPopModel LmActivityPopModel
			{
				get
				{
					return lmActivityPopModel;
				}
				set	
				{
					lmActivityPopModel = value;
				}
			}

			public class ListItemActivities_LmActivityPopModel
			{

				private long? id;

				private string bizId;

				private string subBizCode;

				private string title;

				private string displayDate;

				private string startDate;

				private string endDate;

				private string extInfo;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
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
