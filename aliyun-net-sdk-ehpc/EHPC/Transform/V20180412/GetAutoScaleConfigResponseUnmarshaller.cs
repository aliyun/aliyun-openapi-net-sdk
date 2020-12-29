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
        public static GetAutoScaleConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAutoScaleConfigResponse getAutoScaleConfigResponse = new GetAutoScaleConfigResponse();

			getAutoScaleConfigResponse.HttpResponse = _ctx.HttpResponse;
			getAutoScaleConfigResponse.RequestId = _ctx.StringValue("GetAutoScaleConfig.RequestId");
			getAutoScaleConfigResponse.Uid = _ctx.StringValue("GetAutoScaleConfig.Uid");
			getAutoScaleConfigResponse.ClusterId = _ctx.StringValue("GetAutoScaleConfig.ClusterId");
			getAutoScaleConfigResponse.ClusterType = _ctx.StringValue("GetAutoScaleConfig.ClusterType");
			getAutoScaleConfigResponse.EnableAutoGrow = _ctx.BooleanValue("GetAutoScaleConfig.EnableAutoGrow");
			getAutoScaleConfigResponse.EnableAutoShrink = _ctx.BooleanValue("GetAutoScaleConfig.EnableAutoShrink");
			getAutoScaleConfigResponse.GrowIntervalInMinutes = _ctx.IntegerValue("GetAutoScaleConfig.GrowIntervalInMinutes");
			getAutoScaleConfigResponse.ShrinkIntervalInMinutes = _ctx.IntegerValue("GetAutoScaleConfig.ShrinkIntervalInMinutes");
			getAutoScaleConfigResponse.ShrinkIdleTimes = _ctx.IntegerValue("GetAutoScaleConfig.ShrinkIdleTimes");
			getAutoScaleConfigResponse.GrowTimeoutInMinutes = _ctx.IntegerValue("GetAutoScaleConfig.GrowTimeoutInMinutes");
			getAutoScaleConfigResponse.ExtraNodesGrowRatio = _ctx.IntegerValue("GetAutoScaleConfig.ExtraNodesGrowRatio");
			getAutoScaleConfigResponse.GrowRatio = _ctx.IntegerValue("GetAutoScaleConfig.GrowRatio");
			getAutoScaleConfigResponse.MaxNodesInCluster = _ctx.IntegerValue("GetAutoScaleConfig.MaxNodesInCluster");
			getAutoScaleConfigResponse.ExcludeNodes = _ctx.StringValue("GetAutoScaleConfig.ExcludeNodes");
			getAutoScaleConfigResponse.SpotStrategy = _ctx.StringValue("GetAutoScaleConfig.SpotStrategy");
			getAutoScaleConfigResponse.SpotPriceLimit = _ctx.FloatValue("GetAutoScaleConfig.SpotPriceLimit");
			getAutoScaleConfigResponse.ImageId = _ctx.StringValue("GetAutoScaleConfig.ImageId");

			List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo> getAutoScaleConfigResponse_queues = new List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo>();
			for (int i = 0; i < _ctx.Length("GetAutoScaleConfig.Queues.Length"); i++) {
				GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo queueInfo = new GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo();
				queueInfo.QueueName = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].QueueName");
				queueInfo.ResourceGroupId = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].ResourceGroupId");
				queueInfo.InstanceType = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceType");
				queueInfo.SpotStrategy = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].SpotStrategy");
				queueInfo.SpotPriceLimit = _ctx.FloatValue("GetAutoScaleConfig.Queues["+ i +"].SpotPriceLimit");
				queueInfo.EnableAutoGrow = _ctx.BooleanValue("GetAutoScaleConfig.Queues["+ i +"].EnableAutoGrow");
				queueInfo.EnableAutoShrink = _ctx.BooleanValue("GetAutoScaleConfig.Queues["+ i +"].EnableAutoShrink");
				queueInfo.MaxNodesInQueue = _ctx.IntegerValue("GetAutoScaleConfig.Queues["+ i +"].MaxNodesInQueue");
				queueInfo.MinNodesInQueue = _ctx.IntegerValue("GetAutoScaleConfig.Queues["+ i +"].MinNodesInQueue");
				queueInfo.QueueImageId = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].QueueImageId");

				List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo> queueInfo_instanceTypes = new List<GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo>();
				for (int j = 0; j < _ctx.Length("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes.Length"); j++) {
					GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo instanceTypeInfo = new GetAutoScaleConfigResponse.GetAutoScaleConfig_QueueInfo.GetAutoScaleConfig_InstanceTypeInfo();
					instanceTypeInfo.InstanceType = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].InstanceType");
					instanceTypeInfo.SpotStrategy = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].SpotStrategy");
					instanceTypeInfo.SpotPriceLimit = _ctx.FloatValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].SpotPriceLimit");
					instanceTypeInfo.ZoneId = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].ZoneId");
					instanceTypeInfo.VSwitchId = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].VSwitchId");
					instanceTypeInfo.HostNamePrefix = _ctx.StringValue("GetAutoScaleConfig.Queues["+ i +"].InstanceTypes["+ j +"].HostNamePrefix");

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
