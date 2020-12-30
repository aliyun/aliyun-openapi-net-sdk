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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class UpdateEnvironmentResponseUnmarshaller
    {
        public static UpdateEnvironmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateEnvironmentResponse updateEnvironmentResponse = new UpdateEnvironmentResponse();

			updateEnvironmentResponse.HttpResponse = _ctx.HttpResponse;
			updateEnvironmentResponse.Code = _ctx.IntegerValue("UpdateEnvironment.Code");
			updateEnvironmentResponse.RequestId = _ctx.StringValue("UpdateEnvironment.RequestId");
			updateEnvironmentResponse.ErrMsg = _ctx.StringValue("UpdateEnvironment.ErrMsg");

			UpdateEnvironmentResponse.UpdateEnvironment_Result result = new UpdateEnvironmentResponse.UpdateEnvironment_Result();
			result.Success = _ctx.BooleanValue("UpdateEnvironment.Result.Success");
			updateEnvironmentResponse.Result = result;
        
			return updateEnvironmentResponse;
        }
    }
}
