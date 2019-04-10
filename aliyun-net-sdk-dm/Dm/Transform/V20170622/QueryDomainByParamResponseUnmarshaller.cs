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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class QueryDomainByParamResponseUnmarshaller
    {
        public static QueryDomainByParamResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDomainByParamResponse queryDomainByParamResponse = new QueryDomainByParamResponse();

			queryDomainByParamResponse.HttpResponse = context.HttpResponse;
			queryDomainByParamResponse.RequestId = context.StringValue("QueryDomainByParam.RequestId");
			queryDomainByParamResponse.TotalCount = context.IntegerValue("QueryDomainByParam.TotalCount");
			queryDomainByParamResponse.PageNumber = context.IntegerValue("QueryDomainByParam.PageNumber");
			queryDomainByParamResponse.PageSize = context.IntegerValue("QueryDomainByParam.PageSize");

			List<QueryDomainByParamResponse.QueryDomainByParam_Domain> queryDomainByParamResponse_data = new List<QueryDomainByParamResponse.QueryDomainByParam_Domain>();
			for (int i = 0; i < context.Length("QueryDomainByParam.Data.Length"); i++) {
				QueryDomainByParamResponse.QueryDomainByParam_Domain domain = new QueryDomainByParamResponse.QueryDomainByParam_Domain();
				domain.DomainId = context.StringValue("QueryDomainByParam.Data["+ i +"].DomainId");
				domain.DomainName = context.StringValue("QueryDomainByParam.Data["+ i +"].DomainName");
				domain.DomainStatus = context.StringValue("QueryDomainByParam.Data["+ i +"].DomainStatus");
				domain.DomainRecord = context.StringValue("QueryDomainByParam.Data["+ i +"].DomainRecord");
				domain.ConfirmStatus = context.StringValue("QueryDomainByParam.Data["+ i +"].ConfirmStatus");
				domain.SpfAuthStatus = context.StringValue("QueryDomainByParam.Data["+ i +"].SpfAuthStatus");
				domain.MxAuthStatus = context.StringValue("QueryDomainByParam.Data["+ i +"].MxAuthStatus");
				domain.CreateTime = context.StringValue("QueryDomainByParam.Data["+ i +"].CreateTime");
				domain.UtcCreateTime = context.LongValue("QueryDomainByParam.Data["+ i +"].UtcCreateTime");
				domain.CnameAuthStatus = context.StringValue("QueryDomainByParam.Data["+ i +"].CnameAuthStatus");
				domain.IcpStatus = context.StringValue("QueryDomainByParam.Data["+ i +"].IcpStatus");

				queryDomainByParamResponse_data.Add(domain);
			}
			queryDomainByParamResponse.Data = queryDomainByParamResponse_data;
        
			return queryDomainByParamResponse;
        }
    }
}
