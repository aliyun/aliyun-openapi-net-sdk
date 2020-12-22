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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeVServerGroupsResponseUnmarshaller
    {
        public static DescribeVServerGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVServerGroupsResponse describeVServerGroupsResponse = new DescribeVServerGroupsResponse();

			describeVServerGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeVServerGroupsResponse.RequestId = _ctx.StringValue("DescribeVServerGroups.RequestId");

			List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup> describeVServerGroupsResponse_vServerGroups = new List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup>();
			for (int i = 0; i < _ctx.Length("DescribeVServerGroups.VServerGroups.Length"); i++) {
				DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup vServerGroup = new DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup();
				vServerGroup.VServerGroupId = _ctx.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].VServerGroupId");
				vServerGroup.VServerGroupName = _ctx.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].VServerGroupName");

				DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects associatedObjects = new DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects();

				List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Listener> associatedObjects_listeners = new List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Listener>();
				for (int j = 0; j < _ctx.Length("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Listeners.Length"); j++) {
					DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Listener listener = new DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Listener();
					listener.Protocol = _ctx.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Listeners["+ j +"].Protocol");
					listener.Port = _ctx.IntegerValue("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Listeners["+ j +"].Port");

					associatedObjects_listeners.Add(listener);
				}
				associatedObjects.Listeners = associatedObjects_listeners;

				List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Rule> associatedObjects_rules = new List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Rule>();
				for (int j = 0; j < _ctx.Length("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Rules.Length"); j++) {
					DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Rule rule = new DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup.DescribeVServerGroups_AssociatedObjects.DescribeVServerGroups_Rule();
					rule.RuleId = _ctx.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Rules["+ j +"].RuleId");
					rule.Domain = _ctx.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Rules["+ j +"].Domain");
					rule.Url = _ctx.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Rules["+ j +"].Url");
					rule.RuleName = _ctx.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].AssociatedObjects.Rules["+ j +"].RuleName");

					associatedObjects_rules.Add(rule);
				}
				associatedObjects.Rules = associatedObjects_rules;
				vServerGroup.AssociatedObjects = associatedObjects;

				describeVServerGroupsResponse_vServerGroups.Add(vServerGroup);
			}
			describeVServerGroupsResponse.VServerGroups = describeVServerGroupsResponse_vServerGroups;
        
			return describeVServerGroupsResponse;
        }
    }
}
