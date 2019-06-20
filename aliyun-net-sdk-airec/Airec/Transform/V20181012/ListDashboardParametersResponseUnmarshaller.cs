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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class ListDashboardParametersResponseUnmarshaller
    {
        public static ListDashboardParametersResponse Unmarshall(UnmarshallerContext context)
        {
			ListDashboardParametersResponse listDashboardParametersResponse = new ListDashboardParametersResponse();

			listDashboardParametersResponse.HttpResponse = context.HttpResponse;
			listDashboardParametersResponse.RequestId = context.StringValue("ListDashboardParameters.RequestId");
			listDashboardParametersResponse.Code = context.StringValue("ListDashboardParameters.Code");
			listDashboardParametersResponse.Message = context.StringValue("ListDashboardParameters.Message");

			ListDashboardParametersResponse.ListDashboardParameters_Result result = new ListDashboardParametersResponse.ListDashboardParameters_Result();

			List<string> result_traceId = new List<string>();
			for (int i = 0; i < context.Length("ListDashboardParameters.Result.TraceId.Length"); i++) {
				result_traceId.Add(context.StringValue("ListDashboardParameters.Result.TraceId["+ i +"]"));
			}
			result.TraceId = result_traceId;

			List<string> result_sceneId = new List<string>();
			for (int i = 0; i < context.Length("ListDashboardParameters.Result.SceneId.Length"); i++) {
				result_sceneId.Add(context.StringValue("ListDashboardParameters.Result.SceneId["+ i +"]"));
			}
			result.SceneId = result_sceneId;
			listDashboardParametersResponse.Result = result;
        
			return listDashboardParametersResponse;
        }
    }
}
