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
    public class DescribeImagePipelinesResponseUnmarshaller
    {
        public static DescribeImagePipelinesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImagePipelinesResponse describeImagePipelinesResponse = new DescribeImagePipelinesResponse();

			describeImagePipelinesResponse.HttpResponse = _ctx.HttpResponse;
			describeImagePipelinesResponse.RequestId = _ctx.StringValue("DescribeImagePipelines.RequestId");
			describeImagePipelinesResponse.TotalCount = _ctx.IntegerValue("DescribeImagePipelines.TotalCount");
			describeImagePipelinesResponse.NextToken = _ctx.StringValue("DescribeImagePipelines.NextToken");
			describeImagePipelinesResponse.MaxResults = _ctx.IntegerValue("DescribeImagePipelines.MaxResults");

			List<DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet> describeImagePipelinesResponse_imagePipeline = new List<DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet>();
			for (int i = 0; i < _ctx.Length("DescribeImagePipelines.ImagePipeline.Length"); i++) {
				DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet imagePipelineSet = new DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet();
				imagePipelineSet.CreationTime = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].CreationTime");
				imagePipelineSet.ImagePipelineId = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].ImagePipelineId");
				imagePipelineSet.Name = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].Name");
				imagePipelineSet.Description = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].Description");
				imagePipelineSet.BaseImageType = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].BaseImageType");
				imagePipelineSet.BaseImage = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].BaseImage");
				imagePipelineSet.ImageName = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].ImageName");
				imagePipelineSet.VSwitchId = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].VSwitchId");
				imagePipelineSet.InstanceType = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].InstanceType");
				imagePipelineSet.InternetMaxBandwidthOut = _ctx.IntegerValue("DescribeImagePipelines.ImagePipeline["+ i +"].InternetMaxBandwidthOut");
				imagePipelineSet.SystemDiskSize = _ctx.IntegerValue("DescribeImagePipelines.ImagePipeline["+ i +"].SystemDiskSize");
				imagePipelineSet.DeleteInstanceOnFailure = _ctx.BooleanValue("DescribeImagePipelines.ImagePipeline["+ i +"].DeleteInstanceOnFailure");
				imagePipelineSet.BuildContent = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].BuildContent");
				imagePipelineSet.ResourceGroupId = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].ResourceGroupId");

				List<string> imagePipelineSet_addAccounts = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeImagePipelines.ImagePipeline["+ i +"].AddAccounts.Length"); j++) {
					imagePipelineSet_addAccounts.Add(_ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].AddAccounts["+ j +"]"));
				}
				imagePipelineSet.AddAccounts = imagePipelineSet_addAccounts;

				List<string> imagePipelineSet_toRegionIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeImagePipelines.ImagePipeline["+ i +"].ToRegionIds.Length"); j++) {
					imagePipelineSet_toRegionIds.Add(_ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].ToRegionIds["+ j +"]"));
				}
				imagePipelineSet.ToRegionIds = imagePipelineSet_toRegionIds;

				List<DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet.DescribeImagePipelines_Tag> imagePipelineSet_tags = new List<DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet.DescribeImagePipelines_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeImagePipelines.ImagePipeline["+ i +"].Tags.Length"); j++) {
					DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet.DescribeImagePipelines_Tag tag = new DescribeImagePipelinesResponse.DescribeImagePipelines_ImagePipelineSet.DescribeImagePipelines_Tag();
					tag.TagKey = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeImagePipelines.ImagePipeline["+ i +"].Tags["+ j +"].TagValue");

					imagePipelineSet_tags.Add(tag);
				}
				imagePipelineSet.Tags = imagePipelineSet_tags;

				describeImagePipelinesResponse_imagePipeline.Add(imagePipelineSet);
			}
			describeImagePipelinesResponse.ImagePipeline = describeImagePipelinesResponse_imagePipeline;
        
			return describeImagePipelinesResponse;
        }
    }
}
