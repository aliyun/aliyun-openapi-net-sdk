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
    public class ListAlbumPhotosResponseUnmarshaller
    {
        public static ListAlbumPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListAlbumPhotosResponse listAlbumPhotosResponse = new ListAlbumPhotosResponse();

			listAlbumPhotosResponse.HttpResponse = context.HttpResponse;
			listAlbumPhotosResponse.Code = context.StringValue("ListAlbumPhotos.Code");
			listAlbumPhotosResponse.Message = context.StringValue("ListAlbumPhotos.Message");
			listAlbumPhotosResponse.NextCursor = context.StringValue("ListAlbumPhotos.NextCursor");
			listAlbumPhotosResponse.TotalCount = context.IntegerValue("ListAlbumPhotos.TotalCount");
			listAlbumPhotosResponse.RequestId = context.StringValue("ListAlbumPhotos.RequestId");
			listAlbumPhotosResponse.Action = context.StringValue("ListAlbumPhotos.Action");

			List<ListAlbumPhotosResponse.ListAlbumPhotos_Result> listAlbumPhotosResponse_results = new List<ListAlbumPhotosResponse.ListAlbumPhotos_Result>();
			for (int i = 0; i < context.Length("ListAlbumPhotos.Results.Length"); i++) {
				ListAlbumPhotosResponse.ListAlbumPhotos_Result result = new ListAlbumPhotosResponse.ListAlbumPhotos_Result();
				result.PhotoId = context.LongValue("ListAlbumPhotos.Results["+ i +"].PhotoId");
				result.State = context.StringValue("ListAlbumPhotos.Results["+ i +"].State");

				listAlbumPhotosResponse_results.Add(result);
			}
			listAlbumPhotosResponse.Results = listAlbumPhotosResponse_results;
        
			return listAlbumPhotosResponse;
        }
    }
}