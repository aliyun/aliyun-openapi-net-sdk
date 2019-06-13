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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeTemplatesListResponseUnmarshaller
    {
        public static DescribeTemplatesListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTemplatesListResponse describeTemplatesListResponse = new DescribeTemplatesListResponse();

			describeTemplatesListResponse.HttpResponse = context.HttpResponse;
			describeTemplatesListResponse.RequestId = context.StringValue("DescribeTemplatesList.RequestId");
			describeTemplatesListResponse.DBInstanceID = context.IntegerValue("DescribeTemplatesList.DBInstanceID");
			describeTemplatesListResponse.DBInstanceName = context.StringValue("DescribeTemplatesList.DBInstanceName");
			describeTemplatesListResponse.StartTime = context.StringValue("DescribeTemplatesList.StartTime");
			describeTemplatesListResponse.EndTime = context.StringValue("DescribeTemplatesList.EndTime");
			describeTemplatesListResponse.TotalRecords = context.IntegerValue("DescribeTemplatesList.TotalRecords");
			describeTemplatesListResponse.PagingID = context.StringValue("DescribeTemplatesList.PagingID");
			describeTemplatesListResponse.MaxRecordsPerPage = context.IntegerValue("DescribeTemplatesList.MaxRecordsPerPage");
			describeTemplatesListResponse.PageNumbers = context.IntegerValue("DescribeTemplatesList.PageNumbers");
			describeTemplatesListResponse.ItemsNumbers = context.IntegerValue("DescribeTemplatesList.ItemsNumbers");

			List<DescribeTemplatesListResponse.DescribeTemplatesList_ItemsItem> describeTemplatesListResponse_items = new List<DescribeTemplatesListResponse.DescribeTemplatesList_ItemsItem>();
			for (int i = 0; i < context.Length("DescribeTemplatesList.Items.Length"); i++) {
				DescribeTemplatesListResponse.DescribeTemplatesList_ItemsItem itemsItem = new DescribeTemplatesListResponse.DescribeTemplatesList_ItemsItem();
				itemsItem.Template = context.StringValue("DescribeTemplatesList.Items["+ i +"].Template");
				itemsItem.TotalConsume = context.LongValue("DescribeTemplatesList.Items["+ i +"].TotalConsume");
				itemsItem.AvgConsume = context.FloatValue("DescribeTemplatesList.Items["+ i +"].AvgConsume");
				itemsItem.TotalCounts = context.LongValue("DescribeTemplatesList.Items["+ i +"].TotalCounts");
				itemsItem.AvgScanRows = context.FloatValue("DescribeTemplatesList.Items["+ i +"].AvgScanRows");
				itemsItem.TotalScanRows = context.LongValue("DescribeTemplatesList.Items["+ i +"].TotalScanRows");
				itemsItem.TotalUpdateRows = context.LongValue("DescribeTemplatesList.Items["+ i +"].TotalUpdateRows");
				itemsItem.AvgUpdateRows = context.FloatValue("DescribeTemplatesList.Items["+ i +"].AvgUpdateRows");
				itemsItem.SqlType = context.StringValue("DescribeTemplatesList.Items["+ i +"].SqlType");
				itemsItem.TemplateHash = context.StringValue("DescribeTemplatesList.Items["+ i +"].TemplateHash");

				describeTemplatesListResponse_items.Add(itemsItem);
			}
			describeTemplatesListResponse.Items = describeTemplatesListResponse_items;
        
			return describeTemplatesListResponse;
        }
    }
}
