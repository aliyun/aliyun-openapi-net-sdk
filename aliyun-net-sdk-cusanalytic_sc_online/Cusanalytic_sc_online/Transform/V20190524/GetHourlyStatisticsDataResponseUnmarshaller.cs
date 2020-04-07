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
    public class GetHourlyStatisticsDataResponseUnmarshaller
    {
        public static GetHourlyStatisticsDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetHourlyStatisticsDataResponse getHourlyStatisticsDataResponse = new GetHourlyStatisticsDataResponse();

			getHourlyStatisticsDataResponse.HttpResponse = context.HttpResponse;
			getHourlyStatisticsDataResponse.ErrorMsg = context.StringValue("GetHourlyStatisticsData.ErrorMsg");
			getHourlyStatisticsDataResponse.CursorTime = context.StringValue("GetHourlyStatisticsData.CursorTime");
			getHourlyStatisticsDataResponse.Success = context.BooleanValue("GetHourlyStatisticsData.Success");

			List<GetHourlyStatisticsDataResponse.GetHourlyStatisticsData_BaseStatisticsData> getHourlyStatisticsDataResponse_baseStatisticsDatas = new List<GetHourlyStatisticsDataResponse.GetHourlyStatisticsData_BaseStatisticsData>();
			for (int i = 0; i < context.Length("GetHourlyStatisticsData.BaseStatisticsDatas.Length"); i++) {
				GetHourlyStatisticsDataResponse.GetHourlyStatisticsData_BaseStatisticsData baseStatisticsData = new GetHourlyStatisticsDataResponse.GetHourlyStatisticsData_BaseStatisticsData();
				baseStatisticsData.MaleUvCount = context.IntegerValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].MaleUvCount");
				baseStatisticsData.StoreId = context.LongValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].StoreId");
				baseStatisticsData.Day = context.StringValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].Day");
				baseStatisticsData.LocationId = context.LongValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].LocationId");
				baseStatisticsData.StayPeriod = context.IntegerValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].StayPeriod");
				baseStatisticsData.UvCount = context.IntegerValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].UvCount");
				baseStatisticsData.OnlyBodyUvCount = context.IntegerValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].OnlyBodyUvCount");
				baseStatisticsData.Hour = context.StringValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].Hour");
				baseStatisticsData.FemaleUvCount = context.IntegerValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].FemaleUvCount");
				baseStatisticsData.OldCount = context.IntegerValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].OldCount");
				baseStatisticsData.NewCount = context.IntegerValue("GetHourlyStatisticsData.BaseStatisticsDatas["+ i +"].NewCount");

				getHourlyStatisticsDataResponse_baseStatisticsDatas.Add(baseStatisticsData);
			}
			getHourlyStatisticsDataResponse.BaseStatisticsDatas = getHourlyStatisticsDataResponse_baseStatisticsDatas;
        
			return getHourlyStatisticsDataResponse;
        }
    }
}
