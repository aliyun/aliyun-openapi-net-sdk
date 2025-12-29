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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeVpcsForMongoDBResponseUnmarshaller
    {
        public static DescribeVpcsForMongoDBResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpcsForMongoDBResponse describeVpcsForMongoDBResponse = new DescribeVpcsForMongoDBResponse();

			describeVpcsForMongoDBResponse.HttpResponse = _ctx.HttpResponse;
			describeVpcsForMongoDBResponse.TotalCount = _ctx.IntegerValue("DescribeVpcsForMongoDB.TotalCount");
			describeVpcsForMongoDBResponse.RequestId = _ctx.StringValue("DescribeVpcsForMongoDB.RequestId");
			describeVpcsForMongoDBResponse.PageSize = _ctx.IntegerValue("DescribeVpcsForMongoDB.PageSize");
			describeVpcsForMongoDBResponse.PageNumber = _ctx.IntegerValue("DescribeVpcsForMongoDB.PageNumber");

			List<DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc> describeVpcsForMongoDBResponse_vpcs = new List<DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc>();
			for (int i = 0; i < _ctx.Length("DescribeVpcsForMongoDB.Vpcs.Length"); i++) {
				DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc vpc = new DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc();
				vpc.Status = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].Status");
				vpc.VpcName = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VpcName");
				vpc.VpcId = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VpcId");
				vpc.IsDefault = _ctx.BooleanValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].IsDefault");
				vpc.CidrBlock = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].CidrBlock");
				vpc.RegionNo = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].RegionNo");
				vpc.GmtCreate = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].GmtCreate");
				vpc.AliUid = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].AliUid");
				vpc.GmtModified = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].GmtModified");
				vpc.Bid = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].Bid");

				List<DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc.DescribeVpcsForMongoDB_VSwitch> vpc_vSwitchs = new List<DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc.DescribeVpcsForMongoDB_VSwitch>();
				for (int j = 0; j < _ctx.Length("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs.Length"); j++) {
					DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc.DescribeVpcsForMongoDB_VSwitch vSwitch = new DescribeVpcsForMongoDBResponse.DescribeVpcsForMongoDB_Vpc.DescribeVpcsForMongoDB_VSwitch();
					vSwitch.Status = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].Status");
					vSwitch.VSwitchId = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].VSwitchId");
					vSwitch.IsDefault = _ctx.BooleanValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].IsDefault");
					vSwitch.CidrBlock = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].CidrBlock");
					vSwitch.GmtCreate = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].GmtCreate");
					vSwitch.GmtModified = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].GmtModified");
					vSwitch.IzNo = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].IzNo");
					vSwitch.VSwitchName = _ctx.StringValue("DescribeVpcsForMongoDB.Vpcs["+ i +"].VSwitchs["+ j +"].VSwitchName");

					vpc_vSwitchs.Add(vSwitch);
				}
				vpc.VSwitchs = vpc_vSwitchs;

				describeVpcsForMongoDBResponse_vpcs.Add(vpc);
			}
			describeVpcsForMongoDBResponse.Vpcs = describeVpcsForMongoDBResponse_vpcs;
        
			return describeVpcsForMongoDBResponse;
        }
    }
}
