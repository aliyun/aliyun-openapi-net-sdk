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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class SearchMediaRequest : RpcAcsRequest<SearchMediaResponse>
    {
        public SearchMediaRequest()
            : base("Mts", "2014-06-18", "SearchMedia")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _from;

		private string _to;

		private string _keyWord;

		private string _title;

		private string _description;

		private string _tag;

		private string _cateId;

		private string _sortBy;

		private long? _pageSize;

		private long? _pageNumber;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string From
		{
			get
			{
				return _from;
			}
			set	
			{
				_from = value;
				DictionaryUtil.Add(QueryParameters, "From", value);
			}
		}

		public string To
		{
			get
			{
				return _to;
			}
			set	
			{
				_to = value;
				DictionaryUtil.Add(QueryParameters, "To", value);
			}
		}

		public string KeyWord
		{
			get
			{
				return _keyWord;
			}
			set	
			{
				_keyWord = value;
				DictionaryUtil.Add(QueryParameters, "KeyWord", value);
			}
		}

		public string Title
		{
			get
			{
				return _title;
			}
			set	
			{
				_title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string Tag
		{
			get
			{
				return _tag;
			}
			set	
			{
				_tag = value;
				DictionaryUtil.Add(QueryParameters, "Tag", value);
			}
		}

		public string CateId
		{
			get
			{
				return _cateId;
			}
			set	
			{
				_cateId = value;
				DictionaryUtil.Add(QueryParameters, "CateId", value);
			}
		}

		public string SortBy
		{
			get
			{
				return _sortBy;
			}
			set	
			{
				_sortBy = value;
				DictionaryUtil.Add(QueryParameters, "SortBy", value);
			}
		}

		public long? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override SearchMediaResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SearchMediaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}