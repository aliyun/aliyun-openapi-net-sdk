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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeDBInstanceAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeDBInstanceAttribute.RequestId");

			DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance dBInstance = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance();
			dBInstance.Type = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Type");
			dBInstance.Status = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Status");
			dBInstance.RightsSeparationStatus = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.RightsSeparationStatus");
			dBInstance.DBNodeCount = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstance.DBNodeCount");
			dBInstance.Expired = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Expired");
			dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.CreateTime");
			dBInstance.PayType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.PayType");
			dBInstance.Port = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Port");
			dBInstance.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.LockMode");
			dBInstance.Description = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Description");
			dBInstance.ConnectionString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnectionString");
			dBInstance.StorageUsed = _ctx.LongValue("DescribeDBInstanceAttribute.DBInstance.StorageUsed");
			dBInstance.ExpireDate = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ExpireDate");
			dBInstance.CommodityCode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.CommodityCode");
			dBInstance.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.MaintainStartTime");
			dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBInstanceType");
			dBInstance.DBNodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodeClass");
			dBInstance.LatestMinorVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.LatestMinorVersion");
			dBInstance.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.MaintainEndTime");
			dBInstance.DBType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBType");
			dBInstance.RightsSeparationEnabled = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstance.RightsSeparationEnabled");
			dBInstance.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.VPCId");
			dBInstance.MinorVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.MinorVersion");
			dBInstance.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.RegionId");
			dBInstance.Network = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Network");
			dBInstance.DBVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBVersion");
			dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.VSwitchId");
			dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ZoneId");
			dBInstance.Engine = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Engine");
			dBInstance.KindCode = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstance.KindCode");
			dBInstance.Id = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Id");
			dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ResourceGroupId");
			dBInstance.CnNodeCount = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstance.CnNodeCount");
			dBInstance.DnNodeCount = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstance.DnNodeCount");
			dBInstance.CnNodeClassCode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.CnNodeClassCode");
			dBInstance.DnNodeClassCode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DnNodeClassCode");
			dBInstance.Series = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Series");
			dBInstance.TopologyType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.TopologyType");
			dBInstance.PrimaryZone = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.PrimaryZone");
			dBInstance.SecondaryZone = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.SecondaryZone");
			dBInstance.TertiaryZone = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.TertiaryZone");
			dBInstance.DifferentDNSpec = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstance.DifferentDNSpec");
			dBInstance.ColumnarInstanceName = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ColumnarInstanceName");
			dBInstance.CanNotCreateColumnar = _ctx.BooleanValue("DescribeDBInstanceAttribute.DBInstance.CanNotCreateColumnar");
			dBInstance.SpecCategory = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.SpecCategory");

			List<string> dBInstance_readDBInstances = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.ReadDBInstances.Length"); i++) {
				dBInstance_readDBInstances.Add(_ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ReadDBInstances["+ i +"]"));
			}
			dBInstance.ReadDBInstances = dBInstance_readDBInstances;

			List<string> dBInstance_columnarReadDBInstances = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.ColumnarReadDBInstances.Length"); i++) {
				dBInstance_columnarReadDBInstances.Add(_ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ColumnarReadDBInstances["+ i +"]"));
			}
			dBInstance.ColumnarReadDBInstances = dBInstance_columnarReadDBInstances;

			List<string> dBInstance_lTSVersions = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.LTSVersions.Length"); i++) {
				dBInstance_lTSVersions.Add(_ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.LTSVersions["+ i +"]"));
			}
			dBInstance.LTSVersions = dBInstance_lTSVersions;

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode> dBInstance_dBNodes = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.DBNodes.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode dBNode = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode();
				dBNode.ComputeNodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].ComputeNodeId");
				dBNode.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].NodeClass");
				dBNode.DataNodeId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].DataNodeId");
				dBNode.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].ZoneId");
				dBNode.Id = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].Id");
				dBNode.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].RegionId");

				dBInstance_dBNodes.Add(dBNode);
			}
			dBInstance.DBNodes = dBInstance_dBNodes;

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr> dBInstance_connAddrs = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.ConnAddrs.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr connAddr = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr();
				connAddr.Type = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].Type");
				connAddr.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].VSwitchId");
				connAddr.Port = _ctx.LongValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].Port");
				connAddr.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].VPCId");
				connAddr.ConnectionString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].ConnectionString");
				connAddr.VpcInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].VpcInstanceId");

				dBInstance_connAddrs.Add(connAddr);
			}
			dBInstance.ConnAddrs = dBInstance_connAddrs;

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_TagSetItem> dBInstance_tagSet = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_TagSetItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.TagSet.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_TagSetItem tagSetItem = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_TagSetItem();
				tagSetItem.Key = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.TagSet["+ i +"].Key");
				tagSetItem._Value = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.TagSet["+ i +"].Value");

				dBInstance_tagSet.Add(tagSetItem);
			}
			dBInstance.TagSet = dBInstance_tagSet;
			describeDBInstanceAttributeResponse.DBInstance = dBInstance;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}
