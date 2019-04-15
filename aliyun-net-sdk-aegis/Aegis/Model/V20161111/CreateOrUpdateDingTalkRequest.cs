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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class CreateOrUpdateDingTalkRequest : RpcAcsRequest<CreateOrUpdateDingTalkResponse>
    {
        public CreateOrUpdateDingTalkRequest()
            : base("aegis", "2016-11-11", "CreateOrUpdateDingTalk", "vipaegis", "openAPI")
        {
        }

		private string ruleActionName;

		private string sourceIp;

		private string sendUrl;

		private long? id;

		private long? intervalTime;

		public string RuleActionName
		{
			get
			{
				return ruleActionName;
			}
			set	
			{
				ruleActionName = value;
				DictionaryUtil.Add(QueryParameters, "RuleActionName", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string SendUrl
		{
			get
			{
				return sendUrl;
			}
			set	
			{
				sendUrl = value;
				DictionaryUtil.Add(QueryParameters, "SendUrl", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public long? IntervalTime
		{
			get
			{
				return intervalTime;
			}
			set	
			{
				intervalTime = value;
				DictionaryUtil.Add(QueryParameters, "IntervalTime", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOrUpdateDingTalkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrUpdateDingTalkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
