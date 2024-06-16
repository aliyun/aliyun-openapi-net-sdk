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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveMessageGroupResponseUnmarshaller
    {
        public static DescribeLiveMessageGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveMessageGroupResponse describeLiveMessageGroupResponse = new DescribeLiveMessageGroupResponse();

			describeLiveMessageGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveMessageGroupResponse.RequestId = _ctx.StringValue("DescribeLiveMessageGroup.RequestId");
			describeLiveMessageGroupResponse.GroupId = _ctx.StringValue("DescribeLiveMessageGroup.GroupId");
			describeLiveMessageGroupResponse.CreatorId = _ctx.StringValue("DescribeLiveMessageGroup.CreatorId");
			describeLiveMessageGroupResponse.Createtime = _ctx.LongValue("DescribeLiveMessageGroup.Createtime");
			describeLiveMessageGroupResponse.GroupName = _ctx.StringValue("DescribeLiveMessageGroup.GroupName");
			describeLiveMessageGroupResponse.GroupInfo = _ctx.StringValue("DescribeLiveMessageGroup.GroupInfo");
			describeLiveMessageGroupResponse.Delete = _ctx.BooleanValue("DescribeLiveMessageGroup.Delete");
			describeLiveMessageGroupResponse.TotalTimes = _ctx.LongValue("DescribeLiveMessageGroup.TotalTimes");
			describeLiveMessageGroupResponse.OnlineUserCounts = _ctx.LongValue("DescribeLiveMessageGroup.OnlineUserCounts");
			describeLiveMessageGroupResponse.MsgAmount = _ctx.StringValue("DescribeLiveMessageGroup.MsgAmount");
			describeLiveMessageGroupResponse.Deletatime = _ctx.LongValue("DescribeLiveMessageGroup.Deletatime");
			describeLiveMessageGroupResponse.Deletor = _ctx.StringValue("DescribeLiveMessageGroup.Deletor");

			List<string> describeLiveMessageGroupResponse_adminList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLiveMessageGroup.AdminList.Length"); i++) {
				describeLiveMessageGroupResponse_adminList.Add(_ctx.StringValue("DescribeLiveMessageGroup.AdminList["+ i +"]"));
			}
			describeLiveMessageGroupResponse.AdminList = describeLiveMessageGroupResponse_adminList;
        
			return describeLiveMessageGroupResponse;
        }
    }
}
