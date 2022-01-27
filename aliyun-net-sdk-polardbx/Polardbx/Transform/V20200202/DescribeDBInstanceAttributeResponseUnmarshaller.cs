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
			dBInstance.Status = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Status");
			dBInstance.Description = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Description");
			dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ZoneId");
			dBInstance.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.VPCId");
			dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.CreateTime");
			dBInstance.Expired = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Expired");
			dBInstance.PayType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.PayType");
			dBInstance.DBType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBType");
			dBInstance.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.LockMode");
			dBInstance.StorageUsed = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.StorageUsed");
			dBInstance.DBVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBVersion");
			dBInstance.Network = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Network");
			dBInstance.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.RegionId");
			dBInstance.Engine = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Engine");
			dBInstance.Id = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Id");
			dBInstance.ConnectionString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnectionString");
			dBInstance.Port = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Port");
			dBInstance.MinorVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.MinorVersion");
			dBInstance.LatestMinorVersion = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.LatestMinorVersion");
			dBInstance.DBNodeCount = _ctx.IntegerValue("DescribeDBInstanceAttribute.DBInstance.DBNodeCount");
			dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBInstanceType");
			dBInstance.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.MaintainStartTime");
			dBInstance.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.MaintainEndTime");
			dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.VSwitchId");
			dBInstance.CommodityCode = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.CommodityCode");
			dBInstance.ExpireDate = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ExpireDate");
			dBInstance.Type = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.Type");
			dBInstance.DBNodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodeClass");

			List<string> dBInstance_readDBInstances = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.ReadDBInstances.Length"); i++) {
				dBInstance_readDBInstances.Add(_ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ReadDBInstances["+ i +"]"));
			}
			dBInstance.ReadDBInstances = dBInstance_readDBInstances;

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode> dBInstance_dBNodes = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.DBNodes.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode dBNode = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_DBNode();
				dBNode.Id = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].Id");
				dBNode.NodeClass = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].NodeClass");
				dBNode.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].RegionId");
				dBNode.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.DBNodes["+ i +"].ZoneId");

				dBInstance_dBNodes.Add(dBNode);
			}
			dBInstance.DBNodes = dBInstance_dBNodes;

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr> dBInstance_connAddrs = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.DBInstance.ConnAddrs.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr connAddr = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstance.DescribeDBInstanceAttribute_ConnAddr();
				connAddr.ConnectionString = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].ConnectionString");
				connAddr.Port = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].Port");
				connAddr.Type = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].Type");
				connAddr.VPCId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].VPCId");
				connAddr.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.DBInstance.ConnAddrs["+ i +"].VSwitchId");

				dBInstance_connAddrs.Add(connAddr);
			}
			dBInstance.ConnAddrs = dBInstance_connAddrs;
			describeDBInstanceAttributeResponse.DBInstance = dBInstance;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}
