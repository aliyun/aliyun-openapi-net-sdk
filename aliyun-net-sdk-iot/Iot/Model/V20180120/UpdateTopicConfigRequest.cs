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
    public class UpdateTopicConfigRequest : RpcAcsRequest<UpdateTopicConfigResponse>
    {
        public UpdateTopicConfigRequest()
            : base("Iot", "2018-01-20", "UpdateTopicConfig", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string iotInstanceId;

		private string topicFullName;

		private bool? enableBroadcast;

		private bool? enableProxySubscribe;

		private string productKey;

		private string codec;

		private string operation;

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public string TopicFullName
		{
			get
			{
				return topicFullName;
			}
			set	
			{
				topicFullName = value;
				DictionaryUtil.Add(QueryParameters, "TopicFullName", value);
			}
		}

		public bool? EnableBroadcast
		{
			get
			{
				return enableBroadcast;
			}
			set	
			{
				enableBroadcast = value;
				DictionaryUtil.Add(QueryParameters, "EnableBroadcast", value.ToString());
			}
		}

		public bool? EnableProxySubscribe
		{
			get
			{
				return enableProxySubscribe;
			}
			set	
			{
				enableProxySubscribe = value;
				DictionaryUtil.Add(QueryParameters, "EnableProxySubscribe", value.ToString());
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

		public string Codec
		{
			get
			{
				return codec;
			}
			set	
			{
				codec = value;
				DictionaryUtil.Add(QueryParameters, "Codec", value);
			}
		}

		public string Operation
		{
			get
			{
				return operation;
			}
			set	
			{
				operation = value;
				DictionaryUtil.Add(QueryParameters, "Operation", value);
			}
		}

        public override UpdateTopicConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTopicConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
