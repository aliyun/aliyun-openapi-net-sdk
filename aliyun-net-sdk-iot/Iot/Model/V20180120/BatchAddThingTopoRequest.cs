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
    public class BatchAddThingTopoRequest : RpcAcsRequest<BatchAddThingTopoResponse>
    {
        public BatchAddThingTopoRequest()
            : base("Iot", "2018-01-20", "BatchAddThingTopo", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string gwProductKey;

		private string iotInstanceId;

		private List<TopoAddItem> topoAddItems = new List<TopoAddItem>(){ };

		private string gwDeviceName;

		public string GwProductKey
		{
			get
			{
				return gwProductKey;
			}
			set	
			{
				gwProductKey = value;
				DictionaryUtil.Add(QueryParameters, "GwProductKey", value);
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

		public List<TopoAddItem> TopoAddItems
		{
			get
			{
				return topoAddItems;
			}

			set
			{
				topoAddItems = value;
				for (int i = 0; i < topoAddItems.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TopoAddItem." + (i + 1) + ".ClientId", topoAddItems[i].ClientId);
					DictionaryUtil.Add(QueryParameters,"TopoAddItem." + (i + 1) + ".SignMethod", topoAddItems[i].SignMethod);
					DictionaryUtil.Add(QueryParameters,"TopoAddItem." + (i + 1) + ".Sign", topoAddItems[i].Sign);
					DictionaryUtil.Add(QueryParameters,"TopoAddItem." + (i + 1) + ".DeviceName", topoAddItems[i].DeviceName);
					DictionaryUtil.Add(QueryParameters,"TopoAddItem." + (i + 1) + ".ProductKey", topoAddItems[i].ProductKey);
					DictionaryUtil.Add(QueryParameters,"TopoAddItem." + (i + 1) + ".Timestamp", topoAddItems[i].Timestamp);
				}
			}
		}

		public string GwDeviceName
		{
			get
			{
				return gwDeviceName;
			}
			set	
			{
				gwDeviceName = value;
				DictionaryUtil.Add(QueryParameters, "GwDeviceName", value);
			}
		}

		public class TopoAddItem
		{

			private string clientId;

			private string signMethod;

			private string sign;

			private string deviceName;

			private string productKey;

			private string timestamp;

			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			public string SignMethod
			{
				get
				{
					return signMethod;
				}
				set	
				{
					signMethod = value;
				}
			}

			public string Sign
			{
				get
				{
					return sign;
				}
				set	
				{
					sign = value;
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

			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}
		}

        public override BatchAddThingTopoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchAddThingTopoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
