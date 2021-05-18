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
        public static ListJobTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobTemplatesResponse listJobTemplatesResponse = new ListJobTemplatesResponse();

			listJobTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listJobTemplatesResponse.RequestId = _ctx.StringValue("ListJobTemplates.RequestId");
			listJobTemplatesResponse.TotalCount = _ctx.IntegerValue("ListJobTemplates.TotalCount");
			listJobTemplatesResponse.PageNumber = _ctx.IntegerValue("ListJobTemplates.PageNumber");
			listJobTemplatesResponse.PageSize = _ctx.IntegerValue("ListJobTemplates.PageSize");

			List<ListJobTemplatesResponse.ListJobTemplates_JobTemplates> listJobTemplatesResponse_templates = new List<ListJobTemplatesResponse.ListJobTemplates_JobTemplates>();
			for (int i = 0; i < _ctx.Length("ListJobTemplates.Templates.Length"); i++) {
				ListJobTemplatesResponse.ListJobTemplates_JobTemplates jobTemplates = new ListJobTemplatesResponse.ListJobTemplates_JobTemplates();
				jobTemplates.Id = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].Id");
				jobTemplates.Name = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].Name");
				jobTemplates.CommandLine = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].CommandLine");
				jobTemplates.RunasUser = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].RunasUser");
				jobTemplates.Priority = _ctx.IntegerValue("ListJobTemplates.Templates["+ i +"].Priority");
				jobTemplates.PackagePath = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].PackagePath");
				jobTemplates.StdoutRedirectPath = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].StdoutRedirectPath");
				jobTemplates.StderrRedirectPath = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].StderrRedirectPath");
				jobTemplates.ReRunable = _ctx.BooleanValue("ListJobTemplates.Templates["+ i +"].ReRunable");
				jobTemplates.ArrayRequest = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].ArrayRequest");
				jobTemplates.Variables = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].Variables");
				jobTemplates.Queue = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].Queue");
				jobTemplates.ClockTime = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].ClockTime");
				jobTemplates.Node = _ctx.IntegerValue("ListJobTemplates.Templates["+ i +"].Node");
				jobTemplates.Task = _ctx.IntegerValue("ListJobTemplates.Templates["+ i +"].Task");
				jobTemplates.Thread = _ctx.IntegerValue("ListJobTemplates.Templates["+ i +"].Thread");
				jobTemplates.Mem = _ctx.StringValue("ListJobTemplates.Templates["+ i +"].Mem");
				jobTemplates.Gpu = _ctx.IntegerValue("ListJobTemplates.Templates["+ i +"].Gpu");

				listJobTemplatesResponse_templates.Add(jobTemplates);
			}
			listJobTemplatesResponse.Templates = listJobTemplatesResponse_templates;
        
			return listJobTemplatesResponse;
        }
    }
}
