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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetCopyrightPersonListResponseUnmarshaller
    {
        public static GetCopyrightPersonListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCopyrightPersonListResponse getCopyrightPersonListResponse = new GetCopyrightPersonListResponse();

			getCopyrightPersonListResponse.HttpResponse = _ctx.HttpResponse;
			getCopyrightPersonListResponse.PageNum = _ctx.IntegerValue("GetCopyrightPersonList.PageNum");
			getCopyrightPersonListResponse.RequestId = _ctx.StringValue("GetCopyrightPersonList.RequestId");
			getCopyrightPersonListResponse.PageSize = _ctx.IntegerValue("GetCopyrightPersonList.PageSize");
			getCopyrightPersonListResponse.Success = _ctx.BooleanValue("GetCopyrightPersonList.Success");
			getCopyrightPersonListResponse.TotalItemNum = _ctx.IntegerValue("GetCopyrightPersonList.TotalItemNum");

			List<GetCopyrightPersonListResponse.GetCopyrightPersonList_DataItem> getCopyrightPersonListResponse_data = new List<GetCopyrightPersonListResponse.GetCopyrightPersonList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetCopyrightPersonList.Data.Length"); i++) {
				GetCopyrightPersonListResponse.GetCopyrightPersonList_DataItem dataItem = new GetCopyrightPersonListResponse.GetCopyrightPersonList_DataItem();
				dataItem.LegalPersonType = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].LegalPersonType");
				dataItem.RoleType = _ctx.IntegerValue("GetCopyrightPersonList.Data["+ i +"].RoleType");
				dataItem.City = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].City");
				dataItem.UseType = _ctx.IntegerValue("GetCopyrightPersonList.Data["+ i +"].UseType");
				dataItem.Phone = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].Phone");
				dataItem.County = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].County");
				dataItem.UserPk = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].UserPk");
				dataItem.CardType = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].CardType");
				dataItem.Email = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].Email");
				dataItem.ExpiredDate = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].ExpiredDate");
				dataItem.CardNum = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].CardNum");
				dataItem.Address = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].Address");
				dataItem.OwnerType = _ctx.IntegerValue("GetCopyrightPersonList.Data["+ i +"].OwnerType");
				dataItem.Name = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].Name");
				dataItem.PersonId = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].PersonId");
				dataItem.AuditStatus = _ctx.IntegerValue("GetCopyrightPersonList.Data["+ i +"].AuditStatus");
				dataItem.Province = _ctx.StringValue("GetCopyrightPersonList.Data["+ i +"].Province");

				getCopyrightPersonListResponse_data.Add(dataItem);
			}
			getCopyrightPersonListResponse.Data = getCopyrightPersonListResponse_data;
        
			return getCopyrightPersonListResponse;
        }
    }
}
