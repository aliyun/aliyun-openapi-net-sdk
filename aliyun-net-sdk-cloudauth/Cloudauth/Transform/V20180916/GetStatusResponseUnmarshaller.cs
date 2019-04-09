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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class GetStatusResponseUnmarshaller
    {
        public static GetStatusResponse Unmarshall(UnmarshallerContext context)
        {
			GetStatusResponse getStatusResponse = new GetStatusResponse();

			getStatusResponse.HttpResponse = context.HttpResponse;
			getStatusResponse.RequestId = context.StringValue("GetStatus.RequestId");
			getStatusResponse.Success = context.BooleanValue("GetStatus.Success");
			getStatusResponse.Code = context.StringValue("GetStatus.Code");
			getStatusResponse.Message = context.StringValue("GetStatus.Message");

			GetStatusResponse.GetStatus_Data data = new GetStatusResponse.GetStatus_Data();
			data.StatusCode = context.IntegerValue("GetStatus.Data.StatusCode");
			data.TrustedScore = context.FloatValue("GetStatus.Data.TrustedScore");
			data.SimilarityScore = context.FloatValue("GetStatus.Data.SimilarityScore");
			data.AuditConclusions = context.StringValue("GetStatus.Data.AuditConclusions");
			data.AuthorityComparisonScore = context.FloatValue("GetStatus.Data.AuthorityComparisonScore");
			getStatusResponse.Data = data;
        
			return getStatusResponse;
        }
    }
}
