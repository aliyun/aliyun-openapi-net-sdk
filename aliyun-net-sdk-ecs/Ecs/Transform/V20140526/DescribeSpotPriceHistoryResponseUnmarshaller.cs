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
        public static DescribeSpotPriceHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSpotPriceHistoryResponse describeSpotPriceHistoryResponse = new DescribeSpotPriceHistoryResponse();

			describeSpotPriceHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeSpotPriceHistoryResponse.RequestId = _ctx.StringValue("DescribeSpotPriceHistory.RequestId");
			describeSpotPriceHistoryResponse.NextOffset = _ctx.IntegerValue("DescribeSpotPriceHistory.NextOffset");
			describeSpotPriceHistoryResponse.Currency = _ctx.StringValue("DescribeSpotPriceHistory.Currency");

			List<DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType> describeSpotPriceHistoryResponse_spotPrices = new List<DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType>();
			for (int i = 0; i < _ctx.Length("DescribeSpotPriceHistory.SpotPrices.Length"); i++) {
				DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType spotPriceType = new DescribeSpotPriceHistoryResponse.DescribeSpotPriceHistory_SpotPriceType();
				spotPriceType.ZoneId = _ctx.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].ZoneId");
				spotPriceType.InstanceType = _ctx.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].InstanceType");
				spotPriceType.IoOptimized = _ctx.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].IoOptimized");
				spotPriceType.Timestamp = _ctx.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].Timestamp");
				spotPriceType.NetworkType = _ctx.StringValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].NetworkType");
				spotPriceType.SpotPrice = _ctx.FloatValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].SpotPrice");
				spotPriceType.OriginPrice = _ctx.FloatValue("DescribeSpotPriceHistory.SpotPrices["+ i +"].OriginPrice");

				describeSpotPriceHistoryResponse_spotPrices.Add(spotPriceType);
			}
			describeSpotPriceHistoryResponse.SpotPrices = describeSpotPriceHistoryResponse_spotPrices;
        
			return describeSpotPriceHistoryResponse;
        }
    }
}
