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
    public class DescribeMetaListResponseUnmarshaller
    {
        public static DescribeMetaListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMetaListResponse describeMetaListResponse = new DescribeMetaListResponse();

			describeMetaListResponse.HttpResponse = _ctx.HttpResponse;
			describeMetaListResponse.RequestId = _ctx.StringValue("DescribeMetaList.RequestId");
			describeMetaListResponse.DBInstanceName = _ctx.StringValue("DescribeMetaList.DBInstanceName");
			describeMetaListResponse.PageNumber = _ctx.IntegerValue("DescribeMetaList.PageNumber");
			describeMetaListResponse.PageRecordCount = _ctx.IntegerValue("DescribeMetaList.PageRecordCount");
			describeMetaListResponse.TotalRecordCount = _ctx.IntegerValue("DescribeMetaList.TotalRecordCount");
			describeMetaListResponse.TotalPageCount = _ctx.IntegerValue("DescribeMetaList.TotalPageCount");

			List<DescribeMetaListResponse.DescribeMetaList_Meta> describeMetaListResponse_items = new List<DescribeMetaListResponse.DescribeMetaList_Meta>();
			for (int i = 0; i < _ctx.Length("DescribeMetaList.Items.Length"); i++) {
				DescribeMetaListResponse.DescribeMetaList_Meta meta = new DescribeMetaListResponse.DescribeMetaList_Meta();
				meta.Database = _ctx.StringValue("DescribeMetaList.Items["+ i +"].Database");
				meta.Tables = _ctx.StringValue("DescribeMetaList.Items["+ i +"].Tables");
				meta.Size = _ctx.StringValue("DescribeMetaList.Items["+ i +"].Size");

				describeMetaListResponse_items.Add(meta);
			}
			describeMetaListResponse.Items = describeMetaListResponse_items;
        
			return describeMetaListResponse;
        }
    }
}
