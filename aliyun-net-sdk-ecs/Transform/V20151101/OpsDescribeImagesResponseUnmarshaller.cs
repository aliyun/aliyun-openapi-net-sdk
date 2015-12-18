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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDescribeImagesResponseUnmarshaller
    {
        public static OpsDescribeImagesResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDescribeImagesResponse opsDescribeImagesResponse = new OpsDescribeImagesResponse();

			opsDescribeImagesResponse.HttpResponse = context.HttpResponse;
			opsDescribeImagesResponse.RequestId = context.StringValue("OpsDescribeImages.RequestId");
			opsDescribeImagesResponse.TotalCount = context.IntegerValue("OpsDescribeImages.TotalCount");
			opsDescribeImagesResponse.PageNo = context.IntegerValue("OpsDescribeImages.PageNo");
			opsDescribeImagesResponse.PageSize = context.IntegerValue("OpsDescribeImages.PageSize");

			List<OpsDescribeImagesResponse.Image> images = new List<OpsDescribeImagesResponse.Image>();
			for (int i = 0; i < context.Length("OpsDescribeImages.Images.Length"); i++) {
				OpsDescribeImagesResponse.Image image = new OpsDescribeImagesResponse.Image();
				image.Id = context.LongValue("OpsDescribeImages.Images["+ i +"].Id");
				image.Bid = context.StringValue("OpsDescribeImages.Images["+ i +"].Bid");
				image.AliUid = context.LongValue("OpsDescribeImages.Images["+ i +"].AliUid");
				image.ImageId = context.StringValue("OpsDescribeImages.Images["+ i +"].ImageId");
				image.ImageSize = context.IntegerValue("OpsDescribeImages.Images["+ i +"].ImageSize");
				image.ImageName = context.StringValue("OpsDescribeImages.Images["+ i +"].ImageName");
				image.OsType = context.StringValue("OpsDescribeImages.Images["+ i +"].OsType");
				image.Platform = context.StringValue("OpsDescribeImages.Images["+ i +"].Platform");
				image.OsName = context.StringValue("OpsDescribeImages.Images["+ i +"].OsName");
				image.OsBit = context.StringValue("OpsDescribeImages.Images["+ i +"].OsBit");
				image.OsMemo = context.StringValue("OpsDescribeImages.Images["+ i +"].OsMemo");
				image.OsKind = context.StringValue("OpsDescribeImages.Images["+ i +"].OsKind");
				image.Remark = context.StringValue("OpsDescribeImages.Images["+ i +"].Remark");
				image.Version = context.StringValue("OpsDescribeImages.Images["+ i +"].Version");
				image.CreatedTime = context.StringValue("OpsDescribeImages.Images["+ i +"].CreatedTime");
				image.ModifiedTime = context.StringValue("OpsDescribeImages.Images["+ i +"].ModifiedTime");
				image.Status = context.StringValue("OpsDescribeImages.Images["+ i +"].Status");
				image.SnapshotId = context.StringValue("OpsDescribeImages.Images["+ i +"].SnapshotId");
				image.ProductCode = context.StringValue("OpsDescribeImages.Images["+ i +"].ProductCode");
				image.RegionNo = context.StringValue("OpsDescribeImages.Images["+ i +"].RegionNo");
				image.DisplayName = context.StringValue("OpsDescribeImages.Images["+ i +"].DisplayName");
				image.ImageCategory = context.StringValue("OpsDescribeImages.Images["+ i +"].ImageCategory");
				image.SrcImageId = context.LongValue("OpsDescribeImages.Images["+ i +"].SrcImageId");
				image.SupportIoOptimizedInstance = context.BooleanValue("OpsDescribeImages.Images["+ i +"].SupportIoOptimizedInstance");

				images.Add(image);
			}
			opsDescribeImagesResponse.Images = images;
        
			return opsDescribeImagesResponse;
        }
    }
}