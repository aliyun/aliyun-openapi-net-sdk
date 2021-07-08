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
    public class DescribeDataCenterResponseUnmarshaller
    {
        public static DescribeDataCenterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataCenterResponse describeDataCenterResponse = new DescribeDataCenterResponse();

			describeDataCenterResponse.HttpResponse = _ctx.HttpResponse;
			describeDataCenterResponse.RequestId = _ctx.StringValue("DescribeDataCenter.RequestId");
			describeDataCenterResponse.DataCenterId = _ctx.StringValue("DescribeDataCenter.DataCenterId");
			describeDataCenterResponse.RegionId = _ctx.StringValue("DescribeDataCenter.RegionId");
			describeDataCenterResponse.ZoneId = _ctx.StringValue("DescribeDataCenter.ZoneId");
			describeDataCenterResponse.ClusterId = _ctx.StringValue("DescribeDataCenter.ClusterId");
			describeDataCenterResponse.DataCenterName = _ctx.StringValue("DescribeDataCenter.DataCenterName");
			describeDataCenterResponse.Status = _ctx.StringValue("DescribeDataCenter.Status");
			describeDataCenterResponse.CreatedTime = _ctx.StringValue("DescribeDataCenter.CreatedTime");
			describeDataCenterResponse.InstanceType = _ctx.StringValue("DescribeDataCenter.InstanceType");
			describeDataCenterResponse.NodeCount = _ctx.IntegerValue("DescribeDataCenter.NodeCount");
			describeDataCenterResponse.DiskType = _ctx.StringValue("DescribeDataCenter.DiskType");
			describeDataCenterResponse.DiskSize = _ctx.IntegerValue("DescribeDataCenter.DiskSize");
			describeDataCenterResponse.VpcId = _ctx.StringValue("DescribeDataCenter.VpcId");
			describeDataCenterResponse.VswitchId = _ctx.StringValue("DescribeDataCenter.VswitchId");
			describeDataCenterResponse.PayType = _ctx.StringValue("DescribeDataCenter.PayType");
			describeDataCenterResponse.CommodityInstance = _ctx.StringValue("DescribeDataCenter.CommodityInstance");
			describeDataCenterResponse.ExpireTime = _ctx.StringValue("DescribeDataCenter.ExpireTime");
			describeDataCenterResponse.LockMode = _ctx.StringValue("DescribeDataCenter.LockMode");
			describeDataCenterResponse.AutoRenewal = _ctx.BooleanValue("DescribeDataCenter.AutoRenewal");
			describeDataCenterResponse.AutoRenewPeriod = _ctx.IntegerValue("DescribeDataCenter.AutoRenewPeriod");
        
			return describeDataCenterResponse;
        }
    }
}
