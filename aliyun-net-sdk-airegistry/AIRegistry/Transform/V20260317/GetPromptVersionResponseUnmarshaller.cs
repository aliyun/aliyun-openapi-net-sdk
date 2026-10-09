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
using Aliyun.Acs.AIRegistry.Model.V20260317;

namespace Aliyun.Acs.AIRegistry.Transform.V20260317
{
    public class GetPromptVersionResponseUnmarshaller
    {
        public static GetPromptVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPromptVersionResponse getPromptVersionResponse = new GetPromptVersionResponse();

			getPromptVersionResponse.HttpResponse = _ctx.HttpResponse;
			getPromptVersionResponse.RequestId = _ctx.StringValue("GetPromptVersion.RequestId");

			GetPromptVersionResponse.GetPromptVersion_Data data = new GetPromptVersionResponse.GetPromptVersion_Data();
			data.Status = _ctx.StringValue("GetPromptVersion.Data.Status");
			data.Version = _ctx.StringValue("GetPromptVersion.Data.Version");
			data.SrcUser = _ctx.StringValue("GetPromptVersion.Data.SrcUser");
			data.PromptKey = _ctx.StringValue("GetPromptVersion.Data.PromptKey");
			data.GmtModified = _ctx.LongValue("GetPromptVersion.Data.GmtModified");
			data.CommitMsg = _ctx.StringValue("GetPromptVersion.Data.CommitMsg");
			data.Template = _ctx.StringValue("GetPromptVersion.Data.Template");
			data.Md5 = _ctx.StringValue("GetPromptVersion.Data.Md5");

			List<GetPromptVersionResponse.GetPromptVersion_Data.GetPromptVersion_Variable> data_variables = new List<GetPromptVersionResponse.GetPromptVersion_Data.GetPromptVersion_Variable>();
			for (int i = 0; i < _ctx.Length("GetPromptVersion.Data.Variables.Length"); i++) {
				GetPromptVersionResponse.GetPromptVersion_Data.GetPromptVersion_Variable variable = new GetPromptVersionResponse.GetPromptVersion_Data.GetPromptVersion_Variable();
				variable.DefaultValue = _ctx.StringValue("GetPromptVersion.Data.Variables["+ i +"].DefaultValue");
				variable.Description = _ctx.StringValue("GetPromptVersion.Data.Variables["+ i +"].Description");
				variable.Name = _ctx.StringValue("GetPromptVersion.Data.Variables["+ i +"].Name");

				data_variables.Add(variable);
			}
			data.Variables = data_variables;
			getPromptVersionResponse.Data = data;
        
			return getPromptVersionResponse;
        }
    }
}
