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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeSynDbsResponseUnmarshaller
    {
        public static DescribeSynDbsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSynDbsResponse describeSynDbsResponse = new DescribeSynDbsResponse();

			describeSynDbsResponse.HttpResponse = _ctx.HttpResponse;
			describeSynDbsResponse.RequestId = _ctx.StringValue("DescribeSynDbs.RequestId");
			describeSynDbsResponse.TotalCount = _ctx.IntegerValue("DescribeSynDbs.TotalCount");
			describeSynDbsResponse.PageSize = _ctx.IntegerValue("DescribeSynDbs.PageSize");
			describeSynDbsResponse.PageNumber = _ctx.IntegerValue("DescribeSynDbs.PageNumber");

			List<DescribeSynDbsResponse.DescribeSynDbs_SynDb> describeSynDbsResponse_synDbs = new List<DescribeSynDbsResponse.DescribeSynDbs_SynDb>();
			for (int i = 0; i < _ctx.Length("DescribeSynDbs.SynDbs.Length"); i++) {
				DescribeSynDbsResponse.DescribeSynDbs_SynDb synDb = new DescribeSynDbsResponse.DescribeSynDbs_SynDb();
				synDb.RdsId = _ctx.StringValue("DescribeSynDbs.SynDbs["+ i +"].RdsId");
				synDb.SynDb = _ctx.StringValue("DescribeSynDbs.SynDbs["+ i +"].SynDb");
				synDb.SynStatus = _ctx.BooleanValue("DescribeSynDbs.SynDbs["+ i +"].SynStatus");
				synDb.ErrorMsg = _ctx.StringValue("DescribeSynDbs.SynDbs["+ i +"].ErrorMsg");
				synDb.RdsUserName = _ctx.StringValue("DescribeSynDbs.SynDbs["+ i +"].RdsUserName");
				synDb.RdsPassword = _ctx.StringValue("DescribeSynDbs.SynDbs["+ i +"].RdsPassword");
				synDb.RdsVpcUrl = _ctx.StringValue("DescribeSynDbs.SynDbs["+ i +"].RdsVpcUrl");

				describeSynDbsResponse_synDbs.Add(synDb);
			}
			describeSynDbsResponse.SynDbs = describeSynDbsResponse_synDbs;
        
			return describeSynDbsResponse;
        }
    }
}
