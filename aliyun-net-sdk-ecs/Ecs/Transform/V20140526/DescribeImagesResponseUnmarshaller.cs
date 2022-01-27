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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeImagesResponseUnmarshaller
    {
        public static DescribeImagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImagesResponse describeImagesResponse = new DescribeImagesResponse();

			describeImagesResponse.HttpResponse = _ctx.HttpResponse;
			describeImagesResponse.PageSize = _ctx.IntegerValue("DescribeImages.PageSize");
			describeImagesResponse.PageNumber = _ctx.IntegerValue("DescribeImages.PageNumber");
			describeImagesResponse.RequestId = _ctx.StringValue("DescribeImages.RequestId");
			describeImagesResponse.TotalCount = _ctx.IntegerValue("DescribeImages.TotalCount");
			describeImagesResponse.RegionId = _ctx.StringValue("DescribeImages.RegionId");

			List<DescribeImagesResponse.DescribeImages_Image> describeImagesResponse_images = new List<DescribeImagesResponse.DescribeImages_Image>();
			for (int i = 0; i < _ctx.Length("DescribeImages.Images.Length"); i++) {
				DescribeImagesResponse.DescribeImages_Image image = new DescribeImagesResponse.DescribeImages_Image();
				image.CreationTime = _ctx.StringValue("DescribeImages.Images["+ i +"].CreationTime");
				image.Status = _ctx.StringValue("DescribeImages.Images["+ i +"].Status");
				image.ImageFamily = _ctx.StringValue("DescribeImages.Images["+ i +"].ImageFamily");
				image.Progress = _ctx.StringValue("DescribeImages.Images["+ i +"].Progress");
				image.IsCopied = _ctx.BooleanValue("DescribeImages.Images["+ i +"].IsCopied");
				image.IsSupportIoOptimized = _ctx.BooleanValue("DescribeImages.Images["+ i +"].IsSupportIoOptimized");
				image.ImageOwnerAlias = _ctx.StringValue("DescribeImages.Images["+ i +"].ImageOwnerAlias");
				image.IsSupportCloudinit = _ctx.BooleanValue("DescribeImages.Images["+ i +"].IsSupportCloudinit");
				image.ImageVersion = _ctx.StringValue("DescribeImages.Images["+ i +"].ImageVersion");
				image.Usage = _ctx.StringValue("DescribeImages.Images["+ i +"].Usage");
				image.IsSelfShared = _ctx.StringValue("DescribeImages.Images["+ i +"].IsSelfShared");
				image.Description = _ctx.StringValue("DescribeImages.Images["+ i +"].Description");
				image.Size = _ctx.IntegerValue("DescribeImages.Images["+ i +"].Size");
				image.ResourceGroupId = _ctx.StringValue("DescribeImages.Images["+ i +"].ResourceGroupId");
				image.Platform = _ctx.StringValue("DescribeImages.Images["+ i +"].Platform");
				image.OSNameEn = _ctx.StringValue("DescribeImages.Images["+ i +"].OSNameEn");
				image.ImageName = _ctx.StringValue("DescribeImages.Images["+ i +"].ImageName");
				image.OSName = _ctx.StringValue("DescribeImages.Images["+ i +"].OSName");
				image.ImageId = _ctx.StringValue("DescribeImages.Images["+ i +"].ImageId");
				image.OSType = _ctx.StringValue("DescribeImages.Images["+ i +"].OSType");
				image.IsSubscribed = _ctx.BooleanValue("DescribeImages.Images["+ i +"].IsSubscribed");
				image.ProductCode = _ctx.StringValue("DescribeImages.Images["+ i +"].ProductCode");
				image.Architecture = _ctx.StringValue("DescribeImages.Images["+ i +"].Architecture");
				image.IsPublic = _ctx.BooleanValue("DescribeImages.Images["+ i +"].IsPublic");
				image.ImageOwnerId = _ctx.LongValue("DescribeImages.Images["+ i +"].ImageOwnerId");

				List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping> image_diskDeviceMappings = new List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping>();
				for (int j = 0; j < _ctx.Length("DescribeImages.Images["+ i +"].DiskDeviceMappings.Length"); j++) {
					DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping diskDeviceMapping = new DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping();
					diskDeviceMapping.Type = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Type");
					diskDeviceMapping.ImportOSSBucket = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].ImportOSSBucket");
					diskDeviceMapping.Progress = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Progress");
					diskDeviceMapping.SnapshotId = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].SnapshotId");
					diskDeviceMapping.ImportOSSObject = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].ImportOSSObject");
					diskDeviceMapping.Device = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Device");
					diskDeviceMapping.Size = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Size");
					diskDeviceMapping.RemainTime = _ctx.IntegerValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].RemainTime");
					diskDeviceMapping.Format = _ctx.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Format");

					image_diskDeviceMappings.Add(diskDeviceMapping);
				}
				image.DiskDeviceMappings = image_diskDeviceMappings;

				List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag> image_tags = new List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeImages.Images["+ i +"].Tags.Length"); j++) {
					DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag tag = new DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag();
					tag.TagValue = _ctx.StringValue("DescribeImages.Images["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeImages.Images["+ i +"].Tags["+ j +"].TagKey");

					image_tags.Add(tag);
				}
				image.Tags = image_tags;

				describeImagesResponse_images.Add(image);
			}
			describeImagesResponse.Images = describeImagesResponse_images;
        
			return describeImagesResponse;
        }
    }
}
