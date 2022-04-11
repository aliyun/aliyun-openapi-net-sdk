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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetAuditHistoryResponseUnmarshaller
    {
        public static GetAuditHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAuditHistoryResponse getAuditHistoryResponse = new GetAuditHistoryResponse();

			getAuditHistoryResponse.HttpResponse = _ctx.HttpResponse;
			getAuditHistoryResponse.Status = _ctx.StringValue("GetAuditHistory.Status");
			getAuditHistoryResponse.RequestId = _ctx.StringValue("GetAuditHistory.RequestId");
			getAuditHistoryResponse.Total = _ctx.LongValue("GetAuditHistory.Total");

			List<GetAuditHistoryResponse.GetAuditHistory_History> getAuditHistoryResponse_histories = new List<GetAuditHistoryResponse.GetAuditHistory_History>();
			for (int i = 0; i < _ctx.Length("GetAuditHistory.Histories.Length"); i++) {
				GetAuditHistoryResponse.GetAuditHistory_History history = new GetAuditHistoryResponse.GetAuditHistory_History();
				history.Status = _ctx.StringValue("GetAuditHistory.Histories["+ i +"].Status");
				history.CreationTime = _ctx.StringValue("GetAuditHistory.Histories["+ i +"].CreationTime");
				history.Comment = _ctx.StringValue("GetAuditHistory.Histories["+ i +"].Comment");
				history.Reason = _ctx.StringValue("GetAuditHistory.Histories["+ i +"].Reason");
				history.Auditor = _ctx.StringValue("GetAuditHistory.Histories["+ i +"].Auditor");

				getAuditHistoryResponse_histories.Add(history);
			}
			getAuditHistoryResponse.Histories = getAuditHistoryResponse_histories;
        
			return getAuditHistoryResponse;
        }
    }
}
