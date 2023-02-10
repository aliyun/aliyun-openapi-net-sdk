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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListIpsecServerLogsResponseUnmarshaller
    {
        public static ListIpsecServerLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIpsecServerLogsResponse listIpsecServerLogsResponse = new ListIpsecServerLogsResponse();

			listIpsecServerLogsResponse.HttpResponse = _ctx.HttpResponse;
			listIpsecServerLogsResponse.PageSize = _ctx.IntegerValue("ListIpsecServerLogs.PageSize");
			listIpsecServerLogsResponse.PageNumber = _ctx.IntegerValue("ListIpsecServerLogs.PageNumber");
			listIpsecServerLogsResponse.RequestId = _ctx.StringValue("ListIpsecServerLogs.RequestId");
			listIpsecServerLogsResponse.Count = _ctx.IntegerValue("ListIpsecServerLogs.Count");
			listIpsecServerLogsResponse.IsCompleted = _ctx.BooleanValue("ListIpsecServerLogs.IsCompleted");

			List<string> listIpsecServerLogsResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("ListIpsecServerLogs.Data.Length"); i++) {
				listIpsecServerLogsResponse_data.Add(_ctx.StringValue("ListIpsecServerLogs.Data["+ i +"]"));
			}
			listIpsecServerLogsResponse.Data = listIpsecServerLogsResponse_data;
        
			return listIpsecServerLogsResponse;
        }
    }
}
