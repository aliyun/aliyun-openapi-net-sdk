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
    public class ListVpcEndpointsRequest : RpcAcsRequest<ListVpcEndpointsResponse>
    {
        public ListVpcEndpointsRequest()
            : base("Privatelink", "2020-04-15", "ListVpcEndpoints", "privatelink", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string endpointId;

		private string endpointStatus;

		private string nextToken;

		private string serviceName;

		private string connectionStatus;

		private string vpcId;

		private string endpointName;

		private int? maxResults;

		public string EndpointId
		{
			get
			{
				return endpointId;
			}
			set	
			{
				endpointId = value;
				DictionaryUtil.Add(QueryParameters, "EndpointId", value);
			}
		}

		public string EndpointStatus
		{
			get
			{
				return endpointStatus;
			}
			set	
			{
				endpointStatus = value;
				DictionaryUtil.Add(QueryParameters, "EndpointStatus", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
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

		public string ConnectionStatus
		{
			get
			{
				return connectionStatus;
			}
			set	
			{
				connectionStatus = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionStatus", value);
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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListVpcEndpointsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListVpcEndpointsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
