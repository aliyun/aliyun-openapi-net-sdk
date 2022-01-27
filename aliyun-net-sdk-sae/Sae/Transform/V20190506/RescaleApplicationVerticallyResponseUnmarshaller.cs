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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class RescaleApplicationVerticallyResponseUnmarshaller
    {
        public static RescaleApplicationVerticallyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RescaleApplicationVerticallyResponse rescaleApplicationVerticallyResponse = new RescaleApplicationVerticallyResponse();

			rescaleApplicationVerticallyResponse.HttpResponse = _ctx.HttpResponse;
			rescaleApplicationVerticallyResponse.RequestId = _ctx.StringValue("RescaleApplicationVertically.RequestId");
			rescaleApplicationVerticallyResponse.Code = _ctx.StringValue("RescaleApplicationVertically.Code");
			rescaleApplicationVerticallyResponse.Success = _ctx.BooleanValue("RescaleApplicationVertically.Success");
			rescaleApplicationVerticallyResponse.ErrorCode = _ctx.StringValue("RescaleApplicationVertically.ErrorCode");
			rescaleApplicationVerticallyResponse.Message = _ctx.StringValue("RescaleApplicationVertically.Message");
			rescaleApplicationVerticallyResponse.TraceId = _ctx.StringValue("RescaleApplicationVertically.TraceId");

			RescaleApplicationVerticallyResponse.RescaleApplicationVertically_Data data = new RescaleApplicationVerticallyResponse.RescaleApplicationVertically_Data();
			data.ChangeOrderId = _ctx.StringValue("RescaleApplicationVertically.Data.ChangeOrderId");
			rescaleApplicationVerticallyResponse.Data = data;
        
			return rescaleApplicationVerticallyResponse;
        }
    }
}
