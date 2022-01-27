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
        public static DescribeDataCentersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataCentersResponse describeDataCentersResponse = new DescribeDataCentersResponse();

			describeDataCentersResponse.HttpResponse = _ctx.HttpResponse;
			describeDataCentersResponse.RequestId = _ctx.StringValue("DescribeDataCenters.RequestId");

			List<DescribeDataCentersResponse.DescribeDataCenters_DataCenter> describeDataCentersResponse_dataCenters = new List<DescribeDataCentersResponse.DescribeDataCenters_DataCenter>();
			for (int i = 0; i < _ctx.Length("DescribeDataCenters.DataCenters.Length"); i++) {
				DescribeDataCentersResponse.DescribeDataCenters_DataCenter dataCenter = new DescribeDataCentersResponse.DescribeDataCenters_DataCenter();
				dataCenter.DataCenterId = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].DataCenterId");
				dataCenter.RegionId = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].RegionId");
				dataCenter.ZoneId = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].ZoneId");
				dataCenter.ClusterId = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].ClusterId");
				dataCenter.DataCenterName = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].DataCenterName");
				dataCenter.Status = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].Status");
				dataCenter.CreatedTime = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].CreatedTime");
				dataCenter.InstanceType = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].InstanceType");
				dataCenter.NodeCount = _ctx.IntegerValue("DescribeDataCenters.DataCenters["+ i +"].NodeCount");
				dataCenter.DiskType = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].DiskType");
				dataCenter.DiskSize = _ctx.IntegerValue("DescribeDataCenters.DataCenters["+ i +"].DiskSize");
				dataCenter.VpcId = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].VpcId");
				dataCenter.VswitchId = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].VswitchId");
				dataCenter.PayType = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].PayType");
				dataCenter.CommodityInstance = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].CommodityInstance");
				dataCenter.ExpireTime = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].ExpireTime");
				dataCenter.LockMode = _ctx.StringValue("DescribeDataCenters.DataCenters["+ i +"].LockMode");
				dataCenter.AutoRenewal = _ctx.BooleanValue("DescribeDataCenters.DataCenters["+ i +"].AutoRenewal");
				dataCenter.AutoRenewPeriod = _ctx.IntegerValue("DescribeDataCenters.DataCenters["+ i +"].AutoRenewPeriod");

				describeDataCentersResponse_dataCenters.Add(dataCenter);
			}
			describeDataCentersResponse.DataCenters = describeDataCentersResponse_dataCenters;
        
			return describeDataCentersResponse;
        }
    }
}
