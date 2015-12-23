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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

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

			List<DescribeImagesResponse.Image> images = new List<DescribeImagesResponse.Image>();
			for (int i = 0; i < context.Length("DescribeImages.Images.Length"); i++) {
				DescribeImagesResponse.Image image = new DescribeImagesResponse.Image();
				image.Progress = context.StringValue("DescribeImages.Images["+ i +"].Progress");
				image.ImageId = context.StringValue("DescribeImages.Images["+ i +"].ImageId");
				image.ImageName = context.StringValue("DescribeImages.Images["+ i +"].ImageName");
				image.ImageVersion = context.StringValue("DescribeImages.Images["+ i +"].ImageVersion");
				image.Description = context.StringValue("DescribeImages.Images["+ i +"].Description");
				image.Size = context.IntegerValue("DescribeImages.Images["+ i +"].Size");
				image.ImageOwnerAlias = context.StringValue("DescribeImages.Images["+ i +"].ImageOwnerAlias");
				image.OSName = context.StringValue("DescribeImages.Images["+ i +"].OSName");
				image.Architecture = (DescribeImagesResponse.Image.Architecture_)Enum.Parse(typeof(DescribeImagesResponse.Image.Architecture_),
					 context.StringValue("DescribeImages.Images["+ i +"].Architecture"));
				image.Status = context.StringValue("DescribeImages.Images["+ i +"].Status");
				image.ProductCode = context.StringValue("DescribeImages.Images["+ i +"].ProductCode");
				image.IsSubscribed = context.BooleanValue("DescribeImages.Images["+ i +"].IsSubscribed");
				image.CreationTime = context.StringValue("DescribeImages.Images["+ i +"].CreationTime");
				image.IsSelfShared = context.StringValue("DescribeImages.Images["+ i +"].IsSelfShared");
				image.OSType = context.StringValue("DescribeImages.Images["+ i +"].OSType");
				image.Platform = context.StringValue("DescribeImages.Images["+ i +"].Platform");
				image.Usage = context.StringValue("DescribeImages.Images["+ i +"].Usage");
				image.IsCopied = context.BooleanValue("DescribeImages.Images["+ i +"].IsCopied");

				List<DescribeImagesResponse.Image.DiskDeviceMapping> diskDeviceMappings = new List<DescribeImagesResponse.Image.DiskDeviceMapping>();
				for (int j = 0; j < context.Length("DescribeImages.Images["+ i +"].DiskDeviceMappings.Length"); j++) {
					DescribeImagesResponse.Image.DiskDeviceMapping diskDeviceMapping = new DescribeImagesResponse.Image.DiskDeviceMapping();
					diskDeviceMapping.SnapshotId = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].SnapshotId");
					diskDeviceMapping.Size = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Size");
					diskDeviceMapping.Device = context.StringValue("DescribeImages.Images["+ i +"].DiskDeviceMappings["+ j +"].Device");

					diskDeviceMappings.Add(diskDeviceMapping);
				}
				image.DiskDeviceMappings = diskDeviceMappings;

				List<DescribeImagesResponse.Image.Tag> tags = new List<DescribeImagesResponse.Image.Tag>();
				for (int j = 0; j < context.Length("DescribeImages.Images["+ i +"].Tags.Length"); j++) {
					DescribeImagesResponse.Image.Tag tag = new DescribeImagesResponse.Image.Tag();
					tag.TagKey = context.StringValue("DescribeImages.Images["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeImages.Images["+ i +"].Tags["+ j +"].TagValue");

					tags.Add(tag);
				}
				image.Tags = tags;

				images.Add(image);
			}
			describeImagesResponse.Images = images;
        
			return describeImagesResponse;
        }
    }
}