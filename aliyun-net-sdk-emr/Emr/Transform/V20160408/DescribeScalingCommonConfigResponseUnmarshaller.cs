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
    public class DescribeScalingCommonConfigResponseUnmarshaller
    {
        public static DescribeScalingCommonConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScalingCommonConfigResponse describeScalingCommonConfigResponse = new DescribeScalingCommonConfigResponse();

			describeScalingCommonConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeScalingCommonConfigResponse.RequestId = _ctx.StringValue("DescribeScalingCommonConfig.RequestId");
			describeScalingCommonConfigResponse.AutoScalingHookHeartbeatDefaultTime = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingHookHeartbeatDefaultTime");
			describeScalingCommonConfigResponse.AutoScalingCoolDownTime = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingCoolDownTime");
			describeScalingCommonConfigResponse.AutoScalingMNSScalingThreadSleepTime = _ctx.LongValue("DescribeScalingCommonConfig.AutoScalingMNSScalingThreadSleepTime");
			describeScalingCommonConfigResponse.AutoScalingGroupMinSizeLimit = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingGroupMinSizeLimit");
			describeScalingCommonConfigResponse.AutoScalingGroupMaxSizeLimit = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingGroupMaxSizeLimit");
			describeScalingCommonConfigResponse.AutoScalingRuleMinDelayLimit = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingRuleMinDelayLimit");
			describeScalingCommonConfigResponse.AutoScalingRuleAlarmDelayLimit = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingRuleAlarmDelayLimit");
			describeScalingCommonConfigResponse.AutoScalingRuleAlarmSilentTime = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingRuleAlarmSilentTime");
			describeScalingCommonConfigResponse.AutoScalingConfigSystemDiskSize = _ctx.IntegerValue("DescribeScalingCommonConfig.AutoScalingConfigSystemDiskSize");
			describeScalingCommonConfigResponse.AutoScalingConfigDecommissionQueryInterval = _ctx.LongValue("DescribeScalingCommonConfig.AutoScalingConfigDecommissionQueryInterval");
        
			return describeScalingCommonConfigResponse;
        }
    }
}
