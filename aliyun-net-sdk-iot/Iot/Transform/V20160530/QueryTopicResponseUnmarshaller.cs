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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20160530;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class QueryTopicResponseUnmarshaller
    {
        public static QueryTopicResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTopicResponse queryTopicResponse = new QueryTopicResponse();

			queryTopicResponse.HttpResponse = context.HttpResponse;
			queryTopicResponse.RequestId = context.StringValue("QueryTopic.RequestId");
			queryTopicResponse.Success = context.BooleanValue("QueryTopic.Success");
			queryTopicResponse.ErrorMessage = context.StringValue("QueryTopic.ErrorMessage");

			List<QueryTopicResponse.TopicInfo> topicList = new List<QueryTopicResponse.TopicInfo>();
			for (int i = 0; i < context.Length("QueryTopic.TopicList.Length"); i++) {
				QueryTopicResponse.TopicInfo topicInfo = new QueryTopicResponse.TopicInfo();
				topicInfo.TopicName = context.StringValue("QueryTopic.TopicList["+ i +"].TopicName");
				topicInfo.ProductKey = context.StringValue("QueryTopic.TopicList["+ i +"].ProductKey");
				topicInfo.TopicMessageCount = context.IntegerValue("QueryTopic.TopicList["+ i +"].TopicMessageCount");
				topicInfo.OwnerUserId = context.StringValue("QueryTopic.TopicList["+ i +"].OwnerUserId");

				topicList.Add(topicInfo);
			}
			queryTopicResponse.TopicList = topicList;
        
			return queryTopicResponse;
        }
    }
}