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
    public class UpdateIngressResponseUnmarshaller
    {
        public static UpdateIngressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateIngressResponse updateIngressResponse = new UpdateIngressResponse();

			updateIngressResponse.HttpResponse = _ctx.HttpResponse;
			updateIngressResponse.Message = _ctx.StringValue("UpdateIngress.Message");
			updateIngressResponse.RequestId = _ctx.StringValue("UpdateIngress.RequestId");
			updateIngressResponse.TraceId = _ctx.StringValue("UpdateIngress.TraceId");
			updateIngressResponse.ErrorCode = _ctx.StringValue("UpdateIngress.ErrorCode");
			updateIngressResponse.Code = _ctx.StringValue("UpdateIngress.Code");
			updateIngressResponse.Success = _ctx.BooleanValue("UpdateIngress.Success");

			UpdateIngressResponse.UpdateIngress_Data data = new UpdateIngressResponse.UpdateIngress_Data();
			data.IngressId = _ctx.LongValue("UpdateIngress.Data.IngressId");
			updateIngressResponse.Data = data;
        
			return updateIngressResponse;
        }
    }
}
