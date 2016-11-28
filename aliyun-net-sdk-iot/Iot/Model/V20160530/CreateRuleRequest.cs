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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20160530;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20160530
{
    public class CreateRuleRequest : RpcAcsRequest<CreateRuleResponse>
    {
        public CreateRuleRequest()
            : base("Iot", "2016-05-30", "CreateRule")
        {
        }

		private string select;

		private string shortTopic;

		private string where;

		private long? productKey;

		private string name;

		private string ruleDesc;

		public string Select
		{
			get
			{
				return select;
			}
			set	
			{
				select = value;
				DictionaryUtil.Add(QueryParameters, "Select", value);
			}
		}

		public string ShortTopic
		{
			get
			{
				return shortTopic;
			}
			set	
			{
				shortTopic = value;
				DictionaryUtil.Add(QueryParameters, "ShortTopic", value);
			}
		}

		public string Where
		{
			get
			{
				return where;
			}
			set	
			{
				where = value;
				DictionaryUtil.Add(QueryParameters, "Where", value);
			}
		}

		public long? ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string RuleDesc
		{
			get
			{
				return ruleDesc;
			}
			set	
			{
				ruleDesc = value;
				DictionaryUtil.Add(QueryParameters, "RuleDesc", value);
			}
		}

        public override CreateRuleResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}