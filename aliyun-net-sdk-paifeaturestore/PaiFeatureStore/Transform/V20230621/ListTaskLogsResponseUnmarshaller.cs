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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListTaskLogsResponseUnmarshaller
    {
        public static ListTaskLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskLogsResponse listTaskLogsResponse = new ListTaskLogsResponse();

			listTaskLogsResponse.HttpResponse = _ctx.HttpResponse;
			listTaskLogsResponse.RequestId = _ctx.StringValue("ListTaskLogs.RequestId");
			listTaskLogsResponse.TotalCount = _ctx.IntegerValue("ListTaskLogs.TotalCount");

			List<string> listTaskLogsResponse_logs = new List<string>();
			for (int i = 0; i < _ctx.Length("ListTaskLogs.Logs.Length"); i++) {
				listTaskLogsResponse_logs.Add(_ctx.StringValue("ListTaskLogs.Logs["+ i +"]"));
			}
			listTaskLogsResponse.Logs = listTaskLogsResponse_logs;
        
			return listTaskLogsResponse;
        }
    }
}
