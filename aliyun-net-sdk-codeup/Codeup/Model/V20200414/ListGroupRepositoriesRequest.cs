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
    public class ListGroupRepositoriesRequest : RoaAcsRequest<ListGroupRepositoriesResponse>
    {
        public ListGroupRepositoriesRequest()
            : base("codeup", "2020-04-14", "ListGroupRepositories")
        {
			UriPattern = "/api/v3/groups/[Identity]/projects";
			Method = MethodType.GET;
        }

		private string accessToken;

		private bool? isMember;

		private string organizationId;

		private string search;

		private string subUserId;

		private string identity;

		private long? pageSize;

		private long? page;

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

		public bool? IsMember
		{
			get
			{
				return isMember;
			}
			set	
			{
				isMember = value;
				DictionaryUtil.Add(QueryParameters, "IsMember", value.ToString());
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

		public string SubUserId
		{
			get
			{
				return subUserId;
			}
			set	
			{
				subUserId = value;
				DictionaryUtil.Add(QueryParameters, "SubUserId", value);
			}
		}

		public string Identity
		{
			get
			{
				return identity;
			}
			set	
			{
				identity = value;
				DictionaryUtil.Add(PathParameters, "Identity", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListGroupRepositoriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListGroupRepositoriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
