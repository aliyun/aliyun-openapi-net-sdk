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
using Aliyun.Acs.Domain.Model.V20180208;

namespace Aliyun.Acs.Domain.Transform.V20180208
{
    public class QueryBrokerDemandRecordResponseUnmarshaller
    {
        public static QueryBrokerDemandRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBrokerDemandRecordResponse queryBrokerDemandRecordResponse = new QueryBrokerDemandRecordResponse();

			queryBrokerDemandRecordResponse.HttpResponse = _ctx.HttpResponse;
			queryBrokerDemandRecordResponse.RequestId = _ctx.StringValue("QueryBrokerDemandRecord.RequestId");
			queryBrokerDemandRecordResponse.TotalItemNum = _ctx.IntegerValue("QueryBrokerDemandRecord.TotalItemNum");
			queryBrokerDemandRecordResponse.CurrentPageNum = _ctx.IntegerValue("QueryBrokerDemandRecord.CurrentPageNum");
			queryBrokerDemandRecordResponse.PageSize = _ctx.IntegerValue("QueryBrokerDemandRecord.PageSize");
			queryBrokerDemandRecordResponse.TotalPageNum = _ctx.IntegerValue("QueryBrokerDemandRecord.TotalPageNum");

			List<QueryBrokerDemandRecordResponse.QueryBrokerDemandRecord_BrokerDemandRecord> queryBrokerDemandRecordResponse_data = new List<QueryBrokerDemandRecordResponse.QueryBrokerDemandRecord_BrokerDemandRecord>();
			for (int i = 0; i < _ctx.Length("QueryBrokerDemandRecord.Data.Length"); i++) {
				QueryBrokerDemandRecordResponse.QueryBrokerDemandRecord_BrokerDemandRecord brokerDemandRecord = new QueryBrokerDemandRecordResponse.QueryBrokerDemandRecord_BrokerDemandRecord();
				brokerDemandRecord.BizId = _ctx.StringValue("QueryBrokerDemandRecord.Data["+ i +"].BizId");
				brokerDemandRecord.Description = _ctx.StringValue("QueryBrokerDemandRecord.Data["+ i +"].Description");
				brokerDemandRecord.CreateTime = _ctx.LongValue("QueryBrokerDemandRecord.Data["+ i +"].CreateTime");

				queryBrokerDemandRecordResponse_data.Add(brokerDemandRecord);
			}
			queryBrokerDemandRecordResponse.Data = queryBrokerDemandRecordResponse_data;
        
			return queryBrokerDemandRecordResponse;
        }
    }
}
