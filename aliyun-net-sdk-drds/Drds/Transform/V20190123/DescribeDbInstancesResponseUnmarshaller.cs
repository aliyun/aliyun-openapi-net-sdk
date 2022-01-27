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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDbInstancesResponseUnmarshaller
    {
        public static DescribeDbInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDbInstancesResponse describeDbInstancesResponse = new DescribeDbInstancesResponse();

			describeDbInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDbInstancesResponse.RequestId = _ctx.StringValue("DescribeDbInstances.RequestId");

			List<DescribeDbInstancesResponse.DescribeDbInstances_DBInstance> describeDbInstancesResponse_items = new List<DescribeDbInstancesResponse.DescribeDbInstances_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDbInstances.Items.Length"); i++) {
				DescribeDbInstancesResponse.DescribeDbInstances_DBInstance dBInstance = new DescribeDbInstancesResponse.DescribeDbInstances_DBInstance();
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].DBInstanceId");
				dBInstance.DBInstanceStatus = _ctx.IntegerValue("DescribeDbInstances.Items["+ i +"].DBInstanceStatus");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].DBInstanceType");
				dBInstance.Engine = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].Engine");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].EngineVersion");
				dBInstance.RegionId = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].RegionId");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].ZoneId");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].DBInstanceDescription");
				dBInstance.InstanceNetworkType = _ctx.StringValue("DescribeDbInstances.Items["+ i +"].InstanceNetworkType");

				List<string> dBInstance_readOnlyDBInstanceId = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDbInstances.Items["+ i +"].ReadOnlyDBInstanceId.Length"); j++) {
					dBInstance_readOnlyDBInstanceId.Add(_ctx.StringValue("DescribeDbInstances.Items["+ i +"].ReadOnlyDBInstanceId["+ j +"]"));
				}
				dBInstance.ReadOnlyDBInstanceId = dBInstance_readOnlyDBInstanceId;

				describeDbInstancesResponse_items.Add(dBInstance);
			}
			describeDbInstancesResponse.Items = describeDbInstancesResponse_items;
        
			return describeDbInstancesResponse;
        }
    }
}
