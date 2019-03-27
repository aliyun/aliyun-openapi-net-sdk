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
using Aliyun.Acs.Drds.Model.V20171016;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeDrdsDBsResponseUnmarshaller
    {
        public static DescribeDrdsDBsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDrdsDBsResponse describeDrdsDBsResponse = new DescribeDrdsDBsResponse();

			describeDrdsDBsResponse.HttpResponse = context.HttpResponse;
			describeDrdsDBsResponse.RequestId = context.StringValue("DescribeDrdsDBs.RequestId");
			describeDrdsDBsResponse.Success = context.BooleanValue("DescribeDrdsDBs.Success");

			List<DescribeDrdsDBsResponse.DescribeDrdsDBs_Db> describeDrdsDBsResponse_data = new List<DescribeDrdsDBsResponse.DescribeDrdsDBs_Db>();
			for (int i = 0; i < context.Length("DescribeDrdsDBs.Data.Length"); i++) {
				DescribeDrdsDBsResponse.DescribeDrdsDBs_Db db = new DescribeDrdsDBsResponse.DescribeDrdsDBs_Db();
				db.DbName = context.StringValue("DescribeDrdsDBs.Data["+ i +"].DbName");
				db.Status = context.IntegerValue("DescribeDrdsDBs.Data["+ i +"].Status");
				db.CreateTime = context.StringValue("DescribeDrdsDBs.Data["+ i +"].CreateTime");
				db.Msg = context.StringValue("DescribeDrdsDBs.Data["+ i +"].Msg");
				db.Mode = context.StringValue("DescribeDrdsDBs.Data["+ i +"].Mode");

				describeDrdsDBsResponse_data.Add(db);
			}
			describeDrdsDBsResponse.Data = describeDrdsDBsResponse_data;
        
			return describeDrdsDBsResponse;
        }
    }
}
