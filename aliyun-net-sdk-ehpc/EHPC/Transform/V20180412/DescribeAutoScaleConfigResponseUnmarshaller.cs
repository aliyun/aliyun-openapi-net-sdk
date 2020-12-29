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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribeAutoScaleConfigResponseUnmarshaller
    {
        public static DescribeAutoScaleConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoScaleConfigResponse describeAutoScaleConfigResponse = new DescribeAutoScaleConfigResponse();

			describeAutoScaleConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoScaleConfigResponse.RequestId = _ctx.StringValue("DescribeAutoScaleConfig.RequestId");
			describeAutoScaleConfigResponse.Uid = _ctx.StringValue("DescribeAutoScaleConfig.Uid");
			describeAutoScaleConfigResponse.ClusterId = _ctx.StringValue("DescribeAutoScaleConfig.ClusterId");
			describeAutoScaleConfigResponse.ClusterType = _ctx.StringValue("DescribeAutoScaleConfig.ClusterType");
			describeAutoScaleConfigResponse.EnableAutoGrow = _ctx.BooleanValue("DescribeAutoScaleConfig.EnableAutoGrow");
			describeAutoScaleConfigResponse.EnableAutoShrink = _ctx.BooleanValue("DescribeAutoScaleConfig.EnableAutoShrink");
			describeAutoScaleConfigResponse.GrowIntervalInMinutes = _ctx.IntegerValue("DescribeAutoScaleConfig.GrowIntervalInMinutes");
			describeAutoScaleConfigResponse.ShrinkIntervalInMinutes = _ctx.IntegerValue("DescribeAutoScaleConfig.ShrinkIntervalInMinutes");
			describeAutoScaleConfigResponse.ShrinkIdleTimes = _ctx.IntegerValue("DescribeAutoScaleConfig.ShrinkIdleTimes");
			describeAutoScaleConfigResponse.GrowTimeoutInMinutes = _ctx.IntegerValue("DescribeAutoScaleConfig.GrowTimeoutInMinutes");
			describeAutoScaleConfigResponse.ExtraNodesGrowRatio = _ctx.IntegerValue("DescribeAutoScaleConfig.ExtraNodesGrowRatio");
			describeAutoScaleConfigResponse.GrowRatio = _ctx.IntegerValue("DescribeAutoScaleConfig.GrowRatio");
			describeAutoScaleConfigResponse.MaxNodesInCluster = _ctx.IntegerValue("DescribeAutoScaleConfig.MaxNodesInCluster");
			describeAutoScaleConfigResponse.ExcludeNodes = _ctx.StringValue("DescribeAutoScaleConfig.ExcludeNodes");
			describeAutoScaleConfigResponse.SpotStrategy = _ctx.StringValue("DescribeAutoScaleConfig.SpotStrategy");
			describeAutoScaleConfigResponse.SpotPriceLimit = _ctx.StringValue("DescribeAutoScaleConfig.SpotPriceLimit");
        
			return describeAutoScaleConfigResponse;
        }
    }
}
