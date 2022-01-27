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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeHoneyPotSuspStatisticsResponseUnmarshaller
    {
        public static DescribeHoneyPotSuspStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHoneyPotSuspStatisticsResponse describeHoneyPotSuspStatisticsResponse = new DescribeHoneyPotSuspStatisticsResponse();

			describeHoneyPotSuspStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeHoneyPotSuspStatisticsResponse.RequestId = _ctx.StringValue("DescribeHoneyPotSuspStatistics.RequestId");

			List<DescribeHoneyPotSuspStatisticsResponse.DescribeHoneyPotSuspStatistics_SuspHoneyPotStatisticsResponseItem> describeHoneyPotSuspStatisticsResponse_suspHoneyPotStatisticsResponse = new List<DescribeHoneyPotSuspStatisticsResponse.DescribeHoneyPotSuspStatistics_SuspHoneyPotStatisticsResponseItem>();
			for (int i = 0; i < _ctx.Length("DescribeHoneyPotSuspStatistics.SuspHoneyPotStatisticsResponse.Length"); i++) {
				DescribeHoneyPotSuspStatisticsResponse.DescribeHoneyPotSuspStatistics_SuspHoneyPotStatisticsResponseItem suspHoneyPotStatisticsResponseItem = new DescribeHoneyPotSuspStatisticsResponse.DescribeHoneyPotSuspStatistics_SuspHoneyPotStatisticsResponseItem();
				suspHoneyPotStatisticsResponseItem.Count = _ctx.IntegerValue("DescribeHoneyPotSuspStatistics.SuspHoneyPotStatisticsResponse["+ i +"].Count");
				suspHoneyPotStatisticsResponseItem.Type = _ctx.StringValue("DescribeHoneyPotSuspStatistics.SuspHoneyPotStatisticsResponse["+ i +"].Type");
				suspHoneyPotStatisticsResponseItem.InstanceId = _ctx.StringValue("DescribeHoneyPotSuspStatistics.SuspHoneyPotStatisticsResponse["+ i +"].InstanceId");
				suspHoneyPotStatisticsResponseItem.InstanceName = _ctx.StringValue("DescribeHoneyPotSuspStatistics.SuspHoneyPotStatisticsResponse["+ i +"].InstanceName");
				suspHoneyPotStatisticsResponseItem.VpcId = _ctx.StringValue("DescribeHoneyPotSuspStatistics.SuspHoneyPotStatisticsResponse["+ i +"].VpcId");
				suspHoneyPotStatisticsResponseItem.VpcName = _ctx.StringValue("DescribeHoneyPotSuspStatistics.SuspHoneyPotStatisticsResponse["+ i +"].VpcName");

				describeHoneyPotSuspStatisticsResponse_suspHoneyPotStatisticsResponse.Add(suspHoneyPotStatisticsResponseItem);
			}
			describeHoneyPotSuspStatisticsResponse.SuspHoneyPotStatisticsResponse = describeHoneyPotSuspStatisticsResponse_suspHoneyPotStatisticsResponse;
        
			return describeHoneyPotSuspStatisticsResponse;
        }
    }
}
