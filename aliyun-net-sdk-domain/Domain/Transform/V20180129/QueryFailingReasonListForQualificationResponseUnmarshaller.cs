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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryFailingReasonListForQualificationResponseUnmarshaller
    {
        public static QueryFailingReasonListForQualificationResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFailingReasonListForQualificationResponse queryFailingReasonListForQualificationResponse = new QueryFailingReasonListForQualificationResponse();

			queryFailingReasonListForQualificationResponse.HttpResponse = context.HttpResponse;
			queryFailingReasonListForQualificationResponse.RequestId = context.StringValue("QueryFailingReasonListForQualification.RequestId");

			List<QueryFailingReasonListForQualificationResponse.QueryFailingReasonListForQualification_FailRecord> queryFailingReasonListForQualificationResponse_data = new List<QueryFailingReasonListForQualificationResponse.QueryFailingReasonListForQualification_FailRecord>();
			for (int i = 0; i < context.Length("QueryFailingReasonListForQualification.Data.Length"); i++) {
				QueryFailingReasonListForQualificationResponse.QueryFailingReasonListForQualification_FailRecord failRecord = new QueryFailingReasonListForQualificationResponse.QueryFailingReasonListForQualification_FailRecord();
				failRecord.Date = context.StringValue("QueryFailingReasonListForQualification.Data["+ i +"].Date");
				failRecord.FailReason = context.StringValue("QueryFailingReasonListForQualification.Data["+ i +"].FailReason");

				queryFailingReasonListForQualificationResponse_data.Add(failRecord);
			}
			queryFailingReasonListForQualificationResponse.Data = queryFailingReasonListForQualificationResponse_data;
        
			return queryFailingReasonListForQualificationResponse;
        }
    }
}
