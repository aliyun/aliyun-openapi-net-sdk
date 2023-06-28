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
    public class PredictClassifierModelResponseUnmarshaller
    {
        public static PredictClassifierModelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PredictClassifierModelResponse predictClassifierModelResponse = new PredictClassifierModelResponse();

			predictClassifierModelResponse.HttpResponse = _ctx.HttpResponse;
			predictClassifierModelResponse.RequestId = _ctx.StringValue("PredictClassifierModel.RequestId");
			predictClassifierModelResponse.Code = _ctx.IntegerValue("PredictClassifierModel.Code");
			predictClassifierModelResponse.Data = _ctx.StringValue("PredictClassifierModel.Data");
			predictClassifierModelResponse.Message = _ctx.StringValue("PredictClassifierModel.Message");
        
			return predictClassifierModelResponse;
        }
    }
}
