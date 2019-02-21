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
    public class BatchAddDeviceGroupRelationsRequest : RpcAcsRequest<BatchAddDeviceGroupRelationsResponse>
    {
        public BatchAddDeviceGroupRelationsRequest()
            : base("Iot", "2018-01-20", "BatchAddDeviceGroupRelations", "iot", "openAPI")
        {
        }

		private string iotInstanceId;

		private string groupId;

		private List<Device> devices;

		private string accessKeyId;

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

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public List<Device> Devices
		{
			get
			{
				return devices;
			}

			set
			{
				devices = value;
				for (int i = 0; i < devices.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Device." + (i + 1) + ".DeviceName", devices[i].DeviceName);
					DictionaryUtil.Add(QueryParameters,"Device." + (i + 1) + ".ProductKey", devices[i].ProductKey);
				}
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

		public class Device
		{

			private string deviceName;

			private string productKey;

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

        public override BatchAddDeviceGroupRelationsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return BatchAddDeviceGroupRelationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}