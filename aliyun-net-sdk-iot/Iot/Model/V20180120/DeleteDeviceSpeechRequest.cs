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
    public class DeleteDeviceSpeechRequest : RpcAcsRequest<DeleteDeviceSpeechResponse>
    {
        public DeleteDeviceSpeechRequest()
            : base("Iot", "2018-01-20", "DeleteDeviceSpeech")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotId;

		private string iotInstanceId;

		private List<DeviceSpeechList> deviceSpeechLists = new List<DeviceSpeechList>(){ };

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(BodyParameters, "IotId", value);
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
				DictionaryUtil.Add(BodyParameters, "IotInstanceId", value);
			}
		}

		public List<DeviceSpeechList> DeviceSpeechLists
		{
			get
			{
				return deviceSpeechLists;
			}

			set
			{
				deviceSpeechLists = value;
				for (int i = 0; i < deviceSpeechLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"DeviceSpeechList." + (i + 1) + ".BizCode", deviceSpeechLists[i].BizCode);
					DictionaryUtil.Add(BodyParameters,"DeviceSpeechList." + (i + 1) + ".AudioFormat", deviceSpeechLists[i].AudioFormat);
				}
			}
		}

		public class DeviceSpeechList
		{

			private string bizCode;

			private string audioFormat;

			public string BizCode
			{
				get
				{
					return bizCode;
				}
				set	
				{
					bizCode = value;
				}
			}

			public string AudioFormat
			{
				get
				{
					return audioFormat;
				}
				set	
				{
					audioFormat = value;
				}
			}
		}

        public override DeleteDeviceSpeechResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteDeviceSpeechResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
