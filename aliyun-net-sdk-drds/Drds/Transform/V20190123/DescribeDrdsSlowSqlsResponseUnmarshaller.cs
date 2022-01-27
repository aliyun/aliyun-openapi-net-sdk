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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsSlowSqlsResponseUnmarshaller
    {
        public static DescribeDrdsSlowSqlsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsSlowSqlsResponse describeDrdsSlowSqlsResponse = new DescribeDrdsSlowSqlsResponse();

			describeDrdsSlowSqlsResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsSlowSqlsResponse.RequestId = _ctx.StringValue("DescribeDrdsSlowSqls.RequestId");
			describeDrdsSlowSqlsResponse.Success = _ctx.BooleanValue("DescribeDrdsSlowSqls.Success");
			describeDrdsSlowSqlsResponse.Total = _ctx.IntegerValue("DescribeDrdsSlowSqls.Total");
			describeDrdsSlowSqlsResponse.PageNumber = _ctx.IntegerValue("DescribeDrdsSlowSqls.PageNumber");
			describeDrdsSlowSqlsResponse.PageSize = _ctx.IntegerValue("DescribeDrdsSlowSqls.PageSize");

			List<DescribeDrdsSlowSqlsResponse.DescribeDrdsSlowSqls_Item> describeDrdsSlowSqlsResponse_items = new List<DescribeDrdsSlowSqlsResponse.DescribeDrdsSlowSqls_Item>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsSlowSqls.Items.Length"); i++) {
				DescribeDrdsSlowSqlsResponse.DescribeDrdsSlowSqls_Item item = new DescribeDrdsSlowSqlsResponse.DescribeDrdsSlowSqls_Item();
				item.Schema = _ctx.StringValue("DescribeDrdsSlowSqls.Items["+ i +"].Schema");
				item.Sql = _ctx.StringValue("DescribeDrdsSlowSqls.Items["+ i +"].Sql");
				item.SendTime = _ctx.LongValue("DescribeDrdsSlowSqls.Items["+ i +"].SendTime");
				item.ResponseTime = _ctx.LongValue("DescribeDrdsSlowSqls.Items["+ i +"].ResponseTime");
				item.Host = _ctx.StringValue("DescribeDrdsSlowSqls.Items["+ i +"].Host");

				describeDrdsSlowSqlsResponse_items.Add(item);
			}
			describeDrdsSlowSqlsResponse.Items = describeDrdsSlowSqlsResponse_items;
        
			return describeDrdsSlowSqlsResponse;
        }
    }
}
