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
using Aliyun.Acs.imgsearch.Model.V20200320;

namespace Aliyun.Acs.imgsearch.Transform.V20200320
{
    public class ListImagesResponseUnmarshaller
    {
        public static ListImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListImagesResponse listImagesResponse = new ListImagesResponse();

			listImagesResponse.HttpResponse = _ctx.HttpResponse;
			listImagesResponse.RequestId = _ctx.StringValue("ListImages.RequestId");

			ListImagesResponse.ListImages_Data data = new ListImagesResponse.ListImages_Data();
			data.Token = _ctx.StringValue("ListImages.Data.Token");
			data.TotalCount = _ctx.IntegerValue("ListImages.Data.TotalCount");

			List<ListImagesResponse.ListImages_Data.ListImages_ImageListItem> data_imageList = new List<ListImagesResponse.ListImages_Data.ListImages_ImageListItem>();
			for (int i = 0; i < _ctx.Length("ListImages.Data.ImageList.Length"); i++) {
				ListImagesResponse.ListImages_Data.ListImages_ImageListItem imageListItem = new ListImagesResponse.ListImages_Data.ListImages_ImageListItem();
				imageListItem.EntityId = _ctx.StringValue("ListImages.Data.ImageList["+ i +"].EntityId");
				imageListItem.CreatedAt = _ctx.LongValue("ListImages.Data.ImageList["+ i +"].CreatedAt");
				imageListItem.UpdatedAt = _ctx.LongValue("ListImages.Data.ImageList["+ i +"].UpdatedAt");
				imageListItem.DataId = _ctx.StringValue("ListImages.Data.ImageList["+ i +"].DataId");
				imageListItem.ExtraData = _ctx.StringValue("ListImages.Data.ImageList["+ i +"].ExtraData");

				data_imageList.Add(imageListItem);
			}
			data.ImageList = data_imageList;
			listImagesResponse.Data = data;
        
			return listImagesResponse;
        }
    }
}
