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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class ListPersonByImageResponseUnmarshaller
    {
        public static ListPersonByImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonByImageResponse listPersonByImageResponse = new ListPersonByImageResponse();

			listPersonByImageResponse.HttpResponse = _ctx.HttpResponse;
			listPersonByImageResponse.ErrorCode = _ctx.StringValue("ListPersonByImage.ErrorCode");
			listPersonByImageResponse.ErrorMessage = _ctx.StringValue("ListPersonByImage.ErrorMessage");
			listPersonByImageResponse.Message = _ctx.StringValue("ListPersonByImage.Message");
			listPersonByImageResponse.Code = _ctx.StringValue("ListPersonByImage.Code");
			listPersonByImageResponse.DynamicCode = _ctx.StringValue("ListPersonByImage.DynamicCode");
			listPersonByImageResponse.RequestId = _ctx.StringValue("ListPersonByImage.RequestId");
			listPersonByImageResponse.Success = _ctx.BooleanValue("ListPersonByImage.Success");
			listPersonByImageResponse.DynamicMessage = _ctx.StringValue("ListPersonByImage.DynamicMessage");

			List<ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem> listPersonByImageResponse_personSearchResultItems = new List<ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem>();
			for (int i = 0; i < _ctx.Length("ListPersonByImage.PersonSearchResultItems.Length"); i++) {
				ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem personSearchResultItem = new ListPersonByImageResponse.ListPersonByImage_PersonSearchResultItem();
				personSearchResultItem.UkId = _ctx.LongValue("ListPersonByImage.PersonSearchResultItems["+ i +"].UkId");
				personSearchResultItem.Score = _ctx.FloatValue("ListPersonByImage.PersonSearchResultItems["+ i +"].Score");

				listPersonByImageResponse_personSearchResultItems.Add(personSearchResultItem);
			}
			listPersonByImageResponse.PersonSearchResultItems = listPersonByImageResponse_personSearchResultItems;
        
			return listPersonByImageResponse;
        }
    }
}
