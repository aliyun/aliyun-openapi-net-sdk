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
    public class QueryTopicReverseRouteTableResponseUnmarshaller
    {
        public static QueryTopicReverseRouteTableResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTopicReverseRouteTableResponse queryTopicReverseRouteTableResponse = new QueryTopicReverseRouteTableResponse();

			queryTopicReverseRouteTableResponse.HttpResponse = context.HttpResponse;
			queryTopicReverseRouteTableResponse.RequestId = context.StringValue("QueryTopicReverseRouteTable.RequestId");
			queryTopicReverseRouteTableResponse.Success = context.BooleanValue("QueryTopicReverseRouteTable.Success");
			queryTopicReverseRouteTableResponse.Code = context.StringValue("QueryTopicReverseRouteTable.Code");
			queryTopicReverseRouteTableResponse.ErrorMessage = context.StringValue("QueryTopicReverseRouteTable.ErrorMessage");

			List<Dictionary<string, string>> queryTopicReverseRouteTableResponse_srcTopics = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("QueryTopicReverseRouteTable.SrcTopics.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "QueryTopicReverseRouteTable.SrcTopics["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					queryTopicReverseRouteTableResponse_srcTopics.Add(tmp);
				}
			}
			queryTopicReverseRouteTableResponse.SrcTopics = queryTopicReverseRouteTableResponse_srcTopics;
        
			return queryTopicReverseRouteTableResponse;
        }
    }
}
