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
			getAutoScaleConfigResponse.SpotStrategy = context.StringValue("GetAutoScaleConfig.SpotStrategy");
			getAutoScaleConfigResponse.SpotPriceLimit = context.FloatValue("GetAutoScaleConfig.SpotPriceLimit");

			List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo> getAutoScaleConfigResponse_queues = new List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo>();
			for (int i = 0; i < context.Length("GetAutoScaleConfig.Queues.Length"); i++) {
				GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo queueInfo = new GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo();
				queueInfo.QueueName = context.StringValue("GetAutoScaleConfig.Queues["+ i +"].QueueName");
				queueInfo.InstanceType = context.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceType");
				queueInfo.SpotStrategy = context.StringValue("GetAutoScaleConfig.Queues["+ i +"].SpotStrategy");
				queueInfo.SpotPriceLimit = context.FloatValue("GetAutoScaleConfig.Queues["+ i +"].SpotPriceLimit");
				queueInfo.EnableAutoGrow = context.BooleanValue("GetAutoScaleConfig.Queues["+ i +"].EnableAutoGrow");
				queueInfo.EnableAutoShrink = context.BooleanValue("GetAutoScaleConfig.Queues["+ i +"].EnableAutoShrink");

				List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo> queueInfo_instanceTypes = new List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo>();
				for (int j = 0; j < context.Length("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes.Length"); j++) {
					GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo instanceTypeInfo = new GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo();
					instanceTypeInfo.InstanceType = context.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].InstanceType");
					instanceTypeInfo.SpotStrategy = context.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].SpotStrategy");
					instanceTypeInfo.SpotPriceLimit = context.FloatValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].SpotPriceLimit");

					queueInfo_instanceTypes.Add(instanceTypeInfo);
				}
				queueInfo.InstanceTypes = queueInfo_instanceTypes;

				getAutoScaleConfigResponse_queues.Add(queueInfo);
			}
			getAutoScaleConfigResponse.Queues = getAutoScaleConfigResponse_queues;
        
			return getAutoScaleConfigResponse;
        }
    }
}
