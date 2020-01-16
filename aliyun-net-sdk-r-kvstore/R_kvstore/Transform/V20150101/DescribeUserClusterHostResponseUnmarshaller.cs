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
    public class DescribeUserClusterHostResponseUnmarshaller
    {
        public static DescribeUserClusterHostResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserClusterHostResponse describeUserClusterHostResponse = new DescribeUserClusterHostResponse();

			describeUserClusterHostResponse.HttpResponse = context.HttpResponse;
			describeUserClusterHostResponse.RequestId = context.StringValue("DescribeUserClusterHost.RequestId");
			describeUserClusterHostResponse.MaxRecordsPerPage = context.StringValue("DescribeUserClusterHost.MaxRecordsPerPage");
			describeUserClusterHostResponse.PageNumber = context.IntegerValue("DescribeUserClusterHost.PageNumber");
			describeUserClusterHostResponse.TotalRecords = context.IntegerValue("DescribeUserClusterHost.TotalRecords");
			describeUserClusterHostResponse.ItemNumbers = context.IntegerValue("DescribeUserClusterHost.ItemNumbers");

			List<DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo> describeUserClusterHostResponse_hostItems = new List<DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo>();
			for (int i = 0; i < context.Length("DescribeUserClusterHost.HostItems.Length"); i++) {
				DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo hostInfo = new DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo();
				hostInfo.ClusterId = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ClusterId");
				hostInfo.HostId = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostId");
				hostInfo.Engine = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].Engine");
				hostInfo.HostIP = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostIP");
				hostInfo.HostStatus = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostStatus");
				hostInfo.AllocationStatus = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].AllocationStatus");
				hostInfo.HostCpu = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostCpu");
				hostInfo.HostMem = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostMem");
				hostInfo.HostStorage = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostStorage");
				hostInfo.HostName = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostName");
				hostInfo.Id = context.IntegerValue("DescribeUserClusterHost.HostItems["+ i +"].Id");
				hostInfo.CreateTime = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].CreateTime");
				hostInfo.InstanceNumber = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].InstanceNumber");
				hostInfo.RegionId = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].RegionId");
				hostInfo.ZoneId = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ZoneId");
				hostInfo.HostClass = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostClass");
				hostInfo.ExpireTime = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ExpireTime");
				hostInfo.ChargeType = context.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ChargeType");

				describeUserClusterHostResponse_hostItems.Add(hostInfo);
			}
			describeUserClusterHostResponse.HostItems = describeUserClusterHostResponse_hostItems;
        
			return describeUserClusterHostResponse;
        }
    }
}
