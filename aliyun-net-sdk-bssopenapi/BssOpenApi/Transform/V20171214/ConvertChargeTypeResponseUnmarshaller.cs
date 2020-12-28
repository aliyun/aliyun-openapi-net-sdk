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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class ConvertChargeTypeResponseUnmarshaller
    {
        public static ConvertChargeTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConvertChargeTypeResponse convertChargeTypeResponse = new ConvertChargeTypeResponse();

			convertChargeTypeResponse.HttpResponse = _ctx.HttpResponse;
			convertChargeTypeResponse.RequestId = _ctx.StringValue("ConvertChargeType.RequestId");
			convertChargeTypeResponse.Success = _ctx.BooleanValue("ConvertChargeType.Success");
			convertChargeTypeResponse.Code = _ctx.StringValue("ConvertChargeType.Code");
			convertChargeTypeResponse.Message = _ctx.StringValue("ConvertChargeType.Message");

			ConvertChargeTypeResponse.ConvertChargeType_Data data = new ConvertChargeTypeResponse.ConvertChargeType_Data();
			data.OrderId = _ctx.StringValue("ConvertChargeType.Data.OrderId");
			convertChargeTypeResponse.Data = data;
        
			return convertChargeTypeResponse;
        }
    }
}
