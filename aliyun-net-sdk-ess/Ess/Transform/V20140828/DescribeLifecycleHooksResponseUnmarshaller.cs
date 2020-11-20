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
    public class DescribeLifecycleHooksResponseUnmarshaller
    {
        public static DescribeLifecycleHooksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLifecycleHooksResponse describeLifecycleHooksResponse = new DescribeLifecycleHooksResponse();

			describeLifecycleHooksResponse.HttpResponse = context.HttpResponse;
			describeLifecycleHooksResponse.TotalCount = context.IntegerValue("DescribeLifecycleHooks.TotalCount");
			describeLifecycleHooksResponse.PageNumber = context.IntegerValue("DescribeLifecycleHooks.PageNumber");
			describeLifecycleHooksResponse.PageSize = context.IntegerValue("DescribeLifecycleHooks.PageSize");
			describeLifecycleHooksResponse.RequestId = context.StringValue("DescribeLifecycleHooks.RequestId");

			List<DescribeLifecycleHooksResponse.DescribeLifecycleHooks_LifecycleHook> describeLifecycleHooksResponse_lifecycleHooks = new List<DescribeLifecycleHooksResponse.DescribeLifecycleHooks_LifecycleHook>();
			for (int i = 0; i < context.Length("DescribeLifecycleHooks.LifecycleHooks.Length"); i++) {
				DescribeLifecycleHooksResponse.DescribeLifecycleHooks_LifecycleHook lifecycleHook = new DescribeLifecycleHooksResponse.DescribeLifecycleHooks_LifecycleHook();
				lifecycleHook.ScalingGroupId = context.StringValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].ScalingGroupId");
				lifecycleHook.LifecycleHookId = context.StringValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].LifecycleHookId");
				lifecycleHook.LifecycleHookName = context.StringValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].LifecycleHookName");
				lifecycleHook.DefaultResult = context.StringValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].DefaultResult");
				lifecycleHook.HeartbeatTimeout = context.IntegerValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].HeartbeatTimeout");
				lifecycleHook.LifecycleTransition = context.StringValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].LifecycleTransition");
				lifecycleHook.NotificationMetadata = context.StringValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].NotificationMetadata");
				lifecycleHook.NotificationArn = context.StringValue("DescribeLifecycleHooks.LifecycleHooks["+ i +"].NotificationArn");

				describeLifecycleHooksResponse_lifecycleHooks.Add(lifecycleHook);
			}
			describeLifecycleHooksResponse.LifecycleHooks = describeLifecycleHooksResponse_lifecycleHooks;
        
			return describeLifecycleHooksResponse;
        }
    }
}
