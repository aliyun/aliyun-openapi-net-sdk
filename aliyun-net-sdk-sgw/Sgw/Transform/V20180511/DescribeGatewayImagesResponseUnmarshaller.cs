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
        public static DescribeGatewayImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayImagesResponse describeGatewayImagesResponse = new DescribeGatewayImagesResponse();

			describeGatewayImagesResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayImagesResponse.RequestId = _ctx.StringValue("DescribeGatewayImages.RequestId");
			describeGatewayImagesResponse.Success = _ctx.BooleanValue("DescribeGatewayImages.Success");
			describeGatewayImagesResponse.Code = _ctx.StringValue("DescribeGatewayImages.Code");
			describeGatewayImagesResponse.Message = _ctx.StringValue("DescribeGatewayImages.Message");

			List<DescribeGatewayImagesResponse.DescribeGatewayImages_Image> describeGatewayImagesResponse_images = new List<DescribeGatewayImagesResponse.DescribeGatewayImages_Image>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayImages.Images.Length"); i++) {
				DescribeGatewayImagesResponse.DescribeGatewayImages_Image image = new DescribeGatewayImagesResponse.DescribeGatewayImages_Image();
				image.Name = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].Name");
				image.Description = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].Description");
				image.Size = _ctx.LongValue("DescribeGatewayImages.Images["+ i +"].Size");
				image.ModifiedDate = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].ModifiedDate");
				image.Version = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].Version");
				image.Title = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].Title");
				image.Type = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].Type");
				image.MD5 = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].MD5");
				image.Url = _ctx.StringValue("DescribeGatewayImages.Images["+ i +"].Url");

				describeGatewayImagesResponse_images.Add(image);
			}
			describeGatewayImagesResponse.Images = describeGatewayImagesResponse_images;
        
			return describeGatewayImagesResponse;
        }
    }
}
