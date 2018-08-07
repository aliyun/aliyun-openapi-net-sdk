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
using Aliyun.Acs.Iot.Model.V20170420;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20170420
{
    public class QueryTopicRouteTableResponseUnmarshaller
    {
        public static QueryTopicRouteTableResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTopicRouteTableResponse queryTopicRouteTableResponse = new QueryTopicRouteTableResponse();

			queryTopicRouteTableResponse.HttpResponse = context.HttpResponse;
			queryTopicRouteTableResponse.RequestId = context.StringValue("QueryTopicRouteTable.RequestId");
			queryTopicRouteTableResponse.Success = context.BooleanValue("QueryTopicRouteTable.Success");
			queryTopicRouteTableResponse.Code = context.StringValue("QueryTopicRouteTable.Code");
			queryTopicRouteTableResponse.ErrorMessage = context.StringValue("QueryTopicRouteTable.ErrorMessage");

			List<string> queryTopicRouteTableResponse_dstTopics = new List<string>();
			for (int i = 0; i < context.Length("QueryTopicRouteTable.DstTopics.Length"); i++) {
				queryTopicRouteTableResponse_dstTopics.Add(context.StringValue("QueryTopicRouteTable.DstTopics["+ i +"]"));
			}
			queryTopicRouteTableResponse.DstTopics = queryTopicRouteTableResponse_dstTopics;
        
			return queryTopicRouteTableResponse;
        }
    }
}