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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeDingTalkResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDingTalk_ActionListArr> actionList;

		private DescribeDingTalk_PageInfo pageInfo;

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

		public List<DescribeDingTalk_ActionListArr> ActionList
		{
			get
			{
				return actionList;
			}
			set	
			{
				actionList = value;
			}
		}

		public DescribeDingTalk_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeDingTalk_ActionListArr
		{

			private int? status;

			private string configList;

			private long? gmtCreate;

			private string actionName;

			private string url;

			private long? aliUid;

			private string dingTalkLang;

			private int? intervalTime;

			private long? gmtModified;

			private string groupIdList;

			private int? id;

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

			public string ConfigList
			{
				get
				{
					return configList;
				}
				set	
				{
					configList = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string ActionName
			{
				get
				{
					return actionName;
				}
				set	
				{
					actionName = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string DingTalkLang
			{
				get
				{
					return dingTalkLang;
				}
				set	
				{
					dingTalkLang = value;
				}
			}

			public int? IntervalTime
			{
				get
				{
					return intervalTime;
				}
				set	
				{
					intervalTime = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string GroupIdList
			{
				get
				{
					return groupIdList;
				}
				set	
				{
					groupIdList = value;
				}
			}

			public int? Id
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
		}

		public class DescribeDingTalk_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? TotalCount
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
		}
	}
}
