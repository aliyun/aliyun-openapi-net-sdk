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
    public class GetOcJusticeLimitHighConsumeResponseUnmarshaller
    {
        public static GetOcJusticeLimitHighConsumeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeLimitHighConsumeResponse getOcJusticeLimitHighConsumeResponse = new GetOcJusticeLimitHighConsumeResponse();

			getOcJusticeLimitHighConsumeResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeLimitHighConsumeResponse.Code = _ctx.StringValue("GetOcJusticeLimitHighConsume.Code");
			getOcJusticeLimitHighConsumeResponse.Success = _ctx.BooleanValue("GetOcJusticeLimitHighConsume.Success");
			getOcJusticeLimitHighConsumeResponse.Message = _ctx.StringValue("GetOcJusticeLimitHighConsume.Message");
			getOcJusticeLimitHighConsumeResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeLimitHighConsume.TotalNum");
			getOcJusticeLimitHighConsumeResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeLimitHighConsume.PageIndex");
			getOcJusticeLimitHighConsumeResponse.PageNum = _ctx.IntegerValue("GetOcJusticeLimitHighConsume.PageNum");
			getOcJusticeLimitHighConsumeResponse.RequestId = _ctx.StringValue("GetOcJusticeLimitHighConsume.RequestId");

			List<GetOcJusticeLimitHighConsumeResponse.GetOcJusticeLimitHighConsume_DataItem> getOcJusticeLimitHighConsumeResponse_data = new List<GetOcJusticeLimitHighConsumeResponse.GetOcJusticeLimitHighConsume_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeLimitHighConsume.Data.Length"); i++) {
				GetOcJusticeLimitHighConsumeResponse.GetOcJusticeLimitHighConsume_DataItem dataItem = new GetOcJusticeLimitHighConsumeResponse.GetOcJusticeLimitHighConsume_DataItem();
				dataItem.Name = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].Name");
				dataItem.CompanyName = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].CompanyName");
				dataItem.FilingDate = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].FilingDate");
				dataItem.CaseNum = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].CaseNum");
				dataItem.Court = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].Court");
				dataItem.ExecutionApplicant = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].ExecutionApplicant");
				dataItem.CauseAction = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].CauseAction");
				dataItem.PublishDate = _ctx.StringValue("GetOcJusticeLimitHighConsume.Data["+ i +"].PublishDate");

				getOcJusticeLimitHighConsumeResponse_data.Add(dataItem);
			}
			getOcJusticeLimitHighConsumeResponse.Data = getOcJusticeLimitHighConsumeResponse_data;
        
			return getOcJusticeLimitHighConsumeResponse;
        }
    }
}
