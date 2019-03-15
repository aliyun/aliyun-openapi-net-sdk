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
    public class ListFacePhotosResponseUnmarshaller
    {
        public static ListFacePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListFacePhotosResponse listFacePhotosResponse = new ListFacePhotosResponse();

			listFacePhotosResponse.HttpResponse = context.HttpResponse;
			listFacePhotosResponse.Code = context.StringValue("ListFacePhotos.Code");
			listFacePhotosResponse.Message = context.StringValue("ListFacePhotos.Message");
			listFacePhotosResponse.NextCursor = context.StringValue("ListFacePhotos.NextCursor");
			listFacePhotosResponse.TotalCount = context.IntegerValue("ListFacePhotos.TotalCount");
			listFacePhotosResponse.RequestId = context.StringValue("ListFacePhotos.RequestId");
			listFacePhotosResponse.Action = context.StringValue("ListFacePhotos.Action");

			List<ListFacePhotosResponse.ListFacePhotos_Result> listFacePhotosResponse_results = new List<ListFacePhotosResponse.ListFacePhotos_Result>();
			for (int i = 0; i < context.Length("ListFacePhotos.Results.Length"); i++) {
				ListFacePhotosResponse.ListFacePhotos_Result result = new ListFacePhotosResponse.ListFacePhotos_Result();
				result.PhotoId = context.LongValue("ListFacePhotos.Results["+ i +"].PhotoId");
				result.PhotoIdStr = context.StringValue("ListFacePhotos.Results["+ i +"].PhotoIdStr");
				result.Mtime = context.LongValue("ListFacePhotos.Results["+ i +"].Mtime");
				result.State = context.StringValue("ListFacePhotos.Results["+ i +"].State");

				listFacePhotosResponse_results.Add(result);
			}
			listFacePhotosResponse.Results = listFacePhotosResponse_results;
        
			return listFacePhotosResponse;
        }
    }
}
