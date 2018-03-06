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
    public class ReactivatePhotosResponseUnmarshaller
    {
        public static ReactivatePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ReactivatePhotosResponse reactivatePhotosResponse = new ReactivatePhotosResponse();

			reactivatePhotosResponse.HttpResponse = context.HttpResponse;
			reactivatePhotosResponse.Code = context.StringValue("ReactivatePhotos.Code");
			reactivatePhotosResponse.Message = context.StringValue("ReactivatePhotos.Message");
			reactivatePhotosResponse.RequestId = context.StringValue("ReactivatePhotos.RequestId");
			reactivatePhotosResponse.Action = context.StringValue("ReactivatePhotos.Action");

			List<ReactivatePhotosResponse.ReactivatePhotos_Result> reactivatePhotosResponse_results = new List<ReactivatePhotosResponse.ReactivatePhotos_Result>();
			for (int i = 0; i < context.Length("ReactivatePhotos.Results.Length"); i++) {
				ReactivatePhotosResponse.ReactivatePhotos_Result result = new ReactivatePhotosResponse.ReactivatePhotos_Result();
				result.Id = context.LongValue("ReactivatePhotos.Results["+ i +"].Id");
				result.IdStr = context.StringValue("ReactivatePhotos.Results["+ i +"].IdStr");
				result.Code = context.StringValue("ReactivatePhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("ReactivatePhotos.Results["+ i +"].Message");

				reactivatePhotosResponse_results.Add(result);
			}
			reactivatePhotosResponse.Results = reactivatePhotosResponse_results;
        
			return reactivatePhotosResponse;
        }
    }
}