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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeStoreStatisticsResponseUnmarshaller
    {
        public static DescribeStoreStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStoreStatisticsResponse describeStoreStatisticsResponse = new DescribeStoreStatisticsResponse();

			describeStoreStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeStoreStatisticsResponse.ErrorMessage = _ctx.StringValue("DescribeStoreStatistics.ErrorMessage");
			describeStoreStatisticsResponse.ErrorCode = _ctx.StringValue("DescribeStoreStatistics.ErrorCode");
			describeStoreStatisticsResponse.Message = _ctx.StringValue("DescribeStoreStatistics.Message");
			describeStoreStatisticsResponse.DynamicCode = _ctx.StringValue("DescribeStoreStatistics.DynamicCode");
			describeStoreStatisticsResponse.Code = _ctx.StringValue("DescribeStoreStatistics.Code");
			describeStoreStatisticsResponse.DynamicMessage = _ctx.StringValue("DescribeStoreStatistics.DynamicMessage");
			describeStoreStatisticsResponse.RequestId = _ctx.StringValue("DescribeStoreStatistics.RequestId");
			describeStoreStatisticsResponse.Success = _ctx.BooleanValue("DescribeStoreStatistics.Success");

			List<DescribeStoreStatisticsResponse.DescribeStoreStatistics_StoreStatisticsInfo> describeStoreStatisticsResponse_storeStatisticsInfoList = new List<DescribeStoreStatisticsResponse.DescribeStoreStatistics_StoreStatisticsInfo>();
			for (int i = 0; i < _ctx.Length("DescribeStoreStatistics.StoreStatisticsInfoList.Length"); i++) {
				DescribeStoreStatisticsResponse.DescribeStoreStatistics_StoreStatisticsInfo storeStatisticsInfo = new DescribeStoreStatisticsResponse.DescribeStoreStatistics_StoreStatisticsInfo();
				storeStatisticsInfo.SendFailEsl = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].SendFailEsl");
				storeStatisticsInfo.DisplayFailEsl = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].DisplayFailEsl");
				storeStatisticsInfo.StoreName = _ctx.StringValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].StoreName");
				storeStatisticsInfo.ActiveApDevice = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].ActiveApDevice");
				storeStatisticsInfo.UpdateFailureEsl = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].UpdateFailureEsl");
				storeStatisticsInfo.UpdateEsl = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].UpdateEsl");
				storeStatisticsInfo.OfflineEslDevice = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].OfflineEslDevice");
				storeStatisticsInfo.StatisticsTime = _ctx.StringValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].StatisticsTime");
				storeStatisticsInfo.StoreId = _ctx.StringValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].StoreId");
				storeStatisticsInfo.BindEsl = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].BindEsl");
				storeStatisticsInfo.AbnormalEsl = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].AbnormalEsl");
				storeStatisticsInfo.LowBatteryEsl = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].LowBatteryEsl");
				storeStatisticsInfo.BindItem = _ctx.IntegerValue("DescribeStoreStatistics.StoreStatisticsInfoList["+ i +"].BindItem");

				describeStoreStatisticsResponse_storeStatisticsInfoList.Add(storeStatisticsInfo);
			}
			describeStoreStatisticsResponse.StoreStatisticsInfoList = describeStoreStatisticsResponse_storeStatisticsInfoList;
        
			return describeStoreStatisticsResponse;
        }
    }
}
