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
			describeDBClusterAttributeResponse.RequestId = _ctx.StringValue("DescribeDBClusterAttribute.RequestId");
			describeDBClusterAttributeResponse.RegionId = _ctx.StringValue("DescribeDBClusterAttribute.RegionId");
			describeDBClusterAttributeResponse.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterNetworkType");
			describeDBClusterAttributeResponse.VPCId = _ctx.StringValue("DescribeDBClusterAttribute.VPCId");
			describeDBClusterAttributeResponse.VSwitchId = _ctx.StringValue("DescribeDBClusterAttribute.VSwitchId");
			describeDBClusterAttributeResponse.PayType = _ctx.StringValue("DescribeDBClusterAttribute.PayType");
			describeDBClusterAttributeResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterId");
			describeDBClusterAttributeResponse.DBClusterStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterStatus");
			describeDBClusterAttributeResponse.DBClusterDescription = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterDescription");
			describeDBClusterAttributeResponse.Engine = _ctx.StringValue("DescribeDBClusterAttribute.Engine");
			describeDBClusterAttributeResponse.DBType = _ctx.StringValue("DescribeDBClusterAttribute.DBType");
			describeDBClusterAttributeResponse.DBVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBVersion");
			describeDBClusterAttributeResponse.LockMode = _ctx.StringValue("DescribeDBClusterAttribute.LockMode");
			describeDBClusterAttributeResponse.DeletionLock = _ctx.IntegerValue("DescribeDBClusterAttribute.DeletionLock");
			describeDBClusterAttributeResponse.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.CreationTime");
			describeDBClusterAttributeResponse.ExpireTime = _ctx.StringValue("DescribeDBClusterAttribute.ExpireTime");
			describeDBClusterAttributeResponse.Expired = _ctx.StringValue("DescribeDBClusterAttribute.Expired");
			describeDBClusterAttributeResponse.MaintainTime = _ctx.StringValue("DescribeDBClusterAttribute.MaintainTime");
			describeDBClusterAttributeResponse.StorageUsed = _ctx.LongValue("DescribeDBClusterAttribute.StorageUsed");
			describeDBClusterAttributeResponse.StorageMax = _ctx.LongValue("DescribeDBClusterAttribute.StorageMax");
			describeDBClusterAttributeResponse.ZoneIds = _ctx.StringValue("DescribeDBClusterAttribute.ZoneIds");
			describeDBClusterAttributeResponse.SQLSize = _ctx.LongValue("DescribeDBClusterAttribute.SQLSize");
			describeDBClusterAttributeResponse.IsLatestVersion = _ctx.BooleanValue("DescribeDBClusterAttribute.IsLatestVersion");
			describeDBClusterAttributeResponse.ResourceGroupId = _ctx.StringValue("DescribeDBClusterAttribute.ResourceGroupId");
			describeDBClusterAttributeResponse.DataLevel1BackupChainSize = _ctx.LongValue("DescribeDBClusterAttribute.DataLevel1BackupChainSize");
			describeDBClusterAttributeResponse.Category = _ctx.StringValue("DescribeDBClusterAttribute.Category");
			describeDBClusterAttributeResponse.DBVersionStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBVersionStatus");

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag> describeDBClusterAttributeResponse_tags = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.Tags.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag tag = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag();
				tag.Key = _ctx.StringValue("DescribeDBClusterAttribute.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeDBClusterAttribute.Tags["+ i +"].Value");

				describeDBClusterAttributeResponse_tags.Add(tag);
			}
			describeDBClusterAttributeResponse.Tags = describeDBClusterAttributeResponse_tags;

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode> describeDBClusterAttributeResponse_dBNodes = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.DBNodes.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode dBNode = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode();
				dBNode.DBNodeId = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeId");
				dBNode.ZoneId = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].ZoneId");
				dBNode.DBNodeStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeStatus");
				dBNode.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].CreationTime");
				dBNode.DBNodeClass = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeClass");
				dBNode.DBNodeRole = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeRole");
				dBNode.MaxIOPS = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxIOPS");
				dBNode.MaxConnections = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxConnections");
				dBNode.FailoverPriority = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].FailoverPriority");

				describeDBClusterAttributeResponse_dBNodes.Add(dBNode);
			}
			describeDBClusterAttributeResponse.DBNodes = describeDBClusterAttributeResponse_dBNodes;
        
			return describeDBClusterAttributeResponse;
        }
    }
}
