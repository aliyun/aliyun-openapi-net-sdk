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
        public static DescribeDBClusterAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterAttributeResponse describeDBClusterAttributeResponse = new DescribeDBClusterAttributeResponse();

			describeDBClusterAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterAttributeResponse.DeletionLock = _ctx.IntegerValue("DescribeDBClusterAttribute.DeletionLock");
			describeDBClusterAttributeResponse.Category = _ctx.StringValue("DescribeDBClusterAttribute.Category");
			describeDBClusterAttributeResponse.ResourceGroupId = _ctx.StringValue("DescribeDBClusterAttribute.ResourceGroupId");
			describeDBClusterAttributeResponse.DataLevel1BackupChainSize = _ctx.LongValue("DescribeDBClusterAttribute.DataLevel1BackupChainSize");
			describeDBClusterAttributeResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterId");
			describeDBClusterAttributeResponse.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterNetworkType");
			describeDBClusterAttributeResponse.DBType = _ctx.StringValue("DescribeDBClusterAttribute.DBType");
			describeDBClusterAttributeResponse.IsLatestVersion = _ctx.BooleanValue("DescribeDBClusterAttribute.IsLatestVersion");
			describeDBClusterAttributeResponse.DBVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBVersion");
			describeDBClusterAttributeResponse.StorageMax = _ctx.LongValue("DescribeDBClusterAttribute.StorageMax");
			describeDBClusterAttributeResponse.ZoneIds = _ctx.StringValue("DescribeDBClusterAttribute.ZoneIds");
			describeDBClusterAttributeResponse.MaintainTime = _ctx.StringValue("DescribeDBClusterAttribute.MaintainTime");
			describeDBClusterAttributeResponse.Engine = _ctx.StringValue("DescribeDBClusterAttribute.Engine");
			describeDBClusterAttributeResponse.RequestId = _ctx.StringValue("DescribeDBClusterAttribute.RequestId");
			describeDBClusterAttributeResponse.VPCId = _ctx.StringValue("DescribeDBClusterAttribute.VPCId");
			describeDBClusterAttributeResponse.DBClusterStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterStatus");
			describeDBClusterAttributeResponse.VSwitchId = _ctx.StringValue("DescribeDBClusterAttribute.VSwitchId");
			describeDBClusterAttributeResponse.DBClusterDescription = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterDescription");
			describeDBClusterAttributeResponse.Expired = _ctx.StringValue("DescribeDBClusterAttribute.Expired");
			describeDBClusterAttributeResponse.LockMode = _ctx.StringValue("DescribeDBClusterAttribute.LockMode");
			describeDBClusterAttributeResponse.PayType = _ctx.StringValue("DescribeDBClusterAttribute.PayType");
			describeDBClusterAttributeResponse.StorageUsed = _ctx.LongValue("DescribeDBClusterAttribute.StorageUsed");
			describeDBClusterAttributeResponse.DBVersionStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBVersionStatus");
			describeDBClusterAttributeResponse.SubCategory = _ctx.StringValue("DescribeDBClusterAttribute.SubCategory");
			describeDBClusterAttributeResponse.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.CreationTime");
			describeDBClusterAttributeResponse.RegionId = _ctx.StringValue("DescribeDBClusterAttribute.RegionId");
			describeDBClusterAttributeResponse.SQLSize = _ctx.LongValue("DescribeDBClusterAttribute.SQLSize");
			describeDBClusterAttributeResponse.ExpireTime = _ctx.StringValue("DescribeDBClusterAttribute.ExpireTime");

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode> describeDBClusterAttributeResponse_dBNodes = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.DBNodes.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode dBNode = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode();
				dBNode.DBNodeStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeStatus");
				dBNode.MaxConnections = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxConnections");
				dBNode.ZoneId = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].ZoneId");
				dBNode.DBNodeRole = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeRole");
				dBNode.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].CreationTime");
				dBNode.DBNodeId = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeId");
				dBNode.FailoverPriority = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].FailoverPriority");
				dBNode.DBNodeClass = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeClass");
				dBNode.MaxIOPS = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxIOPS");

				describeDBClusterAttributeResponse_dBNodes.Add(dBNode);
			}
			describeDBClusterAttributeResponse.DBNodes = describeDBClusterAttributeResponse_dBNodes;

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag> describeDBClusterAttributeResponse_tags = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.Tags.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag tag = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag();
				tag._Value = _ctx.StringValue("DescribeDBClusterAttribute.Tags["+ i +"].Value");
				tag.Key = _ctx.StringValue("DescribeDBClusterAttribute.Tags["+ i +"].Key");

				describeDBClusterAttributeResponse_tags.Add(tag);
			}
			describeDBClusterAttributeResponse.Tags = describeDBClusterAttributeResponse_tags;
        
			return describeDBClusterAttributeResponse;
        }
    }
}
