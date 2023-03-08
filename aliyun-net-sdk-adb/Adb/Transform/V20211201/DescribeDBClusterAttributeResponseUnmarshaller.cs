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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeDBClusterAttributeResponseUnmarshaller
    {
        public static DescribeDBClusterAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterAttributeResponse describeDBClusterAttributeResponse = new DescribeDBClusterAttributeResponse();

			describeDBClusterAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterAttributeResponse.RequestId = _ctx.StringValue("DescribeDBClusterAttribute.RequestId");

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster> describeDBClusterAttributeResponse_items = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.Items.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster dBCluster = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster();
				dBCluster.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].CreationTime");
				dBCluster.Expired = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Expired");
				dBCluster.MaintainTime = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].MaintainTime");
				dBCluster.PayType = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].PayType");
				dBCluster.Mode = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Mode");
				dBCluster.Port = _ctx.IntegerValue("DescribeDBClusterAttribute.Items["+ i +"].Port");
				dBCluster.LockMode = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].LockMode");
				dBCluster.EngineVersion = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].EngineVersion");
				dBCluster.StorageResource = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].StorageResource");
				dBCluster.DBClusterId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterId");
				dBCluster.ConnectionString = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ConnectionString");
				dBCluster.DBClusterType = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterType");
				dBCluster.CommodityCode = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].CommodityCode");
				dBCluster.ExpireTime = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ExpireTime");
				dBCluster.LockReason = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].LockReason");
				dBCluster.VPCId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VPCId");
				dBCluster.ComputeResource = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ComputeResource");
				dBCluster.RegionId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].RegionId");
				dBCluster.VSwitchId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VSwitchId");
				dBCluster.DBVersion = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBVersion");
				dBCluster.DBClusterStatus = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterStatus");
				dBCluster.ResourceGroupId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ResourceGroupId");
				dBCluster.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterNetworkType");
				dBCluster.DBClusterDescription = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterDescription");
				dBCluster.UserENIStatus = _ctx.BooleanValue("DescribeDBClusterAttribute.Items["+ i +"].UserENIStatus");
				dBCluster.ZoneId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ZoneId");
				dBCluster.Engine = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Engine");
				dBCluster.ReservedACU = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ReservedACU");
				dBCluster.ComputeResourceTotal = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ComputeResourceTotal");
				dBCluster.StorageResourceTotal = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].StorageResourceTotal");

				describeDBClusterAttributeResponse_items.Add(dBCluster);
			}
			describeDBClusterAttributeResponse.Items = describeDBClusterAttributeResponse_items;
        
			return describeDBClusterAttributeResponse;
        }
    }
}
