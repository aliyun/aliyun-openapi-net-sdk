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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSqlLogTemplatesListResponseUnmarshaller
    {
        public static DescribeSqlLogTemplatesListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSqlLogTemplatesListResponse describeSqlLogTemplatesListResponse = new DescribeSqlLogTemplatesListResponse();

			describeSqlLogTemplatesListResponse.HttpResponse = context.HttpResponse;
			describeSqlLogTemplatesListResponse.RequestId = context.StringValue("DescribeSqlLogTemplatesList.RequestId");
			describeSqlLogTemplatesListResponse.DBInstanceID = context.IntegerValue("DescribeSqlLogTemplatesList.DBInstanceID");
			describeSqlLogTemplatesListResponse.DBInstanceName = context.StringValue("DescribeSqlLogTemplatesList.DBInstanceName");
			describeSqlLogTemplatesListResponse.StartTime = context.StringValue("DescribeSqlLogTemplatesList.StartTime");
			describeSqlLogTemplatesListResponse.EndTime = context.StringValue("DescribeSqlLogTemplatesList.EndTime");
			describeSqlLogTemplatesListResponse.TotalRecords = context.IntegerValue("DescribeSqlLogTemplatesList.TotalRecords");
			describeSqlLogTemplatesListResponse.PagingID = context.StringValue("DescribeSqlLogTemplatesList.PagingID");
			describeSqlLogTemplatesListResponse.MaxRecordsPerPage = context.IntegerValue("DescribeSqlLogTemplatesList.MaxRecordsPerPage");
			describeSqlLogTemplatesListResponse.PageNumbers = context.IntegerValue("DescribeSqlLogTemplatesList.PageNumbers");
			describeSqlLogTemplatesListResponse.ItemsNumbers = context.IntegerValue("DescribeSqlLogTemplatesList.ItemsNumbers");

			List<DescribeSqlLogTemplatesListResponse.DescribeSqlLogTemplatesList_Template> describeSqlLogTemplatesListResponse_items = new List<DescribeSqlLogTemplatesListResponse.DescribeSqlLogTemplatesList_Template>();
			for (int i = 0; i < context.Length("DescribeSqlLogTemplatesList.Items.Length"); i++) {
				DescribeSqlLogTemplatesListResponse.DescribeSqlLogTemplatesList_Template template = new DescribeSqlLogTemplatesListResponse.DescribeSqlLogTemplatesList_Template();
				template.Template = context.StringValue("DescribeSqlLogTemplatesList.Items["+ i +"].Template");
				template.TotalConsume = context.LongValue("DescribeSqlLogTemplatesList.Items["+ i +"].TotalConsume");
				template.AvgConsume = context.FloatValue("DescribeSqlLogTemplatesList.Items["+ i +"].AvgConsume");
				template.TotalCounts = context.LongValue("DescribeSqlLogTemplatesList.Items["+ i +"].TotalCounts");
				template.AvgScanRows = context.FloatValue("DescribeSqlLogTemplatesList.Items["+ i +"].AvgScanRows");
				template.TotalScanRows = context.LongValue("DescribeSqlLogTemplatesList.Items["+ i +"].TotalScanRows");
				template.TotalUpdateRows = context.LongValue("DescribeSqlLogTemplatesList.Items["+ i +"].TotalUpdateRows");
				template.AvgUpdateRows = context.FloatValue("DescribeSqlLogTemplatesList.Items["+ i +"].AvgUpdateRows");
				template.SqlType = context.StringValue("DescribeSqlLogTemplatesList.Items["+ i +"].SqlType");
				template.TemplateHash = context.StringValue("DescribeSqlLogTemplatesList.Items["+ i +"].TemplateHash");

				describeSqlLogTemplatesListResponse_items.Add(template);
			}
			describeSqlLogTemplatesListResponse.Items = describeSqlLogTemplatesListResponse_items;
        
			return describeSqlLogTemplatesListResponse;
        }
    }
}