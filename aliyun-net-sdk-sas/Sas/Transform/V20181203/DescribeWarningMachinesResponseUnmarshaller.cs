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
    public class DescribeWarningMachinesResponseUnmarshaller
    {
        public static DescribeWarningMachinesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWarningMachinesResponse describeWarningMachinesResponse = new DescribeWarningMachinesResponse();

			describeWarningMachinesResponse.HttpResponse = _ctx.HttpResponse;
			describeWarningMachinesResponse.RequestId = _ctx.StringValue("DescribeWarningMachines.RequestId");
			describeWarningMachinesResponse.Count = _ctx.IntegerValue("DescribeWarningMachines.Count");
			describeWarningMachinesResponse.PageSize = _ctx.IntegerValue("DescribeWarningMachines.PageSize");
			describeWarningMachinesResponse.TotalCount = _ctx.IntegerValue("DescribeWarningMachines.TotalCount");
			describeWarningMachinesResponse.CurrentPage = _ctx.IntegerValue("DescribeWarningMachines.CurrentPage");

			List<DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine> describeWarningMachinesResponse_warningMachines = new List<DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine>();
			for (int i = 0; i < _ctx.Length("DescribeWarningMachines.WarningMachines.Length"); i++) {
				DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine warningMachine = new DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine();
				warningMachine.Uuid = _ctx.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].Uuid");
				warningMachine.InstanceName = _ctx.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].InstanceName");
				warningMachine.InstanceId = _ctx.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].InstanceId");
				warningMachine.RegionId = _ctx.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].RegionId");
				warningMachine.InternetIp = _ctx.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].InternetIp");
				warningMachine.IntranetIp = _ctx.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].IntranetIp");
				warningMachine.PassCount = _ctx.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].PassCount");
				warningMachine.HighWarningCount = _ctx.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].HighWarningCount");
				warningMachine.MediumWarningCount = _ctx.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].MediumWarningCount");
				warningMachine.LowWarningCount = _ctx.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].LowWarningCount");
				warningMachine.Status = _ctx.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].Status");

				describeWarningMachinesResponse_warningMachines.Add(warningMachine);
			}
			describeWarningMachinesResponse.WarningMachines = describeWarningMachinesResponse_warningMachines;
        
			return describeWarningMachinesResponse;
        }
    }
}
