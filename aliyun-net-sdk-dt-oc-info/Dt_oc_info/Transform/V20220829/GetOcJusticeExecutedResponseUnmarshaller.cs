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
    public class GetOcJusticeExecutedResponseUnmarshaller
    {
        public static GetOcJusticeExecutedResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeExecutedResponse getOcJusticeExecutedResponse = new GetOcJusticeExecutedResponse();

			getOcJusticeExecutedResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeExecutedResponse.Code = _ctx.StringValue("GetOcJusticeExecuted.Code");
			getOcJusticeExecutedResponse.Success = _ctx.BooleanValue("GetOcJusticeExecuted.Success");
			getOcJusticeExecutedResponse.Message = _ctx.StringValue("GetOcJusticeExecuted.Message");
			getOcJusticeExecutedResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeExecuted.TotalNum");
			getOcJusticeExecutedResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeExecuted.PageIndex");
			getOcJusticeExecutedResponse.PageNum = _ctx.IntegerValue("GetOcJusticeExecuted.PageNum");
			getOcJusticeExecutedResponse.RequestId = _ctx.StringValue("GetOcJusticeExecuted.RequestId");

			List<GetOcJusticeExecutedResponse.GetOcJusticeExecuted_DataItem> getOcJusticeExecutedResponse_data = new List<GetOcJusticeExecutedResponse.GetOcJusticeExecuted_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeExecuted.Data.Length"); i++) {
				GetOcJusticeExecutedResponse.GetOcJusticeExecuted_DataItem dataItem = new GetOcJusticeExecutedResponse.GetOcJusticeExecuted_DataItem();
				dataItem.CaseNum = _ctx.StringValue("GetOcJusticeExecuted.Data["+ i +"].CaseNum");
				dataItem.FilingDate = _ctx.StringValue("GetOcJusticeExecuted.Data["+ i +"].FilingDate");
				dataItem.Court = _ctx.StringValue("GetOcJusticeExecuted.Data["+ i +"].Court");
				dataItem.Amount = _ctx.StringValue("GetOcJusticeExecuted.Data["+ i +"].Amount");

				getOcJusticeExecutedResponse_data.Add(dataItem);
			}
			getOcJusticeExecutedResponse.Data = getOcJusticeExecutedResponse_data;
        
			return getOcJusticeExecutedResponse;
        }
    }
}
