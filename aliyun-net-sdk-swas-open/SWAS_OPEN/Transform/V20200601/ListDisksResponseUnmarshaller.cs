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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class ListDisksResponseUnmarshaller
    {
        public static ListDisksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDisksResponse listDisksResponse = new ListDisksResponse();

			listDisksResponse.HttpResponse = _ctx.HttpResponse;
			listDisksResponse.TotalCount = _ctx.IntegerValue("ListDisks.TotalCount");
			listDisksResponse.RequestId = _ctx.StringValue("ListDisks.RequestId");
			listDisksResponse.PageSize = _ctx.IntegerValue("ListDisks.PageSize");
			listDisksResponse.PageNumber = _ctx.IntegerValue("ListDisks.PageNumber");

			List<ListDisksResponse.ListDisks_Disk> listDisksResponse_disks = new List<ListDisksResponse.ListDisks_Disk>();
			for (int i = 0; i < _ctx.Length("ListDisks.Disks.Length"); i++) {
				ListDisksResponse.ListDisks_Disk disk = new ListDisksResponse.ListDisks_Disk();
				disk.CreationTime = _ctx.StringValue("ListDisks.Disks["+ i +"].CreationTime");
				disk.Status = _ctx.StringValue("ListDisks.Disks["+ i +"].Status");
				disk.Device = _ctx.StringValue("ListDisks.Disks["+ i +"].Device");
				disk.Size = _ctx.IntegerValue("ListDisks.Disks["+ i +"].Size");
				disk.DiskName = _ctx.StringValue("ListDisks.Disks["+ i +"].DiskName");
				disk.DiskChargeType = _ctx.StringValue("ListDisks.Disks["+ i +"].DiskChargeType");
				disk.DiskType = _ctx.StringValue("ListDisks.Disks["+ i +"].DiskType");
				disk.Category = _ctx.StringValue("ListDisks.Disks["+ i +"].Category");
				disk.DiskId = _ctx.StringValue("ListDisks.Disks["+ i +"].DiskId");
				disk.InstanceId = _ctx.StringValue("ListDisks.Disks["+ i +"].InstanceId");
				disk.RegionId = _ctx.StringValue("ListDisks.Disks["+ i +"].RegionId");

				listDisksResponse_disks.Add(disk);
			}
			listDisksResponse.Disks = listDisksResponse_disks;
        
			return listDisksResponse;
        }
    }
}
