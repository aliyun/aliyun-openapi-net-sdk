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
    public class AllocateCostUnitResourceResponseUnmarshaller
    {
        public static AllocateCostUnitResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AllocateCostUnitResourceResponse allocateCostUnitResourceResponse = new AllocateCostUnitResourceResponse();

			allocateCostUnitResourceResponse.HttpResponse = _ctx.HttpResponse;
			allocateCostUnitResourceResponse.RequestId = _ctx.StringValue("AllocateCostUnitResource.RequestId");
			allocateCostUnitResourceResponse.Message = _ctx.StringValue("AllocateCostUnitResource.Message");
			allocateCostUnitResourceResponse.Code = _ctx.StringValue("AllocateCostUnitResource.Code");
			allocateCostUnitResourceResponse.Success = _ctx.BooleanValue("AllocateCostUnitResource.Success");

			AllocateCostUnitResourceResponse.AllocateCostUnitResource_Data data = new AllocateCostUnitResourceResponse.AllocateCostUnitResource_Data();
			data.IsSuccess = _ctx.BooleanValue("AllocateCostUnitResource.Data.IsSuccess");
			data.ToUnitUserId = _ctx.LongValue("AllocateCostUnitResource.Data.ToUnitUserId");
			data.ToUnitId = _ctx.LongValue("AllocateCostUnitResource.Data.ToUnitId");
			allocateCostUnitResourceResponse.Data = data;
        
			return allocateCostUnitResourceResponse;
        }
    }
}
