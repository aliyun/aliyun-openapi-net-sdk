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
    public class QueryInvoicingCustomerListResponseUnmarshaller
    {
        public static QueryInvoicingCustomerListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryInvoicingCustomerListResponse queryInvoicingCustomerListResponse = new QueryInvoicingCustomerListResponse();

			queryInvoicingCustomerListResponse.HttpResponse = _ctx.HttpResponse;
			queryInvoicingCustomerListResponse.Code = _ctx.StringValue("QueryInvoicingCustomerList.Code");
			queryInvoicingCustomerListResponse.Message = _ctx.StringValue("QueryInvoicingCustomerList.Message");
			queryInvoicingCustomerListResponse.RequestId = _ctx.StringValue("QueryInvoicingCustomerList.RequestId");
			queryInvoicingCustomerListResponse.Success = _ctx.BooleanValue("QueryInvoicingCustomerList.Success");

			QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data data = new QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data();

			List<QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice> data_customerInvoiceList = new List<QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice>();
			for (int i = 0; i < _ctx.Length("QueryInvoicingCustomerList.Data.CustomerInvoiceList.Length"); i++) {
				QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice customerInvoice = new QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice();
				customerInvoice.Type = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Type");
				customerInvoice.Status = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Status");
				customerInvoice.AdjustType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].AdjustType");
				customerInvoice.Bank = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Bank");
				customerInvoice.StartCycle = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].StartCycle");
				customerInvoice.TitleChangeInstructions = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TitleChangeInstructions");
				customerInvoice.UserId = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].UserId");
				customerInvoice.OperatingLicenseAddress = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].OperatingLicenseAddress");
				customerInvoice.InvoiceTitle = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].InvoiceTitle");
				customerInvoice.UserNick = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].UserNick");
				customerInvoice.OperatingLicensePhone = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].OperatingLicensePhone");
				customerInvoice.EndCycle = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].EndCycle");
				customerInvoice.DefaultRemark = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].DefaultRemark");
				customerInvoice.TaxationLicense = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TaxationLicense");
				customerInvoice.RegisterNo = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].RegisterNo");
				customerInvoice.GmtCreate = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].GmtCreate");
				customerInvoice.TaxpayerType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TaxpayerType");
				customerInvoice.CustomerType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].CustomerType");
				customerInvoice.IssueType = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].IssueType");
				customerInvoice.Id = _ctx.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Id");
				customerInvoice.BankNo = _ctx.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].BankNo");

				data_customerInvoiceList.Add(customerInvoice);
			}
			data.CustomerInvoiceList = data_customerInvoiceList;
			queryInvoicingCustomerListResponse.Data = data;
        
			return queryInvoicingCustomerListResponse;
        }
    }
}
