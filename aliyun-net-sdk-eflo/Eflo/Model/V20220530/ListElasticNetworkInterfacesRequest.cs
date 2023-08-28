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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class ListElasticNetworkInterfacesRequest : RpcAcsRequest<ListElasticNetworkInterfacesResponse>
    {
        public ListElasticNetworkInterfacesRequest()
            : base("eflo", "2022-05-30", "ListElasticNetworkInterfaces", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string networkType;

		private string type;

		private int? pageNumber;

		private int? pageSize;

		private string nodeId;

		private string ip;

		private string vSwitchId;

		private string vpcId;

		private string zoneId;

		private string elasticNetworkInterfaceId;

		private string status;

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
				DictionaryUtil.Add(BodyParameters, "NetworkType", value);
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
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string NodeId
		{
			get
			{
				return nodeId;
			}
			set	
			{
				nodeId = value;
				DictionaryUtil.Add(BodyParameters, "NodeId", value);
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
				DictionaryUtil.Add(BodyParameters, "Ip", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(BodyParameters, "VSwitchId", value);
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
				DictionaryUtil.Add(BodyParameters, "VpcId", value);
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
				DictionaryUtil.Add(BodyParameters, "ZoneId", value);
			}
		}

		public string ElasticNetworkInterfaceId
		{
			get
			{
				return elasticNetworkInterfaceId;
			}
			set	
			{
				elasticNetworkInterfaceId = value;
				DictionaryUtil.Add(BodyParameters, "ElasticNetworkInterfaceId", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListElasticNetworkInterfacesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListElasticNetworkInterfacesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
