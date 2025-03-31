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
    public class DescribeCustomizeRuleCountResponseUnmarshaller
    {
        public static DescribeCustomizeRuleCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomizeRuleCountResponse describeCustomizeRuleCountResponse = new DescribeCustomizeRuleCountResponse();

			describeCustomizeRuleCountResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomizeRuleCountResponse.Success = _ctx.BooleanValue("DescribeCustomizeRuleCount.Success");
			describeCustomizeRuleCountResponse.Code = _ctx.IntegerValue("DescribeCustomizeRuleCount.Code");
			describeCustomizeRuleCountResponse.Message = _ctx.StringValue("DescribeCustomizeRuleCount.Message");
			describeCustomizeRuleCountResponse.RequestId = _ctx.StringValue("DescribeCustomizeRuleCount.RequestId");

			DescribeCustomizeRuleCountResponse.DescribeCustomizeRuleCount_Data data = new DescribeCustomizeRuleCountResponse.DescribeCustomizeRuleCount_Data();
			data.InUseRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.InUseRuleNum");
			data.HighRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.HighRuleNum");
			data.MediumRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.MediumRuleNum");
			data.LowRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.LowRuleNum");
			data.TotalRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.TotalRuleNum");
			data.CustomizeRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.CustomizeRuleNum");
			data.PredefinedRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.PredefinedRuleNum");
			data.UnEventRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.UnEventRuleNum");
			data.ExpertRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.ExpertRuleNum");
			data.GraphComputingRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.GraphComputingRuleNum");
			data.SingleAlertRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.SingleAlertRuleNum");
			data.AggregationRuleNum = _ctx.IntegerValue("DescribeCustomizeRuleCount.Data.AggregationRuleNum");
			describeCustomizeRuleCountResponse.Data = data;
        
			return describeCustomizeRuleCountResponse;
        }
    }
}
