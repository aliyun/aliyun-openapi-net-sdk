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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveGrtnTrafficUsageResponseUnmarshaller
    {
        public static DescribeLiveGrtnTrafficUsageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveGrtnTrafficUsageResponse describeLiveGrtnTrafficUsageResponse = new DescribeLiveGrtnTrafficUsageResponse();

			describeLiveGrtnTrafficUsageResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveGrtnTrafficUsageResponse.AppId = _ctx.StringValue("DescribeLiveGrtnTrafficUsage.AppId");
			describeLiveGrtnTrafficUsageResponse.Area = _ctx.StringValue("DescribeLiveGrtnTrafficUsage.Area");
			describeLiveGrtnTrafficUsageResponse.EndTime = _ctx.StringValue("DescribeLiveGrtnTrafficUsage.EndTime");
			describeLiveGrtnTrafficUsageResponse.Filed = _ctx.StringValue("DescribeLiveGrtnTrafficUsage.Filed");
			describeLiveGrtnTrafficUsageResponse.RequestId = _ctx.StringValue("DescribeLiveGrtnTrafficUsage.RequestId");
			describeLiveGrtnTrafficUsageResponse.StartTime = _ctx.StringValue("DescribeLiveGrtnTrafficUsage.StartTime");

			List<DescribeLiveGrtnTrafficUsageResponse.DescribeLiveGrtnTrafficUsage_UsageData> describeLiveGrtnTrafficUsageResponse_usageDataPerInterval = new List<DescribeLiveGrtnTrafficUsageResponse.DescribeLiveGrtnTrafficUsage_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveGrtnTrafficUsage.UsageDataPerInterval.Length"); i++) {
				DescribeLiveGrtnTrafficUsageResponse.DescribeLiveGrtnTrafficUsage_UsageData usageData = new DescribeLiveGrtnTrafficUsageResponse.DescribeLiveGrtnTrafficUsage_UsageData();
				usageData.TimeStamp = _ctx.StringValue("DescribeLiveGrtnTrafficUsage.UsageDataPerInterval["+ i +"].TimeStamp");
				usageData._Value = _ctx.DoubleValue("DescribeLiveGrtnTrafficUsage.UsageDataPerInterval["+ i +"].Value");

				describeLiveGrtnTrafficUsageResponse_usageDataPerInterval.Add(usageData);
			}
			describeLiveGrtnTrafficUsageResponse.UsageDataPerInterval = describeLiveGrtnTrafficUsageResponse_usageDataPerInterval;
        
			return describeLiveGrtnTrafficUsageResponse;
        }
    }
}
