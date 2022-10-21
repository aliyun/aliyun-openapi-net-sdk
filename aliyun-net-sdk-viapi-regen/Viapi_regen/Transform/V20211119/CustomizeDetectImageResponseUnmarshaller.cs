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
    public class CustomizeDetectImageResponseUnmarshaller
    {
        public static CustomizeDetectImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CustomizeDetectImageResponse customizeDetectImageResponse = new CustomizeDetectImageResponse();

			customizeDetectImageResponse.HttpResponse = _ctx.HttpResponse;
			customizeDetectImageResponse.RequestId = _ctx.StringValue("CustomizeDetectImage.RequestId");
			customizeDetectImageResponse.Code = _ctx.StringValue("CustomizeDetectImage.Code");
			customizeDetectImageResponse.Message = _ctx.StringValue("CustomizeDetectImage.Message");

			CustomizeDetectImageResponse.CustomizeDetectImage_Data data = new CustomizeDetectImageResponse.CustomizeDetectImage_Data();

			List<CustomizeDetectImageResponse.CustomizeDetectImage_Data.CustomizeDetectImage_ElementsItem> data_elements = new List<CustomizeDetectImageResponse.CustomizeDetectImage_Data.CustomizeDetectImage_ElementsItem>();
			for (int i = 0; i < _ctx.Length("CustomizeDetectImage.Data.Elements.Length"); i++) {
				CustomizeDetectImageResponse.CustomizeDetectImage_Data.CustomizeDetectImage_ElementsItem elementsItem = new CustomizeDetectImageResponse.CustomizeDetectImage_Data.CustomizeDetectImage_ElementsItem();
				elementsItem.Score = _ctx.FloatValue("CustomizeDetectImage.Data.Elements["+ i +"].Score");
				elementsItem.Category = _ctx.StringValue("CustomizeDetectImage.Data.Elements["+ i +"].Category");

				CustomizeDetectImageResponse.CustomizeDetectImage_Data.CustomizeDetectImage_ElementsItem.CustomizeDetectImage_Boxes boxes = new CustomizeDetectImageResponse.CustomizeDetectImage_Data.CustomizeDetectImage_ElementsItem.CustomizeDetectImage_Boxes();
				boxes.X = _ctx.FloatValue("CustomizeDetectImage.Data.Elements["+ i +"].Boxes.X");
				boxes.Y = _ctx.FloatValue("CustomizeDetectImage.Data.Elements["+ i +"].Boxes.Y");
				boxes.Width = _ctx.FloatValue("CustomizeDetectImage.Data.Elements["+ i +"].Boxes.Width");
				boxes.Height = _ctx.FloatValue("CustomizeDetectImage.Data.Elements["+ i +"].Boxes.Height");
				elementsItem.Boxes = boxes;

				data_elements.Add(elementsItem);
			}
			data.Elements = data_elements;
			customizeDetectImageResponse.Data = data;
        
			return customizeDetectImageResponse;
        }
    }
}
