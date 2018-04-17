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
using Aliyun.Acs.Iot.Model.V20180120;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryDeviceStatisticsResponseUnmarshaller
    {
        public static QueryDeviceStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceStatisticsResponse queryDeviceStatisticsResponse = new QueryDeviceStatisticsResponse();

			queryDeviceStatisticsResponse.HttpResponse = context.HttpResponse;
			queryDeviceStatisticsResponse.RequestId = context.StringValue("QueryDeviceStatistics.RequestId");
			queryDeviceStatisticsResponse.Success = context.BooleanValue("QueryDeviceStatistics.Success");
			queryDeviceStatisticsResponse.ErrorMessage = context.StringValue("QueryDeviceStatistics.ErrorMessage");

			QueryDeviceStatisticsResponse.QueryDeviceStatistics_Data data = new QueryDeviceStatisticsResponse.QueryDeviceStatistics_Data();
			data.DeviceCount = context.LongValue("QueryDeviceStatistics.Data.DeviceCount");
			data.OnlineCount = context.LongValue("QueryDeviceStatistics.Data.OnlineCount");
			data.ActiveCount = context.LongValue("QueryDeviceStatistics.Data.ActiveCount");
			queryDeviceStatisticsResponse.Data = data;
        
			return queryDeviceStatisticsResponse;
        }
    }
}