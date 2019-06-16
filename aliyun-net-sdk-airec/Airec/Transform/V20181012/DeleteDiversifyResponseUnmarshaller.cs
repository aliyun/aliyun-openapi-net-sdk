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
    public class DeleteDiversifyResponseUnmarshaller
    {
        public static DeleteDiversifyResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteDiversifyResponse deleteDiversifyResponse = new DeleteDiversifyResponse();

			deleteDiversifyResponse.HttpResponse = context.HttpResponse;
			deleteDiversifyResponse.RequestId = context.StringValue("DeleteDiversify.RequestId");
			deleteDiversifyResponse.Code = context.StringValue("DeleteDiversify.Code");
			deleteDiversifyResponse.Message = context.StringValue("DeleteDiversify.Message");

			DeleteDiversifyResponse.DeleteDiversify_Result result = new DeleteDiversifyResponse.DeleteDiversify_Result();
			result.Name = context.StringValue("DeleteDiversify.Result.Name");
			result.GmtCreate = context.StringValue("DeleteDiversify.Result.GmtCreate");
			result.GmtModified = context.StringValue("DeleteDiversify.Result.GmtModified");

			DeleteDiversifyResponse.DeleteDiversify_Result.DeleteDiversify_Parameter parameter = new DeleteDiversifyResponse.DeleteDiversify_Result.DeleteDiversify_Parameter();
			parameter.CategoryIndex = context.IntegerValue("DeleteDiversify.Result.Parameter.CategoryIndex");
			parameter.Window = context.IntegerValue("DeleteDiversify.Result.Parameter.Window");
			result.Parameter = parameter;
			deleteDiversifyResponse.Result = result;
        
			return deleteDiversifyResponse;
        }
    }
}
