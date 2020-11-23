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
        public static GetStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStatusResponse getStatusResponse = new GetStatusResponse();

			getStatusResponse.HttpResponse = _ctx.HttpResponse;
			getStatusResponse.RequestId = _ctx.StringValue("GetStatus.RequestId");
			getStatusResponse.Success = _ctx.BooleanValue("GetStatus.Success");
			getStatusResponse.Code = _ctx.StringValue("GetStatus.Code");
			getStatusResponse.Message = _ctx.StringValue("GetStatus.Message");

			GetStatusResponse.GetStatus_Data data = new GetStatusResponse.GetStatus_Data();
			data.StatusCode = _ctx.IntegerValue("GetStatus.Data.StatusCode");
			data.TrustedScore = _ctx.FloatValue("GetStatus.Data.TrustedScore");
			data.SimilarityScore = _ctx.FloatValue("GetStatus.Data.SimilarityScore");
			data.AuditConclusions = _ctx.StringValue("GetStatus.Data.AuditConclusions");
			data.AuthorityComparisonScore = _ctx.FloatValue("GetStatus.Data.AuthorityComparisonScore");
			getStatusResponse.Data = data;
        
			return getStatusResponse;
        }
    }
}
