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
    public class DescribeResultListResponseUnmarshaller
    {
        public static DescribeResultListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResultListResponse describeResultListResponse = new DescribeResultListResponse();

			describeResultListResponse.HttpResponse = context.HttpResponse;
			describeResultListResponse.RequestId = context.StringValue("DescribeResultList.RequestId");

			DescribeResultListResponse.DescribeResultList_PageInfo pageInfo = new DescribeResultListResponse.DescribeResultList_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeResultList.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeResultList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeResultList.PageInfo.CurrentPage");
			pageInfo.TotalCount = context.IntegerValue("DescribeResultList.PageInfo.TotalCount");
			describeResultListResponse.PageInfo = pageInfo;

			List<DescribeResultListResponse.DescribeResultList_ResultListItem> describeResultListResponse_resultList = new List<DescribeResultListResponse.DescribeResultList_ResultListItem>();
			for (int i = 0; i < context.Length("DescribeResultList.ResultList.Length"); i++) {
				DescribeResultListResponse.DescribeResultList_ResultListItem resultListItem = new DescribeResultListResponse.DescribeResultList_ResultListItem();
				resultListItem.LastTimestamp = context.LongValue("DescribeResultList.ResultList["+ i +"].LastTimestamp");
				resultListItem.ModifiedTimestamp = context.LongValue("DescribeResultList.ResultList["+ i +"].ModifiedTimestamp");
				resultListItem.WarnLevel = context.StringValue("DescribeResultList.ResultList["+ i +"].WarnLevel");
				resultListItem.UniqueKey = context.StringValue("DescribeResultList.ResultList["+ i +"].UniqueKey");
				resultListItem.LastOperate = context.LongValue("DescribeResultList.ResultList["+ i +"].LastOperate");
				resultListItem.CreateTimestamp = context.LongValue("DescribeResultList.ResultList["+ i +"].CreateTimestamp");
				resultListItem.RuleDescription = context.StringValue("DescribeResultList.ResultList["+ i +"].RuleDescription");
				resultListItem.RuleType = context.StringValue("DescribeResultList.ResultList["+ i +"].RuleType");
				resultListItem.RuleName = context.StringValue("DescribeResultList.ResultList["+ i +"].RuleName");
				resultListItem.Details = context.StringValue("DescribeResultList.ResultList["+ i +"].Details");
				resultListItem.Id = context.IntegerValue("DescribeResultList.ResultList["+ i +"].Id");
				resultListItem.AliUid = context.LongValue("DescribeResultList.ResultList["+ i +"].AliUid");
				resultListItem.RuleId = context.IntegerValue("DescribeResultList.ResultList["+ i +"].RuleId");
				resultListItem.Status = context.IntegerValue("DescribeResultList.ResultList["+ i +"].Status");
				resultListItem.FieldKey = context.StringValue("DescribeResultList.ResultList["+ i +"].FieldKey");
				resultListItem.InternetIp = context.StringValue("DescribeResultList.ResultList["+ i +"].InternetIp");
				resultListItem.IntranetIp = context.StringValue("DescribeResultList.ResultList["+ i +"].IntranetIp");
				resultListItem.InstanceId = context.StringValue("DescribeResultList.ResultList["+ i +"].InstanceId");
				resultListItem.InstanceName = context.StringValue("DescribeResultList.ResultList["+ i +"].InstanceName");
				resultListItem.FieldKey1 = context.StringValue("DescribeResultList.ResultList["+ i +"].FieldKey");

				describeResultListResponse_resultList.Add(resultListItem);
			}
			describeResultListResponse.ResultList = describeResultListResponse_resultList;
        
			return describeResultListResponse;
        }
    }
}
