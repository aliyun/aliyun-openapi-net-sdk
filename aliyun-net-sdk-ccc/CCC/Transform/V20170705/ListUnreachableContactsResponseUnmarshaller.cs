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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListUnreachableContactsResponseUnmarshaller
    {
        public static ListUnreachableContactsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUnreachableContactsResponse listUnreachableContactsResponse = new ListUnreachableContactsResponse();

			listUnreachableContactsResponse.HttpResponse = _ctx.HttpResponse;
			listUnreachableContactsResponse.RequestId = _ctx.StringValue("ListUnreachableContacts.RequestId");
			listUnreachableContactsResponse.Success = _ctx.BooleanValue("ListUnreachableContacts.Success");
			listUnreachableContactsResponse.Code = _ctx.StringValue("ListUnreachableContacts.Code");
			listUnreachableContactsResponse.Message = _ctx.StringValue("ListUnreachableContacts.Message");
			listUnreachableContactsResponse.HttpStatusCode = _ctx.IntegerValue("ListUnreachableContacts.HttpStatusCode");

			ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts unreachableContacts = new ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts();
			unreachableContacts.TotalCount = _ctx.IntegerValue("ListUnreachableContacts.UnreachableContacts.TotalCount");
			unreachableContacts.PageNumber = _ctx.IntegerValue("ListUnreachableContacts.UnreachableContacts.PageNumber");
			unreachableContacts.PageSize = _ctx.IntegerValue("ListUnreachableContacts.UnreachableContacts.PageSize");

			List<ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact> unreachableContacts_list = new List<ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact>();
			for (int i = 0; i < _ctx.Length("ListUnreachableContacts.UnreachableContacts.List.Length"); i++) {
				ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact unreachableContact = new ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact();
				unreachableContact.TotalAttempts = _ctx.IntegerValue("ListUnreachableContacts.UnreachableContacts.List["+ i +"].TotalAttempts");

				List<ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact.ListUnreachableContacts_Contact> unreachableContact_contacts = new List<ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact.ListUnreachableContacts_Contact>();
				for (int j = 0; j < _ctx.Length("ListUnreachableContacts.UnreachableContacts.List["+ i +"].Contacts.Length"); j++) {
					ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact.ListUnreachableContacts_Contact contact = new ListUnreachableContactsResponse.ListUnreachableContacts_UnreachableContacts.ListUnreachableContacts_UnreachableContact.ListUnreachableContacts_Contact();
					contact.ContactId = _ctx.StringValue("ListUnreachableContacts.UnreachableContacts.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = _ctx.StringValue("ListUnreachableContacts.UnreachableContacts.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Role = _ctx.StringValue("ListUnreachableContacts.UnreachableContacts.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = _ctx.StringValue("ListUnreachableContacts.UnreachableContacts.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = _ctx.StringValue("ListUnreachableContacts.UnreachableContacts.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = _ctx.StringValue("ListUnreachableContacts.UnreachableContacts.List["+ i +"].Contacts["+ j +"].ReferenceId");

					unreachableContact_contacts.Add(contact);
				}
				unreachableContact.Contacts = unreachableContact_contacts;

				unreachableContacts_list.Add(unreachableContact);
			}
			unreachableContacts.List = unreachableContacts_list;
			listUnreachableContactsResponse.UnreachableContacts = unreachableContacts;
        
			return listUnreachableContactsResponse;
        }
    }
}
