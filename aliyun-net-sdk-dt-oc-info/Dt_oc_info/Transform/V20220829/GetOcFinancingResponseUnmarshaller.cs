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
    public class GetOcFinancingResponseUnmarshaller
    {
        public static GetOcFinancingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcFinancingResponse getOcFinancingResponse = new GetOcFinancingResponse();

			getOcFinancingResponse.HttpResponse = _ctx.HttpResponse;
			getOcFinancingResponse.Code = _ctx.StringValue("GetOcFinancing.Code");
			getOcFinancingResponse.Success = _ctx.BooleanValue("GetOcFinancing.Success");
			getOcFinancingResponse.Message = _ctx.StringValue("GetOcFinancing.Message");
			getOcFinancingResponse.TotalNum = _ctx.IntegerValue("GetOcFinancing.TotalNum");
			getOcFinancingResponse.PageIndex = _ctx.IntegerValue("GetOcFinancing.PageIndex");
			getOcFinancingResponse.PageNum = _ctx.IntegerValue("GetOcFinancing.PageNum");
			getOcFinancingResponse.RequestId = _ctx.StringValue("GetOcFinancing.RequestId");

			List<GetOcFinancingResponse.GetOcFinancing_DataItem> getOcFinancingResponse_data = new List<GetOcFinancingResponse.GetOcFinancing_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcFinancing.Data.Length"); i++) {
				GetOcFinancingResponse.GetOcFinancing_DataItem dataItem = new GetOcFinancingResponse.GetOcFinancing_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcFinancing.Data["+ i +"].EntName");
				dataItem.FinDate = _ctx.StringValue("GetOcFinancing.Data["+ i +"].FinDate");
				dataItem.FinTurn = _ctx.StringValue("GetOcFinancing.Data["+ i +"].FinTurn");
				dataItem.FinAmount = _ctx.StringValue("GetOcFinancing.Data["+ i +"].FinAmount");
				dataItem.Investors = _ctx.StringValue("GetOcFinancing.Data["+ i +"].Investors");

				getOcFinancingResponse_data.Add(dataItem);
			}
			getOcFinancingResponse.Data = getOcFinancingResponse_data;
        
			return getOcFinancingResponse;
        }
    }
}
