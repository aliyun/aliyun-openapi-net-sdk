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
using Aliyun.Acs.ARMS.Model.V20190808;

namespace Aliyun.Acs.ARMS.Transform.V20190808
{
    public class SearchAlertContactResponseUnmarshaller
    {
        public static SearchAlertContactResponse Unmarshall(UnmarshallerContext context)
        {
			SearchAlertContactResponse searchAlertContactResponse = new SearchAlertContactResponse();

			searchAlertContactResponse.HttpResponse = context.HttpResponse;
			searchAlertContactResponse.RequestId = context.StringValue("SearchAlertContact.RequestId");

			SearchAlertContactResponse.SearchAlertContact_PageBean pageBean = new SearchAlertContactResponse.SearchAlertContact_PageBean();
			pageBean.TotalCount = context.IntegerValue("SearchAlertContact.PageBean.TotalCount");
			pageBean.PageNumber = context.IntegerValue("SearchAlertContact.PageBean.PageNumber");
			pageBean.PageSize = context.IntegerValue("SearchAlertContact.PageBean.PageSize");

			List<SearchAlertContactResponse.SearchAlertContact_PageBean.SearchAlertContact_Contact> pageBean_contacts = new List<SearchAlertContactResponse.SearchAlertContact_PageBean.SearchAlertContact_Contact>();
			for (int i = 0; i < context.Length("SearchAlertContact.PageBean.Contacts.Length"); i++) {
				SearchAlertContactResponse.SearchAlertContact_PageBean.SearchAlertContact_Contact contact = new SearchAlertContactResponse.SearchAlertContact_PageBean.SearchAlertContact_Contact();
				contact.ContactId = context.LongValue("SearchAlertContact.PageBean.Contacts["+ i +"].ContactId");
				contact.ContactName = context.StringValue("SearchAlertContact.PageBean.Contacts["+ i +"].ContactName");
				contact.Phone = context.StringValue("SearchAlertContact.PageBean.Contacts["+ i +"].Phone");
				contact.Email = context.StringValue("SearchAlertContact.PageBean.Contacts["+ i +"].Email");
				contact.UserId = context.StringValue("SearchAlertContact.PageBean.Contacts["+ i +"].UserId");
				contact.DingRobot = context.StringValue("SearchAlertContact.PageBean.Contacts["+ i +"].DingRobot");
				contact.CreateTime = context.LongValue("SearchAlertContact.PageBean.Contacts["+ i +"].CreateTime");
				contact.UpdateTime = context.LongValue("SearchAlertContact.PageBean.Contacts["+ i +"].UpdateTime");
				contact.SystemNoc = context.BooleanValue("SearchAlertContact.PageBean.Contacts["+ i +"].SystemNoc");

				pageBean_contacts.Add(contact);
			}
			pageBean.Contacts = pageBean_contacts;
			searchAlertContactResponse.PageBean = pageBean;
        
			return searchAlertContactResponse;
        }
    }
}
