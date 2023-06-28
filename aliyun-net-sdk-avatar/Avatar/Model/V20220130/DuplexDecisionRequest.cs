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
    public class DuplexDecisionRequest : RpcAcsRequest<DuplexDecisionResponse>
    {
        public DuplexDecisionRequest()
            : base("avatar", "2022-01-30", "DuplexDecision")
        {
			Method = MethodType.POST;
        }

		private int? interruptType;

		private List<string> customKeywords = new List<string>(){ };

		private string sessionId;

		private string dialogStatus;

		private DialogContext dialogContext_;

		private int? callTime;

		private string appId;

		private long? tenantId;

		private string text;

		private string bizRequestId;

		[JsonProperty(PropertyName = "InterruptType")]
		public int? InterruptType
		{
			get
			{
				return interruptType;
			}
			set	
			{
				interruptType = value;
				DictionaryUtil.Add(QueryParameters, "InterruptType", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "CustomKeywords")]
		public List<string> CustomKeywords
		{
			get
			{
				return customKeywords;
			}

			set
			{
				customKeywords = value;
				if(customKeywords != null)
				{
					for (int depth1 = 0; depth1 < customKeywords.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"CustomKeywords." + (depth1 + 1), customKeywords[depth1]);
					}
				}
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

		[JsonProperty(PropertyName = "DialogStatus")]
		public string DialogStatus
		{
			get
			{
				return dialogStatus;
			}
			set	
			{
				dialogStatus = value;
				DictionaryUtil.Add(QueryParameters, "DialogStatus", value);
			}
		}

		[JsonProperty(PropertyName = "DialogContext")]
		public DialogContext DialogContext_
		{
			get
			{
				return dialogContext_;
			}

			set
			{
				dialogContext_ = value;
				DictionaryUtil.Add(QueryParameters, "DialogContext", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "CallTime")]
		public int? CallTime
		{
			get
			{
				return callTime;
			}
			set	
			{
				callTime = value;
				DictionaryUtil.Add(QueryParameters, "CallTime", value.ToString());
			}
		}

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
				DictionaryUtil.Add(QueryParameters, "AppId", value);
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

		[JsonProperty(PropertyName = "Text")]
		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(QueryParameters, "Text", value);
			}
		}

		[JsonProperty(PropertyName = "BizRequestId")]
		public string BizRequestId
		{
			get
			{
				return bizRequestId;
			}
			set	
			{
				bizRequestId = value;
				DictionaryUtil.Add(QueryParameters, "BizRequestId", value);
			}
		}

		public class DialogContext
		{

			private List<HistoriesItem> histories = new List<HistoriesItem>(){ };

			private int? curUtteranceIdx;

			[JsonProperty(PropertyName = "Histories")]
			public List<HistoriesItem> Histories
			{
				get
				{
					return histories;
				}
				set	
				{
					histories = value;
				}
			}

			[JsonProperty(PropertyName = "CurUtteranceIdx")]
			public int? CurUtteranceIdx
			{
				get
				{
					return curUtteranceIdx;
				}
				set	
				{
					curUtteranceIdx = value;
				}
			}

			public class HistoriesItem
			{

				private string robot;

				private string user;

				[JsonProperty(PropertyName = "Robot")]
				public string Robot
				{
					get
					{
						return robot;
					}
					set	
					{
						robot = value;
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
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DuplexDecisionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DuplexDecisionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
