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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListAgentStateLogsResponseUnmarshaller
    {
        public static ListAgentStateLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAgentStateLogsResponse listAgentStateLogsResponse = new ListAgentStateLogsResponse();

			listAgentStateLogsResponse.HttpResponse = _ctx.HttpResponse;
			listAgentStateLogsResponse.Code = _ctx.StringValue("ListAgentStateLogs.Code");
			listAgentStateLogsResponse.HttpStatusCode = _ctx.IntegerValue("ListAgentStateLogs.HttpStatusCode");
			listAgentStateLogsResponse.Message = _ctx.StringValue("ListAgentStateLogs.Message");
			listAgentStateLogsResponse.RequestId = _ctx.StringValue("ListAgentStateLogs.RequestId");

			List<ListAgentStateLogsResponse.ListAgentStateLogs_DataItem> listAgentStateLogsResponse_data = new List<ListAgentStateLogsResponse.ListAgentStateLogs_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAgentStateLogs.Data.Length"); i++) {
				ListAgentStateLogsResponse.ListAgentStateLogs_DataItem dataItem = new ListAgentStateLogsResponse.ListAgentStateLogs_DataItem();
				dataItem.Duration = _ctx.LongValue("ListAgentStateLogs.Data["+ i +"].Duration");
				dataItem.StartTime = _ctx.LongValue("ListAgentStateLogs.Data["+ i +"].StartTime");
				dataItem.State = _ctx.StringValue("ListAgentStateLogs.Data["+ i +"].State");
				dataItem.StateCode = _ctx.StringValue("ListAgentStateLogs.Data["+ i +"].StateCode");

				listAgentStateLogsResponse_data.Add(dataItem);
			}
			listAgentStateLogsResponse.Data = listAgentStateLogsResponse_data;
        
			return listAgentStateLogsResponse;
        }
    }
}
