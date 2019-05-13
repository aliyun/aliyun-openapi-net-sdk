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
    public class QueryQualificationDetailResponseUnmarshaller
    {
        public static QueryQualificationDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryQualificationDetailResponse queryQualificationDetailResponse = new QueryQualificationDetailResponse();

			queryQualificationDetailResponse.HttpResponse = context.HttpResponse;
			queryQualificationDetailResponse.TrackId = context.StringValue("QueryQualificationDetail.TrackId");
			queryQualificationDetailResponse.AuditStatus = context.IntegerValue("QueryQualificationDetail.AuditStatus");
			queryQualificationDetailResponse.RequestId = context.StringValue("QueryQualificationDetail.RequestId");

			List<QueryQualificationDetailResponse.QueryQualificationDetail_QualificationCredential> queryQualificationDetailResponse_credentials = new List<QueryQualificationDetailResponse.QueryQualificationDetail_QualificationCredential>();
			for (int i = 0; i < context.Length("QueryQualificationDetail.Credentials.Length"); i++) {
				QueryQualificationDetailResponse.QueryQualificationDetail_QualificationCredential qualificationCredential = new QueryQualificationDetailResponse.QueryQualificationDetail_QualificationCredential();
				qualificationCredential.CredentialNo = context.StringValue("QueryQualificationDetail.Credentials["+ i +"].CredentialNo");
				qualificationCredential.CredentialType = context.StringValue("QueryQualificationDetail.Credentials["+ i +"].CredentialType");
				qualificationCredential.CredentialUrl = context.StringValue("QueryQualificationDetail.Credentials["+ i +"].CredentialUrl");

				queryQualificationDetailResponse_credentials.Add(qualificationCredential);
			}
			queryQualificationDetailResponse.Credentials = queryQualificationDetailResponse_credentials;
        
			return queryQualificationDetailResponse;
        }
    }
}
