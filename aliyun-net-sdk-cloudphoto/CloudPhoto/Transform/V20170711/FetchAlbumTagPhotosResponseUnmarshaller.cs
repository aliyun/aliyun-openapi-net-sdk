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
    public class FetchAlbumTagPhotosResponseUnmarshaller
    {
        public static FetchAlbumTagPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			FetchAlbumTagPhotosResponse fetchAlbumTagPhotosResponse = new FetchAlbumTagPhotosResponse();

			fetchAlbumTagPhotosResponse.HttpResponse = context.HttpResponse;
			fetchAlbumTagPhotosResponse.Code = context.StringValue("FetchAlbumTagPhotos.Code");
			fetchAlbumTagPhotosResponse.Message = context.StringValue("FetchAlbumTagPhotos.Message");
			fetchAlbumTagPhotosResponse.TotalCount = context.IntegerValue("FetchAlbumTagPhotos.TotalCount");
			fetchAlbumTagPhotosResponse.RequestId = context.StringValue("FetchAlbumTagPhotos.RequestId");
			fetchAlbumTagPhotosResponse.Action = context.StringValue("FetchAlbumTagPhotos.Action");

			List<FetchAlbumTagPhotosResponse.FetchAlbumTagPhotos_Result> fetchAlbumTagPhotosResponse_results = new List<FetchAlbumTagPhotosResponse.FetchAlbumTagPhotos_Result>();
			for (int i = 0; i < context.Length("FetchAlbumTagPhotos.Results.Length"); i++) {
				FetchAlbumTagPhotosResponse.FetchAlbumTagPhotos_Result result = new FetchAlbumTagPhotosResponse.FetchAlbumTagPhotos_Result();
				result.PhotoId = context.LongValue("FetchAlbumTagPhotos.Results["+ i +"].PhotoId");
				result.PhotoIdStr = context.StringValue("FetchAlbumTagPhotos.Results["+ i +"].PhotoIdStr");
				result.Mtime = context.LongValue("FetchAlbumTagPhotos.Results["+ i +"].Mtime");
				result.State = context.StringValue("FetchAlbumTagPhotos.Results["+ i +"].State");

				fetchAlbumTagPhotosResponse_results.Add(result);
			}
			fetchAlbumTagPhotosResponse.Results = fetchAlbumTagPhotosResponse_results;
        
			return fetchAlbumTagPhotosResponse;
        }
    }
}