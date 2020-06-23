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
    public class QueryOperationAuditInfoListResponseUnmarshaller
    {
        public static QueryOperationAuditInfoListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOperationAuditInfoListResponse queryOperationAuditInfoListResponse = new QueryOperationAuditInfoListResponse();

			queryOperationAuditInfoListResponse.HttpResponse = context.HttpResponse;
			queryOperationAuditInfoListResponse.RequestId = context.StringValue("QueryOperationAuditInfoList.RequestId");
			queryOperationAuditInfoListResponse.TotalItemNum = context.IntegerValue("QueryOperationAuditInfoList.TotalItemNum");
			queryOperationAuditInfoListResponse.CurrentPageNum = context.IntegerValue("QueryOperationAuditInfoList.CurrentPageNum");
			queryOperationAuditInfoListResponse.TotalPageNum = context.IntegerValue("QueryOperationAuditInfoList.TotalPageNum");
			queryOperationAuditInfoListResponse.PageSize = context.IntegerValue("QueryOperationAuditInfoList.PageSize");
			queryOperationAuditInfoListResponse.PrePage = context.BooleanValue("QueryOperationAuditInfoList.PrePage");
			queryOperationAuditInfoListResponse.NextPage = context.BooleanValue("QueryOperationAuditInfoList.NextPage");

			List<QueryOperationAuditInfoListResponse.QueryOperationAuditInfoList_OperationAuditRecord> queryOperationAuditInfoListResponse_data = new List<QueryOperationAuditInfoListResponse.QueryOperationAuditInfoList_OperationAuditRecord>();
			for (int i = 0; i < context.Length("QueryOperationAuditInfoList.Data.Length"); i++) {
				QueryOperationAuditInfoListResponse.QueryOperationAuditInfoList_OperationAuditRecord operationAuditRecord = new QueryOperationAuditInfoListResponse.QueryOperationAuditInfoList_OperationAuditRecord();
				operationAuditRecord.Id = context.LongValue("QueryOperationAuditInfoList.Data["+ i +"].Id");
				operationAuditRecord.CreateTime = context.LongValue("QueryOperationAuditInfoList.Data["+ i +"].CreateTime");
				operationAuditRecord.UpdateTime = context.LongValue("QueryOperationAuditInfoList.Data["+ i +"].UpdateTime");
				operationAuditRecord.BusinessName = context.StringValue("QueryOperationAuditInfoList.Data["+ i +"].BusinessName");
				operationAuditRecord.DomainName = context.StringValue("QueryOperationAuditInfoList.Data["+ i +"].DomainName");
				operationAuditRecord.AuditType = context.IntegerValue("QueryOperationAuditInfoList.Data["+ i +"].AuditType");
				operationAuditRecord.AuditStatus = context.IntegerValue("QueryOperationAuditInfoList.Data["+ i +"].AuditStatus");
				operationAuditRecord.AuditInfo = context.StringValue("QueryOperationAuditInfoList.Data["+ i +"].AuditInfo");
				operationAuditRecord.Remark = context.StringValue("QueryOperationAuditInfoList.Data["+ i +"].Remark");

				queryOperationAuditInfoListResponse_data.Add(operationAuditRecord);
			}
			queryOperationAuditInfoListResponse.Data = queryOperationAuditInfoListResponse_data;
        
			return queryOperationAuditInfoListResponse;
        }
    }
}
