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
using Aliyun.Acs.Ccs.Model.V20171001;

namespace Aliyun.Acs.Ccs.Transform.V20171001
{
    public class GetHotlineRecordResponseUnmarshaller
    {
        public static GetHotlineRecordResponse Unmarshall(UnmarshallerContext context)
        {
			GetHotlineRecordResponse getHotlineRecordResponse = new GetHotlineRecordResponse();

			getHotlineRecordResponse.HttpResponse = context.HttpResponse;
			getHotlineRecordResponse.RequestId = context.StringValue("GetHotlineRecord.RequestId");
			getHotlineRecordResponse.Id = context.StringValue("GetHotlineRecord.Id");
			getHotlineRecordResponse.CallType = context.StringValue("GetHotlineRecord.CallType");
			getHotlineRecordResponse.VisitorId = context.StringValue("GetHotlineRecord.VisitorId");
			getHotlineRecordResponse.VisitorPhone = context.StringValue("GetHotlineRecord.VisitorPhone");
			getHotlineRecordResponse.VisitorProvince = context.StringValue("GetHotlineRecord.VisitorProvince");
			getHotlineRecordResponse.SceneId = context.StringValue("GetHotlineRecord.SceneId");
			getHotlineRecordResponse.AgentId = context.StringValue("GetHotlineRecord.AgentId");
			getHotlineRecordResponse.AgentName = context.StringValue("GetHotlineRecord.AgentName");
			getHotlineRecordResponse.CreateTime = context.StringValue("GetHotlineRecord.CreateTime");
			getHotlineRecordResponse.FinishTime = context.StringValue("GetHotlineRecord.FinishTime");
			getHotlineRecordResponse.Status = context.StringValue("GetHotlineRecord.Status");
			getHotlineRecordResponse.Memo = context.StringValue("GetHotlineRecord.Memo");
			getHotlineRecordResponse.HangupType = context.StringValue("GetHotlineRecord.HangupType");
			getHotlineRecordResponse.Satisfaction = context.StringValue("GetHotlineRecord.Satisfaction");
			getHotlineRecordResponse.OutboundTaskId = context.StringValue("GetHotlineRecord.OutboundTaskId");
			getHotlineRecordResponse.Categories = context.StringValue("GetHotlineRecord.Categories");
			getHotlineRecordResponse.CcsInstanceId = context.StringValue("GetHotlineRecord.CcsInstanceId");
			getHotlineRecordResponse.TalkDuration = context.LongValue("GetHotlineRecord.TalkDuration");
			getHotlineRecordResponse.GroupId = context.StringValue("GetHotlineRecord.GroupId");
			getHotlineRecordResponse.GroupName = context.StringValue("GetHotlineRecord.GroupName");
        
			return getHotlineRecordResponse;
        }
    }
}
