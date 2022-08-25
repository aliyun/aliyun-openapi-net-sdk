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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryDeviceSubTopicResponseUnmarshaller
    {
        public static QueryDeviceSubTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceSubTopicResponse queryDeviceSubTopicResponse = new QueryDeviceSubTopicResponse();

			queryDeviceSubTopicResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceSubTopicResponse.RequestId = _ctx.StringValue("QueryDeviceSubTopic.RequestId");
			queryDeviceSubTopicResponse.Success = _ctx.BooleanValue("QueryDeviceSubTopic.Success");
			queryDeviceSubTopicResponse.Code = _ctx.StringValue("QueryDeviceSubTopic.Code");
			queryDeviceSubTopicResponse.ErrorMessage = _ctx.StringValue("QueryDeviceSubTopic.ErrorMessage");

			List<QueryDeviceSubTopicResponse.QueryDeviceSubTopic_Topic> queryDeviceSubTopicResponse_topicList = new List<QueryDeviceSubTopicResponse.QueryDeviceSubTopic_Topic>();
			for (int i = 0; i < _ctx.Length("QueryDeviceSubTopic.TopicList.Length"); i++) {
				QueryDeviceSubTopicResponse.QueryDeviceSubTopic_Topic topic = new QueryDeviceSubTopicResponse.QueryDeviceSubTopic_Topic();
				topic.TopicName = _ctx.StringValue("QueryDeviceSubTopic.TopicList["+ i +"].TopicName");
				topic.Timestamp = _ctx.LongValue("QueryDeviceSubTopic.TopicList["+ i +"].Timestamp");

				queryDeviceSubTopicResponse_topicList.Add(topic);
			}
			queryDeviceSubTopicResponse.TopicList = queryDeviceSubTopicResponse_topicList;
        
			return queryDeviceSubTopicResponse;
        }
    }
}
