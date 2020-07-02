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
        public static ListTopicsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTopicsResponse listTopicsResponse = new ListTopicsResponse();

			listTopicsResponse.HttpResponse = context.HttpResponse;
			listTopicsResponse.Success = context.BooleanValue("ListTopics.Success");
			listTopicsResponse.ErrorCode = context.StringValue("ListTopics.ErrorCode");
			listTopicsResponse.ErrorMessage = context.StringValue("ListTopics.ErrorMessage");
			listTopicsResponse.HttpStatusCode = context.IntegerValue("ListTopics.HttpStatusCode");
			listTopicsResponse.RequestId = context.StringValue("ListTopics.RequestId");

			ListTopicsResponse.ListTopics_Data data = new ListTopicsResponse.ListTopics_Data();
			data.PageNumber = context.IntegerValue("ListTopics.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListTopics.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListTopics.Data.TotalCount");

			List<ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem> data_topics = new List<ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem>();
			for (int i = 0; i < context.Length("ListTopics.Data.Topics.Length"); i++) {
				ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem topicsItem = new ListTopicsResponse.ListTopics_Data.ListTopics_TopicsItem();
				topicsItem.TopicId = context.LongValue("ListTopics.Data.Topics["+ i +"].TopicId");
				topicsItem.TopicName = context.StringValue("ListTopics.Data.Topics["+ i +"].TopicName");
				topicsItem.TopicStatus = context.StringValue("ListTopics.Data.Topics["+ i +"].TopicStatus");
				topicsItem.TopicType = context.StringValue("ListTopics.Data.Topics["+ i +"].TopicType");
				topicsItem.AddTime = context.LongValue("ListTopics.Data.Topics["+ i +"].AddTime");
				topicsItem.HappenTime = context.LongValue("ListTopics.Data.Topics["+ i +"].HappenTime");
				topicsItem.FixTime = context.LongValue("ListTopics.Data.Topics["+ i +"].FixTime");
				topicsItem.InstanceId = context.LongValue("ListTopics.Data.Topics["+ i +"].InstanceId");
				topicsItem.NodeId = context.LongValue("ListTopics.Data.Topics["+ i +"].NodeId");
				topicsItem.NodeName = context.StringValue("ListTopics.Data.Topics["+ i +"].NodeName");
				topicsItem.NodeOwner = context.StringValue("ListTopics.Data.Topics["+ i +"].NodeOwner");
				topicsItem.ProjectId = context.LongValue("ListTopics.Data.Topics["+ i +"].ProjectId");

				data_topics.Add(topicsItem);
			}
			data.Topics = data_topics;
			listTopicsResponse.Data = data;
        
			return listTopicsResponse;
        }
    }
}
