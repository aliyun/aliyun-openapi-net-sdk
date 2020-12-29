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
    public class DescribeGWSImagesResponseUnmarshaller
    {
        public static DescribeGWSImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGWSImagesResponse describeGWSImagesResponse = new DescribeGWSImagesResponse();

			describeGWSImagesResponse.HttpResponse = _ctx.HttpResponse;
			describeGWSImagesResponse.RequestId = _ctx.StringValue("DescribeGWSImages.RequestId");
			describeGWSImagesResponse.TotalCount = _ctx.IntegerValue("DescribeGWSImages.TotalCount");
			describeGWSImagesResponse.PageNumber = _ctx.IntegerValue("DescribeGWSImages.PageNumber");
			describeGWSImagesResponse.PageSize = _ctx.IntegerValue("DescribeGWSImages.PageSize");

			List<DescribeGWSImagesResponse.DescribeGWSImages_ImageInfo> describeGWSImagesResponse_images = new List<DescribeGWSImagesResponse.DescribeGWSImages_ImageInfo>();
			for (int i = 0; i < _ctx.Length("DescribeGWSImages.Images.Length"); i++) {
				DescribeGWSImagesResponse.DescribeGWSImages_ImageInfo imageInfo = new DescribeGWSImagesResponse.DescribeGWSImages_ImageInfo();
				imageInfo.ImageId = _ctx.StringValue("DescribeGWSImages.Images["+ i +"].ImageId");
				imageInfo.Status = _ctx.StringValue("DescribeGWSImages.Images["+ i +"].Status");
				imageInfo.CreateTime = _ctx.StringValue("DescribeGWSImages.Images["+ i +"].CreateTime");
				imageInfo.Name = _ctx.StringValue("DescribeGWSImages.Images["+ i +"].Name");
				imageInfo.ImageType = _ctx.StringValue("DescribeGWSImages.Images["+ i +"].ImageType");
				imageInfo.Progress = _ctx.StringValue("DescribeGWSImages.Images["+ i +"].Progress");
				imageInfo.Size = _ctx.IntegerValue("DescribeGWSImages.Images["+ i +"].Size");

				describeGWSImagesResponse_images.Add(imageInfo);
			}
			describeGWSImagesResponse.Images = describeGWSImagesResponse_images;
        
			return describeGWSImagesResponse;
        }
    }
}
