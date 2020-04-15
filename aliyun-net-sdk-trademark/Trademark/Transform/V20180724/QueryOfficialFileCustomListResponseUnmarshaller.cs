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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryOfficialFileCustomListResponseUnmarshaller
    {
        public static QueryOfficialFileCustomListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOfficialFileCustomListResponse queryOfficialFileCustomListResponse = new QueryOfficialFileCustomListResponse();

			queryOfficialFileCustomListResponse.HttpResponse = context.HttpResponse;
			queryOfficialFileCustomListResponse.RequestId = context.StringValue("QueryOfficialFileCustomList.RequestId");
			queryOfficialFileCustomListResponse.TotalItemNum = context.IntegerValue("QueryOfficialFileCustomList.TotalItemNum");
			queryOfficialFileCustomListResponse.CurrentPageNum = context.IntegerValue("QueryOfficialFileCustomList.CurrentPageNum");
			queryOfficialFileCustomListResponse.PageSize = context.IntegerValue("QueryOfficialFileCustomList.PageSize");
			queryOfficialFileCustomListResponse.TotalPageNum = context.IntegerValue("QueryOfficialFileCustomList.TotalPageNum");

			List<QueryOfficialFileCustomListResponse.QueryOfficialFileCustomList_CustomList> queryOfficialFileCustomListResponse_data = new List<QueryOfficialFileCustomListResponse.QueryOfficialFileCustomList_CustomList>();
			for (int i = 0; i < context.Length("QueryOfficialFileCustomList.Data.Length"); i++) {
				QueryOfficialFileCustomListResponse.QueryOfficialFileCustomList_CustomList customList = new QueryOfficialFileCustomListResponse.QueryOfficialFileCustomList_CustomList();
				customList.Status = context.StringValue("QueryOfficialFileCustomList.Data["+ i +"].Status");
				customList.CreateTime = context.LongValue("QueryOfficialFileCustomList.Data["+ i +"].CreateTime");
				customList.StartAcceptTime = context.LongValue("QueryOfficialFileCustomList.Data["+ i +"].StartAcceptTime");
				customList.EndAcceptTime = context.LongValue("QueryOfficialFileCustomList.Data["+ i +"].EndAcceptTime");
				customList.ExpireTime = context.LongValue("QueryOfficialFileCustomList.Data["+ i +"].ExpireTime");
				customList.DownloadUrl = context.StringValue("QueryOfficialFileCustomList.Data["+ i +"].DownloadUrl");
				customList.Remark = context.StringValue("QueryOfficialFileCustomList.Data["+ i +"].Remark");

				queryOfficialFileCustomListResponse_data.Add(customList);
			}
			queryOfficialFileCustomListResponse.Data = queryOfficialFileCustomListResponse_data;
        
			return queryOfficialFileCustomListResponse;
        }
    }
}
