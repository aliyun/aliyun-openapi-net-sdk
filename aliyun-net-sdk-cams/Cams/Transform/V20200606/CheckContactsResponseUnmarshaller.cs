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
using Aliyun.Acs.cams.Model.V20200606;

namespace Aliyun.Acs.cams.Transform.V20200606
{
    public class CheckContactsResponseUnmarshaller
    {
        public static CheckContactsResponse Unmarshall(UnmarshallerContext context)
        {
			CheckContactsResponse checkContactsResponse = new CheckContactsResponse();

			checkContactsResponse.HttpResponse = context.HttpResponse;
			checkContactsResponse.RequestId = context.StringValue("CheckContacts.RequestId");
			checkContactsResponse.ResultCode = context.StringValue("CheckContacts.ResultCode");
			checkContactsResponse.ResultMessage = context.StringValue("CheckContacts.ResultMessage");

			List<CheckContactsResponse.CheckContacts_ContactStatus> checkContactsResponse_contacts = new List<CheckContactsResponse.CheckContacts_ContactStatus>();
			for (int i = 0; i < context.Length("CheckContacts.Contacts.Length"); i++) {
				CheckContactsResponse.CheckContacts_ContactStatus contactStatus = new CheckContactsResponse.CheckContacts_ContactStatus();
				contactStatus.PhoneNumber = context.StringValue("CheckContacts.Contacts["+ i +"].PhoneNumber");
				contactStatus.Status = context.StringValue("CheckContacts.Contacts["+ i +"].Status");

				checkContactsResponse_contacts.Add(contactStatus);
			}
			checkContactsResponse.Contacts = checkContactsResponse_contacts;
        
			return checkContactsResponse;
        }
    }
}
