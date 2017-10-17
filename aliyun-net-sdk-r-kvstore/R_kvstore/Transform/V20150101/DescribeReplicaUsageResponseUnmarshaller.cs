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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeReplicaUsageResponseUnmarshaller
    {
        public static DescribeReplicaUsageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReplicaUsageResponse describeReplicaUsageResponse = new DescribeReplicaUsageResponse();

			describeReplicaUsageResponse.HttpResponse = context.HttpResponse;
			describeReplicaUsageResponse.RequestId = context.StringValue("DescribeReplicaUsage.RequestId");
			describeReplicaUsageResponse.StartTime = context.StringValue("DescribeReplicaUsage.StartTime");
			describeReplicaUsageResponse.EndTime = context.StringValue("DescribeReplicaUsage.EndTime");
			describeReplicaUsageResponse.ReplicaId = context.StringValue("DescribeReplicaUsage.ReplicaId");

			DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys performanceKeys = new DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys();

			List<DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem> performanceKeys_performanceKey = new List<DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem>();
			for (int i = 0; i < context.Length("DescribeReplicaUsage.PerformanceKeys.PerformanceKey.Length"); i++) {
				DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem performanceKeyItem = new DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem();
				performanceKeyItem.Key = context.StringValue("DescribeReplicaUsage.PerformanceKeys.PerformanceKey["+ i +"].Key");
				performanceKeyItem.Unit = context.StringValue("DescribeReplicaUsage.PerformanceKeys.PerformanceKey["+ i +"].Unit");
				performanceKeyItem.ValueFormat = context.StringValue("DescribeReplicaUsage.PerformanceKeys.PerformanceKey["+ i +"].ValueFormat");

				DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem.DescribeReplicaUsage_PerformanceValues performanceValues = new DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem.DescribeReplicaUsage_PerformanceValues();

				List<DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem.DescribeReplicaUsage_PerformanceValues.DescribeReplicaUsage_PerformanceValueItem> performanceValues_performanceValue = new List<DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem.DescribeReplicaUsage_PerformanceValues.DescribeReplicaUsage_PerformanceValueItem>();
				for (int j = 0; j < context.Length("DescribeReplicaUsage.PerformanceKeys.PerformanceKey["+ i +"].PerformanceValues.PerformanceValue.Length"); j++) {
					DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem.DescribeReplicaUsage_PerformanceValues.DescribeReplicaUsage_PerformanceValueItem performanceValueItem = new DescribeReplicaUsageResponse.DescribeReplicaUsage_PerformanceKeys.DescribeReplicaUsage_PerformanceKeyItem.DescribeReplicaUsage_PerformanceValues.DescribeReplicaUsage_PerformanceValueItem();
					performanceValueItem._Value = context.StringValue("DescribeReplicaUsage.PerformanceKeys.PerformanceKey["+ i +"].PerformanceValues.PerformanceValue["+ j +"].Value");
					performanceValueItem.Date = context.StringValue("DescribeReplicaUsage.PerformanceKeys.PerformanceKey["+ i +"].PerformanceValues.PerformanceValue["+ j +"].Date");

					performanceValues_performanceValue.Add(performanceValueItem);
				}
				performanceValues.PerformanceValue = performanceValues_performanceValue;
				performanceKeyItem.PerformanceValues = performanceValues;

				performanceKeys_performanceKey.Add(performanceKeyItem);
			}
			performanceKeys.PerformanceKey = performanceKeys_performanceKey;
			describeReplicaUsageResponse.PerformanceKeys = performanceKeys;
        
			return describeReplicaUsageResponse;
        }
    }
}