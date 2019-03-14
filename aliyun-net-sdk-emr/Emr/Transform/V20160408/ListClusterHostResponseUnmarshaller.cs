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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListClusterHostResponseUnmarshaller
    {
        public static ListClusterHostResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterHostResponse listClusterHostResponse = new ListClusterHostResponse();

			listClusterHostResponse.HttpResponse = context.HttpResponse;
			listClusterHostResponse.RequestId = context.StringValue("ListClusterHost.RequestId");
			listClusterHostResponse.PageNumber = context.IntegerValue("ListClusterHost.PageNumber");
			listClusterHostResponse.PageSize = context.IntegerValue("ListClusterHost.PageSize");
			listClusterHostResponse.Total = context.IntegerValue("ListClusterHost.Total");

			List<ListClusterHostResponse.ListClusterHost_Host> listClusterHostResponse_hostList = new List<ListClusterHostResponse.ListClusterHost_Host>();
			for (int i = 0; i < context.Length("ListClusterHost.HostList.Length"); i++) {
				ListClusterHostResponse.ListClusterHost_Host host = new ListClusterHostResponse.ListClusterHost_Host();
				host.HostName = context.StringValue("ListClusterHost.HostList["+ i +"].HostName");
				host.PublicIp = context.StringValue("ListClusterHost.HostList["+ i +"].PublicIp");
				host.PrivateIp = context.StringValue("ListClusterHost.HostList["+ i +"].PrivateIp");
				host.Role = context.StringValue("ListClusterHost.HostList["+ i +"].Role");
				host.InstanceType = context.StringValue("ListClusterHost.HostList["+ i +"].InstanceType");
				host.Cpu = context.IntegerValue("ListClusterHost.HostList["+ i +"].Cpu");
				host.Memory = context.IntegerValue("ListClusterHost.HostList["+ i +"].Memory");
				host.Status = context.StringValue("ListClusterHost.HostList["+ i +"].Status");
				host.InstanceStatus = context.StringValue("ListClusterHost.HostList["+ i +"].InstanceStatus");
				host.Type = context.StringValue("ListClusterHost.HostList["+ i +"].Type");
				host.HostInstanceId = context.StringValue("ListClusterHost.HostList["+ i +"].HostInstanceId");
				host.SerialNumber = context.StringValue("ListClusterHost.HostList["+ i +"].SerialNumber");
				host.ChargeType = context.StringValue("ListClusterHost.HostList["+ i +"].ChargeType");
				host.ExpiredTime = context.LongValue("ListClusterHost.HostList["+ i +"].ExpiredTime");
				host.HostGroupId = context.StringValue("ListClusterHost.HostList["+ i +"].HostGroupId");
				host.CreateTime = context.StringValue("ListClusterHost.HostList["+ i +"].CreateTime");
				host.EmrExpiredTime = context.StringValue("ListClusterHost.HostList["+ i +"].EmrExpiredTime");
				host.SupportIpV6 = context.BooleanValue("ListClusterHost.HostList["+ i +"].SupportIpV6");

				List<ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk> host_diskList = new List<ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk>();
				for (int j = 0; j < context.Length("ListClusterHost.HostList["+ i +"].DiskList.Length"); j++) {
					ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk disk = new ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk();
					disk.DiskId = context.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].DiskId");
					disk.Type = context.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].Type");
					disk.DiskType = context.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].DiskType");
					disk.DiskSize = context.IntegerValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].DiskSize");

					host_diskList.Add(disk);
				}
				host.DiskList = host_diskList;

				listClusterHostResponse_hostList.Add(host);
			}
			listClusterHostResponse.HostList = listClusterHostResponse_hostList;
        
			return listClusterHostResponse;
        }
    }
}
