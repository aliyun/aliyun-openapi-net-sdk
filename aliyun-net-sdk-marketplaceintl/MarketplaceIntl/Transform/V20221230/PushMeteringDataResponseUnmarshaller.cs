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
using Aliyun.Acs.marketplaceIntl.Model.V20221230;

namespace Aliyun.Acs.marketplaceIntl.Transform.V20221230
{
    public class PushMeteringDataResponseUnmarshaller
    {
        public static PushMeteringDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PushMeteringDataResponse pushMeteringDataResponse = new PushMeteringDataResponse();

			pushMeteringDataResponse.HttpResponse = _ctx.HttpResponse;
			pushMeteringDataResponse.Result = _ctx.BooleanValue("PushMeteringData.Result");
			pushMeteringDataResponse.Success = _ctx.BooleanValue("PushMeteringData.Success");
			pushMeteringDataResponse.Code = _ctx.StringValue("PushMeteringData.Code");
			pushMeteringDataResponse.Message = _ctx.StringValue("PushMeteringData.Message");
			pushMeteringDataResponse.RequestId = _ctx.StringValue("PushMeteringData.RequestId");
			pushMeteringDataResponse.ForceFatal = _ctx.BooleanValue("PushMeteringData.ForceFatal");
			pushMeteringDataResponse.DynamicMessage = _ctx.StringValue("PushMeteringData.DynamicMessage");
        
			return pushMeteringDataResponse;
        }
    }
}
