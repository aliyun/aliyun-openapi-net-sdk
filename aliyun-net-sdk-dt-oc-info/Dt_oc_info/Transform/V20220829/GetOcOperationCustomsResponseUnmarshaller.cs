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
    public class GetOcOperationCustomsResponseUnmarshaller
    {
        public static GetOcOperationCustomsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcOperationCustomsResponse getOcOperationCustomsResponse = new GetOcOperationCustomsResponse();

			getOcOperationCustomsResponse.HttpResponse = _ctx.HttpResponse;
			getOcOperationCustomsResponse.Code = _ctx.StringValue("GetOcOperationCustoms.Code");
			getOcOperationCustomsResponse.Success = _ctx.BooleanValue("GetOcOperationCustoms.Success");
			getOcOperationCustomsResponse.Message = _ctx.StringValue("GetOcOperationCustoms.Message");
			getOcOperationCustomsResponse.TotalNum = _ctx.IntegerValue("GetOcOperationCustoms.TotalNum");
			getOcOperationCustomsResponse.PageIndex = _ctx.IntegerValue("GetOcOperationCustoms.PageIndex");
			getOcOperationCustomsResponse.PageNum = _ctx.IntegerValue("GetOcOperationCustoms.PageNum");
			getOcOperationCustomsResponse.RequestId = _ctx.StringValue("GetOcOperationCustoms.RequestId");

			List<GetOcOperationCustomsResponse.GetOcOperationCustoms_DataItem> getOcOperationCustomsResponse_data = new List<GetOcOperationCustomsResponse.GetOcOperationCustoms_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcOperationCustoms.Data.Length"); i++) {
				GetOcOperationCustomsResponse.GetOcOperationCustoms_DataItem dataItem = new GetOcOperationCustomsResponse.GetOcOperationCustoms_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].EntName");
				dataItem.RegDate = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].RegDate");
				dataItem.CustomsNum = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].CustomsNum");
				dataItem.CustomsReg = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].CustomsReg");
				dataItem.BusinessCate = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].BusinessCate");
				dataItem.AdminRegionName = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].AdminRegionName");
				dataItem.EcoRegionName = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].EcoRegionName");
				dataItem.SpecialArea = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].SpecialArea");
				dataItem.IndustryType = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].IndustryType");
				dataItem.ValidDate = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].ValidDate");
				dataItem.ElectType = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].ElectType");
				dataItem.CancelFlag = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].CancelFlag");
				dataItem.AnnualReport = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].AnnualReport");
				dataItem.CreditLevelsNew = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].CreditLevelsNew");
				dataItem.IdentCode = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].IdentCode");
				dataItem.IdentDate = _ctx.StringValue("GetOcOperationCustoms.Data["+ i +"].IdentDate");

				getOcOperationCustomsResponse_data.Add(dataItem);
			}
			getOcOperationCustomsResponse.Data = getOcOperationCustomsResponse_data;
        
			return getOcOperationCustomsResponse;
        }
    }
}
