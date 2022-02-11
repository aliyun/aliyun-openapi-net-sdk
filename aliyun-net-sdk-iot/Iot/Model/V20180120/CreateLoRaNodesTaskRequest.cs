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
    public class CreateLoRaNodesTaskRequest : RpcAcsRequest<CreateLoRaNodesTaskResponse>
    {
        public CreateLoRaNodesTaskRequest()
            : base("Iot", "2018-01-20", "CreateLoRaNodesTask", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotInstanceId;

		private List<DeviceInfo> deviceInfos = new List<DeviceInfo>(){ };

		private string productKey;

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

		public List<DeviceInfo> DeviceInfos
		{
			get
			{
				return deviceInfos;
			}

			set
			{
				deviceInfos = value;
				for (int i = 0; i < deviceInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DeviceInfo." + (i + 1) + ".PinCode", deviceInfos[i].PinCode);
					DictionaryUtil.Add(QueryParameters,"DeviceInfo." + (i + 1) + ".DevEui", deviceInfos[i].DevEui);
				}
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

		public class DeviceInfo
		{

			private string pinCode;

			private string devEui;

			public string PinCode
			{
				get
				{
					return pinCode;
				}
				set	
				{
					pinCode = value;
				}
			}

			public string DevEui
			{
				get
				{
					return devEui;
				}
				set	
				{
					devEui = value;
				}
			}
		}

        public override CreateLoRaNodesTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLoRaNodesTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
