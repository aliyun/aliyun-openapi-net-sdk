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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
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
				dBCluster.RegionId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].RegionId");
				dBCluster.ZoneId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ZoneId");
				dBCluster.DBClusterId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterId");
				dBCluster.DBClusterType = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterType");
				dBCluster.DBClusterDescription = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterDescription");
				dBCluster.Category = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Category");
				dBCluster.LockMode = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].LockMode");
				dBCluster.LockReason = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].LockReason");
				dBCluster.PayType = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].PayType");
				dBCluster.DBVersion = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBVersion");
				dBCluster.DBClusterStatus = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterStatus");
				dBCluster.DBNodeStorage = _ctx.LongValue("DescribeDBClusterAttribute.Items["+ i +"].DBNodeStorage");
				dBCluster.DBNodeClass = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBNodeClass");
				dBCluster.DBNodeCount = _ctx.LongValue("DescribeDBClusterAttribute.Items["+ i +"].DBNodeCount");
				dBCluster.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].CreationTime");
				dBCluster.ExpireTime = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ExpireTime");
				dBCluster.Expired = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Expired");
				dBCluster.MaintainTime = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].MaintainTime");
				dBCluster.Engine = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Engine");
				dBCluster.VPCId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VPCId");
				dBCluster.VSwitchId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VSwitchId");
				dBCluster.VPCCloudInstanceId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VPCCloudInstanceId");
				dBCluster.CommodityCode = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].CommodityCode");
				dBCluster.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterNetworkType");
				dBCluster.ConnectionString = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ConnectionString");
				dBCluster.Port = _ctx.IntegerValue("DescribeDBClusterAttribute.Items["+ i +"].Port");
				dBCluster.RdsInstanceId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].RdsInstanceId");
				dBCluster.DtsJobId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DtsJobId");
				dBCluster.ExecutorCount = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ExecutorCount");
				dBCluster.DiskType = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DiskType");
				dBCluster.ComputeResource = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ComputeResource");
				dBCluster.StorageResource = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].StorageResource");
				dBCluster.Mode = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Mode");
				dBCluster.ResourceGroupId = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ResourceGroupId");
				dBCluster.ElasticIOResource = _ctx.IntegerValue("DescribeDBClusterAttribute.Items["+ i +"].ElasticIOResource");
				dBCluster.EngineVersion = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].EngineVersion");
				dBCluster.UserENIStatus = _ctx.BooleanValue("DescribeDBClusterAttribute.Items["+ i +"].UserENIStatus");
				dBCluster.EnableSpark = _ctx.BooleanValue("DescribeDBClusterAttribute.Items["+ i +"].EnableSpark");
				dBCluster.EnableAirflow = _ctx.BooleanValue("DescribeDBClusterAttribute.Items["+ i +"].EnableAirflow");

				List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag> dBCluster_tags = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterAttribute.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag tag = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag();
					tag.Key = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Tags["+ j +"].Value");

					dBCluster_tags.Add(tag);
				}
				dBCluster.Tags = dBCluster_tags;

				describeDBClusterAttributeResponse_items.Add(dBCluster);
			}
			describeDBClusterAttributeResponse.Items = describeDBClusterAttributeResponse_items;
        
			return describeDBClusterAttributeResponse;
        }
    }
}
