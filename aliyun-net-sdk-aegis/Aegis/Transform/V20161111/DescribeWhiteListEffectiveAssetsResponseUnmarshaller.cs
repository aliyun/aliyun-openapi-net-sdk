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
    public class DescribeWhiteListEffectiveAssetsResponseUnmarshaller
    {
        public static DescribeWhiteListEffectiveAssetsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWhiteListEffectiveAssetsResponse describeWhiteListEffectiveAssetsResponse = new DescribeWhiteListEffectiveAssetsResponse();

			describeWhiteListEffectiveAssetsResponse.HttpResponse = context.HttpResponse;
			describeWhiteListEffectiveAssetsResponse.RequestId = context.StringValue("DescribeWhiteListEffectiveAssets.RequestId");
			describeWhiteListEffectiveAssetsResponse.Count = context.IntegerValue("DescribeWhiteListEffectiveAssets.Count");
			describeWhiteListEffectiveAssetsResponse.PageSize = context.IntegerValue("DescribeWhiteListEffectiveAssets.PageSize");
			describeWhiteListEffectiveAssetsResponse.TotalCount = context.IntegerValue("DescribeWhiteListEffectiveAssets.TotalCount");
			describeWhiteListEffectiveAssetsResponse.CurrentPage = context.IntegerValue("DescribeWhiteListEffectiveAssets.CurrentPage");

			List<DescribeWhiteListEffectiveAssetsResponse.DescribeWhiteListEffectiveAssets_Asset> describeWhiteListEffectiveAssetsResponse_assets = new List<DescribeWhiteListEffectiveAssetsResponse.DescribeWhiteListEffectiveAssets_Asset>();
			for (int i = 0; i < context.Length("DescribeWhiteListEffectiveAssets.Assets.Length"); i++) {
				DescribeWhiteListEffectiveAssetsResponse.DescribeWhiteListEffectiveAssets_Asset asset = new DescribeWhiteListEffectiveAssetsResponse.DescribeWhiteListEffectiveAssets_Asset();
				asset.Uuid = context.StringValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].Uuid");
				asset.MachineName = context.StringValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].MachineName");
				asset.InternetIp = context.StringValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].InternetIp");
				asset.IntranetIp = context.StringValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].IntranetIp");
				asset.StrategyId = context.LongValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].StrategyId");
				asset.StrategyName = context.StringValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].StrategyName");
				asset.SuspiciousEventCount = context.IntegerValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].SuspiciousEventCount");
				asset.ProcessMethod = context.IntegerValue("DescribeWhiteListEffectiveAssets.Assets["+ i +"].ProcessMethod");

				describeWhiteListEffectiveAssetsResponse_assets.Add(asset);
			}
			describeWhiteListEffectiveAssetsResponse.Assets = describeWhiteListEffectiveAssetsResponse_assets;
        
			return describeWhiteListEffectiveAssetsResponse;
        }
    }
}
