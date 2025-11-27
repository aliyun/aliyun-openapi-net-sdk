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
using Aliyun.Acs.sophonsoar;
using Aliyun.Acs.sophonsoar.Transform;
using Aliyun.Acs.sophonsoar.Transform.V20220728;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
    public class RunNotifyComponentWithWebhookRequest : RpcAcsRequest<RunNotifyComponentWithWebhookResponse>
    {
        public RunNotifyComponentWithWebhookRequest()
            : base("sophonsoar", "2022-07-28", "RunNotifyComponentWithWebhook")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private long? roleFor;

		private string webhook;

		private string componentName;

		private string secret;

		private string actionName;

		private string content;

		private string nodeName;

		private string playbookUuid;

		private int? assetId;

		private string roleType;

		private string lang;

		private string msgType;

		public long? RoleFor
		{
			get
			{
				return roleFor;
			}
			set	
			{
				roleFor = value;
				DictionaryUtil.Add(QueryParameters, "RoleFor", value.ToString());
			}
		}

		public string Webhook
		{
			get
			{
				return webhook;
			}
			set	
			{
				webhook = value;
				DictionaryUtil.Add(QueryParameters, "Webhook", value);
			}
		}

		public string ComponentName
		{
			get
			{
				return componentName;
			}
			set	
			{
				componentName = value;
				DictionaryUtil.Add(QueryParameters, "ComponentName", value);
			}
		}

		public string Secret
		{
			get
			{
				return secret;
			}
			set	
			{
				secret = value;
				DictionaryUtil.Add(QueryParameters, "Secret", value);
			}
		}

		public string ActionName
		{
			get
			{
				return actionName;
			}
			set	
			{
				actionName = value;
				DictionaryUtil.Add(QueryParameters, "ActionName", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

		public string NodeName
		{
			get
			{
				return nodeName;
			}
			set	
			{
				nodeName = value;
				DictionaryUtil.Add(QueryParameters, "NodeName", value);
			}
		}

		public string PlaybookUuid
		{
			get
			{
				return playbookUuid;
			}
			set	
			{
				playbookUuid = value;
				DictionaryUtil.Add(QueryParameters, "PlaybookUuid", value);
			}
		}

		public int? AssetId
		{
			get
			{
				return assetId;
			}
			set	
			{
				assetId = value;
				DictionaryUtil.Add(QueryParameters, "AssetId", value.ToString());
			}
		}

		public string RoleType
		{
			get
			{
				return roleType;
			}
			set	
			{
				roleType = value;
				DictionaryUtil.Add(QueryParameters, "RoleType", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string MsgType
		{
			get
			{
				return msgType;
			}
			set	
			{
				msgType = value;
				DictionaryUtil.Add(QueryParameters, "MsgType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RunNotifyComponentWithWebhookResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunNotifyComponentWithWebhookResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
