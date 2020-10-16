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
    public class UpdateSubscribeRelationRequest : RpcAcsRequest<UpdateSubscribeRelationResponse>
    {
        public UpdateSubscribeRelationRequest()
            : base("Iot", "2018-01-20", "UpdateSubscribeRelation", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? otaEventFlag;

		private bool? deviceTopoLifeCycleFlag;

		private string type;

		private bool? deviceLifeCycleFlag;

		private string iotInstanceId;

		private bool? deviceStatusChangeFlag;

		private bool? otaVersionFlag;

		private bool? deviceTagFlag;

		private List<string> consumerGroupIdss = new List<string>(){ };

		private string productKey;

		private bool? thingHistoryFlag;

		private bool? foundDeviceListFlag;

		private bool? otaJobFlag;

		private bool? deviceDataFlag;

		private string mnsConfiguration;

		public bool? OtaEventFlag
		{
			get
			{
				return otaEventFlag;
			}
			set	
			{
				otaEventFlag = value;
				DictionaryUtil.Add(QueryParameters, "OtaEventFlag", value.ToString());
			}
		}

		public bool? DeviceTopoLifeCycleFlag
		{
			get
			{
				return deviceTopoLifeCycleFlag;
			}
			set	
			{
				deviceTopoLifeCycleFlag = value;
				DictionaryUtil.Add(QueryParameters, "DeviceTopoLifeCycleFlag", value.ToString());
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

		public bool? DeviceLifeCycleFlag
		{
			get
			{
				return deviceLifeCycleFlag;
			}
			set	
			{
				deviceLifeCycleFlag = value;
				DictionaryUtil.Add(QueryParameters, "DeviceLifeCycleFlag", value.ToString());
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

		public bool? DeviceStatusChangeFlag
		{
			get
			{
				return deviceStatusChangeFlag;
			}
			set	
			{
				deviceStatusChangeFlag = value;
				DictionaryUtil.Add(QueryParameters, "DeviceStatusChangeFlag", value.ToString());
			}
		}

		public bool? OtaVersionFlag
		{
			get
			{
				return otaVersionFlag;
			}
			set	
			{
				otaVersionFlag = value;
				DictionaryUtil.Add(QueryParameters, "OtaVersionFlag", value.ToString());
			}
		}

		public bool? DeviceTagFlag
		{
			get
			{
				return deviceTagFlag;
			}
			set	
			{
				deviceTagFlag = value;
				DictionaryUtil.Add(QueryParameters, "DeviceTagFlag", value.ToString());
			}
		}

		public List<string> ConsumerGroupIdss
		{
			get
			{
				return consumerGroupIdss;
			}

			set
			{
				consumerGroupIdss = value;
				for (int i = 0; i < consumerGroupIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ConsumerGroupIds." + (i + 1) , consumerGroupIdss[i]);
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

		public bool? ThingHistoryFlag
		{
			get
			{
				return thingHistoryFlag;
			}
			set	
			{
				thingHistoryFlag = value;
				DictionaryUtil.Add(QueryParameters, "ThingHistoryFlag", value.ToString());
			}
		}

		public bool? FoundDeviceListFlag
		{
			get
			{
				return foundDeviceListFlag;
			}
			set	
			{
				foundDeviceListFlag = value;
				DictionaryUtil.Add(QueryParameters, "FoundDeviceListFlag", value.ToString());
			}
		}

		public bool? OtaJobFlag
		{
			get
			{
				return otaJobFlag;
			}
			set	
			{
				otaJobFlag = value;
				DictionaryUtil.Add(QueryParameters, "OtaJobFlag", value.ToString());
			}
		}

		public bool? DeviceDataFlag
		{
			get
			{
				return deviceDataFlag;
			}
			set	
			{
				deviceDataFlag = value;
				DictionaryUtil.Add(QueryParameters, "DeviceDataFlag", value.ToString());
			}
		}

		public string MnsConfiguration
		{
			get
			{
				return mnsConfiguration;
			}
			set	
			{
				mnsConfiguration = value;
				DictionaryUtil.Add(QueryParameters, "MnsConfiguration", value);
			}
		}

        public override UpdateSubscribeRelationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSubscribeRelationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
