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
    public class EditPhotosResponseUnmarshaller
    {
        public static EditPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			EditPhotosResponse editPhotosResponse = new EditPhotosResponse();

			editPhotosResponse.HttpResponse = context.HttpResponse;
			editPhotosResponse.Code = context.StringValue("EditPhotos.Code");
			editPhotosResponse.Message = context.StringValue("EditPhotos.Message");
			editPhotosResponse.RequestId = context.StringValue("EditPhotos.RequestId");
			editPhotosResponse.Action = context.StringValue("EditPhotos.Action");

			List<EditPhotosResponse.EditPhotos_Result> editPhotosResponse_results = new List<EditPhotosResponse.EditPhotos_Result>();
			for (int i = 0; i < context.Length("EditPhotos.Results.Length"); i++) {
				EditPhotosResponse.EditPhotos_Result result = new EditPhotosResponse.EditPhotos_Result();
				result.Id = context.LongValue("EditPhotos.Results["+ i +"].Id");
				result.Code = context.StringValue("EditPhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("EditPhotos.Results["+ i +"].Message");

				editPhotosResponse_results.Add(result);
			}
			editPhotosResponse.Results = editPhotosResponse_results;
        
			return editPhotosResponse;
        }
    }
}