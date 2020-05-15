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
    public class CreateTopicRouteTableResponseUnmarshaller
    {
        public static CreateTopicRouteTableResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTopicRouteTableResponse createTopicRouteTableResponse = new CreateTopicRouteTableResponse();

			createTopicRouteTableResponse.HttpResponse = context.HttpResponse;
			createTopicRouteTableResponse.RequestId = context.StringValue("CreateTopicRouteTable.RequestId");
			createTopicRouteTableResponse.Success = context.BooleanValue("CreateTopicRouteTable.Success");
			createTopicRouteTableResponse.Code = context.StringValue("CreateTopicRouteTable.Code");
			createTopicRouteTableResponse.IsAllSucceed = context.BooleanValue("CreateTopicRouteTable.IsAllSucceed");
			createTopicRouteTableResponse.ErrorMessage = context.StringValue("CreateTopicRouteTable.ErrorMessage");

			List<Dictionary<string, string>> createTopicRouteTableResponse_failureTopics = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("CreateTopicRouteTable.FailureTopics.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "CreateTopicRouteTable.FailureTopics["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					createTopicRouteTableResponse_failureTopics.Add(tmp);
				}
			}
			createTopicRouteTableResponse.FailureTopics = createTopicRouteTableResponse_failureTopics;
        
			return createTopicRouteTableResponse;
        }
    }
}
