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
    public class SetEdgeInstanceDriverConfigsRequest : RpcAcsRequest<SetEdgeInstanceDriverConfigsResponse>
    {
        public SetEdgeInstanceDriverConfigsRequest()
            : base("Iot", "2018-01-20", "SetEdgeInstanceDriverConfigs", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Configs> configss = new List<Configs>(){ };

		private string driverId;

		private string iotInstanceId;

		private string instanceId;

		public List<Configs> Configss
		{
			get
			{
				return configss;
			}

			set
			{
				configss = value;
				for (int i = 0; i < configss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Configs." + (i + 1) + ".Format", configss[i].Format);
					DictionaryUtil.Add(QueryParameters,"Configs." + (i + 1) + ".Content", configss[i].Content);
					DictionaryUtil.Add(QueryParameters,"Configs." + (i + 1) + ".Key", configss[i].Key);
				}
			}
		}

		public string DriverId
		{
			get
			{
				return driverId;
			}
			set	
			{
				driverId = value;
				DictionaryUtil.Add(QueryParameters, "DriverId", value);
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

		public class Configs
		{

			private string format;

			private string content;

			private string key;

			public string Format
			{
				get
				{
					return format;
				}
				set	
				{
					format = value;
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
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetEdgeInstanceDriverConfigsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetEdgeInstanceDriverConfigsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
