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
        public static DescribeVSwitchesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVSwitchesResponse describeVSwitchesResponse = new DescribeVSwitchesResponse();

			describeVSwitchesResponse.HttpResponse = _ctx.HttpResponse;
			describeVSwitchesResponse.RequestId = _ctx.StringValue("DescribeVSwitches.RequestId");
			describeVSwitchesResponse.Success = _ctx.BooleanValue("DescribeVSwitches.Success");
			describeVSwitchesResponse.Code = _ctx.StringValue("DescribeVSwitches.Code");
			describeVSwitchesResponse.Message = _ctx.StringValue("DescribeVSwitches.Message");
			describeVSwitchesResponse.TotalCount = _ctx.IntegerValue("DescribeVSwitches.TotalCount");
			describeVSwitchesResponse.PageNumber = _ctx.IntegerValue("DescribeVSwitches.PageNumber");
			describeVSwitchesResponse.PageSize = _ctx.IntegerValue("DescribeVSwitches.PageSize");

			List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch> describeVSwitchesResponse_vSwitches = new List<DescribeVSwitchesResponse.DescribeVSwitches_VSwitch>();
			for (int i = 0; i < _ctx.Length("DescribeVSwitches.VSwitches.Length"); i++) {
				DescribeVSwitchesResponse.DescribeVSwitches_VSwitch vSwitch = new DescribeVSwitchesResponse.DescribeVSwitches_VSwitch();
				vSwitch.Name = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Name");
				vSwitch.Id = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].Id");
				vSwitch.IsDefault = _ctx.BooleanValue("DescribeVSwitches.VSwitches["+ i +"].IsDefault");
				vSwitch.ZoneId = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].ZoneId");
				vSwitch.AvailableSelectionInfo = _ctx.StringValue("DescribeVSwitches.VSwitches["+ i +"].AvailableSelectionInfo");

				describeVSwitchesResponse_vSwitches.Add(vSwitch);
			}
			describeVSwitchesResponse.VSwitches = describeVSwitchesResponse_vSwitches;
        
			return describeVSwitchesResponse;
        }
    }
}
