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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnUserDomainsByFuncResponseUnmarshaller
    {
        public static DescribeCdnUserDomainsByFuncResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnUserDomainsByFuncResponse describeCdnUserDomainsByFuncResponse = new DescribeCdnUserDomainsByFuncResponse();

			describeCdnUserDomainsByFuncResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnUserDomainsByFuncResponse.RequestId = _ctx.StringValue("DescribeCdnUserDomainsByFunc.RequestId");
			describeCdnUserDomainsByFuncResponse.PageNumber = _ctx.LongValue("DescribeCdnUserDomainsByFunc.PageNumber");
			describeCdnUserDomainsByFuncResponse.PageSize = _ctx.LongValue("DescribeCdnUserDomainsByFunc.PageSize");
			describeCdnUserDomainsByFuncResponse.TotalCount = _ctx.LongValue("DescribeCdnUserDomainsByFunc.TotalCount");

			List<DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData> describeCdnUserDomainsByFuncResponse_domains = new List<DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData>();
			for (int i = 0; i < _ctx.Length("DescribeCdnUserDomainsByFunc.Domains.Length"); i++) {
				DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData pageData = new DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData();
				pageData.DomainName = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].DomainName");
				pageData.Cname = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Cname");
				pageData.CdnType = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].CdnType");
				pageData.DomainStatus = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].DomainStatus");
				pageData.GmtCreated = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].GmtCreated");
				pageData.GmtModified = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].GmtModified");
				pageData.Description = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Description");
				pageData.SslProtocol = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].SslProtocol");
				pageData.ResourceGroupId = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].ResourceGroupId");
				pageData.Sandbox = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Sandbox");

				List<DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData.DescribeCdnUserDomainsByFunc_Source> pageData_sources = new List<DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData.DescribeCdnUserDomainsByFunc_Source>();
				for (int j = 0; j < _ctx.Length("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Sources.Length"); j++) {
					DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData.DescribeCdnUserDomainsByFunc_Source source = new DescribeCdnUserDomainsByFuncResponse.DescribeCdnUserDomainsByFunc_PageData.DescribeCdnUserDomainsByFunc_Source();
					source.Type = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Type");
					source.Content = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Content");
					source.Port = _ctx.IntegerValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Port");
					source.Priority = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Priority");
					source.Weight = _ctx.StringValue("DescribeCdnUserDomainsByFunc.Domains["+ i +"].Sources["+ j +"].Weight");

					pageData_sources.Add(source);
				}
				pageData.Sources = pageData_sources;

				describeCdnUserDomainsByFuncResponse_domains.Add(pageData);
			}
			describeCdnUserDomainsByFuncResponse.Domains = describeCdnUserDomainsByFuncResponse_domains;
        
			return describeCdnUserDomainsByFuncResponse;
        }
    }
}
