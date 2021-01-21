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
    public class DescribeImagePipelineExecutionsResponseUnmarshaller
    {
        public static DescribeImagePipelineExecutionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImagePipelineExecutionsResponse describeImagePipelineExecutionsResponse = new DescribeImagePipelineExecutionsResponse();

			describeImagePipelineExecutionsResponse.HttpResponse = _ctx.HttpResponse;
			describeImagePipelineExecutionsResponse.RequestId = _ctx.StringValue("DescribeImagePipelineExecutions.RequestId");
			describeImagePipelineExecutionsResponse.TotalCount = _ctx.IntegerValue("DescribeImagePipelineExecutions.TotalCount");
			describeImagePipelineExecutionsResponse.NextToken = _ctx.StringValue("DescribeImagePipelineExecutions.NextToken");
			describeImagePipelineExecutionsResponse.MaxResults = _ctx.IntegerValue("DescribeImagePipelineExecutions.MaxResults");

			List<DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet> describeImagePipelineExecutionsResponse_imagePipelineExecution = new List<DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet>();
			for (int i = 0; i < _ctx.Length("DescribeImagePipelineExecutions.ImagePipelineExecution.Length"); i++) {
				DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet imagePipelineExecutionSet = new DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet();
				imagePipelineExecutionSet.CreationTime = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].CreationTime");
				imagePipelineExecutionSet.ModifiedTime = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].ModifiedTime");
				imagePipelineExecutionSet.ImageId = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].ImageId");
				imagePipelineExecutionSet.ImagePipelineId = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].ImagePipelineId");
				imagePipelineExecutionSet.ExecutionId = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].ExecutionId");
				imagePipelineExecutionSet.Status = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].Status");
				imagePipelineExecutionSet.Message = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].Message");
				imagePipelineExecutionSet.ResourceGroupId = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].ResourceGroupId");

				List<DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet.DescribeImagePipelineExecutions_Tag> imagePipelineExecutionSet_tags = new List<DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet.DescribeImagePipelineExecutions_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].Tags.Length"); j++) {
					DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet.DescribeImagePipelineExecutions_Tag tag = new DescribeImagePipelineExecutionsResponse.DescribeImagePipelineExecutions_ImagePipelineExecutionSet.DescribeImagePipelineExecutions_Tag();
					tag.TagKey = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeImagePipelineExecutions.ImagePipelineExecution["+ i +"].Tags["+ j +"].TagValue");

					imagePipelineExecutionSet_tags.Add(tag);
				}
				imagePipelineExecutionSet.Tags = imagePipelineExecutionSet_tags;

				describeImagePipelineExecutionsResponse_imagePipelineExecution.Add(imagePipelineExecutionSet);
			}
			describeImagePipelineExecutionsResponse.ImagePipelineExecution = describeImagePipelineExecutionsResponse_imagePipelineExecution;
        
			return describeImagePipelineExecutionsResponse;
        }
    }
}
