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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class ListImagesResponseUnmarshaller
    {
        public static ListImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListImagesResponse listImagesResponse = new ListImagesResponse();

			listImagesResponse.HttpResponse = _ctx.HttpResponse;
			listImagesResponse.RequestId = _ctx.StringValue("ListImages.RequestId");

			List<ListImagesResponse.ListImages_Image> listImagesResponse_images = new List<ListImagesResponse.ListImages_Image>();
			for (int i = 0; i < _ctx.Length("ListImages.Images.Length"); i++) {
				ListImagesResponse.ListImages_Image image = new ListImagesResponse.ListImages_Image();
				image.ImageType = _ctx.StringValue("ListImages.Images["+ i +"].ImageType");
				image.Description = _ctx.StringValue("ListImages.Images["+ i +"].Description");
				image.ImageName = _ctx.StringValue("ListImages.Images["+ i +"].ImageName");
				image.ImageId = _ctx.StringValue("ListImages.Images["+ i +"].ImageId");
				image.Platform = _ctx.StringValue("ListImages.Images["+ i +"].Platform");

				listImagesResponse_images.Add(image);
			}
			listImagesResponse.Images = listImagesResponse_images;
        
			return listImagesResponse;
        }
    }
}
