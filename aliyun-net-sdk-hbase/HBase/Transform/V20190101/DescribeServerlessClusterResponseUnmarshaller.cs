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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeServerlessClusterResponseUnmarshaller
    {
        public static DescribeServerlessClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeServerlessClusterResponse describeServerlessClusterResponse = new DescribeServerlessClusterResponse();

			describeServerlessClusterResponse.HttpResponse = _ctx.HttpResponse;
			describeServerlessClusterResponse.RequestId = _ctx.StringValue("DescribeServerlessCluster.RequestId");
			describeServerlessClusterResponse.VpcId = _ctx.StringValue("DescribeServerlessCluster.VpcId");
			describeServerlessClusterResponse.VSwitchId = _ctx.StringValue("DescribeServerlessCluster.VSwitchId");
			describeServerlessClusterResponse.InstanceId = _ctx.StringValue("DescribeServerlessCluster.InstanceId");
			describeServerlessClusterResponse.InstanceName = _ctx.StringValue("DescribeServerlessCluster.InstanceName");
			describeServerlessClusterResponse.MainVersion = _ctx.StringValue("DescribeServerlessCluster.MainVersion");
			describeServerlessClusterResponse.Status = _ctx.StringValue("DescribeServerlessCluster.Status");
			describeServerlessClusterResponse.ClusterType = _ctx.StringValue("DescribeServerlessCluster.ClusterType");
			describeServerlessClusterResponse.HasUser = _ctx.StringValue("DescribeServerlessCluster.HasUser");
			describeServerlessClusterResponse.LockMode = _ctx.StringValue("DescribeServerlessCluster.LockMode");
			describeServerlessClusterResponse.HaType = _ctx.StringValue("DescribeServerlessCluster.HaType");
			describeServerlessClusterResponse.PayType = _ctx.StringValue("DescribeServerlessCluster.PayType");
			describeServerlessClusterResponse.InnerEndpoint = _ctx.StringValue("DescribeServerlessCluster.InnerEndpoint");
			describeServerlessClusterResponse.OuterEndpoint = _ctx.StringValue("DescribeServerlessCluster.OuterEndpoint");
			describeServerlessClusterResponse.ReserverMinQpsNum = _ctx.StringValue("DescribeServerlessCluster.ReserverMinQpsNum");
			describeServerlessClusterResponse.ReserverMaxQpsNum = _ctx.StringValue("DescribeServerlessCluster.ReserverMaxQpsNum");
			describeServerlessClusterResponse.AutoRenew = _ctx.StringValue("DescribeServerlessCluster.AutoRenew");
			describeServerlessClusterResponse.CreateTime = _ctx.StringValue("DescribeServerlessCluster.CreateTime");
			describeServerlessClusterResponse.ExpireTime = _ctx.StringValue("DescribeServerlessCluster.ExpireTime");
			describeServerlessClusterResponse.RegionId = _ctx.StringValue("DescribeServerlessCluster.RegionId");
			describeServerlessClusterResponse.ZoneId = _ctx.StringValue("DescribeServerlessCluster.ZoneId");
			describeServerlessClusterResponse.UpdateStatus = _ctx.StringValue("DescribeServerlessCluster.UpdateStatus");
			describeServerlessClusterResponse.IsDeletionProtection = _ctx.StringValue("DescribeServerlessCluster.IsDeletionProtection");
			describeServerlessClusterResponse.DiskSize = _ctx.StringValue("DescribeServerlessCluster.DiskSize");
			describeServerlessClusterResponse.CuSize = _ctx.StringValue("DescribeServerlessCluster.CuSize");
			describeServerlessClusterResponse.ResourceGroupId = _ctx.StringValue("DescribeServerlessCluster.ResourceGroupId");
        
			return describeServerlessClusterResponse;
        }
    }
}
