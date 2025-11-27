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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeNotifyTemplateListResponseUnmarshaller
    {
        public static DescribeNotifyTemplateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNotifyTemplateListResponse describeNotifyTemplateListResponse = new DescribeNotifyTemplateListResponse();

			describeNotifyTemplateListResponse.HttpResponse = _ctx.HttpResponse;
			describeNotifyTemplateListResponse.RequestId = _ctx.StringValue("DescribeNotifyTemplateList.RequestId");

			DescribeNotifyTemplateListResponse.DescribeNotifyTemplateList_Page page = new DescribeNotifyTemplateListResponse.DescribeNotifyTemplateList_Page();
			page.TotalCount = _ctx.IntegerValue("DescribeNotifyTemplateList.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("DescribeNotifyTemplateList.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("DescribeNotifyTemplateList.Page.PageSize");
			describeNotifyTemplateListResponse.Page = page;

			List<DescribeNotifyTemplateListResponse.DescribeNotifyTemplateList_DataItem> describeNotifyTemplateListResponse_data = new List<DescribeNotifyTemplateListResponse.DescribeNotifyTemplateList_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeNotifyTemplateList.Data.Length"); i++) {
				DescribeNotifyTemplateListResponse.DescribeNotifyTemplateList_DataItem dataItem = new DescribeNotifyTemplateListResponse.DescribeNotifyTemplateList_DataItem();
				dataItem.TemplateName = _ctx.StringValue("DescribeNotifyTemplateList.Data["+ i +"].TemplateName");
				dataItem.EventId = _ctx.StringValue("DescribeNotifyTemplateList.Data["+ i +"].EventId");
				dataItem.Subject = _ctx.StringValue("DescribeNotifyTemplateList.Data["+ i +"].Subject");
				dataItem.Content = _ctx.StringValue("DescribeNotifyTemplateList.Data["+ i +"].Content");
				dataItem._Params = _ctx.StringValue("DescribeNotifyTemplateList.Data["+ i +"].Params");

				describeNotifyTemplateListResponse_data.Add(dataItem);
			}
			describeNotifyTemplateListResponse.Data = describeNotifyTemplateListResponse_data;
        
			return describeNotifyTemplateListResponse;
        }
    }
}
