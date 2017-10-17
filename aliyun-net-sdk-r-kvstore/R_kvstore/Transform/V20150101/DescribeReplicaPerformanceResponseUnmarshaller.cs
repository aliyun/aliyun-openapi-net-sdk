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
    public class DescribeReplicaPerformanceResponseUnmarshaller
    {
        public static DescribeReplicaPerformanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReplicaPerformanceResponse describeReplicaPerformanceResponse = new DescribeReplicaPerformanceResponse();

			describeReplicaPerformanceResponse.HttpResponse = context.HttpResponse;
			describeReplicaPerformanceResponse.RequestId = context.StringValue("DescribeReplicaPerformance.RequestId");
			describeReplicaPerformanceResponse.StartTime = context.StringValue("DescribeReplicaPerformance.StartTime");
			describeReplicaPerformanceResponse.EndTime = context.StringValue("DescribeReplicaPerformance.EndTime");
			describeReplicaPerformanceResponse.ReplicaId = context.StringValue("DescribeReplicaPerformance.ReplicaId");

			DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys performanceKeys = new DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys();

			List<DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem> performanceKeys_performanceKey = new List<DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem>();
			for (int i = 0; i < context.Length("DescribeReplicaPerformance.PerformanceKeys.PerformanceKey.Length"); i++) {
				DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem performanceKeyItem = new DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem();
				performanceKeyItem.Key = context.StringValue("DescribeReplicaPerformance.PerformanceKeys.PerformanceKey["+ i +"].Key");
				performanceKeyItem.Unit = context.StringValue("DescribeReplicaPerformance.PerformanceKeys.PerformanceKey["+ i +"].Unit");
				performanceKeyItem.ValueFormat = context.StringValue("DescribeReplicaPerformance.PerformanceKeys.PerformanceKey["+ i +"].ValueFormat");

				DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem.DescribeReplicaPerformance_PerformanceValues performanceValues = new DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem.DescribeReplicaPerformance_PerformanceValues();

				List<DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem.DescribeReplicaPerformance_PerformanceValues.DescribeReplicaPerformance_PerformanceValueItem> performanceValues_performanceValue = new List<DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem.DescribeReplicaPerformance_PerformanceValues.DescribeReplicaPerformance_PerformanceValueItem>();
				for (int j = 0; j < context.Length("DescribeReplicaPerformance.PerformanceKeys.PerformanceKey["+ i +"].PerformanceValues.PerformanceValue.Length"); j++) {
					DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem.DescribeReplicaPerformance_PerformanceValues.DescribeReplicaPerformance_PerformanceValueItem performanceValueItem = new DescribeReplicaPerformanceResponse.DescribeReplicaPerformance_PerformanceKeys.DescribeReplicaPerformance_PerformanceKeyItem.DescribeReplicaPerformance_PerformanceValues.DescribeReplicaPerformance_PerformanceValueItem();
					performanceValueItem._Value = context.StringValue("DescribeReplicaPerformance.PerformanceKeys.PerformanceKey["+ i +"].PerformanceValues.PerformanceValue["+ j +"].Value");
					performanceValueItem.Date = context.StringValue("DescribeReplicaPerformance.PerformanceKeys.PerformanceKey["+ i +"].PerformanceValues.PerformanceValue["+ j +"].Date");

					performanceValues_performanceValue.Add(performanceValueItem);
				}
				performanceValues.PerformanceValue = performanceValues_performanceValue;
				performanceKeyItem.PerformanceValues = performanceValues;

				performanceKeys_performanceKey.Add(performanceKeyItem);
			}
			performanceKeys.PerformanceKey = performanceKeys_performanceKey;
			describeReplicaPerformanceResponse.PerformanceKeys = performanceKeys;
        
			return describeReplicaPerformanceResponse;
        }
    }
}