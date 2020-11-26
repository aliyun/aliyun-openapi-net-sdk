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
    public class UpdateFileResponseUnmarshaller
    {
        public static UpdateFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateFileResponse updateFileResponse = new UpdateFileResponse();

			updateFileResponse.HttpResponse = _ctx.HttpResponse;
			updateFileResponse.RequestId = _ctx.StringValue("UpdateFile.RequestId");
			updateFileResponse.ErrorCode = _ctx.StringValue("UpdateFile.ErrorCode");
			updateFileResponse.Success = _ctx.BooleanValue("UpdateFile.Success");
			updateFileResponse.ErrorMessage = _ctx.StringValue("UpdateFile.ErrorMessage");

			UpdateFileResponse.UpdateFile_Result result = new UpdateFileResponse.UpdateFile_Result();
			result.BranchName = _ctx.StringValue("UpdateFile.Result.BranchName");
			result.FilePath = _ctx.StringValue("UpdateFile.Result.FilePath");
			updateFileResponse.Result = result;
        
			return updateFileResponse;
        }
    }
}
