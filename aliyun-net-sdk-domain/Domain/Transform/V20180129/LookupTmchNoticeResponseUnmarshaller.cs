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
    public class LookupTmchNoticeResponseUnmarshaller
    {
        public static LookupTmchNoticeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LookupTmchNoticeResponse lookupTmchNoticeResponse = new LookupTmchNoticeResponse();

			lookupTmchNoticeResponse.HttpResponse = _ctx.HttpResponse;
			lookupTmchNoticeResponse.RequestId = _ctx.StringValue("LookupTmchNotice.RequestId");
			lookupTmchNoticeResponse.Id = _ctx.LongValue("LookupTmchNotice.Id");
			lookupTmchNoticeResponse.NotBefore = _ctx.StringValue("LookupTmchNotice.NotBefore");
			lookupTmchNoticeResponse.NotAfter = _ctx.StringValue("LookupTmchNotice.NotAfter");
			lookupTmchNoticeResponse.Label = _ctx.StringValue("LookupTmchNotice.Label");

			List<LookupTmchNoticeResponse.LookupTmchNotice_Claim> lookupTmchNoticeResponse_claims = new List<LookupTmchNoticeResponse.LookupTmchNotice_Claim>();
			for (int i = 0; i < _ctx.Length("LookupTmchNotice.Claims.Length"); i++) {
				LookupTmchNoticeResponse.LookupTmchNotice_Claim claim = new LookupTmchNoticeResponse.LookupTmchNotice_Claim();
				claim.MarkName = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].MarkName");
				claim.GoodsAndServices = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].GoodsAndServices");

				LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_JurDesc jurDesc = new LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_JurDesc();
				jurDesc.JurCC = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].JurDesc.JurCC");
				jurDesc.Desc = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].JurDesc.Desc");
				claim.JurDesc = jurDesc;

				List<LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Holder> claim_holders = new List<LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Holder>();
				for (int j = 0; j < _ctx.Length("LookupTmchNotice.Claims["+ i +"].Holders.Length"); j++) {
					LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Holder holder = new LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Holder();
					holder.Entitlement = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Entitlement");
					holder.Org = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Org");

					LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Holder.LookupTmchNotice_Addr addr = new LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Holder.LookupTmchNotice_Addr();
					addr.City = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Addr.City");
					addr.Sp = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Addr.Sp");
					addr.Pc = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Addr.Pc");
					addr.Cc = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Addr.Cc");

					List<string> addr_street = new List<string>();
					for (int k = 0; k < _ctx.Length("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Addr.Street.Length"); k++) {
						addr_street.Add(_ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Holders["+ j +"].Addr.Street["+ k +"]"));
					}
					addr.Street = addr_street;
					holder.Addr = addr;

					claim_holders.Add(holder);
				}
				claim.Holders = claim_holders;

				List<LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Contact> claim_contacts = new List<LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Contact>();
				for (int j = 0; j < _ctx.Length("LookupTmchNotice.Claims["+ i +"].Contacts.Length"); j++) {
					LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Contact contact = new LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Contact();
					contact.Type = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Type");
					contact.Name = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Name");
					contact.Org = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Org");
					contact.Voice = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Voice");
					contact.Fax = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Fax");
					contact.Email = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Email");

					LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Contact.LookupTmchNotice_Addr1 addr1 = new LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_Contact.LookupTmchNotice_Addr1();
					addr1.City = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Addr.City");
					addr1.Sp = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Addr.Sp");
					addr1.Pc = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Addr.Pc");
					addr1.Cc = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Addr.Cc");

					List<string> addr1_street2 = new List<string>();
					for (int k = 0; k < _ctx.Length("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Addr.Street.Length"); k++) {
						addr1_street2.Add(_ctx.StringValue("LookupTmchNotice.Claims["+ i +"].Contacts["+ j +"].Addr.Street["+ k +"]"));
					}
					addr1.Street2 = addr1_street2;
					contact.Addr1 = addr1;

					claim_contacts.Add(contact);
				}
				claim.Contacts = claim_contacts;

				List<LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_ClassDesc> claim_classDescs = new List<LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_ClassDesc>();
				for (int j = 0; j < _ctx.Length("LookupTmchNotice.Claims["+ i +"].ClassDescs.Length"); j++) {
					LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_ClassDesc classDesc = new LookupTmchNoticeResponse.LookupTmchNotice_Claim.LookupTmchNotice_ClassDesc();
					classDesc.ClassNum = _ctx.IntegerValue("LookupTmchNotice.Claims["+ i +"].ClassDescs["+ j +"].ClassNum");
					classDesc.Desc = _ctx.StringValue("LookupTmchNotice.Claims["+ i +"].ClassDescs["+ j +"].Desc");

					claim_classDescs.Add(classDesc);
				}
				claim.ClassDescs = claim_classDescs;

				lookupTmchNoticeResponse_claims.Add(claim);
			}
			lookupTmchNoticeResponse.Claims = lookupTmchNoticeResponse_claims;
        
			return lookupTmchNoticeResponse;
        }
    }
}
