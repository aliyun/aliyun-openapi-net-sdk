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
    public class ModifyDashboardNl2sqlStatusResponseUnmarshaller
    {
        public static ModifyDashboardNl2sqlStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyDashboardNl2sqlStatusResponse modifyDashboardNl2sqlStatusResponse = new ModifyDashboardNl2sqlStatusResponse();

			modifyDashboardNl2sqlStatusResponse.HttpResponse = _ctx.HttpResponse;
			modifyDashboardNl2sqlStatusResponse.RequestId = _ctx.StringValue("ModifyDashboardNl2sqlStatus.RequestId");
			modifyDashboardNl2sqlStatusResponse.Success = _ctx.BooleanValue("ModifyDashboardNl2sqlStatus.Success");

			List<string> modifyDashboardNl2sqlStatusResponse_result = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyDashboardNl2sqlStatus.Result.Length"); i++) {
				modifyDashboardNl2sqlStatusResponse_result.Add(_ctx.StringValue("ModifyDashboardNl2sqlStatus.Result["+ i +"]"));
			}
			modifyDashboardNl2sqlStatusResponse.Result = modifyDashboardNl2sqlStatusResponse_result;
        
			return modifyDashboardNl2sqlStatusResponse;
        }
    }
}
