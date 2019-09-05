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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class CreateFaultRequest : RpcAcsRequest<CreateFaultResponse>
    {
        public CreateFaultRequest()
            : base("CCC", "2017-07-05", "CreateFault")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string agentOssFileName;

		private string description;

		private string operatingSystemVersion;

		private long? startTime;

		private string microphoneList;

		private string clientPort;

		private string customFilePath;

		private string clientIp;

		private string speakerList;

		private long? agentId;

		private long? endTime;

		private string speakerEquipment;

		private string servicePort;

		private string serviceIp;

		private string instanceId;

		private string agentFilePath;

		private string connectId;

		private string customOssFileName;

		private string microphoneEquipment;

		private string browserVersion;

		public string AgentOssFileName
		{
			get
			{
				return agentOssFileName;
			}
			set	
			{
				agentOssFileName = value;
				DictionaryUtil.Add(QueryParameters, "AgentOssFileName", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string OperatingSystemVersion
		{
			get
			{
				return operatingSystemVersion;
			}
			set	
			{
				operatingSystemVersion = value;
				DictionaryUtil.Add(QueryParameters, "OperatingSystemVersion", value);
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public string MicrophoneList
		{
			get
			{
				return microphoneList;
			}
			set	
			{
				microphoneList = value;
				DictionaryUtil.Add(QueryParameters, "MicrophoneList", value);
			}
		}

		public string ClientPort
		{
			get
			{
				return clientPort;
			}
			set	
			{
				clientPort = value;
				DictionaryUtil.Add(QueryParameters, "ClientPort", value);
			}
		}

		public string CustomFilePath
		{
			get
			{
				return customFilePath;
			}
			set	
			{
				customFilePath = value;
				DictionaryUtil.Add(QueryParameters, "CustomFilePath", value);
			}
		}

		public string ClientIp
		{
			get
			{
				return clientIp;
			}
			set	
			{
				clientIp = value;
				DictionaryUtil.Add(QueryParameters, "ClientIp", value);
			}
		}

		public string SpeakerList
		{
			get
			{
				return speakerList;
			}
			set	
			{
				speakerList = value;
				DictionaryUtil.Add(QueryParameters, "SpeakerList", value);
			}
		}

		public long? AgentId
		{
			get
			{
				return agentId;
			}
			set	
			{
				agentId = value;
				DictionaryUtil.Add(QueryParameters, "AgentId", value.ToString());
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

		public string SpeakerEquipment
		{
			get
			{
				return speakerEquipment;
			}
			set	
			{
				speakerEquipment = value;
				DictionaryUtil.Add(QueryParameters, "SpeakerEquipment", value);
			}
		}

		public string ServicePort
		{
			get
			{
				return servicePort;
			}
			set	
			{
				servicePort = value;
				DictionaryUtil.Add(QueryParameters, "ServicePort", value);
			}
		}

		public string ServiceIp
		{
			get
			{
				return serviceIp;
			}
			set	
			{
				serviceIp = value;
				DictionaryUtil.Add(QueryParameters, "ServiceIp", value);
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

		public string AgentFilePath
		{
			get
			{
				return agentFilePath;
			}
			set	
			{
				agentFilePath = value;
				DictionaryUtil.Add(QueryParameters, "AgentFilePath", value);
			}
		}

		public string ConnectId
		{
			get
			{
				return connectId;
			}
			set	
			{
				connectId = value;
				DictionaryUtil.Add(QueryParameters, "ConnectId", value);
			}
		}

		public string CustomOssFileName
		{
			get
			{
				return customOssFileName;
			}
			set	
			{
				customOssFileName = value;
				DictionaryUtil.Add(QueryParameters, "CustomOssFileName", value);
			}
		}

		public string MicrophoneEquipment
		{
			get
			{
				return microphoneEquipment;
			}
			set	
			{
				microphoneEquipment = value;
				DictionaryUtil.Add(QueryParameters, "MicrophoneEquipment", value);
			}
		}

		public string BrowserVersion
		{
			get
			{
				return browserVersion;
			}
			set	
			{
				browserVersion = value;
				DictionaryUtil.Add(QueryParameters, "BrowserVersion", value);
			}
		}

        public override CreateFaultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFaultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
