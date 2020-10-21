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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewayImagesResponseUnmarshaller
    {
        public static DescribeGatewayImagesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayImagesResponse describeGatewayImagesResponse = new DescribeGatewayImagesResponse();

			describeGatewayImagesResponse.HttpResponse = context.HttpResponse;
			describeGatewayImagesResponse.RequestId = context.StringValue("DescribeGatewayImages.RequestId");
			describeGatewayImagesResponse.Success = context.BooleanValue("DescribeGatewayImages.Success");
			describeGatewayImagesResponse.Code = context.StringValue("DescribeGatewayImages.Code");
			describeGatewayImagesResponse.Message = context.StringValue("DescribeGatewayImages.Message");

			List<DescribeGatewayImagesResponse.DescribeGatewayImages_Image> describeGatewayImagesResponse_images = new List<DescribeGatewayImagesResponse.DescribeGatewayImages_Image>();
			for (int i = 0; i < context.Length("DescribeGatewayImages.Images.Length"); i++) {
				DescribeGatewayImagesResponse.DescribeGatewayImages_Image image = new DescribeGatewayImagesResponse.DescribeGatewayImages_Image();
				image.Name = context.StringValue("DescribeGatewayImages.Images["+ i +"].Name");
				image.Description = context.StringValue("DescribeGatewayImages.Images["+ i +"].Description");
				image.Size = context.LongValue("DescribeGatewayImages.Images["+ i +"].Size");
				image.ModifiedDate = context.StringValue("DescribeGatewayImages.Images["+ i +"].ModifiedDate");
				image.Version = context.StringValue("DescribeGatewayImages.Images["+ i +"].Version");
				image.Title = context.StringValue("DescribeGatewayImages.Images["+ i +"].Title");
				image.Type = context.StringValue("DescribeGatewayImages.Images["+ i +"].Type");
				image.MD5 = context.StringValue("DescribeGatewayImages.Images["+ i +"].MD5");
				image.Url = context.StringValue("DescribeGatewayImages.Images["+ i +"].Url");

				describeGatewayImagesResponse_images.Add(image);
			}
			describeGatewayImagesResponse.Images = describeGatewayImagesResponse_images;
        
			return describeGatewayImagesResponse;
        }
    }
}
