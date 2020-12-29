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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListCustomImagesResponseUnmarshaller
    {
        public static ListCustomImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCustomImagesResponse listCustomImagesResponse = new ListCustomImagesResponse();

			listCustomImagesResponse.HttpResponse = _ctx.HttpResponse;
			listCustomImagesResponse.RequestId = _ctx.StringValue("ListCustomImages.RequestId");

			List<ListCustomImagesResponse.ListCustomImages_ImageInfo> listCustomImagesResponse_images = new List<ListCustomImagesResponse.ListCustomImages_ImageInfo>();
			for (int i = 0; i < _ctx.Length("ListCustomImages.Images.Length"); i++) {
				ListCustomImagesResponse.ListCustomImages_ImageInfo imageInfo = new ListCustomImagesResponse.ListCustomImages_ImageInfo();
				imageInfo.Uid = _ctx.StringValue("ListCustomImages.Images["+ i +"].Uid");
				imageInfo.ImageId = _ctx.StringValue("ListCustomImages.Images["+ i +"].ImageId");
				imageInfo.ImageName = _ctx.StringValue("ListCustomImages.Images["+ i +"].ImageName");
				imageInfo.ImageOwnerAlias = _ctx.StringValue("ListCustomImages.Images["+ i +"].ImageOwnerAlias");
				imageInfo.Description = _ctx.StringValue("ListCustomImages.Images["+ i +"].Description");
				imageInfo.Status = _ctx.StringValue("ListCustomImages.Images["+ i +"].Status");
				imageInfo.ProductCode = _ctx.StringValue("ListCustomImages.Images["+ i +"].ProductCode");
				imageInfo.SkuCode = _ctx.StringValue("ListCustomImages.Images["+ i +"].SkuCode");
				imageInfo.PricingCycle = _ctx.StringValue("ListCustomImages.Images["+ i +"].PricingCycle");
				imageInfo.PostInstallScript = _ctx.StringValue("ListCustomImages.Images["+ i +"].PostInstallScript");
				imageInfo.Size = _ctx.IntegerValue("ListCustomImages.Images["+ i +"].Size");

				ListCustomImagesResponse.ListCustomImages_ImageInfo.ListCustomImages_BaseOsTag baseOsTag = new ListCustomImagesResponse.ListCustomImages_ImageInfo.ListCustomImages_BaseOsTag();
				baseOsTag.OsTag = _ctx.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.OsTag");
				baseOsTag.Platform = _ctx.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.Platform");
				baseOsTag.Version = _ctx.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.Version");
				baseOsTag.Architecture = _ctx.StringValue("ListCustomImages.Images["+ i +"].BaseOsTag.Architecture");
				imageInfo.BaseOsTag = baseOsTag;

				ListCustomImagesResponse.ListCustomImages_ImageInfo.ListCustomImages_OsTag osTag = new ListCustomImagesResponse.ListCustomImages_ImageInfo.ListCustomImages_OsTag();
				osTag.OsTag = _ctx.StringValue("ListCustomImages.Images["+ i +"].OsTag.OsTag");
				osTag.BaseOsTag = _ctx.StringValue("ListCustomImages.Images["+ i +"].OsTag.BaseOsTag");
				osTag.Platform = _ctx.StringValue("ListCustomImages.Images["+ i +"].OsTag.Platform");
				osTag.Version = _ctx.StringValue("ListCustomImages.Images["+ i +"].OsTag.Version");
				osTag.Architecture = _ctx.StringValue("ListCustomImages.Images["+ i +"].OsTag.Architecture");
				imageInfo.OsTag = osTag;

				listCustomImagesResponse_images.Add(imageInfo);
			}
			listCustomImagesResponse.Images = listCustomImagesResponse_images;
        
			return listCustomImagesResponse;
        }
    }
}
