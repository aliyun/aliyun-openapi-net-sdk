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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
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

			List<DescribeDingTalkResponse.DescribeDingTalk_ActionListArr> describeDingTalkResponse_actionList = new List<DescribeDingTalkResponse.DescribeDingTalk_ActionListArr>();
			for (int i = 0; i < context.Length("DescribeDingTalk.ActionList.Length"); i++) {
				DescribeDingTalkResponse.DescribeDingTalk_ActionListArr actionListArr = new DescribeDingTalkResponse.DescribeDingTalk_ActionListArr();
				actionListArr.GmtModified = context.LongValue("DescribeDingTalk.ActionList["+ i +"].GmtModified");
				actionListArr.Id = context.IntegerValue("DescribeDingTalk.ActionList["+ i +"].Id");
				actionListArr.AliUid = context.LongValue("DescribeDingTalk.ActionList["+ i +"].AliUid");
				actionListArr.GmtCreate = context.LongValue("DescribeDingTalk.ActionList["+ i +"].GmtCreate");
				actionListArr.Url = context.StringValue("DescribeDingTalk.ActionList["+ i +"].Url");
				actionListArr.IntervalTime = context.IntegerValue("DescribeDingTalk.ActionList["+ i +"].IntervalTime");
				actionListArr.ActionName = context.StringValue("DescribeDingTalk.ActionList["+ i +"].ActionName");
				actionListArr.Status = context.IntegerValue("DescribeDingTalk.ActionList["+ i +"].Status");
				actionListArr.ConfigList = context.StringValue("DescribeDingTalk.ActionList["+ i +"].ConfigList");
				actionListArr.GroupIdList = context.StringValue("DescribeDingTalk.ActionList["+ i +"].GroupIdList");
				actionListArr.DingTalkLang = context.StringValue("DescribeDingTalk.ActionList["+ i +"].DingTalkLang");

				describeDingTalkResponse_actionList.Add(actionListArr);
			}
			describeDingTalkResponse.ActionList = describeDingTalkResponse_actionList;
        
			return describeDingTalkResponse;
        }
    }
}
