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
    public class DescribeMetaListResponseUnmarshaller
    {
        public static DescribeMetaListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMetaListResponse describeMetaListResponse = new DescribeMetaListResponse();

			describeMetaListResponse.HttpResponse = _ctx.HttpResponse;
			describeMetaListResponse.RequestId = _ctx.StringValue("DescribeMetaList.RequestId");
			describeMetaListResponse.TotalRecordCount = _ctx.StringValue("DescribeMetaList.TotalRecordCount");
			describeMetaListResponse.TotalPageCount = _ctx.StringValue("DescribeMetaList.TotalPageCount");
			describeMetaListResponse.PageSize = _ctx.StringValue("DescribeMetaList.PageSize");
			describeMetaListResponse.PageNumber = _ctx.StringValue("DescribeMetaList.PageNumber");

			List<DescribeMetaListResponse.DescribeMetaList_MetaItem> describeMetaListResponse_items = new List<DescribeMetaListResponse.DescribeMetaList_MetaItem>();
			for (int i = 0; i < _ctx.Length("DescribeMetaList.Items.Length"); i++) {
				DescribeMetaListResponse.DescribeMetaList_MetaItem metaItem = new DescribeMetaListResponse.DescribeMetaList_MetaItem();
				metaItem.Database = _ctx.StringValue("DescribeMetaList.Items["+ i +"].Database");

				List<string> metaItem_tables = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeMetaList.Items["+ i +"].Tables.Length"); j++) {
					metaItem_tables.Add(_ctx.StringValue("DescribeMetaList.Items["+ i +"].Tables["+ j +"]"));
				}
				metaItem.Tables = metaItem_tables;

				describeMetaListResponse_items.Add(metaItem);
			}
			describeMetaListResponse.Items = describeMetaListResponse_items;
        
			return describeMetaListResponse;
        }
    }
}
