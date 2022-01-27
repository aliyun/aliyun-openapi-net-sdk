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
        public static DescribeDingTalkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDingTalkResponse describeDingTalkResponse = new DescribeDingTalkResponse();

			describeDingTalkResponse.HttpResponse = _ctx.HttpResponse;
			describeDingTalkResponse.RequestId = _ctx.StringValue("DescribeDingTalk.RequestId");

			DescribeDingTalkResponse.DescribeDingTalk_PageInfo pageInfo = new DescribeDingTalkResponse.DescribeDingTalk_PageInfo();
			pageInfo.PageSize = _ctx.IntegerValue("DescribeDingTalk.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeDingTalk.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeDingTalk.PageInfo.CurrentPage");
			describeDingTalkResponse.PageInfo = pageInfo;

			List<DescribeDingTalkResponse.DescribeDingTalk_ActionListArr> describeDingTalkResponse_actionList = new List<DescribeDingTalkResponse.DescribeDingTalk_ActionListArr>();
			for (int i = 0; i < _ctx.Length("DescribeDingTalk.ActionList.Length"); i++) {
				DescribeDingTalkResponse.DescribeDingTalk_ActionListArr actionListArr = new DescribeDingTalkResponse.DescribeDingTalk_ActionListArr();
				actionListArr.GmtModified = _ctx.LongValue("DescribeDingTalk.ActionList["+ i +"].GmtModified");
				actionListArr.Id = _ctx.IntegerValue("DescribeDingTalk.ActionList["+ i +"].Id");
				actionListArr.AliUid = _ctx.LongValue("DescribeDingTalk.ActionList["+ i +"].AliUid");
				actionListArr.GmtCreate = _ctx.LongValue("DescribeDingTalk.ActionList["+ i +"].GmtCreate");
				actionListArr.Url = _ctx.StringValue("DescribeDingTalk.ActionList["+ i +"].Url");
				actionListArr.IntervalTime = _ctx.IntegerValue("DescribeDingTalk.ActionList["+ i +"].IntervalTime");
				actionListArr.ActionName = _ctx.StringValue("DescribeDingTalk.ActionList["+ i +"].ActionName");
				actionListArr.Status = _ctx.IntegerValue("DescribeDingTalk.ActionList["+ i +"].Status");
				actionListArr.ConfigList = _ctx.StringValue("DescribeDingTalk.ActionList["+ i +"].ConfigList");
				actionListArr.GroupIdList = _ctx.StringValue("DescribeDingTalk.ActionList["+ i +"].GroupIdList");
				actionListArr.DingTalkLang = _ctx.StringValue("DescribeDingTalk.ActionList["+ i +"].DingTalkLang");

				describeDingTalkResponse_actionList.Add(actionListArr);
			}
			describeDingTalkResponse.ActionList = describeDingTalkResponse_actionList;
        
			return describeDingTalkResponse;
        }
    }
}
