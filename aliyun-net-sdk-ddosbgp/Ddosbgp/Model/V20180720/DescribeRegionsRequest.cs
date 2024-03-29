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
using Aliyun.Acs.ddosbgp;
using Aliyun.Acs.ddosbgp.Transform;
using Aliyun.Acs.ddosbgp.Transform.V20180720;

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
    public class DescribeRegionsRequest : RpcAcsRequest<DescribeRegionsResponse>
    {
        public DescribeRegionsRequest()
            : base("ddosbgp", "2018-07-20", "DescribeRegions")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddosbgp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddosbgp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeRegionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRegionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
