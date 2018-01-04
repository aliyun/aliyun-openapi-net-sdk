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
using Aliyun.Acs.TeslaMaxCompute.Model.V20180104;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Transform.V20180104
{
    public class GetQuotaHistoryInfoResponseUnmarshaller
    {
        public static GetQuotaHistoryInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetQuotaHistoryInfoResponse getQuotaHistoryInfoResponse = new GetQuotaHistoryInfoResponse();

			getQuotaHistoryInfoResponse.HttpResponse = context.HttpResponse;
			getQuotaHistoryInfoResponse.Code = context.IntegerValue("GetQuotaHistoryInfo.Code");
			getQuotaHistoryInfoResponse.Message = context.StringValue("GetQuotaHistoryInfo.Message");
			getQuotaHistoryInfoResponse.RequestId = context.StringValue("GetQuotaHistoryInfo.RequestId");

			List<GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem> getQuotaHistoryInfoResponse_data = new List<GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem>();
			for (int i = 0; i < context.Length("GetQuotaHistoryInfo.Data.Length"); i++) {
				GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem dataItem = new GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem();
				dataItem.Times = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Times");

				GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point point = new GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point();

				GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_CpuMaxQuota cpuMaxQuota = new GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_CpuMaxQuota();
				cpuMaxQuota.Min = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuMaxQuota.Min");
				cpuMaxQuota.Max = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuMaxQuota.Max");
				cpuMaxQuota.Avg = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuMaxQuota.Avg");
				point.CpuMaxQuota = cpuMaxQuota;

				GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_CpuMinQuota cpuMinQuota = new GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_CpuMinQuota();
				cpuMinQuota.Min = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuMinQuota.Min");
				cpuMinQuota.Max = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuMinQuota.Max");
				cpuMinQuota.Avg = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuMinQuota.Avg");
				point.CpuMinQuota = cpuMinQuota;

				GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_MemUsed memUsed = new GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_MemUsed();
				memUsed.Min = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.MemUsed.Min");
				memUsed.Max = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.MemUsed.Max");
				memUsed.Avg = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.MemUsed.Avg");
				point.MemUsed = memUsed;

				GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_CpuUsed cpuUsed = new GetQuotaHistoryInfoResponse.GetQuotaHistoryInfo_DataItem.GetQuotaHistoryInfo_Point.GetQuotaHistoryInfo_CpuUsed();
				cpuUsed.Min = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuUsed.Min");
				cpuUsed.Max = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuUsed.Max");
				cpuUsed.Avg = context.IntegerValue("GetQuotaHistoryInfo.Data["+ i +"].Point.CpuUsed.Avg");
				point.CpuUsed = cpuUsed;
				dataItem.Point = point;

				getQuotaHistoryInfoResponse_data.Add(dataItem);
			}
			getQuotaHistoryInfoResponse.Data = getQuotaHistoryInfoResponse_data;
        
			return getQuotaHistoryInfoResponse;
        }
    }
}