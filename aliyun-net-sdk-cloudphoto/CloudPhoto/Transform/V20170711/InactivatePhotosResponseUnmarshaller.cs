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
    public class InactivatePhotosResponseUnmarshaller
    {
        public static InactivatePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			InactivatePhotosResponse inactivatePhotosResponse = new InactivatePhotosResponse();

			inactivatePhotosResponse.HttpResponse = context.HttpResponse;
			inactivatePhotosResponse.Code = context.StringValue("InactivatePhotos.Code");
			inactivatePhotosResponse.Message = context.StringValue("InactivatePhotos.Message");
			inactivatePhotosResponse.RequestId = context.StringValue("InactivatePhotos.RequestId");
			inactivatePhotosResponse.Action = context.StringValue("InactivatePhotos.Action");

			List<InactivatePhotosResponse.InactivatePhotos_Result> inactivatePhotosResponse_results = new List<InactivatePhotosResponse.InactivatePhotos_Result>();
			for (int i = 0; i < context.Length("InactivatePhotos.Results.Length"); i++) {
				InactivatePhotosResponse.InactivatePhotos_Result result = new InactivatePhotosResponse.InactivatePhotos_Result();
				result.Id = context.LongValue("InactivatePhotos.Results["+ i +"].Id");
				result.IdStr = context.StringValue("InactivatePhotos.Results["+ i +"].IdStr");
				result.Code = context.StringValue("InactivatePhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("InactivatePhotos.Results["+ i +"].Message");

				inactivatePhotosResponse_results.Add(result);
			}
			inactivatePhotosResponse.Results = inactivatePhotosResponse_results;
        
			return inactivatePhotosResponse;
        }
    }
}
