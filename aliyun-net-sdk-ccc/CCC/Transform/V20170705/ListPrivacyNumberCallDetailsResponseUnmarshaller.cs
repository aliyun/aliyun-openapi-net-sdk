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
    public class ListPrivacyNumberCallDetailsResponseUnmarshaller
    {
        public static ListPrivacyNumberCallDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPrivacyNumberCallDetailsResponse listPrivacyNumberCallDetailsResponse = new ListPrivacyNumberCallDetailsResponse();

			listPrivacyNumberCallDetailsResponse.HttpResponse = context.HttpResponse;
			listPrivacyNumberCallDetailsResponse.RequestId = context.StringValue("ListPrivacyNumberCallDetails.RequestId");
			listPrivacyNumberCallDetailsResponse.Success = context.BooleanValue("ListPrivacyNumberCallDetails.Success");
			listPrivacyNumberCallDetailsResponse.Code = context.StringValue("ListPrivacyNumberCallDetails.Code");
			listPrivacyNumberCallDetailsResponse.Message = context.StringValue("ListPrivacyNumberCallDetails.Message");
			listPrivacyNumberCallDetailsResponse.HttpStatusCode = context.IntegerValue("ListPrivacyNumberCallDetails.HttpStatusCode");

			ListPrivacyNumberCallDetailsResponse.ListPrivacyNumberCallDetails_PrivacyNumberCallDetails privacyNumberCallDetails = new ListPrivacyNumberCallDetailsResponse.ListPrivacyNumberCallDetails_PrivacyNumberCallDetails();
			privacyNumberCallDetails.TotalCount = context.IntegerValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.TotalCount");
			privacyNumberCallDetails.PageNumber = context.IntegerValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.PageNumber");
			privacyNumberCallDetails.PageSize = context.IntegerValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.PageSize");

			List<ListPrivacyNumberCallDetailsResponse.ListPrivacyNumberCallDetails_PrivacyNumberCallDetails.ListPrivacyNumberCallDetails_PrivacyNumberCallDetail> privacyNumberCallDetails_list = new List<ListPrivacyNumberCallDetailsResponse.ListPrivacyNumberCallDetails_PrivacyNumberCallDetails.ListPrivacyNumberCallDetails_PrivacyNumberCallDetail>();
			for (int i = 0; i < context.Length("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List.Length"); i++) {
				ListPrivacyNumberCallDetailsResponse.ListPrivacyNumberCallDetails_PrivacyNumberCallDetails.ListPrivacyNumberCallDetails_PrivacyNumberCallDetail privacyNumberCallDetail = new ListPrivacyNumberCallDetailsResponse.ListPrivacyNumberCallDetails_PrivacyNumberCallDetails.ListPrivacyNumberCallDetails_PrivacyNumberCallDetail();
				privacyNumberCallDetail.AgentId = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].AgentId");
				privacyNumberCallDetail.AgentName = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].AgentName");
				privacyNumberCallDetail.ContactId = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].ContactId");
				privacyNumberCallDetail.CallingNumber = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].CallingNumber");
				privacyNumberCallDetail.CalledNumber = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].CalledNumber");
				privacyNumberCallDetail.PrivacyNumber = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].PrivacyNumber");
				privacyNumberCallDetail.ContactType = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].ContactType");
				privacyNumberCallDetail.Result = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].Result");
				privacyNumberCallDetail.Description = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].Description");
				privacyNumberCallDetail.CallTime = context.LongValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].CallTime");
				privacyNumberCallDetail.Status = context.StringValue("ListPrivacyNumberCallDetails.PrivacyNumberCallDetails.List["+ i +"].Status");

				privacyNumberCallDetails_list.Add(privacyNumberCallDetail);
			}
			privacyNumberCallDetails.List = privacyNumberCallDetails_list;
			listPrivacyNumberCallDetailsResponse.PrivacyNumberCallDetails = privacyNumberCallDetails;
        
			return listPrivacyNumberCallDetailsResponse;
        }
    }
}
