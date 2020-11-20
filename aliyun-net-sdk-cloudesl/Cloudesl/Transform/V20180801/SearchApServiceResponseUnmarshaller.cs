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
using Aliyun.Acs.cloudesl.Model.V20180801;

namespace Aliyun.Acs.cloudesl.Transform.V20180801
{
    public class SearchApServiceResponseUnmarshaller
    {
        public static SearchApServiceResponse Unmarshall(UnmarshallerContext context)
        {
			SearchApServiceResponse searchApServiceResponse = new SearchApServiceResponse();

			searchApServiceResponse.HttpResponse = context.HttpResponse;
			searchApServiceResponse.RequestId = context.StringValue("SearchApService.RequestId");
			searchApServiceResponse.Success = context.BooleanValue("SearchApService.Success");
			searchApServiceResponse.Message = context.StringValue("SearchApService.Message");
			searchApServiceResponse.ErrorCode = context.StringValue("SearchApService.ErrorCode");
			searchApServiceResponse.TotalCount = context.IntegerValue("SearchApService.TotalCount");
			searchApServiceResponse.PageNumber = context.IntegerValue("SearchApService.PageNumber");
			searchApServiceResponse.PageSize = context.IntegerValue("SearchApService.PageSize");

			List<SearchApServiceResponse.SearchApService_ApInfo> searchApServiceResponse_items = new List<SearchApServiceResponse.SearchApService_ApInfo>();
			for (int i = 0; i < context.Length("SearchApService.Items.Length"); i++) {
				SearchApServiceResponse.SearchApService_ApInfo apInfo = new SearchApServiceResponse.SearchApService_ApInfo();
				apInfo.IsActivate = context.BooleanValue("SearchApService.Items["+ i +"].IsActivate");
				apInfo.Mac = context.StringValue("SearchApService.Items["+ i +"].Mac");
				apInfo.Model = context.StringValue("SearchApService.Items["+ i +"].Model");
				apInfo.Status = context.BooleanValue("SearchApService.Items["+ i +"].Status");

				searchApServiceResponse_items.Add(apInfo);
			}
			searchApServiceResponse.Items = searchApServiceResponse_items;
        
			return searchApServiceResponse;
        }
    }
}
