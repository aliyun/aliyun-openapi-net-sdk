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
        public static DescribeWarningMachinesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWarningMachinesResponse describeWarningMachinesResponse = new DescribeWarningMachinesResponse();

			describeWarningMachinesResponse.HttpResponse = context.HttpResponse;
			describeWarningMachinesResponse.RequestId = context.StringValue("DescribeWarningMachines.RequestId");
			describeWarningMachinesResponse.Count = context.IntegerValue("DescribeWarningMachines.Count");
			describeWarningMachinesResponse.PageSize = context.IntegerValue("DescribeWarningMachines.PageSize");
			describeWarningMachinesResponse.TotalCount = context.IntegerValue("DescribeWarningMachines.TotalCount");
			describeWarningMachinesResponse.CurrentPage = context.IntegerValue("DescribeWarningMachines.CurrentPage");

			List<DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine> describeWarningMachinesResponse_warningMachines = new List<DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine>();
			for (int i = 0; i < context.Length("DescribeWarningMachines.WarningMachines.Length"); i++) {
				DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine warningMachine = new DescribeWarningMachinesResponse.DescribeWarningMachines_WarningMachine();
				warningMachine.Uuid = context.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].Uuid");
				warningMachine.MachineName = context.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].MachineName");
				warningMachine.InternetIp = context.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].InternetIp");
				warningMachine.IntranetIp = context.StringValue("DescribeWarningMachines.WarningMachines["+ i +"].IntranetIp");
				warningMachine.PassCount = context.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].PassCount");
				warningMachine.HighWarningCount = context.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].HighWarningCount");
				warningMachine.MediumWarningCount = context.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].MediumWarningCount");
				warningMachine.LowWarningCount = context.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].LowWarningCount");
				warningMachine.Status = context.IntegerValue("DescribeWarningMachines.WarningMachines["+ i +"].Status");

				describeWarningMachinesResponse_warningMachines.Add(warningMachine);
			}
			describeWarningMachinesResponse.WarningMachines = describeWarningMachinesResponse_warningMachines;
        
			return describeWarningMachinesResponse;
        }
    }
}
