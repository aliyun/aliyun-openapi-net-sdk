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
    public class GetOcJusticeJudgementDocResponseUnmarshaller
    {
        public static GetOcJusticeJudgementDocResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeJudgementDocResponse getOcJusticeJudgementDocResponse = new GetOcJusticeJudgementDocResponse();

			getOcJusticeJudgementDocResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeJudgementDocResponse.Code = _ctx.StringValue("GetOcJusticeJudgementDoc.Code");
			getOcJusticeJudgementDocResponse.Success = _ctx.BooleanValue("GetOcJusticeJudgementDoc.Success");
			getOcJusticeJudgementDocResponse.Message = _ctx.StringValue("GetOcJusticeJudgementDoc.Message");
			getOcJusticeJudgementDocResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeJudgementDoc.TotalNum");
			getOcJusticeJudgementDocResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeJudgementDoc.PageIndex");
			getOcJusticeJudgementDocResponse.PageNum = _ctx.IntegerValue("GetOcJusticeJudgementDoc.PageNum");
			getOcJusticeJudgementDocResponse.RequestId = _ctx.StringValue("GetOcJusticeJudgementDoc.RequestId");

			List<GetOcJusticeJudgementDocResponse.GetOcJusticeJudgementDoc_DataItem> getOcJusticeJudgementDocResponse_data = new List<GetOcJusticeJudgementDocResponse.GetOcJusticeJudgementDoc_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeJudgementDoc.Data.Length"); i++) {
				GetOcJusticeJudgementDocResponse.GetOcJusticeJudgementDoc_DataItem dataItem = new GetOcJusticeJudgementDocResponse.GetOcJusticeJudgementDoc_DataItem();
				dataItem.Title = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].Title");
				dataItem.CaseNum = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].CaseNum");
				dataItem.Role = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].Role");
				dataItem.JudgeResult = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].JudgeResult");
				dataItem.JudgeDate = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].JudgeDate");
				dataItem.PublicDate = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].PublicDate");
				dataItem.CauseAction = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].CauseAction");
				dataItem.CaseType = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].CaseType");
				dataItem.Court = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].Court");
				dataItem.SubAmount = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].SubAmount");
				dataItem.CaseFlow = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].CaseFlow");
				dataItem.Party = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].Party");
				dataItem.Plaintiff = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].Plaintiff");
				dataItem.Defendant = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].Defendant");
				dataItem.JudgeType = _ctx.StringValue("GetOcJusticeJudgementDoc.Data["+ i +"].JudgeType");

				getOcJusticeJudgementDocResponse_data.Add(dataItem);
			}
			getOcJusticeJudgementDocResponse.Data = getOcJusticeJudgementDocResponse_data;
        
			return getOcJusticeJudgementDocResponse;
        }
    }
}
