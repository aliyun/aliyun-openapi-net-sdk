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
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class CreateChannelTokenRequest : RpcAcsRequest<CreateChannelTokenResponse>
    {
        public CreateChannelTokenRequest()
            : base("rtc", "2018-01-11", "CreateChannelToken", "rtc", "openAPI")
        {
        }

		private string sessionId;

		private string uId;

		private string action;

		private long? ownerId;

		private string nonce;

		private string appId;

		private string channelId;

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

		public string UId
		{
			get
			{
				return uId;
			}
			set	
			{
				uId = value;
				DictionaryUtil.Add(QueryParameters, "UId", value);
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

		public string Nonce
		{
			get
			{
				return nonce;
			}
			set	
			{
				nonce = value;
				DictionaryUtil.Add(QueryParameters, "Nonce", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

        public override CreateChannelTokenResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateChannelTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}