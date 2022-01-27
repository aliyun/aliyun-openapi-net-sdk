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
using Aliyun.Acs.nlp_automl.Model.V20191111;

namespace Aliyun.Acs.nlp_automl.Transform.V20191111
{
    public class GetModelResponseUnmarshaller
    {
        public static GetModelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetModelResponse getModelResponse = new GetModelResponse();

			getModelResponse.HttpResponse = _ctx.HttpResponse;
			getModelResponse.RequestId = _ctx.StringValue("GetModel.RequestId");
			getModelResponse.Data = _ctx.StringValue("GetModel.Data");
			getModelResponse.Code = _ctx.IntegerValue("GetModel.Code");
			getModelResponse.Message = _ctx.StringValue("GetModel.Message");
			getModelResponse.Success = _ctx.BooleanValue("GetModel.Success");
        
			return getModelResponse;
        }
    }
}
