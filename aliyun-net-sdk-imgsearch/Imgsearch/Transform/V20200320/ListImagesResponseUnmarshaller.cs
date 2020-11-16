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
        public static ListImagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListImagesResponse listImagesResponse = new ListImagesResponse();

			listImagesResponse.HttpResponse = context.HttpResponse;
			listImagesResponse.RequestId = context.StringValue("ListImages.RequestId");

			ListImagesResponse.ListImages_Data data = new ListImagesResponse.ListImages_Data();
			data.Token = context.StringValue("ListImages.Data.Token");
			data.TotalCount = context.IntegerValue("ListImages.Data.TotalCount");

			List<ListImagesResponse.ListImages_Data.ListImages_ImageListItem> data_imageList = new List<ListImagesResponse.ListImages_Data.ListImages_ImageListItem>();
			for (int i = 0; i < context.Length("ListImages.Data.ImageList.Length"); i++) {
				ListImagesResponse.ListImages_Data.ListImages_ImageListItem imageListItem = new ListImagesResponse.ListImages_Data.ListImages_ImageListItem();
				imageListItem.DataId = context.StringValue("ListImages.Data.ImageList["+ i +"].DataId");
				imageListItem.ExtraData = context.StringValue("ListImages.Data.ImageList["+ i +"].ExtraData");
				imageListItem.EntityId = context.StringValue("ListImages.Data.ImageList["+ i +"].EntityId");
				imageListItem.UpdatedAt = context.LongValue("ListImages.Data.ImageList["+ i +"].UpdatedAt");
				imageListItem.CreatedAt = context.LongValue("ListImages.Data.ImageList["+ i +"].CreatedAt");

				data_imageList.Add(imageListItem);
			}
			data.ImageList = data_imageList;
			listImagesResponse.Data = data;
        
			return listImagesResponse;
        }
    }
}
