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
    public class DescribeDrdsDBsResponseUnmarshaller
    {
        public static DescribeDrdsDBsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsDBsResponse describeDrdsDBsResponse = new DescribeDrdsDBsResponse();

			describeDrdsDBsResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsDBsResponse.RequestId = _ctx.StringValue("DescribeDrdsDBs.RequestId");
			describeDrdsDBsResponse.Success = _ctx.BooleanValue("DescribeDrdsDBs.Success");
			describeDrdsDBsResponse.PageNumber = _ctx.StringValue("DescribeDrdsDBs.PageNumber");
			describeDrdsDBsResponse.PageSize = _ctx.StringValue("DescribeDrdsDBs.PageSize");
			describeDrdsDBsResponse.Total = _ctx.StringValue("DescribeDrdsDBs.Total");

			List<DescribeDrdsDBsResponse.DescribeDrdsDBs_Db> describeDrdsDBsResponse_data = new List<DescribeDrdsDBsResponse.DescribeDrdsDBs_Db>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsDBs.Data.Length"); i++) {
				DescribeDrdsDBsResponse.DescribeDrdsDBs_Db db = new DescribeDrdsDBsResponse.DescribeDrdsDBs_Db();
				db.DbName = _ctx.StringValue("DescribeDrdsDBs.Data["+ i +"].DbName");
				db.Status = _ctx.StringValue("DescribeDrdsDBs.Data["+ i +"].Status");
				db.CreateTime = _ctx.StringValue("DescribeDrdsDBs.Data["+ i +"].CreateTime");
				db.Mode = _ctx.StringValue("DescribeDrdsDBs.Data["+ i +"].Mode");
				db.Schema = _ctx.StringValue("DescribeDrdsDBs.Data["+ i +"].Schema");
				db.DbInstType = _ctx.StringValue("DescribeDrdsDBs.Data["+ i +"].DbInstType");

				describeDrdsDBsResponse_data.Add(db);
			}
			describeDrdsDBsResponse.Data = describeDrdsDBsResponse_data;
        
			return describeDrdsDBsResponse;
        }
    }
}
