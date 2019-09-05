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
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class CreateClusterRequest : RoaAcsRequest<CreateClusterResponse>
    {
        public CreateClusterRequest()
            : base("foas", "2018-11-11", "CreateCluster", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/clusters";
			Method = MethodType.POST;
        }

		private string orderId;

		private string userOssBucket;

		private string displayName;

		private string userVpcId;

		private string zoneId;

		private string description;

		private string userVSwitch;

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(BodyParameters, "orderId", value);
			}
		}

		public string UserOssBucket
		{
			get
			{
				return userOssBucket;
			}
			set	
			{
				userOssBucket = value;
				DictionaryUtil.Add(BodyParameters, "userOssBucket", value);
			}
		}

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
				DictionaryUtil.Add(BodyParameters, "displayName", value);
			}
		}

		public string UserVpcId
		{
			get
			{
				return userVpcId;
			}
			set	
			{
				userVpcId = value;
				DictionaryUtil.Add(BodyParameters, "userVpcId", value);
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
				DictionaryUtil.Add(BodyParameters, "zoneId", value);
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
				DictionaryUtil.Add(BodyParameters, "description", value);
			}
		}

		public string UserVSwitch
		{
			get
			{
				return userVSwitch;
			}
			set	
			{
				userVSwitch = value;
				DictionaryUtil.Add(BodyParameters, "userVSwitch", value);
			}
		}

        public override CreateClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
