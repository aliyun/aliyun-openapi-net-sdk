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
    public class ModifyDiversifyResponseUnmarshaller
    {
        public static ModifyDiversifyResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyDiversifyResponse modifyDiversifyResponse = new ModifyDiversifyResponse();

			modifyDiversifyResponse.HttpResponse = context.HttpResponse;
			modifyDiversifyResponse.RequestId = context.StringValue("ModifyDiversify.RequestId");
			modifyDiversifyResponse.Code = context.StringValue("ModifyDiversify.Code");
			modifyDiversifyResponse.Message = context.StringValue("ModifyDiversify.Message");

			ModifyDiversifyResponse.ModifyDiversify_Result result = new ModifyDiversifyResponse.ModifyDiversify_Result();
			result.Name = context.StringValue("ModifyDiversify.Result.Name");
			result.GmtCreate = context.StringValue("ModifyDiversify.Result.GmtCreate");
			result.GmtModified = context.StringValue("ModifyDiversify.Result.GmtModified");

			ModifyDiversifyResponse.ModifyDiversify_Result.ModifyDiversify_Parameter parameter = new ModifyDiversifyResponse.ModifyDiversify_Result.ModifyDiversify_Parameter();
			parameter.CategoryIndex = context.IntegerValue("ModifyDiversify.Result.Parameter.CategoryIndex");
			parameter.Window = context.IntegerValue("ModifyDiversify.Result.Parameter.Window");
			result.Parameter = parameter;
			modifyDiversifyResponse.Result = result;
        
			return modifyDiversifyResponse;
        }
    }
}
