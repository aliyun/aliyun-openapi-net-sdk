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
    public class QueryMediaListRequest : RpcAcsRequest<QueryMediaListResponse>
    {
        public QueryMediaListRequest()
            : base("Mts", "2014-06-18", "QueryMediaList")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _mediaIds;

		private bool? _includePlayList;

		private bool? _includeSnapshotList;

		private bool? _includeMediaInfo;

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

		public string MediaIds
		{
			get
			{
				return _mediaIds;
			}
			set	
			{
				_mediaIds = value;
				DictionaryUtil.Add(QueryParameters, "MediaIds", value);
			}
		}

		public bool? IncludePlayList
		{
			get
			{
				return _includePlayList;
			}
			set	
			{
				_includePlayList = value;
				DictionaryUtil.Add(QueryParameters, "IncludePlayList", value.ToString());
			}
		}

		public bool? IncludeSnapshotList
		{
			get
			{
				return _includeSnapshotList;
			}
			set	
			{
				_includeSnapshotList = value;
				DictionaryUtil.Add(QueryParameters, "IncludeSnapshotList", value.ToString());
			}
		}

		public bool? IncludeMediaInfo
		{
			get
			{
				return _includeMediaInfo;
			}
			set	
			{
				_includeMediaInfo = value;
				DictionaryUtil.Add(QueryParameters, "IncludeMediaInfo", value.ToString());
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

        public override QueryMediaListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryMediaListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}