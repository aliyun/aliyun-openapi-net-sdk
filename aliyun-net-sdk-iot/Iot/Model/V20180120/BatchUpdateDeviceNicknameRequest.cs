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
    public class BatchUpdateDeviceNicknameRequest : RpcAcsRequest<BatchUpdateDeviceNicknameResponse>
    {
        public BatchUpdateDeviceNicknameRequest()
            : base("Iot", "2018-01-20", "BatchUpdateDeviceNickname", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotInstanceId;

		private List<DeviceNicknameInfo> deviceNicknameInfos = new List<DeviceNicknameInfo>(){ };

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

		public List<DeviceNicknameInfo> DeviceNicknameInfos
		{
			get
			{
				return deviceNicknameInfos;
			}

			set
			{
				deviceNicknameInfos = value;
				for (int i = 0; i < deviceNicknameInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DeviceNicknameInfo." + (i + 1) + ".IotId", deviceNicknameInfos[i].IotId);
					DictionaryUtil.Add(QueryParameters,"DeviceNicknameInfo." + (i + 1) + ".Nickname", deviceNicknameInfos[i].Nickname);
					DictionaryUtil.Add(QueryParameters,"DeviceNicknameInfo." + (i + 1) + ".DeviceName", deviceNicknameInfos[i].DeviceName);
					DictionaryUtil.Add(QueryParameters,"DeviceNicknameInfo." + (i + 1) + ".ProductKey", deviceNicknameInfos[i].ProductKey);
				}
			}
		}

		public class DeviceNicknameInfo
		{

			private string iotId;

			private string nickname;

			private string deviceName;

			private string productKey;

			public string IotId
			{
				get
				{
					return iotId;
				}
				set	
				{
					iotId = value;
				}
			}

			public string Nickname
			{
				get
				{
					return nickname;
				}
				set	
				{
					nickname = value;
				}
			}

			public string DeviceName
			{
				get
				{
					return deviceName;
				}
				set	
				{
					deviceName = value;
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
				}
			}
		}

        public override BatchUpdateDeviceNicknameResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchUpdateDeviceNicknameResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
