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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class UpdateVideoInfosResponseUnmarshaller
    {
        public static UpdateVideoInfosResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateVideoInfosResponse updateVideoInfosResponse = new UpdateVideoInfosResponse();

			updateVideoInfosResponse.HttpResponse = context.HttpResponse;
			updateVideoInfosResponse.RequestId = context.StringValue("UpdateVideoInfos.RequestId");

			List<string> updateVideoInfosResponse_nonExistVideoIds = new List<string>();
			for (int i = 0; i < context.Length("UpdateVideoInfos.NonExistVideoIds.Length"); i++) {
				updateVideoInfosResponse_nonExistVideoIds.Add(context.StringValue("UpdateVideoInfos.NonExistVideoIds["+ i +"]"));
			}
			updateVideoInfosResponse.NonExistVideoIds = updateVideoInfosResponse_nonExistVideoIds;

			List<string> updateVideoInfosResponse_forbiddenVideoIds = new List<string>();
			for (int i = 0; i < context.Length("UpdateVideoInfos.ForbiddenVideoIds.Length"); i++) {
				updateVideoInfosResponse_forbiddenVideoIds.Add(context.StringValue("UpdateVideoInfos.ForbiddenVideoIds["+ i +"]"));
			}
			updateVideoInfosResponse.ForbiddenVideoIds = updateVideoInfosResponse_forbiddenVideoIds;
        
			return updateVideoInfosResponse;
        }
    }
}
