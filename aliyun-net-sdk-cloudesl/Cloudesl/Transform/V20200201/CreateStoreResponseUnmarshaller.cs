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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class CreateStoreResponseUnmarshaller
    {
        public static CreateStoreResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateStoreResponse createStoreResponse = new CreateStoreResponse();

			createStoreResponse.HttpResponse = _ctx.HttpResponse;
			createStoreResponse.ErrorMessage = _ctx.StringValue("CreateStore.ErrorMessage");
			createStoreResponse.ErrorCode = _ctx.StringValue("CreateStore.ErrorCode");
			createStoreResponse.Message = _ctx.StringValue("CreateStore.Message");
			createStoreResponse.StoreId = _ctx.StringValue("CreateStore.StoreId");
			createStoreResponse.DynamicCode = _ctx.StringValue("CreateStore.DynamicCode");
			createStoreResponse.Code = _ctx.StringValue("CreateStore.Code");
			createStoreResponse.DynamicMessage = _ctx.StringValue("CreateStore.DynamicMessage");
			createStoreResponse.RequestId = _ctx.StringValue("CreateStore.RequestId");
			createStoreResponse.Success = _ctx.BooleanValue("CreateStore.Success");
        
			return createStoreResponse;
        }
    }
}
