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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class RemoveAlbumPhotosResponseUnmarshaller
    {
        public static RemoveAlbumPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			RemoveAlbumPhotosResponse removeAlbumPhotosResponse = new RemoveAlbumPhotosResponse();

			removeAlbumPhotosResponse.HttpResponse = context.HttpResponse;
			removeAlbumPhotosResponse.Code = context.StringValue("RemoveAlbumPhotos.Code");
			removeAlbumPhotosResponse.Message = context.StringValue("RemoveAlbumPhotos.Message");
			removeAlbumPhotosResponse.RequestId = context.StringValue("RemoveAlbumPhotos.RequestId");
			removeAlbumPhotosResponse.Action = context.StringValue("RemoveAlbumPhotos.Action");

			List<RemoveAlbumPhotosResponse.RemoveAlbumPhotos_Result> removeAlbumPhotosResponse_results = new List<RemoveAlbumPhotosResponse.RemoveAlbumPhotos_Result>();
			for (int i = 0; i < context.Length("RemoveAlbumPhotos.Results.Length"); i++) {
				RemoveAlbumPhotosResponse.RemoveAlbumPhotos_Result result = new RemoveAlbumPhotosResponse.RemoveAlbumPhotos_Result();
				result.Id = context.LongValue("RemoveAlbumPhotos.Results["+ i +"].Id");
				result.IdStr = context.StringValue("RemoveAlbumPhotos.Results["+ i +"].IdStr");
				result.Code = context.StringValue("RemoveAlbumPhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("RemoveAlbumPhotos.Results["+ i +"].Message");

				removeAlbumPhotosResponse_results.Add(result);
			}
			removeAlbumPhotosResponse.Results = removeAlbumPhotosResponse_results;
        
			return removeAlbumPhotosResponse;
        }
    }
}
