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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class GetSortScriptResponseUnmarshaller
    {
        public static GetSortScriptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSortScriptResponse getSortScriptResponse = new GetSortScriptResponse();

			getSortScriptResponse.HttpResponse = _ctx.HttpResponse;
			getSortScriptResponse.RequestId = _ctx.StringValue("GetSortScript.requestId");

			GetSortScriptResponse.GetSortScript_Result result = new GetSortScriptResponse.GetSortScript_Result();
			result.Type = _ctx.StringValue("GetSortScript.Result.type");
			result.Scope = _ctx.StringValue("GetSortScript.Result.scope");
			result.Status = _ctx.StringValue("GetSortScript.Result.status");
			result.CreateTime = _ctx.StringValue("GetSortScript.Result.createTime");
			result.ModifyTime = _ctx.StringValue("GetSortScript.Result.modifyTime");
			getSortScriptResponse.Result = result;
        
			return getSortScriptResponse;
        }
    }
}
