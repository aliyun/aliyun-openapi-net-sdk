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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class QueryTagResponseUnmarshaller
    {
        public static QueryTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTagResponse queryTagResponse = new QueryTagResponse();

			queryTagResponse.HttpResponse = _ctx.HttpResponse;
			queryTagResponse.RequestId = _ctx.StringValue("QueryTag.RequestId");
			queryTagResponse.PageNumber = _ctx.IntegerValue("QueryTag.PageNumber");
			queryTagResponse.PageSize = _ctx.IntegerValue("QueryTag.PageSize");
			queryTagResponse.TotalCount = _ctx.IntegerValue("QueryTag.TotalCount");

			List<QueryTagResponse.QueryTag_Item> queryTagResponse_items = new List<QueryTagResponse.QueryTag_Item>();
			for (int i = 0; i < _ctx.Length("QueryTag.Items.Length"); i++) {
				QueryTagResponse.QueryTag_Item item = new QueryTagResponse.QueryTag_Item();
				item.Name = _ctx.StringValue("QueryTag.Items["+ i +"].Name");
				item.Category = _ctx.StringValue("QueryTag.Items["+ i +"].Category");
				item.Description = _ctx.StringValue("QueryTag.Items["+ i +"].Description");

				queryTagResponse_items.Add(item);
			}
			queryTagResponse.Items = queryTagResponse_items;
        
			return queryTagResponse;
        }
    }
}
