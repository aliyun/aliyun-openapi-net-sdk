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
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class DescribeGatewayStatisticsRequest : RpcAcsRequest<DescribeGatewayStatisticsResponse>
    {
        public DescribeGatewayStatisticsRequest()
            : base("sgw", "2018-05-11", "DescribeGatewayStatistics", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string gatewayCategory;

		private string gatewayLocation;

		private long? startTimestamp;

		private long? endTimestamp;

		private string targetAccountId;

		private string securityToken;

		public string GatewayCategory
		{
			get
			{
				return gatewayCategory;
			}
			set	
			{
				gatewayCategory = value;
				DictionaryUtil.Add(QueryParameters, "GatewayCategory", value);
			}
		}

		public string GatewayLocation
		{
			get
			{
				return gatewayLocation;
			}
			set	
			{
				gatewayLocation = value;
				DictionaryUtil.Add(QueryParameters, "GatewayLocation", value);
			}
		}

		public long? StartTimestamp
		{
			get
			{
				return startTimestamp;
			}
			set	
			{
				startTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "StartTimestamp", value.ToString());
			}
		}

		public long? EndTimestamp
		{
			get
			{
				return endTimestamp;
			}
			set	
			{
				endTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "EndTimestamp", value.ToString());
			}
		}

		public string TargetAccountId
		{
			get
			{
				return targetAccountId;
			}
			set	
			{
				targetAccountId = value;
				DictionaryUtil.Add(QueryParameters, "TargetAccountId", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

        public override DescribeGatewayStatisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeGatewayStatisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
