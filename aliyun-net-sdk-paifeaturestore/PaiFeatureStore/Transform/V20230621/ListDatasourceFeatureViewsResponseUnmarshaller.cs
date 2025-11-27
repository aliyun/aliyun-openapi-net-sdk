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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListDatasourceFeatureViewsResponseUnmarshaller
    {
        public static ListDatasourceFeatureViewsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatasourceFeatureViewsResponse listDatasourceFeatureViewsResponse = new ListDatasourceFeatureViewsResponse();

			listDatasourceFeatureViewsResponse.HttpResponse = _ctx.HttpResponse;
			listDatasourceFeatureViewsResponse.TotalCount = _ctx.LongValue("ListDatasourceFeatureViews.TotalCount");
			listDatasourceFeatureViewsResponse.RequestId = _ctx.StringValue("ListDatasourceFeatureViews.requestId");

			ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_TotalUsageStatistics totalUsageStatistics = new ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_TotalUsageStatistics();
			totalUsageStatistics.TotalDiskUsage = _ctx.DoubleValue("ListDatasourceFeatureViews.TotalUsageStatistics.TotalDiskUsage");
			totalUsageStatistics.TotalMemoryUsage = _ctx.DoubleValue("ListDatasourceFeatureViews.TotalUsageStatistics.TotalMemoryUsage");

			List<ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_TotalUsageStatistics.ListDatasourceFeatureViews_TotalReadWriteCountItem> totalUsageStatistics_totalReadWriteCount = new List<ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_TotalUsageStatistics.ListDatasourceFeatureViews_TotalReadWriteCountItem>();
			for (int i = 0; i < _ctx.Length("ListDatasourceFeatureViews.TotalUsageStatistics.TotalReadWriteCount.Length"); i++) {
				ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_TotalUsageStatistics.ListDatasourceFeatureViews_TotalReadWriteCountItem totalReadWriteCountItem = new ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_TotalUsageStatistics.ListDatasourceFeatureViews_TotalReadWriteCountItem();
				totalReadWriteCountItem.Date = _ctx.StringValue("ListDatasourceFeatureViews.TotalUsageStatistics.TotalReadWriteCount["+ i +"].Date");
				totalReadWriteCountItem.TotalWriteCount = _ctx.LongValue("ListDatasourceFeatureViews.TotalUsageStatistics.TotalReadWriteCount["+ i +"].TotalWriteCount");
				totalReadWriteCountItem.TotalReadCount = _ctx.LongValue("ListDatasourceFeatureViews.TotalUsageStatistics.TotalReadWriteCount["+ i +"].TotalReadCount");

				totalUsageStatistics_totalReadWriteCount.Add(totalReadWriteCountItem);
			}
			totalUsageStatistics.TotalReadWriteCount = totalUsageStatistics_totalReadWriteCount;
			listDatasourceFeatureViewsResponse.TotalUsageStatistics = totalUsageStatistics;

			List<ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews> listDatasourceFeatureViewsResponse_featureViews = new List<ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews>();
			for (int i = 0; i < _ctx.Length("ListDatasourceFeatureViews.FeatureViews.Length"); i++) {
				ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews datasourceFeatureViews = new ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews();
				datasourceFeatureViews.FeatureViewId = _ctx.StringValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].FeatureViewId");
				datasourceFeatureViews.Name = _ctx.StringValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].Name");
				datasourceFeatureViews.ProjectName = _ctx.StringValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].ProjectName");
				datasourceFeatureViews.Type = _ctx.StringValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].Type");
				datasourceFeatureViews.FeatureEntityName = _ctx.StringValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].FeatureEntityName");
				datasourceFeatureViews.TTL = _ctx.IntegerValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].TTL");
				datasourceFeatureViews.Config = _ctx.StringValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].Config");

				ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews.ListDatasourceFeatureViews_UsageStatistics usageStatistics = new ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews.ListDatasourceFeatureViews_UsageStatistics();
				usageStatistics.RowCount = _ctx.LongValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].UsageStatistics.RowCount");
				usageStatistics.DiskUsage = _ctx.DoubleValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].UsageStatistics.DiskUsage");
				usageStatistics.MemoryUsage = _ctx.DoubleValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].UsageStatistics.MemoryUsage");

				List<ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews.ListDatasourceFeatureViews_UsageStatistics.ListDatasourceFeatureViews_ReadWriteCountItem> usageStatistics_readWriteCount = new List<ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews.ListDatasourceFeatureViews_UsageStatistics.ListDatasourceFeatureViews_ReadWriteCountItem>();
				for (int j = 0; j < _ctx.Length("ListDatasourceFeatureViews.FeatureViews["+ i +"].UsageStatistics.ReadWriteCount.Length"); j++) {
					ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews.ListDatasourceFeatureViews_UsageStatistics.ListDatasourceFeatureViews_ReadWriteCountItem readWriteCountItem = new ListDatasourceFeatureViewsResponse.ListDatasourceFeatureViews_DatasourceFeatureViews.ListDatasourceFeatureViews_UsageStatistics.ListDatasourceFeatureViews_ReadWriteCountItem();
					readWriteCountItem.Date = _ctx.StringValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].UsageStatistics.ReadWriteCount["+ j +"].Date");
					readWriteCountItem.WriteCount = _ctx.LongValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].UsageStatistics.ReadWriteCount["+ j +"].WriteCount");
					readWriteCountItem.ReadCount = _ctx.LongValue("ListDatasourceFeatureViews.FeatureViews["+ i +"].UsageStatistics.ReadWriteCount["+ j +"].ReadCount");

					usageStatistics_readWriteCount.Add(readWriteCountItem);
				}
				usageStatistics.ReadWriteCount = usageStatistics_readWriteCount;
				datasourceFeatureViews.UsageStatistics = usageStatistics;

				listDatasourceFeatureViewsResponse_featureViews.Add(datasourceFeatureViews);
			}
			listDatasourceFeatureViewsResponse.FeatureViews = listDatasourceFeatureViewsResponse_featureViews;
        
			return listDatasourceFeatureViewsResponse;
        }
    }
}
