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
    public class GetOcJusticeDishonestyResponseUnmarshaller
    {
        public static GetOcJusticeDishonestyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeDishonestyResponse getOcJusticeDishonestyResponse = new GetOcJusticeDishonestyResponse();

			getOcJusticeDishonestyResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeDishonestyResponse.Code = _ctx.StringValue("GetOcJusticeDishonesty.Code");
			getOcJusticeDishonestyResponse.Success = _ctx.BooleanValue("GetOcJusticeDishonesty.Success");
			getOcJusticeDishonestyResponse.Message = _ctx.StringValue("GetOcJusticeDishonesty.Message");
			getOcJusticeDishonestyResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeDishonesty.TotalNum");
			getOcJusticeDishonestyResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeDishonesty.PageIndex");
			getOcJusticeDishonestyResponse.PageNum = _ctx.IntegerValue("GetOcJusticeDishonesty.PageNum");
			getOcJusticeDishonestyResponse.RequestId = _ctx.StringValue("GetOcJusticeDishonesty.RequestId");

			List<GetOcJusticeDishonestyResponse.GetOcJusticeDishonesty_DataItem> getOcJusticeDishonestyResponse_data = new List<GetOcJusticeDishonestyResponse.GetOcJusticeDishonesty_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeDishonesty.Data.Length"); i++) {
				GetOcJusticeDishonestyResponse.GetOcJusticeDishonesty_DataItem dataItem = new GetOcJusticeDishonestyResponse.GetOcJusticeDishonesty_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].EntName");
				dataItem.SocialCreditCode = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].SocialCreditCode");
				dataItem.LegalName = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].LegalName");
				dataItem.Court = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].Court");
				dataItem.Province = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].Province");
				dataItem.FromCaseNum = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].FromCaseNum");
				dataItem.FilingDate = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].FilingDate");
				dataItem.CaseNum = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].CaseNum");
				dataItem.ExecuteDepartment = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].ExecuteDepartment");
				dataItem.FinalDuty = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].FinalDuty");
				dataItem.ExecutionStatus = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].ExecutionStatus");
				dataItem.ExecutionDesc = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].ExecutionDesc");
				dataItem.PublishDate = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].PublishDate");
				dataItem.Amount = _ctx.StringValue("GetOcJusticeDishonesty.Data["+ i +"].Amount");

				getOcJusticeDishonestyResponse_data.Add(dataItem);
			}
			getOcJusticeDishonestyResponse.Data = getOcJusticeDishonestyResponse_data;
        
			return getOcJusticeDishonestyResponse;
        }
    }
}
