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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsDomainRegionDataResponseUnmarshaller
    {
        public static DescribeVsDomainRegionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainRegionDataResponse describeVsDomainRegionDataResponse = new DescribeVsDomainRegionDataResponse();

			describeVsDomainRegionDataResponse.HttpResponse = context.HttpResponse;
			describeVsDomainRegionDataResponse.RequestId = context.StringValue("DescribeVsDomainRegionData.RequestId");
			describeVsDomainRegionDataResponse.DomainName = context.StringValue("DescribeVsDomainRegionData.DomainName");
			describeVsDomainRegionDataResponse.DataInterval = context.StringValue("DescribeVsDomainRegionData.DataInterval");
			describeVsDomainRegionDataResponse.StartTime = context.StringValue("DescribeVsDomainRegionData.StartTime");
			describeVsDomainRegionDataResponse.EndTime = context.StringValue("DescribeVsDomainRegionData.EndTime");

			List<DescribeVsDomainRegionDataResponse.DescribeVsDomainRegionData_RegionProportionData> describeVsDomainRegionDataResponse_value = new List<DescribeVsDomainRegionDataResponse.DescribeVsDomainRegionData_RegionProportionData>();
			for (int i = 0; i < context.Length("DescribeVsDomainRegionData.Value.Length"); i++) {
				DescribeVsDomainRegionDataResponse.DescribeVsDomainRegionData_RegionProportionData regionProportionData = new DescribeVsDomainRegionDataResponse.DescribeVsDomainRegionData_RegionProportionData();
				regionProportionData.Region = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.Qps = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.AvgResponseRate = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.ReqErrRate = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].ReqErrRate");
				regionProportionData.TotalBytes = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = context.StringValue("DescribeVsDomainRegionData.Value["+ i +"].TotalQuery");

				describeVsDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeVsDomainRegionDataResponse._Value = describeVsDomainRegionDataResponse_value;
        
			return describeVsDomainRegionDataResponse;
        }
    }
}
