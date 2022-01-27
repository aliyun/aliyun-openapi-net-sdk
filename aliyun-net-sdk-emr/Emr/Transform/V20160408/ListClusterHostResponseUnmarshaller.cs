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
        public static ListClusterHostResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterHostResponse listClusterHostResponse = new ListClusterHostResponse();

			listClusterHostResponse.HttpResponse = _ctx.HttpResponse;
			listClusterHostResponse.RequestId = _ctx.StringValue("ListClusterHost.RequestId");
			listClusterHostResponse.PageNumber = _ctx.IntegerValue("ListClusterHost.PageNumber");
			listClusterHostResponse.PageSize = _ctx.IntegerValue("ListClusterHost.PageSize");
			listClusterHostResponse.Total = _ctx.IntegerValue("ListClusterHost.Total");

			List<ListClusterHostResponse.ListClusterHost_Host> listClusterHostResponse_hostList = new List<ListClusterHostResponse.ListClusterHost_Host>();
			for (int i = 0; i < _ctx.Length("ListClusterHost.HostList.Length"); i++) {
				ListClusterHostResponse.ListClusterHost_Host host = new ListClusterHostResponse.ListClusterHost_Host();
				host.HostName = _ctx.StringValue("ListClusterHost.HostList["+ i +"].HostName");
				host.PublicIp = _ctx.StringValue("ListClusterHost.HostList["+ i +"].PublicIp");
				host.PrivateIp = _ctx.StringValue("ListClusterHost.HostList["+ i +"].PrivateIp");
				host.Role = _ctx.StringValue("ListClusterHost.HostList["+ i +"].Role");
				host.ZoneId = _ctx.StringValue("ListClusterHost.HostList["+ i +"].ZoneId");
				host.InstanceType = _ctx.StringValue("ListClusterHost.HostList["+ i +"].InstanceType");
				host.Cpu = _ctx.IntegerValue("ListClusterHost.HostList["+ i +"].Cpu");
				host.Memory = _ctx.IntegerValue("ListClusterHost.HostList["+ i +"].Memory");
				host.Status = _ctx.StringValue("ListClusterHost.HostList["+ i +"].Status");
				host.InstanceStatus = _ctx.StringValue("ListClusterHost.HostList["+ i +"].InstanceStatus");
				host.Type = _ctx.StringValue("ListClusterHost.HostList["+ i +"].Type");
				host.HostInstanceId = _ctx.StringValue("ListClusterHost.HostList["+ i +"].HostInstanceId");
				host.SerialNumber = _ctx.StringValue("ListClusterHost.HostList["+ i +"].SerialNumber");
				host.ChargeType = _ctx.StringValue("ListClusterHost.HostList["+ i +"].ChargeType");
				host.ExpiredTime = _ctx.LongValue("ListClusterHost.HostList["+ i +"].ExpiredTime");
				host.HostGroupId = _ctx.StringValue("ListClusterHost.HostList["+ i +"].HostGroupId");
				host.CreateTime = _ctx.StringValue("ListClusterHost.HostList["+ i +"].CreateTime");
				host.EmrExpiredTime = _ctx.StringValue("ListClusterHost.HostList["+ i +"].EmrExpiredTime");
				host.SupportIpV6 = _ctx.BooleanValue("ListClusterHost.HostList["+ i +"].SupportIpV6");

				List<ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk> host_diskList = new List<ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk>();
				for (int j = 0; j < _ctx.Length("ListClusterHost.HostList["+ i +"].DiskList.Length"); j++) {
					ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk disk = new ListClusterHostResponse.ListClusterHost_Host.ListClusterHost_Disk();
					disk.DiskId = _ctx.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].DiskId");
					disk.Type = _ctx.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].Type");
					disk.Device = _ctx.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].Device");
					disk.DiskType = _ctx.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].DiskType");
					disk.DiskSize = _ctx.IntegerValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].DiskSize");
					disk.BlockMountPoint = _ctx.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].BlockMountPoint");
					disk.DiskMountPoint = _ctx.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].DiskMountPoint");
					disk._Event = _ctx.StringValue("ListClusterHost.HostList["+ i +"].DiskList["+ j +"].Event");

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
