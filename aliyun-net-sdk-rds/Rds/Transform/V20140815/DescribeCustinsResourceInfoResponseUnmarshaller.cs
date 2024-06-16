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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeCustinsResourceInfoResponseUnmarshaller
    {
        public static DescribeCustinsResourceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustinsResourceInfoResponse describeCustinsResourceInfoResponse = new DescribeCustinsResourceInfoResponse();

			describeCustinsResourceInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeCustinsResourceInfoResponse.RequestId = _ctx.StringValue("DescribeCustinsResourceInfo.RequestId");

			List<DescribeCustinsResourceInfoResponse.DescribeCustinsResourceInfo_DataItem> describeCustinsResourceInfoResponse_data = new List<DescribeCustinsResourceInfoResponse.DescribeCustinsResourceInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCustinsResourceInfo.Data.Length"); i++) {
				DescribeCustinsResourceInfoResponse.DescribeCustinsResourceInfo_DataItem dataItem = new DescribeCustinsResourceInfoResponse.DescribeCustinsResourceInfo_DataItem();
				dataItem.MaxIopsIncreaseRatio = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MaxIopsIncreaseRatio");
				dataItem.MaxConnIncreaseRatioValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MaxConnIncreaseRatioValue");
				dataItem.MemoryAdjustDeadline = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MemoryAdjustDeadline");
				dataItem.MemAdjustableMaxValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MemAdjustableMaxValue");
				dataItem.IopsAdjustableMaxValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].IopsAdjustableMaxValue");
				dataItem.CpuIncreaseRatio = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].CpuIncreaseRatio");
				dataItem.MaxIopsIncreaseRatioValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MaxIopsIncreaseRatioValue");
				dataItem.OriginMaxConn = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].OriginMaxConn");
				dataItem.MemoryIncreaseRatioValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MemoryIncreaseRatioValue");
				dataItem.MaxConnIncreaseRatio = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MaxConnIncreaseRatio");
				dataItem.CpuIncreaseRatioValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].CpuIncreaseRatioValue");
				dataItem.OriginMaxIops = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].OriginMaxIops");
				dataItem.MaxConnAdjustableMaxValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MaxConnAdjustableMaxValue");
				dataItem.MaxConnAdjustDeadline = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MaxConnAdjustDeadline");
				dataItem.MaxIopsAdjustDeadline = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MaxIopsAdjustDeadline");
				dataItem.OriginMemory = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].OriginMemory");
				dataItem.MemAdjustableMaxRatio = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MemAdjustableMaxRatio");
				dataItem.CpuAdjustableMaxValue = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].CpuAdjustableMaxValue");
				dataItem.CpuAdjustableMaxRatio = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].CpuAdjustableMaxRatio");
				dataItem.CpuAdjustDeadline = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].CpuAdjustDeadline");
				dataItem.MemoryIncreaseRatio = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].MemoryIncreaseRatio");
				dataItem.OriginCpu = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].OriginCpu");
				dataItem.DBInstanceId = _ctx.StringValue("DescribeCustinsResourceInfo.Data["+ i +"].DBInstanceId");

				describeCustinsResourceInfoResponse_data.Add(dataItem);
			}
			describeCustinsResourceInfoResponse.Data = describeCustinsResourceInfoResponse_data;
        
			return describeCustinsResourceInfoResponse;
        }
    }
}
