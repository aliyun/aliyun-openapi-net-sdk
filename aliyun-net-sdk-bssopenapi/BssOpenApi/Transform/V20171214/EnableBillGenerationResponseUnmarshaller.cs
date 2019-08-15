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
    public class EnableBillGenerationResponseUnmarshaller
    {
        public static EnableBillGenerationResponse Unmarshall(UnmarshallerContext context)
        {
			EnableBillGenerationResponse enableBillGenerationResponse = new EnableBillGenerationResponse();

			enableBillGenerationResponse.HttpResponse = context.HttpResponse;
			enableBillGenerationResponse.RequestId = context.StringValue("EnableBillGeneration.RequestId");
			enableBillGenerationResponse.Success = context.BooleanValue("EnableBillGeneration.Success");
			enableBillGenerationResponse.Code = context.StringValue("EnableBillGeneration.Code");
			enableBillGenerationResponse.Message = context.StringValue("EnableBillGeneration.Message");

			EnableBillGenerationResponse.EnableBillGeneration_Data data = new EnableBillGenerationResponse.EnableBillGeneration_Data();
			data.Boolean = context.BooleanValue("EnableBillGeneration.Data.Boolean");
			enableBillGenerationResponse.Data = data;
        
			return enableBillGenerationResponse;
        }
    }
}
