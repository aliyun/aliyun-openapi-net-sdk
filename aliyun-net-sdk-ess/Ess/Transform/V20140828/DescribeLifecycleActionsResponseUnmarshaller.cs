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
    public class DescribeLifecycleActionsResponseUnmarshaller
    {
        public static DescribeLifecycleActionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLifecycleActionsResponse describeLifecycleActionsResponse = new DescribeLifecycleActionsResponse();

			describeLifecycleActionsResponse.HttpResponse = context.HttpResponse;
			describeLifecycleActionsResponse.RequestId = context.StringValue("DescribeLifecycleActions.RequestId");
			describeLifecycleActionsResponse.NextToken = context.StringValue("DescribeLifecycleActions.NextToken");
			describeLifecycleActionsResponse.MaxResults = context.IntegerValue("DescribeLifecycleActions.MaxResults");
			describeLifecycleActionsResponse.TotalCount = context.IntegerValue("DescribeLifecycleActions.TotalCount");

			List<DescribeLifecycleActionsResponse.DescribeLifecycleActions_LifecycleAction> describeLifecycleActionsResponse_lifecycleActions = new List<DescribeLifecycleActionsResponse.DescribeLifecycleActions_LifecycleAction>();
			for (int i = 0; i < context.Length("DescribeLifecycleActions.LifecycleActions.Length"); i++) {
				DescribeLifecycleActionsResponse.DescribeLifecycleActions_LifecycleAction lifecycleAction = new DescribeLifecycleActionsResponse.DescribeLifecycleActions_LifecycleAction();
				lifecycleAction.LifecycleActionToken = context.StringValue("DescribeLifecycleActions.LifecycleActions["+ i +"].LifecycleActionToken");
				lifecycleAction.LifecycleActionStatus = context.StringValue("DescribeLifecycleActions.LifecycleActions["+ i +"].LifecycleActionStatus");
				lifecycleAction.LifecycleActionResult = context.StringValue("DescribeLifecycleActions.LifecycleActions["+ i +"].LifecycleActionResult");
				lifecycleAction.LifecycleHookId = context.StringValue("DescribeLifecycleActions.LifecycleActions["+ i +"].LifecycleHookId");

				List<string> lifecycleAction_instanceIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeLifecycleActions.LifecycleActions["+ i +"].InstanceIds.Length"); j++) {
					lifecycleAction_instanceIds.Add(context.StringValue("DescribeLifecycleActions.LifecycleActions["+ i +"].InstanceIds["+ j +"]"));
				}
				lifecycleAction.InstanceIds = lifecycleAction_instanceIds;

				describeLifecycleActionsResponse_lifecycleActions.Add(lifecycleAction);
			}
			describeLifecycleActionsResponse.LifecycleActions = describeLifecycleActionsResponse_lifecycleActions;
        
			return describeLifecycleActionsResponse;
        }
    }
}
