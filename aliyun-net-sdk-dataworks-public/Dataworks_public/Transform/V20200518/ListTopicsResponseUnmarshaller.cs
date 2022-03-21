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
    public class ListTopicsResponseUnmarshaller
    {
        public static ListTopicsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTopicsResponse listTopicsResponse = new ListTopicsResponse();

			listTopicsResponse.HttpResponse = _ctx.HttpResponse;
			listTopicsResponse.HttpStatusCode = _ctx.IntegerValue("ListTopics.HttpStatusCode");
			listTopicsResponse.RequestId = _ctx.StringValue("ListTopics.RequestId");
			listTopicsResponse.ErrorMessage = _ctx.StringValue("ListTopics.ErrorMessage");
			listTopicsResponse.ErrorCode = _ctx.StringValue("ListTopics.ErrorCode");
			listTopicsResponse.Success = _ctx.BooleanValue("ListTopics.Success");

			ListTopicsResponse.ListTopics_Data data = new ListTopicsResponse.ListTopics_Data();
			data.PageNumber = _ctx.IntegerValue("ListTopics.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListTopics.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListTopics.Data.TotalCount");

			List<ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem> data_topics = new List<ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem>();
			for (int i = 0; i < _ctx.Length("ListTopics.Data.Topics.Length"); i++) {
				ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem topicsItem = new ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem();
				topicsItem.TopicName = _ctx.StringValue("ListTopics.Data.Topics["+ i +"].TopicName");
				topicsItem.ProjectId = _ctx.LongValue("ListTopics.Data.Topics["+ i +"].ProjectId");
				topicsItem.NodeOwner = _ctx.StringValue("ListTopics.Data.Topics["+ i +"].NodeOwner");
				topicsItem.InstanceId = _ctx.LongValue("ListTopics.Data.Topics["+ i +"].InstanceId");
				topicsItem.FixTime = _ctx.LongValue("ListTopics.Data.Topics["+ i +"].FixTime");
				topicsItem.TopicType = _ctx.StringValue("ListTopics.Data.Topics["+ i +"].TopicType");
				topicsItem.TopicStatus = _ctx.StringValue("ListTopics.Data.Topics["+ i +"].TopicStatus");
				topicsItem.HappenTime = _ctx.LongValue("ListTopics.Data.Topics["+ i +"].HappenTime");
				topicsItem.NodeName = _ctx.StringValue("ListTopics.Data.Topics["+ i +"].NodeName");
				topicsItem.TopicId = _ctx.LongValue("ListTopics.Data.Topics["+ i +"].TopicId");
				topicsItem.AddTime = _ctx.LongValue("ListTopics.Data.Topics["+ i +"].AddTime");
				topicsItem.NodeId = _ctx.LongValue("ListTopics.Data.Topics["+ i +"].NodeId");

				data_topics.Add(topicsItem);
			}
			data.Topics = data_topics;
			listTopicsResponse.Data = data;
        
			return listTopicsResponse;
        }
    }
}
