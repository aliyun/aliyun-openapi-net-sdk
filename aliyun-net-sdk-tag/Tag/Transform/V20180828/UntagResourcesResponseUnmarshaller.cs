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
    public class UntagResourcesResponseUnmarshaller
    {
        public static UntagResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			UntagResourcesResponse untagResourcesResponse = new UntagResourcesResponse();

			untagResourcesResponse.HttpResponse = context.HttpResponse;
			untagResourcesResponse.RequestId = context.StringValue("UntagResources.RequestId");

			List<UntagResourcesResponse.UntagResources_FailedResource> untagResourcesResponse_failedResources = new List<UntagResourcesResponse.UntagResources_FailedResource>();
			for (int i = 0; i < context.Length("UntagResources.FailedResources.Length"); i++) {
				UntagResourcesResponse.UntagResources_FailedResource failedResource = new UntagResourcesResponse.UntagResources_FailedResource();
				failedResource.ResourceARN = context.StringValue("UntagResources.FailedResources["+ i +"].ResourceARN");

				UntagResourcesResponse.UntagResources_FailedResource.UntagResources_Result result = new UntagResourcesResponse.UntagResources_FailedResource.UntagResources_Result();
				result.Code = context.StringValue("UntagResources.FailedResources["+ i +"].Result.Code");
				result.Message = context.StringValue("UntagResources.FailedResources["+ i +"].Result.Message");
				failedResource.Result = result;

				untagResourcesResponse_failedResources.Add(failedResource);
			}
			untagResourcesResponse.FailedResources = untagResourcesResponse_failedResources;
        
			return untagResourcesResponse;
        }
    }
}
