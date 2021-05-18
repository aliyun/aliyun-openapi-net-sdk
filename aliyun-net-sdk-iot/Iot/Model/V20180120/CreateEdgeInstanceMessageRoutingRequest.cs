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
    public class CreateEdgeInstanceMessageRoutingRequest : RpcAcsRequest<CreateEdgeInstanceMessageRoutingResponse>
    {
        public CreateEdgeInstanceMessageRoutingRequest()
            : base("Iot", "2018-01-20", "CreateEdgeInstanceMessageRouting", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceData;

		private string targetType;

		private string iotInstanceId;

		private string sourceType;

		private string topicFilter;

		private string instanceId;

		private string targetData;

		private string name;

		private int? targetIotHubQos;

		public string SourceData
		{
			get
			{
				return sourceData;
			}
			set	
			{
				sourceData = value;
				DictionaryUtil.Add(QueryParameters, "SourceData", value);
			}
		}

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
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

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string TopicFilter
		{
			get
			{
				return topicFilter;
			}
			set	
			{
				topicFilter = value;
				DictionaryUtil.Add(QueryParameters, "TopicFilter", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string TargetData
		{
			get
			{
				return targetData;
			}
			set	
			{
				targetData = value;
				DictionaryUtil.Add(QueryParameters, "TargetData", value);
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

		public int? TargetIotHubQos
		{
			get
			{
				return targetIotHubQos;
			}
			set	
			{
				targetIotHubQos = value;
				DictionaryUtil.Add(QueryParameters, "TargetIotHubQos", value.ToString());
			}
		}

        public override CreateEdgeInstanceMessageRoutingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateEdgeInstanceMessageRoutingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
