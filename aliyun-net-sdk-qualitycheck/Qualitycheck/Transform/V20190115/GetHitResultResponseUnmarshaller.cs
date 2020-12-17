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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetHitResultResponseUnmarshaller
    {
        public static GetHitResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHitResultResponse getHitResultResponse = new GetHitResultResponse();

			getHitResultResponse.HttpResponse = _ctx.HttpResponse;
			getHitResultResponse.RequestId = _ctx.StringValue("GetHitResult.RequestId");
			getHitResultResponse.Success = _ctx.BooleanValue("GetHitResult.Success");
			getHitResultResponse.Code = _ctx.StringValue("GetHitResult.Code");
			getHitResultResponse.Message = _ctx.StringValue("GetHitResult.Message");
			getHitResultResponse.Count = _ctx.IntegerValue("GetHitResult.Count");
			getHitResultResponse.PageSize = _ctx.IntegerValue("GetHitResult.PageSize");
			getHitResultResponse.PageNumber = _ctx.IntegerValue("GetHitResult.PageNumber");

			List<GetHitResultResponse.GetHitResult_ResultInfo> getHitResultResponse_data = new List<GetHitResultResponse.GetHitResult_ResultInfo>();
			for (int i = 0; i < _ctx.Length("GetHitResult.Data.Length"); i++) {
				GetHitResultResponse.GetHitResult_ResultInfo resultInfo = new GetHitResultResponse.GetHitResult_ResultInfo();
				resultInfo.Rid = _ctx.LongValue("GetHitResult.Data["+ i +"].Rid");
				resultInfo.RuleName = _ctx.StringValue("GetHitResult.Data["+ i +"].RuleName");

				getHitResultResponse_data.Add(resultInfo);
			}
			getHitResultResponse.Data = getHitResultResponse_data;
        
			return getHitResultResponse;
        }
    }
}
