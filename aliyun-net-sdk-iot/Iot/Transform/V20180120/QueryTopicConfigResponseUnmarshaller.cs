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
    public class QueryTopicConfigResponseUnmarshaller
    {
        public static QueryTopicConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTopicConfigResponse queryTopicConfigResponse = new QueryTopicConfigResponse();

			queryTopicConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryTopicConfigResponse.RequestId = _ctx.StringValue("QueryTopicConfig.RequestId");
			queryTopicConfigResponse.Success = _ctx.BooleanValue("QueryTopicConfig.Success");
			queryTopicConfigResponse.Code = _ctx.StringValue("QueryTopicConfig.Code");
			queryTopicConfigResponse.Message = _ctx.StringValue("QueryTopicConfig.Message");

			List<QueryTopicConfigResponse.QueryTopicConfig_TopicConfigInfo> queryTopicConfigResponse_data = new List<QueryTopicConfigResponse.QueryTopicConfig_TopicConfigInfo>();
			for (int i = 0; i < _ctx.Length("QueryTopicConfig.Data.Length"); i++) {
				QueryTopicConfigResponse.QueryTopicConfig_TopicConfigInfo topicConfigInfo = new QueryTopicConfigResponse.QueryTopicConfig_TopicConfigInfo();
				topicConfigInfo.ProductKey = _ctx.StringValue("QueryTopicConfig.Data["+ i +"].ProductKey");
				topicConfigInfo.TopicFullName = _ctx.StringValue("QueryTopicConfig.Data["+ i +"].TopicFullName");
				topicConfigInfo.Operation = _ctx.StringValue("QueryTopicConfig.Data["+ i +"].Operation");
				topicConfigInfo.Description = _ctx.StringValue("QueryTopicConfig.Data["+ i +"].Description");
				topicConfigInfo.EnableBroadcast = _ctx.BooleanValue("QueryTopicConfig.Data["+ i +"].EnableBroadcast");
				topicConfigInfo.EnableProxySubscribe = _ctx.BooleanValue("QueryTopicConfig.Data["+ i +"].EnableProxySubscribe");
				topicConfigInfo.Codec = _ctx.StringValue("QueryTopicConfig.Data["+ i +"].Codec");

				queryTopicConfigResponse_data.Add(topicConfigInfo);
			}
			queryTopicConfigResponse.Data = queryTopicConfigResponse_data;
        
			return queryTopicConfigResponse;
        }
    }
}
