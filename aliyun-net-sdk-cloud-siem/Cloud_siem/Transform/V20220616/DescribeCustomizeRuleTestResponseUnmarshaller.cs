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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeCustomizeRuleTestResponseUnmarshaller
    {
        public static DescribeCustomizeRuleTestResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomizeRuleTestResponse describeCustomizeRuleTestResponse = new DescribeCustomizeRuleTestResponse();

			describeCustomizeRuleTestResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomizeRuleTestResponse.Success = _ctx.BooleanValue("DescribeCustomizeRuleTest.Success");
			describeCustomizeRuleTestResponse.Code = _ctx.IntegerValue("DescribeCustomizeRuleTest.Code");
			describeCustomizeRuleTestResponse.Message = _ctx.StringValue("DescribeCustomizeRuleTest.Message");
			describeCustomizeRuleTestResponse.RequestId = _ctx.StringValue("DescribeCustomizeRuleTest.RequestId");

			DescribeCustomizeRuleTestResponse.DescribeCustomizeRuleTest_Data data = new DescribeCustomizeRuleTestResponse.DescribeCustomizeRuleTest_Data();
			data.Id = _ctx.LongValue("DescribeCustomizeRuleTest.Data.Id");
			data.Status = _ctx.IntegerValue("DescribeCustomizeRuleTest.Data.Status");
			data.SimulateData = _ctx.StringValue("DescribeCustomizeRuleTest.Data.SimulateData");
			describeCustomizeRuleTestResponse.Data = data;
        
			return describeCustomizeRuleTestResponse;
        }
    }
}
