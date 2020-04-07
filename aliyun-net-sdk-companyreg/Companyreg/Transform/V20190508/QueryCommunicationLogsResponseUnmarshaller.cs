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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class QueryCommunicationLogsResponseUnmarshaller
    {
        public static QueryCommunicationLogsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCommunicationLogsResponse queryCommunicationLogsResponse = new QueryCommunicationLogsResponse();

			queryCommunicationLogsResponse.HttpResponse = context.HttpResponse;
			queryCommunicationLogsResponse.RequestId = context.StringValue("QueryCommunicationLogs.RequestId");

			List<QueryCommunicationLogsResponse.QueryCommunicationLogs_TaskList> queryCommunicationLogsResponse_data = new List<QueryCommunicationLogsResponse.QueryCommunicationLogs_TaskList>();
			for (int i = 0; i < context.Length("QueryCommunicationLogs.Data.Length"); i++) {
				QueryCommunicationLogsResponse.QueryCommunicationLogs_TaskList taskList = new QueryCommunicationLogsResponse.QueryCommunicationLogs_TaskList();
				taskList.BizId = context.StringValue("QueryCommunicationLogs.Data["+ i +"].BizId");
				taskList.Note = context.StringValue("QueryCommunicationLogs.Data["+ i +"].Note");
				taskList.PartnerCode = context.StringValue("QueryCommunicationLogs.Data["+ i +"].PartnerCode");
				taskList.UpdateTime = context.LongValue("QueryCommunicationLogs.Data["+ i +"].UpdateTime");
				taskList.CreateTime = context.LongValue("QueryCommunicationLogs.Data["+ i +"].CreateTime");

				queryCommunicationLogsResponse_data.Add(taskList);
			}
			queryCommunicationLogsResponse.Data = queryCommunicationLogsResponse_data;
        
			return queryCommunicationLogsResponse;
        }
    }
}
