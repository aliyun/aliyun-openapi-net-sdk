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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceSearchGroupImagesResponseUnmarshaller
    {
        public static ListFaceSearchGroupImagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceSearchGroupImagesResponse listFaceSearchGroupImagesResponse = new ListFaceSearchGroupImagesResponse();

			listFaceSearchGroupImagesResponse.HttpResponse = context.HttpResponse;
			listFaceSearchGroupImagesResponse.RequestId = context.StringValue("ListFaceSearchGroupImages.RequestId");
			listFaceSearchGroupImagesResponse.NextMarker = context.StringValue("ListFaceSearchGroupImages.NextMarker");
			listFaceSearchGroupImagesResponse.GroupName = context.StringValue("ListFaceSearchGroupImages.GroupName");
			listFaceSearchGroupImagesResponse.GroupId = context.StringValue("ListFaceSearchGroupImages.GroupId");

			List<ListFaceSearchGroupImagesResponse.ListFaceSearchGroupImages_ImagesItem> listFaceSearchGroupImagesResponse_images = new List<ListFaceSearchGroupImagesResponse.ListFaceSearchGroupImages_ImagesItem>();
			for (int i = 0; i < context.Length("ListFaceSearchGroupImages.Images.Length"); i++) {
				ListFaceSearchGroupImagesResponse.ListFaceSearchGroupImages_ImagesItem imagesItem = new ListFaceSearchGroupImagesResponse.ListFaceSearchGroupImages_ImagesItem();
				imagesItem.User = context.StringValue("ListFaceSearchGroupImages.Images["+ i +"].User");
				imagesItem.ImageId = context.StringValue("ListFaceSearchGroupImages.Images["+ i +"].ImageId");
				imagesItem.ImageUrl = context.StringValue("ListFaceSearchGroupImages.Images["+ i +"].ImageUrl");
				imagesItem.ImageMd5 = context.StringValue("ListFaceSearchGroupImages.Images["+ i +"].ImageMd5");
				imagesItem.Roll = context.FloatValue("ListFaceSearchGroupImages.Images["+ i +"].Roll");
				imagesItem.FaceId = context.StringValue("ListFaceSearchGroupImages.Images["+ i +"].FaceId");
				imagesItem.Yaw = context.FloatValue("ListFaceSearchGroupImages.Images["+ i +"].Yaw");
				imagesItem.Quality = context.FloatValue("ListFaceSearchGroupImages.Images["+ i +"].Quality");
				imagesItem.Glasses = context.IntegerValue("ListFaceSearchGroupImages.Images["+ i +"].Glasses");
				imagesItem.Hat = context.IntegerValue("ListFaceSearchGroupImages.Images["+ i +"].Hat");
				imagesItem.Pitch = context.FloatValue("ListFaceSearchGroupImages.Images["+ i +"].Pitch");
				imagesItem.Age = context.IntegerValue("ListFaceSearchGroupImages.Images["+ i +"].Age");
				imagesItem.Gender = context.StringValue("ListFaceSearchGroupImages.Images["+ i +"].Gender");

				List<string> imagesItem_axis = new List<string>();
				for (int j = 0; j < context.Length("ListFaceSearchGroupImages.Images["+ i +"].Axis.Length"); j++) {
					imagesItem_axis.Add(context.StringValue("ListFaceSearchGroupImages.Images["+ i +"].Axis["+ j +"]"));
				}
				imagesItem.Axis = imagesItem_axis;

				listFaceSearchGroupImagesResponse_images.Add(imagesItem);
			}
			listFaceSearchGroupImagesResponse.Images = listFaceSearchGroupImagesResponse_images;
        
			return listFaceSearchGroupImagesResponse;
        }
    }
}