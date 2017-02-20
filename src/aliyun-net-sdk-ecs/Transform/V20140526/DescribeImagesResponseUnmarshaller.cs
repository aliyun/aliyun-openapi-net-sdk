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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeImagesResponseUnmarshaller
    {
        public static DescribeImagesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeImagesResponse describeImagesResponse = new DescribeImagesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeImages.RequestId"),
                RegionId = context.StringValue("DescribeImages.RegionId"),
                TotalCount = context.IntegerValue("DescribeImages.TotalCount"),
                PageNumber = context.IntegerValue("DescribeImages.PageNumber"),
                PageSize = context.IntegerValue("DescribeImages.PageSize")
            };
            List<DescribeImagesResponse.Image> images = new List<DescribeImagesResponse.Image>();
			for (int i = 0; i < context.Length("DescribeImages.Images.Length"); i++) {
                DescribeImagesResponse.Image image = new DescribeImagesResponse.Image()
                {
                    Progress = context.StringValue($"DescribeImages.Images[{i}].Progress"),
                    ImageId = context.StringValue($"DescribeImages.Images[{i}].ImageId"),
                    ImageName = context.StringValue($"DescribeImages.Images[{i}].ImageName"),
                    ImageVersion = context.StringValue($"DescribeImages.Images[{i}].ImageVersion"),
                    Description = context.StringValue($"DescribeImages.Images[{i}].Description"),
                    Size = context.IntegerValue($"DescribeImages.Images[{i}].Size"),
                    ImageOwnerAlias = context.StringValue($"DescribeImages.Images[{i}].ImageOwnerAlias"),
                    IsSupportIoOptimized = context.BooleanValue($"DescribeImages.Images[{i}].IsSupportIoOptimized"),
                    OsName = context.StringValue($"DescribeImages.Images[{i}].OSName"),
                    Architecture = context.EnumValue<DescribeImagesResponse.Image.ArchitectureEnum>($"DescribeImages.Images[{i}].Architecture"),
                    Status = context.StringValue($"DescribeImages.Images[{i}].Status"),
                    ProductCode = context.StringValue($"DescribeImages.Images[{i}].ProductCode"),
                    IsSubscribed = context.BooleanValue($"DescribeImages.Images[{i}].IsSubscribed"),
                    CreationTime = context.StringValue($"DescribeImages.Images[{i}].CreationTime"),
                    IsSelfShared = context.StringValue($"DescribeImages.Images[{i}].IsSelfShared"),
                    OsType = context.StringValue($"DescribeImages.Images[{i}].OSType"),
                    Platform = context.StringValue($"DescribeImages.Images[{i}].Platform"),
                    Usage = context.StringValue($"DescribeImages.Images[{i}].Usage"),
                    IsCopied = context.BooleanValue($"DescribeImages.Images[{i}].IsCopied")
                };
                List<DescribeImagesResponse.Image.DiskDeviceMapping> diskDeviceMappings = new List<DescribeImagesResponse.Image.DiskDeviceMapping>();
				for (int j = 0; j < context.Length($"DescribeImages.Images[{i}].DiskDeviceMappings.Length"); j++) {
                    DescribeImagesResponse.Image.DiskDeviceMapping diskDeviceMapping = new DescribeImagesResponse.Image.DiskDeviceMapping()
                    {
                        SnapshotId = context.StringValue($"DescribeImages.Images[{i}].DiskDeviceMappings[{j}].SnapshotId"),
                        Size = context.StringValue($"DescribeImages.Images[{i}].DiskDeviceMappings[{j}].Size"),
                        Device = context.StringValue($"DescribeImages.Images[{i}].DiskDeviceMappings[{j}].Device"),
                        Format = context.StringValue($"DescribeImages.Images[{i}].DiskDeviceMappings[{j}].Format"),
                        ImportOssBucket = context.StringValue($"DescribeImages.Images[{i}].DiskDeviceMappings[{j}].ImportOSSBucket"),
                        ImportOssObject = context.StringValue($"DescribeImages.Images[{i}].DiskDeviceMappings[{j}].ImportOSSObject")
                    };
                    diskDeviceMappings.Add(diskDeviceMapping);
				}
				image.DiskDeviceMappings = diskDeviceMappings;

				List<DescribeImagesResponse.Image.Tag> tags = new List<DescribeImagesResponse.Image.Tag>();
				for (int j = 0; j < context.Length($"DescribeImages.Images[{i}].Tags.Length"); j++) {
                    DescribeImagesResponse.Image.Tag tag = new DescribeImagesResponse.Image.Tag()
                    {
                        TagKey = context.StringValue($"DescribeImages.Images[{i}].Tags[{j}].TagKey"),
                        TagValue = context.StringValue($"DescribeImages.Images[{i}].Tags[{j}].TagValue")
                    };
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