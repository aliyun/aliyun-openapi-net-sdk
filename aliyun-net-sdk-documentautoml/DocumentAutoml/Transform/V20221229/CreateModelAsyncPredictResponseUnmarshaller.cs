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
using Aliyun.Acs.documentAutoml.Model.V20221229;

namespace Aliyun.Acs.documentAutoml.Transform.V20221229
{
    public class CreateModelAsyncPredictResponseUnmarshaller
    {
        public static CreateModelAsyncPredictResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateModelAsyncPredictResponse createModelAsyncPredictResponse = new CreateModelAsyncPredictResponse();

			createModelAsyncPredictResponse.HttpResponse = _ctx.HttpResponse;
			createModelAsyncPredictResponse.RequestId = _ctx.StringValue("CreateModelAsyncPredict.RequestId");
			createModelAsyncPredictResponse.Code = _ctx.IntegerValue("CreateModelAsyncPredict.Code");
			createModelAsyncPredictResponse.Message = _ctx.StringValue("CreateModelAsyncPredict.Message");
			createModelAsyncPredictResponse.Data = _ctx.StringValue("CreateModelAsyncPredict.Data");
        
			return createModelAsyncPredictResponse;
        }
    }
}
