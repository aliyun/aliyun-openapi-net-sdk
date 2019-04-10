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
        public static DescribeAutoScaleConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAutoScaleConfigResponse describeAutoScaleConfigResponse = new DescribeAutoScaleConfigResponse();

			describeAutoScaleConfigResponse.HttpResponse = context.HttpResponse;
			describeAutoScaleConfigResponse.RequestId = context.StringValue("DescribeAutoScaleConfig.RequestId");
			describeAutoScaleConfigResponse.Uid = context.StringValue("DescribeAutoScaleConfig.Uid");
			describeAutoScaleConfigResponse.ClusterId = context.StringValue("DescribeAutoScaleConfig.ClusterId");
			describeAutoScaleConfigResponse.ClusterType = context.StringValue("DescribeAutoScaleConfig.ClusterType");
			describeAutoScaleConfigResponse.EnableAutoGrow = context.BooleanValue("DescribeAutoScaleConfig.EnableAutoGrow");
			describeAutoScaleConfigResponse.EnableAutoShrink = context.BooleanValue("DescribeAutoScaleConfig.EnableAutoShrink");
			describeAutoScaleConfigResponse.GrowIntervalInMinutes = context.IntegerValue("DescribeAutoScaleConfig.GrowIntervalInMinutes");
			describeAutoScaleConfigResponse.ShrinkIntervalInMinutes = context.IntegerValue("DescribeAutoScaleConfig.ShrinkIntervalInMinutes");
			describeAutoScaleConfigResponse.ShrinkIdleTimes = context.IntegerValue("DescribeAutoScaleConfig.ShrinkIdleTimes");
			describeAutoScaleConfigResponse.GrowTimeoutInMinutes = context.IntegerValue("DescribeAutoScaleConfig.GrowTimeoutInMinutes");
			describeAutoScaleConfigResponse.ExtraNodesGrowRatio = context.IntegerValue("DescribeAutoScaleConfig.ExtraNodesGrowRatio");
			describeAutoScaleConfigResponse.GrowRatio = context.IntegerValue("DescribeAutoScaleConfig.GrowRatio");
			describeAutoScaleConfigResponse.MaxNodesInCluster = context.IntegerValue("DescribeAutoScaleConfig.MaxNodesInCluster");
			describeAutoScaleConfigResponse.ExcludeNodes = context.StringValue("DescribeAutoScaleConfig.ExcludeNodes");
			describeAutoScaleConfigResponse.SpotStrategy = context.StringValue("DescribeAutoScaleConfig.SpotStrategy");
			describeAutoScaleConfigResponse.SpotPriceLimit = context.StringValue("DescribeAutoScaleConfig.SpotPriceLimit");
        
			return describeAutoScaleConfigResponse;
        }
    }
}
