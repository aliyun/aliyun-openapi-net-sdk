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
    public class GetOcIcShareholderResponseUnmarshaller
    {
        public static GetOcIcShareholderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcShareholderResponse getOcIcShareholderResponse = new GetOcIcShareholderResponse();

			getOcIcShareholderResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcShareholderResponse.Code = _ctx.StringValue("GetOcIcShareholder.Code");
			getOcIcShareholderResponse.Success = _ctx.BooleanValue("GetOcIcShareholder.Success");
			getOcIcShareholderResponse.Message = _ctx.StringValue("GetOcIcShareholder.Message");
			getOcIcShareholderResponse.TotalNum = _ctx.IntegerValue("GetOcIcShareholder.TotalNum");
			getOcIcShareholderResponse.PageIndex = _ctx.IntegerValue("GetOcIcShareholder.PageIndex");
			getOcIcShareholderResponse.PageNum = _ctx.IntegerValue("GetOcIcShareholder.PageNum");
			getOcIcShareholderResponse.RequestId = _ctx.StringValue("GetOcIcShareholder.RequestId");

			List<GetOcIcShareholderResponse.GetOcIcShareholder_DataItem> getOcIcShareholderResponse_data = new List<GetOcIcShareholderResponse.GetOcIcShareholder_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcShareholder.Data.Length"); i++) {
				GetOcIcShareholderResponse.GetOcIcShareholder_DataItem dataItem = new GetOcIcShareholderResponse.GetOcIcShareholder_DataItem();
				dataItem.StockName = _ctx.StringValue("GetOcIcShareholder.Data["+ i +"].StockName");
				dataItem.StockType = _ctx.StringValue("GetOcIcShareholder.Data["+ i +"].StockType");
				dataItem.StockPercent = _ctx.StringValue("GetOcIcShareholder.Data["+ i +"].StockPercent");
				dataItem.ShouldCap = _ctx.StringValue("GetOcIcShareholder.Data["+ i +"].ShouldCap");
				dataItem.ShouldCapTime = _ctx.StringValue("GetOcIcShareholder.Data["+ i +"].ShouldCapTime");

				getOcIcShareholderResponse_data.Add(dataItem);
			}
			getOcIcShareholderResponse.Data = getOcIcShareholderResponse_data;
        
			return getOcIcShareholderResponse;
        }
    }
}
