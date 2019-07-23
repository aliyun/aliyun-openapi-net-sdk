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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterAttributeResponseUnmarshaller
    {
        public static DescribeDBClusterAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBClusterAttributeResponse describeDBClusterAttributeResponse = new DescribeDBClusterAttributeResponse();

			describeDBClusterAttributeResponse.HttpResponse = context.HttpResponse;
			describeDBClusterAttributeResponse.RequestId = context.StringValue("DescribeDBClusterAttribute.RequestId");
			describeDBClusterAttributeResponse.RegionId = context.StringValue("DescribeDBClusterAttribute.RegionId");
			describeDBClusterAttributeResponse.DBClusterNetworkType = context.StringValue("DescribeDBClusterAttribute.DBClusterNetworkType");
			describeDBClusterAttributeResponse.VPCId = context.StringValue("DescribeDBClusterAttribute.VPCId");
			describeDBClusterAttributeResponse.VSwitchId = context.StringValue("DescribeDBClusterAttribute.VSwitchId");
			describeDBClusterAttributeResponse.PayType = context.StringValue("DescribeDBClusterAttribute.PayType");
			describeDBClusterAttributeResponse.DBClusterId = context.StringValue("DescribeDBClusterAttribute.DBClusterId");
			describeDBClusterAttributeResponse.DBClusterStatus = context.StringValue("DescribeDBClusterAttribute.DBClusterStatus");
			describeDBClusterAttributeResponse.DBClusterDescription = context.StringValue("DescribeDBClusterAttribute.DBClusterDescription");
			describeDBClusterAttributeResponse.Engine = context.StringValue("DescribeDBClusterAttribute.Engine");
			describeDBClusterAttributeResponse.DBType = context.StringValue("DescribeDBClusterAttribute.DBType");
			describeDBClusterAttributeResponse.DBVersion = context.StringValue("DescribeDBClusterAttribute.DBVersion");
			describeDBClusterAttributeResponse.LockMode = context.StringValue("DescribeDBClusterAttribute.LockMode");
			describeDBClusterAttributeResponse.DeletionLock = context.IntegerValue("DescribeDBClusterAttribute.DeletionLock");
			describeDBClusterAttributeResponse.CreationTime = context.StringValue("DescribeDBClusterAttribute.CreationTime");
			describeDBClusterAttributeResponse.ExpireTime = context.StringValue("DescribeDBClusterAttribute.ExpireTime");
			describeDBClusterAttributeResponse.Expired = context.StringValue("DescribeDBClusterAttribute.Expired");
			describeDBClusterAttributeResponse.MaintainTime = context.StringValue("DescribeDBClusterAttribute.MaintainTime");
			describeDBClusterAttributeResponse.StorageUsed = context.LongValue("DescribeDBClusterAttribute.StorageUsed");
			describeDBClusterAttributeResponse.StorageMax = context.IntegerValue("DescribeDBClusterAttribute.StorageMax");
			describeDBClusterAttributeResponse.ZoneIds = context.StringValue("DescribeDBClusterAttribute.ZoneIds");
			describeDBClusterAttributeResponse.SQLSize = context.LongValue("DescribeDBClusterAttribute.SQLSize");
			describeDBClusterAttributeResponse.IsLatestVersion = context.BooleanValue("DescribeDBClusterAttribute.IsLatestVersion");

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag> describeDBClusterAttributeResponse_tags = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag>();
			for (int i = 0; i < context.Length("DescribeDBClusterAttribute.Tags.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag tag = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag();
				tag.Key = context.StringValue("DescribeDBClusterAttribute.Tags["+ i +"].Key");
				tag._Value = context.StringValue("DescribeDBClusterAttribute.Tags["+ i +"]._Value");

				describeDBClusterAttributeResponse_tags.Add(tag);
			}
			describeDBClusterAttributeResponse.Tags = describeDBClusterAttributeResponse_tags;

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode> describeDBClusterAttributeResponse_dBNodes = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode>();
			for (int i = 0; i < context.Length("DescribeDBClusterAttribute.DBNodes.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode dBNode = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode();
				dBNode.DBNodeId = context.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeId");
				dBNode.ZoneId = context.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].ZoneId");
				dBNode.DBNodeStatus = context.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeStatus");
				dBNode.CreationTime = context.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].CreationTime");
				dBNode.DBNodeClass = context.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeClass");
				dBNode.DBNodeRole = context.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeRole");
				dBNode.MaxIOPS = context.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxIOPS");
				dBNode.MaxConnections = context.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxConnections");

				describeDBClusterAttributeResponse_dBNodes.Add(dBNode);
			}
			describeDBClusterAttributeResponse.DBNodes = describeDBClusterAttributeResponse_dBNodes;
        
			return describeDBClusterAttributeResponse;
        }
    }
}
