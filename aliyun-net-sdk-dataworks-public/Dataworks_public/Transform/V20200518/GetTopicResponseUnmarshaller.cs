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
        public static GetTopicResponse Unmarshall(UnmarshallerContext context)
        {
			GetTopicResponse getTopicResponse = new GetTopicResponse();

			getTopicResponse.HttpResponse = context.HttpResponse;
			getTopicResponse.Success = context.BooleanValue("GetTopic.Success");
			getTopicResponse.ErrorCode = context.StringValue("GetTopic.ErrorCode");
			getTopicResponse.ErrorMessage = context.StringValue("GetTopic.ErrorMessage");
			getTopicResponse.HttpStatusCode = context.IntegerValue("GetTopic.HttpStatusCode");
			getTopicResponse.RequestId = context.StringValue("GetTopic.RequestId");

			GetTopicResponse.GetTopic_Data data = new GetTopicResponse.GetTopic_Data();
			data.TopicId = context.LongValue("GetTopic.Data.TopicId");
			data.TopicName = context.StringValue("GetTopic.Data.TopicName");
			data.TopicStatus = context.StringValue("GetTopic.Data.TopicStatus");
			data.TopicType = context.StringValue("GetTopic.Data.TopicType");
			data.AddTime = context.LongValue("GetTopic.Data.AddTime");
			data.AlertTime = context.LongValue("GetTopic.Data.AlertTime");
			data.Assigner = context.StringValue("GetTopic.Data.Assigner");
			data.BaselineId = context.LongValue("GetTopic.Data.BaselineId");
			data.BaselineName = context.StringValue("GetTopic.Data.BaselineName");
			data.BaselineInGroupId = context.IntegerValue("GetTopic.Data.BaselineInGroupId");
			data.BaselineStatus = context.StringValue("GetTopic.Data.BaselineStatus");
			data.BaselineBuffer = context.LongValue("GetTopic.Data.BaselineBuffer");
			data.Buffer = context.LongValue("GetTopic.Data.Buffer");
			data.DealTime = context.LongValue("GetTopic.Data.DealTime");
			data.DealUser = context.StringValue("GetTopic.Data.DealUser");
			data.FixTime = context.LongValue("GetTopic.Data.FixTime");
			data.HappenTime = context.LongValue("GetTopic.Data.HappenTime");
			data.InstanceId = context.LongValue("GetTopic.Data.InstanceId");
			data.NextAlertTime = context.LongValue("GetTopic.Data.NextAlertTime");
			data.NodeId = context.LongValue("GetTopic.Data.NodeId");
			data.NodeName = context.StringValue("GetTopic.Data.NodeName");
			data.Owner = context.StringValue("GetTopic.Data.Owner");
			data.ProjectId = context.LongValue("GetTopic.Data.ProjectId");
			getTopicResponse.Data = data;
        
			return getTopicResponse;
        }
    }
}
