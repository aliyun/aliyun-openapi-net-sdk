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
    public class DescribeImageFromFamilyResponseUnmarshaller
    {
        public static DescribeImageFromFamilyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImageFromFamilyResponse describeImageFromFamilyResponse = new DescribeImageFromFamilyResponse();

			describeImageFromFamilyResponse.HttpResponse = context.HttpResponse;
			describeImageFromFamilyResponse.RequestId = context.StringValue("DescribeImageFromFamily.RequestId");

			DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image image = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image();
			image.Progress = context.StringValue("DescribeImageFromFamily.Image.Progress");
			image.ImageId = context.StringValue("DescribeImageFromFamily.Image.ImageId");
			image.ImageName = context.StringValue("DescribeImageFromFamily.Image.ImageName");
			image.ImageFamily = context.StringValue("DescribeImageFromFamily.Image.ImageFamily");
			image.ImageVersion = context.StringValue("DescribeImageFromFamily.Image.ImageVersion");
			image.Description = context.StringValue("DescribeImageFromFamily.Image.Description");
			image.Size = context.IntegerValue("DescribeImageFromFamily.Image.Size");
			image.ImageOwnerAlias = context.StringValue("DescribeImageFromFamily.Image.ImageOwnerAlias");
			image.IsSupportIoOptimized = context.BooleanValue("DescribeImageFromFamily.Image.IsSupportIoOptimized");
			image.IsSupportCloudinit = context.BooleanValue("DescribeImageFromFamily.Image.IsSupportCloudinit");
			image.OSName = context.StringValue("DescribeImageFromFamily.Image.OSName");
			image.Architecture = context.StringValue("DescribeImageFromFamily.Image.Architecture");
			image.Status = context.StringValue("DescribeImageFromFamily.Image.Status");
			image.ProductCode = context.StringValue("DescribeImageFromFamily.Image.ProductCode");
			image.IsSubscribed = context.BooleanValue("DescribeImageFromFamily.Image.IsSubscribed");
			image.CreationTime = context.StringValue("DescribeImageFromFamily.Image.CreationTime");
			image.IsSelfShared = context.StringValue("DescribeImageFromFamily.Image.IsSelfShared");
			image.OSType = context.StringValue("DescribeImageFromFamily.Image.OSType");
			image.Platform = context.StringValue("DescribeImageFromFamily.Image.Platform");
			image.Usage = context.StringValue("DescribeImageFromFamily.Image.Usage");
			image.IsCopied = context.BooleanValue("DescribeImageFromFamily.Image.IsCopied");

			List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping> image_diskDeviceMappings = new List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping>();
			for (int i = 0; i < context.Length("DescribeImageFromFamily.Image.DiskDeviceMappings.Length"); i++) {
				DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping diskDeviceMapping = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping();
				diskDeviceMapping.SnapshotId = context.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].SnapshotId");
				diskDeviceMapping.Size = context.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Size");
				diskDeviceMapping.Device = context.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Device");
				diskDeviceMapping.Type = context.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Type");
				diskDeviceMapping.Format = context.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Format");
				diskDeviceMapping.ImportOSSBucket = context.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].ImportOSSBucket");
				diskDeviceMapping.ImportOSSObject = context.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].ImportOSSObject");

				image_diskDeviceMappings.Add(diskDeviceMapping);
			}
			image.DiskDeviceMappings = image_diskDeviceMappings;

			List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag> image_tags = new List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag>();
			for (int i = 0; i < context.Length("DescribeImageFromFamily.Image.Tags.Length"); i++) {
				DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag tag = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag();
				tag.TagKey = context.StringValue("DescribeImageFromFamily.Image.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("DescribeImageFromFamily.Image.Tags["+ i +"].TagValue");

				image_tags.Add(tag);
			}
			image.Tags = image_tags;
			describeImageFromFamilyResponse.Image = image;
        
			return describeImageFromFamilyResponse;
        }
    }
}
