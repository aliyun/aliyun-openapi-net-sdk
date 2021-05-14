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
    public class DescribeDrdsDBResponseUnmarshaller
    {
        public static DescribeDrdsDBResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsDBResponse describeDrdsDBResponse = new DescribeDrdsDBResponse();

			describeDrdsDBResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsDBResponse.RequestId = _ctx.StringValue("DescribeDrdsDB.RequestId");
			describeDrdsDBResponse.Success = _ctx.BooleanValue("DescribeDrdsDB.Success");

			DescribeDrdsDBResponse.DescribeDrdsDB_Data data = new DescribeDrdsDBResponse.DescribeDrdsDB_Data();
			data.DbName = _ctx.StringValue("DescribeDrdsDB.Data.DbName");
			data.Status = _ctx.StringValue("DescribeDrdsDB.Data.Status");
			data.CreateTime = _ctx.StringValue("DescribeDrdsDB.Data.CreateTime");
			data.Mode = _ctx.StringValue("DescribeDrdsDB.Data.Mode");
			data.Schema = _ctx.StringValue("DescribeDrdsDB.Data.Schema");
			data.DbInstType = _ctx.StringValue("DescribeDrdsDB.Data.DbInstType");
			data.InstRole = _ctx.StringValue("DescribeDrdsDB.Data.InstRole");
			describeDrdsDBResponse.Data = data;
        
			return describeDrdsDBResponse;
        }
    }
}
