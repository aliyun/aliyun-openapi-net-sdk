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
    public class ActivatePhotosResponseUnmarshaller
    {
        public static ActivatePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ActivatePhotosResponse activatePhotosResponse = new ActivatePhotosResponse();

			activatePhotosResponse.HttpResponse = context.HttpResponse;
			activatePhotosResponse.Code = context.StringValue("ActivatePhotos.Code");
			activatePhotosResponse.Message = context.StringValue("ActivatePhotos.Message");
			activatePhotosResponse.RequestId = context.StringValue("ActivatePhotos.RequestId");
			activatePhotosResponse.Action = context.StringValue("ActivatePhotos.Action");

			List<ActivatePhotosResponse.ActivatePhotos_Result> activatePhotosResponse_results = new List<ActivatePhotosResponse.ActivatePhotos_Result>();
			for (int i = 0; i < context.Length("ActivatePhotos.Results.Length"); i++) {
				ActivatePhotosResponse.ActivatePhotos_Result result = new ActivatePhotosResponse.ActivatePhotos_Result();
				result.Id = context.LongValue("ActivatePhotos.Results["+ i +"].Id");
				result.Code = context.StringValue("ActivatePhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("ActivatePhotos.Results["+ i +"].Message");

				activatePhotosResponse_results.Add(result);
			}
			activatePhotosResponse.Results = activatePhotosResponse_results;
        
			return activatePhotosResponse;
        }
    }
}