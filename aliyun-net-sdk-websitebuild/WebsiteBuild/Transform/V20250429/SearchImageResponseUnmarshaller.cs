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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class SearchImageResponseUnmarshaller
    {
        public static SearchImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchImageResponse searchImageResponse = new SearchImageResponse();

			searchImageResponse.HttpResponse = _ctx.HttpResponse;
			searchImageResponse.RequestId = _ctx.StringValue("SearchImage.RequestId");
			searchImageResponse.ErrorMsg = _ctx.StringValue("SearchImage.ErrorMsg");
			searchImageResponse.Success = _ctx.StringValue("SearchImage.Success");
			searchImageResponse.ErrorCode = _ctx.StringValue("SearchImage.ErrorCode");

			SearchImageResponse.SearchImage_ImageResponse imageResponse = new SearchImageResponse.SearchImage_ImageResponse();
			imageResponse.MaxResults = _ctx.IntegerValue("SearchImage.ImageResponse.MaxResults");
			imageResponse.NextToken = _ctx.StringValue("SearchImage.ImageResponse.NextToken");

			List<SearchImageResponse.SearchImage_ImageResponse.SearchImage_Image> imageResponse_imageList = new List<SearchImageResponse.SearchImage_ImageResponse.SearchImage_Image>();
			for (int i = 0; i < _ctx.Length("SearchImage.ImageResponse.ImageList.Length"); i++) {
				SearchImageResponse.SearchImage_ImageResponse.SearchImage_Image image = new SearchImageResponse.SearchImage_ImageResponse.SearchImage_Image();
				image.ImageRatio = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].ImageRatio");
				image.DescriptiveTones = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].DescriptiveTones");
				image.OssKey = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].OssKey");
				image.ImageCategory = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].ImageCategory");
				image.Height = _ctx.IntegerValue("SearchImage.ImageResponse.ImageList["+ i +"].Height");
				image.QuantitativePalette = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].QuantitativePalette");
				image.ImageUuid = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].ImageUuid");
				image.Width = _ctx.IntegerValue("SearchImage.ImageResponse.ImageList["+ i +"].Width");
				image.Url = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].Url");
				image.TagsFromImage = _ctx.StringValue("SearchImage.ImageResponse.ImageList["+ i +"].TagsFromImage");

				imageResponse_imageList.Add(image);
			}
			imageResponse.ImageList = imageResponse_imageList;
			searchImageResponse.ImageResponse = imageResponse;
        
			return searchImageResponse;
        }
    }
}
