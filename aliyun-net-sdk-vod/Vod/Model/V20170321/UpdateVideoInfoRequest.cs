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
using Aliyun.Acs.Vod.Transform;
using Aliyun.Acs.Vod.Transform.V20170321;
using System.Collections.Generic;

namespace Aliyun.Acs.Vod.Model.V20170321
{
    public class UpdateVideoInfoRequest : RpcAcsRequest<UpdateVideoInfoResponse>
    {
        public UpdateVideoInfoRequest()
            : base("vod", "2017-03-21", "UpdateVideoInfo")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string videoId;

		private string title;

		private string tags;

		private string description;

		private string coverURL;

		private int? cateId;

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

		public string VideoId
		{
			get
			{
				return videoId;
			}
			set	
			{
				videoId = value;
				DictionaryUtil.Add(QueryParameters, "VideoId", value);
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
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string CoverURL
		{
			get
			{
				return coverURL;
			}
			set	
			{
				coverURL = value;
				DictionaryUtil.Add(QueryParameters, "CoverURL", value);
			}
		}

		public int? CateId
		{
			get
			{
				return cateId;
			}
			set	
			{
				cateId = value;
				DictionaryUtil.Add(QueryParameters, "CateId", value.ToString());
			}
		}

        public override UpdateVideoInfoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateVideoInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}