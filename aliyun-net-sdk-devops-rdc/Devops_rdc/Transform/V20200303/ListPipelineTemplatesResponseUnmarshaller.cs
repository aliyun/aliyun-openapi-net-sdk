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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListPipelineTemplatesResponseUnmarshaller
    {
        public static ListPipelineTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPipelineTemplatesResponse listPipelineTemplatesResponse = new ListPipelineTemplatesResponse();

			listPipelineTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listPipelineTemplatesResponse.RequestId = _ctx.StringValue("ListPipelineTemplates.RequestId");

			ListPipelineTemplatesResponse.ListPipelineTemplates_Data data = new ListPipelineTemplatesResponse.ListPipelineTemplates_Data();
			data.Total = _ctx.FloatValue("ListPipelineTemplates.Data.Total");

			List<ListPipelineTemplatesResponse.ListPipelineTemplates_Data.ListPipelineTemplates_模板列表> data_dataList = new List<ListPipelineTemplatesResponse.ListPipelineTemplates_Data.ListPipelineTemplates_模板列表>();
			for (int i = 0; i < _ctx.Length("ListPipelineTemplates.Data.DataList.Length"); i++) {
				ListPipelineTemplatesResponse.ListPipelineTemplates_Data.ListPipelineTemplates_模板列表 模板列表 = new ListPipelineTemplatesResponse.ListPipelineTemplates_Data.ListPipelineTemplates_模板列表();
				模板列表.TemplateName = _ctx.StringValue("ListPipelineTemplates.Data.DataList["+ i +"].TemplateName");
				模板列表.Id = _ctx.LongValue("ListPipelineTemplates.Data.DataList["+ i +"].Id");

				data_dataList.Add(模板列表);
			}
			data.DataList = data_dataList;
			listPipelineTemplatesResponse.Data = data;
        
			return listPipelineTemplatesResponse;
        }
    }
}
