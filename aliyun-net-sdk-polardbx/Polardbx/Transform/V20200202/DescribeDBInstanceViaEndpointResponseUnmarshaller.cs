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
    public class DescribeDBInstanceViaEndpointResponseUnmarshaller
    {
        public static DescribeDBInstanceViaEndpointResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceViaEndpointResponse describeDBInstanceViaEndpointResponse = new DescribeDBInstanceViaEndpointResponse();

			describeDBInstanceViaEndpointResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceViaEndpointResponse.RequestId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.RequestId");

			DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance dBInstance = new DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance();
			dBInstance.Type = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Type");
			dBInstance.Status = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Status");
			dBInstance.RightsSeparationStatus = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.RightsSeparationStatus");
			dBInstance.DBNodeCount = _ctx.IntegerValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodeCount");
			dBInstance.Expired = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Expired");
			dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.CreateTime");
			dBInstance.PayType = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.PayType");
			dBInstance.Port = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Port");
			dBInstance.LockMode = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.LockMode");
			dBInstance.Description = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Description");
			dBInstance.ConnectionString = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ConnectionString");
			dBInstance.StorageUsed = _ctx.LongValue("DescribeDBInstanceViaEndpoint.DBInstance.StorageUsed");
			dBInstance.ExpireDate = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ExpireDate");
			dBInstance.CommodityCode = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.CommodityCode");
			dBInstance.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.MaintainStartTime");
			dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBInstanceType");
			dBInstance.DBNodeClass = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodeClass");
			dBInstance.LatestMinorVersion = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.LatestMinorVersion");
			dBInstance.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.MaintainEndTime");
			dBInstance.DBType = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBType");
			dBInstance.RightsSeparationEnabled = _ctx.BooleanValue("DescribeDBInstanceViaEndpoint.DBInstance.RightsSeparationEnabled");
			dBInstance.VPCId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.VPCId");
			dBInstance.MinorVersion = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.MinorVersion");
			dBInstance.RegionId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.RegionId");
			dBInstance.Network = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Network");
			dBInstance.DBVersion = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBVersion");
			dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.VSwitchId");
			dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ZoneId");
			dBInstance.Engine = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Engine");
			dBInstance.KindCode = _ctx.IntegerValue("DescribeDBInstanceViaEndpoint.DBInstance.KindCode");
			dBInstance.Id = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Id");
			dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ResourceGroupId");
			dBInstance.CnNodeCount = _ctx.IntegerValue("DescribeDBInstanceViaEndpoint.DBInstance.CnNodeCount");
			dBInstance.DnNodeCount = _ctx.IntegerValue("DescribeDBInstanceViaEndpoint.DBInstance.DnNodeCount");
			dBInstance.CnNodeClassCode = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.CnNodeClassCode");
			dBInstance.DnNodeClassCode = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DnNodeClassCode");
			dBInstance.Series = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.Series");

			List<string> dBInstance_readDBInstances = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceViaEndpoint.DBInstance.ReadDBInstances.Length"); i++) {
				dBInstance_readDBInstances.Add(_ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ReadDBInstances["+ i +"]"));
			}
			dBInstance.ReadDBInstances = dBInstance_readDBInstances;

			List<string> dBInstance_lTSVersions = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceViaEndpoint.DBInstance.LTSVersions.Length"); i++) {
				dBInstance_lTSVersions.Add(_ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.LTSVersions["+ i +"]"));
			}
			dBInstance.LTSVersions = dBInstance_lTSVersions;

			List<DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_DBNode> dBInstance_dBNodes = new List<DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_DBNode>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceViaEndpoint.DBInstance.DBNodes.Length"); i++) {
				DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_DBNode dBNode = new DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_DBNode();
				dBNode.ComputeNodeId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodes["+ i +"].ComputeNodeId");
				dBNode.NodeClass = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodes["+ i +"].NodeClass");
				dBNode.DataNodeId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodes["+ i +"].DataNodeId");
				dBNode.ZoneId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodes["+ i +"].ZoneId");
				dBNode.Id = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodes["+ i +"].Id");
				dBNode.RegionId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.DBNodes["+ i +"].RegionId");

				dBInstance_dBNodes.Add(dBNode);
			}
			dBInstance.DBNodes = dBInstance_dBNodes;

			List<DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_ConnAddr> dBInstance_connAddrs = new List<DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_ConnAddr>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceViaEndpoint.DBInstance.ConnAddrs.Length"); i++) {
				DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_ConnAddr connAddr = new DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_ConnAddr();
				connAddr.Type = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ConnAddrs["+ i +"].Type");
				connAddr.VSwitchId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ConnAddrs["+ i +"].VSwitchId");
				connAddr.Port = _ctx.LongValue("DescribeDBInstanceViaEndpoint.DBInstance.ConnAddrs["+ i +"].Port");
				connAddr.VPCId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ConnAddrs["+ i +"].VPCId");
				connAddr.ConnectionString = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ConnAddrs["+ i +"].ConnectionString");
				connAddr.VpcInstanceId = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.ConnAddrs["+ i +"].VpcInstanceId");

				dBInstance_connAddrs.Add(connAddr);
			}
			dBInstance.ConnAddrs = dBInstance_connAddrs;

			List<DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_TagSetItem> dBInstance_tagSet = new List<DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_TagSetItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceViaEndpoint.DBInstance.TagSet.Length"); i++) {
				DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_TagSetItem tagSetItem = new DescribeDBInstanceViaEndpointResponse.DescribeDBInstanceViaEndpoint_DBInstance.DescribeDBInstanceViaEndpoint_TagSetItem();
				tagSetItem.Key = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.TagSet["+ i +"].Key");
				tagSetItem._Value = _ctx.StringValue("DescribeDBInstanceViaEndpoint.DBInstance.TagSet["+ i +"].Value");

				dBInstance_tagSet.Add(tagSetItem);
			}
			dBInstance.TagSet = dBInstance_tagSet;
			describeDBInstanceViaEndpointResponse.DBInstance = dBInstance;
        
			return describeDBInstanceViaEndpointResponse;
        }
    }
}
