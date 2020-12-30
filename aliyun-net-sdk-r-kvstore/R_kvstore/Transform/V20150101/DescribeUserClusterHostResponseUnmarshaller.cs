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
        public static DescribeUserClusterHostResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserClusterHostResponse describeUserClusterHostResponse = new DescribeUserClusterHostResponse();

			describeUserClusterHostResponse.HttpResponse = _ctx.HttpResponse;
			describeUserClusterHostResponse.RequestId = _ctx.StringValue("DescribeUserClusterHost.RequestId");
			describeUserClusterHostResponse.MaxRecordsPerPage = _ctx.StringValue("DescribeUserClusterHost.MaxRecordsPerPage");
			describeUserClusterHostResponse.PageNumber = _ctx.IntegerValue("DescribeUserClusterHost.PageNumber");
			describeUserClusterHostResponse.TotalRecords = _ctx.IntegerValue("DescribeUserClusterHost.TotalRecords");
			describeUserClusterHostResponse.ItemNumbers = _ctx.IntegerValue("DescribeUserClusterHost.ItemNumbers");

			List<DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo> describeUserClusterHostResponse_hostItems = new List<DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo>();
			for (int i = 0; i < _ctx.Length("DescribeUserClusterHost.HostItems.Length"); i++) {
				DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo hostInfo = new DescribeUserClusterHostResponse.DescribeUserClusterHost_HostInfo();
				hostInfo.ClusterId = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ClusterId");
				hostInfo.HostId = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostId");
				hostInfo.Engine = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].Engine");
				hostInfo.HostIP = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostIP");
				hostInfo.HostStatus = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostStatus");
				hostInfo.AllocationStatus = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].AllocationStatus");
				hostInfo.HostCpu = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostCpu");
				hostInfo.HostMem = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostMem");
				hostInfo.HostStorage = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostStorage");
				hostInfo.HostName = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostName");
				hostInfo.Id = _ctx.IntegerValue("DescribeUserClusterHost.HostItems["+ i +"].Id");
				hostInfo.CreateTime = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].CreateTime");
				hostInfo.InstanceNumber = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].InstanceNumber");
				hostInfo.RegionId = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].RegionId");
				hostInfo.ZoneId = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ZoneId");
				hostInfo.HostClass = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].HostClass");
				hostInfo.ExpireTime = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ExpireTime");
				hostInfo.ChargeType = _ctx.StringValue("DescribeUserClusterHost.HostItems["+ i +"].ChargeType");

				describeUserClusterHostResponse_hostItems.Add(hostInfo);
			}
			describeUserClusterHostResponse.HostItems = describeUserClusterHostResponse_hostItems;
        
			return describeUserClusterHostResponse;
        }
    }
}
