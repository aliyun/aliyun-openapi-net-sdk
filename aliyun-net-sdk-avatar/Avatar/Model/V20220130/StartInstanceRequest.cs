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
    public class StartInstanceRequest : RpcAcsRequest<StartInstanceResponse>
    {
        public StartInstanceRequest()
            : base("avatar", "2022-01-30", "StartInstance")
        {
			Method = MethodType.POST;
        }

		private string app;

		private long? tenantId;

		private string bizId;

		private Channel channel_;

		private CommandRequest commandRequest_;

		private string user;

		[JsonProperty(PropertyName = "App")]
		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
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

		[JsonProperty(PropertyName = "BizId")]
		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		[JsonProperty(PropertyName = "Channel")]
		public Channel Channel_
		{
			get
			{
				return channel_;
			}

			set
			{
				channel_ = value;
				DictionaryUtil.Add(QueryParameters, "Channel", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "CommandRequest")]
		public CommandRequest CommandRequest_
		{
			get
			{
				return commandRequest_;
			}

			set
			{
				commandRequest_ = value;
				DictionaryUtil.Add(QueryParameters, "CommandRequest", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "User")]
		public string User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
				DictionaryUtil.Add(QueryParameters, "User", value);
			}
		}

		public class Channel
		{

			private string type;

			private Dictionary<string, string> reqConfig;

			[JsonProperty(PropertyName = "Type")]
			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			[JsonProperty(PropertyName = "ReqConfig")]
			public Dictionary<string, string> ReqConfig
			{
				get
				{
					return reqConfig;
				}
				set	
				{
					reqConfig = value;
				}
			}
		}

		public class CommandRequest
		{

			private bool? alphaSwitch;

			[JsonProperty(PropertyName = "AlphaSwitch")]
			public bool? AlphaSwitch
			{
				get
				{
					return alphaSwitch;
				}
				set	
				{
					alphaSwitch = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override StartInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
