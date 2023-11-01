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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeCloudSiemAssetsCounterResponseUnmarshaller
    {
        public static DescribeCloudSiemAssetsCounterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudSiemAssetsCounterResponse describeCloudSiemAssetsCounterResponse = new DescribeCloudSiemAssetsCounterResponse();

			describeCloudSiemAssetsCounterResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudSiemAssetsCounterResponse.Success = _ctx.BooleanValue("DescribeCloudSiemAssetsCounter.Success");
			describeCloudSiemAssetsCounterResponse.Code = _ctx.IntegerValue("DescribeCloudSiemAssetsCounter.Code");
			describeCloudSiemAssetsCounterResponse.Message = _ctx.StringValue("DescribeCloudSiemAssetsCounter.Message");
			describeCloudSiemAssetsCounterResponse.RequestId = _ctx.StringValue("DescribeCloudSiemAssetsCounter.RequestId");

			List<DescribeCloudSiemAssetsCounterResponse.DescribeCloudSiemAssetsCounter_DataItem> describeCloudSiemAssetsCounterResponse_data = new List<DescribeCloudSiemAssetsCounterResponse.DescribeCloudSiemAssetsCounter_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCloudSiemAssetsCounter.Data.Length"); i++) {
				DescribeCloudSiemAssetsCounterResponse.DescribeCloudSiemAssetsCounter_DataItem dataItem = new DescribeCloudSiemAssetsCounterResponse.DescribeCloudSiemAssetsCounter_DataItem();
				dataItem.AssetType = _ctx.StringValue("DescribeCloudSiemAssetsCounter.Data["+ i +"].AssetType");
				dataItem.AssetNum = _ctx.IntegerValue("DescribeCloudSiemAssetsCounter.Data["+ i +"].AssetNum");

				describeCloudSiemAssetsCounterResponse_data.Add(dataItem);
			}
			describeCloudSiemAssetsCounterResponse.Data = describeCloudSiemAssetsCounterResponse_data;
        
			return describeCloudSiemAssetsCounterResponse;
        }
    }
}
