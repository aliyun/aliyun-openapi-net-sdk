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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListDynamicImageResponseUnmarshaller
    {
        public static ListDynamicImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDynamicImageResponse listDynamicImageResponse = new ListDynamicImageResponse();

			listDynamicImageResponse.HttpResponse = _ctx.HttpResponse;
			listDynamicImageResponse.RequestId = _ctx.StringValue("ListDynamicImage.RequestId");

			List<ListDynamicImageResponse.ListDynamicImage_DynamicImage> listDynamicImageResponse_dynamicImageList = new List<ListDynamicImageResponse.ListDynamicImage_DynamicImage>();
			for (int i = 0; i < _ctx.Length("ListDynamicImage.DynamicImageList.Length"); i++) {
				ListDynamicImageResponse.ListDynamicImage_DynamicImage dynamicImage = new ListDynamicImageResponse.ListDynamicImage_DynamicImage();
				dynamicImage.CreationTime = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].CreationTime");
				dynamicImage.FileURL = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].FileURL");
				dynamicImage.VideoId = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].VideoId");
				dynamicImage.Width = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].Width");
				dynamicImage.JobId = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].JobId");
				dynamicImage.Height = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].Height");
				dynamicImage.Fps = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].Fps");
				dynamicImage.Duration = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].Duration");
				dynamicImage.Format = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].Format");
				dynamicImage.DynamicImageId = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].DynamicImageId");
				dynamicImage.FileSize = _ctx.StringValue("ListDynamicImage.DynamicImageList["+ i +"].FileSize");

				listDynamicImageResponse_dynamicImageList.Add(dynamicImage);
			}
			listDynamicImageResponse.DynamicImageList = listDynamicImageResponse_dynamicImageList;
        
			return listDynamicImageResponse;
        }
    }
}
