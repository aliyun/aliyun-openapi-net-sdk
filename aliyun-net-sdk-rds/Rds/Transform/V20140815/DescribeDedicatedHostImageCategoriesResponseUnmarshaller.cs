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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDedicatedHostImageCategoriesResponseUnmarshaller
    {
        public static DescribeDedicatedHostImageCategoriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostImageCategoriesResponse describeDedicatedHostImageCategoriesResponse = new DescribeDedicatedHostImageCategoriesResponse();

			describeDedicatedHostImageCategoriesResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostImageCategoriesResponse.RequestId = context.StringValue("DescribeDedicatedHostImageCategories.RequestId");

			List<DescribeDedicatedHostImageCategoriesResponse.DescribeDedicatedHostImageCategories_ImagesItem> describeDedicatedHostImageCategoriesResponse_images = new List<DescribeDedicatedHostImageCategoriesResponse.DescribeDedicatedHostImageCategories_ImagesItem>();
			for (int i = 0; i < context.Length("DescribeDedicatedHostImageCategories.Images.Length"); i++) {
				DescribeDedicatedHostImageCategoriesResponse.DescribeDedicatedHostImageCategories_ImagesItem imagesItem = new DescribeDedicatedHostImageCategoriesResponse.DescribeDedicatedHostImageCategories_ImagesItem();
				imagesItem.ImageName = context.StringValue("DescribeDedicatedHostImageCategories.Images["+ i +"].ImageName");
				imagesItem.ImageCode = context.StringValue("DescribeDedicatedHostImageCategories.Images["+ i +"].ImageCode");

				describeDedicatedHostImageCategoriesResponse_images.Add(imagesItem);
			}
			describeDedicatedHostImageCategoriesResponse.Images = describeDedicatedHostImageCategoriesResponse_images;
        
			return describeDedicatedHostImageCategoriesResponse;
        }
    }
}
