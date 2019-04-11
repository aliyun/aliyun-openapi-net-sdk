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
    public class DeleteVideoResponseUnmarshaller
    {
        public static DeleteVideoResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteVideoResponse deleteVideoResponse = new DeleteVideoResponse();

			deleteVideoResponse.HttpResponse = context.HttpResponse;
			deleteVideoResponse.RequestId = context.StringValue("DeleteVideo.RequestId");

			List<string> deleteVideoResponse_nonExistVideoIds = new List<string>();
			for (int i = 0; i < context.Length("DeleteVideo.NonExistVideoIds.Length"); i++) {
				deleteVideoResponse_nonExistVideoIds.Add(context.StringValue("DeleteVideo.NonExistVideoIds["+ i +"]"));
			}
			deleteVideoResponse.NonExistVideoIds = deleteVideoResponse_nonExistVideoIds;

			List<string> deleteVideoResponse_forbiddenVideoIds = new List<string>();
			for (int i = 0; i < context.Length("DeleteVideo.ForbiddenVideoIds.Length"); i++) {
				deleteVideoResponse_forbiddenVideoIds.Add(context.StringValue("DeleteVideo.ForbiddenVideoIds["+ i +"]"));
			}
			deleteVideoResponse.ForbiddenVideoIds = deleteVideoResponse_forbiddenVideoIds;
        
			return deleteVideoResponse;
        }
    }
}
