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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryCustomerAddressListResponseUnmarshaller
    {
        public static QueryCustomerAddressListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCustomerAddressListResponse queryCustomerAddressListResponse = new QueryCustomerAddressListResponse();

			queryCustomerAddressListResponse.HttpResponse = _ctx.HttpResponse;
			queryCustomerAddressListResponse.RequestId = _ctx.StringValue("QueryCustomerAddressList.RequestId");
			queryCustomerAddressListResponse.Success = _ctx.BooleanValue("QueryCustomerAddressList.Success");
			queryCustomerAddressListResponse.Code = _ctx.StringValue("QueryCustomerAddressList.Code");
			queryCustomerAddressListResponse.Message = _ctx.StringValue("QueryCustomerAddressList.Message");

			QueryCustomerAddressListResponse.QueryCustomerAddressList_Data data = new QueryCustomerAddressListResponse.QueryCustomerAddressList_Data();

			List<QueryCustomerAddressListResponse.QueryCustomerAddressList_Data.QueryCustomerAddressList_CustomerInvoiceAddress> data_customerInvoiceAddressList = new List<QueryCustomerAddressListResponse.QueryCustomerAddressList_Data.QueryCustomerAddressList_CustomerInvoiceAddress>();
			for (int i = 0; i < _ctx.Length("QueryCustomerAddressList.Data.CustomerInvoiceAddressList.Length"); i++) {
				QueryCustomerAddressListResponse.QueryCustomerAddressList_Data.QueryCustomerAddressList_CustomerInvoiceAddress customerInvoiceAddress = new QueryCustomerAddressListResponse.QueryCustomerAddressList_Data.QueryCustomerAddressList_CustomerInvoiceAddress();
				customerInvoiceAddress.Id = _ctx.LongValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].Id");
				customerInvoiceAddress.UserId = _ctx.LongValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].UserId");
				customerInvoiceAddress.UserNick = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].UserNick");
				customerInvoiceAddress.Addressee = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].Addressee");
				customerInvoiceAddress.Province = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].Province");
				customerInvoiceAddress.City = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].City");
				customerInvoiceAddress.County = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].County");
				customerInvoiceAddress.Street = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].Street");
				customerInvoiceAddress.PostalCode = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].PostalCode");
				customerInvoiceAddress.Phone = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].Phone");
				customerInvoiceAddress.BizType = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].BizType");
				customerInvoiceAddress.DeliveryAddress = _ctx.StringValue("QueryCustomerAddressList.Data.CustomerInvoiceAddressList["+ i +"].DeliveryAddress");

				data_customerInvoiceAddressList.Add(customerInvoiceAddress);
			}
			data.CustomerInvoiceAddressList = data_customerInvoiceAddressList;
			queryCustomerAddressListResponse.Data = data;
        
			return queryCustomerAddressListResponse;
        }
    }
}
