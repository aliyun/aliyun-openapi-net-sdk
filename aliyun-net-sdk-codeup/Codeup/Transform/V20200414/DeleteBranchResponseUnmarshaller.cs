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
    public class DeleteBranchResponseUnmarshaller
    {
        public static DeleteBranchResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteBranchResponse deleteBranchResponse = new DeleteBranchResponse();

			deleteBranchResponse.HttpResponse = context.HttpResponse;
			deleteBranchResponse.RequestId = context.StringValue("DeleteBranch.RequestId");
			deleteBranchResponse.ErrorCode = context.StringValue("DeleteBranch.ErrorCode");
			deleteBranchResponse.Success = context.BooleanValue("DeleteBranch.Success");
			deleteBranchResponse.ErrorMessage = context.StringValue("DeleteBranch.ErrorMessage");

			DeleteBranchResponse.DeleteBranch_Result result = new DeleteBranchResponse.DeleteBranch_Result();
			result.BranchName = context.StringValue("DeleteBranch.Result.BranchName");
			deleteBranchResponse.Result = result;
        
			return deleteBranchResponse;
        }
    }
}
