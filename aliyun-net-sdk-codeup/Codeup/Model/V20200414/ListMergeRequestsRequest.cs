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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.codeup;
using Aliyun.Acs.codeup.Transform;
using Aliyun.Acs.codeup.Transform.V20200414;

namespace Aliyun.Acs.codeup.Model.V20200414
{
    public class ListMergeRequestsRequest : RoaAcsRequest<ListMergeRequestsResponse>
    {
        public ListMergeRequestsRequest()
            : base("codeup", "2020-04-14", "ListMergeRequests")
        {
			UriPattern = "/api/v4/merge_requests/advanced_search";
			Method = MethodType.GET;
        }

		private string beforeDate;

		private string assigneeIdList;

		private string accessToken;

		private string subscriberCodeupIdList;

		private string afterDate;

		private string organizationId;

		private string groupIdList;

		private string search;

		private string authorCodeupIdList;

		private string authorIdList;

		private long? pageSize;

		private string projectIdList;

		private long? page;

		private string assigneeCodeupIdList;

		private string state;

		private string order;

		public string BeforeDate
		{
			get
			{
				return beforeDate;
			}
			set	
			{
				beforeDate = value;
				DictionaryUtil.Add(QueryParameters, "BeforeDate", value);
			}
		}

		public string AssigneeIdList
		{
			get
			{
				return assigneeIdList;
			}
			set	
			{
				assigneeIdList = value;
				DictionaryUtil.Add(QueryParameters, "AssigneeIdList", value);
			}
		}

		public string AccessToken
		{
			get
			{
				return accessToken;
			}
			set	
			{
				accessToken = value;
				DictionaryUtil.Add(QueryParameters, "AccessToken", value);
			}
		}

		public string SubscriberCodeupIdList
		{
			get
			{
				return subscriberCodeupIdList;
			}
			set	
			{
				subscriberCodeupIdList = value;
				DictionaryUtil.Add(QueryParameters, "SubscriberCodeupIdList", value);
			}
		}

		public string AfterDate
		{
			get
			{
				return afterDate;
			}
			set	
			{
				afterDate = value;
				DictionaryUtil.Add(QueryParameters, "AfterDate", value);
			}
		}

		public string OrganizationId
		{
			get
			{
				return organizationId;
			}
			set	
			{
				organizationId = value;
				DictionaryUtil.Add(QueryParameters, "OrganizationId", value);
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
				DictionaryUtil.Add(QueryParameters, "GroupIdList", value);
			}
		}

		public string Search
		{
			get
			{
				return search;
			}
			set	
			{
				search = value;
				DictionaryUtil.Add(QueryParameters, "Search", value);
			}
		}

		public string AuthorCodeupIdList
		{
			get
			{
				return authorCodeupIdList;
			}
			set	
			{
				authorCodeupIdList = value;
				DictionaryUtil.Add(QueryParameters, "AuthorCodeupIdList", value);
			}
		}

		public string AuthorIdList
		{
			get
			{
				return authorIdList;
			}
			set	
			{
				authorIdList = value;
				DictionaryUtil.Add(QueryParameters, "AuthorIdList", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string ProjectIdList
		{
			get
			{
				return projectIdList;
			}
			set	
			{
				projectIdList = value;
				DictionaryUtil.Add(QueryParameters, "ProjectIdList", value);
			}
		}

		public long? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "Page", value.ToString());
			}
		}

		public string AssigneeCodeupIdList
		{
			get
			{
				return assigneeCodeupIdList;
			}
			set	
			{
				assigneeCodeupIdList = value;
				DictionaryUtil.Add(QueryParameters, "AssigneeCodeupIdList", value);
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListMergeRequestsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListMergeRequestsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
