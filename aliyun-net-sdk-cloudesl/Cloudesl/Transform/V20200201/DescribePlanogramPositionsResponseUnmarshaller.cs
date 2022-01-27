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
    public class DescribePlanogramPositionsResponseUnmarshaller
    {
        public static DescribePlanogramPositionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlanogramPositionsResponse describePlanogramPositionsResponse = new DescribePlanogramPositionsResponse();

			describePlanogramPositionsResponse.HttpResponse = _ctx.HttpResponse;
			describePlanogramPositionsResponse.Code = _ctx.StringValue("DescribePlanogramPositions.Code");
			describePlanogramPositionsResponse.DynamicCode = _ctx.StringValue("DescribePlanogramPositions.DynamicCode");
			describePlanogramPositionsResponse.DynamicMessage = _ctx.StringValue("DescribePlanogramPositions.DynamicMessage");
			describePlanogramPositionsResponse.ErrorCode = _ctx.StringValue("DescribePlanogramPositions.ErrorCode");
			describePlanogramPositionsResponse.ErrorMessage = _ctx.StringValue("DescribePlanogramPositions.ErrorMessage");
			describePlanogramPositionsResponse.Message = _ctx.StringValue("DescribePlanogramPositions.Message");
			describePlanogramPositionsResponse.RequestId = _ctx.StringValue("DescribePlanogramPositions.RequestId");
			describePlanogramPositionsResponse.Shelf = _ctx.StringValue("DescribePlanogramPositions.Shelf");
			describePlanogramPositionsResponse.StoreId = _ctx.StringValue("DescribePlanogramPositions.StoreId");
			describePlanogramPositionsResponse.Success = _ctx.BooleanValue("DescribePlanogramPositions.Success");
			describePlanogramPositionsResponse.ShelfType = _ctx.StringValue("DescribePlanogramPositions.ShelfType");

			List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo> describePlanogramPositionsResponse_layerInfos = new List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo>();
			for (int i = 0; i < _ctx.Length("DescribePlanogramPositions.LayerInfos.Length"); i++) {
				DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo layerInfo = new DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo();
				layerInfo.Layer = _ctx.IntegerValue("DescribePlanogramPositions.LayerInfos["+ i +"].Layer");
				layerInfo.LayerOrigin = _ctx.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].LayerOrigin");
				layerInfo.RailCode = _ctx.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].RailCode");

				List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo> layerInfo_shelfPositionInfos = new List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo>();
				for (int j = 0; j < _ctx.Length("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos.Length"); j++) {
					DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo shelfPositionInfo = new DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo();
					shelfPositionInfo.Column = _ctx.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].Column");
					shelfPositionInfo.Depth = _ctx.FloatValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].Depth");
					shelfPositionInfo.Facing = _ctx.IntegerValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].Facing");
					shelfPositionInfo.ItemBarCode = _ctx.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].ItemBarCode");
					shelfPositionInfo.ItemTitle = _ctx.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].ItemTitle");
					shelfPositionInfo.OffsetFrom = _ctx.FloatValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].OffsetFrom");
					shelfPositionInfo.OffsetTo = _ctx.FloatValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].OffsetTo");

					layerInfo_shelfPositionInfos.Add(shelfPositionInfo);
				}
				layerInfo.ShelfPositionInfos = layerInfo_shelfPositionInfos;

				describePlanogramPositionsResponse_layerInfos.Add(layerInfo);
			}
			describePlanogramPositionsResponse.LayerInfos = describePlanogramPositionsResponse_layerInfos;
        
			return describePlanogramPositionsResponse;
        }
    }
}
