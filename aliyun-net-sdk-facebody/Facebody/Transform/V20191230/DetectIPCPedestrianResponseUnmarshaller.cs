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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class DetectIPCPedestrianResponseUnmarshaller
    {
        public static DetectIPCPedestrianResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectIPCPedestrianResponse detectIPCPedestrianResponse = new DetectIPCPedestrianResponse();

			detectIPCPedestrianResponse.HttpResponse = _ctx.HttpResponse;
			detectIPCPedestrianResponse.RequestId = _ctx.StringValue("DetectIPCPedestrian.RequestId");

			DetectIPCPedestrianResponse.DetectIPCPedestrian_Data data = new DetectIPCPedestrianResponse.DetectIPCPedestrian_Data();

			List<DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem> data_imageInfoList = new List<DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem>();
			for (int i = 0; i < _ctx.Length("DetectIPCPedestrian.Data.ImageInfoList.Length"); i++) {
				DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem imageInfoListItem = new DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem();
				imageInfoListItem.ErrorCode = _ctx.StringValue("DetectIPCPedestrian.Data.ImageInfoList["+ i +"].ErrorCode");
				imageInfoListItem.ErrorMessage = _ctx.StringValue("DetectIPCPedestrian.Data.ImageInfoList["+ i +"].ErrorMessage");
				imageInfoListItem.DataId = _ctx.StringValue("DetectIPCPedestrian.Data.ImageInfoList["+ i +"].DataId");

				List<DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem.DetectIPCPedestrian_Element> imageInfoListItem_elements = new List<DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem.DetectIPCPedestrian_Element>();
				for (int j = 0; j < _ctx.Length("DetectIPCPedestrian.Data.ImageInfoList["+ i +"].Elements.Length"); j++) {
					DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem.DetectIPCPedestrian_Element element = new DetectIPCPedestrianResponse.DetectIPCPedestrian_Data.DetectIPCPedestrian_ImageInfoListItem.DetectIPCPedestrian_Element();
					element.Score = _ctx.FloatValue("DetectIPCPedestrian.Data.ImageInfoList["+ i +"].Elements["+ j +"].Score");

					List<string> element_boxes = new List<string>();
					for (int k = 0; k < _ctx.Length("DetectIPCPedestrian.Data.ImageInfoList["+ i +"].Elements["+ j +"].Boxes.Length"); k++) {
						element_boxes.Add(_ctx.StringValue("DetectIPCPedestrian.Data.ImageInfoList["+ i +"].Elements["+ j +"].Boxes["+ k +"]"));
					}
					element.Boxes = element_boxes;

					imageInfoListItem_elements.Add(element);
				}
				imageInfoListItem.Elements = imageInfoListItem_elements;

				data_imageInfoList.Add(imageInfoListItem);
			}
			data.ImageInfoList = data_imageInfoList;
			detectIPCPedestrianResponse.Data = data;
        
			return detectIPCPedestrianResponse;
        }
    }
}
