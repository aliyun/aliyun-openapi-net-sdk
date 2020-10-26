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
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeLimitationResponseUnmarshaller
    {
        public static DescribeLimitationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLimitationResponse describeLimitationResponse = new DescribeLimitationResponse();

			describeLimitationResponse.HttpResponse = context.HttpResponse;
			describeLimitationResponse.MaxNumberOfScalingGroups = context.IntegerValue("DescribeLimitation.MaxNumberOfScalingGroups");
			describeLimitationResponse.MaxNumberOfScalingConfigurations = context.IntegerValue("DescribeLimitation.MaxNumberOfScalingConfigurations");
			describeLimitationResponse.MaxNumberOfScalingRules = context.IntegerValue("DescribeLimitation.MaxNumberOfScalingRules");
			describeLimitationResponse.MaxNumberOfScheduledTasks = context.IntegerValue("DescribeLimitation.MaxNumberOfScheduledTasks");
			describeLimitationResponse.MaxNumberOfScalingInstances = context.IntegerValue("DescribeLimitation.MaxNumberOfScalingInstances");
			describeLimitationResponse.MaxNumberOfDBInstances = context.IntegerValue("DescribeLimitation.MaxNumberOfDBInstances");
			describeLimitationResponse.MaxNumberOfLoadBalancers = context.IntegerValue("DescribeLimitation.MaxNumberOfLoadBalancers");
			describeLimitationResponse.MaxNumberOfMinSize = context.IntegerValue("DescribeLimitation.MaxNumberOfMinSize");
			describeLimitationResponse.MaxNumberOfMaxSize = context.IntegerValue("DescribeLimitation.MaxNumberOfMaxSize");
			describeLimitationResponse.MaxNumberOfVServerGroups = context.IntegerValue("DescribeLimitation.MaxNumberOfVServerGroups");
			describeLimitationResponse.MaxNumberOfLifecycleHooks = context.IntegerValue("DescribeLimitation.MaxNumberOfLifecycleHooks");
			describeLimitationResponse.MaxNumberOfNotificationConfigurations = context.IntegerValue("DescribeLimitation.MaxNumberOfNotificationConfigurations");
        
			return describeLimitationResponse;
        }
    }
}
