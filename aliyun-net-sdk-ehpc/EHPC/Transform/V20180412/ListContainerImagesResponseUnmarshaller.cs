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
    public class ListContainerImagesResponseUnmarshaller
    {
        public static ListContainerImagesResponse Unmarshall(UnmarshallerContext context)
        {
			ListContainerImagesResponse listContainerImagesResponse = new ListContainerImagesResponse();

			listContainerImagesResponse.HttpResponse = context.HttpResponse;
			listContainerImagesResponse.RequestId = context.StringValue("ListContainerImages.RequestId");
			listContainerImagesResponse.TotalCount = context.IntegerValue("ListContainerImages.TotalCount");
			listContainerImagesResponse.PageNumber = context.IntegerValue("ListContainerImages.PageNumber");
			listContainerImagesResponse.PageSize = context.IntegerValue("ListContainerImages.PageSize");
			listContainerImagesResponse.DBInfo = context.StringValue("ListContainerImages.DBInfo");

			List<ListContainerImagesResponse.ListContainerImages_ImagesItem> listContainerImagesResponse_images = new List<ListContainerImagesResponse.ListContainerImages_ImagesItem>();
			for (int i = 0; i < context.Length("ListContainerImages.Images.Length"); i++) {
				ListContainerImagesResponse.ListContainerImages_ImagesItem imagesItem = new ListContainerImagesResponse.ListContainerImages_ImagesItem();
				imagesItem.System = context.StringValue("ListContainerImages.Images["+ i +"].System");
				imagesItem.Type = context.StringValue("ListContainerImages.Images["+ i +"].Type");
				imagesItem.Status = context.StringValue("ListContainerImages.Images["+ i +"].Status");
				imagesItem.ImageId = context.StringValue("ListContainerImages.Images["+ i +"].ImageId");
				imagesItem.UpdateDateTime = context.StringValue("ListContainerImages.Images["+ i +"].UpdateDateTime");
				imagesItem.Repository = context.StringValue("ListContainerImages.Images["+ i +"].Repository");
				imagesItem.Tag = context.StringValue("ListContainerImages.Images["+ i +"].Tag");

				listContainerImagesResponse_images.Add(imagesItem);
			}
			listContainerImagesResponse.Images = listContainerImagesResponse_images;
        
			return listContainerImagesResponse;
        }
    }
}
