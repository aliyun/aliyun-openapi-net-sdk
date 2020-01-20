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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListThingTemplatesResponseUnmarshaller
    {
        public static ListThingTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListThingTemplatesResponse listThingTemplatesResponse = new ListThingTemplatesResponse();

			listThingTemplatesResponse.HttpResponse = context.HttpResponse;
			listThingTemplatesResponse.RequestId = context.StringValue("ListThingTemplates.RequestId");
			listThingTemplatesResponse.Success = context.BooleanValue("ListThingTemplates.Success");
			listThingTemplatesResponse.Code = context.StringValue("ListThingTemplates.Code");
			listThingTemplatesResponse.ErrorMessage = context.StringValue("ListThingTemplates.ErrorMessage");

			List<ListThingTemplatesResponse.ListThingTemplates_CategoryInfo> listThingTemplatesResponse_data = new List<ListThingTemplatesResponse.ListThingTemplates_CategoryInfo>();
			for (int i = 0; i < context.Length("ListThingTemplates.Data.Length"); i++) {
				ListThingTemplatesResponse.ListThingTemplates_CategoryInfo categoryInfo = new ListThingTemplatesResponse.ListThingTemplates_CategoryInfo();
				categoryInfo.CategoryKey = context.StringValue("ListThingTemplates.Data["+ i +"].CategoryKey");
				categoryInfo.CategoryName = context.StringValue("ListThingTemplates.Data["+ i +"].CategoryName");

				listThingTemplatesResponse_data.Add(categoryInfo);
			}
			listThingTemplatesResponse.Data = listThingTemplatesResponse_data;
        
			return listThingTemplatesResponse;
        }
    }
}
