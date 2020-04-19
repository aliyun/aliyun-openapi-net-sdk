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
using Aliyun.Acs.multimediaai.Model.V20190810;

namespace Aliyun.Acs.multimediaai.Transform.V20190810
{
    public class ListFaceImagesResponseUnmarshaller
    {
        public static ListFaceImagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceImagesResponse listFaceImagesResponse = new ListFaceImagesResponse();

			listFaceImagesResponse.HttpResponse = context.HttpResponse;
			listFaceImagesResponse.RequestId = context.StringValue("ListFaceImages.RequestId");
			listFaceImagesResponse.PageNumber = context.IntegerValue("ListFaceImages.PageNumber");
			listFaceImagesResponse.PageSize = context.IntegerValue("ListFaceImages.PageSize");
			listFaceImagesResponse.TotalCount = context.LongValue("ListFaceImages.TotalCount");

			List<ListFaceImagesResponse.ListFaceImages_FaceImage> listFaceImagesResponse_faceImages = new List<ListFaceImagesResponse.ListFaceImages_FaceImage>();
			for (int i = 0; i < context.Length("ListFaceImages.FaceImages.Length"); i++) {
				ListFaceImagesResponse.ListFaceImages_FaceImage faceImage = new ListFaceImagesResponse.ListFaceImages_FaceImage();
				faceImage.FaceImageId = context.LongValue("ListFaceImages.FaceImages["+ i +"].FaceImageId");
				faceImage.ImageUrl = context.StringValue("ListFaceImages.FaceImages["+ i +"].ImageUrl");

				List<string> faceImage_faceRectangle = new List<string>();
				for (int j = 0; j < context.Length("ListFaceImages.FaceImages["+ i +"].FaceRectangle.Length"); j++) {
					faceImage_faceRectangle.Add(context.StringValue("ListFaceImages.FaceImages["+ i +"].FaceRectangle["+ j +"]"));
				}
				faceImage.FaceRectangle = faceImage_faceRectangle;

				listFaceImagesResponse_faceImages.Add(faceImage);
			}
			listFaceImagesResponse.FaceImages = listFaceImagesResponse_faceImages;
        
			return listFaceImagesResponse;
        }
    }
}
