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
using Aliyun.Acs.Iot.Transform.V20180120;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class UpdateRuleActionRequest : RpcAcsRequest<UpdateRuleActionResponse>
    {
        public UpdateRuleActionRequest()
            : base("Iot", "2018-01-20", "UpdateRuleAction", "iot", "openAPI")
        {
        }

		private string configuration;

		private string iotInstanceId;

		private long? actionId;

		private string type;

		private string accessKeyId;

		public string Configuration
		{
			get
			{
				return configuration;
			}
			set	
			{
				configuration = value;
				DictionaryUtil.Add(QueryParameters, "Configuration", value);
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

		public long? ActionId
		{
			get
			{
				return actionId;
			}
			set	
			{
				actionId = value;
				DictionaryUtil.Add(QueryParameters, "ActionId", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override UpdateRuleActionResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateRuleActionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}