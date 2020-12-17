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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnUserDomainsByFuncResponseUnmarshaller
    {
        public static DescribeDcdnUserDomainsByFuncResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnUserDomainsByFuncResponse describeDcdnUserDomainsByFuncResponse = new DescribeDcdnUserDomainsByFuncResponse();

			describeDcdnUserDomainsByFuncResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnUserDomainsByFuncResponse.RequestId = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.RequestId");
			describeDcdnUserDomainsByFuncResponse.PageNumber = _ctx.LongValue("DescribeDcdnUserDomainsByFunc.PageNumber");
			describeDcdnUserDomainsByFuncResponse.PageSize = _ctx.LongValue("DescribeDcdnUserDomainsByFunc.PageSize");
			describeDcdnUserDomainsByFuncResponse.TotalCount = _ctx.LongValue("DescribeDcdnUserDomainsByFunc.TotalCount");

			List<DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData> describeDcdnUserDomainsByFuncResponse_domains = new List<DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnUserDomainsByFunc.Domains.Length"); i++) {
				DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData pageData = new DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData();
				pageData.DomainName = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].DomainName");
				pageData.Cname = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Cname");
				pageData.CdnType = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].CdnType");
				pageData.DomainStatus = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].GmtModified");
				pageData.Description = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Description");
				pageData.SslProtocol = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].SslProtocol");
				pageData.ResourceGroupId = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Sandbox");

				List<DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData.DescribeDcdnUserDomainsByFunc_Source> pageData_sources = new List<DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData.DescribeDcdnUserDomainsByFunc_Source>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Sources.Length"); j++) {
					DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData.DescribeDcdnUserDomainsByFunc_Source source = new DescribeDcdnUserDomainsByFuncResponse.DescribeDcdnUserDomainsByFunc_PageData.DescribeDcdnUserDomainsByFunc_Source();
					source.Type = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = _ctx.IntegerValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Priority");
					source.Weight = _ctx.StringValue("DescribeDcdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Weight");

					pageData_sources.Add(source);
				}
				pageData.Sources = pageData_sources;

				describeDcdnUserDomainsByFuncResponse_domains.Add(pageData);
			}
			describeDcdnUserDomainsByFuncResponse.Domains = describeDcdnUserDomainsByFuncResponse_domains;
        
			return describeDcdnUserDomainsByFuncResponse;
        }
    }
}
