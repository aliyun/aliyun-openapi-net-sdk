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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribePlanogramShelvesResponseUnmarshaller
    {
        public static DescribePlanogramShelvesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlanogramShelvesResponse describePlanogramShelvesResponse = new DescribePlanogramShelvesResponse();

			describePlanogramShelvesResponse.HttpResponse = _ctx.HttpResponse;
			describePlanogramShelvesResponse.Code = _ctx.StringValue("DescribePlanogramShelves.Code");
			describePlanogramShelvesResponse.DynamicCode = _ctx.StringValue("DescribePlanogramShelves.DynamicCode");
			describePlanogramShelvesResponse.DynamicMessage = _ctx.StringValue("DescribePlanogramShelves.DynamicMessage");
			describePlanogramShelvesResponse.ErrorCode = _ctx.StringValue("DescribePlanogramShelves.ErrorCode");
			describePlanogramShelvesResponse.ErrorMessage = _ctx.StringValue("DescribePlanogramShelves.ErrorMessage");
			describePlanogramShelvesResponse.Message = _ctx.StringValue("DescribePlanogramShelves.Message");
			describePlanogramShelvesResponse.RequestId = _ctx.StringValue("DescribePlanogramShelves.RequestId");
			describePlanogramShelvesResponse.StoreId = _ctx.StringValue("DescribePlanogramShelves.StoreId");
			describePlanogramShelvesResponse.Success = _ctx.BooleanValue("DescribePlanogramShelves.Success");
			describePlanogramShelvesResponse.PageNumber = _ctx.IntegerValue("DescribePlanogramShelves.PageNumber");
			describePlanogramShelvesResponse.PageSize = _ctx.IntegerValue("DescribePlanogramShelves.PageSize");
			describePlanogramShelvesResponse.TotalCount = _ctx.IntegerValue("DescribePlanogramShelves.TotalCount");

			List<DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo> describePlanogramShelvesResponse_shelfInfos = new List<DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo>();
			for (int i = 0; i < _ctx.Length("DescribePlanogramShelves.ShelfInfos.Length"); i++) {
				DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo shelfInfo = new DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo();
				shelfInfo.Shelf = _ctx.StringValue("DescribePlanogramShelves.ShelfInfos["+ i +"].Shelf");
				shelfInfo.BeMatch = _ctx.BooleanValue("DescribePlanogramShelves.ShelfInfos["+ i +"].BeMatch");
				shelfInfo.Zone = _ctx.StringValue("DescribePlanogramShelves.ShelfInfos["+ i +"].Zone");
				shelfInfo.Category = _ctx.StringValue("DescribePlanogramShelves.ShelfInfos["+ i +"].Category");
				shelfInfo.ShelfType = _ctx.StringValue("DescribePlanogramShelves.ShelfInfos["+ i +"].ShelfType");

				List<DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo.DescribePlanogramShelves_LayerInfo> shelfInfo_layerInfos = new List<DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo.DescribePlanogramShelves_LayerInfo>();
				for (int j = 0; j < _ctx.Length("DescribePlanogramShelves.ShelfInfos["+ i +"].LayerInfos.Length"); j++) {
					DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo.DescribePlanogramShelves_LayerInfo layerInfo = new DescribePlanogramShelvesResponse.DescribePlanogramShelves_ShelfInfo.DescribePlanogramShelves_LayerInfo();
					layerInfo.Layer = _ctx.IntegerValue("DescribePlanogramShelves.ShelfInfos["+ i +"].LayerInfos["+ j +"].Layer");

					shelfInfo_layerInfos.Add(layerInfo);
				}
				shelfInfo.LayerInfos = shelfInfo_layerInfos;

				describePlanogramShelvesResponse_shelfInfos.Add(shelfInfo);
			}
			describePlanogramShelvesResponse.ShelfInfos = describePlanogramShelvesResponse_shelfInfos;
        
			return describePlanogramShelvesResponse;
        }
    }
}
