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
    public class RegisterDeviceRequest : RpcAcsRequest<RegisterDeviceResponse>
    {
        public RegisterDeviceRequest()
            : base("Iot", "2018-01-20", "RegisterDevice", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string loraNodeType;

		private string iotInstanceId;

		private string nickname;

		private string pinCode;

		private string productKey;

		private string devEui;

		private string joinEui;

		private string deviceName;

		private string appKey;

		public string LoraNodeType
		{
			get
			{
				return loraNodeType;
			}
			set	
			{
				loraNodeType = value;
				DictionaryUtil.Add(QueryParameters, "LoraNodeType", value);
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

		public string Nickname
		{
			get
			{
				return nickname;
			}
			set	
			{
				nickname = value;
				DictionaryUtil.Add(QueryParameters, "Nickname", value);
			}
		}

		public string PinCode
		{
			get
			{
				return pinCode;
			}
			set	
			{
				pinCode = value;
				DictionaryUtil.Add(QueryParameters, "PinCode", value);
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

		public string DevEui
		{
			get
			{
				return devEui;
			}
			set	
			{
				devEui = value;
				DictionaryUtil.Add(QueryParameters, "DevEui", value);
			}
		}

		public string JoinEui
		{
			get
			{
				return joinEui;
			}
			set	
			{
				joinEui = value;
				DictionaryUtil.Add(QueryParameters, "JoinEui", value);
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
				DictionaryUtil.Add(QueryParameters, "DeviceName", value);
			}
		}

		public string AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value);
			}
		}

        public override RegisterDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegisterDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
