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
    public class DescribeDBInstanceByTagsResponseUnmarshaller
    {
        public static DescribeDBInstanceByTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceByTagsResponse describeDBInstanceByTagsResponse = new DescribeDBInstanceByTagsResponse();

			describeDBInstanceByTagsResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceByTagsResponse.RequestId = context.StringValue("DescribeDBInstanceByTags.RequestId");
			describeDBInstanceByTagsResponse.PageNumber = context.IntegerValue("DescribeDBInstanceByTags.PageNumber");
			describeDBInstanceByTagsResponse.PageRecordCount = context.IntegerValue("DescribeDBInstanceByTags.PageRecordCount");
			describeDBInstanceByTagsResponse.TotalRecordCount = context.IntegerValue("DescribeDBInstanceByTags.TotalRecordCount");

			List<DescribeDBInstanceByTagsResponse.DBInstanceTag> items = new List<DescribeDBInstanceByTagsResponse.DBInstanceTag>();
			for (int i = 0; i < context.Length("DescribeDBInstanceByTags.Items.Length"); i++) {
				DescribeDBInstanceByTagsResponse.DBInstanceTag dBInstanceTag = new DescribeDBInstanceByTagsResponse.DBInstanceTag();
				dBInstanceTag.DBInstanceId = context.StringValue("DescribeDBInstanceByTags.Items["+ i +"].DBInstanceId");

				List<DescribeDBInstanceByTagsResponse.DBInstanceTag.Tag> tags = new List<DescribeDBInstanceByTagsResponse.DBInstanceTag.Tag>();
				for (int j = 0; j < context.Length("DescribeDBInstanceByTags.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceByTagsResponse.DBInstanceTag.Tag tag = new DescribeDBInstanceByTagsResponse.DBInstanceTag.Tag();
					tag.TagKey = context.StringValue("DescribeDBInstanceByTags.Items["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeDBInstanceByTags.Items["+ i +"].Tags["+ j +"].TagValue");

					tags.Add(tag);
				}
				dBInstanceTag.Tags = tags;

				items.Add(dBInstanceTag);
			}
			describeDBInstanceByTagsResponse.Items = items;
        
			return describeDBInstanceByTagsResponse;
        }
    }
}