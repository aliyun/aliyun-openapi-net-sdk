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
    public class GetScriptFileNamesResponseUnmarshaller
    {
        public static GetScriptFileNamesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetScriptFileNamesResponse getScriptFileNamesResponse = new GetScriptFileNamesResponse();

			getScriptFileNamesResponse.HttpResponse = _ctx.HttpResponse;
			getScriptFileNamesResponse.RequestId = _ctx.StringValue("GetScriptFileNames.requestId");

			List<GetScriptFileNamesResponse.GetScriptFileNames_FileInfos> getScriptFileNamesResponse_result = new List<GetScriptFileNamesResponse.GetScriptFileNames_FileInfos>();
			for (int i = 0; i < _ctx.Length("GetScriptFileNames.Result.Length"); i++) {
				GetScriptFileNamesResponse.GetScriptFileNames_FileInfos fileInfos = new GetScriptFileNamesResponse.GetScriptFileNames_FileInfos();
				fileInfos.FileName = _ctx.StringValue("GetScriptFileNames.Result["+ i +"].fileName");
				fileInfos.CreateTime = _ctx.StringValue("GetScriptFileNames.Result["+ i +"].createTime");
				fileInfos.ModifyTime = _ctx.StringValue("GetScriptFileNames.Result["+ i +"].modifyTime");

				getScriptFileNamesResponse_result.Add(fileInfos);
			}
			getScriptFileNamesResponse.Result = getScriptFileNamesResponse_result;
        
			return getScriptFileNamesResponse;
        }
    }
}
