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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class DescribeResourceGroupsResponseUnmarshaller
    {
        public static DescribeResourceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceGroupsResponse describeResourceGroupsResponse = new DescribeResourceGroupsResponse();

			describeResourceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceGroupsResponse.RequestId = _ctx.StringValue("DescribeResourceGroups.RequestId");
			describeResourceGroupsResponse.TotalCount = _ctx.StringValue("DescribeResourceGroups.TotalCount");

			List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem> describeResourceGroupsResponse_resourceGroup = new List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem>();
			for (int i = 0; i < _ctx.Length("DescribeResourceGroups.ResourceGroup.Length"); i++) {
				DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem resourceGroupItem = new DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem();
				resourceGroupItem.ResourceGroupId = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].ResourceGroupId");
				resourceGroupItem.ResourceGroupName = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].ResourceGroupName");
				resourceGroupItem.ResourceCount = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].ResourceCount");
				resourceGroupItem.AuthCount = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].AuthCount");
				resourceGroupItem.CreateTime = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].CreateTime");

				List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Policy> resourceGroupItem_policies = new List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Policy>();
				for (int j = 0; j < _ctx.Length("DescribeResourceGroups.ResourceGroup["+ i +"].Policies.Length"); j++) {
					DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Policy policy = new DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Policy();
					policy.Id = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].Policies["+ j +"].Id");
					policy.Name = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].Policies["+ j +"].Name");
					policy.IsDefault = _ctx.BooleanValue("DescribeResourceGroups.ResourceGroup["+ i +"].Policies["+ j +"].IsDefault");

					resourceGroupItem_policies.Add(policy);
				}
				resourceGroupItem.Policies = resourceGroupItem_policies;

				List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Timer> resourceGroupItem_timers = new List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Timer>();
				for (int j = 0; j < _ctx.Length("DescribeResourceGroups.ResourceGroup["+ i +"].Timers.Length"); j++) {
					DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Timer timer = new DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_Timer();
					timer.Id = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].Timers["+ j +"].Id");
					timer.Name = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].Timers["+ j +"].Name");
					timer.TimerStatus = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].Timers["+ j +"].TimerStatus");
					timer.BindStatus = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].Timers["+ j +"].BindStatus");

					resourceGroupItem_timers.Add(timer);
				}
				resourceGroupItem.Timers = resourceGroupItem_timers;

				List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_AppRule> resourceGroupItem_appRules = new List<DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_AppRule>();
				for (int j = 0; j < _ctx.Length("DescribeResourceGroups.ResourceGroup["+ i +"].AppRules.Length"); j++) {
					DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_AppRule appRule = new DescribeResourceGroupsResponse.DescribeResourceGroups_ResourceGroupItem.DescribeResourceGroups_AppRule();
					appRule.Id = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].AppRules["+ j +"].Id");
					appRule.Name = _ctx.StringValue("DescribeResourceGroups.ResourceGroup["+ i +"].AppRules["+ j +"].Name");
					appRule.Type = _ctx.IntegerValue("DescribeResourceGroups.ResourceGroup["+ i +"].AppRules["+ j +"].Type");

					resourceGroupItem_appRules.Add(appRule);
				}
				resourceGroupItem.AppRules = resourceGroupItem_appRules;

				describeResourceGroupsResponse_resourceGroup.Add(resourceGroupItem);
			}
			describeResourceGroupsResponse.ResourceGroup = describeResourceGroupsResponse_resourceGroup;
        
			return describeResourceGroupsResponse;
        }
    }
}
