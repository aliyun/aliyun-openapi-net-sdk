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
using Aliyun.Acs.Tag.Model.V20180828;

namespace Aliyun.Acs.Tag.Transform.V20180828
{
    public class TagResourcesResponseUnmarshaller
    {
        public static TagResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			TagResourcesResponse tagResourcesResponse = new TagResourcesResponse();

			tagResourcesResponse.HttpResponse = context.HttpResponse;
			tagResourcesResponse.RequestId = context.StringValue("TagResources.RequestId");

			List<TagResourcesResponse.TagResources_FailedResource> tagResourcesResponse_failedResources = new List<TagResourcesResponse.TagResources_FailedResource>();
			for (int i = 0; i < context.Length("TagResources.FailedResources.Length"); i++) {
				TagResourcesResponse.TagResources_FailedResource failedResource = new TagResourcesResponse.TagResources_FailedResource();
				failedResource.ResourceARN = context.StringValue("TagResources.FailedResources["+ i +"].ResourceARN");

				TagResourcesResponse.TagResources_FailedResource.TagResources_Result result = new TagResourcesResponse.TagResources_FailedResource.TagResources_Result();
				result.Code = context.StringValue("TagResources.FailedResources["+ i +"].Result.Code");
				result.Message = context.StringValue("TagResources.FailedResources["+ i +"].Result.Message");
				failedResource.Result = result;

				tagResourcesResponse_failedResources.Add(failedResource);
			}
			tagResourcesResponse.FailedResources = tagResourcesResponse_failedResources;
        
			return tagResourcesResponse;
        }
    }
}
