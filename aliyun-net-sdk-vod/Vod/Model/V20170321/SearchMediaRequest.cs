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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class SearchMediaRequest : RpcAcsRequest<SearchMediaResponse>
    {
        public SearchMediaRequest()
            : base("vod", "2017-03-21", "SearchMedia", "vod", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private int? pageNo;

		private string searchType;

		private string match;

		private int? pageSize;

		private string action;

		private string sortBy;

		private string sessionId;

		private long? ownerId;

		private string fields;

		private string scrollToken;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
			}
		}

		public string SearchType
		{
			get
			{
				return searchType;
			}
			set	
			{
				searchType = value;
				DictionaryUtil.Add(QueryParameters, "SearchType", value);
			}
		}

		public string Match
		{
			get
			{
				return match;
			}
			set	
			{
				match = value;
				DictionaryUtil.Add(QueryParameters, "Match", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string SortBy
		{
			get
			{
				return sortBy;
			}
			set	
			{
				sortBy = value;
				DictionaryUtil.Add(QueryParameters, "SortBy", value);
			}
		}

		public string SessionId
		{
			get
			{
				return sessionId;
			}
			set	
			{
				sessionId = value;
				DictionaryUtil.Add(QueryParameters, "SessionId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Fields
		{
			get
			{
				return fields;
			}
			set	
			{
				fields = value;
				DictionaryUtil.Add(QueryParameters, "Fields", value);
			}
		}

		public string ScrollToken
		{
			get
			{
				return scrollToken;
			}
			set	
			{
				scrollToken = value;
				DictionaryUtil.Add(QueryParameters, "ScrollToken", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchMediaResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SearchMediaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}