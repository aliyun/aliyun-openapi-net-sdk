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
    public class QueryDomainSpecialBizInfoByDomainResponseUnmarshaller
    {
        public static QueryDomainSpecialBizInfoByDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainSpecialBizInfoByDomainResponse queryDomainSpecialBizInfoByDomainResponse = new QueryDomainSpecialBizInfoByDomainResponse();

			queryDomainSpecialBizInfoByDomainResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainSpecialBizInfoByDomainResponse.RequestId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.RequestId");
			queryDomainSpecialBizInfoByDomainResponse.HttpStatusCode = _ctx.IntegerValue("QueryDomainSpecialBizInfoByDomain.HttpStatusCode");
			queryDomainSpecialBizInfoByDomainResponse.DynamicCode = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.DynamicCode");
			queryDomainSpecialBizInfoByDomainResponse.DynamicMessage = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.DynamicMessage");
			queryDomainSpecialBizInfoByDomainResponse.Synchro = _ctx.BooleanValue("QueryDomainSpecialBizInfoByDomain.Synchro");
			queryDomainSpecialBizInfoByDomainResponse.ErrorMsg = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.ErrorMsg");
			queryDomainSpecialBizInfoByDomainResponse.ErrorCode = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.ErrorCode");
			queryDomainSpecialBizInfoByDomainResponse.Success = _ctx.BooleanValue("QueryDomainSpecialBizInfoByDomain.Success");
			queryDomainSpecialBizInfoByDomainResponse.AllowRetry = _ctx.BooleanValue("QueryDomainSpecialBizInfoByDomain.AllowRetry");
			queryDomainSpecialBizInfoByDomainResponse.AppName = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.AppName");

			List<string> queryDomainSpecialBizInfoByDomainResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryDomainSpecialBizInfoByDomain.ErrorArgs.Length"); i++) {
				queryDomainSpecialBizInfoByDomainResponse_errorArgs.Add(_ctx.StringValue("QueryDomainSpecialBizInfoByDomain.ErrorArgs["+ i +"]"));
			}
			queryDomainSpecialBizInfoByDomainResponse.ErrorArgs = queryDomainSpecialBizInfoByDomainResponse_errorArgs;

			QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module module = new QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module();
			module.Id = _ctx.LongValue("QueryDomainSpecialBizInfoByDomain.Module.Id");
			module.GmtCreate = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.GmtCreate");
			module.GmtModified = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.GmtModified");
			module.BizName = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.BizName");
			module.BizNo = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.BizNo");
			module.DomainName = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainName");
			module.SaleId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.SaleId");
			module.UserId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.UserId");
			module.ProductId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.ProductId");
			module.BizType = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.BizType");
			module.BizStatus = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.BizStatus");
			module.Status = _ctx.IntegerValue("QueryDomainSpecialBizInfoByDomain.Module.Status");
			module.StatusDesc = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.StatusDesc");
			module.AuditMsg = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.AuditMsg");
			module.OrderId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.OrderId");
			module.UpdateTime = _ctx.LongValue("QueryDomainSpecialBizInfoByDomain.Module.UpdateTime");
			module.CreateTime = _ctx.LongValue("QueryDomainSpecialBizInfoByDomain.Module.CreateTime");

			QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module.QueryDomainSpecialBizInfoByDomain_DomainSpecialBizContact domainSpecialBizContact = new QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module.QueryDomainSpecialBizInfoByDomain_DomainSpecialBizContact();
			domainSpecialBizContact.BizId = _ctx.LongValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.BizId");
			domainSpecialBizContact.RegType = _ctx.IntegerValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.RegType");
			domainSpecialBizContact.CCompany = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.CCompany");
			domainSpecialBizContact.ECompany = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.ECompany");
			domainSpecialBizContact.CName = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.CName");
			domainSpecialBizContact.EName = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.EName");
			domainSpecialBizContact.CCountry = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.CCountry");
			domainSpecialBizContact.CProvince = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.CProvince");
			domainSpecialBizContact.EProvince = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.EProvince");
			domainSpecialBizContact.CCity = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.CCity");
			domainSpecialBizContact.ECity = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.ECity");
			domainSpecialBizContact.CVenu = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.CVenu");
			domainSpecialBizContact.EVenu = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.EVenu");
			domainSpecialBizContact.Postalcode = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.Postalcode");
			domainSpecialBizContact.Email = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.Email");
			domainSpecialBizContact.TelArea = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.TelArea");
			domainSpecialBizContact.TelMain = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.TelMain");
			domainSpecialBizContact.TelExt = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.TelExt");
			domainSpecialBizContact.FaxArea = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.FaxArea");
			domainSpecialBizContact.FaxMain = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.FaxMain");
			domainSpecialBizContact.FaxExt = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.FaxExt");
			domainSpecialBizContact.Mobile = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.Mobile");
			domainSpecialBizContact.Extend = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.Extend");
			domainSpecialBizContact.VspContactId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.VspContactId");
			domainSpecialBizContact.RegistrantId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizContact.RegistrantId");
			module.DomainSpecialBizContact = domainSpecialBizContact;

			List<QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module.QueryDomainSpecialBizInfoByDomain_DomainSpecialBizCredential> module_domainSpecialBizCredentials = new List<QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module.QueryDomainSpecialBizInfoByDomain_DomainSpecialBizCredential>();
			for (int i = 0; i < _ctx.Length("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials.Length"); i++) {
				QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module.QueryDomainSpecialBizInfoByDomain_DomainSpecialBizCredential domainSpecialBizCredential = new QueryDomainSpecialBizInfoByDomainResponse.QueryDomainSpecialBizInfoByDomain_Module.QueryDomainSpecialBizInfoByDomain_DomainSpecialBizCredential();
				domainSpecialBizCredential.DomainName = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials["+ i +"].DomainName");
				domainSpecialBizCredential.SaleId = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials["+ i +"].SaleId");
				domainSpecialBizCredential.BizId = _ctx.LongValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials["+ i +"].BizId");
				domainSpecialBizCredential.CredentialNo = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials["+ i +"].CredentialNo");
				domainSpecialBizCredential.CredentialType = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials["+ i +"].CredentialType");
				domainSpecialBizCredential.CredentialUrl = _ctx.StringValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials["+ i +"].CredentialUrl");
				domainSpecialBizCredential.HolderCert = _ctx.IntegerValue("QueryDomainSpecialBizInfoByDomain.Module.DomainSpecialBizCredentials["+ i +"].HolderCert");

				module_domainSpecialBizCredentials.Add(domainSpecialBizCredential);
			}
			module.DomainSpecialBizCredentials = module_domainSpecialBizCredentials;
			queryDomainSpecialBizInfoByDomainResponse.Module = module;
        
			return queryDomainSpecialBizInfoByDomainResponse;
        }
    }
}
