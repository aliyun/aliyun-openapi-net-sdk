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
    public class MoveFacePhotosResponseUnmarshaller
    {
        public static MoveFacePhotosResponse Unmarshall(UnmarshallerContext context)
        {
			MoveFacePhotosResponse moveFacePhotosResponse = new MoveFacePhotosResponse();

			moveFacePhotosResponse.HttpResponse = context.HttpResponse;
			moveFacePhotosResponse.Code = context.StringValue("MoveFacePhotos.Code");
			moveFacePhotosResponse.Message = context.StringValue("MoveFacePhotos.Message");
			moveFacePhotosResponse.RequestId = context.StringValue("MoveFacePhotos.RequestId");
			moveFacePhotosResponse.Action = context.StringValue("MoveFacePhotos.Action");

			List<MoveFacePhotosResponse.MoveFacePhotos_Result> moveFacePhotosResponse_results = new List<MoveFacePhotosResponse.MoveFacePhotos_Result>();
			for (int i = 0; i < context.Length("MoveFacePhotos.Results.Length"); i++) {
				MoveFacePhotosResponse.MoveFacePhotos_Result result = new MoveFacePhotosResponse.MoveFacePhotos_Result();
				result.Id = context.LongValue("MoveFacePhotos.Results["+ i +"].Id");
				result.IdStr = context.StringValue("MoveFacePhotos.Results["+ i +"].IdStr");
				result.Code = context.StringValue("MoveFacePhotos.Results["+ i +"].Code");
				result.Message = context.StringValue("MoveFacePhotos.Results["+ i +"].Message");

				moveFacePhotosResponse_results.Add(result);
			}
			moveFacePhotosResponse.Results = moveFacePhotosResponse_results;
        
			return moveFacePhotosResponse;
        }
    }
}
