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
    public class DescribeSasAssetStatisticsResponseUnmarshaller
    {
        public static DescribeSasAssetStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSasAssetStatisticsResponse describeSasAssetStatisticsResponse = new DescribeSasAssetStatisticsResponse();

			describeSasAssetStatisticsResponse.HttpResponse = context.HttpResponse;
			describeSasAssetStatisticsResponse.RequestId = context.StringValue("DescribeSasAssetStatistics.RequestId");
			describeSasAssetStatisticsResponse.PageSize = context.IntegerValue("DescribeSasAssetStatistics.PageSize");
			describeSasAssetStatisticsResponse.CurrentPage = context.IntegerValue("DescribeSasAssetStatistics.CurrentPage");
			describeSasAssetStatisticsResponse.TotalCount = context.IntegerValue("DescribeSasAssetStatistics.TotalCount");

			List<DescribeSasAssetStatisticsResponse.DescribeSasAssetStatistics_Asset> describeSasAssetStatisticsResponse_assetList = new List<DescribeSasAssetStatisticsResponse.DescribeSasAssetStatistics_Asset>();
			for (int i = 0; i < context.Length("DescribeSasAssetStatistics.AssetList.Length"); i++) {
				DescribeSasAssetStatisticsResponse.DescribeSasAssetStatistics_Asset asset = new DescribeSasAssetStatisticsResponse.DescribeSasAssetStatistics_Asset();
				asset.HealthCheckCount = context.IntegerValue("DescribeSasAssetStatistics.AssetList["+ i +"].HealthCheckCount");
				asset.VulCount = context.IntegerValue("DescribeSasAssetStatistics.AssetList["+ i +"].VulCount");
				asset.SafeEventCount = context.IntegerValue("DescribeSasAssetStatistics.AssetList["+ i +"].SafeEventCount");
				asset.Uuid = context.StringValue("DescribeSasAssetStatistics.AssetList["+ i +"].Uuid");

				describeSasAssetStatisticsResponse_assetList.Add(asset);
			}
			describeSasAssetStatisticsResponse.AssetList = describeSasAssetStatisticsResponse_assetList;
        
			return describeSasAssetStatisticsResponse;
        }
    }
}
