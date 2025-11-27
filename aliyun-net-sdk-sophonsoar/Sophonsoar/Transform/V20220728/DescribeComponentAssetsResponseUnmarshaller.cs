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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeComponentAssetsResponseUnmarshaller
    {
        public static DescribeComponentAssetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeComponentAssetsResponse describeComponentAssetsResponse = new DescribeComponentAssetsResponse();

			describeComponentAssetsResponse.HttpResponse = _ctx.HttpResponse;
			describeComponentAssetsResponse.RequestId = _ctx.StringValue("DescribeComponentAssets.RequestId");

			List<DescribeComponentAssetsResponse.DescribeComponentAssets_ComponentAssetsItem> describeComponentAssetsResponse_componentAssets = new List<DescribeComponentAssetsResponse.DescribeComponentAssets_ComponentAssetsItem>();
			for (int i = 0; i < _ctx.Length("DescribeComponentAssets.ComponentAssets.Length"); i++) {
				DescribeComponentAssetsResponse.DescribeComponentAssets_ComponentAssetsItem componentAssetsItem = new DescribeComponentAssetsResponse.DescribeComponentAssets_ComponentAssetsItem();
				componentAssetsItem.Id = _ctx.LongValue("DescribeComponentAssets.ComponentAssets["+ i +"].Id");
				componentAssetsItem.GmtCreate = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].GmtCreate");
				componentAssetsItem.GmtModified = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].GmtModified");
				componentAssetsItem.Name = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].Name");
				componentAssetsItem.Componentname = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].Componentname");
				componentAssetsItem._Params = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].Params");
				componentAssetsItem.DomainId = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].DomainId");
				componentAssetsItem.TenantId = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].TenantId");
				componentAssetsItem.Owner = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].Owner");
				componentAssetsItem.AssetUuid = _ctx.StringValue("DescribeComponentAssets.ComponentAssets["+ i +"].AssetUuid");

				describeComponentAssetsResponse_componentAssets.Add(componentAssetsItem);
			}
			describeComponentAssetsResponse.ComponentAssets = describeComponentAssetsResponse_componentAssets;
        
			return describeComponentAssetsResponse;
        }
    }
}
