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
        public static DescribePlanogramPositionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePlanogramPositionsResponse describePlanogramPositionsResponse = new DescribePlanogramPositionsResponse();

			describePlanogramPositionsResponse.HttpResponse = context.HttpResponse;
			describePlanogramPositionsResponse.Code = context.StringValue("DescribePlanogramPositions.Code");
			describePlanogramPositionsResponse.DynamicCode = context.StringValue("DescribePlanogramPositions.DynamicCode");
			describePlanogramPositionsResponse.DynamicMessage = context.StringValue("DescribePlanogramPositions.DynamicMessage");
			describePlanogramPositionsResponse.ErrorCode = context.StringValue("DescribePlanogramPositions.ErrorCode");
			describePlanogramPositionsResponse.ErrorMessage = context.StringValue("DescribePlanogramPositions.ErrorMessage");
			describePlanogramPositionsResponse.Message = context.StringValue("DescribePlanogramPositions.Message");
			describePlanogramPositionsResponse.RequestId = context.StringValue("DescribePlanogramPositions.RequestId");
			describePlanogramPositionsResponse.Shelf = context.StringValue("DescribePlanogramPositions.Shelf");
			describePlanogramPositionsResponse.StoreId = context.StringValue("DescribePlanogramPositions.StoreId");
			describePlanogramPositionsResponse.Success = context.BooleanValue("DescribePlanogramPositions.Success");

			List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo> describePlanogramPositionsResponse_layerInfos = new List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo>();
			for (int i = 0; i < context.Length("DescribePlanogramPositions.LayerInfos.Length"); i++) {
				DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo layerInfo = new DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo();
				layerInfo.Layer = context.IntegerValue("DescribePlanogramPositions.LayerInfos["+ i +"].Layer");
				layerInfo.LayerOrigin = context.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].LayerOrigin");

				List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo> layerInfo_shelfPositionInfos = new List<DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo>();
				for (int j = 0; j < context.Length("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos.Length"); j++) {
					DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo shelfPositionInfo = new DescribePlanogramPositionsResponse.DescribePlanogramPositions_LayerInfo.DescribePlanogramPositions_ShelfPositionInfo();
					shelfPositionInfo.Column = context.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].Column");
					shelfPositionInfo.Depth = context.FloatValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].Depth");
					shelfPositionInfo.Facing = context.IntegerValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].Facing");
					shelfPositionInfo.ItemBarCode = context.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].ItemBarCode");
					shelfPositionInfo.ItemTitle = context.StringValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].ItemTitle");
					shelfPositionInfo.OffsetFrom = context.FloatValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].OffsetFrom");
					shelfPositionInfo.OffsetTo = context.FloatValue("DescribePlanogramPositions.LayerInfos["+ i +"].ShelfPositionInfos["+ j +"].OffsetTo");

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
