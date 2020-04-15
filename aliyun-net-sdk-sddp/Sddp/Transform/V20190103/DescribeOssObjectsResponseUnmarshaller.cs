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
        public static DescribeOssObjectsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssObjectsResponse describeOssObjectsResponse = new DescribeOssObjectsResponse();

			describeOssObjectsResponse.HttpResponse = context.HttpResponse;
			describeOssObjectsResponse.RequestId = context.StringValue("DescribeOssObjects.RequestId");
			describeOssObjectsResponse.PageSize = context.IntegerValue("DescribeOssObjects.PageSize");
			describeOssObjectsResponse.CurrentPage = context.IntegerValue("DescribeOssObjects.CurrentPage");
			describeOssObjectsResponse.TotalCount = context.IntegerValue("DescribeOssObjects.TotalCount");

			List<DescribeOssObjectsResponse.DescribeOssObjects_Column> describeOssObjectsResponse_items = new List<DescribeOssObjectsResponse.DescribeOssObjects_Column>();
			for (int i = 0; i < context.Length("DescribeOssObjects.Items.Length"); i++) {
				DescribeOssObjectsResponse.DescribeOssObjects_Column column = new DescribeOssObjectsResponse.DescribeOssObjects_Column();
				column.Id = context.StringValue("DescribeOssObjects.Items["+ i +"].Id");
				column.Name = context.StringValue("DescribeOssObjects.Items["+ i +"].Name");
				column.RegionId = context.StringValue("DescribeOssObjects.Items["+ i +"].RegionId");
				column.RiskLevelId = context.LongValue("DescribeOssObjects.Items["+ i +"].RiskLevelId");
				column.Category = context.LongValue("DescribeOssObjects.Items["+ i +"].Category");
				column.InstanceId = context.LongValue("DescribeOssObjects.Items["+ i +"].InstanceId");
				column.FileId = context.StringValue("DescribeOssObjects.Items["+ i +"].FileId");
				column.RiskLevelName = context.StringValue("DescribeOssObjects.Items["+ i +"].RiskLevelName");
				column.Size = context.LongValue("DescribeOssObjects.Items["+ i +"].Size");
				column.SensitiveCount = context.IntegerValue("DescribeOssObjects.Items["+ i +"].SensitiveCount");
				column.RuleCount = context.IntegerValue("DescribeOssObjects.Items["+ i +"].RuleCount");
				column.CategoryName = context.StringValue("DescribeOssObjects.Items["+ i +"].CategoryName");
				column.BucketName = context.StringValue("DescribeOssObjects.Items["+ i +"].BucketName");

				describeOssObjectsResponse_items.Add(column);
			}
			describeOssObjectsResponse.Items = describeOssObjectsResponse_items;
        
			return describeOssObjectsResponse;
        }
    }
}
