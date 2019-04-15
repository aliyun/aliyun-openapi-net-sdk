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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeTopRiskyAssetsResponseUnmarshaller
    {
        public static DescribeTopRiskyAssetsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTopRiskyAssetsResponse describeTopRiskyAssetsResponse = new DescribeTopRiskyAssetsResponse();

			describeTopRiskyAssetsResponse.HttpResponse = context.HttpResponse;
			describeTopRiskyAssetsResponse.RequestId = context.StringValue("DescribeTopRiskyAssets.RequestId");
			describeTopRiskyAssetsResponse.TotalCount = context.IntegerValue("DescribeTopRiskyAssets.TotalCount");

			List<DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset> describeTopRiskyAssetsResponse_topRiskyAssets = new List<DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset>();
			for (int i = 0; i < context.Length("DescribeTopRiskyAssets.TopRiskyAssets.Length"); i++) {
				DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset topRiskyAsset = new DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset();
				topRiskyAsset.Type = context.StringValue("DescribeTopRiskyAssets.TopRiskyAssets["+ i +"].Type");

				List<DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset.DescribeTopRiskyAssets_AssetInfo> topRiskyAsset_assetInfos = new List<DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset.DescribeTopRiskyAssets_AssetInfo>();
				for (int j = 0; j < context.Length("DescribeTopRiskyAssets.TopRiskyAssets["+ i +"].AssetInfos.Length"); j++) {
					DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset.DescribeTopRiskyAssets_AssetInfo assetInfo = new DescribeTopRiskyAssetsResponse.DescribeTopRiskyAssets_TopRiskyAsset.DescribeTopRiskyAssets_AssetInfo();
					assetInfo.Uuid = context.StringValue("DescribeTopRiskyAssets.TopRiskyAssets["+ i +"].AssetInfos["+ j +"].Uuid");
					assetInfo.Ip = context.StringValue("DescribeTopRiskyAssets.TopRiskyAssets["+ i +"].AssetInfos["+ j +"].Ip");
					assetInfo.InstanceName = context.StringValue("DescribeTopRiskyAssets.TopRiskyAssets["+ i +"].AssetInfos["+ j +"].InstanceName");
					assetInfo.Count = context.StringValue("DescribeTopRiskyAssets.TopRiskyAssets["+ i +"].AssetInfos["+ j +"].Count");

					topRiskyAsset_assetInfos.Add(assetInfo);
				}
				topRiskyAsset.AssetInfos = topRiskyAsset_assetInfos;

				describeTopRiskyAssetsResponse_topRiskyAssets.Add(topRiskyAsset);
			}
			describeTopRiskyAssetsResponse.TopRiskyAssets = describeTopRiskyAssetsResponse_topRiskyAssets;
        
			return describeTopRiskyAssetsResponse;
        }
    }
}
