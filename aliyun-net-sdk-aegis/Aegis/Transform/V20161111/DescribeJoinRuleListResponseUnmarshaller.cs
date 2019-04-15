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
    public class DescribeJoinRuleListResponseUnmarshaller
    {
        public static DescribeJoinRuleListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeJoinRuleListResponse describeJoinRuleListResponse = new DescribeJoinRuleListResponse();

			describeJoinRuleListResponse.HttpResponse = context.HttpResponse;
			describeJoinRuleListResponse.RequestId = context.StringValue("DescribeJoinRuleList.RequestId");

			DescribeJoinRuleListResponse.DescribeJoinRuleList_PageInfo pageInfo = new DescribeJoinRuleListResponse.DescribeJoinRuleList_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeJoinRuleList.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeJoinRuleList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeJoinRuleList.PageInfo.CurrentPage");
			pageInfo.TotalCount = context.IntegerValue("DescribeJoinRuleList.PageInfo.TotalCount");
			describeJoinRuleListResponse.PageInfo = pageInfo;

			List<DescribeJoinRuleListResponse.DescribeJoinRuleList_JoinRuleListItem> describeJoinRuleListResponse_joinRuleList = new List<DescribeJoinRuleListResponse.DescribeJoinRuleList_JoinRuleListItem>();
			for (int i = 0; i < context.Length("DescribeJoinRuleList.JoinRuleList.Length"); i++) {
				DescribeJoinRuleListResponse.DescribeJoinRuleList_JoinRuleListItem joinRuleListItem = new DescribeJoinRuleListResponse.DescribeJoinRuleList_JoinRuleListItem();
				joinRuleListItem.TimeWindow = context.IntegerValue("DescribeJoinRuleList.JoinRuleList["+ i +"].TimeWindow");
				joinRuleListItem.WarnLevel = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].WarnLevel");
				joinRuleListItem.DataSourceId1 = context.IntegerValue("DescribeJoinRuleList.JoinRuleList["+ i +"].DataSourceId1");
				joinRuleListItem.Description = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].Description");
				joinRuleListItem.RuleName = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].RuleName");
				joinRuleListItem.JoinRelation = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].JoinRelation");
				joinRuleListItem.DataSourceId2 = context.IntegerValue("DescribeJoinRuleList.JoinRuleList["+ i +"].DataSourceId2");
				joinRuleListItem.Expression2 = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].Expression2");
				joinRuleListItem.RuleId = context.IntegerValue("DescribeJoinRuleList.JoinRuleList["+ i +"].RuleId");
				joinRuleListItem.Expression1 = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].Expression1");
				joinRuleListItem.Actions = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].Actions");
				joinRuleListItem.StatisticsRules = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].StatisticsRules");
				joinRuleListItem.NeedGroup = context.BooleanValue("DescribeJoinRuleList.JoinRuleList["+ i +"].NeedGroup");
				joinRuleListItem.StatusCode = context.StringValue("DescribeJoinRuleList.JoinRuleList["+ i +"].StatusCode");

				describeJoinRuleListResponse_joinRuleList.Add(joinRuleListItem);
			}
			describeJoinRuleListResponse.JoinRuleList = describeJoinRuleListResponse_joinRuleList;
        
			return describeJoinRuleListResponse;
        }
    }
}
