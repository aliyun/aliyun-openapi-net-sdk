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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryStudioAppDomainListOpenResponseUnmarshaller
    {
        public static QueryStudioAppDomainListOpenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryStudioAppDomainListOpenResponse queryStudioAppDomainListOpenResponse = new QueryStudioAppDomainListOpenResponse();

			queryStudioAppDomainListOpenResponse.HttpResponse = _ctx.HttpResponse;
			queryStudioAppDomainListOpenResponse.RequestId = _ctx.StringValue("QueryStudioAppDomainListOpen.RequestId");
			queryStudioAppDomainListOpenResponse.Success = _ctx.BooleanValue("QueryStudioAppDomainListOpen.Success");
			queryStudioAppDomainListOpenResponse.Code = _ctx.StringValue("QueryStudioAppDomainListOpen.Code");
			queryStudioAppDomainListOpenResponse.ErrorMessage = _ctx.StringValue("QueryStudioAppDomainListOpen.ErrorMessage");

			QueryStudioAppDomainListOpenResponse.QueryStudioAppDomainListOpen_Data data = new QueryStudioAppDomainListOpenResponse.QueryStudioAppDomainListOpen_Data();
			data.PageNo = _ctx.IntegerValue("QueryStudioAppDomainListOpen.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryStudioAppDomainListOpen.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryStudioAppDomainListOpen.Data.Total");
			data.TotalPage = _ctx.IntegerValue("QueryStudioAppDomainListOpen.Data.TotalPage");

			List<QueryStudioAppDomainListOpenResponse.QueryStudioAppDomainListOpen_Data.QueryStudioAppDomainListOpen_DomainInfo> data_list = new List<QueryStudioAppDomainListOpenResponse.QueryStudioAppDomainListOpen_Data.QueryStudioAppDomainListOpen_DomainInfo>();
			for (int i = 0; i < _ctx.Length("QueryStudioAppDomainListOpen.Data.List.Length"); i++) {
				QueryStudioAppDomainListOpenResponse.QueryStudioAppDomainListOpen_Data.QueryStudioAppDomainListOpen_DomainInfo domainInfo = new QueryStudioAppDomainListOpenResponse.QueryStudioAppDomainListOpen_Data.QueryStudioAppDomainListOpen_DomainInfo();
				domainInfo.TenantId = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].TenantId");
				domainInfo.AppId = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].AppId");
				domainInfo.ProjectId = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].ProjectId");
				domainInfo.Host = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].Host");
				domainInfo.Id = _ctx.IntegerValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].Id");
				domainInfo.IsBeian = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].IsBeian");
				domainInfo.Protocol = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].Protocol");
				domainInfo.GmtCreate = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].GmtCreate");
				domainInfo.GmtModified = _ctx.StringValue("QueryStudioAppDomainListOpen.Data.List["+ i +"].GmtModified");

				data_list.Add(domainInfo);
			}
			data.List = data_list;
			queryStudioAppDomainListOpenResponse.Data = data;
        
			return queryStudioAppDomainListOpenResponse;
        }
    }
}
