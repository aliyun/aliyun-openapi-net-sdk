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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryFaceUserIdByCustomUserIdResponseUnmarshaller
    {
        public static QueryFaceUserIdByCustomUserIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceUserIdByCustomUserIdResponse queryFaceUserIdByCustomUserIdResponse = new QueryFaceUserIdByCustomUserIdResponse();

			queryFaceUserIdByCustomUserIdResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceUserIdByCustomUserIdResponse.Code = _ctx.StringValue("QueryFaceUserIdByCustomUserId.Code");
			queryFaceUserIdByCustomUserIdResponse.RequestId = _ctx.StringValue("QueryFaceUserIdByCustomUserId.RequestId");
			queryFaceUserIdByCustomUserIdResponse.ErrorMessage = _ctx.StringValue("QueryFaceUserIdByCustomUserId.ErrorMessage");
			queryFaceUserIdByCustomUserIdResponse.Success = _ctx.BooleanValue("QueryFaceUserIdByCustomUserId.Success");

			QueryFaceUserIdByCustomUserIdResponse.QueryFaceUserIdByCustomUserId_Data data = new QueryFaceUserIdByCustomUserIdResponse.QueryFaceUserIdByCustomUserId_Data();
			data._Params = _ctx.StringValue("QueryFaceUserIdByCustomUserId.Data.Params");
			data.CustomUserId = _ctx.StringValue("QueryFaceUserIdByCustomUserId.Data.CustomUserId");
			data.Name = _ctx.StringValue("QueryFaceUserIdByCustomUserId.Data.Name");
			data.UserId = _ctx.StringValue("QueryFaceUserIdByCustomUserId.Data.UserId");
			queryFaceUserIdByCustomUserIdResponse.Data = data;
        
			return queryFaceUserIdByCustomUserIdResponse;
        }
    }
}
