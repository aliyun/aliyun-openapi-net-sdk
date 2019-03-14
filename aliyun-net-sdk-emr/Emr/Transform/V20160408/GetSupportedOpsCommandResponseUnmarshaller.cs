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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class GetSupportedOpsCommandResponseUnmarshaller
    {
        public static GetSupportedOpsCommandResponse Unmarshall(UnmarshallerContext context)
        {
			GetSupportedOpsCommandResponse getSupportedOpsCommandResponse = new GetSupportedOpsCommandResponse();

			getSupportedOpsCommandResponse.HttpResponse = context.HttpResponse;
			getSupportedOpsCommandResponse.RequestId = context.StringValue("GetSupportedOpsCommand.RequestId");

			List<GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory> getSupportedOpsCommandResponse_list = new List<GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory>();
			for (int i = 0; i < context.Length("GetSupportedOpsCommand.List.Length"); i++) {
				GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory opsCommandCategory = new GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory();
				opsCommandCategory.Category = context.StringValue("GetSupportedOpsCommand.List["+ i +"].Category");

				List<GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory.GetSupportedOpsCommand_OpsCommandInfo> opsCommandCategory_commandList = new List<GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory.GetSupportedOpsCommand_OpsCommandInfo>();
				for (int j = 0; j < context.Length("GetSupportedOpsCommand.List["+ i +"].CommandList.Length"); j++) {
					GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory.GetSupportedOpsCommand_OpsCommandInfo opsCommandInfo = new GetSupportedOpsCommandResponse.GetSupportedOpsCommand_OpsCommandCategory.GetSupportedOpsCommand_OpsCommandInfo();
					opsCommandInfo.Id = context.StringValue("GetSupportedOpsCommand.List["+ i +"].CommandList["+ j +"].Id");
					opsCommandInfo.Name = context.StringValue("GetSupportedOpsCommand.List["+ i +"].CommandList["+ j +"].Name");
					opsCommandInfo.Discription = context.StringValue("GetSupportedOpsCommand.List["+ i +"].CommandList["+ j +"].Discription");
					opsCommandInfo.TargetType = context.StringValue("GetSupportedOpsCommand.List["+ i +"].CommandList["+ j +"].TargetType");
					opsCommandInfo._Params = context.StringValue("GetSupportedOpsCommand.List["+ i +"].CommandList["+ j +"].Params");

					opsCommandCategory_commandList.Add(opsCommandInfo);
				}
				opsCommandCategory.CommandList = opsCommandCategory_commandList;

				getSupportedOpsCommandResponse_list.Add(opsCommandCategory);
			}
			getSupportedOpsCommandResponse.List = getSupportedOpsCommandResponse_list;
        
			return getSupportedOpsCommandResponse;
        }
    }
}
