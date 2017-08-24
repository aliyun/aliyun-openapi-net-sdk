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
    public class ListMomentPhotosResponseUnmarshaller
    {
        public static ListMomentPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListMomentPhotosResponse listMomentPhotosResponse = new ListMomentPhotosResponse();

			listMomentPhotosResponse.HttpResponse = context.HttpResponse;
			listMomentPhotosResponse.Code = context.StringValue("ListMomentPhotos.Code");
			listMomentPhotosResponse.Message = context.StringValue("ListMomentPhotos.Message");
			listMomentPhotosResponse.NextCursor = context.StringValue("ListMomentPhotos.NextCursor");
			listMomentPhotosResponse.TotalCount = context.IntegerValue("ListMomentPhotos.TotalCount");
			listMomentPhotosResponse.RequestId = context.StringValue("ListMomentPhotos.RequestId");
			listMomentPhotosResponse.Action = context.StringValue("ListMomentPhotos.Action");

			List<ListMomentPhotosResponse.ListMomentPhotos_Result> listMomentPhotosResponse_results = new List<ListMomentPhotosResponse.ListMomentPhotos_Result>();
			for (int i = 0; i < context.Length("ListMomentPhotos.Results.Length"); i++) {
				ListMomentPhotosResponse.ListMomentPhotos_Result result = new ListMomentPhotosResponse.ListMomentPhotos_Result();
				result.PhotoId = context.LongValue("ListMomentPhotos.Results["+ i +"].PhotoId");
				result.State = context.StringValue("ListMomentPhotos.Results["+ i +"].State");

				listMomentPhotosResponse_results.Add(result);
			}
			listMomentPhotosResponse.Results = listMomentPhotosResponse_results;
        
			return listMomentPhotosResponse;
        }
    }
}