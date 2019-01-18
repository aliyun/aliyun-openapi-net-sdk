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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DestroyConsortiumResponseUnmarshaller
    {
        public static DestroyConsortiumResponse Unmarshall(UnmarshallerContext context)
        {
			DestroyConsortiumResponse destroyConsortiumResponse = new DestroyConsortiumResponse();

			destroyConsortiumResponse.HttpResponse = context.HttpResponse;
			destroyConsortiumResponse.RequestId = context.StringValue("DestroyConsortium.RequestId");
			destroyConsortiumResponse.Success = context.BooleanValue("DestroyConsortium.Success");
			destroyConsortiumResponse.ErrorCode = context.IntegerValue("DestroyConsortium.ErrorCode");
			destroyConsortiumResponse.DynamicCode = context.StringValue("DestroyConsortium.DynamicCode");
			destroyConsortiumResponse.DynamicMessage = context.StringValue("DestroyConsortium.DynamicMessage");

			DestroyConsortiumResponse.DestroyConsortium_Result result = new DestroyConsortiumResponse.DestroyConsortium_Result();
			result.ConsortiumId = context.StringValue("DestroyConsortium.Result.ConsortiumId");
			result.Name = context.StringValue("DestroyConsortium.Result.Name");
			destroyConsortiumResponse.Result = result;
        
			return destroyConsortiumResponse;
        }
    }
}