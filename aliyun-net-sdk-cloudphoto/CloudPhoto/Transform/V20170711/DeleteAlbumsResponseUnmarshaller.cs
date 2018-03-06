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
    public class DeleteAlbumsResponseUnmarshaller
    {
        public static DeleteAlbumsResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteAlbumsResponse deleteAlbumsResponse = new DeleteAlbumsResponse();

			deleteAlbumsResponse.HttpResponse = context.HttpResponse;
			deleteAlbumsResponse.Code = context.StringValue("DeleteAlbums.Code");
			deleteAlbumsResponse.Message = context.StringValue("DeleteAlbums.Message");
			deleteAlbumsResponse.RequestId = context.StringValue("DeleteAlbums.RequestId");
			deleteAlbumsResponse.Action = context.StringValue("DeleteAlbums.Action");

			List<DeleteAlbumsResponse.DeleteAlbums_Result> deleteAlbumsResponse_results = new List<DeleteAlbumsResponse.DeleteAlbums_Result>();
			for (int i = 0; i < context.Length("DeleteAlbums.Results.Length"); i++) {
				DeleteAlbumsResponse.DeleteAlbums_Result result = new DeleteAlbumsResponse.DeleteAlbums_Result();
				result.Id = context.LongValue("DeleteAlbums.Results["+ i +"].Id");
				result.IdStr = context.StringValue("DeleteAlbums.Results["+ i +"].IdStr");
				result.Code = context.StringValue("DeleteAlbums.Results["+ i +"].Code");
				result.Message = context.StringValue("DeleteAlbums.Results["+ i +"].Message");

				deleteAlbumsResponse_results.Add(result);
			}
			deleteAlbumsResponse.Results = deleteAlbumsResponse_results;
        
			return deleteAlbumsResponse;
        }
    }
}