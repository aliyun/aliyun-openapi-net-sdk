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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeUserBackupMachinesResponseUnmarshaller
    {
        public static DescribeUserBackupMachinesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserBackupMachinesResponse describeUserBackupMachinesResponse = new DescribeUserBackupMachinesResponse();

			describeUserBackupMachinesResponse.HttpResponse = _ctx.HttpResponse;
			describeUserBackupMachinesResponse.RequestId = _ctx.StringValue("DescribeUserBackupMachines.RequestId");

			List<DescribeUserBackupMachinesResponse.DescribeUserBackupMachines_SimpleBackupMachine> describeUserBackupMachinesResponse_machines = new List<DescribeUserBackupMachinesResponse.DescribeUserBackupMachines_SimpleBackupMachine>();
			for (int i = 0; i < _ctx.Length("DescribeUserBackupMachines.Machines.Length"); i++) {
				DescribeUserBackupMachinesResponse.DescribeUserBackupMachines_SimpleBackupMachine simpleBackupMachine = new DescribeUserBackupMachinesResponse.DescribeUserBackupMachines_SimpleBackupMachine();
				simpleBackupMachine.Id = _ctx.LongValue("DescribeUserBackupMachines.Machines["+ i +"].Id");
				simpleBackupMachine.Uuid = _ctx.StringValue("DescribeUserBackupMachines.Machines["+ i +"].Uuid");
				simpleBackupMachine.PolicyName = _ctx.StringValue("DescribeUserBackupMachines.Machines["+ i +"].PolicyName");

				describeUserBackupMachinesResponse_machines.Add(simpleBackupMachine);
			}
			describeUserBackupMachinesResponse.Machines = describeUserBackupMachinesResponse_machines;
        
			return describeUserBackupMachinesResponse;
        }
    }
}
