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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class QuerySlsLogStoreListResponseUnmarshaller
    {
        public static QuerySlsLogStoreListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySlsLogStoreListResponse querySlsLogStoreListResponse = new QuerySlsLogStoreListResponse();

			querySlsLogStoreListResponse.HttpResponse = _ctx.HttpResponse;
			querySlsLogStoreListResponse.TotalSize = _ctx.IntegerValue("QuerySlsLogStoreList.TotalSize");
			querySlsLogStoreListResponse.RequestId = _ctx.StringValue("QuerySlsLogStoreList.RequestId");
			querySlsLogStoreListResponse.Code = _ctx.IntegerValue("QuerySlsLogStoreList.Code");
			querySlsLogStoreListResponse.Message = _ctx.StringValue("QuerySlsLogStoreList.Message");

			List<QuerySlsLogStoreListResponse.QuerySlsLogStoreList_SlsLog> querySlsLogStoreListResponse_result = new List<QuerySlsLogStoreListResponse.QuerySlsLogStoreList_SlsLog>();
			for (int i = 0; i < _ctx.Length("QuerySlsLogStoreList.Result.Length"); i++) {
				QuerySlsLogStoreListResponse.QuerySlsLogStoreList_SlsLog slsLog = new QuerySlsLogStoreListResponse.QuerySlsLogStoreList_SlsLog();
				slsLog.Logstore = _ctx.StringValue("QuerySlsLogStoreList.Result["+ i +"].Logstore");
				slsLog.Project = _ctx.StringValue("QuerySlsLogStoreList.Result["+ i +"].Project");
				slsLog.Link = _ctx.StringValue("QuerySlsLogStoreList.Result["+ i +"].Link");
				slsLog.ConsumerSide = _ctx.StringValue("QuerySlsLogStoreList.Result["+ i +"].ConsumerSide");
				slsLog.CreateTime = _ctx.StringValue("QuerySlsLogStoreList.Result["+ i +"].CreateTime");
				slsLog.Source = _ctx.StringValue("QuerySlsLogStoreList.Result["+ i +"].Source");

				querySlsLogStoreListResponse_result.Add(slsLog);
			}
			querySlsLogStoreListResponse.Result = querySlsLogStoreListResponse_result;
        
			return querySlsLogStoreListResponse;
        }
    }
}
