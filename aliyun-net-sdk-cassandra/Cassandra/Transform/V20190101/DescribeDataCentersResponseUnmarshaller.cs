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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeDataCentersResponseUnmarshaller
    {
        public static DescribeDataCentersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataCentersResponse describeDataCentersResponse = new DescribeDataCentersResponse();

			describeDataCentersResponse.HttpResponse = context.HttpResponse;
			describeDataCentersResponse.RequestId = context.StringValue("DescribeDataCenters.RequestId");

			List<DescribeDataCentersResponse.DescribeDataCenters_DataCenter> describeDataCentersResponse_dataCenters = new List<DescribeDataCentersResponse.DescribeDataCenters_DataCenter>();
			for (int i = 0; i < context.Length("DescribeDataCenters.DataCenters.Length"); i++) {
				DescribeDataCentersResponse.DescribeDataCenters_DataCenter dataCenter = new DescribeDataCentersResponse.DescribeDataCenters_DataCenter();
				dataCenter.DataCenterId = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].DataCenterId");
				dataCenter.RegionId = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].RegionId");
				dataCenter.ZoneId = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].ZoneId");
				dataCenter.ClusterId = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].ClusterId");
				dataCenter.DataCenterName = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].DataCenterName");
				dataCenter.Status = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].Status");
				dataCenter.CreatedTime = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].CreatedTime");
				dataCenter.InstanceType = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].InstanceType");
				dataCenter.NodeCount = context.IntegerValue("DescribeDataCenters.DataCenters["+ i +"].NodeCount");
				dataCenter.DiskType = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].DiskType");
				dataCenter.DiskSize = context.IntegerValue("DescribeDataCenters.DataCenters["+ i +"].DiskSize");
				dataCenter.VpcId = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].VpcId");
				dataCenter.VswitchId = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].VswitchId");
				dataCenter.PayType = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].PayType");
				dataCenter.CommodityInstance = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].CommodityInstance");
				dataCenter.ExpireTime = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].ExpireTime");
				dataCenter.LockMode = context.StringValue("DescribeDataCenters.DataCenters["+ i +"].LockMode");
				dataCenter.AutoRenewal = context.BooleanValue("DescribeDataCenters.DataCenters["+ i +"].AutoRenewal");
				dataCenter.AutoRenewPeriod = context.IntegerValue("DescribeDataCenters.DataCenters["+ i +"].AutoRenewPeriod");

				describeDataCentersResponse_dataCenters.Add(dataCenter);
			}
			describeDataCentersResponse.DataCenters = describeDataCentersResponse_dataCenters;
        
			return describeDataCentersResponse;
        }
    }
}
