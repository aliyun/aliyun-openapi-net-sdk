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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class ListPersonByImageResponseUnmarshaller
    {
        public static ListPersonByImageResponse Unmarshall(UnmarshallerContext context)
        {
			ListPersonByImageResponse listPersonByImageResponse = new ListPersonByImageResponse();

			listPersonByImageResponse.HttpResponse = context.HttpResponse;
			listPersonByImageResponse.ErrorCode = context.StringValue("ListPersonByImage.ErrorCode");
			listPersonByImageResponse.ErrorMessage = context.StringValue("ListPersonByImage.ErrorMessage");
			listPersonByImageResponse.RequestId = context.StringValue("ListPersonByImage.RequestId");
			listPersonByImageResponse.Success = context.BooleanValue("ListPersonByImage.Success");

			List<ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem> listPersonByImageResponse_personSearchResultItems = new List<ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem>();
			for (int i = 0; i < context.Length("ListPersonByImage.PersonSearchResultItems.Length"); i++) {
				ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem personSearchResultItem = new ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem();
				personSearchResultItem.UkId = context.LongValue("ListPersonByImage.PersonSearchResultItems["+ i +"].UkId");
				personSearchResultItem.Score = context.FloatValue("ListPersonByImage.PersonSearchResultItems["+ i +"].Score");

				listPersonByImageResponse_personSearchResultItems.Add(personSearchResultItem);
			}
			listPersonByImageResponse.PersonSearchResultItems = listPersonByImageResponse_personSearchResultItems;
        
			return listPersonByImageResponse;
        }
    }
}
