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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class CreatePostPayOrderResponseUnmarshaller
    {
        public static CreatePostPayOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePostPayOrderResponse createPostPayOrderResponse = new CreatePostPayOrderResponse();

			createPostPayOrderResponse.HttpResponse = _ctx.HttpResponse;
			createPostPayOrderResponse.Code = _ctx.IntegerValue("CreatePostPayOrder.Code");
			createPostPayOrderResponse.Message = _ctx.StringValue("CreatePostPayOrder.Message");
			createPostPayOrderResponse.RequestId = _ctx.StringValue("CreatePostPayOrder.RequestId");
			createPostPayOrderResponse.Success = _ctx.BooleanValue("CreatePostPayOrder.Success");
			createPostPayOrderResponse.OrderId = _ctx.StringValue("CreatePostPayOrder.OrderId");
        
			return createPostPayOrderResponse;
        }
    }
}
