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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeOssObjectsResponseUnmarshaller
    {
        public static DescribeOssObjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssObjectsResponse describeOssObjectsResponse = new DescribeOssObjectsResponse();

			describeOssObjectsResponse.HttpResponse = _ctx.HttpResponse;
			describeOssObjectsResponse.CurrentPage = _ctx.IntegerValue("DescribeOssObjects.CurrentPage");
			describeOssObjectsResponse.RequestId = _ctx.StringValue("DescribeOssObjects.RequestId");
			describeOssObjectsResponse.PageSize = _ctx.IntegerValue("DescribeOssObjects.PageSize");
			describeOssObjectsResponse.TotalCount = _ctx.IntegerValue("DescribeOssObjects.TotalCount");

			List<DescribeOssObjectsResponse.DescribeOssObjects_Column> describeOssObjectsResponse_items = new List<DescribeOssObjectsResponse.DescribeOssObjects_Column>();
			for (int i = 0; i < _ctx.Length("DescribeOssObjects.Items.Length"); i++) {
				DescribeOssObjectsResponse.DescribeOssObjects_Column column = new DescribeOssObjectsResponse.DescribeOssObjects_Column();
				column.InstanceId = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].InstanceId");
				column.CategoryName = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].CategoryName");
				column.RiskLevelId = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].RiskLevelId");
				column.RegionId = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].RegionId");
				column.FileId = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].FileId");
				column.LastScanTime = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].LastScanTime");
				column.RegionName = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].RegionName");
				column.Size = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].Size");
				column.BucketName = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].BucketName");
				column.RiskLevelName = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].RiskLevelName");
				column.Category = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].Category");
				column.Name = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].Name");
				column.RuleCount = _ctx.IntegerValue("DescribeOssObjects.Items["+ i +"].RuleCount");
				column.SensitiveCount = _ctx.IntegerValue("DescribeOssObjects.Items["+ i +"].SensitiveCount");
				column.Id = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].Id");
				column.FileCategoryCode = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].FileCategoryCode");
				column.FileCategoryName = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].FileCategoryName");

				List<DescribeOssObjectsResponse.DescribeOssObjects_Column.DescribeOssObjects_Rule> column_ruleList = new List<DescribeOssObjectsResponse.DescribeOssObjects_Column.DescribeOssObjects_Rule>();
				for (int j = 0; j < _ctx.Length("DescribeOssObjects.Items["+ i +"].RuleList.Length"); j++) {
					DescribeOssObjectsResponse.DescribeOssObjects_Column.DescribeOssObjects_Rule rule = new DescribeOssObjectsResponse.DescribeOssObjects_Column.DescribeOssObjects_Rule();
					rule.Name = _ctx.StringValue("DescribeOssObjects.Items["+ i +"].RuleList["+ j +"].Name");
					rule.RiskLevelId = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].RuleList["+ j +"].RiskLevelId");
					rule.Count = _ctx.LongValue("DescribeOssObjects.Items["+ i +"].RuleList["+ j +"].Count");

					column_ruleList.Add(rule);
				}
				column.RuleList = column_ruleList;

				describeOssObjectsResponse_items.Add(column);
			}
			describeOssObjectsResponse.Items = describeOssObjectsResponse_items;
        
			return describeOssObjectsResponse;
        }
    }
}
