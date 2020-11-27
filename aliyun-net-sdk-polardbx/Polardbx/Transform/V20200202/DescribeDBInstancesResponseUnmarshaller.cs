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
    public class DescribeDBInstancesResponseUnmarshaller
    {
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse();

			describeDBInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesResponse.RequestId = _ctx.StringValue("DescribeDBInstances.RequestId");
			describeDBInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstances.PageNumber");
			describeDBInstancesResponse.PageSize = _ctx.IntegerValue("DescribeDBInstances.PageSize");
			describeDBInstancesResponse.TotalNumber = _ctx.IntegerValue("DescribeDBInstances.TotalNumber");

			List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance> describeDBInstancesResponse_dBInstances = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstances.DBInstances.Length"); i++) {
				DescribeDBInstancesResponse.DescribeDBInstances_DBInstance dBInstance = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance();
				dBInstance.Id = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Id");
				dBInstance.Description = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Description");
				dBInstance.PayType = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].PayType");
				dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].CreateTime");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ExpireTime");
				dBInstance.Expired = _ctx.BooleanValue("DescribeDBInstances.DBInstances["+ i +"].Expired");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].RegionId");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ZoneId");
				dBInstance.Network = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Network");
				dBInstance.VPCId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].VPCId");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Engine");
				dBInstance.DBType = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBType");
				dBInstance.DBVersion = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].DBVersion");
				dBInstance.Status = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Status");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].LockMode");
				dBInstance.LockReason = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].LockReason");
				dBInstance.NodeCount = _ctx.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].NodeCount");
				dBInstance.NodeClass = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].NodeClass");
				dBInstance.StorageUsed = _ctx.IntegerValue("DescribeDBInstances.DBInstances["+ i +"].StorageUsed");
				dBInstance.CommodityCode = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].CommodityCode");
				dBInstance.Type = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Type");

				List<string> dBInstance_readDBInstances = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.DBInstances["+ i +"].ReadDBInstances.Length"); j++) {
					dBInstance_readDBInstances.Add(_ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].ReadDBInstances["+ j +"]"));
				}
				dBInstance.ReadDBInstances = dBInstance_readDBInstances;

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_PolarDBXNode> dBInstance_nodes = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_PolarDBXNode>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.DBInstances["+ i +"].Nodes.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_PolarDBXNode polarDBXNode = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_PolarDBXNode();
					polarDBXNode.Id = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Nodes["+ j +"].Id");
					polarDBXNode.ClassCode = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Nodes["+ j +"].ClassCode");
					polarDBXNode.RegionId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Nodes["+ j +"].RegionId");
					polarDBXNode.ZoneId = _ctx.StringValue("DescribeDBInstances.DBInstances["+ i +"].Nodes["+ j +"].ZoneId");

					dBInstance_nodes.Add(polarDBXNode);
				}
				dBInstance.Nodes = dBInstance_nodes;

				describeDBInstancesResponse_dBInstances.Add(dBInstance);
			}
			describeDBInstancesResponse.DBInstances = describeDBInstancesResponse_dBInstances;
        
			return describeDBInstancesResponse;
        }
    }
}
