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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetMin5StatisticsDataResponseUnmarshaller
    {
        public static GetMin5StatisticsDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetMin5StatisticsDataResponse getMin5StatisticsDataResponse = new GetMin5StatisticsDataResponse();

			getMin5StatisticsDataResponse.HttpResponse = context.HttpResponse;
			getMin5StatisticsDataResponse.ErrorMsg = context.StringValue("GetMin5StatisticsData.ErrorMsg");
			getMin5StatisticsDataResponse.CursorTime = context.StringValue("GetMin5StatisticsData.CursorTime");
			getMin5StatisticsDataResponse.Success = context.BooleanValue("GetMin5StatisticsData.Success");

			List<GetMin5StatisticsDataResponse.GetMin5StatisticsData_BaseStatisticsData> getMin5StatisticsDataResponse_baseStatisticsDatas = new List<GetMin5StatisticsDataResponse.GetMin5StatisticsData_BaseStatisticsData>();
			for (int i = 0; i < context.Length("GetMin5StatisticsData.BaseStatisticsDatas.Length"); i++) {
				GetMin5StatisticsDataResponse.GetMin5StatisticsData_BaseStatisticsData baseStatisticsData = new GetMin5StatisticsDataResponse.GetMin5StatisticsData_BaseStatisticsData();
				baseStatisticsData.MaleUvCount = context.IntegerValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].MaleUvCount");
				baseStatisticsData.Minute = context.StringValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].Minute");
				baseStatisticsData.StoreId = context.LongValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].StoreId");
				baseStatisticsData.Day = context.StringValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].Day");
				baseStatisticsData.LocationId = context.LongValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].LocationId");
				baseStatisticsData.StayPeriod = context.LongValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].StayPeriod");
				baseStatisticsData.UvCount = context.IntegerValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].UvCount");
				baseStatisticsData.OnlyBodyUvCount = context.IntegerValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].OnlyBodyUvCount");
				baseStatisticsData.Hour = context.StringValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].Hour");
				baseStatisticsData.FemaleUvCount = context.IntegerValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].FemaleUvCount");
				baseStatisticsData.OldCount = context.IntegerValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].OldCount");
				baseStatisticsData.NewCount = context.IntegerValue("GetMin5StatisticsData.BaseStatisticsDatas["+ i +"].NewCount");

				getMin5StatisticsDataResponse_baseStatisticsDatas.Add(baseStatisticsData);
			}
			getMin5StatisticsDataResponse.BaseStatisticsDatas = getMin5StatisticsDataResponse_baseStatisticsDatas;
        
			return getMin5StatisticsDataResponse;
        }
    }
}
