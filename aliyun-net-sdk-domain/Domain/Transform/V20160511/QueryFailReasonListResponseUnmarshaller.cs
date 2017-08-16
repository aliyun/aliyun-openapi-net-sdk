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
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryFailReasonListResponseUnmarshaller
    {
        public static QueryFailReasonListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFailReasonListResponse queryFailReasonListResponse = new QueryFailReasonListResponse();

			queryFailReasonListResponse.HttpResponse = context.HttpResponse;
			queryFailReasonListResponse.RequestId = context.StringValue("QueryFailReasonList.RequestId");

			List<QueryFailReasonListResponse.QueryFailReasonList_FailRecord> queryFailReasonListResponse_data = new List<QueryFailReasonListResponse.QueryFailReasonList_FailRecord>();
			for (int i = 0; i < context.Length("QueryFailReasonList.Data.Length"); i++) {
				QueryFailReasonListResponse.QueryFailReasonList_FailRecord failRecord = new QueryFailReasonListResponse.QueryFailReasonList_FailRecord();
				failRecord.Date = context.StringValue("QueryFailReasonList.Data["+ i +"].Date");
				failRecord.FailReason = context.StringValue("QueryFailReasonList.Data["+ i +"].FailReason");

				queryFailReasonListResponse_data.Add(failRecord);
			}
			queryFailReasonListResponse.Data = queryFailReasonListResponse_data;
        
			return queryFailReasonListResponse;
        }
    }
}