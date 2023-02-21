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
    public class GetOcOperationPurchaseLandResponseUnmarshaller
    {
        public static GetOcOperationPurchaseLandResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcOperationPurchaseLandResponse getOcOperationPurchaseLandResponse = new GetOcOperationPurchaseLandResponse();

			getOcOperationPurchaseLandResponse.HttpResponse = _ctx.HttpResponse;
			getOcOperationPurchaseLandResponse.Code = _ctx.StringValue("GetOcOperationPurchaseLand.Code");
			getOcOperationPurchaseLandResponse.Success = _ctx.BooleanValue("GetOcOperationPurchaseLand.Success");
			getOcOperationPurchaseLandResponse.Message = _ctx.StringValue("GetOcOperationPurchaseLand.Message");
			getOcOperationPurchaseLandResponse.TotalNum = _ctx.IntegerValue("GetOcOperationPurchaseLand.TotalNum");
			getOcOperationPurchaseLandResponse.PageIndex = _ctx.IntegerValue("GetOcOperationPurchaseLand.PageIndex");
			getOcOperationPurchaseLandResponse.PageNum = _ctx.IntegerValue("GetOcOperationPurchaseLand.PageNum");
			getOcOperationPurchaseLandResponse.RequestId = _ctx.StringValue("GetOcOperationPurchaseLand.RequestId");

			List<GetOcOperationPurchaseLandResponse.GetOcOperationPurchaseLand_DataItem> getOcOperationPurchaseLandResponse_data = new List<GetOcOperationPurchaseLandResponse.GetOcOperationPurchaseLand_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcOperationPurchaseLand.Data.Length"); i++) {
				GetOcOperationPurchaseLandResponse.GetOcOperationPurchaseLand_DataItem dataItem = new GetOcOperationPurchaseLandResponse.GetOcOperationPurchaseLand_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].EntName");
				dataItem.RegionName = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].RegionName");
				dataItem.ElectronicNo = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].ElectronicNo");
				dataItem.ProjectName = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].ProjectName");
				dataItem.Location = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].Location");
				dataItem.Area = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].Area");
				dataItem.ReleaseDate = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].ReleaseDate");
				dataItem.LandSource = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].LandSource");
				dataItem.LandUse = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].LandUse");
				dataItem.LandLevel = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].LandLevel");
				dataItem.SigningMode = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].SigningMode");
				dataItem.UseYear = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].UseYear");
				dataItem.Industry = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].Industry");
				dataItem.PromiseDeliveryDate = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].PromiseDeliveryDate");
				dataItem.PromiseStartDate = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].PromiseStartDate");
				dataItem.PromiseEndDate = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].PromiseEndDate");
				dataItem.Department = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].Department");
				dataItem.Price = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].Price");
				dataItem.VolumeFractionUpperBound = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].VolumeFractionUpperBound");
				dataItem.VolumeFractionLowerBound = _ctx.StringValue("GetOcOperationPurchaseLand.Data["+ i +"].VolumeFractionLowerBound");

				getOcOperationPurchaseLandResponse_data.Add(dataItem);
			}
			getOcOperationPurchaseLandResponse.Data = getOcOperationPurchaseLandResponse_data;
        
			return getOcOperationPurchaseLandResponse;
        }
    }
}
