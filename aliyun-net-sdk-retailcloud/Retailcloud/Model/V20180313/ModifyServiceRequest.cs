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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class ModifyServiceRequest : RpcAcsRequest<ModifyServiceResponse>
    {
        public ModifyServiceRequest()
            : base("retailcloud", "2018-03-13", "ModifyService", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string name;

		private List<PortMappings> portMappingss = new List<PortMappings>(){ };

		private long? serviceId;

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public List<PortMappings> PortMappingss
		{
			get
			{
				return portMappingss;
			}

			set
			{
				portMappingss = value;
				for (int i = 0; i < portMappingss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"PortMappings." + (i + 1) + ".Protocol", portMappingss[i].Protocol);
					DictionaryUtil.Add(BodyParameters,"PortMappings." + (i + 1) + ".Port", portMappingss[i].Port);
					DictionaryUtil.Add(BodyParameters,"PortMappings." + (i + 1) + ".Name", portMappingss[i].Name);
					DictionaryUtil.Add(BodyParameters,"PortMappings." + (i + 1) + ".NodePort", portMappingss[i].NodePort);
					DictionaryUtil.Add(BodyParameters,"PortMappings." + (i + 1) + ".TargetPort", portMappingss[i].TargetPort);
				}
			}
		}

		public long? ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceId", value.ToString());
			}
		}

		public class PortMappings
		{

			private string protocol;

			private int? port;

			private string name;

			private int? nodePort;

			private string targetPort;

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public int? NodePort
			{
				get
				{
					return nodePort;
				}
				set	
				{
					nodePort = value;
				}
			}

			public string TargetPort
			{
				get
				{
					return targetPort;
				}
				set	
				{
					targetPort = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
