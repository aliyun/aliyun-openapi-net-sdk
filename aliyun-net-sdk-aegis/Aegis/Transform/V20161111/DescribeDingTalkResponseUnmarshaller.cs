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
    public class DescribeDingTalkResponseUnmarshaller
    {
        public static DescribeDingTalkResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDingTalkResponse describeDingTalkResponse = new DescribeDingTalkResponse();

			describeDingTalkResponse.HttpResponse = context.HttpResponse;
			describeDingTalkResponse.RequestId = context.StringValue("DescribeDingTalk.RequestId");

			DescribeDingTalkResponse.DescribeDingTalk_PageInfo pageInfo = new DescribeDingTalkResponse.DescribeDingTalk_PageInfo();
			pageInfo.PageSize = context.IntegerValue("DescribeDingTalk.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribeDingTalk.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribeDingTalk.PageInfo.CurrentPage");
			describeDingTalkResponse.PageInfo = pageInfo;

			List<DescribeDingTalkResponse.DescribeDingTalk_ActionListItem> describeDingTalkResponse_actionList = new List<DescribeDingTalkResponse.DescribeDingTalk_ActionListItem>();
			for (int i = 0; i < context.Length("DescribeDingTalk.ActionList.Length"); i++) {
				DescribeDingTalkResponse.DescribeDingTalk_ActionListItem actionListItem = new DescribeDingTalkResponse.DescribeDingTalk_ActionListItem();
				actionListItem.GmtModified = context.LongValue("DescribeDingTalk.ActionList["+ i +"].GmtModified");
				actionListItem.Id = context.IntegerValue("DescribeDingTalk.ActionList["+ i +"].Id");
				actionListItem.AliUid = context.LongValue("DescribeDingTalk.ActionList["+ i +"].AliUid");
				actionListItem.GmtCreate = context.LongValue("DescribeDingTalk.ActionList["+ i +"].GmtCreate");
				actionListItem.Url = context.StringValue("DescribeDingTalk.ActionList["+ i +"].Url");
				actionListItem.IntervalTime = context.IntegerValue("DescribeDingTalk.ActionList["+ i +"].IntervalTime");
				actionListItem.ActionName = context.StringValue("DescribeDingTalk.ActionList["+ i +"].ActionName");

				describeDingTalkResponse_actionList.Add(actionListItem);
			}
			describeDingTalkResponse.ActionList = describeDingTalkResponse_actionList;
        
			return describeDingTalkResponse;
        }
    }
}
