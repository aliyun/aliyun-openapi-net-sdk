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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListAlertContactsResponseUnmarshaller
    {
        public static ListAlertContactsResponse Unmarshall(UnmarshallerContext context)
        {
			ListAlertContactsResponse listAlertContactsResponse = new ListAlertContactsResponse();

			listAlertContactsResponse.HttpResponse = context.HttpResponse;

			List<ListAlertContactsResponse.ListAlertContacts_AlertContact> listAlertContactsResponse_alertContactList = new List<ListAlertContactsResponse.ListAlertContacts_AlertContact>();
			for (int i = 0; i < context.Length("ListAlertContacts.AlertContactList.Length"); i++) {
				ListAlertContactsResponse.ListAlertContacts_AlertContact alertContact = new ListAlertContactsResponse.ListAlertContacts_AlertContact();
				alertContact.Id = context.LongValue("ListAlertContacts.AlertContactList["+ i +"].Id");
				alertContact.GmtCreate = context.StringValue("ListAlertContacts.AlertContactList["+ i +"].GmtCreate");
				alertContact.GmtModified = context.StringValue("ListAlertContacts.AlertContactList["+ i +"].GmtModified");
				alertContact.BizId = context.StringValue("ListAlertContacts.AlertContactList["+ i +"].BizId");
				alertContact.Name = context.StringValue("ListAlertContacts.AlertContactList["+ i +"].Name");
				alertContact.Email = context.StringValue("ListAlertContacts.AlertContactList["+ i +"].Email");
				alertContact.PhoneNumber = context.StringValue("ListAlertContacts.AlertContactList["+ i +"].PhoneNumber");

				listAlertContactsResponse_alertContactList.Add(alertContact);
			}
			listAlertContactsResponse.AlertContactList = listAlertContactsResponse_alertContactList;
        
			return listAlertContactsResponse;
        }
    }
}
