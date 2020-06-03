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
        public static DescribeDataCenterResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataCenterResponse describeDataCenterResponse = new DescribeDataCenterResponse();

			describeDataCenterResponse.HttpResponse = context.HttpResponse;
			describeDataCenterResponse.RequestId = context.StringValue("DescribeDataCenter.RequestId");
			describeDataCenterResponse.DataCenterId = context.StringValue("DescribeDataCenter.DataCenterId");
			describeDataCenterResponse.RegionId = context.StringValue("DescribeDataCenter.RegionId");
			describeDataCenterResponse.ZoneId = context.StringValue("DescribeDataCenter.ZoneId");
			describeDataCenterResponse.ClusterId = context.StringValue("DescribeDataCenter.ClusterId");
			describeDataCenterResponse.DataCenterName = context.StringValue("DescribeDataCenter.DataCenterName");
			describeDataCenterResponse.Status = context.StringValue("DescribeDataCenter.Status");
			describeDataCenterResponse.CreatedTime = context.StringValue("DescribeDataCenter.CreatedTime");
			describeDataCenterResponse.InstanceType = context.StringValue("DescribeDataCenter.InstanceType");
			describeDataCenterResponse.NodeCount = context.IntegerValue("DescribeDataCenter.NodeCount");
			describeDataCenterResponse.DiskType = context.StringValue("DescribeDataCenter.DiskType");
			describeDataCenterResponse.DiskSize = context.IntegerValue("DescribeDataCenter.DiskSize");
			describeDataCenterResponse.VpcId = context.StringValue("DescribeDataCenter.VpcId");
			describeDataCenterResponse.VswitchId = context.StringValue("DescribeDataCenter.VswitchId");
			describeDataCenterResponse.PayType = context.StringValue("DescribeDataCenter.PayType");
			describeDataCenterResponse.CommodityInstance = context.StringValue("DescribeDataCenter.CommodityInstance");
			describeDataCenterResponse.ExpireTime = context.StringValue("DescribeDataCenter.ExpireTime");
			describeDataCenterResponse.LockMode = context.StringValue("DescribeDataCenter.LockMode");
			describeDataCenterResponse.AutoRenewal = context.BooleanValue("DescribeDataCenter.AutoRenewal");
			describeDataCenterResponse.AutoRenewPeriod = context.IntegerValue("DescribeDataCenter.AutoRenewPeriod");
        
			return describeDataCenterResponse;
        }
    }
}
