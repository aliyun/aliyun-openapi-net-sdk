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
    public class GetVideoPlayInfoRequest : RpcAcsRequest<GetVideoPlayInfoResponse>
    {
        public GetVideoPlayInfoRequest()
            : base("vod", "2017-03-21", "GetVideoPlayInfo")
        {
        }

		private string clientVersion;

		private string signVersion;

		private string accessKeyId;

		private string resourceOwnerAccount;

		private long? clientTS;

		private string action;

		private long? resourceOwnerId;

		private long? ownerId;

		private string videoId;

		private string channel;

		private string playSign;

		public string ClientVersion
		{
			get
			{
				return clientVersion;
			}
			set	
			{
				clientVersion = value;
				DictionaryUtil.Add(QueryParameters, "ClientVersion", value);
			}
		}

		public string SignVersion
		{
			get
			{
				return signVersion;
			}
			set	
			{
				signVersion = value;
				DictionaryUtil.Add(QueryParameters, "SignVersion", value);
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

		public long? ClientTS
		{
			get
			{
				return clientTS;
			}
			set	
			{
				clientTS = value;
				DictionaryUtil.Add(QueryParameters, "ClientTS", value.ToString());
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

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public string PlaySign
		{
			get
			{
				return playSign;
			}
			set	
			{
				playSign = value;
				DictionaryUtil.Add(QueryParameters, "PlaySign", value);
			}
		}

        public override GetVideoPlayInfoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetVideoPlayInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}