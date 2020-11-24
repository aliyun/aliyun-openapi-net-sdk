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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeWebCcProtectSwitchResponseUnmarshaller
    {
        public static DescribeWebCcProtectSwitchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebCcProtectSwitchResponse describeWebCcProtectSwitchResponse = new DescribeWebCcProtectSwitchResponse();

			describeWebCcProtectSwitchResponse.HttpResponse = _ctx.HttpResponse;
			describeWebCcProtectSwitchResponse.RequestId = _ctx.StringValue("DescribeWebCcProtectSwitch.RequestId");

			List<DescribeWebCcProtectSwitchResponse.DescribeWebCcProtectSwitch_ProtectSwitch> describeWebCcProtectSwitchResponse_protectSwitchList = new List<DescribeWebCcProtectSwitchResponse.DescribeWebCcProtectSwitch_ProtectSwitch>();
			for (int i = 0; i < _ctx.Length("DescribeWebCcProtectSwitch.ProtectSwitchList.Length"); i++) {
				DescribeWebCcProtectSwitchResponse.DescribeWebCcProtectSwitch_ProtectSwitch protectSwitch = new DescribeWebCcProtectSwitchResponse.DescribeWebCcProtectSwitch_ProtectSwitch();
				protectSwitch.Domain = _ctx.StringValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].Domain");
				protectSwitch.BlackWhiteListEnable = _ctx.IntegerValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].BlackWhiteListEnable");
				protectSwitch.RegionBlockEnable = _ctx.IntegerValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].RegionBlockEnable");
				protectSwitch.CcEnable = _ctx.IntegerValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].CcEnable");
				protectSwitch.CcCustomRuleEnable = _ctx.IntegerValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].CcCustomRuleEnable");
				protectSwitch.PreciseRuleEnable = _ctx.IntegerValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].PreciseRuleEnable");
				protectSwitch.AiRuleEnable = _ctx.IntegerValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].AiRuleEnable");
				protectSwitch.CcTemplate = _ctx.StringValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].CcTemplate");
				protectSwitch.AiTemplate = _ctx.StringValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].AiTemplate");
				protectSwitch.AiMode = _ctx.StringValue("DescribeWebCcProtectSwitch.ProtectSwitchList["+ i +"].AiMode");

				describeWebCcProtectSwitchResponse_protectSwitchList.Add(protectSwitch);
			}
			describeWebCcProtectSwitchResponse.ProtectSwitchList = describeWebCcProtectSwitchResponse_protectSwitchList;
        
			return describeWebCcProtectSwitchResponse;
        }
    }
}
