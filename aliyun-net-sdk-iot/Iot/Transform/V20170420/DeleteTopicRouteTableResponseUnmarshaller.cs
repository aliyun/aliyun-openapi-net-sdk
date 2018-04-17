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
    public class DeleteTopicRouteTableResponseUnmarshaller
    {
        public static DeleteTopicRouteTableResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteTopicRouteTableResponse deleteTopicRouteTableResponse = new DeleteTopicRouteTableResponse();

			deleteTopicRouteTableResponse.HttpResponse = context.HttpResponse;
			deleteTopicRouteTableResponse.RequestId = context.StringValue("DeleteTopicRouteTable.RequestId");
			deleteTopicRouteTableResponse.Success = context.BooleanValue("DeleteTopicRouteTable.Success");
			deleteTopicRouteTableResponse.IsAllSucceed = context.BooleanValue("DeleteTopicRouteTable.IsAllSucceed");
			deleteTopicRouteTableResponse.ErrorMessage = context.StringValue("DeleteTopicRouteTable.ErrorMessage");

			List<string> deleteTopicRouteTableResponse_failureTopics = new List<string>();
			for (int i = 0; i < context.Length("DeleteTopicRouteTable.FailureTopics.Length"); i++) {
				deleteTopicRouteTableResponse_failureTopics.Add(context.StringValue("DeleteTopicRouteTable.FailureTopics["+ i +"]"));
			}
			deleteTopicRouteTableResponse.FailureTopics = deleteTopicRouteTableResponse_failureTopics;
        
			return deleteTopicRouteTableResponse;
        }
    }
}