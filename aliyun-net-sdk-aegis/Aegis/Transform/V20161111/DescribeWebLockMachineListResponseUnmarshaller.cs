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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeWebLockMachineListResponseUnmarshaller
    {
        public static DescribeWebLockMachineListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWebLockMachineListResponse describeWebLockMachineListResponse = new DescribeWebLockMachineListResponse();

			describeWebLockMachineListResponse.HttpResponse = context.HttpResponse;
			describeWebLockMachineListResponse.RequestId = context.StringValue("DescribeWebLockMachineList.RequestId");
			describeWebLockMachineListResponse.TotalCount = context.IntegerValue("DescribeWebLockMachineList.TotalCount");

			List<DescribeWebLockMachineListResponse.DescribeWebLockMachineList_MachineInfo> describeWebLockMachineListResponse_machineList = new List<DescribeWebLockMachineListResponse.DescribeWebLockMachineList_MachineInfo>();
			for (int i = 0; i < context.Length("DescribeWebLockMachineList.MachineList.Length"); i++) {
				DescribeWebLockMachineListResponse.DescribeWebLockMachineList_MachineInfo machineInfo = new DescribeWebLockMachineListResponse.DescribeWebLockMachineList_MachineInfo();
				machineInfo.Uuid = context.StringValue("DescribeWebLockMachineList.MachineList["+ i +"].Uuid");
				machineInfo.InternetIp = context.StringValue("DescribeWebLockMachineList.MachineList["+ i +"].InternetIp");
				machineInfo.IntranetIp = context.StringValue("DescribeWebLockMachineList.MachineList["+ i +"].IntranetIp");
				machineInfo.InstanceId = context.StringValue("DescribeWebLockMachineList.MachineList["+ i +"].InstanceId");
				machineInfo.InstanceName = context.StringValue("DescribeWebLockMachineList.MachineList["+ i +"].InstanceName");
				machineInfo.Status = context.StringValue("DescribeWebLockMachineList.MachineList["+ i +"].Status");

				describeWebLockMachineListResponse_machineList.Add(machineInfo);
			}
			describeWebLockMachineListResponse.MachineList = describeWebLockMachineListResponse_machineList;
        
			return describeWebLockMachineListResponse;
        }
    }
}
