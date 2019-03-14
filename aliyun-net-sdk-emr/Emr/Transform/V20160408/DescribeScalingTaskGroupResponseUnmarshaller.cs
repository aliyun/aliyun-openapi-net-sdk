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
    public class DescribeScalingTaskGroupResponseUnmarshaller
    {
        public static DescribeScalingTaskGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingTaskGroupResponse describeScalingTaskGroupResponse = new DescribeScalingTaskGroupResponse();

			describeScalingTaskGroupResponse.HttpResponse = context.HttpResponse;
			describeScalingTaskGroupResponse.RequestId = context.StringValue("DescribeScalingTaskGroup.RequestId");
			describeScalingTaskGroupResponse.ScalingGroupId = context.StringValue("DescribeScalingTaskGroup.ScalingGroupId");
			describeScalingTaskGroupResponse.HostGroupId = context.StringValue("DescribeScalingTaskGroup.HostGroupId");
			describeScalingTaskGroupResponse.MinSize = context.IntegerValue("DescribeScalingTaskGroup.MinSize");
			describeScalingTaskGroupResponse.MaxSize = context.IntegerValue("DescribeScalingTaskGroup.MaxSize");
			describeScalingTaskGroupResponse.DefaultCooldown = context.IntegerValue("DescribeScalingTaskGroup.DefaultCooldown");
			describeScalingTaskGroupResponse.Status = context.StringValue("DescribeScalingTaskGroup.Status");
			describeScalingTaskGroupResponse.ActiveRuleCategory = context.StringValue("DescribeScalingTaskGroup.ActiveRuleCategory");

			DescribeScalingTaskGroupResponse.DescribeScalingTaskGroup_ScalingConfig scalingConfig = new DescribeScalingTaskGroupResponse.DescribeScalingTaskGroup_ScalingConfig();
			scalingConfig.PayType = context.StringValue("DescribeScalingTaskGroup.ScalingConfig.PayType");
			scalingConfig.DataDiskCategory = context.StringValue("DescribeScalingTaskGroup.ScalingConfig.DataDiskCategory");
			scalingConfig.DataDiskSize = context.IntegerValue("DescribeScalingTaskGroup.ScalingConfig.DataDiskSize");
			scalingConfig.DataDiskCount = context.IntegerValue("DescribeScalingTaskGroup.ScalingConfig.DataDiskCount");
			scalingConfig.SysDiskCategory = context.StringValue("DescribeScalingTaskGroup.ScalingConfig.SysDiskCategory");
			scalingConfig.SysDiskSize = context.IntegerValue("DescribeScalingTaskGroup.ScalingConfig.SysDiskSize");
			scalingConfig.CpuCount = context.IntegerValue("DescribeScalingTaskGroup.ScalingConfig.CpuCount");
			scalingConfig.MemSize = context.IntegerValue("DescribeScalingTaskGroup.ScalingConfig.MemSize");
			scalingConfig.SpotStrategy = context.StringValue("DescribeScalingTaskGroup.ScalingConfig.SpotStrategy");

			List<string> scalingConfig_instanceTypeList = new List<string>();
			for (int i = 0; i < context.Length("DescribeScalingTaskGroup.ScalingConfig.InstanceTypeList.Length"); i++) {
				scalingConfig_instanceTypeList.Add(context.StringValue("DescribeScalingTaskGroup.ScalingConfig.InstanceTypeList["+ i +"]"));
			}
			scalingConfig.InstanceTypeList = scalingConfig_instanceTypeList;

			List<DescribeScalingTaskGroupResponse.DescribeScalingTaskGroup_ScalingConfig.DescribeScalingTaskGroup_SpotPriceLimit> scalingConfig_spotPriceLimits = new List<DescribeScalingTaskGroupResponse.DescribeScalingTaskGroup_ScalingConfig.DescribeScalingTaskGroup_SpotPriceLimit>();
			for (int i = 0; i < context.Length("DescribeScalingTaskGroup.ScalingConfig.SpotPriceLimits.Length"); i++) {
				DescribeScalingTaskGroupResponse.DescribeScalingTaskGroup_ScalingConfig.DescribeScalingTaskGroup_SpotPriceLimit spotPriceLimit = new DescribeScalingTaskGroupResponse.DescribeScalingTaskGroup_ScalingConfig.DescribeScalingTaskGroup_SpotPriceLimit();
				spotPriceLimit.InstanceType = context.StringValue("DescribeScalingTaskGroup.ScalingConfig.SpotPriceLimits["+ i +"].InstanceType");
				spotPriceLimit.PriceLimit = context.FloatValue("DescribeScalingTaskGroup.ScalingConfig.SpotPriceLimits["+ i +"].PriceLimit");

				scalingConfig_spotPriceLimits.Add(spotPriceLimit);
			}
			scalingConfig.SpotPriceLimits = scalingConfig_spotPriceLimits;
			describeScalingTaskGroupResponse.ScalingConfig = scalingConfig;
        
			return describeScalingTaskGroupResponse;
        }
    }
}
