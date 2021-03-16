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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class ListDevicesImagesResponseUnmarshaller
    {
        public static ListDevicesImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevicesImagesResponse listDevicesImagesResponse = new ListDevicesImagesResponse();

			listDevicesImagesResponse.HttpResponse = _ctx.HttpResponse;
			listDevicesImagesResponse.ErrorCode = _ctx.StringValue("ListDevicesImages.ErrorCode");
			listDevicesImagesResponse.ErrorMessage = _ctx.StringValue("ListDevicesImages.ErrorMessage");
			listDevicesImagesResponse.Message = _ctx.StringValue("ListDevicesImages.Message");
			listDevicesImagesResponse.Code = _ctx.StringValue("ListDevicesImages.Code");
			listDevicesImagesResponse.DynamicCode = _ctx.StringValue("ListDevicesImages.DynamicCode");
			listDevicesImagesResponse.RequestId = _ctx.StringValue("ListDevicesImages.RequestId");
			listDevicesImagesResponse.Success = _ctx.BooleanValue("ListDevicesImages.Success");
			listDevicesImagesResponse.DynamicMessage = _ctx.StringValue("ListDevicesImages.DynamicMessage");

			List<ListDevicesImagesResponse.ListDevicesImages_DeviceImage> listDevicesImagesResponse_deviceImages = new List<ListDevicesImagesResponse.ListDevicesImages_DeviceImage>();
			for (int i = 0; i < _ctx.Length("ListDevicesImages.DeviceImages.Length"); i++) {
				ListDevicesImagesResponse.ListDevicesImages_DeviceImage deviceImage = new ListDevicesImagesResponse.ListDevicesImages_DeviceImage();
				deviceImage.IpcId = _ctx.LongValue("ListDevicesImages.DeviceImages["+ i +"].IpcId");
				deviceImage.ImageUrl = _ctx.StringValue("ListDevicesImages.DeviceImages["+ i +"].ImageUrl");

				listDevicesImagesResponse_deviceImages.Add(deviceImage);
			}
			listDevicesImagesResponse.DeviceImages = listDevicesImagesResponse_deviceImages;
        
			return listDevicesImagesResponse;
        }
    }
}
