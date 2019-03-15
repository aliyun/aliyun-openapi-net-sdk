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
    public class ListTagPhotosResponseUnmarshaller
    {
        public static ListTagPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagPhotosResponse listTagPhotosResponse = new ListTagPhotosResponse();

			listTagPhotosResponse.HttpResponse = context.HttpResponse;
			listTagPhotosResponse.Code = context.StringValue("ListTagPhotos.Code");
			listTagPhotosResponse.Message = context.StringValue("ListTagPhotos.Message");
			listTagPhotosResponse.NextCursor = context.StringValue("ListTagPhotos.NextCursor");
			listTagPhotosResponse.TotalCount = context.IntegerValue("ListTagPhotos.TotalCount");
			listTagPhotosResponse.RequestId = context.StringValue("ListTagPhotos.RequestId");
			listTagPhotosResponse.Action = context.StringValue("ListTagPhotos.Action");

			List<ListTagPhotosResponse.ListTagPhotos_Result> listTagPhotosResponse_results = new List<ListTagPhotosResponse.ListTagPhotos_Result>();
			for (int i = 0; i < context.Length("ListTagPhotos.Results.Length"); i++) {
				ListTagPhotosResponse.ListTagPhotos_Result result = new ListTagPhotosResponse.ListTagPhotos_Result();
				result.PhotoId = context.LongValue("ListTagPhotos.Results["+ i +"].PhotoId");
				result.PhotoIdStr = context.StringValue("ListTagPhotos.Results["+ i +"].PhotoIdStr");
				result.State = context.StringValue("ListTagPhotos.Results["+ i +"].State");

				listTagPhotosResponse_results.Add(result);
			}
			listTagPhotosResponse.Results = listTagPhotosResponse_results;
        
			return listTagPhotosResponse;
        }
    }
}
