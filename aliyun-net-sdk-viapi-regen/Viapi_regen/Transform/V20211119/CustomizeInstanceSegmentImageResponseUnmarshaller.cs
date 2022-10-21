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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class CustomizeInstanceSegmentImageResponseUnmarshaller
    {
        public static CustomizeInstanceSegmentImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CustomizeInstanceSegmentImageResponse customizeInstanceSegmentImageResponse = new CustomizeInstanceSegmentImageResponse();

			customizeInstanceSegmentImageResponse.HttpResponse = _ctx.HttpResponse;
			customizeInstanceSegmentImageResponse.RequestId = _ctx.StringValue("CustomizeInstanceSegmentImage.RequestId");
			customizeInstanceSegmentImageResponse.Code = _ctx.StringValue("CustomizeInstanceSegmentImage.Code");
			customizeInstanceSegmentImageResponse.Message = _ctx.StringValue("CustomizeInstanceSegmentImage.Message");

			CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data data = new CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data();

			List<CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem> data_elements = new List<CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem>();
			for (int i = 0; i < _ctx.Length("CustomizeInstanceSegmentImage.Data.Elements.Length"); i++) {
				CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem elementsItem = new CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem();
				elementsItem.Score = _ctx.FloatValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Score");
				elementsItem.Category = _ctx.StringValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Category");

				CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_Boxes boxes = new CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_Boxes();
				boxes.X = _ctx.IntegerValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Boxes.X");
				boxes.Y = _ctx.IntegerValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Boxes.Y");
				boxes.Width = _ctx.IntegerValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Boxes.Width");
				boxes.Height = _ctx.IntegerValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Boxes.Height");
				elementsItem.Boxes = boxes;

				CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_Mask mask = new CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_Mask();
				mask.Counts = _ctx.StringValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Mask.Counts");

				List<string> mask_sizes = new List<string>();
				for (int j = 0; j < _ctx.Length("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Mask.Sizes.Length"); j++) {
					mask_sizes.Add(_ctx.StringValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Mask.Sizes["+ j +"]"));
				}
				mask.Sizes = mask_sizes;
				elementsItem.Mask = mask;

				List<CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_ContoursItem> elementsItem_contours = new List<CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_ContoursItem>();
				for (int j = 0; j < _ctx.Length("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Contours.Length"); j++) {
					CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_ContoursItem contoursItem = new CustomizeInstanceSegmentImageResponse.CustomizeInstanceSegmentImage_Data.CustomizeInstanceSegmentImage_ElementsItem.CustomizeInstanceSegmentImage_ContoursItem();
					contoursItem.X = _ctx.IntegerValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Contours["+ j +"].X");
					contoursItem.Y = _ctx.IntegerValue("CustomizeInstanceSegmentImage.Data.Elements["+ i +"].Contours["+ j +"].Y");

					elementsItem_contours.Add(contoursItem);
				}
				elementsItem.Contours = elementsItem_contours;

				data_elements.Add(elementsItem);
			}
			data.Elements = data_elements;
			customizeInstanceSegmentImageResponse.Data = data;
        
			return customizeInstanceSegmentImageResponse;
        }
    }
}
