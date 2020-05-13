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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class ListDevicesImagesResponseUnmarshaller
    {
        public static ListDevicesImagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListDevicesImagesResponse listDevicesImagesResponse = new ListDevicesImagesResponse();

			listDevicesImagesResponse.HttpResponse = context.HttpResponse;
			listDevicesImagesResponse.ErrorCode = context.StringValue("ListDevicesImages.ErrorCode");
			listDevicesImagesResponse.ErrorMessage = context.StringValue("ListDevicesImages.ErrorMessage");
			listDevicesImagesResponse.Message = context.StringValue("ListDevicesImages.Message");
			listDevicesImagesResponse.Code = context.StringValue("ListDevicesImages.Code");
			listDevicesImagesResponse.DynamicCode = context.StringValue("ListDevicesImages.DynamicCode");
			listDevicesImagesResponse.RequestId = context.StringValue("ListDevicesImages.RequestId");
			listDevicesImagesResponse.Success = context.BooleanValue("ListDevicesImages.Success");
			listDevicesImagesResponse.DynamicMessage = context.StringValue("ListDevicesImages.DynamicMessage");

			List<ListDevicesImagesResponse.ListDevicesImages_DeviceImage> listDevicesImagesResponse_deviceImages = new List<ListDevicesImagesResponse.ListDevicesImages_DeviceImage>();
			for (int i = 0; i < context.Length("ListDevicesImages.DeviceImages.Length"); i++) {
				ListDevicesImagesResponse.ListDevicesImages_DeviceImage deviceImage = new ListDevicesImagesResponse.ListDevicesImages_DeviceImage();
				deviceImage.IpcId = context.LongValue("ListDevicesImages.DeviceImages["+ i +"].IpcId");
				deviceImage.ImageUrl = context.StringValue("ListDevicesImages.DeviceImages["+ i +"].ImageUrl");

				listDevicesImagesResponse_deviceImages.Add(deviceImage);
			}
			listDevicesImagesResponse.DeviceImages = listDevicesImagesResponse_deviceImages;
        
			return listDevicesImagesResponse;
        }
    }
}
