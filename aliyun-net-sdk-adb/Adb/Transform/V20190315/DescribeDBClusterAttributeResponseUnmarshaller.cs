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
        public static DescribeDBClusterAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBClusterAttributeResponse describeDBClusterAttributeResponse = new DescribeDBClusterAttributeResponse();

			describeDBClusterAttributeResponse.HttpResponse = context.HttpResponse;
			describeDBClusterAttributeResponse.RequestId = context.StringValue("DescribeDBClusterAttribute.RequestId");

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster> describeDBClusterAttributeResponse_items = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster>();
			for (int i = 0; i < context.Length("DescribeDBClusterAttribute.Items.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster dBCluster = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster();
				dBCluster.RegionId = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].RegionId");
				dBCluster.ZoneId = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ZoneId");
				dBCluster.DBClusterId = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterId");
				dBCluster.DBClusterType = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterType");
				dBCluster.DBClusterDescription = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterDescription");
				dBCluster.Category = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Category");
				dBCluster.LockMode = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].LockMode");
				dBCluster.LockReason = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].LockReason");
				dBCluster.PayType = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].PayType");
				dBCluster.DBVersion = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBVersion");
				dBCluster.DBClusterStatus = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterStatus");
				dBCluster.DBNodeStorage = context.LongValue("DescribeDBClusterAttribute.Items["+ i +"].DBNodeStorage");
				dBCluster.DBNodeClass = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBNodeClass");
				dBCluster.DBNodeCount = context.LongValue("DescribeDBClusterAttribute.Items["+ i +"].DBNodeCount");
				dBCluster.CreationTime = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].CreationTime");
				dBCluster.ExpireTime = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].ExpireTime");
				dBCluster.Expired = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Expired");
				dBCluster.MaintainTime = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].MaintainTime");
				dBCluster.Engine = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Engine");
				dBCluster.VPCId = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VPCId");
				dBCluster.VSwitchId = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VSwitchId");
				dBCluster.VPCCloudInstanceId = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].VPCCloudInstanceId");
				dBCluster.CommodityCode = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].CommodityCode");
				dBCluster.DBClusterNetworkType = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].DBClusterNetworkType");

				List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag> dBCluster_tags = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag>();
				for (int j = 0; j < context.Length("DescribeDBClusterAttribute.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag tag = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBCluster.DescribeDBClusterAttribute_Tag();
					tag.Key = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeDBClusterAttribute.Items["+ i +"].Tags["+ j +"].Value");

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
