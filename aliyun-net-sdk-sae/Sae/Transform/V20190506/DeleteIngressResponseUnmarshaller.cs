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
    public class DeleteIngressResponseUnmarshaller
    {
        public static DeleteIngressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteIngressResponse deleteIngressResponse = new DeleteIngressResponse();

			deleteIngressResponse.HttpResponse = _ctx.HttpResponse;
			deleteIngressResponse.RequestId = _ctx.StringValue("DeleteIngress.RequestId");
			deleteIngressResponse.Code = _ctx.StringValue("DeleteIngress.Code");
			deleteIngressResponse.Message = _ctx.StringValue("DeleteIngress.Message");
			deleteIngressResponse.Success = _ctx.BooleanValue("DeleteIngress.Success");
			deleteIngressResponse.ErrorCode = _ctx.StringValue("DeleteIngress.ErrorCode");
			deleteIngressResponse.TraceId = _ctx.StringValue("DeleteIngress.TraceId");

			DeleteIngressResponse.DeleteIngress_Data data = new DeleteIngressResponse.DeleteIngress_Data();
			data.IngressId = _ctx.LongValue("DeleteIngress.Data.IngressId");
			deleteIngressResponse.Data = data;
        
			return deleteIngressResponse;
        }
    }
}
