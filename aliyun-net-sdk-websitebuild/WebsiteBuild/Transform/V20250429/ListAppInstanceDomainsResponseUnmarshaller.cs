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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class ListAppInstanceDomainsResponseUnmarshaller
    {
        public static ListAppInstanceDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppInstanceDomainsResponse listAppInstanceDomainsResponse = new ListAppInstanceDomainsResponse();

			listAppInstanceDomainsResponse.HttpResponse = _ctx.HttpResponse;
			listAppInstanceDomainsResponse.RequestId = _ctx.StringValue("ListAppInstanceDomains.RequestId");
			listAppInstanceDomainsResponse.DynamicCode = _ctx.StringValue("ListAppInstanceDomains.DynamicCode");
			listAppInstanceDomainsResponse.DynamicMessage = _ctx.StringValue("ListAppInstanceDomains.DynamicMessage");
			listAppInstanceDomainsResponse.Synchro = _ctx.BooleanValue("ListAppInstanceDomains.Synchro");
			listAppInstanceDomainsResponse.AccessDeniedDetail = _ctx.StringValue("ListAppInstanceDomains.AccessDeniedDetail");
			listAppInstanceDomainsResponse.RootErrorMsg = _ctx.StringValue("ListAppInstanceDomains.RootErrorMsg");
			listAppInstanceDomainsResponse.RootErrorCode = _ctx.StringValue("ListAppInstanceDomains.RootErrorCode");
			listAppInstanceDomainsResponse.AllowRetry = _ctx.BooleanValue("ListAppInstanceDomains.AllowRetry");
			listAppInstanceDomainsResponse.AppName = _ctx.StringValue("ListAppInstanceDomains.AppName");
			listAppInstanceDomainsResponse.MaxResults = _ctx.IntegerValue("ListAppInstanceDomains.MaxResults");
			listAppInstanceDomainsResponse.NextToken = _ctx.StringValue("ListAppInstanceDomains.NextToken");

			List<string> listAppInstanceDomainsResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("ListAppInstanceDomains.ErrorArgs.Length"); i++) {
				listAppInstanceDomainsResponse_errorArgs.Add(_ctx.StringValue("ListAppInstanceDomains.ErrorArgs["+ i +"]"));
			}
			listAppInstanceDomainsResponse.ErrorArgs = listAppInstanceDomainsResponse_errorArgs;

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module module = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module();
			module.TotalItemNum = _ctx.IntegerValue("ListAppInstanceDomains.Module.TotalItemNum");
			module.CurrentPageNum = _ctx.IntegerValue("ListAppInstanceDomains.Module.CurrentPageNum");
			module.PageSize = _ctx.IntegerValue("ListAppInstanceDomains.Module.PageSize");
			module.TotalPageNum = _ctx.IntegerValue("ListAppInstanceDomains.Module.TotalPageNum");
			module.PrePage = _ctx.BooleanValue("ListAppInstanceDomains.Module.PrePage");
			module.NextPage = _ctx.BooleanValue("ListAppInstanceDomains.Module.NextPage");
			module.ResultLimit = _ctx.BooleanValue("ListAppInstanceDomains.Module.ResultLimit");

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next next = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next();
			next.DomainName = _ctx.StringValue("ListAppInstanceDomains.Module.Next.DomainName");
			next.CreateTime = _ctx.StringValue("ListAppInstanceDomains.Module.Next.CreateTime");
			next.OverallStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Next.OverallStatus");

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Verification2 verification2 = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Verification2();
			verification2.VerificationStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Verification.VerificationStatus");
			verification2.ErrorMsg = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Verification.ErrorMsg");

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Verification2.ListAppInstanceDomains_DnsRecord6 dnsRecord6 = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Verification2.ListAppInstanceDomains_DnsRecord6();
			dnsRecord6.RecordType = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Verification.DnsRecord.RecordType");
			dnsRecord6.Host = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Verification.DnsRecord.Host");
			dnsRecord6._Value = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Verification.DnsRecord.Value");
			verification2.DnsRecord6 = dnsRecord6;
			next.Verification2 = verification2;

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Resolution3 resolution3 = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Resolution3();
			resolution3.ResolutionStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Resolution.ResolutionStatus");
			resolution3.ErrorMsg = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Resolution.ErrorMsg");

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Resolution3.ListAppInstanceDomains_DnsRecord7 dnsRecord7 = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Resolution3.ListAppInstanceDomains_DnsRecord7();
			dnsRecord7.RecordType = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Resolution.DnsRecord.RecordType");
			dnsRecord7.Host = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Resolution.DnsRecord.Host");
			dnsRecord7._Value = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Resolution.DnsRecord.Value");
			resolution3.DnsRecord7 = dnsRecord7;
			next.Resolution3 = resolution3;

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Certificate4 certificate4 = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Certificate4();
			certificate4.CertificateStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Certificate.CertificateStatus");
			certificate4.CertificateType = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Certificate.CertificateType");
			certificate4.CertificateName = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Certificate.CertificateName");
			certificate4.EndTime = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Certificate.EndTime");
			next.Certificate4 = certificate4;

			ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Ownership5 ownership5 = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_Next.ListAppInstanceDomains_Ownership5();
			ownership5.Account = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Ownership.Account");
			ownership5.Provider = _ctx.StringValue("ListAppInstanceDomains.Module.Next.Ownership.Provider");
			next.Ownership5 = ownership5;
			module.Next = next;

			List<ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem> module_data = new List<ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAppInstanceDomains.Module.Data.Length"); i++) {
				ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem dataItem = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem();
				dataItem.DomainName = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].DomainName");
				dataItem.CreateTime = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].CreateTime");
				dataItem.OverallStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].OverallStatus");

				ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Verification verification = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Verification();
				verification.VerificationStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Verification.VerificationStatus");
				verification.ErrorMsg = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Verification.ErrorMsg");
				verification.VerificationStatusCode = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Verification.VerificationStatusCode");

				ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Verification.ListAppInstanceDomains_DnsRecord dnsRecord = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Verification.ListAppInstanceDomains_DnsRecord();
				dnsRecord.RecordType = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Verification.DnsRecord.RecordType");
				dnsRecord.Host = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Verification.DnsRecord.Host");
				dnsRecord._Value = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Verification.DnsRecord.Value");
				verification.DnsRecord = dnsRecord;
				dataItem.Verification = verification;

				ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Resolution resolution = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Resolution();
				resolution.ResolutionStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Resolution.ResolutionStatus");
				resolution.ErrorMsg = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Resolution.ErrorMsg");

				ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Resolution.ListAppInstanceDomains_DnsRecord1 dnsRecord1 = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Resolution.ListAppInstanceDomains_DnsRecord1();
				dnsRecord1.RecordType = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Resolution.DnsRecord.RecordType");
				dnsRecord1.Host = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Resolution.DnsRecord.Host");
				dnsRecord1._Value = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Resolution.DnsRecord.Value");
				resolution.DnsRecord1 = dnsRecord1;
				dataItem.Resolution = resolution;

				ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Certificate certificate = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Certificate();
				certificate.CertificateStatus = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Certificate.CertificateStatus");
				certificate.CertificateType = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Certificate.CertificateType");
				certificate.CertificateName = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Certificate.CertificateName");
				certificate.EndTime = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Certificate.EndTime");
				dataItem.Certificate = certificate;

				ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Ownership ownership = new ListAppInstanceDomainsResponse.ListAppInstanceDomains_Module.ListAppInstanceDomains_DataItem.ListAppInstanceDomains_Ownership();
				ownership.Account = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Ownership.Account");
				ownership.Provider = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Ownership.Provider");
				ownership.RootDomain = _ctx.StringValue("ListAppInstanceDomains.Module.Data["+ i +"].Ownership.RootDomain");
				dataItem.Ownership = ownership;

				module_data.Add(dataItem);
			}
			module.Data = module_data;
			listAppInstanceDomainsResponse.Module = module;
        
			return listAppInstanceDomainsResponse;
        }
    }
}
