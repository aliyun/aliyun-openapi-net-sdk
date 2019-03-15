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
    public class RemoveFacePhotosResponseUnmarshaller
    {
        public static RemoveFacePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			RemoveFacePhotosResponse removeFacePhotosResponse = new RemoveFacePhotosResponse();

			removeFacePhotosResponse.HttpResponse = context.HttpResponse;
			removeFacePhotosResponse.Code = context.StringValue("RemoveFacePhotos.Code");
			removeFacePhotosResponse.Message = context.StringValue("RemoveFacePhotos.Message");
			removeFacePhotosResponse.RequestId = context.StringValue("RemoveFacePhotos.RequestId");
			removeFacePhotosResponse.Action = context.StringValue("RemoveFacePhotos.Action");

			List<RemoveFacePhotosResponse.RemoveFacePhotos_Result> removeFacePhotosResponse_results = new List<RemoveFacePhotosResponse.RemoveFacePhotos_Result>();
			for (int i = 0; i < context.Length("RemoveFacePhotos.Results.Length"); i++) {
				RemoveFacePhotosResponse.RemoveFacePhotos_Result result = new RemoveFacePhotosResponse.RemoveFacePhotos_Result();
				result.Id = context.LongValue("RemoveFacePhotos.Results["+ i +"].Id");
				result.IdStr = context.StringValue("RemoveFacePhotos.Results["+ i +"].IdStr");
				result.Code = context.StringValue("RemoveFacePhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("RemoveFacePhotos.Results["+ i +"].Message");

				removeFacePhotosResponse_results.Add(result);
			}
			removeFacePhotosResponse.Results = removeFacePhotosResponse_results;
        
			return removeFacePhotosResponse;
        }
    }
}
