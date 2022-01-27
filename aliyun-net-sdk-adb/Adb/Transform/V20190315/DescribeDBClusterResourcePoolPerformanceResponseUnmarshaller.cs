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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBClusterResourcePoolPerformanceResponseUnmarshaller
    {
        public static DescribeDBClusterResourcePoolPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterResourcePoolPerformanceResponse describeDBClusterResourcePoolPerformanceResponse = new DescribeDBClusterResourcePoolPerformanceResponse();

			describeDBClusterResourcePoolPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterResourcePoolPerformanceResponse.RequestId = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.RequestId");
			describeDBClusterResourcePoolPerformanceResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.DBClusterId");
			describeDBClusterResourcePoolPerformanceResponse.StartTime = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.StartTime");
			describeDBClusterResourcePoolPerformanceResponse.EndTime = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.EndTime");

			List<DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem> describeDBClusterResourcePoolPerformanceResponse_performances = new List<DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterResourcePoolPerformance.Performances.Length"); i++) {
				DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem performanceItem = new DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem();
				performanceItem.Key = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].Key");
				performanceItem.Unit = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].Unit");

				List<DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem> performanceItem_resourcePoolPerformances = new List<DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].ResourcePoolPerformances.Length"); j++) {
					DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem resourcePoolPerformancesItem = new DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem();
					resourcePoolPerformancesItem.ResourcePoolName = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].ResourcePoolPerformances["+ j +"].ResourcePoolName");

					List<DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolSeriesItem> resourcePoolPerformancesItem_resourcePoolSeries = new List<DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolSeriesItem>();
					for (int k = 0; k < _ctx.Length("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].ResourcePoolPerformances["+ j +"].ResourcePoolSeries.Length"); k++) {
						DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolSeriesItem resourcePoolSeriesItem = new DescribeDBClusterResourcePoolPerformanceResponse.DescribeDBClusterResourcePoolPerformance_PerformanceItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolPerformancesItem.DescribeDBClusterResourcePoolPerformance_ResourcePoolSeriesItem();
						resourcePoolSeriesItem.Name = _ctx.StringValue("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].ResourcePoolPerformances["+ j +"].ResourcePoolSeries["+ k +"].Name");

						List<string> resourcePoolSeriesItem_values = new List<string>();
						for (int l = 0; l < _ctx.Length("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].ResourcePoolPerformances["+ j +"].ResourcePoolSeries["+ k +"].Values.Length"); l++) {
							resourcePoolSeriesItem_values.Add(_ctx.StringValue("DescribeDBClusterResourcePoolPerformance.Performances["+ i +"].ResourcePoolPerformances["+ j +"].ResourcePoolSeries["+ k +"].Values["+ l +"]"));
						}
						resourcePoolSeriesItem.Values = resourcePoolSeriesItem_values;

						resourcePoolPerformancesItem_resourcePoolSeries.Add(resourcePoolSeriesItem);
					}
					resourcePoolPerformancesItem.ResourcePoolSeries = resourcePoolPerformancesItem_resourcePoolSeries;

					performanceItem_resourcePoolPerformances.Add(resourcePoolPerformancesItem);
				}
				performanceItem.ResourcePoolPerformances = performanceItem_resourcePoolPerformances;

				describeDBClusterResourcePoolPerformanceResponse_performances.Add(performanceItem);
			}
			describeDBClusterResourcePoolPerformanceResponse.Performances = describeDBClusterResourcePoolPerformanceResponse_performances;
        
			return describeDBClusterResourcePoolPerformanceResponse;
        }
    }
}
