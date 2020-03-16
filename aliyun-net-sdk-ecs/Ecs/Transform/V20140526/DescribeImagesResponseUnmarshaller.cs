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
        public static DescribeImagesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImagesResponse describeImagesResponse = new DescribeImagesResponse();

			describeImagesResponse.HttpResponse = context.HttpResponse;
			describeImagesResponse.RequestId = context.StringValue("DescribeImages.RequestId");
			describeImagesResponse.RegionId = context.StringValue("DescribeImages.RegionId");
			describeImagesResponse.TotalCount = context.IntegerValue("DescribeImages.TotalCount");
			describeImagesResponse.PageNumber = context.IntegerValue("DescribeImages.PageNumber");
			describeImagesResponse.PageSize = context.IntegerValue("DescribeImages.PageSize");

			List<DescribeImagesResponse.DescribeImages_Image> describeImagesResponse_images = new List<DescribeImagesResponse.DescribeImages_Image>();
			for (int i = 0; i < context.Length("DescribeImages.Images.Length"); i++) {
				DescribeImagesResponse.DescribeImages_Image image = new DescribeImagesResponse.DescribeImages_Image();
				image.Progress = context.StringValue("DescribeImages.Images["+ i +"].Progress");
				image.ImageId = context.StringValue("DescribeImages.Images["+ i +"].ImageId");
				image.ImageName = context.StringValue("DescribeImages.Images["+ i +"].ImageName");
				image.ImageFamily = context.StringValue("DescribeImages.Images["+ i +"].ImageFamily");
				image.ImageVersion = context.StringValue("DescribeImages.Images["+ i +"].ImageVersion");
				image.Description = context.StringValue("DescribeImages.Images["+ i +"].Description");
				image.Size = context.IntegerValue("DescribeImages.Images["+ i +"].Size");
				image.ImageOwnerAlias = context.StringValue("DescribeImages.Images["+ i +"].ImageOwnerAlias");
				image.IsSupportIoOptimized = context.BooleanValue("DescribeImages.Images["+ i +"].IsSupportIoOptimized");
				image.IsSupportCloudinit = context.BooleanValue("DescribeImages.Images["+ i +"].IsSupportCloudinit");
				image.OSName = context.StringValue("DescribeImages.Images["+ i +"].OSName");
				image.OSNameEn = context.StringValue("DescribeImages.Images["+ i +"].OSNameEn");
				image.Architecture = context.StringValue("DescribeImages.Images["+ i +"].Architecture");
				image.Status = context.StringValue("DescribeImages.Images["+ i +"].Status");
				image.ProductCode = context.StringValue("DescribeImages.Images["+ i +"].ProductCode");
				image.IsSubscribed = context.BooleanValue("DescribeImages.Images["+ i +"].IsSubscribed");
				image.CreationTime = context.StringValue("DescribeImages.Images["+ i +"].CreationTime");
				image.IsSelfShared = context.StringValue("DescribeImages.Images["+ i +"].IsSelfShared");
				image.OSType = context.StringValue("DescribeImages.Images["+ i +"].OSType");
				image.Platform = context.StringValue("DescribeImages.Images["+ i +"].Platform");
				image.Usage = context.StringValue("DescribeImages.Images["+ i +"].Usage");
				image.IsCopied = context.BooleanValue("DescribeImages.Images["+ i +"].IsCopied");
				image.ResourceGroupId = context.StringValue("DescribeImages.Images["+ i +"].ResourceGroupId");

				List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping> image_diskDeviceMappings = new List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping>();
				for (int j = 0; j < context.Length("DescribeImages.Images["+ i +"].DiskDeviceMappings.Length"); j++) {
					DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping diskDeviceMapping = new DescribeImagesResponse.DescribeImages_Image.DescribeImages_DiskDeviceMapping();
					diskDeviceMapping.SnapshotId = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].SnapshotId");
					diskDeviceMapping.Size = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Size");
					diskDeviceMapping.Device = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Device");
					diskDeviceMapping.Type = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Type");
					diskDeviceMapping.Format = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Format");
					diskDeviceMapping.ImportOSSBucket = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].ImportOSSBucket");
					diskDeviceMapping.ImportOSSObject = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].ImportOSSObject");
					diskDeviceMapping.Progress = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Progress");
					diskDeviceMapping.RemainTime = context.IntegerValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].RemainTime");

					image_diskDeviceMappings.Add(diskDeviceMapping);
				}
				image.DiskDeviceMappings = image_diskDeviceMappings;

				List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag> image_tags = new List<DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag>();
				for (int j = 0; j < context.Length("DescribeImages.Images["+ i +"].Tags.Length"); j++) {
					DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag tag = new DescribeImagesResponse.DescribeImages_Image.DescribeImages_Tag();
					tag.TagKey = context.StringValue("DescribeImages.Images["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeImages.Images["+ i +"].Tags["+ j +"].TagValue");

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
