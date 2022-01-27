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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ValidateTemplateContentResponseUnmarshaller
    {
        public static ValidateTemplateContentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateTemplateContentResponse validateTemplateContentResponse = new ValidateTemplateContentResponse();

			validateTemplateContentResponse.HttpResponse = _ctx.HttpResponse;
			validateTemplateContentResponse.RequestId = _ctx.StringValue("ValidateTemplateContent.RequestId");
			validateTemplateContentResponse.Parameters = _ctx.StringValue("ValidateTemplateContent.Parameters");
			validateTemplateContentResponse.RamRole = _ctx.StringValue("ValidateTemplateContent.RamRole");
			validateTemplateContentResponse.Outputs = _ctx.StringValue("ValidateTemplateContent.Outputs");

			List<ValidateTemplateContentResponse.ValidateTemplateContent_Task> validateTemplateContentResponse_tasks = new List<ValidateTemplateContentResponse.ValidateTemplateContent_Task>();
			for (int i = 0; i < _ctx.Length("ValidateTemplateContent.Tasks.Length"); i++) {
				ValidateTemplateContentResponse.ValidateTemplateContent_Task task = new ValidateTemplateContentResponse.ValidateTemplateContent_Task();
				task.Name = _ctx.StringValue("ValidateTemplateContent.Tasks["+ i +"].Name");
				task.Type = _ctx.StringValue("ValidateTemplateContent.Tasks["+ i +"].Type");
				task.Description = _ctx.StringValue("ValidateTemplateContent.Tasks["+ i +"].Description");
				task.Properties = _ctx.StringValue("ValidateTemplateContent.Tasks["+ i +"].Properties");
				task.Outputs = _ctx.StringValue("ValidateTemplateContent.Tasks["+ i +"].Outputs");

				validateTemplateContentResponse_tasks.Add(task);
			}
			validateTemplateContentResponse.Tasks = validateTemplateContentResponse_tasks;
        
			return validateTemplateContentResponse;
        }
    }
}
