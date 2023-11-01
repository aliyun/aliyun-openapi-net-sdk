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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.avatar;
using Aliyun.Acs.avatar.Transform;
using Aliyun.Acs.avatar.Transform.V20220130;

namespace Aliyun.Acs.avatar.Model.V20220130
{
    public class SubmitAvatarVideoTaskRequest : RpcAcsRequest<SubmitAvatarVideoTaskResponse>
    {
        public SubmitAvatarVideoTaskRequest()
            : base("avatar", "2022-01-30", "SubmitAvatarVideoTask")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string title;

		private string callbackParams;

		private long? tenantId;

		private string videoParams;

		private App app_;

		private string extParams;

		private bool? callback;

		[JsonProperty(PropertyName = "Title")]
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

		[JsonProperty(PropertyName = "CallbackParams")]
		public string CallbackParams
		{
			get
			{
				return callbackParams;
			}
			set	
			{
				callbackParams = value;
				DictionaryUtil.Add(QueryParameters, "CallbackParams", value);
			}
		}

		[JsonProperty(PropertyName = "TenantId")]
		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(QueryParameters, "TenantId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "VideoParams")]
		public string VideoParams
		{
			get
			{
				return videoParams;
			}
			set	
			{
				videoParams = value;
				DictionaryUtil.Add(QueryParameters, "VideoParams", value);
			}
		}

		[JsonProperty(PropertyName = "App")]
		public App App_
		{
			get
			{
				return app_;
			}

			set
			{
				app_ = value;
				DictionaryUtil.Add(QueryParameters, "App", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "ExtParams")]
		public string ExtParams
		{
			get
			{
				return extParams;
			}
			set	
			{
				extParams = value;
				DictionaryUtil.Add(QueryParameters, "ExtParams", value);
			}
		}

		[JsonProperty(PropertyName = "Callback")]
		public bool? Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
				DictionaryUtil.Add(QueryParameters, "Callback", value.ToString());
			}
		}

		public class App
		{

			private string appId;

			[JsonProperty(PropertyName = "AppId")]
			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitAvatarVideoTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitAvatarVideoTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
