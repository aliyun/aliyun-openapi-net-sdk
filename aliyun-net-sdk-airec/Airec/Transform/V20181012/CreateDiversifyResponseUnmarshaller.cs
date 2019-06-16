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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class CreateDiversifyResponseUnmarshaller
    {
        public static CreateDiversifyResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDiversifyResponse createDiversifyResponse = new CreateDiversifyResponse();

			createDiversifyResponse.HttpResponse = context.HttpResponse;
			createDiversifyResponse.RequestId = context.StringValue("CreateDiversify.RequestId");
			createDiversifyResponse.Code = context.StringValue("CreateDiversify.Code");
			createDiversifyResponse.Message = context.StringValue("CreateDiversify.Message");

			CreateDiversifyResponse.CreateDiversify_Result result = new CreateDiversifyResponse.CreateDiversify_Result();
			result.Name = context.StringValue("CreateDiversify.Result.Name");
			result.GmtCreate = context.StringValue("CreateDiversify.Result.GmtCreate");
			result.GmtModified = context.StringValue("CreateDiversify.Result.GmtModified");

			CreateDiversifyResponse.CreateDiversify_Result.CreateDiversify_Parameter parameter = new CreateDiversifyResponse.CreateDiversify_Result.CreateDiversify_Parameter();
			parameter.CategoryIndex = context.IntegerValue("CreateDiversify.Result.Parameter.CategoryIndex");
			parameter.Window = context.IntegerValue("CreateDiversify.Result.Parameter.Window");
			result.Parameter = parameter;
			createDiversifyResponse.Result = result;
        
			return createDiversifyResponse;
        }
    }
}
