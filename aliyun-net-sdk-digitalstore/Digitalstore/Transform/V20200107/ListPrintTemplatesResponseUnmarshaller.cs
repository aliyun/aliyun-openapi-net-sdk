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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListPrintTemplatesResponseUnmarshaller
    {
        public static ListPrintTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListPrintTemplatesResponse listPrintTemplatesResponse = new ListPrintTemplatesResponse();

			listPrintTemplatesResponse.HttpResponse = context.HttpResponse;
			listPrintTemplatesResponse.RequestId = context.StringValue("ListPrintTemplates.RequestId");
			listPrintTemplatesResponse.Success = context.BooleanValue("ListPrintTemplates.Success");

			List<ListPrintTemplatesResponse.ListPrintTemplates_PrintTemplateModel> listPrintTemplatesResponse_printTemplates = new List<ListPrintTemplatesResponse.ListPrintTemplates_PrintTemplateModel>();
			for (int i = 0; i < context.Length("ListPrintTemplates.PrintTemplates.Length"); i++) {
				ListPrintTemplatesResponse.ListPrintTemplates_PrintTemplateModel printTemplateModel = new ListPrintTemplatesResponse.ListPrintTemplates_PrintTemplateModel();
				printTemplateModel.TemplateId = context.StringValue("ListPrintTemplates.PrintTemplates["+ i +"].TemplateId");
				printTemplateModel.TemplateName = context.StringValue("ListPrintTemplates.PrintTemplates["+ i +"].TemplateName");

				listPrintTemplatesResponse_printTemplates.Add(printTemplateModel);
			}
			listPrintTemplatesResponse.PrintTemplates = listPrintTemplatesResponse_printTemplates;
        
			return listPrintTemplatesResponse;
        }
    }
}
