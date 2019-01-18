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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class PutEventTargetsRequest : RpcAcsRequest<PutEventTargetsResponse>
    {
        public PutEventTargetsRequest()
            : base("Cms", "2018-03-08", "PutEventTargets", "cms", "openAPI")
        {
        }

		private List<WebhookParameters> webhookParameterss;

		private List<ContactParameters> contactParameterss;

		private List<FcParameters> fcParameterss;

		private string ruleName;

		private List<MnsParameters> mnsParameterss;

		public List<WebhookParameters> WebhookParameterss
		{
			get
			{
				return webhookParameterss;
			}

			set
			{
				webhookParameterss = value;
				for (int i = 0; i < webhookParameterss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"WebhookParameters." + (i + 1) + ".Id", webhookParameterss[i].Id);
					DictionaryUtil.Add(QueryParameters,"WebhookParameters." + (i + 1) + ".Protocol", webhookParameterss[i].Protocol);
					DictionaryUtil.Add(QueryParameters,"WebhookParameters." + (i + 1) + ".Url", webhookParameterss[i].Url);
					DictionaryUtil.Add(QueryParameters,"WebhookParameters." + (i + 1) + ".Method", webhookParameterss[i].Method);
				}
			}
		}

		public List<ContactParameters> ContactParameterss
		{
			get
			{
				return contactParameterss;
			}

			set
			{
				contactParameterss = value;
				for (int i = 0; i < contactParameterss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ContactParameters." + (i + 1) + ".Id", contactParameterss[i].Id);
					DictionaryUtil.Add(QueryParameters,"ContactParameters." + (i + 1) + ".ContactGroupName", contactParameterss[i].ContactGroupName);
					DictionaryUtil.Add(QueryParameters,"ContactParameters." + (i + 1) + ".Level", contactParameterss[i].Level);
				}
			}
		}

		public List<FcParameters> FcParameterss
		{
			get
			{
				return fcParameterss;
			}

			set
			{
				fcParameterss = value;
				for (int i = 0; i < fcParameterss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"FcParameters." + (i + 1) + ".Id", fcParameterss[i].Id);
					DictionaryUtil.Add(QueryParameters,"FcParameters." + (i + 1) + ".Region", fcParameterss[i].Region);
					DictionaryUtil.Add(QueryParameters,"FcParameters." + (i + 1) + ".ServiceName", fcParameterss[i].ServiceName);
					DictionaryUtil.Add(QueryParameters,"FcParameters." + (i + 1) + ".FunctionName", fcParameterss[i].FunctionName);
				}
			}
		}

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(QueryParameters, "RuleName", value);
			}
		}

		public List<MnsParameters> MnsParameterss
		{
			get
			{
				return mnsParameterss;
			}

			set
			{
				mnsParameterss = value;
				for (int i = 0; i < mnsParameterss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MnsParameters." + (i + 1) + ".Id", mnsParameterss[i].Id);
					DictionaryUtil.Add(QueryParameters,"MnsParameters." + (i + 1) + ".Region", mnsParameterss[i].Region);
					DictionaryUtil.Add(QueryParameters,"MnsParameters." + (i + 1) + ".Queue", mnsParameterss[i].Queue);
				}
			}
		}

		public class WebhookParameters
		{

			private string id;

			private string protocol;

			private string url;

			private string method;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string Method
			{
				get
				{
					return method;
				}
				set	
				{
					method = value;
				}
			}
		}

		public class ContactParameters
		{

			private string id;

			private string contactGroupName;

			private string level;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ContactGroupName
			{
				get
				{
					return contactGroupName;
				}
				set	
				{
					contactGroupName = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}
		}

		public class FcParameters
		{

			private string id;

			private string region;

			private string serviceName;

			private string functionName;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string FunctionName
			{
				get
				{
					return functionName;
				}
				set	
				{
					functionName = value;
				}
			}
		}

		public class MnsParameters
		{

			private string id;

			private string region;

			private string queue;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Queue
			{
				get
				{
					return queue;
				}
				set	
				{
					queue = value;
				}
			}
		}

        public override PutEventTargetsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PutEventTargetsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}