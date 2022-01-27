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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListSceneParametersResponseUnmarshaller
    {
        public static ListSceneParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSceneParametersResponse listSceneParametersResponse = new ListSceneParametersResponse();

			listSceneParametersResponse.HttpResponse = _ctx.HttpResponse;
			listSceneParametersResponse.Code = _ctx.StringValue("ListSceneParameters.code");
			listSceneParametersResponse.Message = _ctx.StringValue("ListSceneParameters.message");
			listSceneParametersResponse.RequestId = _ctx.StringValue("ListSceneParameters.requestId");

			ListSceneParametersResponse.ListSceneParameters_Result result = new ListSceneParametersResponse.ListSceneParameters_Result();

			List<string> result_sceneId = new List<string>();
			for (int i = 0; i < _ctx.Length("ListSceneParameters.Result.SceneId.Length"); i++) {
				result_sceneId.Add(_ctx.StringValue("ListSceneParameters.Result.SceneId["+ i +"]"));
			}
			result.SceneId = result_sceneId;

			List<string> result_traceId = new List<string>();
			for (int i = 0; i < _ctx.Length("ListSceneParameters.Result.TraceId.Length"); i++) {
				result_traceId.Add(_ctx.StringValue("ListSceneParameters.Result.TraceId["+ i +"]"));
			}
			result.TraceId = result_traceId;
			listSceneParametersResponse.Result = result;
        
			return listSceneParametersResponse;
        }
    }
}
