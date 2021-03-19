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
using Aliyun.Acs.Ons.Transform;
using Aliyun.Acs.Ons.Transform.V20190214;

namespace Aliyun.Acs.Ons.Model.V20190214
{
    public class OnsMqttQueryMsgTransTrendRequest : RpcAcsRequest<OnsMqttQueryMsgTransTrendResponse>
    {
        public OnsMqttQueryMsgTransTrendRequest()
            : base("Ons", "2019-02-14", "OnsMqttQueryMsgTransTrend", "ons", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ons.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ons.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string transType;

		private long? endTime;

		private long? beginTime;

		private string tpsType;

		private string parentTopic;

		private string instanceId;

		private int? qos;

		private string msgType;

		private string subTopic;

		public string TransType
		{
			get
			{
				return transType;
			}
			set	
			{
				transType = value;
				DictionaryUtil.Add(QueryParameters, "TransType", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginTime", value.ToString());
			}
		}

		public string TpsType
		{
			get
			{
				return tpsType;
			}
			set	
			{
				tpsType = value;
				DictionaryUtil.Add(QueryParameters, "TpsType", value);
			}
		}

		public string ParentTopic
		{
			get
			{
				return parentTopic;
			}
			set	
			{
				parentTopic = value;
				DictionaryUtil.Add(QueryParameters, "ParentTopic", value);
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

		public int? Qos
		{
			get
			{
				return qos;
			}
			set	
			{
				qos = value;
				DictionaryUtil.Add(QueryParameters, "Qos", value.ToString());
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

		public string SubTopic
		{
			get
			{
				return subTopic;
			}
			set	
			{
				subTopic = value;
				DictionaryUtil.Add(QueryParameters, "SubTopic", value);
			}
		}

        public override OnsMqttQueryMsgTransTrendResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OnsMqttQueryMsgTransTrendResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
