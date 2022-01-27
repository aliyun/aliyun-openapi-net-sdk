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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class ListHotlineTransferNumberResponseUnmarshaller
    {
        public static ListHotlineTransferNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListHotlineTransferNumberResponse listHotlineTransferNumberResponse = new ListHotlineTransferNumberResponse();

			listHotlineTransferNumberResponse.HttpResponse = _ctx.HttpResponse;
			listHotlineTransferNumberResponse.RequestId = _ctx.StringValue("ListHotlineTransferNumber.RequestId");
			listHotlineTransferNumberResponse.Code = _ctx.StringValue("ListHotlineTransferNumber.Code");
			listHotlineTransferNumberResponse.Message = _ctx.StringValue("ListHotlineTransferNumber.Message");

			ListHotlineTransferNumberResponse.ListHotlineTransferNumber_Data data = new ListHotlineTransferNumberResponse.ListHotlineTransferNumber_Data();
			data.Total = _ctx.LongValue("ListHotlineTransferNumber.Data.Total");
			data.PageNo = _ctx.IntegerValue("ListHotlineTransferNumber.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("ListHotlineTransferNumber.Data.PageSize");

			List<ListHotlineTransferNumberResponse.ListHotlineTransferNumber_Data.ListHotlineTransferNumber_ValuesItem> data_values = new List<ListHotlineTransferNumberResponse.ListHotlineTransferNumber_Data.ListHotlineTransferNumber_ValuesItem>();
			for (int i = 0; i < _ctx.Length("ListHotlineTransferNumber.Data.Values.Length"); i++) {
				ListHotlineTransferNumberResponse.ListHotlineTransferNumber_Data.ListHotlineTransferNumber_ValuesItem valuesItem = new ListHotlineTransferNumberResponse.ListHotlineTransferNumber_Data.ListHotlineTransferNumber_ValuesItem();
				valuesItem.QualificationId = _ctx.StringValue("ListHotlineTransferNumber.Data.Values["+ i +"].QualificationId");
				valuesItem.PhoneNumber = _ctx.StringValue("ListHotlineTransferNumber.Data.Values["+ i +"].PhoneNumber");
				valuesItem.NumberOwnerName = _ctx.StringValue("ListHotlineTransferNumber.Data.Values["+ i +"].NumberOwnerName");
				valuesItem.IdentityCard = _ctx.StringValue("ListHotlineTransferNumber.Data.Values["+ i +"].IdentityCard");
				valuesItem.ResUniqueCode = _ctx.StringValue("ListHotlineTransferNumber.Data.Values["+ i +"].ResUniqueCode");
				valuesItem.HotlineNumber = _ctx.StringValue("ListHotlineTransferNumber.Data.Values["+ i +"].HotlineNumber");

				data_values.Add(valuesItem);
			}
			data.Values = data_values;
			listHotlineTransferNumberResponse.Data = data;
        
			return listHotlineTransferNumberResponse;
        }
    }
}
