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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryDSRecordResponseUnmarshaller
    {
        public static QueryDSRecordResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDSRecordResponse queryDSRecordResponse = new QueryDSRecordResponse();

			queryDSRecordResponse.HttpResponse = context.HttpResponse;
			queryDSRecordResponse.RequestId = context.StringValue("QueryDSRecord.RequestId");

			List<QueryDSRecordResponse.QueryDSRecord_DSRecord> queryDSRecordResponse_dSRecordList = new List<QueryDSRecordResponse.QueryDSRecord_DSRecord>();
			for (int i = 0; i < context.Length("QueryDSRecord.DSRecordList.Length"); i++) {
				QueryDSRecordResponse.QueryDSRecord_DSRecord dSRecord = new QueryDSRecordResponse.QueryDSRecord_DSRecord();
				dSRecord.KeyTag = context.IntegerValue("QueryDSRecord.DSRecordList["+ i +"].KeyTag");
				dSRecord.Algorithm = context.IntegerValue("QueryDSRecord.DSRecordList["+ i +"].Algorithm");
				dSRecord.DigestType = context.IntegerValue("QueryDSRecord.DSRecordList["+ i +"].DigestType");
				dSRecord.Digest = context.StringValue("QueryDSRecord.DSRecordList["+ i +"].Digest");

				queryDSRecordResponse_dSRecordList.Add(dSRecord);
			}
			queryDSRecordResponse.DSRecordList = queryDSRecordResponse_dSRecordList;
        
			return queryDSRecordResponse;
        }
    }
}
