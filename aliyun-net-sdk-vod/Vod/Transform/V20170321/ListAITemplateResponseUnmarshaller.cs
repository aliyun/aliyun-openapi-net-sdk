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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListAITemplateResponseUnmarshaller
    {
        public static ListAITemplateResponse Unmarshall(UnmarshallerContext context)
        {
			ListAITemplateResponse listAITemplateResponse = new ListAITemplateResponse();

			listAITemplateResponse.HttpResponse = context.HttpResponse;
			listAITemplateResponse.RequestId = context.StringValue("ListAITemplate.RequestId");

			List<ListAITemplateResponse.ListAITemplate_TemplateInfoListItem> listAITemplateResponse_templateInfoList = new List<ListAITemplateResponse.ListAITemplate_TemplateInfoListItem>();
			for (int i = 0; i < context.Length("ListAITemplate.TemplateInfoList.Length"); i++) {
				ListAITemplateResponse.ListAITemplate_TemplateInfoListItem templateInfoListItem = new ListAITemplateResponse.ListAITemplate_TemplateInfoListItem();
				templateInfoListItem.TemplateId = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].TemplateId");
				templateInfoListItem.TemplateType = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].TemplateType");
				templateInfoListItem.TemplateName = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].TemplateName");
				templateInfoListItem.TemplateConfig = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].TemplateConfig");
				templateInfoListItem.Source = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].Source");
				templateInfoListItem.IsDefault = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].IsDefault");
				templateInfoListItem.CreationTime = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].CreationTime");
				templateInfoListItem.ModifyTime = context.StringValue("ListAITemplate.TemplateInfoList["+ i +"].ModifyTime");

				listAITemplateResponse_templateInfoList.Add(templateInfoListItem);
			}
			listAITemplateResponse.TemplateInfoList = listAITemplateResponse_templateInfoList;
        
			return listAITemplateResponse;
        }
    }
}
