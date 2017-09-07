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
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class GetThumbnailsResponseUnmarshaller
    {
        public static GetThumbnailsResponse Unmarshall(UnmarshallerContext context)
        {
			GetThumbnailsResponse getThumbnailsResponse = new GetThumbnailsResponse();

			getThumbnailsResponse.HttpResponse = context.HttpResponse;
			getThumbnailsResponse.Code = context.StringValue("GetThumbnails.Code");
			getThumbnailsResponse.Message = context.StringValue("GetThumbnails.Message");
			getThumbnailsResponse.RequestId = context.StringValue("GetThumbnails.RequestId");
			getThumbnailsResponse.Action = context.StringValue("GetThumbnails.Action");

			List<GetThumbnailsResponse.GetThumbnails_Result> getThumbnailsResponse_results = new List<GetThumbnailsResponse.GetThumbnails_Result>();
			for (int i = 0; i < context.Length("GetThumbnails.Results.Length"); i++) {
				GetThumbnailsResponse.GetThumbnails_Result result = new GetThumbnailsResponse.GetThumbnails_Result();
				result.Code = context.StringValue("GetThumbnails.Results["+ i +"].Code");
				result.Message = context.StringValue("GetThumbnails.Results["+ i +"].Message");
				result.PhotoId = context.LongValue("GetThumbnails.Results["+ i +"].PhotoId");
				result.ThumbnailUrl = context.StringValue("GetThumbnails.Results["+ i +"].ThumbnailUrl");

				getThumbnailsResponse_results.Add(result);
			}
			getThumbnailsResponse.Results = getThumbnailsResponse_results;
        
			return getThumbnailsResponse;
        }
    }
}