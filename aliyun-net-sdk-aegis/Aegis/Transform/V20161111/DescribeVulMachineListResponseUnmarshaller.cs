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
    public class DescribeVulMachineListResponseUnmarshaller
    {
        public static DescribeVulMachineListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulMachineListResponse describeVulMachineListResponse = new DescribeVulMachineListResponse();

			describeVulMachineListResponse.HttpResponse = context.HttpResponse;
			describeVulMachineListResponse.RequestId = context.StringValue("DescribeVulMachineList.RequestId");
			describeVulMachineListResponse.TotalCount = context.IntegerValue("DescribeVulMachineList.TotalCount");

			List<DescribeVulMachineListResponse.DescribeVulMachineList_MachineStatistic> describeVulMachineListResponse_machineStatistics = new List<DescribeVulMachineListResponse.DescribeVulMachineList_MachineStatistic>();
			for (int i = 0; i < context.Length("DescribeVulMachineList.MachineStatistics.Length"); i++) {
				DescribeVulMachineListResponse.DescribeVulMachineList_MachineStatistic machineStatistic = new DescribeVulMachineListResponse.DescribeVulMachineList_MachineStatistic();
				machineStatistic.Uuid = context.StringValue("DescribeVulMachineList.MachineStatistics["+ i +"].Uuid");
				machineStatistic.CveNum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].CveNum");
				machineStatistic.EmgNum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].EmgNum");
				machineStatistic.SysNum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].SysNum");
				machineStatistic.CmsNum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].CmsNum");
				machineStatistic.CmsDealedTotalNum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].CmsDealedTotalNum");
				machineStatistic.VulDealedTotalNum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulDealedTotalNum");
				machineStatistic.VulAsapSum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulAsapSum");
				machineStatistic.VulLaterSum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulLaterSum");
				machineStatistic.VulNntfSum = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulNntfSum");
				machineStatistic.VulSeriousTotal = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulSeriousTotal");
				machineStatistic.VulHighTotal = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulHighTotal");
				machineStatistic.VulMediumTotal = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulMediumTotal");
				machineStatistic.VulLowTotal = context.IntegerValue("DescribeVulMachineList.MachineStatistics["+ i +"].VulLowTotal");

				describeVulMachineListResponse_machineStatistics.Add(machineStatistic);
			}
			describeVulMachineListResponse.MachineStatistics = describeVulMachineListResponse_machineStatistics;
        
			return describeVulMachineListResponse;
        }
    }
}
