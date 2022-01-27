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
    public class DescribeScalingGroupV2ResponseUnmarshaller
    {
        public static DescribeScalingGroupV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScalingGroupV2Response describeScalingGroupV2Response = new DescribeScalingGroupV2Response();

			describeScalingGroupV2Response.HttpResponse = _ctx.HttpResponse;
			describeScalingGroupV2Response.RequestId = _ctx.StringValue("DescribeScalingGroupV2.RequestId");
			describeScalingGroupV2Response.ScalingGroupId = _ctx.StringValue("DescribeScalingGroupV2.ScalingGroupId");
			describeScalingGroupV2Response.Name = _ctx.StringValue("DescribeScalingGroupV2.Name");
			describeScalingGroupV2Response.Description = _ctx.StringValue("DescribeScalingGroupV2.Description");
			describeScalingGroupV2Response.ActiveStatus = _ctx.StringValue("DescribeScalingGroupV2.ActiveStatus");
			describeScalingGroupV2Response.HostGroupBizId = _ctx.StringValue("DescribeScalingGroupV2.HostGroupBizId");
			describeScalingGroupV2Response.ScalingInMode = _ctx.StringValue("DescribeScalingGroupV2.ScalingInMode");
			describeScalingGroupV2Response.ScalingMinSize = _ctx.IntegerValue("DescribeScalingGroupV2.ScalingMinSize");
			describeScalingGroupV2Response.ScalingMaxSize = _ctx.IntegerValue("DescribeScalingGroupV2.ScalingMaxSize");
			describeScalingGroupV2Response.ConfigState = _ctx.StringValue("DescribeScalingGroupV2.ConfigState");
        
			return describeScalingGroupV2Response;
        }
    }
}
