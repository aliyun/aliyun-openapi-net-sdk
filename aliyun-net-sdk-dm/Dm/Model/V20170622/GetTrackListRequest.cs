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
using Aliyun.Acs.Dm.Transform;
using Aliyun.Acs.Dm.Transform.V20170622;

namespace Aliyun.Acs.Dm.Model.V20170622
{
    public class GetTrackListRequest : RpcAcsRequest<GetTrackListResponse>
    {
        public GetTrackListRequest()
            : base("Dm", "2017-06-22", "GetTrackList", "dm", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string offsetCreateTimeDesc;

		private string offset;

		private string resourceOwnerAccount;

		private string endTime;

		private string startTime;

		private long? ownerId;

		private string pageNumber;

		private string accessKeyId;

		private string total;

		private string offsetCreateTime;

		private string pageSize;

		private string action;

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

		public string OffsetCreateTimeDesc
		{
			get
			{
				return offsetCreateTimeDesc;
			}
			set	
			{
				offsetCreateTimeDesc = value;
				DictionaryUtil.Add(QueryParameters, "OffsetCreateTimeDesc", value);
			}
		}

		public string Offset
		{
			get
			{
				return offset;
			}
			set	
			{
				offset = value;
				DictionaryUtil.Add(QueryParameters, "Offset", value);
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value);
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

		public string Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
				DictionaryUtil.Add(QueryParameters, "Total", value);
			}
		}

		public string OffsetCreateTime
		{
			get
			{
				return offsetCreateTime;
			}
			set	
			{
				offsetCreateTime = value;
				DictionaryUtil.Add(QueryParameters, "OffsetCreateTime", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
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

        public override GetTrackListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTrackListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
