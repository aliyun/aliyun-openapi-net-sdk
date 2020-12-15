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
    public class DescribeDBInstanceByTagsResponseUnmarshaller
    {
        public static DescribeDBInstanceByTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceByTagsResponse describeDBInstanceByTagsResponse = new DescribeDBInstanceByTagsResponse();

			describeDBInstanceByTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceByTagsResponse.RequestId = _ctx.StringValue("DescribeDBInstanceByTags.RequestId");
			describeDBInstanceByTagsResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstanceByTags.PageNumber");
			describeDBInstanceByTagsResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBInstanceByTags.PageRecordCount");
			describeDBInstanceByTagsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBInstanceByTags.TotalRecordCount");

			List<DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag> describeDBInstanceByTagsResponse_items = new List<DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceByTags.Items.Length"); i++) {
				DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag dBInstanceTag = new DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag();
				dBInstanceTag.DBInstanceId = _ctx.StringValue("DescribeDBInstanceByTags.Items["+ i +"].DBInstanceId");

				List<DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag.DescribeDBInstanceByTags_Tag> dBInstanceTag_tags = new List<DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag.DescribeDBInstanceByTags_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceByTags.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag.DescribeDBInstanceByTags_Tag tag = new DescribeDBInstanceByTagsResponse.DescribeDBInstanceByTags_DBInstanceTag.DescribeDBInstanceByTags_Tag();
					tag.TagKey = _ctx.StringValue("DescribeDBInstanceByTags.Items["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeDBInstanceByTags.Items["+ i +"].Tags["+ j +"].TagValue");

					dBInstanceTag_tags.Add(tag);
				}
				dBInstanceTag.Tags = dBInstanceTag_tags;

				describeDBInstanceByTagsResponse_items.Add(dBInstanceTag);
			}
			describeDBInstanceByTagsResponse.Items = describeDBInstanceByTagsResponse_items;
        
			return describeDBInstanceByTagsResponse;
        }
    }
}
