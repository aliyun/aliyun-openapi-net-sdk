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
			image.Progress = _ctx.StringValue("DescribeImageFromFamily.Image.Progress");
			image.ImageId = _ctx.StringValue("DescribeImageFromFamily.Image.ImageId");
			image.ImageName = _ctx.StringValue("DescribeImageFromFamily.Image.ImageName");
			image.ImageFamily = _ctx.StringValue("DescribeImageFromFamily.Image.ImageFamily");
			image.ImageVersion = _ctx.StringValue("DescribeImageFromFamily.Image.ImageVersion");
			image.Description = _ctx.StringValue("DescribeImageFromFamily.Image.Description");
			image.Size = _ctx.IntegerValue("DescribeImageFromFamily.Image.Size");
			image.ImageOwnerAlias = _ctx.StringValue("DescribeImageFromFamily.Image.ImageOwnerAlias");
			image.IsSupportIoOptimized = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsSupportIoOptimized");
			image.IsSupportCloudinit = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsSupportCloudinit");
			image.OSName = _ctx.StringValue("DescribeImageFromFamily.Image.OSName");
			image.Architecture = _ctx.StringValue("DescribeImageFromFamily.Image.Architecture");
			image.Status = _ctx.StringValue("DescribeImageFromFamily.Image.Status");
			image.ProductCode = _ctx.StringValue("DescribeImageFromFamily.Image.ProductCode");
			image.IsSubscribed = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsSubscribed");
			image.CreationTime = _ctx.StringValue("DescribeImageFromFamily.Image.CreationTime");
			image.IsSelfShared = _ctx.StringValue("DescribeImageFromFamily.Image.IsSelfShared");
			image.OSType = _ctx.StringValue("DescribeImageFromFamily.Image.OSType");
			image.Platform = _ctx.StringValue("DescribeImageFromFamily.Image.Platform");
			image.Usage = _ctx.StringValue("DescribeImageFromFamily.Image.Usage");
			image.IsCopied = _ctx.BooleanValue("DescribeImageFromFamily.Image.IsCopied");

			List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping> image_diskDeviceMappings = new List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping>();
			for (int i = 0; i < _ctx.Length("DescribeImageFromFamily.Image.DiskDeviceMappings.Length"); i++) {
				DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping diskDeviceMapping = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_DiskDeviceMapping();
				diskDeviceMapping.SnapshotId = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].SnapshotId");
				diskDeviceMapping.Size = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Size");
				diskDeviceMapping.Device = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Device");
				diskDeviceMapping.Type = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Type");
				diskDeviceMapping.Format = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].Format");
				diskDeviceMapping.ImportOSSBucket = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].ImportOSSBucket");
				diskDeviceMapping.ImportOSSObject = _ctx.StringValue("DescribeImageFromFamily.Image.DiskDeviceMappings["+ i +"].ImportOSSObject");

				image_diskDeviceMappings.Add(diskDeviceMapping);
			}
			image.DiskDeviceMappings = image_diskDeviceMappings;

			List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag> image_tags = new List<DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeImageFromFamily.Image.Tags.Length"); i++) {
				DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag tag = new DescribeImageFromFamilyResponse.DescribeImageFromFamily_Image.DescribeImageFromFamily_Tag();
				tag.TagKey = _ctx.StringValue("DescribeImageFromFamily.Image.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("DescribeImageFromFamily.Image.Tags["+ i +"].TagValue");

				image_tags.Add(tag);
			}
			image.Tags = image_tags;
			describeImageFromFamilyResponse.Image = image;
        
			return describeImageFromFamilyResponse;
        }
    }
}
