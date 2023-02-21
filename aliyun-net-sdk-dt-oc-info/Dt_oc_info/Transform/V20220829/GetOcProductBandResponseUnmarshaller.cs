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
    public class GetOcProductBandResponseUnmarshaller
    {
        public static GetOcProductBandResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcProductBandResponse getOcProductBandResponse = new GetOcProductBandResponse();

			getOcProductBandResponse.HttpResponse = _ctx.HttpResponse;
			getOcProductBandResponse.Code = _ctx.StringValue("GetOcProductBand.Code");
			getOcProductBandResponse.Success = _ctx.BooleanValue("GetOcProductBand.Success");
			getOcProductBandResponse.Message = _ctx.StringValue("GetOcProductBand.Message");
			getOcProductBandResponse.TotalNum = _ctx.IntegerValue("GetOcProductBand.TotalNum");
			getOcProductBandResponse.PageIndex = _ctx.IntegerValue("GetOcProductBand.PageIndex");
			getOcProductBandResponse.PageNum = _ctx.IntegerValue("GetOcProductBand.PageNum");
			getOcProductBandResponse.RequestId = _ctx.StringValue("GetOcProductBand.RequestId");

			List<GetOcProductBandResponse.GetOcProductBand_DataItem> getOcProductBandResponse_data = new List<GetOcProductBandResponse.GetOcProductBand_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcProductBand.Data.Length"); i++) {
				GetOcProductBandResponse.GetOcProductBand_DataItem dataItem = new GetOcProductBandResponse.GetOcProductBand_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcProductBand.Data["+ i +"].EntName");
				dataItem.ProductName = _ctx.StringValue("GetOcProductBand.Data["+ i +"].ProductName");
				dataItem.ProductLogo = _ctx.StringValue("GetOcProductBand.Data["+ i +"].ProductLogo");
				dataItem.ProductIntroduction = _ctx.StringValue("GetOcProductBand.Data["+ i +"].ProductIntroduction");
				dataItem.BrandIntroduction = _ctx.StringValue("GetOcProductBand.Data["+ i +"].BrandIntroduction");
				dataItem.ProductWebsite = _ctx.StringValue("GetOcProductBand.Data["+ i +"].ProductWebsite");
				dataItem.ProductTag = _ctx.StringValue("GetOcProductBand.Data["+ i +"].ProductTag");
				dataItem.Device = _ctx.StringValue("GetOcProductBand.Data["+ i +"].Device");

				getOcProductBandResponse_data.Add(dataItem);
			}
			getOcProductBandResponse.Data = getOcProductBandResponse_data;
        
			return getOcProductBandResponse;
        }
    }
}
