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
    public class ListSearchLogResponseUnmarshaller
    {
        public static ListSearchLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSearchLogResponse listSearchLogResponse = new ListSearchLogResponse();

			listSearchLogResponse.HttpResponse = _ctx.HttpResponse;
			listSearchLogResponse.RequestId = _ctx.StringValue("ListSearchLog.RequestId");

			ListSearchLogResponse.ListSearchLog_Headers headers = new ListSearchLogResponse.ListSearchLog_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListSearchLog.Headers.X-Total-Count");
			listSearchLogResponse.Headers = headers;

			List<ListSearchLogResponse.ListSearchLog_ResultItem> listSearchLogResponse_result = new List<ListSearchLogResponse.ListSearchLog_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListSearchLog.Result.Length"); i++) {
				ListSearchLogResponse.ListSearchLog_ResultItem resultItem = new ListSearchLogResponse.ListSearchLog_ResultItem();
				resultItem.Timestamp = _ctx.LongValue("ListSearchLog.Result["+ i +"].timestamp");
				resultItem.Host = _ctx.StringValue("ListSearchLog.Result["+ i +"].host");
				resultItem.InstanceId = _ctx.StringValue("ListSearchLog.Result["+ i +"].instanceId");
				resultItem.ContentCollection = _ctx.StringValue("ListSearchLog.Result["+ i +"].contentCollection");
				resultItem.Level = _ctx.StringValue("ListSearchLog.Result["+ i +"].level");
				resultItem.Content = _ctx.StringValue("ListSearchLog.Result["+ i +"].content");

				listSearchLogResponse_result.Add(resultItem);
			}
			listSearchLogResponse.Result = listSearchLogResponse_result;
        
			return listSearchLogResponse;
        }
    }
}
