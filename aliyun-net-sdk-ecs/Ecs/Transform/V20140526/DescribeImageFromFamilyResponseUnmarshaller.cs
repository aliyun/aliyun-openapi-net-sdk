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
        public static DescribeImageFromFamilyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageFromFamilyResponse describeImageFromFamilyResponse = new DescribeImageFromFamilyResponse();

			describeImageFromFamilyResponse.HttpResponse = _ctx.HttpResponse;
			describeImageFromFamilyResponse.RequestId = _ctx.StringValue("DescribeImageFromFamily.RequestId");

			DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image image = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image();
			image.CreationTime = _ctx.StringValue("DescribeImageFromFamily.Image.CreationTime");
			image.Status = _ctx.StringValue("DescribeImageFromFamily.Image.Status");
			image.ImageFamily = _ctx.StringValue("DescribeImageFromFamily.Image.ImageFamily");
			image.Progress = _ctx.StringValue("DescribeImageFromFamily.Image.Progress");
			image.IsCopied = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsCopied");
			image.IsSupportIoOptimized = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsSupportIoOptimized");
			image.ImageOwnerAlias = _ctx.StringValue("DescribeImageFromFamily.Image.ImageOwnerAlias");
			image.IsSupportCloudinit = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsSupportCloudinit");
			image.ImageVersion = _ctx.StringValue("DescribeImageFromFamily.Image.ImageVersion");
			image.Usage = _ctx.StringValue("DescribeImageFromFamily.Image.Usage");
			image.IsSelfShared = _ctx.StringValue("DescribeImageFromFamily.Image.IsSelfShared");
			image.Description = _ctx.StringValue("DescribeImageFromFamily.Image.Description");
			image.Size = _ctx.IntegerValue("DescribeImageFromFamily.Image.Size");
			image.Platform = _ctx.StringValue("DescribeImageFromFamily.Image.Platform");
			image.ImageName = _ctx.StringValue("DescribeImageFromFamily.Image.ImageName");
			image.OSName = _ctx.StringValue("DescribeImageFromFamily.Image.OSName");
			image.ImageId = _ctx.StringValue("DescribeImageFromFamily.Image.ImageId");
			image.OSType = _ctx.StringValue("DescribeImageFromFamily.Image.OSType");
			image.IsSubscribed = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsSubscribed");
			image.ProductCode = _ctx.StringValue("DescribeImageFromFamily.Image.ProductCode");
			image.Architecture = _ctx.StringValue("DescribeImageFromFamily.Image.Architecture");

			List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping> image_diskDeviceMappings = new List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping>();
			for (int i = 0; i < _ctx.Length("DescribeImageFromFamily.Image.DiskDeviceMappings.Length"); i++) {
				DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping diskDeviceMapping = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping();
				diskDeviceMapping.Type = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Type");
				diskDeviceMapping.ImportOSSBucket = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].ImportOSSBucket");
				diskDeviceMapping.SnapshotId = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].SnapshotId");
				diskDeviceMapping.ImportOSSObject = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].ImportOSSObject");
				diskDeviceMapping.Size = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Size");
				diskDeviceMapping.Device = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Device");
				diskDeviceMapping.Format = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Format");

				image_diskDeviceMappings.Add(diskDeviceMapping);
			}
			image.DiskDeviceMappings = image_diskDeviceMappings;

			List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag> image_tags = new List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeImageFromFamily.Image.Tags.Length"); i++) {
				DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag tag = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag();
				tag.TagValue = _ctx.StringValue("DescribeImageFromFamily.Image.Tags["+ i +"].TagValue");
				tag.TagKey = _ctx.StringValue("DescribeImageFromFamily.Image.Tags["+ i +"].TagKey");

				image_tags.Add(tag);
			}
			image.Tags = image_tags;
			describeImageFromFamilyResponse.Image = image;
        
			return describeImageFromFamilyResponse;
        }
    }
}
