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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListJobTemplatesResponseUnmarshaller
    {
        public static ListJobTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobTemplatesResponse listJobTemplatesResponse = new ListJobTemplatesResponse();

			listJobTemplatesResponse.HttpResponse = context.HttpResponse;
			listJobTemplatesResponse.RequestId = context.StringValue("ListJobTemplates.RequestId");
			listJobTemplatesResponse.TotalCount = context.IntegerValue("ListJobTemplates.TotalCount");
			listJobTemplatesResponse.PageNumber = context.IntegerValue("ListJobTemplates.PageNumber");
			listJobTemplatesResponse.PageSize = context.IntegerValue("ListJobTemplates.PageSize");

			List<ListJobTemplatesResponse.ListJobTemplates_JobTemplates> listJobTemplatesResponse_templates = new List<ListJobTemplatesResponse.ListJobTemplates_JobTemplates>();
			for (int i = 0; i < context.Length("ListJobTemplates.Templates.Length"); i++) {
				ListJobTemplatesResponse.ListJobTemplates_JobTemplates jobTemplates = new ListJobTemplatesResponse.ListJobTemplates_JobTemplates();
				jobTemplates.Id = context.StringValue("ListJobTemplates.Templates["+ i +"].Id");
				jobTemplates.Name = context.StringValue("ListJobTemplates.Templates["+ i +"].Name");
				jobTemplates.CommandLine = context.StringValue("ListJobTemplates.Templates["+ i +"].CommandLine");
				jobTemplates.RunasUser = context.StringValue("ListJobTemplates.Templates["+ i +"].RunasUser");
				jobTemplates.Priority = context.IntegerValue("ListJobTemplates.Templates["+ i +"].Priority");
				jobTemplates.PackagePath = context.StringValue("ListJobTemplates.Templates["+ i +"].PackagePath");
				jobTemplates.StdoutRedirectPath = context.StringValue("ListJobTemplates.Templates["+ i +"].StdoutRedirectPath");
				jobTemplates.StderrRedirectPath = context.StringValue("ListJobTemplates.Templates["+ i +"].StderrRedirectPath");
				jobTemplates.ReRunable = context.BooleanValue("ListJobTemplates.Templates["+ i +"].ReRunable");
				jobTemplates.ArrayRequest = context.StringValue("ListJobTemplates.Templates["+ i +"].ArrayRequest");
				jobTemplates.Variables = context.StringValue("ListJobTemplates.Templates["+ i +"].Variables");

				listJobTemplatesResponse_templates.Add(jobTemplates);
			}
			listJobTemplatesResponse.Templates = listJobTemplatesResponse_templates;
        
			return listJobTemplatesResponse;
        }
    }
}
