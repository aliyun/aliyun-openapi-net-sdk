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
    public class QueryDomainSpecialBizDetailResponseUnmarshaller
    {
        public static QueryDomainSpecialBizDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainSpecialBizDetailResponse queryDomainSpecialBizDetailResponse = new QueryDomainSpecialBizDetailResponse();

			queryDomainSpecialBizDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainSpecialBizDetailResponse.RequestId = _ctx.StringValue("QueryDomainSpecialBizDetail.RequestId");
			queryDomainSpecialBizDetailResponse.HttpStatusCode = _ctx.IntegerValue("QueryDomainSpecialBizDetail.HttpStatusCode");
			queryDomainSpecialBizDetailResponse.DynamicCode = _ctx.StringValue("QueryDomainSpecialBizDetail.DynamicCode");
			queryDomainSpecialBizDetailResponse.DynamicMessage = _ctx.StringValue("QueryDomainSpecialBizDetail.DynamicMessage");
			queryDomainSpecialBizDetailResponse.Synchro = _ctx.BooleanValue("QueryDomainSpecialBizDetail.Synchro");
			queryDomainSpecialBizDetailResponse.ErrorMsg = _ctx.StringValue("QueryDomainSpecialBizDetail.ErrorMsg");
			queryDomainSpecialBizDetailResponse.ErrorCode = _ctx.StringValue("QueryDomainSpecialBizDetail.ErrorCode");
			queryDomainSpecialBizDetailResponse.Success = _ctx.BooleanValue("QueryDomainSpecialBizDetail.Success");
			queryDomainSpecialBizDetailResponse.AllowRetry = _ctx.BooleanValue("QueryDomainSpecialBizDetail.AllowRetry");
			queryDomainSpecialBizDetailResponse.AppName = _ctx.StringValue("QueryDomainSpecialBizDetail.AppName");

			List<string> queryDomainSpecialBizDetailResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryDomainSpecialBizDetail.ErrorArgs.Length"); i++) {
				queryDomainSpecialBizDetailResponse_errorArgs.Add(_ctx.StringValue("QueryDomainSpecialBizDetail.ErrorArgs["+ i +"]"));
			}
			queryDomainSpecialBizDetailResponse.ErrorArgs = queryDomainSpecialBizDetailResponse_errorArgs;

			QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module module = new QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module();
			module.Id = _ctx.LongValue("QueryDomainSpecialBizDetail.Module.Id");
			module.GmtCreate = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.GmtCreate");
			module.GmtModified = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.GmtModified");
			module.BizName = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.BizName");
			module.BizNo = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.BizNo");
			module.DomainName = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainName");
			module.SaleId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.SaleId");
			module.UserId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.UserId");
			module.ProductId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.ProductId");
			module.BizType = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.BizType");
			module.BizStatus = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.BizStatus");
			module.Status = _ctx.IntegerValue("QueryDomainSpecialBizDetail.Module.Status");
			module.StatusDesc = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.StatusDesc");
			module.AuditMsg = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.AuditMsg");
			module.OrderId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.OrderId");
			module.UpdateTime = _ctx.LongValue("QueryDomainSpecialBizDetail.Module.UpdateTime");
			module.CreateTime = _ctx.LongValue("QueryDomainSpecialBizDetail.Module.CreateTime");

			QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialBizContact domainSpecialBizContact = new QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialBizContact();
			domainSpecialBizContact.BizId = _ctx.LongValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.BizId");
			domainSpecialBizContact.RegType = _ctx.IntegerValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.RegType");
			domainSpecialBizContact.CCompany = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.CCompany");
			domainSpecialBizContact.ECompany = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.ECompany");
			domainSpecialBizContact.CName = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.CName");
			domainSpecialBizContact.EName = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.EName");
			domainSpecialBizContact.CCountry = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.CCountry");
			domainSpecialBizContact.CProvince = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.CProvince");
			domainSpecialBizContact.EProvince = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.EProvince");
			domainSpecialBizContact.CCity = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.CCity");
			domainSpecialBizContact.ECity = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.ECity");
			domainSpecialBizContact.CVenu = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.CVenu");
			domainSpecialBizContact.EVenu = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.EVenu");
			domainSpecialBizContact.Postalcode = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.Postalcode");
			domainSpecialBizContact.Email = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.Email");
			domainSpecialBizContact.TelArea = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.TelArea");
			domainSpecialBizContact.TelMain = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.TelMain");
			domainSpecialBizContact.TelExt = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.TelExt");
			domainSpecialBizContact.FaxArea = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.FaxArea");
			domainSpecialBizContact.FaxMain = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.FaxMain");
			domainSpecialBizContact.FaxExt = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.FaxExt");
			domainSpecialBizContact.Mobile = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.Mobile");
			domainSpecialBizContact.Extend = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.Extend");
			domainSpecialBizContact.VspContactId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.VspContactId");
			domainSpecialBizContact.RegistrantId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizContact.RegistrantId");
			module.DomainSpecialBizContact = domainSpecialBizContact;

			QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialOrderResult domainSpecialOrderResult = new QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialOrderResult();
			domainSpecialOrderResult.SaleId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.SaleId");
			domainSpecialOrderResult.OrderId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.OrderId");
			domainSpecialOrderResult.SubOrderId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.SubOrderId");
			domainSpecialOrderResult.ActionType = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.ActionType");
			domainSpecialOrderResult.OrderAmount = _ctx.DoubleValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.OrderAmount");
			domainSpecialOrderResult.OrderCurrency = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.OrderCurrency");
			domainSpecialOrderResult.OrderTime = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.OrderTime");
			domainSpecialOrderResult.OrderYear = _ctx.IntegerValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.OrderYear");
			domainSpecialOrderResult.OrderStatus = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialOrderResult.OrderStatus");
			module.DomainSpecialOrderResult = domainSpecialOrderResult;

			List<QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialBizCredential> module_domainSpecialBizCredentials = new List<QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialBizCredential>();
			for (int i = 0; i < _ctx.Length("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials.Length"); i++) {
				QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialBizCredential domainSpecialBizCredential = new QueryDomainSpecialBizDetailResponse.QueryDomainSpecialBizDetail_Module.QueryDomainSpecialBizDetail_DomainSpecialBizCredential();
				domainSpecialBizCredential.DomainName = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials["+ i +"].DomainName");
				domainSpecialBizCredential.SaleId = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials["+ i +"].SaleId");
				domainSpecialBizCredential.BizId = _ctx.LongValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials["+ i +"].BizId");
				domainSpecialBizCredential.CredentialNo = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials["+ i +"].CredentialNo");
				domainSpecialBizCredential.CredentialType = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials["+ i +"].CredentialType");
				domainSpecialBizCredential.CredentialUrl = _ctx.StringValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials["+ i +"].CredentialUrl");
				domainSpecialBizCredential.HolderCert = _ctx.IntegerValue("QueryDomainSpecialBizDetail.Module.DomainSpecialBizCredentials["+ i +"].HolderCert");

				module_domainSpecialBizCredentials.Add(domainSpecialBizCredential);
			}
			module.DomainSpecialBizCredentials = module_domainSpecialBizCredentials;
			queryDomainSpecialBizDetailResponse.Module = module;
        
			return queryDomainSpecialBizDetailResponse;
        }
    }
}
