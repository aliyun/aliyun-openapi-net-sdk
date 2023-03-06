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
using Aliyun.Acs.Iot;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CreateOTAVerifyJobRequest : RpcAcsRequest<CreateOTAVerifyJobResponse>
    {
        public CreateOTAVerifyJobRequest()
            : base("Iot", "2018-01-20", "CreateOTAVerifyJob")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? timeoutInMinutes;

		private bool? needConfirm;

		private bool? needPush;

		private string iotInstanceId;

		private string downloadProtocol;

		private List<Tag> tags = new List<Tag>(){ };

		private string firmwareId;

		private string productKey;

		private List<string> targetDeviceNames = new List<string>(){ };

		public int? TimeoutInMinutes
		{
			get
			{
				return timeoutInMinutes;
			}
			set	
			{
				timeoutInMinutes = value;
				DictionaryUtil.Add(QueryParameters, "TimeoutInMinutes", value.ToString());
			}
		}

		public bool? NeedConfirm
		{
			get
			{
				return needConfirm;
			}
			set	
			{
				needConfirm = value;
				DictionaryUtil.Add(QueryParameters, "NeedConfirm", value.ToString());
			}
		}

		public bool? NeedPush
		{
			get
			{
				return needPush;
			}
			set	
			{
				needPush = value;
				DictionaryUtil.Add(QueryParameters, "NeedPush", value.ToString());
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

		public string DownloadProtocol
		{
			get
			{
				return downloadProtocol;
			}
			set	
			{
				downloadProtocol = value;
				DictionaryUtil.Add(QueryParameters, "DownloadProtocol", value);
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public string FirmwareId
		{
			get
			{
				return firmwareId;
			}
			set	
			{
				firmwareId = value;
				DictionaryUtil.Add(QueryParameters, "FirmwareId", value);
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

		public List<string> TargetDeviceNames
		{
			get
			{
				return targetDeviceNames;
			}

			set
			{
				targetDeviceNames = value;
				for (int i = 0; i < targetDeviceNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TargetDeviceName." + (i + 1) , targetDeviceNames[i]);
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
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

        public override CreateOTAVerifyJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOTAVerifyJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
