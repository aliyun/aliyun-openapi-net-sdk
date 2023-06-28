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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcJusticeCaseFilingResponseUnmarshaller
    {
        public static GetOcJusticeCaseFilingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeCaseFilingResponse getOcJusticeCaseFilingResponse = new GetOcJusticeCaseFilingResponse();

			getOcJusticeCaseFilingResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeCaseFilingResponse.Code = _ctx.StringValue("GetOcJusticeCaseFiling.Code");
			getOcJusticeCaseFilingResponse.Success = _ctx.BooleanValue("GetOcJusticeCaseFiling.Success");
			getOcJusticeCaseFilingResponse.Message = _ctx.StringValue("GetOcJusticeCaseFiling.Message");
			getOcJusticeCaseFilingResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeCaseFiling.TotalNum");
			getOcJusticeCaseFilingResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeCaseFiling.PageIndex");
			getOcJusticeCaseFilingResponse.PageNum = _ctx.IntegerValue("GetOcJusticeCaseFiling.PageNum");
			getOcJusticeCaseFilingResponse.RequestId = _ctx.StringValue("GetOcJusticeCaseFiling.RequestId");

			List<GetOcJusticeCaseFilingResponse.GetOcJusticeCaseFiling_DataItem> getOcJusticeCaseFilingResponse_data = new List<GetOcJusticeCaseFilingResponse.GetOcJusticeCaseFiling_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeCaseFiling.Data.Length"); i++) {
				GetOcJusticeCaseFilingResponse.GetOcJusticeCaseFiling_DataItem dataItem = new GetOcJusticeCaseFilingResponse.GetOcJusticeCaseFiling_DataItem();
				dataItem.CaseNum = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].CaseNum");
				dataItem.Judge = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].Judge");
				dataItem.Assistant = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].Assistant");
				dataItem.FilingDate = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].FilingDate");
				dataItem.HearingDate = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].HearingDate");
				dataItem.EndDate = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].EndDate");
				dataItem.CaseStatus = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].CaseStatus");
				dataItem.Role = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].Role");
				dataItem.Party = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].Party");
				dataItem.CauseAction = _ctx.StringValue("GetOcJusticeCaseFiling.Data["+ i +"].CauseAction");

				getOcJusticeCaseFilingResponse_data.Add(dataItem);
			}
			getOcJusticeCaseFilingResponse.Data = getOcJusticeCaseFilingResponse_data;
        
			return getOcJusticeCaseFilingResponse;
        }
    }
}
