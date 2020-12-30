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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeUserClusterHostInstanceResponseUnmarshaller
    {
        public static DescribeUserClusterHostInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserClusterHostInstanceResponse describeUserClusterHostInstanceResponse = new DescribeUserClusterHostInstanceResponse();

			describeUserClusterHostInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeUserClusterHostInstanceResponse.RequestId = _ctx.StringValue("DescribeUserClusterHostInstance.RequestId");
			describeUserClusterHostInstanceResponse.MaxRecordsPerPage = _ctx.IntegerValue("DescribeUserClusterHostInstance.MaxRecordsPerPage");
			describeUserClusterHostInstanceResponse.PageNumber = _ctx.IntegerValue("DescribeUserClusterHostInstance.PageNumber");
			describeUserClusterHostInstanceResponse.TotalRecords = _ctx.IntegerValue("DescribeUserClusterHostInstance.TotalRecords");
			describeUserClusterHostInstanceResponse.ItemNumbers = _ctx.IntegerValue("DescribeUserClusterHostInstance.ItemNumbers");

			List<DescribeUserClusterHostInstanceResponse.DescribeUserClusterHostInstance_InstanceInfo> describeUserClusterHostInstanceResponse_instancesItems = new List<DescribeUserClusterHostInstanceResponse.DescribeUserClusterHostInstance_InstanceInfo>();
			for (int i = 0; i < _ctx.Length("DescribeUserClusterHostInstance.InstancesItems.Length"); i++) {
				DescribeUserClusterHostInstanceResponse.DescribeUserClusterHostInstance_InstanceInfo instanceInfo = new DescribeUserClusterHostInstanceResponse.DescribeUserClusterHostInstance_InstanceInfo();
				instanceInfo.InstanceId = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].InstanceId");
				instanceInfo.ClusterId = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].ClusterId");
				instanceInfo.RegionId = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].RegionId");
				instanceInfo.ZoneId = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].ZoneId");
				instanceInfo.InstanceType = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].InstanceType");
				instanceInfo.Engine = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].Engine");
				instanceInfo.EngineVersion = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].EngineVersion");
				instanceInfo.InstanceStatus = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].InstanceStatus");
				instanceInfo.InstanceClass = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].InstanceClass");
				instanceInfo.CreateTime = _ctx.StringValue("DescribeUserClusterHostInstance.InstancesItems["+ i +"].CreateTime");

				describeUserClusterHostInstanceResponse_instancesItems.Add(instanceInfo);
			}
			describeUserClusterHostInstanceResponse.InstancesItems = describeUserClusterHostInstanceResponse_instancesItems;
        
			return describeUserClusterHostInstanceResponse;
        }
    }
}
