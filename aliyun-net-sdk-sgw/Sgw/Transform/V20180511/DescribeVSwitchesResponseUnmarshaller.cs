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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeVSwitchesResponseUnmarshaller
    {
        public static DescribeVSwitchesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVSwitchesResponse describeVSwitchesResponse = new DescribeVSwitchesResponse();

			describeVSwitchesResponse.HttpResponse = context.HttpResponse;
			describeVSwitchesResponse.RequestId = context.StringValue("DescribeVSwitches.RequestId");
			describeVSwitchesResponse.Success = context.BooleanValue("DescribeVSwitches.Success");
			describeVSwitchesResponse.Code = context.StringValue("DescribeVSwitches.Code");
			describeVSwitchesResponse.Message = context.StringValue("DescribeVSwitches.Message");
			describeVSwitchesResponse.TotalCount = context.IntegerValue("DescribeVSwitches.TotalCount");
			describeVSwitchesResponse.PageNumber = context.IntegerValue("DescribeVSwitches.PageNumber");
			describeVSwitchesResponse.PageSize = context.IntegerValue("DescribeVSwitches.PageSize");

			List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch> describeVSwitchesResponse_vSwitches = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch>();
			for (int i = 0; i < context.Length("DescribeVSwitches.VSwitches.Length"); i++) {
				DescribeVSwitchesResponse.DescribeVSwitches_VSwitch vSwitch = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch();
				vSwitch.Name = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].Name");
				vSwitch.Id = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].Id");
				vSwitch.IsDefault = context.BooleanValue("DescribeVSwitches.VSwitches["+ i +"].IsDefault");
				vSwitch.ZoneId = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].ZoneId");
				vSwitch.AvailableSelectionInfo = context.StringValue("DescribeVSwitches.VSwitches["+ i +"].AvailableSelectionInfo");

				describeVSwitchesResponse_vSwitches.Add(vSwitch);
			}
			describeVSwitchesResponse.VSwitches = describeVSwitchesResponse_vSwitches;
        
			return describeVSwitchesResponse;
        }
    }
}
