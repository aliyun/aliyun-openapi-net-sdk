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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSpotPriceHistoryResponseUnmarshaller
    {
        public static DescribeSpotPriceHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSpotPriceHistoryResponse describeSpotPriceHistoryResponse = new DescribeSpotPriceHistoryResponse();

			describeSpotPriceHistoryResponse.HttpResponse = context.HttpResponse;
			describeSpotPriceHistoryResponse.RequestId = context.StringValue("DescribeSpotPriceHistory.RequestId");
			describeSpotPriceHistoryResponse.NextOffset = context.IntegerValue("DescribeSpotPriceHistory.NextOffset");
			describeSpotPriceHistoryResponse.Currency = context.StringValue("DescribeSpotPriceHistory.Currency");

			List<DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType> describeSpotPriceHistoryResponse_spotPrices = new List<DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType>();
			for (int i = 0; i < context.Length("DescribeSpotPriceHistory.SpotPrices.Length"); i++) {
				DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType spotPriceType = new DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType();
				spotPriceType.ZoneId = context.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].ZoneId");
				spotPriceType.InstanceType = context.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].InstanceType");
				spotPriceType.IoOptimized = context.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].IoOptimized");
				spotPriceType.Timestamp = context.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].Timestamp");
				spotPriceType.NetworkType = context.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].NetworkType");
				spotPriceType.SpotPrice = context.FloatValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].SpotPrice");
				spotPriceType.OriginPrice = context.FloatValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].OriginPrice");

				describeSpotPriceHistoryResponse_spotPrices.Add(spotPriceType);
			}
			describeSpotPriceHistoryResponse.SpotPrices = describeSpotPriceHistoryResponse_spotPrices;
        
			return describeSpotPriceHistoryResponse;
        }
    }
}
