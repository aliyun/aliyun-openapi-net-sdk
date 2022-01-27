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
    public class QueryProductTopicResponseUnmarshaller
    {
        public static QueryProductTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryProductTopicResponse queryProductTopicResponse = new QueryProductTopicResponse();

			queryProductTopicResponse.HttpResponse = _ctx.HttpResponse;
			queryProductTopicResponse.RequestId = _ctx.StringValue("QueryProductTopic.RequestId");
			queryProductTopicResponse.Success = _ctx.BooleanValue("QueryProductTopic.Success");
			queryProductTopicResponse.Code = _ctx.StringValue("QueryProductTopic.Code");
			queryProductTopicResponse.ErrorMessage = _ctx.StringValue("QueryProductTopic.ErrorMessage");

			List<QueryProductTopicResponse.QueryProductTopic_ProductTopicInfo> queryProductTopicResponse_data = new List<QueryProductTopicResponse.QueryProductTopic_ProductTopicInfo>();
			for (int i = 0; i < _ctx.Length("QueryProductTopic.Data.Length"); i++) {
				QueryProductTopicResponse.QueryProductTopic_ProductTopicInfo productTopicInfo = new QueryProductTopicResponse.QueryProductTopic_ProductTopicInfo();
				productTopicInfo.ProductKey = _ctx.StringValue("QueryProductTopic.Data["+ i +"].ProductKey");
				productTopicInfo.TopicShortName = _ctx.StringValue("QueryProductTopic.Data["+ i +"].TopicShortName");
				productTopicInfo.Operation = _ctx.StringValue("QueryProductTopic.Data["+ i +"].Operation");
				productTopicInfo.Desc = _ctx.StringValue("QueryProductTopic.Data["+ i +"].Desc");
				productTopicInfo.Id = _ctx.StringValue("QueryProductTopic.Data["+ i +"].Id");

				queryProductTopicResponse_data.Add(productTopicInfo);
			}
			queryProductTopicResponse.Data = queryProductTopicResponse_data;
        
			return queryProductTopicResponse;
        }
    }
}
