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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class GetCheckDetailResponseUnmarshaller
    {
        public static GetCheckDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCheckDetailResponse getCheckDetailResponse = new GetCheckDetailResponse();

			getCheckDetailResponse.HttpResponse = _ctx.HttpResponse;
			getCheckDetailResponse.RequestId = _ctx.StringValue("GetCheckDetail.RequestId");

			GetCheckDetailResponse.GetCheckDetail_Description description = new GetCheckDetailResponse.GetCheckDetail_Description();
			description.Type = _ctx.StringValue("GetCheckDetail.Description.Type");
			description._Value = _ctx.StringValue("GetCheckDetail.Description.Value");
			description.Link = _ctx.StringValue("GetCheckDetail.Description.Link");
			getCheckDetailResponse.Description = description;

			GetCheckDetailResponse.GetCheckDetail_Solution solution = new GetCheckDetailResponse.GetCheckDetail_Solution();
			solution.Type = _ctx.StringValue("GetCheckDetail.Solution.Type");
			solution._Value = _ctx.StringValue("GetCheckDetail.Solution.Value");
			solution.Link = _ctx.StringValue("GetCheckDetail.Solution.Link");
			getCheckDetailResponse.Solution = solution;

			GetCheckDetailResponse.GetCheckDetail_AssistInfo assistInfo = new GetCheckDetailResponse.GetCheckDetail_AssistInfo();
			assistInfo.Type = _ctx.StringValue("GetCheckDetail.AssistInfo.Type");
			assistInfo._Value = _ctx.StringValue("GetCheckDetail.AssistInfo.Value");
			assistInfo.Link = _ctx.StringValue("GetCheckDetail.AssistInfo.Link");
			getCheckDetailResponse.AssistInfo = assistInfo;
        
			return getCheckDetailResponse;
        }
    }
}
