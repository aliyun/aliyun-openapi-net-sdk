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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterVideoResourcesResponseUnmarshaller
    {
        public static DescribeCasterVideoResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterVideoResourcesResponse describeCasterVideoResourcesResponse = new DescribeCasterVideoResourcesResponse();

			describeCasterVideoResourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterVideoResourcesResponse.RequestId = _ctx.StringValue("DescribeCasterVideoResources.RequestId");
			describeCasterVideoResourcesResponse.Total = _ctx.IntegerValue("DescribeCasterVideoResources.Total");

			List<DescribeCasterVideoResourcesResponse.DescribeCasterVideoResources_VideoResource> describeCasterVideoResourcesResponse_videoResources = new List<DescribeCasterVideoResourcesResponse.DescribeCasterVideoResources_VideoResource>();
			for (int i = 0; i < _ctx.Length("DescribeCasterVideoResources.VideoResources.Length"); i++) {
				DescribeCasterVideoResourcesResponse.DescribeCasterVideoResources_VideoResource videoResource = new DescribeCasterVideoResourcesResponse.DescribeCasterVideoResources_VideoResource();
				videoResource.MaterialId = _ctx.StringValue("DescribeCasterVideoResources.VideoResources["+ i +"].MaterialId");
				videoResource.ResourceId = _ctx.StringValue("DescribeCasterVideoResources.VideoResources["+ i +"].ResourceId");
				videoResource.ResourceName = _ctx.StringValue("DescribeCasterVideoResources.VideoResources["+ i +"].ResourceName");
				videoResource.LocationId = _ctx.StringValue("DescribeCasterVideoResources.VideoResources["+ i +"].LocationId");
				videoResource.LiveStreamUrl = _ctx.StringValue("DescribeCasterVideoResources.VideoResources["+ i +"].LiveStreamUrl");
				videoResource.RepeatNum = _ctx.IntegerValue("DescribeCasterVideoResources.VideoResources["+ i +"].RepeatNum");
				videoResource.VodUrl = _ctx.StringValue("DescribeCasterVideoResources.VideoResources["+ i +"].VodUrl");
				videoResource.BeginOffset = _ctx.IntegerValue("DescribeCasterVideoResources.VideoResources["+ i +"].BeginOffset");
				videoResource.EndOffset = _ctx.IntegerValue("DescribeCasterVideoResources.VideoResources["+ i +"].EndOffset");
				videoResource.PtsCallbackInterval = _ctx.IntegerValue("DescribeCasterVideoResources.VideoResources["+ i +"].PtsCallbackInterval");

				describeCasterVideoResourcesResponse_videoResources.Add(videoResource);
			}
			describeCasterVideoResourcesResponse.VideoResources = describeCasterVideoResourcesResponse_videoResources;
        
			return describeCasterVideoResourcesResponse;
        }
    }
}
