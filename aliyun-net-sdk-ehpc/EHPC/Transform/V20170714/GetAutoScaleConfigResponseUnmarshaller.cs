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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20170714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20170714
{
    public class GetAutoScaleConfigResponseUnmarshaller
    {
        public static GetAutoScaleConfigResponse Unmarshall(UnmarshallerContext context)
        {
			GetAutoScaleConfigResponse getAutoScaleConfigResponse = new GetAutoScaleConfigResponse();

			getAutoScaleConfigResponse.HttpResponse = context.HttpResponse;
			getAutoScaleConfigResponse.RequestId = context.StringValue("GetAutoScaleConfig.RequestId");
			getAutoScaleConfigResponse.Uid = context.StringValue("GetAutoScaleConfig.Uid");
			getAutoScaleConfigResponse.ClusterId = context.StringValue("GetAutoScaleConfig.ClusterId");
			getAutoScaleConfigResponse.ClusterType = context.StringValue("GetAutoScaleConfig.ClusterType");
			getAutoScaleConfigResponse.EnableAutoGrow = context.BooleanValue("GetAutoScaleConfig.EnableAutoGrow");
			getAutoScaleConfigResponse.EnableAutoShrink = context.BooleanValue("GetAutoScaleConfig.EnableAutoShrink");
			getAutoScaleConfigResponse.GrowIntervalInMinutes = context.IntegerValue("GetAutoScaleConfig.GrowIntervalInMinutes");
			getAutoScaleConfigResponse.ShrinkIntervalInMinutes = context.IntegerValue("GetAutoScaleConfig.ShrinkIntervalInMinutes");
			getAutoScaleConfigResponse.ShrinkIdleTimes = context.IntegerValue("GetAutoScaleConfig.ShrinkIdleTimes");
			getAutoScaleConfigResponse.GrowTimeoutInMinutes = context.IntegerValue("GetAutoScaleConfig.GrowTimeoutInMinutes");
			getAutoScaleConfigResponse.ExtraNodesGrowRatio = context.IntegerValue("GetAutoScaleConfig.ExtraNodesGrowRatio");
			getAutoScaleConfigResponse.GrowRatio = context.IntegerValue("GetAutoScaleConfig.GrowRatio");
			getAutoScaleConfigResponse.MaxNodesInCluster = context.IntegerValue("GetAutoScaleConfig.MaxNodesInCluster");
			getAutoScaleConfigResponse.ExcludeNodes = context.StringValue("GetAutoScaleConfig.ExcludeNodes");
        
			return getAutoScaleConfigResponse;
        }
    }
}