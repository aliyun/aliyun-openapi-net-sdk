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
    public class GetSortScriptFileResponseUnmarshaller
    {
        public static GetSortScriptFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSortScriptFileResponse getSortScriptFileResponse = new GetSortScriptFileResponse();

			getSortScriptFileResponse.HttpResponse = _ctx.HttpResponse;
			getSortScriptFileResponse.RequestId = _ctx.StringValue("GetSortScriptFile.requestId");

			GetSortScriptFileResponse.GetSortScriptFile_Result result = new GetSortScriptFileResponse.GetSortScriptFile_Result();
			result.Content = _ctx.StringValue("GetSortScriptFile.Result.content");
			result.Version = _ctx.LongValue("GetSortScriptFile.Result.version");
			result.CreateTime = _ctx.StringValue("GetSortScriptFile.Result.createTime");
			result.ModifyTime = _ctx.StringValue("GetSortScriptFile.Result.modifyTime");
			getSortScriptFileResponse.Result = result;
        
			return getSortScriptFileResponse;
        }
    }
}
