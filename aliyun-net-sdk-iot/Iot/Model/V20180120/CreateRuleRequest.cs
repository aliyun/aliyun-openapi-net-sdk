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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CreateRuleRequest : RpcAcsRequest<CreateRuleResponse>
    {
        public CreateRuleRequest()
            : base("Iot", "2018-01-20", "CreateRule", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string select;

		private string ruleDesc;

		private string shortTopic;

		private string resourceGroupId;

		private string dataType;

		private string iotInstanceId;

		private string _where;

		private int? topicType;

		private string productKey;

		private string name;

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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string DataType
		{
			get
			{
				return dataType;
			}
			set	
			{
				dataType = value;
				DictionaryUtil.Add(QueryParameters, "DataType", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string _Where
		{
			get
			{
				return _where;
			}
			set	
			{
				_where = value;
				DictionaryUtil.Add(QueryParameters, "Where", value);
			}
		}

		public int? TopicType
		{
			get
			{
				return topicType;
			}
			set	
			{
				topicType = value;
				DictionaryUtil.Add(QueryParameters, "TopicType", value.ToString());
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
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

        public override CreateRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
