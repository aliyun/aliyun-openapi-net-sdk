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
using Aliyun.Acs.EHPC.Model.V20170714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20170714
{
    public class ListCustomImagesResponseUnmarshaller
    {
        public static ListCustomImagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListCustomImagesResponse listCustomImagesResponse = new ListCustomImagesResponse();

			listCustomImagesResponse.HttpResponse = context.HttpResponse;
			listCustomImagesResponse.RequestId = context.StringValue("ListCustomImages.RequestId");

			List<ListCustomImagesResponse.ListCustomImages_ImageInfo> listCustomImagesResponse_images = new List<ListCustomImagesResponse.ListCustomImages_ImageInfo>();
			for (int i = 0; i < context.Length("ListCustomImages.Images.Length"); i++) {
				ListCustomImagesResponse.ListCustomImages_ImageInfo imageInfo = new ListCustomImagesResponse.ListCustomImages_ImageInfo();
				imageInfo.ImageId = context.StringValue("ListCustomImages.Images["+ i +"].ImageId");
				imageInfo.ImageName = context.StringValue("ListCustomImages.Images["+ i +"].ImageName");
				imageInfo.ImageOwnerAlias = context.StringValue("ListCustomImages.Images["+ i +"].ImageOwnerAlias");
				imageInfo.Description = context.StringValue("ListCustomImages.Images["+ i +"].Description");

				ListCustomImagesResponse.ListCustomImages_ImageInfo.ListCustomImages_BaseOsTag baseOsTag = new ListCustomImagesResponse.ListCustomImages_ImageInfo.ListCustomImages_BaseOsTag();
				baseOsTag.OsTag = context.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.OsTag");
				baseOsTag.Platform = context.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.Platform");
				baseOsTag.Version = context.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.Version");
				baseOsTag.Architecture = context.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.Architecture");
				imageInfo.BaseOsTag = baseOsTag;

				listCustomImagesResponse_images.Add(imageInfo);
			}
			listCustomImagesResponse.Images = listCustomImagesResponse_images;
        
			return listCustomImagesResponse;
        }
    }
}