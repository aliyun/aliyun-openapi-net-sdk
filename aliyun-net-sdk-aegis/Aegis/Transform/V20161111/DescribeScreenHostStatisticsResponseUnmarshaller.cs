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
    public class DescribeScreenHostStatisticsResponseUnmarshaller
    {
        public static DescribeScreenHostStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScreenHostStatisticsResponse describeScreenHostStatisticsResponse = new DescribeScreenHostStatisticsResponse();

			describeScreenHostStatisticsResponse.HttpResponse = context.HttpResponse;
			describeScreenHostStatisticsResponse.RequestId = context.StringValue("DescribeScreenHostStatistics.RequestId");

			DescribeScreenHostStatisticsResponse.DescribeScreenHostStatistics_Data data = new DescribeScreenHostStatisticsResponse.DescribeScreenHostStatistics_Data();

			List<string> data_weaknessUuids = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenHostStatistics.Data.WeaknessUuids.Length"); i++) {
				data_weaknessUuids.Add(context.StringValue("DescribeScreenHostStatistics.Data.WeaknessUuids["+ i +"]"));
			}
			data.WeaknessUuids = data_weaknessUuids;

			List<string> data_suspEventUuids = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenHostStatistics.Data.SuspEventUuids.Length"); i++) {
				data_suspEventUuids.Add(context.StringValue("DescribeScreenHostStatistics.Data.SuspEventUuids["+ i +"]"));
			}
			data.SuspEventUuids = data_suspEventUuids;

			List<string> data_suspEventMachineNames = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenHostStatistics.Data.SuspEventMachineNames.Length"); i++) {
				data_suspEventMachineNames.Add(context.StringValue("DescribeScreenHostStatistics.Data.SuspEventMachineNames["+ i +"]"));
			}
			data.SuspEventMachineNames = data_suspEventMachineNames;

			List<string> data_weaknessMachineNames = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenHostStatistics.Data.WeaknessMachineNames.Length"); i++) {
				data_weaknessMachineNames.Add(context.StringValue("DescribeScreenHostStatistics.Data.WeaknessMachineNames["+ i +"]"));
			}
			data.WeaknessMachineNames = data_weaknessMachineNames;
			describeScreenHostStatisticsResponse.Data = data;
        
			return describeScreenHostStatisticsResponse;
        }
    }
}
