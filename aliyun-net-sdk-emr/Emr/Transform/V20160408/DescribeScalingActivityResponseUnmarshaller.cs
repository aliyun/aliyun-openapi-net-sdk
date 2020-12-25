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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeScalingActivityResponseUnmarshaller
    {
        public static DescribeScalingActivityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScalingActivityResponse describeScalingActivityResponse = new DescribeScalingActivityResponse();

			describeScalingActivityResponse.HttpResponse = _ctx.HttpResponse;
			describeScalingActivityResponse.RequestId = _ctx.StringValue("DescribeScalingActivity.RequestId");
			describeScalingActivityResponse.BizId = _ctx.StringValue("DescribeScalingActivity.BizId");
			describeScalingActivityResponse.StartTime = _ctx.LongValue("DescribeScalingActivity.StartTime");
			describeScalingActivityResponse.EndTime = _ctx.LongValue("DescribeScalingActivity.EndTime");
			describeScalingActivityResponse.InstanceIds = _ctx.StringValue("DescribeScalingActivity.InstanceIds");
			describeScalingActivityResponse.TotalCapacity = _ctx.IntegerValue("DescribeScalingActivity.TotalCapacity");
			describeScalingActivityResponse.Cause = _ctx.StringValue("DescribeScalingActivity.Cause");
			describeScalingActivityResponse.Description = _ctx.StringValue("DescribeScalingActivity.Description");
			describeScalingActivityResponse.Status = _ctx.StringValue("DescribeScalingActivity.Status");
			describeScalingActivityResponse.Transition = _ctx.StringValue("DescribeScalingActivity.Transition");
			describeScalingActivityResponse.ScalingRuleId = _ctx.StringValue("DescribeScalingActivity.ScalingRuleId");
			describeScalingActivityResponse.ExpectNum = _ctx.IntegerValue("DescribeScalingActivity.ExpectNum");
        
			return describeScalingActivityResponse;
        }
    }
}
