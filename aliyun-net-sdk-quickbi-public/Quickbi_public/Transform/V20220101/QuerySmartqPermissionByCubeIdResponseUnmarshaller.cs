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
    public class QuerySmartqPermissionByCubeIdResponseUnmarshaller
    {
        public static QuerySmartqPermissionByCubeIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySmartqPermissionByCubeIdResponse querySmartqPermissionByCubeIdResponse = new QuerySmartqPermissionByCubeIdResponse();

			querySmartqPermissionByCubeIdResponse.HttpResponse = _ctx.HttpResponse;
			querySmartqPermissionByCubeIdResponse.RequestId = _ctx.StringValue("QuerySmartqPermissionByCubeId.RequestId");
			querySmartqPermissionByCubeIdResponse.Success = _ctx.BooleanValue("QuerySmartqPermissionByCubeId.Success");

			QuerySmartqPermissionByCubeIdResponse.QuerySmartqPermissionByCubeId_Result result = new QuerySmartqPermissionByCubeIdResponse.QuerySmartqPermissionByCubeId_Result();
			result.HasPerssion = _ctx.BooleanValue("QuerySmartqPermissionByCubeId.Result.HasPerssion");
			result.CubeId = _ctx.StringValue("QuerySmartqPermissionByCubeId.Result.CubeId");
			result.CubeName = _ctx.StringValue("QuerySmartqPermissionByCubeId.Result.CubeName");
			querySmartqPermissionByCubeIdResponse.Result = result;
        
			return querySmartqPermissionByCubeIdResponse;
        }
    }
}
