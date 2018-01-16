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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class QueryMediaListRequest : RpcAcsRequest<QueryMediaListResponse>
    {
        public QueryMediaListRequest()
            : base("Mts", "2014-06-18", "QueryMediaList", "mts", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private bool? includeSnapshotList;

		private string ownerAccount;

		private string action;

		private string mediaIds;

		private long? ownerId;

		private bool? includePlayList;

		private string accessKeyId;

		private bool? includeMediaInfo;

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

		public bool? IncludeSnapshotList
		{
			get
			{
				return includeSnapshotList;
			}
			set	
			{
				includeSnapshotList = value;
				DictionaryUtil.Add(QueryParameters, "IncludeSnapshotList", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string MediaIds
		{
			get
			{
				return mediaIds;
			}
			set	
			{
				mediaIds = value;
				DictionaryUtil.Add(QueryParameters, "MediaIds", value);
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

		public bool? IncludePlayList
		{
			get
			{
				return includePlayList;
			}
			set	
			{
				includePlayList = value;
				DictionaryUtil.Add(QueryParameters, "IncludePlayList", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public bool? IncludeMediaInfo
		{
			get
			{
				return includeMediaInfo;
			}
			set	
			{
				includeMediaInfo = value;
				DictionaryUtil.Add(QueryParameters, "IncludeMediaInfo", value.ToString());
			}
		}

        public override QueryMediaListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryMediaListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}