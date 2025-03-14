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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListCollectionsResponseUnmarshaller
    {
        public static ListCollectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCollectionsResponse listCollectionsResponse = new ListCollectionsResponse();

			listCollectionsResponse.HttpResponse = _ctx.HttpResponse;
			listCollectionsResponse.Success = _ctx.BooleanValue("ListCollections.Success");
			listCollectionsResponse.RequestId = _ctx.StringValue("ListCollections.RequestId");

			List<ListCollectionsResponse.ListCollections_Data> listCollectionsResponse_result = new List<ListCollectionsResponse.ListCollections_Data>();
			for (int i = 0; i < _ctx.Length("ListCollections.Result.Length"); i++) {
				ListCollectionsResponse.ListCollections_Data data = new ListCollectionsResponse.ListCollections_Data();
				data.FavoriteId = _ctx.IntegerValue("ListCollections.Result["+ i +"].FavoriteId");
				data.OwnerId = _ctx.StringValue("ListCollections.Result["+ i +"].OwnerId");
				data.WorksId = _ctx.StringValue("ListCollections.Result["+ i +"].WorksId");
				data.WorksName = _ctx.StringValue("ListCollections.Result["+ i +"].WorksName");
				data.WorksType = _ctx.StringValue("ListCollections.Result["+ i +"].WorksType");
				data.WorkspaceId = _ctx.StringValue("ListCollections.Result["+ i +"].WorkspaceId");
				data.WorkspaceName = _ctx.StringValue("ListCollections.Result["+ i +"].WorkspaceName");

				listCollectionsResponse_result.Add(data);
			}
			listCollectionsResponse.Result = listCollectionsResponse_result;
        
			return listCollectionsResponse;
        }
    }
}
