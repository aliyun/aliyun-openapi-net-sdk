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
using Aliyun.Acs.facebody.Model.V20200910;

namespace Aliyun.Acs.facebody.Transform.V20200910
{
    public class DetectIPCPedestrianOptimizedResponseUnmarshaller
    {
        public static DetectIPCPedestrianOptimizedResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectIPCPedestrianOptimizedResponse detectIPCPedestrianOptimizedResponse = new DetectIPCPedestrianOptimizedResponse();

			detectIPCPedestrianOptimizedResponse.HttpResponse = _ctx.HttpResponse;
			detectIPCPedestrianOptimizedResponse.RequestId = _ctx.StringValue("DetectIPCPedestrianOptimized.RequestId");

			DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data data = new DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data();

			List<DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem> data_imageInfoList = new List<DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem>();
			for (int i = 0; i < _ctx.Length("DetectIPCPedestrianOptimized.Data.ImageInfoList.Length"); i++) {
				DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem imageInfoListItem = new DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem();

				List<DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem.DetectIPCPedestrianOptimized_Element> imageInfoListItem_elements = new List<DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem.DetectIPCPedestrianOptimized_Element>();
				for (int j = 0; j < _ctx.Length("DetectIPCPedestrianOptimized.Data.ImageInfoList["+ i +"].Elements.Length"); j++) {
					DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem.DetectIPCPedestrianOptimized_Element element = new DetectIPCPedestrianOptimizedResponse.DetectIPCPedestrianOptimized_Data.DetectIPCPedestrianOptimized_ImageInfoListItem.DetectIPCPedestrianOptimized_Element();
					element.Score = _ctx.FloatValue("DetectIPCPedestrianOptimized.Data.ImageInfoList["+ i +"].Elements["+ j +"].Score");

					List<string> element_boxes = new List<string>();
					for (int k = 0; k < _ctx.Length("DetectIPCPedestrianOptimized.Data.ImageInfoList["+ i +"].Elements["+ j +"].Boxes.Length"); k++) {
						element_boxes.Add(_ctx.StringValue("DetectIPCPedestrianOptimized.Data.ImageInfoList["+ i +"].Elements["+ j +"].Boxes["+ k +"]"));
					}
					element.Boxes = element_boxes;

					imageInfoListItem_elements.Add(element);
				}
				imageInfoListItem.Elements = imageInfoListItem_elements;

				data_imageInfoList.Add(imageInfoListItem);
			}
			data.ImageInfoList = data_imageInfoList;
			detectIPCPedestrianOptimizedResponse.Data = data;
        
			return detectIPCPedestrianOptimizedResponse;
        }
    }
}
