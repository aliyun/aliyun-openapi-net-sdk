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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class GetAlgorithmDetailResponseUnmarshaller
    {
        public static GetAlgorithmDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAlgorithmDetailResponse getAlgorithmDetailResponse = new GetAlgorithmDetailResponse();

			getAlgorithmDetailResponse.HttpResponse = _ctx.HttpResponse;
			getAlgorithmDetailResponse.Message = _ctx.StringValue("GetAlgorithmDetail.Message");
			getAlgorithmDetailResponse.RequestId = _ctx.StringValue("GetAlgorithmDetail.RequestId");
			getAlgorithmDetailResponse.Code = _ctx.StringValue("GetAlgorithmDetail.Code");
			getAlgorithmDetailResponse.Success = _ctx.BooleanValue("GetAlgorithmDetail.Success");

			GetAlgorithmDetailResponse.GetAlgorithmDetail_Data data = new GetAlgorithmDetailResponse.GetAlgorithmDetail_Data();
			data.AlgorithmName = _ctx.StringValue("GetAlgorithmDetail.Data.AlgorithmName");
			data.DeployRegion = _ctx.StringValue("GetAlgorithmDetail.Data.DeployRegion");
			data.CurrentMonthCount = _ctx.IntegerValue("GetAlgorithmDetail.Data.CurrentMonthCount");
			data.AlgorithmCode = _ctx.StringValue("GetAlgorithmDetail.Data.AlgorithmCode");
			data.ApiDocUrl = _ctx.StringValue("GetAlgorithmDetail.Data.ApiDocUrl");
			data.CurrentMonthSuccessCount = _ctx.IntegerValue("GetAlgorithmDetail.Data.CurrentMonthSuccessCount");
			getAlgorithmDetailResponse.Data = data;
        
			return getAlgorithmDetailResponse;
        }
    }
}
