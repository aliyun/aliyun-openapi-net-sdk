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
    public class QueryEntityResponseUnmarshaller
    {
        public static QueryEntityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEntityResponse queryEntityResponse = new QueryEntityResponse();

			queryEntityResponse.HttpResponse = _ctx.HttpResponse;
			queryEntityResponse.RequestId = _ctx.StringValue("QueryEntity.RequestId");
			queryEntityResponse.PageNumber = _ctx.IntegerValue("QueryEntity.PageNumber");
			queryEntityResponse.PageSize = _ctx.IntegerValue("QueryEntity.PageSize");
			queryEntityResponse.TotalCount = _ctx.IntegerValue("QueryEntity.TotalCount");

			List<QueryEntityResponse.QueryEntity_Item> queryEntityResponse_items = new List<QueryEntityResponse.QueryEntity_Item>();
			for (int i = 0; i < _ctx.Length("QueryEntity.Items.Length"); i++) {
				QueryEntityResponse.QueryEntity_Item item = new QueryEntityResponse.QueryEntity_Item();
				item.TagId = _ctx.LongValue("QueryEntity.Items["+ i +"].TagId");
				item.EntityType = _ctx.StringValue("QueryEntity.Items["+ i +"].EntityType");
				item.EntityId = _ctx.StringValue("QueryEntity.Items["+ i +"].EntityId");

				queryEntityResponse_items.Add(item);
			}
			queryEntityResponse.Items = queryEntityResponse_items;
        
			return queryEntityResponse;
        }
    }
}
