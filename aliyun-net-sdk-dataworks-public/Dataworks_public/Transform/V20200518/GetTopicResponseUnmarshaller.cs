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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetTopicResponseUnmarshaller
    {
        public static GetTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTopicResponse getTopicResponse = new GetTopicResponse();

			getTopicResponse.HttpResponse = _ctx.HttpResponse;
			getTopicResponse.HttpStatusCode = _ctx.IntegerValue("GetTopic.HttpStatusCode");
			getTopicResponse.RequestId = _ctx.StringValue("GetTopic.RequestId");
			getTopicResponse.ErrorMessage = _ctx.StringValue("GetTopic.ErrorMessage");
			getTopicResponse.ErrorCode = _ctx.StringValue("GetTopic.ErrorCode");
			getTopicResponse.Success = _ctx.BooleanValue("GetTopic.Success");

			GetTopicResponse.GetTopic_Data data = new GetTopicResponse.GetTopic_Data();
			data.Owner = _ctx.StringValue("GetTopic.Data.Owner");
			data.TopicName = _ctx.StringValue("GetTopic.Data.TopicName");
			data.BaselineStatus = _ctx.StringValue("GetTopic.Data.BaselineStatus");
			data.ProjectId = _ctx.LongValue("GetTopic.Data.ProjectId");
			data.NextAlertTime = _ctx.LongValue("GetTopic.Data.NextAlertTime");
			data.InstanceId = _ctx.LongValue("GetTopic.Data.InstanceId");
			data.FixTime = _ctx.LongValue("GetTopic.Data.FixTime");
			data.BaselineInGroupId = _ctx.IntegerValue("GetTopic.Data.BaselineInGroupId");
			data.BaselineBuffer = _ctx.LongValue("GetTopic.Data.BaselineBuffer");
			data.TopicType = _ctx.StringValue("GetTopic.Data.TopicType");
			data.TopicStatus = _ctx.StringValue("GetTopic.Data.TopicStatus");
			data.HappenTime = _ctx.LongValue("GetTopic.Data.HappenTime");
			data.DealTime = _ctx.LongValue("GetTopic.Data.DealTime");
			data.DealUser = _ctx.StringValue("GetTopic.Data.DealUser");
			data.BaselineName = _ctx.StringValue("GetTopic.Data.BaselineName");
			data.BaselineId = _ctx.LongValue("GetTopic.Data.BaselineId");
			data.NodeName = _ctx.StringValue("GetTopic.Data.NodeName");
			data.AlertTime = _ctx.LongValue("GetTopic.Data.AlertTime");
			data.Buffer = _ctx.LongValue("GetTopic.Data.Buffer");
			data.Assigner = _ctx.StringValue("GetTopic.Data.Assigner");
			data.TopicId = _ctx.LongValue("GetTopic.Data.TopicId");
			data.AddTime = _ctx.LongValue("GetTopic.Data.AddTime");
			data.NodeId = _ctx.LongValue("GetTopic.Data.NodeId");
			getTopicResponse.Data = data;
        
			return getTopicResponse;
        }
    }
}
