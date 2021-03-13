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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeSchemasResponseUnmarshaller
    {
        public static DescribeSchemasResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSchemasResponse describeSchemasResponse = new DescribeSchemasResponse();

			describeSchemasResponse.HttpResponse = _ctx.HttpResponse;
			describeSchemasResponse.RequestId = _ctx.StringValue("DescribeSchemas.RequestId");

			List<DescribeSchemasResponse.DescribeSchemas_Schema> describeSchemasResponse_items = new List<DescribeSchemasResponse.DescribeSchemas_Schema>();
			for (int i = 0; i < _ctx.Length("DescribeSchemas.Items.Length"); i++) {
				DescribeSchemasResponse.DescribeSchemas_Schema schema = new DescribeSchemasResponse.DescribeSchemas_Schema();
				schema.DBClusterId = _ctx.StringValue("DescribeSchemas.Items["+ i +"].DBClusterId");
				schema.SchemaName = _ctx.StringValue("DescribeSchemas.Items["+ i +"].SchemaName");

				describeSchemasResponse_items.Add(schema);
			}
			describeSchemasResponse.Items = describeSchemasResponse_items;
        
			return describeSchemasResponse;
        }
    }
}
