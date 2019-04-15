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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeGroupListResponseUnmarshaller
    {
        public static DescribeGroupListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGroupListResponse describeGroupListResponse = new DescribeGroupListResponse();

			describeGroupListResponse.HttpResponse = context.HttpResponse;
			describeGroupListResponse.RequestId = context.StringValue("DescribeGroupList.RequestId");
			describeGroupListResponse.Success = context.BooleanValue("DescribeGroupList.Success");

			DescribeGroupListResponse.DescribeGroupList_PageInfo pageInfo = new DescribeGroupListResponse.DescribeGroupList_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeGroupList.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeGroupList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeGroupList.PageInfo.CurrentPage");
			pageInfo.TotalCount = context.IntegerValue("DescribeGroupList.PageInfo.TotalCount");
			describeGroupListResponse.PageInfo = pageInfo;

			List<DescribeGroupListResponse.DescribeGroupList_RuleGroupsItem> describeGroupListResponse_ruleGroups = new List<DescribeGroupListResponse.DescribeGroupList_RuleGroupsItem>();
			for (int i = 0; i < context.Length("DescribeGroupList.RuleGroups.Length"); i++) {
				DescribeGroupListResponse.DescribeGroupList_RuleGroupsItem ruleGroupsItem = new DescribeGroupListResponse.DescribeGroupList_RuleGroupsItem();
				ruleGroupsItem.GroupName = context.StringValue("DescribeGroupList.RuleGroups["+ i +"].GroupName");
				ruleGroupsItem.RuleNum = context.IntegerValue("DescribeGroupList.RuleGroups["+ i +"].RuleNum");
				ruleGroupsItem.Modified = context.LongValue("DescribeGroupList.RuleGroups["+ i +"].Modified");
				ruleGroupsItem.Create = context.LongValue("DescribeGroupList.RuleGroups["+ i +"].Create");
				ruleGroupsItem.Description = context.StringValue("DescribeGroupList.RuleGroups["+ i +"].Description");
				ruleGroupsItem.Id = context.IntegerValue("DescribeGroupList.RuleGroups["+ i +"].Id");
				ruleGroupsItem.AliUid = context.LongValue("DescribeGroupList.RuleGroups["+ i +"].AliUid");
				ruleGroupsItem.Status = context.IntegerValue("DescribeGroupList.RuleGroups["+ i +"].Status");
				ruleGroupsItem.MachineGroupIds = context.StringValue("DescribeGroupList.RuleGroups["+ i +"].MachineGroupIds");

				describeGroupListResponse_ruleGroups.Add(ruleGroupsItem);
			}
			describeGroupListResponse.RuleGroups = describeGroupListResponse_ruleGroups;
        
			return describeGroupListResponse;
        }
    }
}
