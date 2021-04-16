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
    public class ListSpecialPersonnelByImageResponseUnmarshaller
    {
        public static ListSpecialPersonnelByImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSpecialPersonnelByImageResponse listSpecialPersonnelByImageResponse = new ListSpecialPersonnelByImageResponse();

			listSpecialPersonnelByImageResponse.HttpResponse = _ctx.HttpResponse;
			listSpecialPersonnelByImageResponse.Message = _ctx.StringValue("ListSpecialPersonnelByImage.Message");
			listSpecialPersonnelByImageResponse.RequestId = _ctx.StringValue("ListSpecialPersonnelByImage.RequestId");
			listSpecialPersonnelByImageResponse.DynamicCode = _ctx.StringValue("ListSpecialPersonnelByImage.DynamicCode");
			listSpecialPersonnelByImageResponse.DynamicMessage = _ctx.StringValue("ListSpecialPersonnelByImage.DynamicMessage");
			listSpecialPersonnelByImageResponse.ErrorCode = _ctx.StringValue("ListSpecialPersonnelByImage.ErrorCode");
			listSpecialPersonnelByImageResponse.ErrorMessage = _ctx.StringValue("ListSpecialPersonnelByImage.ErrorMessage");
			listSpecialPersonnelByImageResponse.Code = _ctx.StringValue("ListSpecialPersonnelByImage.Code");
			listSpecialPersonnelByImageResponse.Success = _ctx.BooleanValue("ListSpecialPersonnelByImage.Success");

			List<ListSpecialPersonnelByImageResponse.ListSpecialPersonnelByImage_ListPersonResultItem> listSpecialPersonnelByImageResponse_listPersonResultItems = new List<ListSpecialPersonnelByImageResponse.ListSpecialPersonnelByImage_ListPersonResultItem>();
			for (int i = 0; i < _ctx.Length("ListSpecialPersonnelByImage.ListPersonResultItems.Length"); i++) {
				ListSpecialPersonnelByImageResponse.ListSpecialPersonnelByImage_ListPersonResultItem listPersonResultItem = new ListSpecialPersonnelByImageResponse.ListSpecialPersonnelByImage_ListPersonResultItem();
				listPersonResultItem.Score = _ctx.FloatValue("ListSpecialPersonnelByImage.ListPersonResultItems["+ i +"].Score");
				listPersonResultItem.UkId = _ctx.LongValue("ListSpecialPersonnelByImage.ListPersonResultItems["+ i +"].UkId");

				listSpecialPersonnelByImageResponse_listPersonResultItems.Add(listPersonResultItem);
			}
			listSpecialPersonnelByImageResponse.ListPersonResultItems = listSpecialPersonnelByImageResponse_listPersonResultItems;
        
			return listSpecialPersonnelByImageResponse;
        }
    }
}
