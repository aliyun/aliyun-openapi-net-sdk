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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class DescribeMPCoSAuthorizedInfoResponseUnmarshaller
    {
        public static DescribeMPCoSAuthorizedInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMPCoSAuthorizedInfoResponse describeMPCoSAuthorizedInfoResponse = new DescribeMPCoSAuthorizedInfoResponse();

			describeMPCoSAuthorizedInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeMPCoSAuthorizedInfoResponse.Code = _ctx.IntegerValue("DescribeMPCoSAuthorizedInfo.Code");
			describeMPCoSAuthorizedInfoResponse.Message = _ctx.StringValue("DescribeMPCoSAuthorizedInfo.Message");
			describeMPCoSAuthorizedInfoResponse.RequestId = _ctx.StringValue("DescribeMPCoSAuthorizedInfo.RequestId");
			describeMPCoSAuthorizedInfoResponse.Success = _ctx.BooleanValue("DescribeMPCoSAuthorizedInfo.Success");

			DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data data = new DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data();

			List<DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_AuthorizedPhase> data_authorizedPhaseList = new List<DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_AuthorizedPhase>();
			for (int i = 0; i < _ctx.Length("DescribeMPCoSAuthorizedInfo.Data.AuthorizedPhaseList.Length"); i++) {
				DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_AuthorizedPhase authorizedPhase = new DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_AuthorizedPhase();
				authorizedPhase.PhaseName = _ctx.StringValue("DescribeMPCoSAuthorizedInfo.Data.AuthorizedPhaseList["+ i +"].PhaseName");
				authorizedPhase.PhaseId = _ctx.StringValue("DescribeMPCoSAuthorizedInfo.Data.AuthorizedPhaseList["+ i +"].PhaseId");

				data_authorizedPhaseList.Add(authorizedPhase);
			}
			data.AuthorizedPhaseList = data_authorizedPhaseList;

			List<DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_UnAuthorizedPhase> data_unAuthorizedPhaseList = new List<DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_UnAuthorizedPhase>();
			for (int i = 0; i < _ctx.Length("DescribeMPCoSAuthorizedInfo.Data.UnAuthorizedPhaseList.Length"); i++) {
				DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_UnAuthorizedPhase unAuthorizedPhase = new DescribeMPCoSAuthorizedInfoResponse.DescribeMPCoSAuthorizedInfo_Data.DescribeMPCoSAuthorizedInfo_UnAuthorizedPhase();
				unAuthorizedPhase.PhaseName = _ctx.StringValue("DescribeMPCoSAuthorizedInfo.Data.UnAuthorizedPhaseList["+ i +"].PhaseName");
				unAuthorizedPhase.PhaseId = _ctx.StringValue("DescribeMPCoSAuthorizedInfo.Data.UnAuthorizedPhaseList["+ i +"].PhaseId");

				data_unAuthorizedPhaseList.Add(unAuthorizedPhase);
			}
			data.UnAuthorizedPhaseList = data_unAuthorizedPhaseList;
			describeMPCoSAuthorizedInfoResponse.Data = data;
        
			return describeMPCoSAuthorizedInfoResponse;
        }
    }
}
