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
    public class SendMessageRequest : RpcAcsRequest<SendMessageResponse>
    {
        public SendMessageRequest()
            : base("avatar", "2022-01-30", "SendMessage")
        {
			Method = MethodType.POST;
        }

		private bool? feedback;

		private StreamExtension streamExtension_;

		private string textRequest;

		private long? tenantId;

		private VAMLRequest vAMLRequest_;

		private string sessionId;

		[JsonProperty(PropertyName = "Feedback")]
		public bool? Feedback
		{
			get
			{
				return feedback;
			}
			set	
			{
				feedback = value;
				DictionaryUtil.Add(QueryParameters, "Feedback", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "StreamExtension")]
		public StreamExtension StreamExtension_
		{
			get
			{
				return streamExtension_;
			}

			set
			{
				streamExtension_ = value;
				DictionaryUtil.Add(QueryParameters, "StreamExtension", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "TextRequest")]
		public string TextRequest
		{
			get
			{
				return textRequest;
			}
			set	
			{
				textRequest = value;
				DictionaryUtil.Add(QueryParameters, "TextRequest", value);
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

		[JsonProperty(PropertyName = "VAMLRequest")]
		public VAMLRequest VAMLRequest_
		{
			get
			{
				return vAMLRequest_;
			}

			set
			{
				vAMLRequest_ = value;
				DictionaryUtil.Add(QueryParameters, "VAMLRequest", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "SessionId")]
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

		public class StreamExtension
		{

			private bool? isStream;

			private int? index;

			private string position;

			[JsonProperty(PropertyName = "IsStream")]
			public bool? IsStream
			{
				get
				{
					return isStream;
				}
				set	
				{
					isStream = value;
				}
			}

			[JsonProperty(PropertyName = "Index")]
			public int? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			[JsonProperty(PropertyName = "Position")]
			public string Position
			{
				get
				{
					return position;
				}
				set	
				{
					position = value;
				}
			}
		}

		public class VAMLRequest
		{

			private string code;

			private string vaml;

			[JsonProperty(PropertyName = "Code")]
			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			[JsonProperty(PropertyName = "Vaml")]
			public string Vaml
			{
				get
				{
					return vaml;
				}
				set	
				{
					vaml = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendMessageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendMessageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
