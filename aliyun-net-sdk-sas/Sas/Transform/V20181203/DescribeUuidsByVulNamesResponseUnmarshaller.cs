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
    public class DescribeUuidsByVulNamesResponseUnmarshaller
    {
        public static DescribeUuidsByVulNamesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUuidsByVulNamesResponse describeUuidsByVulNamesResponse = new DescribeUuidsByVulNamesResponse();

			describeUuidsByVulNamesResponse.HttpResponse = _ctx.HttpResponse;
			describeUuidsByVulNamesResponse.RequestId = _ctx.StringValue("DescribeUuidsByVulNames.RequestId");

			List<DescribeUuidsByVulNamesResponse.DescribeUuidsByVulNames_MachineInfoStatistic> describeUuidsByVulNamesResponse_machineInfoStatistics = new List<DescribeUuidsByVulNamesResponse.DescribeUuidsByVulNames_MachineInfoStatistic>();
			for (int i = 0; i < _ctx.Length("DescribeUuidsByVulNames.MachineInfoStatistics.Length"); i++) {
				DescribeUuidsByVulNamesResponse.DescribeUuidsByVulNames_MachineInfoStatistic machineInfoStatistic = new DescribeUuidsByVulNamesResponse.DescribeUuidsByVulNames_MachineInfoStatistic();
				machineInfoStatistic.MachineIp = _ctx.StringValue("DescribeUuidsByVulNames.MachineInfoStatistics["+ i +"].MachineIp");
				machineInfoStatistic.MachineName = _ctx.StringValue("DescribeUuidsByVulNames.MachineInfoStatistics["+ i +"].MachineName");
				machineInfoStatistic.Os = _ctx.StringValue("DescribeUuidsByVulNames.MachineInfoStatistics["+ i +"].Os");
				machineInfoStatistic.MachineInstanceId = _ctx.StringValue("DescribeUuidsByVulNames.MachineInfoStatistics["+ i +"].MachineInstanceId");
				machineInfoStatistic.Uuid = _ctx.StringValue("DescribeUuidsByVulNames.MachineInfoStatistics["+ i +"].Uuid");
				machineInfoStatistic.RegionId = _ctx.StringValue("DescribeUuidsByVulNames.MachineInfoStatistics["+ i +"].RegionId");

				describeUuidsByVulNamesResponse_machineInfoStatistics.Add(machineInfoStatistic);
			}
			describeUuidsByVulNamesResponse.MachineInfoStatistics = describeUuidsByVulNamesResponse_machineInfoStatistics;
        
			return describeUuidsByVulNamesResponse;
        }
    }
}
