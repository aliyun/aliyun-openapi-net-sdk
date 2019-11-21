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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListLogstashLogResponseUnmarshaller
    {
        public static ListLogstashLogResponse Unmarshall(UnmarshallerContext context)
        {
			ListLogstashLogResponse listLogstashLogResponse = new ListLogstashLogResponse();

			listLogstashLogResponse.HttpResponse = context.HttpResponse;
			listLogstashLogResponse.RequestId = context.StringValue("ListLogstashLog.RequestId");

			List<ListLogstashLogResponse.ListLogstashLog_ResultItem> listLogstashLogResponse_result = new List<ListLogstashLogResponse.ListLogstashLog_ResultItem>();
			for (int i = 0; i < context.Length("ListLogstashLog.Result.Length"); i++) {
				ListLogstashLogResponse.ListLogstashLog_ResultItem resultItem = new ListLogstashLogResponse.ListLogstashLog_ResultItem();
				resultItem.Timestamp = context.LongValue("ListLogstashLog.Result["+ i +"].timestamp");
				resultItem.Host = context.StringValue("ListLogstashLog.Result["+ i +"].host");
				resultItem.Level = context.StringValue("ListLogstashLog.Result["+ i +"].level");
				resultItem.Content = context.StringValue("ListLogstashLog.Result["+ i +"].content");
				resultItem.InstanceId = context.StringValue("ListLogstashLog.Result["+ i +"].instanceId");

				listLogstashLogResponse_result.Add(resultItem);
			}
			listLogstashLogResponse.Result = listLogstashLogResponse_result;
        
			return listLogstashLogResponse;
        }
    }
}
