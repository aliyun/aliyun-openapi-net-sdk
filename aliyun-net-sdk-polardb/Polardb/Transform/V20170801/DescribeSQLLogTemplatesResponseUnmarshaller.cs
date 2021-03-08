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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeSQLLogTemplatesResponseUnmarshaller
    {
        public static DescribeSQLLogTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogTemplatesResponse describeSQLLogTemplatesResponse = new DescribeSQLLogTemplatesResponse();

			describeSQLLogTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogTemplatesResponse.MaxRecordsPerPage = _ctx.IntegerValue("DescribeSQLLogTemplates.MaxRecordsPerPage");
			describeSQLLogTemplatesResponse.ItemsNumbers = _ctx.IntegerValue("DescribeSQLLogTemplates.ItemsNumbers");
			describeSQLLogTemplatesResponse.RequestId = _ctx.StringValue("DescribeSQLLogTemplates.RequestId");
			describeSQLLogTemplatesResponse.EndTime = _ctx.StringValue("DescribeSQLLogTemplates.EndTime");
			describeSQLLogTemplatesResponse.DBInstanceID = _ctx.IntegerValue("DescribeSQLLogTemplates.DBInstanceID");
			describeSQLLogTemplatesResponse.StartTime = _ctx.StringValue("DescribeSQLLogTemplates.StartTime");
			describeSQLLogTemplatesResponse.TotalRecords = _ctx.IntegerValue("DescribeSQLLogTemplates.TotalRecords");
			describeSQLLogTemplatesResponse.Finish = _ctx.StringValue("DescribeSQLLogTemplates.Finish");
			describeSQLLogTemplatesResponse.PageNumbers = _ctx.IntegerValue("DescribeSQLLogTemplates.PageNumbers");
			describeSQLLogTemplatesResponse.JobId = _ctx.StringValue("DescribeSQLLogTemplates.JobId");
			describeSQLLogTemplatesResponse.PagingID = _ctx.StringValue("DescribeSQLLogTemplates.PagingID");
			describeSQLLogTemplatesResponse.DBInstanceName = _ctx.StringValue("DescribeSQLLogTemplates.DBInstanceName");

			List<DescribeSQLLogTemplatesResponse.DescribeSQLLogTemplates_Template> describeSQLLogTemplatesResponse_items = new List<DescribeSQLLogTemplatesResponse.DescribeSQLLogTemplates_Template>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogTemplates.Items.Length"); i++) {
				DescribeSQLLogTemplatesResponse.DescribeSQLLogTemplates_Template template = new DescribeSQLLogTemplatesResponse.DescribeSQLLogTemplates_Template();
				template.AvgScanRows = _ctx.FloatValue("DescribeSQLLogTemplates.Items["+ i +"].AvgScanRows");
				template.TemplateHash = _ctx.StringValue("DescribeSQLLogTemplates.Items["+ i +"].TemplateHash");
				template.AvgConsume = _ctx.FloatValue("DescribeSQLLogTemplates.Items["+ i +"].AvgConsume");
				template.TotalScanRows = _ctx.LongValue("DescribeSQLLogTemplates.Items["+ i +"].TotalScanRows");
				template.TotalUpdateRows = _ctx.LongValue("DescribeSQLLogTemplates.Items["+ i +"].TotalUpdateRows");
				template.TotalCounts = _ctx.LongValue("DescribeSQLLogTemplates.Items["+ i +"].TotalCounts");
				template.SqlType = _ctx.StringValue("DescribeSQLLogTemplates.Items["+ i +"].SqlType");
				template.AvgUpdateRows = _ctx.FloatValue("DescribeSQLLogTemplates.Items["+ i +"].AvgUpdateRows");
				template.ItemID = _ctx.IntegerValue("DescribeSQLLogTemplates.Items["+ i +"].ItemID");
				template.Template = _ctx.StringValue("DescribeSQLLogTemplates.Items["+ i +"].Template");
				template.TotalConsume = _ctx.LongValue("DescribeSQLLogTemplates.Items["+ i +"].TotalConsume");

				describeSQLLogTemplatesResponse_items.Add(template);
			}
			describeSQLLogTemplatesResponse.Items = describeSQLLogTemplatesResponse_items;
        
			return describeSQLLogTemplatesResponse;
        }
    }
}
