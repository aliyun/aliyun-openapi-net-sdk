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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class UpdateInstanceInformationRequest : RpcAcsRequest<UpdateInstanceInformationResponse>
    {
        public UpdateInstanceInformationRequest()
            : base("oos", "2019-06-01", "UpdateInstanceInformation", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string agentVersion;

		private string ipAddress;

		private string computerName;

		private string platformName;

		private string instanceId;

		private string agentName;

		private string platformType;

		private string platformVersion;

		public string AgentVersion
		{
			get
			{
				return agentVersion;
			}
			set	
			{
				agentVersion = value;
				DictionaryUtil.Add(QueryParameters, "AgentVersion", value);
			}
		}

		public string IpAddress
		{
			get
			{
				return ipAddress;
			}
			set	
			{
				ipAddress = value;
				DictionaryUtil.Add(QueryParameters, "IpAddress", value);
			}
		}

		public string ComputerName
		{
			get
			{
				return computerName;
			}
			set	
			{
				computerName = value;
				DictionaryUtil.Add(QueryParameters, "ComputerName", value);
			}
		}

		public string PlatformName
		{
			get
			{
				return platformName;
			}
			set	
			{
				platformName = value;
				DictionaryUtil.Add(QueryParameters, "PlatformName", value);
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

		public string AgentName
		{
			get
			{
				return agentName;
			}
			set	
			{
				agentName = value;
				DictionaryUtil.Add(QueryParameters, "AgentName", value);
			}
		}

		public string PlatformType
		{
			get
			{
				return platformType;
			}
			set	
			{
				platformType = value;
				DictionaryUtil.Add(QueryParameters, "PlatformType", value);
			}
		}

		public string PlatformVersion
		{
			get
			{
				return platformVersion;
			}
			set	
			{
				platformVersion = value;
				DictionaryUtil.Add(QueryParameters, "PlatformVersion", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateInstanceInformationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateInstanceInformationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
