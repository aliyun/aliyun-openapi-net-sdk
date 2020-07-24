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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class CreateFileResponseUnmarshaller
    {
        public static CreateFileResponse Unmarshall(UnmarshallerContext context)
        {
			CreateFileResponse createFileResponse = new CreateFileResponse();

			createFileResponse.HttpResponse = context.HttpResponse;
			createFileResponse.RequestId = context.StringValue("CreateFile.RequestId");
			createFileResponse.ErrorCode = context.StringValue("CreateFile.ErrorCode");
			createFileResponse.Success = context.BooleanValue("CreateFile.Success");
			createFileResponse.ErrorMessage = context.StringValue("CreateFile.ErrorMessage");

			CreateFileResponse.CreateFile_Result result = new CreateFileResponse.CreateFile_Result();
			result.BranchName = context.StringValue("CreateFile.Result.BranchName");
			result.FilePath = context.StringValue("CreateFile.Result.FilePath");
			createFileResponse.Result = result;
        
			return createFileResponse;
        }
    }
}
