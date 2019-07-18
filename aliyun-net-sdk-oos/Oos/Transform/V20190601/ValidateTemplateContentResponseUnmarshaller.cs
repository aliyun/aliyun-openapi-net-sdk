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
        public static ValidateTemplateContentResponse Unmarshall(UnmarshallerContext context)
        {
			ValidateTemplateContentResponse validateTemplateContentResponse = new ValidateTemplateContentResponse();

			validateTemplateContentResponse.HttpResponse = context.HttpResponse;
			validateTemplateContentResponse.RequestId = context.StringValue("ValidateTemplateContent.RequestId");
			validateTemplateContentResponse.Parameters = context.StringValue("ValidateTemplateContent.Parameters");
			validateTemplateContentResponse.RamRole = context.StringValue("ValidateTemplateContent.RamRole");
			validateTemplateContentResponse.Outputs = context.StringValue("ValidateTemplateContent.Outputs");

			List<ValidateTemplateContentResponse.ValidateTemplateContent_Task> validateTemplateContentResponse_tasks = new List<ValidateTemplateContentResponse.ValidateTemplateContent_Task>();
			for (int i = 0; i < context.Length("ValidateTemplateContent.Tasks.Length"); i++) {
				ValidateTemplateContentResponse.ValidateTemplateContent_Task task = new ValidateTemplateContentResponse.ValidateTemplateContent_Task();
				task.Name = context.StringValue("ValidateTemplateContent.Tasks["+ i +"].Name");
				task.Type = context.StringValue("ValidateTemplateContent.Tasks["+ i +"].Type");
				task.Description = context.StringValue("ValidateTemplateContent.Tasks["+ i +"].Description");
				task.Properties = context.StringValue("ValidateTemplateContent.Tasks["+ i +"].Properties");
				task.Outputs = context.StringValue("ValidateTemplateContent.Tasks["+ i +"].Outputs");

				validateTemplateContentResponse_tasks.Add(task);
			}
			validateTemplateContentResponse.Tasks = validateTemplateContentResponse_tasks;
        
			return validateTemplateContentResponse;
        }
    }
}
