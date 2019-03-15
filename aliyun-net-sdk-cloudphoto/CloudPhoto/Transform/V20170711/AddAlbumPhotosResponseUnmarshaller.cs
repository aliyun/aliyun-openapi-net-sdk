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
    public class AddAlbumPhotosResponseUnmarshaller
    {
        public static AddAlbumPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			AddAlbumPhotosResponse addAlbumPhotosResponse = new AddAlbumPhotosResponse();

			addAlbumPhotosResponse.HttpResponse = context.HttpResponse;
			addAlbumPhotosResponse.Code = context.StringValue("AddAlbumPhotos.Code");
			addAlbumPhotosResponse.Message = context.StringValue("AddAlbumPhotos.Message");
			addAlbumPhotosResponse.RequestId = context.StringValue("AddAlbumPhotos.RequestId");
			addAlbumPhotosResponse.Action = context.StringValue("AddAlbumPhotos.Action");

			List<AddAlbumPhotosResponse.AddAlbumPhotos_Result> addAlbumPhotosResponse_results = new List<AddAlbumPhotosResponse.AddAlbumPhotos_Result>();
			for (int i = 0; i < context.Length("AddAlbumPhotos.Results.Length"); i++) {
				AddAlbumPhotosResponse.AddAlbumPhotos_Result result = new AddAlbumPhotosResponse.AddAlbumPhotos_Result();
				result.Id = context.LongValue("AddAlbumPhotos.Results["+ i +"].Id");
				result.IdStr = context.StringValue("AddAlbumPhotos.Results["+ i +"].IdStr");
				result.Code = context.StringValue("AddAlbumPhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("AddAlbumPhotos.Results["+ i +"].Message");

				addAlbumPhotosResponse_results.Add(result);
			}
			addAlbumPhotosResponse.Results = addAlbumPhotosResponse_results;
        
			return addAlbumPhotosResponse;
        }
    }
}
