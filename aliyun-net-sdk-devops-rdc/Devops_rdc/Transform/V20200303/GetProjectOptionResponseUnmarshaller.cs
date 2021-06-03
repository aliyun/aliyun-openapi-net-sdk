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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetProjectOptionResponseUnmarshaller
    {
        public static GetProjectOptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectOptionResponse getProjectOptionResponse = new GetProjectOptionResponse();

			getProjectOptionResponse.HttpResponse = _ctx.HttpResponse;
			getProjectOptionResponse.Successful = _ctx.BooleanValue("GetProjectOption.Successful");
			getProjectOptionResponse.ErrorCode = _ctx.StringValue("GetProjectOption.ErrorCode");
			getProjectOptionResponse.ErrorMsg = _ctx.StringValue("GetProjectOption.ErrorMsg");
			getProjectOptionResponse.RequestId = _ctx.StringValue("GetProjectOption.RequestId");

			List<GetProjectOptionResponse.GetProjectOption_Option> getProjectOptionResponse_object = new List<GetProjectOptionResponse.GetProjectOption_Option>();
			for (int i = 0; i < _ctx.Length("GetProjectOption.Object.Length"); i++) {
				GetProjectOptionResponse.GetProjectOption_Option option = new GetProjectOptionResponse.GetProjectOption_Option();
				option.Name = _ctx.StringValue("GetProjectOption.Object["+ i +"].Name");
				option._Value = _ctx.StringValue("GetProjectOption.Object["+ i +"].Value");
				option.Kind = _ctx.StringValue("GetProjectOption.Object["+ i +"].Kind");
				option.ScopeName = _ctx.StringValue("GetProjectOption.Object["+ i +"].ScopeName");

				getProjectOptionResponse_object.Add(option);
			}
			getProjectOptionResponse._Object = getProjectOptionResponse_object;
        
			return getProjectOptionResponse;
        }
    }
}
