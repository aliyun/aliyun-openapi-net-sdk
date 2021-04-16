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
using Aliyun.Acs.Privatelink.Transform;
using Aliyun.Acs.Privatelink.Transform.V20200415;

namespace Aliyun.Acs.Privatelink.Model.V20200415
{
    public class CreateVpcEndpointRequest : RpcAcsRequest<CreateVpcEndpointResponse>
    {
        public CreateVpcEndpointRequest()
            : base("Privatelink", "2020-04-15", "CreateVpcEndpoint", "privatelink", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string clientToken;

		private List<string> securityGroupIds = new List<string>(){ };

		private List<Zone> zones = new List<Zone>(){ };

		private string serviceName;

		private bool? dryRun;

		private string endpointDescription;

		private string endpointName;

		private string vpcId;

		private string serviceId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public List<string> SecurityGroupIds
		{
			get
			{
				return securityGroupIds;
			}

			set
			{
				securityGroupIds = value;
				for (int i = 0; i < securityGroupIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SecurityGroupId." + (i + 1) , securityGroupIds[i]);
				}
			}
		}

		public List<Zone> Zones
		{
			get
			{
				return zones;
			}

			set
			{
				zones = value;
				for (int i = 0; i < zones.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Zone." + (i + 1) + ".VSwitchId", zones[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"Zone." + (i + 1) + ".ZoneId", zones[i].ZoneId);
					DictionaryUtil.Add(QueryParameters,"Zone." + (i + 1) + ".ip", zones[i].Ip);
				}
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string EndpointDescription
		{
			get
			{
				return endpointDescription;
			}
			set	
			{
				endpointDescription = value;
				DictionaryUtil.Add(QueryParameters, "EndpointDescription", value);
			}
		}

		public string EndpointName
		{
			get
			{
				return endpointName;
			}
			set	
			{
				endpointName = value;
				DictionaryUtil.Add(QueryParameters, "EndpointName", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceId", value);
			}
		}

		public class Zone
		{

			private string vSwitchId;

			private string zoneId;

			private string ip;

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVpcEndpointResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVpcEndpointResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
