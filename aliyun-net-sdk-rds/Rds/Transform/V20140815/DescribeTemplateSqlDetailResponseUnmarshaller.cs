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
    public class DescribeTemplateSqlDetailResponseUnmarshaller
    {
        public static DescribeTemplateSqlDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTemplateSqlDetailResponse describeTemplateSqlDetailResponse = new DescribeTemplateSqlDetailResponse();

			describeTemplateSqlDetailResponse.HttpResponse = context.HttpResponse;
			describeTemplateSqlDetailResponse.RequestId = context.StringValue("DescribeTemplateSqlDetail.RequestId");
			describeTemplateSqlDetailResponse.DBInstanceID = context.IntegerValue("DescribeTemplateSqlDetail.DBInstanceID");
			describeTemplateSqlDetailResponse.DBInstanceName = context.StringValue("DescribeTemplateSqlDetail.DBInstanceName");
			describeTemplateSqlDetailResponse.StartTime = context.StringValue("DescribeTemplateSqlDetail.StartTime");
			describeTemplateSqlDetailResponse.EndTime = context.StringValue("DescribeTemplateSqlDetail.EndTime");
			describeTemplateSqlDetailResponse.TotalRecords = context.IntegerValue("DescribeTemplateSqlDetail.TotalRecords");
			describeTemplateSqlDetailResponse.PagingID = context.StringValue("DescribeTemplateSqlDetail.PagingID");
			describeTemplateSqlDetailResponse.MaxRecordsPerPage = context.IntegerValue("DescribeTemplateSqlDetail.MaxRecordsPerPage");
			describeTemplateSqlDetailResponse.PageNumbers = context.IntegerValue("DescribeTemplateSqlDetail.PageNumbers");
			describeTemplateSqlDetailResponse.ItemsNumbers = context.IntegerValue("DescribeTemplateSqlDetail.ItemsNumbers");

			List<DescribeTemplateSqlDetailResponse.DescribeTemplateSqlDetail_TemplateSqlDetail> describeTemplateSqlDetailResponse_items = new List<DescribeTemplateSqlDetailResponse.DescribeTemplateSqlDetail_TemplateSqlDetail>();
			for (int i = 0; i < context.Length("DescribeTemplateSqlDetail.Items.Length"); i++) {
				DescribeTemplateSqlDetailResponse.DescribeTemplateSqlDetail_TemplateSqlDetail templateSqlDetail = new DescribeTemplateSqlDetailResponse.DescribeTemplateSqlDetail_TemplateSqlDetail();
				templateSqlDetail.DBName = context.StringValue("DescribeTemplateSqlDetail.Items["+ i +"].DBName");
				templateSqlDetail.AccountName = context.StringValue("DescribeTemplateSqlDetail.Items["+ i +"].AccountName");
				templateSqlDetail.HostAddress = context.StringValue("DescribeTemplateSqlDetail.Items["+ i +"].HostAddress");
				templateSqlDetail.SQLText = context.StringValue("DescribeTemplateSqlDetail.Items["+ i +"].SQLText");
				templateSqlDetail.Consume = context.LongValue("DescribeTemplateSqlDetail.Items["+ i +"].Consume");
				templateSqlDetail.ScanRows = context.LongValue("DescribeTemplateSqlDetail.Items["+ i +"].ScanRows");
				templateSqlDetail.UpdateRows = context.LongValue("DescribeTemplateSqlDetail.Items["+ i +"].UpdateRows");
				templateSqlDetail.State = context.IntegerValue("DescribeTemplateSqlDetail.Items["+ i +"].State");
				templateSqlDetail.ExecuteTime = context.StringValue("DescribeTemplateSqlDetail.Items["+ i +"].ExecuteTime");
				templateSqlDetail.ThreadID = context.StringValue("DescribeTemplateSqlDetail.Items["+ i +"].ThreadID");
				templateSqlDetail.SqlType = context.StringValue("DescribeTemplateSqlDetail.Items["+ i +"].SqlType");

				describeTemplateSqlDetailResponse_items.Add(templateSqlDetail);
			}
			describeTemplateSqlDetailResponse.Items = describeTemplateSqlDetailResponse_items;
        
			return describeTemplateSqlDetailResponse;
        }
    }
}