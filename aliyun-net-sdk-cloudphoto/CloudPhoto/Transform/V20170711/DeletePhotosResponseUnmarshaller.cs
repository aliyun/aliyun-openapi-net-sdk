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
    public class DeletePhotosResponseUnmarshaller
    {
        public static DeletePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			DeletePhotosResponse deletePhotosResponse = new DeletePhotosResponse();

			deletePhotosResponse.HttpResponse = context.HttpResponse;
			deletePhotosResponse.Code = context.StringValue("DeletePhotos.Code");
			deletePhotosResponse.Message = context.StringValue("DeletePhotos.Message");
			deletePhotosResponse.RequestId = context.StringValue("DeletePhotos.RequestId");
			deletePhotosResponse.Action = context.StringValue("DeletePhotos.Action");

			List<DeletePhotosResponse.DeletePhotos_Result> deletePhotosResponse_results = new List<DeletePhotosResponse.DeletePhotos_Result>();
			for (int i = 0; i < context.Length("DeletePhotos.Results.Length"); i++) {
				DeletePhotosResponse.DeletePhotos_Result result = new DeletePhotosResponse.DeletePhotos_Result();
				result.Id = context.LongValue("DeletePhotos.Results["+ i +"].Id");
				result.IdStr = context.StringValue("DeletePhotos.Results["+ i +"].IdStr");
				result.Code = context.StringValue("DeletePhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("DeletePhotos.Results["+ i +"].Message");

				deletePhotosResponse_results.Add(result);
			}
			deletePhotosResponse.Results = deletePhotosResponse_results;
        
			return deletePhotosResponse;
        }
    }
}